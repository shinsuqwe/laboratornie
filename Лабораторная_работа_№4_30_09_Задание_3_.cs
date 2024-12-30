//Лабораторная работа №4.30.09 Задание 3. Дана последовательность. Определить максимальную сумму подпоследовательностей из четных чисел.//

using System;
class NumberThree {
  static void Main() {
      int n, c2, amountm = -10000000, amount = 0;
      n = Convert.ToInt32(Console.ReadLine());
      for(int i = 0; i < n; i++) {
          c2 = Convert.ToInt32(Console.ReadLine());
          if(c2 % 2 == 0) {
              amount += c2;
              
          }
          else {
              if(amountm < amount) amountm = amount;
              amount = 0;
          }
      }
      if((amount != 0) && (amountm < amount)) amountm = amount;
    Console.WriteLine(amountm);
  }
}
//Намятова Анастасия ФИТ-242//