void Zadacha41()
{

    //Задача 41: Пользователь вводит с клавиатуры M чисел.
    //Посчитайте, сколько чисел больше 0 ввёл пользователь.
    Console.WriteLine("Добрый день!");
    Console.WriteLine("Введите числа через проблел!");
    string A = Console.ReadLine();
    string[] ASplit = A.Split();
    int i=0;
    int sum = 0;
        if(Convert.ToInt32(ASplit[i]) !=0)
        {
            if(Convert.ToInt32(ASplit[i])>0)
            {
                i++;
                sum++;
            }
            else if(Convert.ToInt32(ASplit[i])<0)
            {
                i++;
            }       
        }
    Console.WriteLine($"Количество положительных введеных чисел = {sum}");
}



void Zadacha43()
{
    /* Задача 43. Напишите программу, которая найдёт точку
    пересечения двух прямых, заданных уравнениями y = k1 *
    x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
    пользователем. */

    Console.WriteLine("Добрый день! Сегодня будем искать точку пересечения прямых");
    Console.WriteLine("  ");
    Console.WriteLine("Введите значение b1");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение k1");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение b2");
    int b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение k2");
    int k2 = Convert.ToInt32(Console.ReadLine());

    int y=0;
    int x=0;
    x = (b2-b1) / (k1-k2);
    y = x*k1+b1;

    Console.WriteLine($"Координаты точки пересечний ({x},{y})");
}


Zadacha41();
//Zadacha43();

