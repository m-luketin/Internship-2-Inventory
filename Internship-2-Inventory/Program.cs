using System;
using System.Collections.Generic;

namespace Internship_2_Inventory
{
    class Program
    {
        static void Main()
        {
            var computers = new List<Computer>();
            var cellphones = new List<Cellphone>();
            var vehicles = new List<Vehicle>();

            computers.Add(new Computer("a quality pc", new DateTime(2018, 7, 13), 6, 4439.91, Maker.Dell, false, OpSys.Windows, false));
            computers.Add(new Computer("a low-quality laptop", new DateTime(2017, 3, 9), 3, 2199.99, Maker.Asus, true, OpSys.Linux, true));
            computers.Add(new Computer("an average pc", new DateTime(2016, 2, 23), 1, 3179.95, Maker.Acer, false, OpSys.Linux, false));
            cellphones.Add(new Cellphone("an average cellphone", new DateTime(2018, 3, 4), 5, 2200.11, Maker.Xiaomi, true, 0976086801, "Mark", "Jones"));
            cellphones.Add(new Cellphone("a premium cellphone", new DateTime(2018, 11, 10), 12, 5782.11, Maker.Apple, true, 0912221122, "John", "Evans"));
            vehicles.Add(new Vehicle("a reliable car", new DateTime(2011, 3, 29), 36, 47000.99, Maker.Volvo, new DateTime(2019, 3, 14), 230000));
            vehicles.Add(new Vehicle("a barely drivable car", new DateTime(2002, 3, 20), 0, 8300.95, Maker.Seat, new DateTime(2018, 12, 14), 999000));
            vehicles.Add(new Vehicle("a transport van", new DateTime(2009, 8, 23), 24, 33034.25, Maker.Audi, new DateTime(2019, 8, 24), 250000));
            vehicles.Add(new Vehicle("a premium car", new DateTime(2018, 11, 2), 60, 530345.99, Maker.Mercedes, new DateTime(2020, 12, 30), 20000));

            var choice = -1; //int choice?
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
                Console.WriteLine("|8)   Search computers using warranty expiration                        |");
                Console.WriteLine("|9)   Search phones using manufacturer                                  |");
                Console.WriteLine("|10)  Search computers using operating system                           |");
                Console.WriteLine("|11)  Search owners and numbers of phones using warranty expiration     |");
                Console.WriteLine("|12)  Search vehicles with expiring licenses                            |");
                Console.WriteLine("|_______________________________Print___________________________________|");
                Console.WriteLine("|13)  Print computers                                                   |");
                Console.WriteLine("|14)  Print cellphones                                                  |");
                Console.WriteLine("|15)  Print vehicles                                                    |");
                Console.WriteLine("|16)  Print tech with batteries                                         |");
                Console.WriteLine("|17)  Print current vehicle values                                      |");
                Console.WriteLine("|18)  Print current tech values                                         |");
                Console.WriteLine("|_______________________________________________________________________|");
                Console.WriteLine("Press 0 to exit");

                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                    AddComputer(computers);
                else if (choice == 2)
                    AddCellphone(cellphones);
                else if (choice == 3)
                    AddVehicle(vehicles);
                else if (choice == 4)
                    DeleteComputer(computers);
                else if (choice == 5)
                    DeleteCellphone(cellphones);
                else if (choice == 6)
                    DeleteVehicle(vehicles);
                else if (choice == 7)
                    SearchUsingSerial(computers, cellphones, vehicles);
                else if (choice == 8)
                    SearchExpiringComputers(computers);
                else if (choice == 9)
                    SearchPhonesByManufacturer(cellphones);
                else if (choice == 10)
                    SearchComputersByOs(computers);
                else if (choice == 11)
                    SearchUsersByWarranty(cellphones);
                else if (choice == 12)
                    SearchExpiringVehicles(vehicles);
                else if (choice == 13)
                    PrintComputers(computers);
                else if (choice == 14)
                    PrintCellphones(cellphones);
                else if (choice == 15)
                    PrintVehicles(vehicles);
                else if (choice == 16)
                    PrintBatteries(cellphones, computers);
                else if (choice == 17)
                    PrintVehicleValues(vehicles);
                else if (choice == 18)
                    PrintTechValues(cellphones, computers);
                else if (choice != 0)
                    Console.WriteLine("Error!");

            } while (choice != 0);

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
            var maker = (Maker)Enum.Parse(typeof(Maker), manufacturer);
            
