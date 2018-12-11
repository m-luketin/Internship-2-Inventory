using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    class Vehicle : Inventory
    {
        public Vehicle(int serialNumber, string description, DateTime dateOfPurchase, DateTime monthsOfWarranty, decimal priceOfPurchase, string manufacturer, DateTime licenseExpiration, int mileage)
            : base(serialNumber, description, dateOfPurchase, monthsOfWarranty, priceOfPurchase, manufacturer)
        {
            LicenseExpiration = licenseExpiration;
            Mileage = mileage;
        }

        public DateTime LicenseExpiration { get; set; }
        public int Mileage { get; set; }
    }
}
