using System;
using System.Collections.Generic;
using System.Linq;

namespace Internship_2_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            var computers = new List<Computer>();
            var cellphones = new List<Cellphone>();
            var vehicles = new List<Vehicle>();
            
            var computer1 = new Computer("a quality pc", new DateTime(2018, 7, 13), 6, 4439.91, "Dell", false, "Windows", false );
            computers.Append(computer1);
            var computer2 = new Computer("a low-quality laptop", new DateTime(2017, 3, 9), 3, 2199.99, "Asus", true, "Linux", true);
            computers.Append(computer2);
            var computer3 = new Computer("an average pc", new DateTime(2016, 2, 23), 4, 3179.95, "Acer", false, "Linux", false);
            computers.Append(computer3);
            var cellphone1 = new Cellphone("an average cellphone", new DateTime(2018, 3, 4), 5, 2200.11, "Xiaomi", true, 0976086801, "Mark", "Jones");
            cellphones.Append(cellphone1);
            var cellphone2 = new Cellphone("a premium cellphone", new DateTime(2018, 11, 23), 12, 2200.11, "Apple", true, 0912221122, "John", "Evans");
            cellphones.Append(cellphone2);
            var vehicle1 = new Vehicle("a reliable car", new DateTime(2011, 3, 29), 36,  47000.99, "Volvo", new DateTime(2019, 3, 14), 230000 );
            vehicles.Append(vehicle1);
            var vehicle2 = new Vehicle("a barely drivable car", new DateTime(2002, 3, 20), 0,  8300.95, "Seat", new DateTime(2018, 12, 14), 999000 );
            vehicles.Append(vehicle2);
            var vehicle3 = new Vehicle("a transport van", new DateTime(2009, 8, 23), 24,  33034.25, "Volkswagen", new DateTime(2019, 8, 24), 250000 );
            vehicles.Append(vehicle3);
            var vehicle4 = new Vehicle("a premium car", new DateTime(2018, 11, 2), 60,  530345.99, "BMW", new DateTime(2020, 12, 30), 20000 );
            vehicles.Append(vehicle4);

            var choice = 0;
            do
            {
                Console.WriteLine("---------------------------Data_management-----------------------------");
                Console.WriteLine("1)   Add computer");
                Console.WriteLine("2)   Add cellphone");
                Console.WriteLine("3)   Add vehicle");
                Console.WriteLine("4)   Remove computer");
                Console.WriteLine("5)   Remove cellphone");
                Console.WriteLine("6)   Remove vehicle");
                Console.WriteLine("------------------------------Searches---------------------------------");
                Console.WriteLine("7)   Search item using serial number");
                Console.WriteLine("8)   Search computers using expiring warranties");
                Console.WriteLine("9)   Search phones using manufacturer");
                Console.WriteLine("10)  Search computers using operating system");
                Console.WriteLine("11)  Search owners and numbers of phones using warranty expiration");
                Console.WriteLine("-------------------------------Print-----------------------------------");
                Console.WriteLine("12)  Print computers");
                Console.WriteLine("13)  Print cellphones");
                Console.WriteLine("14)  Print vehicles");
                Console.WriteLine("15)  Print tech with batteries");
                Console.WriteLine("16)  Print vehicles with expiring registrations");
                Console.WriteLine("-------------------------------Other-----------------------------------");
                Console.WriteLine("17)  Exit");

                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                    AddComputer(computers);

                else if(choice < 1 || choice > 17)
                    Console.WriteLine("Error!");

            } while (choice != 17);

        }

        static void AddComputer(List<Computer> computers)
        {
            Console.WriteLine("Description:");
            var computerDescription = Console.ReadLine();

            Console.WriteLine("Year of manufacturing:");
            var yearOfManufacturing = int.Parse(Console.ReadLine());
            Console.WriteLine("Month of manufacturing:");
            var monthOfManufacturing = int.Parse(Console.ReadLine());
            Console.WriteLine("Day of manufacturing:");
            var dayOfManufacturing = int.Parse(Console.ReadLine());
            var dateOfManufacturing = new DateTime(yearOfManufacturing, monthOfManufacturing, dayOfManufacturing);

            Console.WriteLine("Months of warranty:");
            var monthsOfWarranty = int.Parse(Console.ReadLine());

            Console.WriteLine("Price of purchase:");
            var priceOfPurchase = double.Parse(Console.ReadLine());

            Console.WriteLine("Manufacturer:");
            var manufacturer = Console.ReadLine();

            Console.WriteLine("Batteries: (y/n)");
            var batteryBool = false;
            var batteries = Console.ReadLine();
            if (batteries == "y")
                batteryBool = true;
            else if (batteries == "n")
                batteryBool = false;

            Console.WriteLine("Operating system:");
            var operatingSystem = Console.ReadLine();

            Console.WriteLine("Laptop: (y/n)");
            var laptopBool = false;
            var laptop = Console.ReadLine();
            if (laptop == "y")
                laptopBool = true;
            else if (laptop == "n")
                laptopBool = false;

            Computer newComputer = new Computer(computerDescription, dateOfManufacturing, monthsOfWarranty, priceOfPurchase, manufacturer, batteryBool, operatingSystem, laptopBool);
            computers.Append(newComputer);
        }
    }
}
