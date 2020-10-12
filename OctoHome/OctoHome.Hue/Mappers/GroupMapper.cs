using OctoHome.Shared.DTOs.Hue;
using Q42.HueApi.Models.Groups;

namespace OctoHome.Hue.Mappers
{
    internal static class GroupMapper
    {
        public static HueGroup Map(Group group)
        {
            return new HueGroup(
                group.Id,
                group.Name,
                (HueGroupType?) group.Type,
                (HueRoomClass?) group.Class,
                group.ModelId,
                group.Lights.ToArray(),
                group.Recycle,
                group.Sensors.ToArray());
        }
    }
}