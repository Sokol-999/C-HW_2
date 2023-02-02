//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

System.Console.WriteLine("Write a number: ");
string number = Console.ReadLine();
int length=number.Length;
int index=0;
if (length<3)
{
    System.Console.WriteLine("ERROR");
}
else
{
    System.Console.WriteLine(number[2]);
}