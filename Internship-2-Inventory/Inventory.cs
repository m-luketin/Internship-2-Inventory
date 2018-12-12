using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Internship_2_Inventory
{
    class Inventory
    {
        public Inventory(string description, DateTime dateOfPurchase, int monthsOfWarranty, double priceOfPurchase, Maker manufacturer)
        {
            SerialNumber = Guid.NewGuid();
            Description = description;
            DateOfPurchase = dateOfPurchase;
            MonthsOfWarranty = monthsOfWarranty;
            PriceOfPurchase = priceOfPurchase;
            Manufacturer = manufacturer;
        }

        public Guid SerialNumber { get; set; }
        public string Description { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public int MonthsOfWarranty { get; set; }
        public double PriceOfPurchase { get; set; }
        public Maker Manufacturer { get; set; }

    }
    public enum Maker
    {
        Volvo,
        Audi,
        Mercedes,
        Porche,
        Seat,
        Asus,
        Acer,
        Dell,
        Xiaomi,
        Apple
    }
}
