/*Лабораторная работа №11. Задание 1. Создать массив из заданного количества объектов класса студент. Класс студент: ФИО (можно одно поле, можно разбить на три поля), год рождения, курс. 
(конструктор на инициализацию всех полей)
Реализовать меню, в котором пункты:
1.	Заполнение
2.	Модификация по ФИО
3.	Запрос1(вывод всех данных о студентах, заданного курса)
4.	Запрос2(вывод всех данных о студентах, рожденных в заданный год)
5.	Выход
После выбора и выполнения пункта меню, пользователь должен попадать обратно на меню, с возможностью выбора другого действия.
Предусмотреть обработку ошибки выбора пункта 2, 3, 4 при отсутствие данных. (выдать сообщение, что данных нет)

Есть класс, описывающий студента. Поля - ФИО, год рождения, курс. Создать массив из заданного
количества объектов этого класса. Выдать всех студентов, родившихся в заданный год,
заданного курса.*/
using System;
class Student {
    private string _name;
    private int _year;
    private int _course;
    public string Name {
        get => _name;
        set => _name = value;
    }
    public int Year {
        get => _year;
        set => _year = value;
    }
    public int Course {
        get => _course;
        set => _course = value;
    }
}
class Program {
    static Student[] DataEntry(int n) {
        Student[] myArr = new Student[n];
        for(int i = 0; i < n; i++) {
            int k = i+1;
            Console.Write($"Введите ФИО студента {k}: ");
            string a = Console.ReadLine();
            Console.Write($"Введите год рождения студента {k}: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Введите курс обучения студента {k}: ");
            int c = Convert.ToInt32(Console.ReadLine());
            myArr[i] = new Student();
            myArr[i].Name = a; myArr[i].Year = b; myArr[i].Course = c;
        }
        return myArr;
    }
  static void Main() {
      int selection = 0;
      int checker = 0;
      Student[] myArr_stud = new Student[1];
      while(selection != 5) {
          Console.WriteLine("Меню");
          Console.WriteLine("1. Заполнение");
          Console.WriteLine("2. Изменения");
          Console.WriteLine("3. Поиск студентов по году");
          Console.WriteLine("4. Поиск студентов по курсу");
          Console.WriteLine("5. Выход");
          selection = Convert.ToInt32(Console.ReadLine());
          switch(selection) {
               case 1:
              if(checker == 0) {
                  Console.Write("Введите количество студентов: ");
                  int amount = Convert.ToInt32(Console.ReadLine());
                  myArr_stud = DataEntry(amount);
                  checker = 1;
                  break;
              }
              else {
                  Console.WriteLine("Массив уже заполнен");
                  break;
              }
               case 2:
              if(checker == 0) {
                  Console.WriteLine("Изменения невозможны, внесите корректные данные");
                  break;
              }
              else {Console.Write("Введите ФИО студента: ");
              string namechange = Console.ReadLine();
              int studchange = -1;
              for(int i = 0; i < myArr_stud.Length; i++) {
                  if(myArr_stud[i].Name == namechange) studchange = i;
              }
              if(studchange == -1) {
                  Console.WriteLine("Студент не числится");
                  break;
              }
              else {
                  Console.WriteLine("Выберите пункт который хотите изменить");
                  Console.WriteLine("1. ФИО");
                  Console.WriteLine("2. Год");
                  Console.WriteLine("3. Курс");
                  int change_selection = Convert.ToInt32(Console.ReadLine());
                  switch (change_selection) {
                      case 1:
                      Console.Write("Введите исправленный вариант (ФИО): ");
                      string change_name = Console.ReadLine();
                      myArr_stud[studchange].Name = change_name;
                      break;
                      case 2:
                      Console.Write("Введите исправленный вариант (год рождения): ");
                      int change_year = Convert.ToInt32(Console.ReadLine());
                      myArr_stud[studchange].Year = change_year;
                      break;
                      case 3:
                      Console.Write("Введите исправленный вариант (курс обучения): ");
                      int change_course = Convert.ToInt32(Console.ReadLine());
                      myArr_stud[studchange].Course = change_course;
                      break;
                  }
                  break;
              }
              }
               case 3:
              if(checker == 0) {
                  Console.WriteLine("Введите корректные данные в массив");
                  break;
              }
              else {
                  Console.Write("Введите год: ");
                  int year_selection = Convert.ToInt32(Console.ReadLine());
                  int checker2 = 0;
                  for(int i = 0; i < myArr_stud.Length; i++) {
                      if(myArr_stud[i].Year == year_selection) {
                          Console.WriteLine($"ФИО: {myArr_stud[i].Name}");
                          Console.WriteLine($"Год рождения: {myArr_stud[i].Year}"); 
                          Console.WriteLine($"Курс: {myArr_stud[i].Course}");
                          checker2 = 1;
                      }
                  }
                  if(checker2 == 0) Console.WriteLine("Нет студентов, родившихся в указанный год");
              
                  break;
              }
               case 4:
              if(checker == 0) {
                  Console.WriteLine("Введите корректные данные в массив");
                  break;
              }
              else {
                  Console.Write("Введите курс: ");
                  int course_selection = Convert.ToInt32(Console.ReadLine());
                  int checker2 = 0;
                  for(int i = 0; i < myArr_stud.Length; i++) {
                      if(myArr_stud[i].Course == course_selection) {
                          Console.WriteLine($"ФИО: {myArr_stud[i].Name}");
                          Console.WriteLine($"Год рождения: {myArr_stud[i].Year}"); 
                          Console.WriteLine($"Курс: {myArr_stud[i].Course}");
                          checker2 = 1;
                      }
                  }
                  if(checker2 == 0) Console.WriteLine("Нет студентов, обучающихся указанном курсе");
              
                  break;            
            }
              case 5: break;
          }
      }
  }
}
//Намятова Анастасия Валерьевна ФИТ-242//


