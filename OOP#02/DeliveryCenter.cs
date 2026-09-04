using OOP_02;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_02
{
    internal struct DeliveryCenter
    {
        private Shipment[] shipments;
        private const int capacity = 10;
        private int count;

        public int Count { get; set; }
        public Shipment this[int index]
        {
            get
            {
                if (shipments == null || index < 0 || index >= shipments.Length)
                {
                    return default;

                }
                return shipments[index];

            }

            set
            {
                if (shipments == null)
                {
                    shipments = new Shipment[capacity];
                }

                if (index < 0 || index > shipments.Length)
                {
                    return;
                }
                shipments[index] = value;

            }

        }

        public Shipment this[string trackingCode]
        {
            get
            {
                if (shipments != null)
                {
                    foreach (Shipment shipment in shipments)
                    {
                        if (shipment.TrackingCode == trackingCode)
                            return shipment;
                    }
                    return default;
                }
                return default;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            if (shipments == null)
                shipments = new Shipment[capacity];

            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i].TrackingCode == null)
                {
                    shipments[i] = shipment;
                    Console.WriteLine("added succesfully");
                    return true;
                }
            }
            return false;

        }
    }
}