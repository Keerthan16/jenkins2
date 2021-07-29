using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//understanding abstract class--------------parent classes will be abstract classes and they will have methods which must be defined in child class---------parent class objects cannot be made

namespace Project2
{
    abstract class RBI
    {
        internal string rule = "customer should have aadhar card";
        //abstract method
        abstract public int Homeloan();//notice function is mentioned abstract and no defination is given to the function
        abstract public int Eduloan();

        //abstract classes can contain non abstract methods
        internal void Rules()
        {
            Console.WriteLine("RULES TO BE FOLLOWED BY ALL BANK-------:{0}", rule);

        }
    }
    //another abstrac class which is child to RBI class
    abstract class SBI:RBI
    {
        //MUST CONTAIN RBI ABSTRACT METHOD

        public override int Eduloan()
        {
            return 8;

        }
        public override int Homeloan()
        {
            return 11;
        }

        //abstract method of SBI
        abstract public void SBICustomer();
    }

    //last node child class---this cannot be abstract

    class SBIBranch : SBI
    {
        //MUST CONTAIN ABSTRACT METHOD OF SBI

        public override void SBICustomer()
        {
            Console.WriteLine( "it has 1000000 customers");

        }
    }
    class Abstracteg
    {
        static void Main()
        {
            //object cant be created for abstract classes....therefor we create an object for last node child class SBIBranch
            //RBI r=new RBI(); is not possible

            SBIBranch obj = new SBIBranch();
            Console.WriteLine("Sbihomeloan:{0}", obj.Homeloan());
            Console.WriteLine("Sbieduloan:{0}", obj.Eduloan());
            obj.Rules();
            obj.SBICustomer();
            //run time polymorphism
            Console.WriteLine("--------------runtime polymorphism---------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("--------------------------------------------");
            RBI runtimeobj = new SBIBranch();       //very imp----we see reference of parent class but object of child class
            Console.WriteLine("Sbihomeloan:{0}", runtimeobj.Homeloan());
            Console.WriteLine("Sbieduloan:{0}", runtimeobj.Eduloan());
            runtimeobj.Rules();
            //runtimeobj.SBICustomer(); since this is sbi method rbi cant access it


        }

    }//so for the user it looks like home loan and edu loan are declared in SBI class where as it is actually declared in RBI class...this phenomenon helps in achieving abstraction using abstract classes
}
