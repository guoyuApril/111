using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Modularity;

namespace ABP.VnextWebCommon
{
    public class WebCommonMoudle : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Console.WriteLine("加载Web Common Moudle 模块...");
            //base.ConfigureServices(context);
        }
    }
}
