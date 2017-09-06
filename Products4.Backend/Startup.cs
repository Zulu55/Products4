using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Products4.Backend.Startup))]
namespace Products4.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
