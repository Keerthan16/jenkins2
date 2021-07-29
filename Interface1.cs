using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    interface INormalCal
    {
        int Add(int x, int y);
        int sub(int x, int y);

    }
    class Calculator: INormalCal,Iscical
    {
        int INormalCal.Add(int x, int y)
        {
            return x + y;

        }
        public int sub(int x,int y)
        {
            return x - y;
        }                                      // the ones with identical method names i.e add...interface names are prefixed to understand which add method to call and publickeyword is nothere in these cases

        int Iscical.Add(int x, int y)
        {
            return x + x + y + y;
        }
        public int mul(int x,int y)
        {
            return x * y;
        }
    }
    interface Iscical
    {
        int Add(int x, int y);
        int mul(int x, int y);

    }
    class Interfaceeg
    {
        static void Main()
        {
            INormalCal ncal = new Calculator();
            Console.WriteLine("addition of normal calculaor:{0}", ncal.Add(5, 7));
            Console.WriteLine("addition of normal calculaor:{0}", ncal.sub(15, 7));
            Iscical scical = new Calculator();
            Console.WriteLine("addition of normal calculaor:{0}", scical.Add(5, 7));
            Console.WriteLine("addition of normal calculaor:{0}", scical.mul(5, 7));
        }
    }//interfaces are used in multiple inheritance where there are many parents and one child
    //in case if the parents have same method name then to avoid confusion interfaces are used
    //interfaces just like abstract classes have abstract methods the diff here is all the interface methods are abstract
    //calling an interface method here we dont make the child class obj instead we make interface objects
        
        
}
