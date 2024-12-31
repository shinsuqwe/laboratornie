/* Лабораторная работа №9. 11.11 Задание 1.  На вход подается строка, состоящая из слов, 
между которыми от одного до нескольких пробелов. Выполнить следующие задачи: 
1) Удалить все лишние пробелы, оставив по одному; 2) Выдать все слова-палиндромы; 
3) Подсчитать количество слов, у которых первый и последний символы совпадают в 
любых начертаниях. */

using System;
class NumberOne {
  static void Main() {
    string a = Console.ReadLine();
    int quantity = 0; //quantity - количество//
    bool pk = true;
    string[] words = a.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
    a = string.Join(" ", words);
    Console.WriteLine(a); // пункт 1 //
    for(int i = 0; i < words.Length; i++){
        string s = words[i].ToLower();
        pk = true;
        for(int k = 0; k < s.Length; k++){
            if(s[k] != s[s.Length - k - 1]) pk = false;
        }
        if(pk) Console.WriteLine(words[i]); // пункт 2 //
    }
    for(int i = 0; i < words.Length; i++) {
        string s1 = words[i].ToLower();
        if(s1[0] == s1[s1.Length-1]) quantity += 1; // пункт 3 //
    }
    Console.WriteLine(quantity);
  }
}
//Намятова Анастасия ФИТ-242//