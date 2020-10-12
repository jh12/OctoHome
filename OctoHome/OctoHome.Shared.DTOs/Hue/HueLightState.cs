using System;

namespace OctoHome.Shared.DTOs.Hue
{
    public class HueLightState
    {
        public bool On { get; }
        public byte Brightness { get; }
        public int? Hue { get; }
        public int? Saturation { get; }
        public double[] ColorCoordinates { get; }
        public int? ColorTemperature { get; }
        public HueAlert? Alert { get; }
        public HueEffect? Effect { get; }
        public string ColorMode { get; }
        public bool? IsReachable { get; }
        public TimeSpan? TransitionTime { get; }
        public string Mode { get; }

        public HueLightState(bool on, byte brightness, int? hue, int? saturation, double[] colorCoordinates, int? colorTemperature, HueAlert? alert, HueEffect? effect, string colorMode, bool? isReachable, TimeSpan? transitionTime, string mode)
        {
            On = on;
            Brightness = brightness;
            Hue = hue;
            Saturation = saturation;
            ColorCoordinates = colorCoordinates;
            ColorTemperature = colorTemperature;
            Alert = alert;
            Effect = effect;
            ColorMode = colorMode;
            IsReachable = isReachable;
            TransitionTime = transitionTime;
            Mode = mode;
        }
    }
}