using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ABP.VnextConsole.Plugin
{
    [Dependency(ServiceLifetime.Transient)]
    public class PluginService
    { 
        public void Plugin() {
            Console.WriteLine("调用插件服务....");
        }
    }
}
