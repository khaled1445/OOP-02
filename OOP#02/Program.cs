using OOP_02;

namespace OOP_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OOP 02 - Smart Delivery Management System 
            #region Part 01 : Theoretical Questions

            #region Question 1
            //Answer the following questions:
            //a) What is the difference between a class and a struct?
            // class is a reference type so it's data is stored in the heap and it also support inheritence
            // struct is a value type so the data is stored in the stack and doesnot support inheritence 

            //b) Why are classes more suitable than structs for large applications?
            // the main and the most important reason is that classes support inheritence which improves 
            // code reusability and maintainability and also classes are reference types so they are more efficient for large data


            #endregion

            #region Question 2 Consider the following code:
            //a) Which class is the parent class?
            // shipment is the parent class

            //b) Which class is the child class?
            // ExpressShipment is the child class

            //c) What members are inherited by ExpressShipment?
            // string TrackingCode

            //d) Why is inheritance better than duplicating the same code in multiple classes?
            //because it improves code reusability and maintainability and also reduces the chance of errors in the code
            #endregion

            #endregion


            #region Part 02 : Practical (Smart Delivery Management System)




            //DeliveryCenter deliveryCenter01 = new DeliveryCenter();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"please enter Shipment{i} ");

            //    Console.WriteLine("Traking Code:");
            //    string trackingCode = Console.ReadLine();

            //    Console.WriteLine("==============================");

            //    Console.WriteLine("Description:");
            //    string description = Console.ReadLine();

            //    Console.WriteLine("==============================");

            //    Console.WriteLine("Weight:");
            //    decimal weight = decimal.Parse(Console.ReadLine());

            //    Console.WriteLine("==============================");

            //    Console.WriteLine("Delivery Fee:");
            //    decimal deliveryFee = decimal.Parse(Console.ReadLine());

            //    Console.WriteLine("==============================");

            //    Console.WriteLine("City:");
            //    string city = Console.ReadLine();

            //    Console.WriteLine("==============================");

            //    Console.WriteLine("Street:");
            //    string street = Console.ReadLine();

            //    Console.WriteLine("==============================");

            //    Console.WriteLine("Building Number:");
            //    int buildingNumber = int.Parse(Console.ReadLine());

            //    Console.WriteLine("==============================");

            //    DeliveryAddress deliveryAddress = new DeliveryAddress(city, street, buildingNumber);
            //    Shipment shipment = new Shipment(trackingCode, description, weight, deliveryFee, deliveryAddress);

            //    bool added = deliveryCenter01.AddShipment(shipment);
            //    Console.WriteLine(added ? "Shipment added successfully." : "Delivery center is full.");
            //    Console.WriteLine();

            //}
            //Console.WriteLine("All Shipments");
            //for (int i = 0; i < 3; i++)
            //{
            //    deliveryCenter01[i].PrintShipment();
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Enter the Tracking Code to Search");
            //string searchCode = Console.ReadLine();

            //Shipment found = deliveryCenter01[searchCode];

            //if (found.TrackingCode != null)
            //{
            //    Console.WriteLine($"shipment found {found.TrackingCode} - {found.Description}");
            //}
            //else
            //    Console.WriteLine("shipment wasn't found");


            //DeliveryAddress originalDA = new DeliveryAddress("Beni Suef", "Bosta", 6);
            //DeliveryAddress copyDA = originalDA;

            //Console.WriteLine("=================================");
            //Console.WriteLine("struct copy test");
            //copyDA.City = "Cairo";
            //copyDA.Street = "faisal";
            //copyDA.BuildingNumber = 10;
            //Console.WriteLine($"Original: " + originalDA.GetFullAddress());
            //Console.WriteLine($"Copy: " + copyDA.GetFullAddress());


            #endregion

            #region Part02
            try
            {
                // 1. Create a DeliveryCenter
                DeliveryCenter center = new DeliveryCenter();

                // 2. Read the center name from the user
                Console.Write("Enter Delivery Center Name: ");
                center.CenterName = Console.ReadLine();
                Console.WriteLine();

                // 3 Create one StandardShipment and add it
                Console.WriteLine("--- Standard Shipment Data ---");
                StandardShipment standard = ReadStandardShipment();
                Console.WriteLine(center.AddShipment(standard)
                    ? "Shipment Added Successfully."
                    : "Delivery center is full.");
                Console.WriteLine();

                // 4. Create one ExpressShipment and add it
                Console.WriteLine("--- Express Shipment Data ---");
                ExpressShipment express = ReadExpressShipment();
                Console.WriteLine(center.AddShipment(express)
                    ? "Shipment Added Successfully."
                    : "Delivery center is full.");
                Console.WriteLine();

                // 5 Create one InternationalShipment and add it
                Console.WriteLine("--- International Shipment Data ---");
                InternationalShipment international = ReadInternationalShipment();
                Console.WriteLine(center.AddShipment(international)
                    ? "Shipment Added Successfully."
                    : "Delivery center is full.");
                Console.WriteLine();

                // 8. Print all shipments
                Console.WriteLine("=".PadRight(50, '='));
                Console.WriteLine($"Delivery Center : {center.CenterName}");
                Console.WriteLine("=".PadRight(50, '='));
                center.PrintAllShipments();

                // 9. Search for a shipment using the existing tracking code indexer
                Console.Write("Enter a Tracking Code to search: ");
                string searchCode = Console.ReadLine();
                Shipment found = center[searchCode];

                if (found != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("Shipment Found:");
                    found.PrintShipment();
                }
                else
                {
                    Console.WriteLine("Shipment not found");
                }
                Console.WriteLine();

                // 10. Remove one shipment using its tracking code
                Console.Write("Enter Tracking Code to Remove: ");
                string removeCode = Console.ReadLine();
                bool removed = center.RemoveShipment(removeCode);
                Console.WriteLine(removed ? "Shipment Removed Successfully." : "Shipment not found");
                Console.WriteLine();

                // 11. Print the remaining shipments
                Console.WriteLine("=".PadRight(50, '='));
                Console.WriteLine("Remaining Shipments");
                Console.WriteLine("=".PadRight(50, '='));
                center.PrintAllShipments();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("!!! An error occurred !!!");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static DeliveryAddress ReadAddress()
        {
            Console.Write("City: ");
            string city = Console.ReadLine();

            Console.Write("Street: ");
            string street = Console.ReadLine();

            Console.Write("Building Number: ");
            int buildingNumber = int.Parse(Console.ReadLine());

            return new DeliveryAddress(city, street, buildingNumber);
        }

        static StandardShipment ReadStandardShipment()
        {
            Console.Write("Tracking Code: ");
            string trackingCode = Console.ReadLine();

            Console.Write("Description: ");
            string description = Console.ReadLine();

            Console.Write("Weight: ");
            decimal weight = decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal deliveryFee = decimal.Parse(Console.ReadLine());

            DeliveryAddress address = ReadAddress();

            return new StandardShipment(trackingCode, description, weight, deliveryFee, address);
        }

        static ExpressShipment ReadExpressShipment()
        {
            Console.Write("Tracking Code: ");
            string trackingCode = Console.ReadLine();

            Console.Write("Description: ");
            string description = Console.ReadLine();

            Console.Write("Weight: ");
            decimal weight = decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal deliveryFee = decimal.Parse(Console.ReadLine());

            DeliveryAddress address = ReadAddress();

            Console.Write("Extra Fee: ");
            decimal extraFee = decimal.Parse(Console.ReadLine());

            return new ExpressShipment(trackingCode, description, weight, deliveryFee, address, extraFee);
        }

        static InternationalShipment ReadInternationalShipment()
        {
            Console.Write("Tracking Code: ");
            string trackingCode = Console.ReadLine();

            Console.Write("Description: ");
            string description = Console.ReadLine();

            Console.Write("Weight: ");
            decimal weight = decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal deliveryFee = decimal.Parse(Console.ReadLine());

            DeliveryAddress address = ReadAddress();

            Console.Write("Destination Country: ");
            string destinationCountry = Console.ReadLine();

            Console.Write("Customs Fee: ");
            decimal customsFee = decimal.Parse(Console.ReadLine());

            return new InternationalShipment(trackingCode, description, weight, deliveryFee, address,
                                              destinationCountry, customsFee);
        }
    }
            #endregion
}
