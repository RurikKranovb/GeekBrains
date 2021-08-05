using System;
using System.IO;
using System.Linq;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee[] employees = new Employee[5];
            employees[0] = new Employee();
            employees[1] = new Employee("Иван", "Иванов", "Ивушкинович", "Бездарь", 87652390781, 50, 20);
            employees[2] = new Employee("Пупа", "Пушков", "Комочкович", "Пупочный пушок", 87652390781, 1, 43);
            employees[3] = new Employee("Витя", "Колбасов", "Петрович", "Инжинер-пищевик", default,30, 60);
            employees[4] = new Employee("Вот", "так", "то");

            foreach (var item in employees.Where(employee => employee.Age > 40))
            {
                Console.WriteLine($"Имя: {item.FistName}, Фамилия: {item.LastName}," +
                                  $" Отчество: {item.Patronymic}, Должность: {item.Position}," +
                                  $" Зарплата: {item.Salary}, Телефон: {item.Telephone}, Возраст: {item.Age}");
            }
        }
    }
}
