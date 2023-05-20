namespace MethodMonteCarlo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество итераций при подсчете числа пи");
            Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculatePi(Convert.ToInt32(Console.ReadLine()))));
            Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculateSplashExample(Convert.ToInt32(Console.ReadLine()))));
        }
    }
}