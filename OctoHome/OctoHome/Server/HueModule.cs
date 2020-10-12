using Autofac;
using OctoHome.Hue.Services;
using OctoHome.Hue.Services.Interfaces;

namespace OctoHome.Server
{
    public class HueModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PhilipsHueService>()
                .As<IPhilipsHueService>()
                .SingleInstance()
                .OnActivating(args => args.Instance.InitializeAsync().Wait());
        }
    }
}