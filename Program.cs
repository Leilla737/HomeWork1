/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

/*Решение1*/
/*Console.WriteLine("Input number1");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number2");
int numB = Convert.ToInt32(Console.ReadLine());


if (numA > numB)
{
 Console.WriteLine($" {numA}");   
}

if (numA < numB);
{
 Console.WriteLine($"{numB}"); 
}*/

/*Решение2*/
/*Console.WriteLine("Input number1");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number2");
int numB = Convert.ToInt32(Console.ReadLine());


if (numA > numB)
{
 Console.WriteLine($"Max {numA}, Min {numB}");   
 
}

if (numA < numB);
{
 Console.WriteLine($"Min {numA}, Max {numB}"); 
}*/

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт
 максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

/*Console.WriteLine("Input num1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input num2");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input num3");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max)

{
max = num2;
}

 if (num3 > max)
{
max = num3;
}

Console.WriteLine("Наибольшее из введённых чисел -> " + max);*/


/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

/*Console.WriteLine("Input number1");
int num = Convert.ToInt32(Console.ReadLine());


if (num % 2 == 1 || num % 2 == -1)

{
Console.WriteLine("нет");
}
else
{
Console.WriteLine("да");
}*/

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на 
выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

/* Console.WriteLine("Input num");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;  
while (count < num)
{
if (count % 2 == 0) 
   {
    Console.WriteLine(count + " ");
   }   
    count++;  
} */
// 



  
        
   // Домашнее задание 28.11.22 
/* Задача 10: Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */


/* int number = ReadInt("Введите трехзначное число: ");
int chislo = number.ToString().Length;

if (chislo < 3 || chislo > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(number));
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
} */

/* Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

/* int number = ReadInt("Введите  число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
} */

/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */


/*int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(Work(dayNumber));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string Work(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write( + a + " - Да");
        }
        else
        {
            Console.Write( + a + " - Нет");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
    }
    return "!";
}*/

      
// Домашнее задание урок 6 Одномерные массивы
 /* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.

 Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"прямые пересекутся в точке Х:  {x}, Y: {y}");*/

//Задача 41: Пользователь вводит с клавиатуры M чисел. 
  // Посчитайте, сколько чисел больше 0 ввёл пользователь
// !!!!!!она не работает

/*Console.WriteLine("Введите числа ");
int m = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < m; i++) {
numbers.Add(Convert.ToInt32(Console.ReadLine()));
}
Console.WriteLine(numbers.Where(n => n > 0).Count());
Console.ReadKey();*/



