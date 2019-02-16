﻿using System;


namespace Task2
{
    //я создал класс Student и ввел туда имя, ID и год обучения
    class Student
    {
        public string name;
        public string ID;
        public int year;

        //я создал конструктор Student в котором содержится имя и ID
        public Student(string name, string ID)
        {
            this.name = name;
            this.ID = ID;
        }

        //Эта функция выводит все элементы класса Student и год обучения увеличивается на 1 год
        public void Print()
        {
            Console.WriteLine("Student's name: " + this.name + Environment.NewLine + "Student's ID: " + this.ID);
        }
        //Метод для инкремента года
        public void Incr()
        {
            year++;
            Console.WriteLine("Student's year of study: " + year); //Вывод инкрементированного года
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Создаю переменную а типа Студент
            Student a = new Student(Console.ReadLine(), Console.ReadLine())
            {
                year = 1
            };
            a.Print();
            a.Incr();
            Console.ReadKey();
        }
    }
}