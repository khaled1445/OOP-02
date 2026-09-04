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

            //b) Why are classes more suitable than structs for large applications?

            #endregion

            #region Question 2 Consider the following code:
            //a) Which class is the parent class?

            //b) Which class is the child class?

            //c) What members are inherited by ExpressShipment?

            //d) Why is inheritance better than duplicating the same code in multiple classes?
            //
            #endregion

            #endregion


        #region Part 02 : Practical (Smart Delivery Management System)




            DeliveryCenter deliveryCenter01 = new DeliveryCenter();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"please enter Shipment{i} ");

                Console.WriteLine("Traking Code:");
                string trackingCode = Console.ReadLine();

                Console.WriteLine("==============================");

                Console.WriteLine("Description:");
                string description = Console.ReadLine();

                Console.WriteLine("==============================");

                Console.WriteLine("Weight:");
                double weight = double.Parse(Console.ReadLine());

                Console.WriteLine("==============================");

                Console.WriteLine("Delivery Fee:");
                decimal deliveryFee = decimal.Parse(Console.ReadLine());

                Console.WriteLine("==============================");

                Console.WriteLine("City:");
                string city = Console.ReadLine();

                Console.WriteLine("==============================");

                Console.WriteLine("Street:");
                string street = Console.ReadLine();

                Console.WriteLine("==============================");

                Console.WriteLine("Building Number:");
                int buildingNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("==============================");

                DeliveryAddress deliveryAddress = new DeliveryAddress(city, street, buildingNumber);
                Shipment shipment = new Shipment(trackingCode, description, weight, deliveryFee, deliveryAddress);

                bool added = deliveryCenter01.AddShipment(shipment);
                Console.WriteLine(added ? "Shipment added successfully." : "Delivery center is full.");
                Console.WriteLine();

            }
            Console.WriteLine("All Shipments");
            for (int i = 0; i < 3; i++)
            {
                deliveryCenter01[i].PrintShipment();
                Console.WriteLine();
            }

            Console.WriteLine("Enter the Tracking Code to Search");
            string searchCode = Console.ReadLine();

            Shipment found = deliveryCenter01[searchCode];

            if (found.TrackingCode != null)
            {
                Console.WriteLine($"shipment found {found.TrackingCode} - {found.Description}");
            }
            else
                Console.WriteLine("shipment wasn't found");


            DeliveryAddress originalDA = new DeliveryAddress("Beni Suef", "Bosta", 6);
            DeliveryAddress copyDA = originalDA;

            Console.WriteLine("=================================");
            Console.WriteLine("struct copy test");
            copyDA.City = "Cairo";
            copyDA.Street = "faisal";
            copyDA.BuildingNumber = 10;
            Console.WriteLine($"Original: " + originalDA.GetFullAddress());
            Console.WriteLine($"Copy: " + copyDA.GetFullAddress());


            #endregion
        }

    }

}