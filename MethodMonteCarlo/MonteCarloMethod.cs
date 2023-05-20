using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodMonteCarlo
{
    public class MonteCarloMethod
    {
        private static MonteCarloMethod singletone;
        private MonteCarloMethod(){}
        public static MonteCarloMethod GetObject()
        {
            if(singletone is null)
            {
                singletone = new MonteCarloMethod();
                return singletone;
            }
            else
            {
                return singletone;
            }
        }
        public double CalculatePi(double NumIter)
        {
            Random r = new Random();
            double k = 0;
            for (int i = 0; i < NumIter; i++)
            {
                double x = (r.NextDouble() * 4) - 2;
                double y = (r.NextDouble() * 4) - 2;
                if (x * x + y * y <= 4) k++;
            }
            return (k / NumIter) * 4;
        }
        public double CalculateSplashExample(double NumIter)
        {
            Random r = new Random();
            double k = 0;
            for (int i = 0; i < NumIter; i++)
            {
                double x = (r.NextDouble() * 9);
                double y = (r.NextDouble() * 5);
                if ((x/3 <= y) && (x * (10 - x) / 5) >= y) k++;
            }
            return (k / NumIter) * 45;
        }
    }
}
