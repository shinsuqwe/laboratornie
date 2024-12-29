// Лабораторная номер 3. 16.09 Задание 1. Дана последовательность из n элементов. Определить количество элементов меньше нуля. //
using System;
class HelloWorld {
	static void Main() {
		int a, k, n;
		a=Convert.ToInt32(Console.ReadLine());
		k=0;
		for (int i=0; i<=a; i++) {
			n=Convert.ToInt32(Console.ReadLine());
			if (n<0) k=k+1;
		}
		Console.WriteLine(k);
	}
}
