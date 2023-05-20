namespace MethodMonteCarlo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((double)(MonteCarloMethod.GetObject().CalculatePi(10000000)));
        }
    }
}