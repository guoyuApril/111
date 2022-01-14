using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ABP.VnextConsole
{
    /// <summary>
    /// 服务类
    /// 第二种：新方法注入 /*: ITransientDependency*/
    /// 第三种：新方法注入 /*: [Dependency(ServiceLifetime.Transient)]*/
    /// </summary>
    [Dependency(ServiceLifetime.Transient)]
    public class HelloWorldService /*: ITransientDependency*/
    {
        public void SayHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
