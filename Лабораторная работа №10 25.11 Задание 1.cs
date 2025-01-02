//Лабораторная работа №10. 25.11 Задание 1. На вход подается строка. Необходимо определить  символ, который чаще всего встречается в комбинации a*b. Регистр не учитывается. //

using System;
class NumberOne {
  static void Main() {
      string a = Console.ReadLine();
      a = a.ToLower();
      char symbol = ' '; 
      char maxsymbol = ' ';
      string aob = "";
      int maxquantity = 0, quantity = 0; //maxquantity - максималотное количество, quantity - количество//
      for(int i = 0; i < a.Length - 1; i++){
          string s = a;
          if(s[i] == 'a' && s[i+2] == 'b') {
              symbol = s[i+1];
              aob = string.Concat('a', symbol);
              aob = string.Concat(aob, 'b');
              s = s.Replace(aob, "");
              quantity = (a.Length - s.Length)/3;
              if(quantity > maxquantity) {
                  maxquantity = quantity;
                  maxsymbol = symbol;
              }
          }
      }
      Console.Write($"Наиболее встречающийся символ: {maxsymbol}");
  }
}
//Намятова Анастасия ФИТ-242//