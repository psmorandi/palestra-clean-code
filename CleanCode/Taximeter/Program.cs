using System;

namespace Taximeter
{
    using Good;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taxi trip calculator!");
            
            var taximeterCalc = new TaximeterCalculator();

            Console.WriteLine($"Should be normal fare? {taximeterCalc.CalcTrip(DateTime.Parse("2020-09-26 10:00:00"), 1000) == 2000}");
            Console.WriteLine($"Should be overnight fare? {taximeterCalc.CalcTrip(DateTime.Parse("2020-09-26 23:00:00"), 1000) == 4000}");
            Console.WriteLine($"Should be sunday fare? {taximeterCalc.CalcTrip(DateTime.Parse("2020-09-27 10:00:00"), 1000) == 3500}");
            Console.WriteLine($"Invalid distance? {taximeterCalc.CalcTrip(DateTime.Parse("2020-09-27 10:00:00"), -1000) == -1}");

            /*Console.WriteLine($"Should be normal fare? {taximeterCalc.CalcTrip(new Trip(DateTime.Parse("2020-09-26 10:00:00"), 1000)) == 2000}");
            Console.WriteLine($"Should be overnight fare? {taximeterCalc.CalcTrip(new Trip(DateTime.Parse("2020-09-26 23:00:00"), 1000)) == 4000}");
            Console.WriteLine($"Should be sunday fare? {taximeterCalc.CalcTrip(new Trip(DateTime.Parse("2020-09-27 10:00:00"), 1000)) == 3500}");
            try
            {
                taximeterCalc.CalcTrip(new Trip(DateTime.Parse("2020-09-27 10:00:00"), -1000));
            }
            catch
            {
                Console.WriteLine($"Invalid distance? true");
            }*/

        }
    }
}
