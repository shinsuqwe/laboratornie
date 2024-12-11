//Лабораторная №2. Задание 3. Путь при поливе грядок. k - расстояние до колодца; l и m - размер грядки; n - колво грядок//
using System;
class HelloWorld {
	static void Main() {
		int p, k, l, m, n;
		k=Convert.ToInt32(Console.ReadLine());
		l=Convert.ToInt32(Console.ReadLine());
		m=Convert.ToInt32(Console.ReadLine());
		n=Convert.ToInt32(Console.ReadLine());
		p=(n*2*k)+(n*2*(m+l))+(m*n*(n-1));
		Console.WriteLine(p);
	}
} 
//Намятова Анастасия Валерьевна ФИТ-242//