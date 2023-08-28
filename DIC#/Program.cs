using DIC_.Before.Entity.Batteris;
using DIC_.Before.Entity.Mobiles;
using DIC_.Before.Interfaces;
using System;

namespace DIC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBattery samsungBattery = new SamSungBattery();
            MobilePhone SamSung = new SamSung(samsungBattery);


            SamSung.TryReplaceBattery();
        }
    }
}
