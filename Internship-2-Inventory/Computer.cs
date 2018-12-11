using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    class Computer : TechEquipment
    {
        public Computer(int serialNumber, string description, DateTime dateOfPurchase, DateTime monthsOfWarranty, decimal priceOfPurchase, string manufacturer, bool batteries, string operatingSystem, bool laptop)
            : base(serialNumber, description, dateOfPurchase, monthsOfWarranty, priceOfPurchase, manufacturer, batteries)
        {
            OperatingSystem = operatingSystem;
            Laptop = laptop;
        }

        public string OperatingSystem { get; set; }
        public bool Laptop { get; set; }    
    }
}
