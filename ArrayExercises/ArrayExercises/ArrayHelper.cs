using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
    public static class ArrayHelper
    {
        public static int[] Frequencies(int[] array)
        {
            if (array is null || array.Length == 0)
            {
                return new int[0];
            }

            int[] result = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                int counter = 0;

                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                    }
                }

                result[i] = counter;
            }

            return result;
        }
    }
}
