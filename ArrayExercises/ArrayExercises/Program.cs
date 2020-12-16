using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "A", "B", "C", "D" };

            int[][] arrangementsIndices = ArrayHelper.Arrangements(array.Length, 3);

            for (int i = 0; i < arrangementsIndices.Length; i++)
            {
                int[] pairOfIndices = arrangementsIndices[i];
                foreach(int index in pairOfIndices)
                {
                    Console.Write($"{array[index]}, ");
                }

                Console.WriteLine();
            }

            // int[] array1 = { 1, 2, 3 };
            // int[] freq =  { 2, 2, 3, 2, 1, 3, 3, 2, 1 };

            // Array: 1, 2, 3
            //        0, 1, 2 ... n-1
            // 1) N = numarul de elemente ale array-ului
            // 2) K = cate elemente iau intr-o pereche

            // (0, 1) => (array[0]=1, array[1]=2)

            // Aranjamente (N=3, K = 2) :
            // (1, 2), (1, 3), (2, 1), (2, 3), (3, 1), (3, 2)
            // Aranjamente (N=3, K = 3) :
            // (1, 2, 3), (2, 1, 3), (2, 3, 1), (3, 1, 2), (3, 2, 1)

            ArrayHelper.Arrangements(4, 3);
        }
    }
}
