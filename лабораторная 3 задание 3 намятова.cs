// Лабораторная номер 3. 16.09 Задание 3. Определить количество элементов, являющихся локальными минимумами. //
using System;
class HelloWorld {
	static void Main() {
		int a, k=0, n1, n2, n3;
		a=Convert.ToInt32(Console.ReadLine());
		n1=Convert.ToInt32(Console.ReadLine());
		n2=Convert.ToInt32(Console.ReadLine());
		for (int i=1; i<a-1; i++) {
			n3=Convert.ToInt32(Console.ReadLine());
			if (n2<n1) {
				if (n2<n3) k=k+1;
			}
			n1=n2;
			n2=n3;
		}
		Console.WriteLine(k);
	}
}
//Намятова Анастасия Валерьевна ФИТ-242. // 