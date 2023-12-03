using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SmirnovIA.Sprint6.Task0.V13.Lib
{
    public class DataService : ISprint6Task0V13
    {
        public double Calculate(int x)
        {
            double res = (Math.Pow(x, 3)) / (x * x - 1);
            return Math.Round(res, 3);
        }
    }
}
