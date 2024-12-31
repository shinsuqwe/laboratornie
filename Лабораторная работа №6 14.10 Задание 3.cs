//Лабораторная работа №6. 14.10 Задание 3. Для каждого элемента найти сумму цифр. //

using System;
class NumberThree {
  static void Main() {
      int n = Convert.ToInt32(Console.ReadLine());
      int[] array = new int[n];
      int amount = 0, s;
      for(int i = 0; i < n; i++){
          array[i] = Convert.ToInt32(Console.ReadLine());
          s = Math.Abs(array[i]);
          while(s > 0) {
              amount = amount + s%10;
              s = s/10;
          }
          Console.WriteLine(amount);
          amount = 0;
      }
  }
}
//Намятова Анастасия ФИТ-242//