/*
Задача 22: Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) Console.WriteLine("Некорректный ввод");
else Table(number);
/*int n = 1;
while (n <=number)
{
    Console.WriteLine ($"{n}   {n*n}");
    n++;
}
*/
void Table(int number)
{
    int count = 1;
    while (count <= number)

    {
        Console.WriteLine($"{count,4}   {count * count,4}");
        count++;
    }
}
