// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Фрилунд А.

using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        Clear();

        WriteLine("Введите число 1: ");
        int number1 = Convert.ToInt32(ReadLine());
        WriteLine("Введите число 2: ");
        int number2 = Convert.ToInt32(ReadLine());
        WriteLine("Введите число 3: ");
        int number3 = Convert.ToInt32(ReadLine());

        int max = number1;

        if (max < number2) max = number2;
        if (max < number3) max = number3;

        WriteLine("");
        WriteLine("Результаты:");
        WriteLine($"Наибольшем из трех чисел является: {max}");
    }
}