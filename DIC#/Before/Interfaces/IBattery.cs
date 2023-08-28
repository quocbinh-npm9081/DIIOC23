using DIC_.Before.Entity.Batteris;
using DIC_.Before.Entity.Mobiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIC_.Before.Interfaces
{
    internal interface IBattery 
    {
        BatteryInfo BatteryInfo { get; set; }
      
        bool IsSupport(MobilePhone mobile);
    }
}
