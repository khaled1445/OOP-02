using OOP_02;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace OOP_02{
    internal class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        public DeliveryAddress Destination { set; get; }

        public string TrackingCode
        {
            get
            {
                return trackingCode;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("TrackingCode cannot be empty or whitespace");
                    return;
                }
                trackingCode = value;

            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Description cannot be empty or whitespace");
                    return;
                }
                description = value;

            }
        }

        public decimal Weight
        {
            get
            {
                return weight;
            }

            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                    Console.WriteLine("Enter a Valid number");
            }
        }
        public decimal DeliveryFee
        {
            get
            {
                return deliveryFee;
            }
            private set
            {
                if (value > 0)
                    deliveryFee = value;
                else
                    Console.WriteLine("Enter a Valid Number");
            }
        }

        public virtual decimal EstimatedCost => DeliveryFee + (Weight * 5);

        public virtual string ShipmentTypeName => "Shipment";

        public Shipment(string trackingCode)
        {
            TrackingCode = string.IsNullOrWhiteSpace(trackingCode) ? "wrong" : trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);
        }

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = string.IsNullOrWhiteSpace(trackingCode) ? "UNKNOWN" : trackingCode;
            Description = string.IsNullOrWhiteSpace(description) ? "Unknown" : description;
            Weight = weight > 0 ? weight : 1;
            DeliveryFee = deliveryFee > 0 ? deliveryFee : 50;
            Destination = (destination);
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;
        }

        protected virtual void PrintExtraDetails()
        {

        }

        public virtual void PrintShipment()
        {
            Console.WriteLine($"Traching Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"DeliveryFee: {DeliveryFee} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()} ");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

    }
}