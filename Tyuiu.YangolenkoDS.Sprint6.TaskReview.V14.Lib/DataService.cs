using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tyuiu.YangolenkoDS.Sprint6.TaskReview.V14.Lib
{
    public class DataService
    {

        public int[,] GetMatrix(int N, int M, int n1, int n2)
        {
            if (N > 1 && M > 1 && n2 > n1)
            {
                int[,] array = new int[N, M];
                Random rand = new Random();
                int count = 1;
                int num1 = 0;
                int num2 = 0;
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        array[i, j] = rand.Next(n1, n2);
                        if (count == 1)
                        {
                            num1 = array[i, j];
                        }
                        else if (count == 2)
                        {
                            num2 = array[i, j];
                        }
                        else if (count == 3)
                        {
                            int mult = num1 * num2;
                            array[i, j] = mult;
                            count = 0;
                        }
                        
                        count++;
                        
                    }
                }

                return array;
            }
            else { throw new ArgumentException("Ошибка, введены неверные данные"); }
        }
        public int Result(int[,] array, int c, int k, int l)
        {
            int res = 1;
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == c)
                    {
                        if (i >= k && i <= l)
                        {
                            if (i % 2 == 0)
                            {
                                res *= array[i, j];
                            }
                        }
                    }
                }
            }
            return res;
        }
    }
}
