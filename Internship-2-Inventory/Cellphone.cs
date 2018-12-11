using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    class Cellphone : TechEquipment
    {
        public Cellphone(int serialNumber, string description, DateTime dateOfPurchase, DateTime monthsOfWarranty, decimal priceOfPurchase, string manufacturer, bool batteries, int phoneNumber, string firstNameOfOwner, string lastNameOfOwner)
            : base(serialNumber, description, dateOfPurchase, monthsOfWarranty, priceOfPurchase, manufacturer, batteries)
        {
            PhoneNumber = phoneNumber;
            FirstNameOfOwner = firstNameOfOwner;
            LastNameOfOwner = lastNameOfOwner;
        }

        public int PhoneNumber { get; set; }
        public string FirstNameOfOwner { get; set; }
        public string LastNameOfOwner { get; set; }
    }
}
