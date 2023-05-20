namespace MethodMonteCarlo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество итераций при подсчете числа пи");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат расчета числа ПИ:");
            Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculatePi(r)));
            //Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculateSplashExample(Convert.ToInt32(Console.ReadLine()))));
            Console.WriteLine("Результат расчета примера:");
            Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculateSplashExample(1000000)));
            Console.WriteLine("Результат задачи 1:");
            //Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculateSplashZad1(Convert.ToInt32(Console.ReadLine()))));
            Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculateSplashZad1(10000000)));
            Console.WriteLine("Результат задачи 2:");
            //Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculateSplashZad2(Convert.ToInt32(Console.ReadLine()))));
            Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculateSplashZad2(10000000)));
            Console.WriteLine("Результат задачи 3:");
            //Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculateSplashZad3(Convert.ToInt32(Console.ReadLine()))));
            Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculateSplashZad3(10000000)));
            Console.WriteLine("Результат задачи 4:");
            //Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculateSplashZad4(Convert.ToInt32(Console.ReadLine()))));
            Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculateSplashZad4(10000000)));
            Console.WriteLine("Результат задачи 5:");
            //Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculateSplashZad5(Convert.ToInt32(Console.ReadLine()))));
            Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculateSplashZad5(10000000)));
            Console.WriteLine("Результат задачи 6:");
            //Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculateSplashZad6(Convert.ToInt32(Console.ReadLine()))));
            Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculateSplashZad6(10000000)));
        }
    }
}