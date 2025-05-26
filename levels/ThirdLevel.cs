using System;
using System.Collections.Generic;
using System.IO;

namespace levels
{
    public static class ThirdLevel
    {
        public static void Solve()
        {
            int n = 15;
            int k = 3;
            string fileName = "combinations.txt";

            Console.WriteLine($"Генерація поєднань {k} з {n} у лексикографічному порядку та запис у файл {fileName}");

            var combinations = GenerateCombinations(n, k);

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var combo in combinations)
                {
                    writer.WriteLine(string.Join(", ", combo));
                }
            }

            Console.WriteLine("Генерація завершена, результат записано у файл.");
        }

        private static List<List<int>> GenerateCombinations(int n, int k)
        {
            var results = new List<List<int>>();
            var combo = new int[k];
            Generate(1, 0);

            void Generate(int start, int depth)
            {
                if (depth == k)
                {
                    results.Add(new List<int>(combo));
                    return;
                }
                for (int i = start; i <= n - (k - depth) + 1; i++)
                {
                    combo[depth] = i;
                    Generate(i + 1, depth + 1);
                }
            }

            return results;
        }
    }
}
