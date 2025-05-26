using System;

namespace levels
{
    public static class SecondLevel
    {
        public static void Solve()
        {
            int n = 5; 
            int k = 8; 

            Console.WriteLine($"Обчислення кількості паролів довжини {k} з {n} голосних букв (з повтореннями).");

            double count = Math.Pow(n, k);
            Console.WriteLine($"Кількість різних паролів: {count:N0}");
        }
    }
}
