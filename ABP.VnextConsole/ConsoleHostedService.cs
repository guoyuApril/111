using ABP.VnextConsole.Common;
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
    //[Dependency(ServiceLifetime.Transient)]
    public class ConsoleHostedService : IHostedService
    {
        private readonly HelloWorldService _helloWorldService;
        public CommonService _commonService {get;set;}
        public ConsoleHostedService(HelloWorldService helloWorldService)
        {
            _helloWorldService = helloWorldService;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _helloWorldService.SayHelloWorld();
            _commonService.CommonServiceStr();
            //cancellationToken.Common();
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
