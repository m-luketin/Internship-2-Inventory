﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    class TechEquipment : Inventory
    {
        public TechEquipment(string description, DateTime dateOfPurchase, int monthsOfWarranty, double priceOfPurchase, Maker manufacturer, bool batteries)
            : base(description, dateOfPurchase, monthsOfWarranty, priceOfPurchase, manufacturer)
        {
            Batteries = batteries;
        }

        public bool Batteries { get; set; }

        public void Print()
        {
            base.Print();
            Console.WriteLine("Batteries:         " + Batteries);
        }
    }
}
