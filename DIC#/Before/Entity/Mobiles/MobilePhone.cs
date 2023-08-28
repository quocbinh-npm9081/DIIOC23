using DIC_.Before.Entity.Batteris;
using DIC_.Before.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIC_.Before.Entity.Mobiles
{
    internal abstract class MobilePhone
    {
        public MobilePhoneManufacture Manufacture { get; set; }
        public IBattery Battery { get; set; }
        public MobilePhone(IBattery battery, MobilePhoneManufacture manufacture) {
            this.Battery = battery;
            this.Manufacture = manufacture;
        }

        public abstract void TryReplaceBattery();
    }
}
