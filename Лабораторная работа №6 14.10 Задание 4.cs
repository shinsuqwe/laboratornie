//Лабораторная работа №6. 14.10 Задание 4. Определить среднее арифметическое четных элементов массива. //

using System;
class NumberFour {
  static void Main() {
      int n = Convert.ToInt32(Console.ReadLine());
      int[] array = new int[n];
      double q = 0, amount = 0, arithmavg = 0;
      for(int i = 0; i < n; i++){
          m[i] = Convert.ToInt32(Console.ReadLine());
          if(m[i]%2==0) {
              q += 1;
              amount += m[i];
          }
      }
      if(q > 0) arithmavg = amount / q;
      Console.WriteLine(arithmavg);
  }
}
//Намятова Анастасия ФИТ-242//