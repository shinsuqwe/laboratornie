//Лабораторная №2. Задание 1. На вход подается две переменных a и b. Необходимо поменять местами две переменных не используя третье//
using System;
class HelloWorld {
	static void Main() {
		int a, b;
		a=Convert.ToInt32(Console.ReadLine());
		b=Convert.ToInt32(Console.ReadLine());
		a=a+b;
		b=a-b;
		a=a-b;
		Console.WriteLine(a);
		Console.WriteLine(b);
	}
} 