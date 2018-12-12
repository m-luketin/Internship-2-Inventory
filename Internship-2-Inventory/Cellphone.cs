using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    class Cellphone : TechEquipment
    {
        public Cellphone(string description, DateTime dateOfPurchase, int monthsOfWarranty, double priceOfPurchase, Maker manufacturer, bool batteries, int phoneNumber, string firstNameOfOwner, string lastNameOfOwner)
            : base(description, dateOfPurchase, monthsOfWarranty, priceOfPurchase, manufacturer, batteries)
        {
            PhoneNumber = phoneNumber;
            FirstNameOfOwner = firstNameOfOwner;
            LastNameOfOwner = lastNameOfOwner;
        }

        public int PhoneNumber { get; set; }
        public string FirstNameOfOwner { get; set; }
        public string LastNameOfOwner { get; set; }

        public void Print()
        {
            base.Print();
            Console.WriteLine("Phone number:      0" + PhoneNumber);
            Console.WriteLine("Owner:             " + FirstNameOfOwner + " " + LastNameOfOwner);
            Console.WriteLine();
        }
    }
}
