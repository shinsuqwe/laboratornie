/*Практическая работа №1. 16.10 Задание 1. Даны три массива размерностью n, m, p. 
В каждом массиве определить: 1) сумму элементов, кратных трем; 
2) произведение нечетных элементов; 3) количество нулевых элементов.*/

using System;
class practice_no1 {
    static int[] massive (int a) {
        int[] myArr = new int[a];
        for(int i = 0; i < a; i++) {
            myArr[i] = Convert.ToInt32(Console.ReadLine());
        }
        return myArr;
    }
    static int amount_elements(int[] n) {
        int amount = 0;
        for(int i = 0; i < n.Length; i++) {
            if(n[i] % 3 == 0) amount = amount + n[i];
        }
        return amount; //Сумма элементов кратных 3//
    }
    static int product_elements(int[] n) {
        int product = 1;
        for(int i = 0; i < n.Length; i++) {
            if(n[i] % 2 != 0) product = product * n[i];
        }
        return product; //Произведение нечетных элементов//
    }
    static int null_elements(int[] n) {
        int quantity = 0;
        for(int i = 0; i < n.Length; i++) {
            if(n[i] == 0) quantity = quantity * 1;
        }
        return quantity; //Количество нулей//
    }
  static void Main() {
    int n = Convert.ToInt32(Console.ReadLine()), a, b;
    int[] myArr1 = massive(n);
    Console.WriteLine("Сумма кратных 3: " + amount_elements(myArr1));
    Console.WriteLine("Произведение нечетных элементов: " + product_elements(myArr1));
    Console.WriteLine("Количество нулей: " + null_elements(myArr1));
    a = Convert.ToInt32(Console.ReadLine());
    myArr1 = massive(a);
    Console.WriteLine("Сумма кратных 3:: " + amount_elements(myArr1));
    Console.WriteLine("Произведение нечетных элементов: " + product_elements(myArr1));
    Console.WriteLine("Количество нулей: " + null_elements(myArr1));
    b = Convert.ToInt32(Console.ReadLine());
    myArr1 = massive(b);
    Console.WriteLine("Сумма кратных 3:: " + amount_elements(myArr1));
    Console.WriteLine("Произведение нечетных элементов: " + product_elements(myArr1));
    Console.WriteLine("Количество нулей: " + null_elements(myArr1));
  }
}
//Намятова Анастасия ФИТ-242//