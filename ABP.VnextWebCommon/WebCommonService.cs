using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ABP.VnextWebCommon
{
    [Dependency(ServiceLifetime.Transient)]
    public class WebCommonService
    {
        public void webCommonService()
        {
            Console.WriteLine("Web Common Servces.....");
        }
    }
}
