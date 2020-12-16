using System;

namespace ArrayExercises
{
    public static class Utils
    {
        public static int ReadNumber(string label)
        {
            if (string.IsNullOrEmpty(label))
            {
                label = "Please enter a numeric value=";
            }

            Console.Write(label);
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int result))
            {
                throw new Exception($"Input '{input}' does not represent a valid number");
            }

            return result;
        }
    }
}
