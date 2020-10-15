using System;

namespace OctoHome.Shared.DTOs.Hue
{
    public class HueLightState
    {
        public bool On { get; set; }
        public byte Brightness { get; set; }
        public int? Hue { get; set; }
        public int? Saturation { get; set; }
        public double[] ColorCoordinates { get; set; }
        public int? ColorTemperature { get; set; }
        public HueAlert? Alert { get; set; }
        public HueEffect? Effect { get; set; }
        public string ColorMode { get; set; }
        public bool? IsReachable { get; set; }
        public TimeSpan? TransitionTime { get; set; }
        public string Mode { get; set; }

        public HueLightState()
        {
        }

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