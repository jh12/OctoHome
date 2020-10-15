using System;

namespace OctoHome.Shared.DTOs.Hue
{
    public class HueScene
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string[] Lights { get; set; }
        public string Owner { get; set; }
        public string Picture { get; set; }
        public bool? Recycle { get; set; }
        public bool? Locked { get; set; }
        public int? Version { get; set; }
        public DateTime? LastUpdated { get; set; }
        public bool? StoreLightState { get; set; }
        public TimeSpan? TransitionTime { get; set; }
        public string Group { get; set; }

        public HueScene()
        {
            
        }

        public HueScene(string id, string name, string[] lights, string owner, string picture, bool? recycle, bool? locked, int? version, DateTime? lastUpdated, bool? storeLightState, TimeSpan? transitionTime, string group)
        {
            Id = id;
            Name = name;
            Lights = lights;
            Owner = owner;
            Picture = picture;
            Recycle = recycle;
            Locked = locked;
            Version = version;
            LastUpdated = lastUpdated;
            StoreLightState = storeLightState;
            TransitionTime = transitionTime;
            Group = group;
        }
    }
}