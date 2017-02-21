using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Ninject;
using System.Reflection;

[assembly: OwinStartup(typeof(AzizTic.WebUI.Startup))]

namespace AzizTic.WebUI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
        }

        private static StandardKernel CreateKarnel()
        {
            var karnel = new StandardKernel();
            karnel.Load(Assembly.GetExecutingAssembly());
            return karnel;
        }
    }
}
