﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    class Vehicle : Inventory
    {
        public Vehicle(string description, DateTime dateOfPurchase, int monthsOfWarranty, double priceOfPurchase, Maker manufacturer, DateTime licenseExpiration, int mileage)
            : base(description, dateOfPurchase, monthsOfWarranty, priceOfPurchase, manufacturer)
        {
            LicenseExpiration = licenseExpiration;
            Mileage = mileage;
        }

        public DateTime LicenseExpiration { get; set; }
        public int Mileage { get; set; }

        public void Print()
        {
            base.Print();
            Console.WriteLine("License expires:   " + LicenseExpiration);
            Console.WriteLine("Mileage:           " + Mileage);
            Console.WriteLine();
        }
    }
}
