
using ConsoleAppTest;
using System;
using System.Collections;
using System.Security.Cryptography;

public class Program
{
    public static void Main()
    {

        Weapon katana = new Weapon("Katana", "Sword", 50, 2.5f,50);
        Player deadly = new Player("Deadly", 100, 20,200);
        Enemy goblin = new Enemy("Goblin", 200, 5, 50);

        Console.WriteLine("Initial weapon and enemy status:");

        katana.Inspect();
        goblin.Inspect();

        Console.WriteLine("Battle begins:");
        deadly.SpecialAttack(goblin, katana, 80);
        deadly.AttackEnemy(goblin, katana);
        katana.Upgrade(10);
        deadly.AttackEnemy(goblin, katana);
        deadly.AttackEnemy(goblin, katana);
        goblin.AttackPlayer(deadly);
        goblin.Inspect();

        Console.ReadKey();



    }

    
    public static string IsValidString(string prompt, int minLength, int maxLength)
    {
        while (true)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(value) || value.Length < minLength || value.Length > maxLength)
            {
                Console.WriteLine($"❌ ERROR: You must enter a string between {minLength} and {maxLength} characters.");
            }
            else
            {
                return value;
            }
        }
    }
    public static int isValidInt(string prompt, int min, int max)
    {
        int value;
        while (true)
        {
            Console.Write(prompt);
            bool isValid = int.TryParse(Console.ReadLine(), out value);

            if (!isValid || value < min || value > max)
            {
                Console.WriteLine($"❌ ERROR: You must enter a number between {min} and {max}.");
            }
            else
            {
                return value;
            }
        }
    }
    public static double isValidDouble(string prompt, int min, int max)
    {
        double value;
        while (true)
        {
            Console.Write(prompt);
            bool isValid = double.TryParse(Console.ReadLine(), out value);

            if (!isValid || value < min || value > max)
            {
                Console.WriteLine($"❌ ERROR: You must enter a number between {min} and {max}.");
            }
            else
            {
                return value;
            }
        }
    }
    public static double calcularPromedio(double[] notas)
    {
        double sum_notas = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            sum_notas += notas[i];
        }
        return sum_notas / notas.Length;
    }
}