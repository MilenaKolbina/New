using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New
{
    class ClassNew
    {
        int[,] numbers;

        public ClassNew()
        {
            numbers = new int[5, 5];

        }

        public ClassNew(int count_rows, int count_cols)
        {
            numbers = new int[count_rows, count_cols];
        }

         public ClassNew(int count_rows, int count_cols, int min, int max)
         {
            numbers = new int[count_rows, count_cols];
            Random random = new Random();
            for(int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(min, max + 1);
                }
            }
         }


        public ClassNew(int[,] _numbers)
        {
            numbers = _numbers;
        }
    }
}
