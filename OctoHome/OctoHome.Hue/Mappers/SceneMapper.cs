using System.Linq;
using OctoHome.Shared.DTOs.Hue;
using Q42.HueApi.Models;

namespace OctoHome.Hue.Mappers
{
    internal static class SceneMapper
    {
        public static HueScene Map(Scene scene)
        {
            return new HueScene(
                scene.Id,
                scene.Name,
                scene.Lights.ToArray(),
                scene.Owner,
                scene.Picture,
                scene.Recycle,
                scene.Locked,
                scene.Version,
                scene.LastUpdated,
                scene.StoreLightState,
                scene.TransitionTime,
                scene.Group);
        }
    }
}