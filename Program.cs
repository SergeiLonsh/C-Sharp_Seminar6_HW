// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Введите число элементов массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int [] Array = new int [m];

// void FillArray (int m)
// {    
//     for (int i = 0; i < m; i++)
//     {
//         Console.WriteLine($"Введите {i+1}-й элемент массива ");
//         Array[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }
// int Total (int[] Array)
// {
// int i=0;
// int sum = 0;
// while (i < Array.Length)
// {
// if(Array[i]>0)
// sum++;
// i++;
// }
// return sum;
// }

// FillArray (m);
// Console.Write($"Чисел больше нуля: {Total(Array)}");
// __________________________________________________________________________________


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Введите значение b1: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение k1: ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение b2: ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение k2: ");
// int k2 = Convert.ToInt32(Console.ReadLine());

// int x = (b2-b1)/(k1-k2);
// int y = k1*x + b1;
// Console.WriteLine($"Точка пересечения имеет координаты х,y = "+(x,y));