/*Лабораторная работа №7. 28.10 Задание 1. Дан двумерный массив. Необходимо поменять местами 
строку, содержащую минимальный элемент со строкой, содержащей максимальный.*/

using System;
class NumberOne {
  static void Main() {
      int maximum = -1000000, minimum = 1000000;
      int max_string = 0, min_string = 0, n = 0;
      int a = Convert.ToInt32(Console.ReadLine());
      int b = Convert.ToInt32(Console.ReadLine());
      int[,] array = new int[a, b];
      for(int x = 0; x < a; x++){
          for(int y = 0; y < b; y++){
              array[x, y] = Convert.ToInt32(Console.ReadLine());
          }
      }
      for(int x = 0; x < a; x ++){
          for(int y = 0; y < b; y++){
              if(array[x, y] < minimum){
                  minimum = array[x, y];
                  min_string = x;
              }
              if(array[x, y] > maximum){
                  maximum = array[x, y];
                  max_string = x;
              }
          }
      }
      for(int y = 0; y < b; y++){
          n = array[min_string, y];
          array[min_string, y] = array[max_string, y];
          array[max_string, y] = n;
      }
  }
}
//Намятова Анастасия ФИТ-242//