﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    class Computer : TechEquipment
    {
        public Computer(string description, DateTime dateOfPurchase, int monthsOfWarranty, double priceOfPurchase, Maker manufacturer, bool batteries, OpSys operatingSystem, bool laptop)
            : base(description, dateOfPurchase, monthsOfWarranty, priceOfPurchase, manufacturer, batteries)
        {
            OperatingSystem = operatingSystem;
            Laptop = laptop;
        }

        public OpSys OperatingSystem { get; set; }
        public bool Laptop { get; set; }

        public void Print()
        {
            base.Print();
            Console.WriteLine("Operating system:  " + OperatingSystem);
            Console.WriteLine("Laptop:            " + Laptop);
            Console.WriteLine();
        }
    }

    public enum OpSys
    {
        Windows,
        Linux,
        iOS
    }
}
