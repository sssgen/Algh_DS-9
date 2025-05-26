using System;
using System.Text;
using levels;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Виберіть рівень завдання (1, 2 або 3):");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                FirstLevel.Solve();
                break;
            case "2":
                SecondLevel.Solve();
                break;
            case "3":
                ThirdLevel.Solve();
                break;
            default:
                Console.WriteLine("Невірний вибір.");
                break;
        }
    }
}
