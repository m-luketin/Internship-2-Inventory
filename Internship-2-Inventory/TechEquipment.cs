using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    class TechEquipment : Inventory
    {
        public TechEquipment(int serialNumber, string description, DateTime dateOfPurchase, DateTime monthsOfWarranty, decimal priceOfPurchase, string manufacturer, bool batteries)
            : base(serialNumber, description, dateOfPurchase, monthsOfWarranty, priceOfPurchase, manufacturer)
        {
            Batteries = batteries;
        }

        public bool Batteries { get; set; }
    }
}
