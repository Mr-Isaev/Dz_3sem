/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Clear();
Console.WriteLine("Введите пятизначное число--> ");
int a = Convert.ToInt32(Console.ReadLine());
int num1 = a / 10000;
int num2 = (a / 1000) % 10;
int num4 = (a / 10) % 10;
int num5 = a  % 10;
/* Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine(num4);
Console.WriteLine(num5); */
if (a<100000 && a > 9999){


if (num1 == num5 && num2 == num4)
{
Console.WriteLine("Это число является палиндромом");
}
else{
	Console.WriteLine("Это число не является палиндромом");
}
}
else{
	Console.WriteLine("А тут не пятизначное число, выйди и зайди нормально");
}