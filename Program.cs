// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

/*Console.Write("Input a first number:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number:");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;

if (a > b)
{
    Console.WriteLine($"Max number first {a}");
}
else
{
    Console.WriteLine($"Max number second {b}");
}
*/


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

/*Console.Write("Input a first number:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number:");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number:");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (b > a)
if (b > c)
{
    Console.WriteLine($"Max number first {b}");
}
if (c > a)
if (c > b)
{
    Console.WriteLine($"Max number second {c}");
}
else
{
    Console.WriteLine($"Max number second {a}");
}

*/

/*// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//  является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Проверим, является ли данное число чётным:");
int num = Convert.ToInt32(Console.ReadLine());
int number = num % 2;

if(number == 0)
Console.WriteLine("Yes");
else
Console.WriteLine("No");

*/
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Найдём все чётные числа от 1 до:");
int N = Convert.ToInt32(Console.ReadLine());

int b = 2;

 while(b <= N)
 {
    Console.Write(b + " ");
    b += 2;
 }