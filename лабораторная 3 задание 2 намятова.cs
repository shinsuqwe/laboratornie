// Лабораторная номер 3. 16.09 Задание 2. Определить среди элементов второй максимальный элемент. //
using System;
class HelloWorld {
	static void Main() {
		int a, n, max, max2;
		a=Convert.ToInt32(Console.ReadLine());
		max=0;
		max2=0;
		for (int i=1; i<=a; i++) {
			n=Convert.ToInt32(Console.ReadLine());
			if (n>max) {
				max2=max;
				max=n;
			}
		}
		Console.WriteLine(max2);
	}
}
//Намятова Анастасия Валерьевна ФИТ-242. // 