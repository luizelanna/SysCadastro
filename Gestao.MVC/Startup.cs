﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gestao.MVC.Startup))]
namespace Gestao.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
