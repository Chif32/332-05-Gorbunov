using System;
using System.Xml.Serialization;

namespace StudentsApp
{
    [Serializable]
    public class Student
    {
        // Свойства студента
        public string LastName { get; set; }        // Фамилия
        public string FirstName { get; set; }       // Имя
        public string MiddleName { get; set; }      // Отчество
        public int Course { get; set; }             // Курс
        public string Group { get; set; }           // Группа
        public DateTime BirthDate { get; set; }     // Дата рождения
        public string Email { get; set; }           // Электронная почта

        // Конструктор по умолчанию
        public Student()
        {
        }

        // Конструктор с параметрами
        public Student(string lastName, string firstName, string middleName, 
                      int course, string group, DateTime birthDate, string email)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            Course = course;
            Group = group;
            BirthDate = birthDate;
            Email = email;
        }
    }
} 