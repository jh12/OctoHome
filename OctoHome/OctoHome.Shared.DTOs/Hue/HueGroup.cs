namespace OctoHome.Shared.DTOs.Hue
{
    public class HueGroup
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public HueGroupType? GroupType { get; set; }
        public HueRoomClass? RoomClass { get; set; }
        public string ModelId { get; set; }
        public string[] LightIds { get; set; }
        public bool? Recycle { get; set; }
        public string[] Sensors { get; set; }

        public HueGroup()
        {
            
        }

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