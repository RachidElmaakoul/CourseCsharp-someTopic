namespace CAException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Delivery = new Delivery() { Id = 123, CustomerName = "Rachid ElMaakoul", Address = "Morroco"};
            var Service = new DeliveryService();

            Service.Start(Delivery);
            Console.WriteLine(Delivery);

            Console.ReadLine();
        }
    }
}
