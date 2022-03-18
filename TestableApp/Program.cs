using System;
using System.Collections.Generic;

namespace TestableApp
{
    public class Program
    {
       

        public List<Employee> AllUsers()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Id = 100, Name = "Asize", Geneder = "male", salary = 40000 });
            employees.Add(new Employee { Id = 101, Name = "Bsize",  Geneder = "Female", salary = 56000 });
            employees.Add(new Employee { Id = 102, Name = "Vsize", Geneder = "male", salary = 44000 });
            employees.Add(new Employee { Id = 103, Name = "Csize", Geneder = "Female", salary = 50000 });
            employees.Add(new Employee { Id = 104, Name = "Dsize", Geneder = "male", salary = 40500 });
            employees.Add(new Employee { Id = 105, Name = "Esize", Geneder = "Female", salary = 52000 });
            employees.Add(new Employee { Id = 106, Name = "Fsize", Geneder = "male", salary = 40020 });
            employees.Add(new Employee { Id = 107, Name = "Gsize", Geneder = "Female", salary = 52000 });

            employees.Add(new Employee { Id = 108, Name = "Esize", Geneder = "Female", salary = 52000 });
            employees.Add(new Employee { Id = 109, Name = "Fsize", Geneder = "male", salary = 40020 });
            employees.Add(new Employee { Id = 110, Name = "Gsize", Geneder = "Female", salary = 52000 });

            return employees;
        }
        public List<Employee> GetEmployees(int id)
        {
            List<Employee> employees = new List<Employee>();
            Program p = new Program();
            var list = p.AllUsers();
            foreach (var x in list)
            {
                if (x.Id == id)
                {
                    employees.Add(x);
                }
            }
            return employees;
        }
        public string Login(string UserId, string Password)
        {
            if (string.IsNullOrEmpty(UserId) || string.IsNullOrEmpty(Password))
            {
                return "Userid or password could not be Empty.";
            }
            else
            {
                if (UserId == "Admin" && Password == "Admin")
                {
                    return "Welcome Admin.";
                }
                return "Incorrect UserId or Password.";
            }
        }
        
      

        static void Main(string[] args)
        {
        }
    }
}
