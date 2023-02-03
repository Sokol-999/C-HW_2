//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

System.Console.WriteLine("Write a namber: ");
int day = Convert.ToInt32(Console.ReadLine());
if (0 < day && day < 8)
{
    if (5 < day && day < 8)
    {
        System.Console.WriteLine("YES");
    }
    else
    {
        System.Console.WriteLine("NO");
    }
}

else
{
    System.Console.WriteLine("This is joke?");
}