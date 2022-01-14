using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ABP.VnextConsole.Common
{
    [Dependency(ServiceLifetime.Transient)]
    public class CommonService
    {
        public void CommonServiceStr()
        {
            Console.WriteLine("Common Service..,方法执行");
        }
    }
}
