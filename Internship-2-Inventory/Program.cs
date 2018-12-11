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
            
            computers.Add(new Computer("a quality pc", new DateTime(2018, 7, 13), 6, 4439.91, "Dell", false, "Windows", false));
            computers.Add(new Computer("a low-quality laptop", new DateTime(2017, 3, 9), 3, 2199.99, "Asus", true, "Linux", true));
            computers.Add(new Computer("an average pc", new DateTime(2016, 2, 23), 1, 3179.95, "Acer", false, "Linux", false));
            cellphones.Add(new Cellphone("an average cellphone", new DateTime(2018, 3, 4), 5, 2200.11, "Xiaomi", true, 0976086801, "Mark", "Jones"));
            cellphones.Add(new Cellphone("a premium cellphone", new DateTime(2018, 11, 23), 12, 2200.11, "Apple", true, 0912221122, "John", "Evans"));
            vehicles.Add(new Vehicle("a reliable car", new DateTime(2011, 3, 29), 36, 47000.99, "Volvo", new DateTime(2019, 3, 14), 230000));
            vehicles.Add(new Vehicle("a barely drivable car", new DateTime(2002, 3, 20), 0, 8300.95, "Seat", new DateTime(2018, 12, 14), 999000));
            vehicles.Add(new Vehicle("a transport van", new DateTime(2009, 8, 23), 24, 33034.25, "Volkswagen", new DateTime(2019, 8, 24), 250000));
            vehicles.Add(new Vehicle("a premium car", new DateTime(2018, 11, 2), 60, 530345.99, "BMW", new DateTime(2020, 12, 30), 20000));

            var choice = 0;
            do
            {
                Console.WriteLine(" ___________________________Data_management_____________________________");
                Console.WriteLine("|1)   Add computer                                                      |");
                Console.WriteLine("|2)   Add cellphone                                                     |");
                Console.WriteLine("|3)   Add vehicle                                                       |");
                Console.WriteLine("|4)   Remove computer                                                   |");
                Console.WriteLine("|5)   Remove cellphone                                                  |");
                Console.WriteLine("|6)   Remove vehicle                                                    |");
                Console.WriteLine("|______________________________Searches_________________________________|");
                Console.WriteLine("|7)   Search item using serial number                                   |");
                Console.WriteLine("|8)   Search computers using expiring warranties                        |");
                Console.WriteLine("|9)   Search phones using manufacturer                                  |");
                Console.WriteLine("|10)  Search computers using operating system                           |");
                Console.WriteLine("|11)  Search owners and numbers of phones using warranty expiration     |");
                Console.WriteLine("|_______________________________Print___________________________________|");
                Console.WriteLine("|12)  Print computers                                                   |");
                Console.WriteLine("|13)  Print cellphones                                                  |");
                Console.WriteLine("|14)  Print vehicles                                                    |");
                Console.WriteLine("|15)  Print tech with batteries                                         |");
                Console.WriteLine("|16)  Print vehicles with expiring registrations                        |");
                Console.WriteLine("|_______________________________________________________________________|");
                Console.WriteLine("|17)__Exit______________________________________________________________|");

                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                    AddComputer(computers);
                else if (choice == 2)
                    AddCellphone(cellphones);
                else if(choice == 3)
                    AddVehicle(vehicles);
                else if(choice == 4)
                    DeleteComputer(computers);
                else if(choice == 5)
                    DeleteCellphone(cellphones);
                else if(choice == 6)
                    DeleteVehicle(vehicles);
                else if(choice == 7)
                    SearchUsingSerial(computers, cellphones, vehicles);
                else if (choice == 8)
                    SearchExpiringComputers(computers);
                else
                    Console.WriteLine("Error!");

            } while (choice != 17);

        }

        static void AddComputer(List<Computer> computers)
        {
            Console.WriteLine("Description:");
            var computerDescription = Console.ReadLine();

            Console.WriteLine("Year of purchase:");
            var yearOfPurchase = int.Parse(Console.ReadLine());
            Console.WriteLine("Month of purchase:");
            var monthOfPurchase = int.Parse(Console.ReadLine());
            Console.WriteLine("Day of purchase:");
            var dayOfPurchase = int.Parse(Console.ReadLine());
            var dateOfPurchase = new DateTime(yearOfPurchase, monthOfPurchase, dayOfPurchase);

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

            Computer newComputer = new Computer(computerDescription, dateOfPurchase, monthsOfWarranty, priceOfPurchase, manufacturer, batteryBool, operatingSystem, laptopBool);
            computers.Add(newComputer);
        }
        static void AddCellphone(List<Cellphone> cellphones)
        {
            Console.WriteLine("Description:");
            var cellphoneDescription = Console.ReadLine();

            Console.WriteLine("Year of purchase:");
            var yearOfPurchase = int.Parse(Console.ReadLine());
            Console.WriteLine("Month of purchase:");
            var monthOfPurchase = int.Parse(Console.ReadLine());
            Console.WriteLine("Day of purchase:");
            var dayOfPurchase = int.Parse(Console.ReadLine());
            var dateOfPurchase = new DateTime(yearOfPurchase, monthOfPurchase, dayOfPurchase);

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

            Console.WriteLine("Phone number:");
            var operatingSystem = int.Parse(Console.ReadLine());

            Console.WriteLine("First name of owner:");
            var ownerFirstName = Console.ReadLine();
            Console.WriteLine("Last name of owner:");
            var ownerLastName = Console.ReadLine();

            Cellphone newCellphone = new Cellphone(cellphoneDescription, dateOfPurchase, monthsOfWarranty, priceOfPurchase, manufacturer, batteryBool, operatingSystem, ownerFirstName, ownerLastName);
            cellphones.Add(newCellphone);
        }
        static void AddVehicle(List<Vehicle> vehicles)
        {
            Console.WriteLine("Description:");
            var vehicleDescription = Console.ReadLine();

            Console.WriteLine("Year of purchase:");
            var yearOfPurchase = int.Parse(Console.ReadLine());
            Console.WriteLine("Month of purchase:");
            var monthOfPurchase = int.Parse(Console.ReadLine());
            Console.WriteLine("Day of purchase:");
            var dayOfPurchase = int.Parse(Console.ReadLine());
            var dateOfPurchase = new DateTime(yearOfPurchase, monthOfPurchase, dayOfPurchase);

            Console.WriteLine("Months of warranty:");
            var monthsOfWarranty = int.Parse(Console.ReadLine());

            Console.WriteLine("Price of purchase:");
            var priceOfPurchase = double.Parse(Console.ReadLine());

            Console.WriteLine("Manufacturer:");
            var manufacturer = Console.ReadLine();

            Console.WriteLine("Year of registration expiration:");
            var yearOfExpiration = int.Parse(Console.ReadLine());
            Console.WriteLine("Month of registration expiration:");
            var monthOfExpiration = int.Parse(Console.ReadLine());
            Console.WriteLine("Day of registration expiration:");
            var dayOfExpiration = int.Parse(Console.ReadLine());
            var dateOfExpiration = new DateTime(yearOfPurchase, monthOfPurchase, dayOfPurchase);


            Console.WriteLine("Mileage:");
            var vehicleMileage = int.Parse(Console.ReadLine());

            Vehicle newVehicle = new Vehicle(vehicleDescription, dateOfPurchase, monthsOfWarranty, priceOfPurchase, manufacturer, dateOfExpiration, vehicleMileage);
            vehicles.Add(newVehicle);
        }

        static void DeleteComputer(List<Computer> computers)
        {
            foreach (var item in computers)
                item.Print();

            Console.WriteLine("Input part of serial number you'd like to delete:");
            var serial = Console.ReadLine();

            var flag = 1;
            foreach (var item in computers)
            {
                if (item.SerialNumber.ToString().Contains(serial))
                {
                    computers.Remove(item);
                    flag = 0;
                    break;
                }
            }
            if (flag == 1)
                Console.WriteLine("Serial not found");
            else
                Console.WriteLine("Deleted.");
        }
        static void DeleteCellphone(List<Cellphone> cellphones)
        {
            foreach (var item in cellphones)
                item.Print();

            Console.WriteLine("Input part of serial number you'd like to delete:");
            var serial = Console.ReadLine();

            var flag = 1;
            foreach (var item in cellphones)
            {
                if (item.SerialNumber.ToString().Contains(serial))
                {
                    cellphones.Remove(item);
                    flag = 0;
                    break;
                }
            }
            if (flag == 1)
                Console.WriteLine("Serial not found");
            else
                Console.WriteLine("Deleted.");
        }
        static void DeleteVehicle(List<Vehicle> vehicles)
        {
            foreach (var item in vehicles)
                item.Print();

            Console.WriteLine("Input part of serial number you'd like to delete:");
            var serial = Console.ReadLine();

            var flag = 1;
            foreach (var item in vehicles)
            {
                if (item.SerialNumber.ToString().Contains(serial))
                {
                    vehicles.Remove(item);
                    flag = 0;
                    break;
                }
            }
            if (flag == 1)
                Console.WriteLine("Serial not found");
            else
                Console.WriteLine("Deleted.");
        }

        static void SearchUsingSerial(List<Computer> computers, List<Cellphone> cellphones, List<Vehicle> vehicles)
        {
            Console.WriteLine("Enter part of serial for search:");
            var serial = Console.ReadLine();

            foreach (var item in computers)
                if (item.SerialNumber.ToString().Contains(serial))
                    item.Print();
            foreach (var item in cellphones)
                if (item.SerialNumber.ToString().Contains(serial))
                    item.Print();
            foreach (var item in vehicles)
                if (item.SerialNumber.ToString().Contains(serial))
                    item.Print();
        }

        static void SearchExpiringComputers(List<Computer> computers)
        {
            foreach(var item in computers)
                if (item.MonthsOfWarranty <= 1)
                    item.Print();
        }
    }
}
