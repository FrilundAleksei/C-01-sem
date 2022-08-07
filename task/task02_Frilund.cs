// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Фрилунд А.

using static System.Console; 
Clear(); 

WriteLine("Введите число 1: "); 
int number1 = Convert.ToInt32 (ReadLine());  
WriteLine("Введите число 2: "); 
int number2 = Convert.ToInt32 (ReadLine()); 

if (number1 <= number2)  
{
    WriteLine("");
    WriteLine("Результаты:");
    WriteLine($"Наибольшее из двух чисел: {number2}"); 
    WriteLine($"Наименьшее из двух чисел: {number1}"); 
} 
        