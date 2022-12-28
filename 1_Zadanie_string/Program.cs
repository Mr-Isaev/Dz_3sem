/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */
Console.Clear();
Console.WriteLine("Введите пятизначное число--> ");
int a = Convert.ToInt32(Console.ReadLine());
string b = Convert.ToString(a);
void Pallindrom(string b)
{
	if (b[0] == b[4] && b[1] == b[3] )
	{
		Console.WriteLine("Ёмаё, это же палиндром!");
	}
	else{
		Console.WriteLine("Ёмаё, это не палиндром:(");
	}
}
if(b.Length == 5){
	Pallindrom(b);
}
else{
	Console.WriteLine("Шалун, попросил же, пятизначное");
}
