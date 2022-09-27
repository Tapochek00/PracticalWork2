using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_14
{
    public class Class1
    {
        public static int[] MatrixColSum(int[,] matr)
        { 
            int sum;
            int[] colSum = new int[matr.GetLength(1)];

            // Среднее арифметическое
            for(int i = 0; i < matr.GetLength(1); i++)
            {
                sum = 0;
                for(int j = 0; j < matr.GetLength(0); j++) sum += matr[j, i];

                for (int j = 0; j < matr.GetLength(0); j++)
                {
                    if(matr[j, i] > Convert.ToDouble(sum)/matr.GetLength(0))
                        colSum[i]++;
                }
            }

            return colSum;
        }

        /// <summary>
        /// Вычисление суммы элементов массива, меньших, чем какое-либо число
        /// </summary>
        /// <param name="max">Максимальное значение</param>
        /// <param name="arr">Массив</param>
        /// <returns></returns>
        public static int SumLessThan(int max, int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
                if (arr[i] < max) sum += arr[i];

            return sum;
        }

        /// <summary>
        /// Вычислить сумму целых случайных чисел, распределенных в диапазоне от 55 до 70,
        /// пока эта сумма не превышает некоторого числа K.
        /// </summary>
        /// <param name="k"></param>
        /// <param name="sum">Сумма</param>
        /// <param name="numbers">Слагаемые</param>
        /// <param name="count">Количество чисел</param>
        public static void RandomSum(int k, out int sum, out string numbers, out int count)
        {
            int theRandomNumber;
            count = 0;
            sum = 0;
            numbers = "";
            Random rand = new Random();

            while (sum < k)
            {
                theRandomNumber = rand.Next(55, 70);
                numbers += theRandomNumber.ToString() + "\n";
                sum += theRandomNumber;
                count++;
            }
        }
    }
}
