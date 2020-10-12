using OctoHome.Shared.DTOs.Hue;
using Q42.HueApi;

namespace OctoHome.Hue.Mappers
{
    internal static class LightMapper
    {
        public static HueLight Map(Light light)
        {
            State state = light.State;

            HueLightState lightState = new HueLightState(
                state.On,
                state.Brightness,
                state.Hue,
                state.Saturation,
                state.ColorCoordinates,
                state.ColorTemperature,
                (HueAlert?)state.Alert,
                (HueEffect?)state.Effect,
                state.ColorMode,
                state.IsReachable,
                state.TransitionTime,
                state.Mode
                );

            return new HueLight(
                light.Id,
                lightState,
                light.Type,
                light.Name,
                light.ModelId,
                light.ProductId,
                light.SwConfigId,
                light.UniqueId,
                light.LuminaireUniqueId,
                light.ManufacturerName,
                light.SoftwareVersion
                );
        }
    }
}