            Console.WriteLine("Batteries: (y/n)");
            var batteryBool = false;
            var batteries = Console.ReadLine();
            if (batteries == "y")
                batteryBool = true;

            Console.WriteLine("Operating system:");
            var operatingSystem = Console.ReadLine();
            var opSystem = (OpSys)Enum.Parse(typeof(OpSys), operatingSystem);

            Console.WriteLine("Laptop: (y/n)");
            var laptopBool = false;
            var laptop = Console.ReadLine();
            if (laptop == "y")
                laptopBool = true;

            Computer newComputer = new Computer(computerDescription, dateOfPurchase, monthsOfWarranty, priceOfPurchase,
                maker, batteryBool, opSystem, laptopBool);
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
            var maker = (Maker)Enum.Parse(typeof(Maker), manufacturer);

            Console.WriteLine("Batteries: (y/n)");
            var batteryBool = false;
            var batteries = Console.ReadLine();
            if (batteries == "y")
                batteryBool = true;

            Console.WriteLine("Phone number:");
            var phoneNumber = int.Parse(Console.ReadLine());
           

            Console.WriteLine("First name of owner:");
            var ownerFirstName = Console.ReadLine();
            Console.WriteLine("Last name of owner:");
            var ownerLastName = Console.ReadLine();

            Cellphone newCellphone = new Cellphone(cellphoneDescription, dateOfPurchase, monthsOfWarranty,
                priceOfPurchase, maker, batteryBool, phoneNumber, ownerFirstName, ownerLastName);
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
            var maker = (Maker)Enum.Parse(typeof(Maker), manufacturer);

            Console.WriteLine("Year of registration expiration:");
            var yearOfExpiration = int.Parse(Console.ReadLine());
            Console.WriteLine("Month of registration expiration:");
            var monthOfExpiration = int.Parse(Console.ReadLine());
            Console.WriteLine("Day of registration expiration:");
            var dayOfExpiration = int.Parse(Console.ReadLine());
            var dateOfExpiration = new DateTime(yearOfExpiration, monthOfExpiration, dayOfExpiration);


            Console.WriteLine("Mileage:");
            var vehicleMileage = int.Parse(Console.ReadLine());

            Vehicle newVehicle = new Vehicle(vehicleDescription, dateOfPurchase, monthsOfWarranty, priceOfPurchase,
                maker, dateOfExpiration, vehicleMileage);
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
            Console.WriteLine("Enter year of expiration:");
            var year = int.Parse(Console.ReadLine());

            foreach (var item in computers)
            {
                var expirationDate = item.DateOfPurchase.AddMonths(item.MonthsOfWarranty);
                if (expirationDate.Year == year)
                    item.Print();
            }
        }

        static void SearchPhonesByManufacturer(List<Cellphone> cellphones)
        {
            Console.WriteLine("Enter the manufacturer:");
            var manufacturer = Console.ReadLine();

            foreach (var item in cellphones)
                if (item.Manufacturer.ToString() == manufacturer)
                    item.Print();
        }

        static void SearchComputersByOs(List<Computer> computers)
        {
            Console.WriteLine("Enter the operating system:");
            var operatingSystem = Console.ReadLine();

            foreach (var item in computers)
                if (item.OperatingSystem.ToString() == operatingSystem)
                    item.Print();
        }

