//Лабораторная работа №4. 30.09 Задание 2. Определить минимальную подпоследовательность, состояющую из нулей//
using System;
class HelloWorld {
  static void Main() {
    int razmax=100000, n, a1, razmer=0;
    n=Convert.ToInt32(Console.ReadLine());
    for (int i=0; i < n; i++) {
        a1=Convert.ToInt32(Console.ReadLine());
        if(a1==0) {
            razmer=razmer+1;
            if (razmer < razmax && razmer !=0) 
            razmax = razmer;
        }
        else {
            if (razmer < razmax && razmer !=0)
            razmax = razmer;
            razmer=0;
        }
      }
      if (razmax==100000) razmax=0;
      Console.WriteLine(razmax);
  }
}
//Намятова Анастасия ФИТ-242//