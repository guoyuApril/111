using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Modularity;

namespace ABP.VnextConsole.Common
{
    public class CommonMoudle: AbpModule
    {
        public void Common()
        {
            Console.WriteLine("Common..,方法执行");        }
    }
}
