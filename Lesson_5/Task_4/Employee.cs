using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4
{
    class Employee
    {

        public Employee(string fistName = "Имя",
            string lastName = "Фамилия",
            string patronymic = "Отчество",
            string position = "Должность",
            long telephone = 89990001122,
            int salary = 3000,
            byte age = 11)
        {
            FistName = fistName;
            LastName = lastName;
            Patronymic = patronymic;
            Position = position;
            Telephone = telephone;
            Salary = salary;
            Age = age;
        }

        public string FistName { get; set; }

        public string LastName { get; set; }

        public string Patronymic { get; set; }

        public string Position { get; set; }

        public long Telephone { get; set; }

        public int Salary { get; set; }

        public byte Age { get; set; }


    }
}
