using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Modularity;

namespace ABP.VnextConsole.Plugin
{
    public class PluginMoudle :AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Console.WriteLine("加载插件模块....");
        }

        /// <summary>
        /// Web 项目加载只使用该方法
        /// </summary>
        /// <param name="context"></param>
        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var myService = context.ServiceProvider.GetRequiredService<PluginService>();
            myService.Plugin();
        }
    }
}
