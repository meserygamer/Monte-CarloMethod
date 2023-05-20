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
    }
}
