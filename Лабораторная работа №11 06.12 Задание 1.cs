/* Лабораторная работа №11. 06.12 Задание 1. Есть класс, имеющий два поля типа инт. 
В нем три конструктора: первый инициализирует значения полей в ноль если нет параметров, 
второй - принимает один параметр (второй - ноль), третий - принимает оба параметра. 
В классе есть четыре метода, включающих вывод: первый - сложение переменных, второй - 
вычитание, третий - деление, четвертый - умножение. Создать три объекта с использованием 
разных конструкторов и использовать для них методы (вычитание дважды). */

using System;
class operation {
    public int A;
    public int B;
    public operation() {
        A = 0;
        B = 0;
    }
    public operation(int a) {
        A = a;
        B = 0;
    }
    public operation(int a, int b) {
        A = a;
        B = b;
    }
    public void Addition() {  //Сложение//
        Console.Write("Сумма: ");
        Console.WriteLine(A + B);
    }
    public void Deduction() {  //Разность//
        Console.Write("Разность 1: ");
        Console.WriteLine(A - B);
        Console.Write("Разность 2: ");
        Console.WriteLine(B - A);
    }
    public void Division() { //Деление//
        if(B != 0) {Console.Write("Частное: "); Console.WriteLine(A / B);}
        else Console.WriteLine("Деление на ноль невозможно");
    }
    public void Multiplication() { //Умножение//
        Console.Write("Произведение: ");
        Console.WriteLine(A * B);
    }
}
class Program {
  static void Main() {
      int a = Convert.ToInt32(Console.ReadLine());
      int b = Convert.ToInt32(Console.ReadLine());
      int c = Convert.ToInt32(Console.ReadLine());
      operation n1 = new operation();
      operation n2 = new operation(a);
      operation n3 = new operation(b, c);
      n1.Addition();
      n1.Deduction();
      n1.Division();
      n1.Multiplication();

      n2.Addition();
      n2.Deduction();
      n2.Division();
      n2.Multiplication();
      
      n3.Addition();
      n3.Deduction();
      n3.Division();
      n3.Multiplication();
  }
}
//Намятова Анастасия ФИТ-242//