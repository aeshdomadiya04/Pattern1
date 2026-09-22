using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern1
{
    internal class EmployeeDetails  //blueprint or templete

    {
        //data member
        public string Name { get; set; }
        private int age;
        public string Dept { get; set; }

        private double Salary;


        public void setSalary(double salary)
        {
            this.Salary = salary;
        }
        public double getSalary()
        {
            return this.Salary;
        }

        public int Age  //property
        {
            get
            {   //read only
                return age;
            }
            set  //write
            {
                age = value;
            }
        }

        public void Display()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Age:" + Age);
            Console.WriteLine("Dept:" + Dept);
            Console.WriteLine("Salary:" + Salary);


        }


    }

    class Employee
    {
        public static void Main(string[] args)
        {
            EmployeeDetails e1 = new EmployeeDetails();
            e1.Name = "Aesh";
            e1.Age = 20;
            e1.Dept = "cse";
            e1.setSalary(10000);

            e1.Display();

            EmployeeDetails e2 = new EmployeeDetails();
            e2.Name = "dhara";
            e2.Age = 20;
            e2.Dept = "it";
            e2.setSalary(20000);

            e2.Display();

            Console.ReadLine();
        }

    }

}