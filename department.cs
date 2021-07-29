using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    enum Feedback
    {
        Poor=1,Fair,Good,Excellent            // creates a table with poor 1;fair 2;good 3 etc------to access any one use feedback.Good
    };
    class department   //base class
    {
        //protected is used only when a variable can be used by a parent and child class

        protected int Did { get; set; }

        protected string Dname { get; set; }

        protected string city { get; set; }

        internal department (int Did,string Dname,string city)    //internal can be used by any class inside a project
        {
            Console.WriteLine("department constructor");
            this.Did = Did;
            this.Dname = Dname;
            this.city = city;
        }
        protected internal void Displaydepartment()
        {
            Console.WriteLine("Did:{0}---------Dname:{1}", Did, city);    //here we dont create the object to access the variables as displaydepartment is not static

        }
        ~department()
        {
            Console.WriteLine("department destructor");
        }


    }
    class Employee: department
    {
        internal static string companyname = "LTI";
        internal int Eid { get; set; }
        internal string name { get; set; }
        internal string city = "pune";
        internal Employee(int Eid, string name, int Did, string Dname, string city) : base(Did, Dname,city)   //we see the last two parameters are parameter constructor parameters which are passed to parent class for initialization of parent variables
        {
            Console.WriteLine("Employee Constructor");                                                         //therefore when we make an object of child class employee we call the child cunstructor with all the parent and child cunstructor parmeteer and use the base keyword to pass those parameters to parent constructor
            this.Eid = Eid;
            this.name = name;
        }
        protected internal void Displayemployeeinfo()
        {
            Displaydepartment();
            
            Console.WriteLine(" department city is:{0}",base.city);//base keyword is used to mention the city to be used is of parent class as both parent and child class have the same variable 'city'
            Console.WriteLine("Eid:{0}--------empname:{1}-------------feedback:{2}-----------grade:{3}", Eid, name, Feedback.Fair, (int)Feedback.Fair);//see the usage of enum feedback
            Console.WriteLine("employee city is:{0}", city);

        }
        ~Employee()
        {
            Console.WriteLine("employee destructor");
        }
    }
    class PartTimeEmployee : Employee
    {
        internal int hoursofwork { get; set; }
        internal int salary { get; set; }
        internal PartTimeEmployee(int Eid,string name,int Did,string Dname,string city, int hoursofwork, int salary):base(Eid,name,Did,Dname,city)//the best practice is to pass the parent parametrs first and then child parameters--not done that here
        {
            this.hoursofwork = hoursofwork;
            this.salary = salary;
            Console.WriteLine("PartTimeEmployee Constructor");

        }
        internal int MonthlySalary()
        {
            int Payment = hoursofwork * salary * 30;
            return Payment;
        }
        ~PartTimeEmployee()
        {
            Console.WriteLine("parttimeemployee destructor");
        }
    }
    class MultilevelInheritance
    {
        static void Main()
        {

            Console.WriteLine("-------------------SINGLE LEVEL INHERITANCE-------------------");
            //single inheritance
            Employee employee = new Employee(1001, "sai", 101, "hr", "madhurai");
            employee.Displayemployeeinfo();

            //Multilevel inheritance
            Console.WriteLine("-------------------MULTI LEVEL INHERITANCE-------------------");
            PartTimeEmployee pt = new PartTimeEmployee(1001, "sai", 101, "hr", "madhurai", 67, 200);
            pt.Displayemployeeinfo();
            Console.WriteLine("monthly salary id:{0}", pt.MonthlySalary());

            GC.Collect();//garbage collector
        }
    }
    
}
