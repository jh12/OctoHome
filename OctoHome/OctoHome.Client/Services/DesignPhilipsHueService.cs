using System.Threading.Tasks;
using OctoHome.Client.Services.Interfaces;
using OctoHome.Shared.DTOs.Hue;

namespace OctoHome.Client.Services
{
    public class DesignPhilipsHueService : IPhilipsHueService
    {
        public async Task<HueLight[]> GetLights()
        {
            return new[]
            {
                new HueLight
                {
                    Id = "1",
                    Name = "Living room",
                    State = new HueLightState
                    {
                        On = true
                    }
                },
                new HueLight
                {
                    Id = "2",
                    Name = "Living room - sofa",
                    State = new HueLightState
                    {
                        On = true
                    }
                },
                new HueLight
                {
                    Id = "3",
                    Name = "Kitchen",
                    State = new HueLightState
                    {
                        On = false
                    }
                },
                new HueLight
                {
                    Id = "4",
                    Name = "Bed room",
                    State = new HueLightState
                    {
                        On = true
                    }
                }
            };
        }

        public Task SwitchLightOn(HueLight light)
        {
            return Task.CompletedTask;
        }

        public Task SwitchLightOff(HueLight light)
        {
            return Task.CompletedTask;
        }

        public async Task<HueGroup[]> GetGroups()
        {
            return new[]
            {
                new HueGroup
                {
                    Id = "1",
                    Name = "Living room",
                    GroupType = HueGroupType.Room,
                    RoomClass = HueRoomClass.LivingRoom,
                    LightIds = new[] {"1", "2"}
                },
                new HueGroup
                {
                    Id = "2",
                    Name = "Kitchen",
                    GroupType = HueGroupType.Room,
                    RoomClass = HueRoomClass.Kitchen,
                    LightIds = new[] {"3"}
                }
            };
        }
    }
}