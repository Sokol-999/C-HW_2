System.Console.WriteLine("Write a three digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (99 < number && number < 1000)
{
    int num = number / 10 % 10;
    System.Console.WriteLine(num);
}
else
{
    System.Console.WriteLine("It's a not three digit number");
}

//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1