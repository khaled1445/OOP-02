using OOP_02;

namespace OOP_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OOP 01 - Smart Delivery Management System 
            #region Part 01 : Theoretical Questions

            #region Question 1 
            //a- DeliveryAddress variable:
            //first DeliveryAddress is a struct (value type) so when you take a copy in another value it makes
            //a new seprate stackframe in the stack put in the new data and the old variable doesn't affected

            //b- Customer variable:
            // Customer is a class (Refrence Type) so when you take a copy you just take the refrence in the stack and
            // it leads you to the same object in Heap so you'll OverWrite the old variable so the two variables will have
            // the same refreance so tthe old one will change to whe new var

            #endregion

            #region Question02
            //a) 1- all fields are public so it's not prevented and anyone can modify it
            //2- there is no validation so the value can be negative 
            //3- the input in description var can bee null 

            //b) if you used private keywork instead of public now the code outside the struct canno't be acssessed outside the 
            // struct so you can put the setters and getters to validate all fields  
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