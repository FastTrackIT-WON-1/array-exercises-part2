using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
    public enum StackMode
    {
        GoUp = 0,

        IncrementCurrent,

        GoDown
    };

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

        public static int[][] Arrangements(int n, int k)
        {
            if (n < 1 || k > n)
            {
                return new int[0][];
            }

            List<int[]> results = new List<int[]>();
            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            StackMode stackMode = StackMode.GoUp;

            while (stack.Count > 0)
            {
                switch (stackMode)
                {
                    case StackMode.GoUp:
                        bool canGoUp = stack.Count < k;
                        if (canGoUp)
                        {
                            // incercam sa urcam
                            for (int i = 0; i < n; i++)
                            {
                                bool isValidValue = !stack.Contains(i);
                                if (isValidValue)
                                {
                                    // pot urca
                                    stack.Push(i);

                                    bool isSolution = stack.Count == k;
                                    if (isSolution)
                                    {
                                        int[] solutionArray = stack.ToArray();
                                        Array.Reverse(solutionArray);

                                        results.Add(solutionArray);
                                        // Console.WriteLine(string.Join(", ", stack));
                                    }

                                    // am reusit sa pun o valoare valida pe nivelul curent
                                    // si continui sa incerc sa urc in stiva
                                    break;
                                }
                            }
                        }
                        else
                        {
                            stackMode = StackMode.IncrementCurrent;
                        }
                        break;

                    case StackMode.IncrementCurrent:
                        int nextValue = stack.Peek() + 1;
                        while (nextValue < n)
                        {
                            bool isValidValue = !stack.Contains(nextValue);
                            if (isValidValue)
                            {
                                stack.Pop();
                                stack.Push(nextValue);

                                bool isSolution = stack.Count == k;
                                if (isSolution)
                                {
                                    int[] solutionArray = stack.ToArray();
                                    Array.Reverse(solutionArray);

                                    results.Add(solutionArray);
                                    // Console.WriteLine(string.Join(", ", stack));
                                }
                                else
                                {
                                    stackMode = StackMode.GoUp;
                                }
                                
                                break;
                            }

                            nextValue++;
                        }

                        if (nextValue >= n)
                        {
                            stackMode = StackMode.GoDown;
                        }
                        break;

                    case StackMode.GoDown:
                        bool canGoDown = stack.Count > 0;
                        if (canGoDown)
                        {
                            stack.Pop();
                            stackMode = StackMode.IncrementCurrent;
                        }
                        break;
                }
            }

            return results.ToArray();
        }
    }
}
