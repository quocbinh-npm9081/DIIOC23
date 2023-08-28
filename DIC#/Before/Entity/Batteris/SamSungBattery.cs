using DIC_.Before.Entity.Mobiles;
using DIC_.Before.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIC_.Before.Entity.Batteris
{
    internal class SamSungBattery : ISamSungBattery
    {
        public BatteryInfo BatteryInfo { get; set; }
        public SamSungBattery()
        {
            BatteryInfo = new BatteryInfo() {
                Manufacture = BatteryManufacture.SamSung,
                ChargeTime = "2h",
                UseTime = "16h"
            };
        }

        public bool IsSupport(MobilePhone mobile)
        {
            return mobile.Manufacture == MobilePhoneManufacture.SAMSUNG | mobile.Battery.BatteryInfo.Manufacture == BatteryManufacture.SamSung;
        }
    }
}
