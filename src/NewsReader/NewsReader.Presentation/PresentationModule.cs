﻿using Autofac;
using Waf.NewsReader.Applications.Services;
using Waf.NewsReader.Applications.Views;
using Waf.NewsReader.Presentation.Services;
using Waf.NewsReader.Presentation.Views;

namespace Waf.NewsReader.Presentation
{
    public class PresentationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<App>().SingleInstance();

            builder.RegisterType<AppInfoService>().As<IAppInfoService>().SingleInstance();

            builder.RegisterType<ShellView>().As<IShellView>().AsSelf().SingleInstance();
        }
    }
}