using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Internship_2_Inventory
{
    class Inventory
    {
        public Inventory(int serialNumber, string description, DateTime dateOfPurchase, DateTime monthsOfWarranty, decimal priceOfPurchase, string manufacturer)
        {
            SerialNumber = serialNumber;
            Description = description;
            DateOfPurchase = dateOfPurchase;
            MonthsOfWarranty = monthsOfWarranty;
            PriceOfPurchase = priceOfPurchase;
            Manufacturer = manufacturer;
        }

        public int SerialNumber { get; set; }
        public string Description { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public DateTime MonthsOfWarranty { get; set; }
        public decimal PriceOfPurchase { get; set; }
        public string Manufacturer { get; set; }
    }
}
