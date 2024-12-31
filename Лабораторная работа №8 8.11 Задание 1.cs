/*Лабораторная работа №8. 8.11 Задание 1. Подается зубчатый массив, задаваемый функцией. 
Определить номера строк, элементы которых образуют равномерно убывающую последовательность.*/

using System;
class NumberOne {
    static int[][] massive (int a){
        int[][] m1 = new int[a][];
        for(int i = 0; i < a; i++){
            int number = Convert.ToInt32(Console.ReadLine());
            m1[i] = new int[number];
            for(int l = 0; l < number; l++){
                m1[i][l] = Convert.ToInt32(Console.ReadLine());
            }
        }
        return m1;
    }
    static void Main(){
        int size = Convert.ToInt32(Console.ReadLine());
        int[][] myArr = massive (size);
        for(int m1 = 0; m1 < size; m1++){
            int difference = 0;
            int check = 0;
            for(int n = 0; n < myArr[m1].Length-2; n++){
                difference = myArr[m1][n] - myArr[m1][n+1];
                if((myArr[m1][n+1] - myArr[m1][n+2] == difference) && (difference>0)) check += 1;
            }
            int stringk = m1 + 1;
            if(check == myArr[m1].Length-2) Console.WriteLine($"Номер строки: {stringk}");
        }
    }
}
  

//Намятова Анастасия ФИТ-242//