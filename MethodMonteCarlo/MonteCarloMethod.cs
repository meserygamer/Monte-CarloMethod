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
        public double CalculateSplashZad1(double NumIter)
        {
            Random r = new Random();
            double k = 0;
            for (int i = 0; i < NumIter; i++)
            {
                double x = (r.NextDouble() * 20) - 5;
                double y = r.NextDouble();
                if ((y >= 0) && (y <= Math.Sin(x))) k++;
            }
            return (k / NumIter) * 20;
        }
        public double CalculateSplashZad2(double NumIter)
        {
            Random r = new Random();
            double k = 0;
            for (int i = 0; i < NumIter; i++)
            {
                double x = (r.NextDouble() * 10);
                double y = (r.NextDouble() * 10);
                if ((x / 2 <= y) && (x * (8 - x) / 2) >= y) k++;
            }
            return (k / NumIter) * 100;
        }
        public double CalculateSplashZad3(double NumIter)
        {
            Random r = new Random();
            double k = 0;
            for (int i = 0; i < NumIter; i++)
            {
                double x = (r.NextDouble() * 15);
                double y = (r.NextDouble() * 6);
                if (y >= ((x - 6) * (x - 6) / 6) && (y <= 6)) k++;
            }
            return (k / NumIter) * 90;
        }
        public double CalculateSplashZad4(double NumIter)
        {
            Random r = new Random();
            double k = 0;
            for (int i = 0; i < NumIter; i++)
            {
                double x = (r.NextDouble() * 15);
                double y = (r.NextDouble() * 4);
                if ((x / 5 <= y) && (x * (12 - x) / 9) >= y) k++;
            }
            return (k / NumIter) * 60;
        }
        public double CalculateSplashZad5(double NumIter)
        {
            Random r = new Random();
            double k = 0;
            for (int i = 0; i < NumIter; i++)
            {
                double x = (r.NextDouble() * 8);
                double y = (r.NextDouble() * 4);
                if (y >= (8 - x) / 8 && y <= (x * (8 - x) / 4)) k++;
            }
            return (k / NumIter) * 32;
        }
        public double CalculateSplashZad6(double NumIter)
        {
            Random r = new Random();
            double k = 0;
            for (int i = 0; i < NumIter; i++)
            {
                double x = (r.NextDouble() * 3);
                double y = (r.NextDouble() * 1);
                if (y >= (x - 2) * (x - 2) / 2 && y <= Math.Sin(x)) k++;
            }
            return (k / NumIter) * 3;
        }
    }
}
