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
    public class ConsoleHostedService : IHostedService
    {
        private readonly HelloWorldService _helloWorldService;
        //public Comm
        public ConsoleHostedService(HelloWorldService helloWorldService)
        {
            _helloWorldService = helloWorldService;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _helloWorldService.SayHelloWorld();
            //cancellationToken.Common();
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
