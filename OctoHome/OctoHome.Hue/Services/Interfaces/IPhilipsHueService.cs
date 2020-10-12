using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OctoHome.Shared.DTOs.Hue;

namespace OctoHome.Hue.Services.Interfaces
{
    public interface IPhilipsHueService
    {
        Task InitializeAsync();

        Task<HueLight[]> GetLightsAsync(CancellationToken cancellationToken);
        Task SwitchLights(IEnumerable<string> ids, bool on, CancellationToken cancellation);

        Task<HueGroup[]> GetGroups(CancellationToken cancellationToken);
        Task<HueGroup> GetGroup(string id, CancellationToken cancellationToken);

        Task<HueScene[]> GetScenes(CancellationToken cancellationToken);
        Task ApplyScene(string id, CancellationToken cancellationToken);
    }
}