using System;
using System.Collections.Generic;

namespace levels
{
    public static class FirstLevel
    {
        public static void Solve()
        {
            int n = 15;
            int k = 3;

            Console.WriteLine($"Обчислення кількості команд з {k} студентів з {n} учасників (поєднання без повторень).");

            long count = Combination(n, k);
            Console.WriteLine($"Кількість різних команд: {count}");

            Console.WriteLine("\nВсі поєднання:");

            var combinations = GenerateCombinations(n, k);
            foreach (var combo in combinations)
            {
                Console.WriteLine(string.Join(", ", combo));
            }
        }

        private static long Combination(int n, int k)
        {
            if (k > n) return 0;
            if (k == 0 || k == n) return 1;

            long result = 1;
            for (int i = 1; i <= k; i++)
            {
                result = result * (n - i + 1) / i;
            }
            return result;
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
