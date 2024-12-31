//Лабораторная работа №6. 14.10 Задание 2. Определить количество элементов, значение которых оканчивается на тройку. //

using System;
class NumberTwo {
  static void Main() {
      int n = Convert.ToInt32(Console.ReadLine());
      int[] array = new int[n];
      int c = 0;
      for(int i = 0; i < n; i++){
          array[i] = Convert.ToInt32(Console.ReadLine());
          if(Math.Abs(array[i])%10==3) c=c+1;
      }
      Console.WriteLine(c);
  }
}
//Намятова Анастасия ФИТ-242//