using System.Security.Cryptography.X509Certificates;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Please type the number of tires on this vehicle");

            int numTires = int.Parse(Console.ReadLine());
            IVehicle vehicle = VehicleFactory.GetVehicle(numTires);
            vehicle.Drive();
        }
    }
}
