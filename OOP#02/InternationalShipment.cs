using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_02
{
    internal class InternationalShipment : Shipment
    {
    
            private string destinationCountry;
            private decimal customsFee;

            public string DestinationCountry
            {
                get { return destinationCountry; }
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        destinationCountry = value;
                }
            }

            public decimal CustomsFee
            {
                get { return customsFee; }
                set
                {
                    if (value >= 0)
                        customsFee = value;
                }
            }

            public override string ShipmentTypeName => "International Shipment";

            public override decimal EstimatedCost => base.EstimatedCost + CustomsFee;

            public InternationalShipment(string trackingCode, string description, decimal weight,
                                          decimal deliveryFee, DeliveryAddress destination,
                                          string destinationCountry, decimal customsFee)
                : base(trackingCode, description, weight, deliveryFee, destination)
            {
                DestinationCountry = string.IsNullOrWhiteSpace(destinationCountry) ? "Unknown" : destinationCountry;
                CustomsFee = customsFee >= 0 ? customsFee : 0;
            }

            protected override void PrintExtraDetails()
            {
                Console.WriteLine($"Destination Country : {DestinationCountry}");
                Console.WriteLine($"Customs Fee          : {CustomsFee} EGP");
            
            }
    }
}
