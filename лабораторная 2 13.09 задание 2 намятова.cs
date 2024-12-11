//Лабораторная №2. Задание 2. Math.Abs. На вход подается две переменных a и b. Нужно минимальное значение из двух переменны//
using System;
class HelloWorld {
	static void Main() {
		int a, b;
		a=Convert.ToInt32(Console.ReadLine());
		b=Convert.ToInt32(Console.ReadLine());
		Console.Write("Minimum ");
		Console.WriteLine((a + b - Math.Abs(a - b))/2);
	}
} 