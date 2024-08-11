using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CAException
{
    public class DeliveryService
    {
        private readonly static Random random = new Random();
        public void Start(Delivery delivery)
        {
            try
            {
                Process(delivery);
                Shopping(delivery);
                Intransit(delivery);
                Delivered(delivery);
            }
            // Custom Exception
            catch (AccidentException ex)
            {
                Console.WriteLine($" there was an Accident At {ex.Location} preventig us from Delivering your parcel : {ex.Message}");
                delivery.DeliveryStatus = DeliveryStatus.UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Delivery Fails due to: {ex.Message}");
                delivery.DeliveryStatus = DeliveryStatus.UNKNOWN;
            }
        }

        private void Process(Delivery delivery)
        {
            FakeIT("PROCESSING");
            if (random.Next(1,10) == 1) 
            {
                throw new InvalidOperationException("Unable to Process the item");
            }
            delivery.DeliveryStatus = DeliveryStatus.PROCESSED;

        } private void Shopping(Delivery delivery)
        {
            FakeIT("SHOPPING");
            if (random.Next(1, 10) == 1)
            {
                throw new InvalidOperationException("parcel is damaged during loading the Process");
            }
            delivery.DeliveryStatus = DeliveryStatus.SHIPPED;

        } private void Intransit(Delivery delivery)
        {
            FakeIT("ON THE WAY");
            if (random.Next(1,5) == 1)
            {
                throw new AccidentException("234 Next Streat Morocco", "ACCIDENT !!!!!");
            }
            delivery.DeliveryStatus = DeliveryStatus.INTRANSIT;

        } private void Delivered(Delivery delivery)
        {
            FakeIT("DELIVERED");
            if (random.Next(1, 5) == 1)
            {
                throw new InvalidAddressException($"'{delivery.Address}' is Invalid !!!");
            }
            delivery.DeliveryStatus = DeliveryStatus.DELIVERED;

        }

        private void FakeIT(string titel)
        {
            Console.Write(titel);
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".\n");
        }
    }
}
