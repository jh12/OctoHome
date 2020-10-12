namespace OctoHome.Shared.DTOs.Hue
{
    public class HueGroup
    {
        public string Id { get; }
        public string Name { get; }
        public HueGroupType? GroupType { get; }
        public HueRoomClass? RoomClass { get; }
        public string ModelId { get; }
        public string[] LightIds { get; }
        public bool? Recycle { get; }
        public string[] Sensors { get; }

        public HueGroup(string id, string name, HueGroupType? groupType, HueRoomClass? roomClass, string modelId, string[] lightIds, bool? recycle, string[] sensors)
        {
            Id = id;
            Name = name;
            GroupType = groupType;
            RoomClass = roomClass;
            ModelId = modelId;
            LightIds = lightIds;
            Recycle = recycle;
            Sensors = sensors;
        }
    }
}