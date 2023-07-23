/* Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num <1000)
{
    int mid = (num % 100 | num % 10) / 10;
    Console.WriteLine($"Вторая цифра числа {num} является {mid}");
}
else Console.Write("Вы введил не трехзначное число!");*/

/* Напишите программу, которая выводит третью цифру заданного числа.
int ThirdDigit(int num)
{
    if (num >=100)
    while (num > 999)
    num = num / 10;
    int result = num % 10;
    return result;
}
 
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Третья цифра Вашего числа: {ThirdDigit(num)}"); */

/* Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.


bool WeekNum(int number)
{
    if (number >= 6 && number <= 7) return true;
    else return false;
}

Console.Write("Введите число дня недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = WeekNum(number);
Console.Write(result);*/
