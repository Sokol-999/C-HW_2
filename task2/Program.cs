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

