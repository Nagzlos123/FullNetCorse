namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMV", 3200);
            Motocycle motocycle = new Motocycle("Honda", 600);

            Console.WriteLine(car);
            Console.WriteLine(motocycle);

            StartVehicle(car);
            StartVehicle(motocycle);

            Console.WriteLine(car);
            Console.WriteLine(motocycle);
        }

        static void StartVehicle(Vehicle vehicle)
        {
            vehicle.Start();
        }
    }
}
