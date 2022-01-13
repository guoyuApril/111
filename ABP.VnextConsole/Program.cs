using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using Volo.Abp.Modularity.PlugIns;

namespace ABP.VnextConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("测试数据......");
            CreateHostBuilder(args).RunConsoleAsync().Wait();
        }
        internal static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseAutofac()
                .ConfigureAppConfiguration((context, config) =>
                {

                }).ConfigureServices((hostContext, services) =>
                {
                    //注册类到IOC容器 （老方法注册）
                    // 简单注册IOC容器
                    services.AddApplication<ConsoleMoudle>();
                    // 加载插件
                    //services.AddApplication<ConsoleMoudle>(options =>
                    //{
                    //    options.PlugInSources.AddFolder(@"");
                    //});
                })

            ;
    }
}
