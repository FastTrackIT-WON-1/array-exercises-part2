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

        public static int[][] CartesianProduct(int[] array1, int[] array2)
        {
            if (array1 is null || 
                array2 is null || 
                array1.Length == 0 ||
                array2.Length == 0)
            {
                return new int[0][];
            }


            int[][] result = new int[array1.Length * array2.Length][];

            for (int i = 0, jaggedIndex = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    result[jaggedIndex] = new[] { array1[i], array2[j] };
                    jaggedIndex++;
                }
            }

            return result;
        }
    }
}
