using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using OctoHome.Client.Services.Interfaces;
using OctoHome.Shared.DTOs.Hue;

namespace OctoHome.Client.Services
{
    public class PhilipsHueService : IPhilipsHueService
    {
        private readonly HttpClient _httpClient;

        public PhilipsHueService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HueLight[]> GetLights()
        {
            return await _httpClient.GetFromJsonAsync<HueLight[]>("api/hue/lights");
        }

        public async Task SwitchLightOn(HueLight light)
        {
            await _httpClient.PutAsync($"api/hue/light/{light.Id}/turn/on", null);
        }

        public async Task SwitchLightOff(HueLight light)
        {
            await _httpClient.PutAsync($"api/hue/light/{light.Id}/turn/off", null);
        }

        public async Task<HueGroup[]> GetGroups()
        {
            return await _httpClient.GetFromJsonAsync<HueGroup[]>("api/hue/groups");
        }
    }
}