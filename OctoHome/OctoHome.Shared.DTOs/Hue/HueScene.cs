using System;

namespace OctoHome.Shared.DTOs.Hue
{
    public class HueScene
    {
        public string Id { get; }
        public string Name { get; }
        public string[] Lights { get; }
        public string Owner { get; }
        public string Picture { get; }
        public bool? Recycle { get; }
        public bool? Locked { get; }
        public int? Version { get; }
        public DateTime? LastUpdated { get; }
        public bool? StoreLightState { get; }
        public TimeSpan? TransitionTime { get; }
        public string Group { get; }

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