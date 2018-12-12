﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    class Computer : TechEquipment
    {
        public Computer(string description, DateTime dateOfPurchase, int monthsOfWarranty, double priceOfPurchase, string manufacturer, bool batteries, string operatingSystem, bool laptop)
            : base(description, dateOfPurchase, monthsOfWarranty, priceOfPurchase, manufacturer, batteries)
        {
            OperatingSystem = operatingSystem;
            Laptop = laptop;
        }

        public string OperatingSystem { get; set; }
        public bool Laptop { get; set; }

        public void Print()
        {
            Console.WriteLine("ID: " + SerialNumber);
            Console.WriteLine("Description:       " + Description);
            Console.WriteLine("Bought:            " + DateOfPurchase);
            Console.WriteLine("Price:             " + PriceOfPurchase);
            Console.WriteLine("Manufacturer:      " + Manufacturer);
            Console.WriteLine("Batteries:         " + Batteries);
            Console.WriteLine("Operating system:  " + OperatingSystem);
            Console.WriteLine("Laptop:            " + Laptop);
            Console.WriteLine();
        }
    }
}
