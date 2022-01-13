using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ABP.VnextConsole
{
    /// <summary>
    /// 使用ABP Moudle
    /// </summary>
    [DependsOn(typeof(AbpAutofacModule))]
    public class ConsoleMoudle : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            //1. IOC注册自定义类
            Console.WriteLine("加载Console的ABPMoudle模块");
            //注册类到IOC容器 （新方法注册）
            //context.Services.AddSingleton<HelloWorldService>();
            context.Services.AddHostedService<ConsoleHostedService>();
        }
    }
}
