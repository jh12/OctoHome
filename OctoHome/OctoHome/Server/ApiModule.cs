using System;
using Autofac;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Core;

namespace OctoHome.Server
{
    public class ApiModule : Module
    {
        private readonly IHostEnvironment _environment;
        private readonly IConfiguration _configuration;

        public ApiModule(IHostEnvironment environment, IConfiguration configuration)
        {
            _environment = environment;
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            RegisterLogger(builder);
        }

        private void RegisterLogger(ContainerBuilder builder)
        {
            LoggerConfiguration loggerConfiguration = new LoggerConfiguration();

            loggerConfiguration
                .Enrich.FromLogContext();

            if (_environment.IsDevelopment())
                loggerConfiguration
                    .WriteTo.Console();
            else
                throw new NotImplementedException(); // TODO

            Logger logger = loggerConfiguration.CreateLogger();
            Log.Logger = logger;

            builder.Register(f => logger).As<ILogger>().SingleInstance();
        }
    }
}