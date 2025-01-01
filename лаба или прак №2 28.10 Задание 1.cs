//Практическая работа №2. 28.10 Задание 1. Дан массив из трех массивов. Определить количество нечетных элементов в каждой его строке.//

using System;
class practice_no1 {
    static int[] massive(int n){
        int[] myArr = new int[n];
        for(int i = 0; i < n; i++) {
            myArr[i] = Convert.ToInt32(Console.ReadLine());
        }
        return myArr;
    }
    static int odd_number(int[] k){ //odd number - колиечество нечетных//
        int odd_number = 0;
        for(int i = 0; i < k.Length; i++){
            if(k[i] % 2 != 0) odd_number = odd_number + 1;
        }
        return odd_number;
    }
  static void Main() {
    int[][] myArr1 = new int[3][];
    int x = Convert.ToInt32(Console.ReadLine());
    myArr1[0] = massive(x);
    int y = Convert.ToInt32(Console.ReadLine());
    myArr1[1] = massive(y);
    int z = Convert.ToInt32(Console.ReadLine());
    myArr1[2] = massive(z);
    Console.WriteLine("Количество нечетных в первой строке: " + odd_number(myArr1[0]));
    Console.WriteLine("Количество нечетных во второй строке: " + odd_number(myArr1[1]));
    Console.WriteLine("Количество нечетных в третьей строке: " + odd_number(myArr1[2]));
  }
}
//Намятова Анастасия ФИТ-242//