using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SmirnovIA.Sprint6.Task7.V24.Lib
{
    public class DataService : ISprint6Task7V24
    {
        public int[,] GetMatrix(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            for (int c = 0; c < columns; c++)
            {
                if (matrix[1, c] % 2 == 0)
                {
                    matrix[1, c] = 1;
                }
            }
            return matrix;
        }
    }
}
