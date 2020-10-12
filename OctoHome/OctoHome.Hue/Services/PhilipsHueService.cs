using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using OctoHome.Hue.Exceptions;
using OctoHome.Hue.Mappers;
using OctoHome.Hue.Services.Interfaces;
using OctoHome.Shared.DTOs.Hue;
using Q42.HueApi;
using Q42.HueApi.Interfaces;
using Q42.HueApi.Models;
using Q42.HueApi.Models.Bridge;
using Q42.HueApi.Models.Groups;

namespace OctoHome.Hue.Services
{
    public class PhilipsHueService : IPhilipsHueService
    {
        private IHueClient _hueClient;
        private string? _appKey;

        public PhilipsHueService(IConfiguration configuration)
        {
            _appKey = configuration["Hue:AppKey"];
        }

        public async Task InitializeAsync()
        {
            List<LocatedBridge> bridges = await HueBridgeDiscovery.FastDiscoveryAsync(TimeSpan.FromSeconds(5));

            LocatedBridge locatedBridge = bridges.First();

            if(string.IsNullOrEmpty(_appKey))
                throw new NotImplementedException("Registering application is not yet implemented");

            LocalHueClient hueClient = new LocalHueClient(locatedBridge.IpAddress, _appKey);

            if (!await hueClient.CheckConnection())
            {
                throw new Exception("Could not establish connection to bridge");
            }

            _hueClient = hueClient;
        }

        #region Light

        public async Task<HueLight[]> GetLightsAsync(CancellationToken cancellationToken)
        {
            IEnumerable<Light> lights = await _hueClient.GetLightsAsync();

            return lights.Select(LightMapper.Map).ToArray();
        }

        public async Task SwitchLights(IEnumerable<string> ids, bool on, CancellationToken cancellationToken)
        {
            LightCommand onCommand = new LightCommand()
            {
                On = @on
            };

            HueResults hueResults = await _hueClient.SendCommandAsync(onCommand, ids);

            DefaultHueResult? defaultHueResult = hueResults.Errors.FirstOrDefault();

            if(defaultHueResult != null)
                throw new HueCommandException(defaultHueResult.Error.Description, HttpStatusCode.BadRequest);
        }

        #endregion

        #region Group

        public async Task<HueGroup> GetGroup(string id, CancellationToken cancellationToken)
        {
            Group? group = await _hueClient.GetGroupAsync(id);

            if(group == null)
                throw new NotFoundException(id);

            return GroupMapper.Map(group);
        }

        public async Task<HueGroup[]> GetGroups(CancellationToken cancellationToken)
        {
            IReadOnlyCollection<Group> groups = await _hueClient.GetGroupsAsync();

            return groups.Select(GroupMapper.Map).ToArray();
        }

        #endregion

        #region Scene

        public async Task<HueScene[]> GetScenes(CancellationToken cancellationToken)
        {
            IReadOnlyCollection<Scene> scenes = await _hueClient.GetScenesAsync();

            return scenes.Select(SceneMapper.Map).ToArray();
        }

        public async Task ApplyScene(string id, CancellationToken cancellationToken)
        {
            SceneCommand sceneCommand = new SceneCommand(id);

            HueResults results = await _hueClient.SendGroupCommandAsync(sceneCommand);

            DefaultHueResult? defaultHueResult = results.Errors.FirstOrDefault();

            if(defaultHueResult != null)
                throw new HueCommandException(defaultHueResult.Error.Description, HttpStatusCode.BadRequest);
        }

        #endregion
    }
}