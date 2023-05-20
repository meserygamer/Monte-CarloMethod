namespace MethodMonteCarlo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество итераций при подсчете числа пи");
            Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculatePi(Convert.ToInt32(Console.ReadLine()))));
            //Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculateSplashExample(Convert.ToInt32(Console.ReadLine()))));
            Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculateSplashExample(1000000)));
            //Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculateSplashZad1(Convert.ToInt32(Console.ReadLine()))));
            Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculateSplashZad1(10000000)));
            //Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculateSplashZad2(Convert.ToInt32(Console.ReadLine()))));
            Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculateSplashZad2(10000000)));
            //Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculateSplashZad3(Convert.ToInt32(Console.ReadLine()))));
            Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculateSplashZad3(10000000)));
        }
    }
}