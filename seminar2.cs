// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Enter 3-digit Number:");

string strNumber = Console.ReadLine();

int digitnumber = Convert.ToInt32(strNumber);
while ((digitnumber >= 100)&&(digitnumber<999))
{
int secondNum = digitnumber/10%10;

Console.WriteLine($"SecondNum = {secondNum}");

break;
}
Console.WriteLine("not a 3-digit number");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Enter Number:");

string strthrdNumber = Console.ReadLine();

int number = Convert.ToInt32(strthrdNumber);

if (number < 100)
{
    Console.WriteLine("no 3rd digit");
}
else if ((number >= 100)&&(number <=999))
{
    int thirdNum = number%10;
    Console.WriteLine($"thirdNum = {thirdNum}");
}
else if ((number >= 1000)&&(number <= 9999))
{
    int thirdNum = number/10%10;

    Console.WriteLine($"thirdNum= {thirdNum}");
}
else if ((number >= 10000)&&(number <= 99999))
{
    int thirdNum = number/100%10;

    Console.WriteLine($"thirdNum= {thirdNum}");
}
else 
{
    Console.WriteLine("I'M TIRED!!!!");
}
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Enter Number from 1 to 7:");

string strNumberDayWeek = Console.ReadLine();

int numberDayWeek = Convert.ToInt32(strNumberDayWeek);
while (numberDayWeek <= 7)
{
    if ((numberDayWeek >=1)&&(numberDayWeek <=6))
    {
    Console.WriteLine("Oh, no! It's a working day.");
    }
    else
    {
    Console.WriteLine("Oh, yes! Day of rest.");
    }
break;
}

Console.WriteLine("Be attentive! Enter Number from 1 to 7.");

