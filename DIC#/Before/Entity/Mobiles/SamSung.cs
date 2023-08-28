using DIC_.Before.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIC_.Before.Entity.Mobiles
{
    internal class SamSung:MobilePhone
    {
      
        public SamSung(IBattery battery) :base(battery, MobilePhoneManufacture.SAMSUNG) { }
        public override void TryReplaceBattery()
        {
            if (Battery.IsSupport(this)) {
                Console.WriteLine($"Yeah (-_-), the battery of '{Battery.BatteryInfo.Manufacture}' can be used for your Samsung Phone");
            }
            else
            {
                Console.WriteLine($"Oh Man >.<, the battery of '{Battery.BatteryInfo.Manufacture}' can not be used for your Samsung Phone");
            }

        }
    }
}