        static void SearchUsersByWarranty(List<Cellphone> cellphones)
        {
            Console.WriteLine("Enter year of expiration:");
            var year = int.Parse(Console.ReadLine());

            foreach (var item in cellphones)
            {
                var expirationDate = item.DateOfPurchase.AddMonths(item.MonthsOfWarranty);
                if (expirationDate.Year == year)
                    item.Print();
            }
        }

        static void SearchExpiringVehicles(List<Vehicle> vehicles)
        {
            foreach (var item in vehicles)
                if ((item.LicenseExpiration - DateTime.Now) < new TimeSpan(30, 0, 0, 0))
                    item.Print();
        }

        static void PrintComputers(List<Computer> computers)
        {
            foreach (var item in computers)
                item.Print();
        }

        static void PrintCellphones(List<Cellphone> cellphones)
        {
            foreach (var item in cellphones)
                item.Print();
        }

        static void PrintVehicles(List<Vehicle> vehicles)
        {
            foreach (var item in vehicles)
                item.Print();
        }

        static void PrintBatteries(List<Cellphone> cellphones, List<Computer> computers)
        {
            foreach (var item in cellphones)
                if (item.Batteries)
                    item.Print();
            foreach (var item in computers)
                if (item.Batteries)
                    item.Print();
        }

        static void PrintVehicleValues(List<Vehicle> vehicles)
        {

            foreach (var item in vehicles)
            {
                var currentValue = item.PriceOfPurchase;
                var limit = 0.2 * currentValue;
                var n = item.Mileage / 20000;

                for (var i = 0; i < n; i++)
                    currentValue = currentValue - (currentValue * 0.1);
                Console.WriteLine("ID: " + item.SerialNumber);
                Console.WriteLine("Purchase price:    " + item.PriceOfPurchase);
                if (currentValue < limit)
                {
                    Console.WriteLine("Current value:     " + limit);
                    Console.WriteLine("Difference:        " + (item.PriceOfPurchase - limit));
                }
                else
                {
                    Console.WriteLine("Current value:     " + currentValue);
                    Console.WriteLine("Difference:        " + (item.PriceOfPurchase - currentValue));
                }

                Console.WriteLine();
            }
        }

        static void PrintTechValues(List<Cellphone> cellphones, List<Computer> computers)
        {
            foreach (var item in cellphones)
            {
                var currentValue = item.PriceOfPurchase;
                var limit = 0.3 * item.PriceOfPurchase;
                var n = (DateTime.Now - item.DateOfPurchase).Days / 30;

                for (var i = 0; i < n; i++)
                    currentValue = currentValue - (currentValue * 0.05);

                Console.WriteLine("ID: " + item.SerialNumber);
                Console.WriteLine("Purchase price:   " + item.PriceOfPurchase);
                if (currentValue < limit)
                {
                    Console.WriteLine("Current value:      " + limit);
                    Console.WriteLine("Difference:         " + (item.PriceOfPurchase - limit));
                }
                else
                {
                    Console.WriteLine("Current value:    " + currentValue);
                    Console.WriteLine("Difference:       " + (item.PriceOfPurchase - currentValue));
                }

                Console.WriteLine();
            }

            foreach (var item in computers)
            {
                var currentValue = item.PriceOfPurchase;
                var limit = 0.3 * item.PriceOfPurchase;
                var n = (DateTime.Now - item.DateOfPurchase).Days / 30;

                for (var i = 0; i < n; i++)
                    currentValue = currentValue - (currentValue * 0.05);

                Console.WriteLine("ID: " + item.SerialNumber);
                Console.WriteLine("Purchase price:   " + item.PriceOfPurchase);
                if (currentValue < limit)
                {
                    Console.WriteLine("Current value:      " + limit);
                    Console.WriteLine("Difference:         " + (item.PriceOfPurchase - limit));
                }
                else
                {
                    Console.WriteLine("Current value:    " + currentValue);
                    Console.WriteLine("Difference:       " + (item.PriceOfPurchase - currentValue));
                }

                Console.WriteLine();
            }
        }
    }
}
