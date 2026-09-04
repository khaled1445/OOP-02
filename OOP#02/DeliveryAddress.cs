using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace OOP_02
{
    internal struct DeliveryAddress
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }

        public DeliveryAddress(string city, string street, int buldingNumber) 
        {
            City = city;
            Street = street;
            BuildingNumber = buldingNumber;
        }

        public String GetFullAddress() 
        {
            return $" {BuildingNumber} : {Street} : {City}";
        }

    }
}
