System.Console.WriteLine("Write a three digit number: ");
string array = Console.ReadLine();

int length = array.Length;

if (length==3)
{
    System.Console.WriteLine("The second digit of the number: ");
    System.Console.WriteLine(array[1]);
}
else
{
    System.Console.WriteLine("EROR-need a three digit number");
}

//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1