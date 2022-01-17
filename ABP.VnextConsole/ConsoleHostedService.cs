using ABP.VnextConsole.Common;
using ABP.VnextConsole.Plugin;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ABP.VnextConsole
{
    /// <summary>
    /// 主机服务—ConsoleHostedService
    /// </summary>
    /// 第二种：新方法注入 /*: ITransientDependency (继承接口)*/
    /// 第三种：新方法注入 /*: [Dependency(ServiceLifetime.Transient)] (特性表示)*/
    public class ConsoleHostedService : IHostedService
    {
        private readonly HelloWorldService _helloWorldService;
        public CommonService _commonService {get;set;}
        public PluginService _pluginService { get; set; }
        public ConsoleHostedService(HelloWorldService helloWorldService)
        {
            _helloWorldService = helloWorldService;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _helloWorldService.SayHelloWorld();
            _commonService.CommonServiceStr();
            _pluginService.Plugin();
            //cancellationToken.Common();
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("stop");
            return Task.CompletedTask;
        }
    }
}
