
using CarFactory;

namespace Caractory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== GAS CAR ===");
            TestCar(EngineType.Gas);

            Console.WriteLine("\n=== ELECTRIC CAR ===");
            TestCar(EngineType.Electric);

            Console.WriteLine("\n=== HYBRID CAR ===");
            TestCar(EngineType.Hybrid);

            Console.WriteLine("\n=== ENGINE REPLACEMENT TEST ===");
            TestEngineReplacement();
        }

        static void TestCar(EngineType type)
        {
            var car = CarFactory.CreateCar(type);

            car.Start();

            car.Accelerate(); // 20
            car.Accelerate(); // 40
            car.Accelerate(); // 60

            car.Brake();      // 40

            car.Stop();
        }

        static void TestEngineReplacement()
        {
            var car = CarFactory.CreateCar(EngineType.Gas);

            car.Start();
            car.Accelerate(); // 20
            car.Stop();

            Console.WriteLine(">>> Replacing engine with Hybrid <<<");

            CarFactory.InstallEngine(car, EngineType.Hybrid);

            car.Start();
            car.Accelerate(); // 20 → Electric
            car.Accelerate(); // 40 → Electric
            car.Accelerate(); // 60 → Switch to Gas
            car.Stop();
        }
    }
}
