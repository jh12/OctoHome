using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OctoHome.Hue.Services.Interfaces;
using OctoHome.Shared.DTOs.Hue;

namespace OctoHome.Server.Controllers
{
    [ApiController]
    [Route("api/hue")]
    public class PhilipsHueController : ControllerBase
    {
        private readonly IPhilipsHueService _hueService;

        public PhilipsHueController(IPhilipsHueService hueService)
        {
            _hueService = hueService;
        }

        #region Light

        [HttpGet("lights")]
        public async Task<HueLight[]> GetLights(CancellationToken cancellationToken)
        {
            return await _hueService.GetLightsAsync(cancellationToken);
        }

        [HttpPut("light/{id}/turn/on")]
        public async Task<IActionResult> SwitchLightOn(string id, CancellationToken cancellationToken)
        {
            await _hueService.SwitchLights(new[] {id}, true, cancellationToken);

            return Ok();
        }

        [HttpPut("light/{id}/turn/off")]
        public async Task<IActionResult> SwitchLightOf(string id, CancellationToken cancellationToken)
        {
            await _hueService.SwitchLights(new[] {id}, false, cancellationToken);

            return Ok();
        }

        #endregion

        #region Groups

        [HttpGet("groups")]
        public async Task<HueGroup[]> GetGroups(CancellationToken cancellationToken)
        {
            return await _hueService.GetGroups(cancellationToken);
        }

        [HttpPut("group/{id}/turn/on")]
        public async Task<IActionResult> TurnOnGroup(string id, CancellationToken cancellationToken)
        {
            HueGroup hueGroup = await _hueService.GetGroup(id, cancellationToken);

            await _hueService.SwitchLights(hueGroup.LightIds, true, cancellationToken);

            return Ok();
        }

        [HttpPut("group/{id}/turn/off")]
        public async Task<IActionResult> TurnOffGroup(string id, CancellationToken cancellationToken)
        {
            HueGroup hueGroup = await _hueService.GetGroup(id, cancellationToken);

            await _hueService.SwitchLights(hueGroup.LightIds, false, cancellationToken);

            return Ok();
        }

        #endregion

        #region Scenes

        [HttpGet("scenes")]
        public async Task<HueScene[]> GetScenes(string? group, CancellationToken cancellationToken)
        {
            HueScene[] scenes = await _hueService.GetScenes(cancellationToken);

            if (group != null)
                scenes = scenes.Where(s => s.Group == group).ToArray();

            return scenes;
        }

        [HttpPut("scene/{id}/apply")]
        public async Task<IActionResult> ApplyScene(string id, CancellationToken cancellationToken)
        {
            await _hueService.ApplyScene(id, cancellationToken);

            return Ok();
        }

        #endregion
    }
}