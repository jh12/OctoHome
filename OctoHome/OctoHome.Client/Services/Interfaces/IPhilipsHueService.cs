using System.Threading.Tasks;
using OctoHome.Shared.DTOs.Hue;

namespace OctoHome.Client.Services.Interfaces
{
    public interface IPhilipsHueService
    {
        Task<HueLight[]> GetLights();
        Task SwitchLightOn(HueLight light);
        Task SwitchLightOff(HueLight light);

        Task<HueGroup[]> GetGroups();
    }
}