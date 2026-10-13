using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3
{
    abstract class EmployeeDetails  //blueprint or templete

    {
        // Abstract 
        // highlights the features only
        // abstract keyword used with class and method
        // you can not create object of abstract class
        // within abstract class, you can put data members, abstract method, non-abstract method, constructor etc.
        // you can use abstract class as a parent class 
        // All the abstract methods must be implemented by its child class
        // All abstract methods are implicitly virtual


        // Interface
        // what a class must do but not how it does
        // it can not add data members, concrete methods
        // All the methods are implicitly abstract and public
        // A class must implement all the methods of an interface being implemented

        abstract public void Show();
        //data member
        public string Name { get; set; }
        private int age;
        public string Dept { get; set; }

        protected double Salary;


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

        virtual public void Display()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Age:" + Age);
            Console.WriteLine("Dept:" + Dept);
            Console.WriteLine("Salary:" + Salary);


        }

        public void check()
        {
            Console.WriteLine("check method from RegularEmployee class");
        }

        interface IA
        {
            void Test1();
        }

        interface IB
        {
            void Test1();
            void Test2();
            void Test3();
        }

        interface IC : IA, IB
        {
            void Test4();
            void Test5();
        }

        class Employee1 : IC
        {
            public void Test1()
            {
                Console.WriteLine("Test1 method from Employee1 class");
            }
            public void Test2()
            {
                Console.WriteLine("Test2 method from Employee1 class");
            }
            public void Test3()
            {
                Console.WriteLine("Test3 method from Employee1 class");
            }
            public void Test4()
            {
                Console.WriteLine("Test4 method from Employee1 class");
            }
            public void Test5()
            {
                Console.WriteLine("Test5 method from Employee1 class");
            }
        }

        interface ITest
        {
            void Test(); //abstract 
        }


    }

    class RegulaerEmployee : EmployeeDetails, ITest  //level 1
    {
        public void Testing()
        {
            Console.WriteLine("Testing method from RegularEmployee class");
        }
        //data member: from this class:1
        //data mwember: from base class:3

        //property: from this class:0
        //property: from base class:1

        //method: from this class:0
        //method: from base class:3
        //private double Basic;
        //private double DA;
        //private double HRA;
        //private double PF;
        //private double PT;

        public override void Display()
        {
            //base.Display();
            ////-------------------
            //Console.WriteLine("Basic:" + Basic);
            //Console.WriteLine("DA:" + DA);
            //Console.WriteLine("HRA:" + HRA);
            //Console.WriteLine("PF:" + PF);
            //Console.WriteLine("PT:" + PT);
        }

        public override void Show()
        {
            Console.WriteLine("Show method from RegularEmployee");
        }
        public new void check()
        {
            Console.WriteLine("check method from RegularEmployee class");
        }

        public void Test()
        {
            Console.WriteLine("Test method from RegularEmployee class");
        }
    }



    class Employee
    {
        public static void Main(string[] args)
        {
            //EmployeeDetails e1 = new EmployeeDetails();
            //e1.Name = "krishna";
            //e1.Age = 20;
            //e1.Dept = "cse";
            //e1.setSalary(10000);

            //e1.Display();

            //EmployeeDetails e2 = new EmployeeDetails();
            //e2.Name = "dhara";
            //e2.Age = 20;
            //e2.Dept = "it";
            //e2.setSalary(20000);



            //e2.Display();

            EmployeeDetails e3 = new RegulaerEmployee();
            e3.Display();//Employee
            e3.check();//employee
            //e3.Test();

            RegulaerEmployee e4 = new RegulaerEmployee();
            e4.Display();//RegularEmployee
            e4.check();//RegularEmployee
            e4.Test();//ok

            EmployeeDetails e5 = new RegulaerEmployee();
            e5.Display();//RegularEmployee
            e5.check();//Employee

            Console.ReadLine();
        }

    }

}