using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2   //virtual method...this method can be overrriden in the future....therefore virtual keyword can give permission for the method to be altered later using override
{
    class UGC
    {
        string[] rules = { "dresscode", "no cell phones", "75% attendence" };
        public virtual void Rulesmethod()
        {
            foreach (var r in rules)
            {
                Console.WriteLine("rule:{0}", r);
            }
        }


    }
    class MIT:UGC
    {
        string mitrule = "arrive at time";
        public override void Rulesmethod()//the rulesmethod of parent is overriden by child class using override keyword
        {
            base.Rulesmethod();
            Console.WriteLine("rule:{0}", mitrule);
        }

    }
    class ANNAuniversity:UGC
    {
        string annarule = "only formals";
        public new void Rulesmethod()//a seperate rulesmethod() with a new memory location for anna university using new keyword
        {
            
            Console.WriteLine("rule:{0}", annarule);
        }
    }
    class virtualeg
    {
        static void Main()
        {
            UGC ugc = new UGC();
            Console.WriteLine("UGC RULES");
            ugc.Rulesmethod();
            Console.WriteLine("MIT RULES");
            MIT mit = new MIT();
            mit.Rulesmethod();
            Console.WriteLine("anna RULES");
            ANNAuniversity anna = new ANNAuniversity();
            anna.Rulesmethod();

        }
    }//ugc rules can be or cannot be followed by the colleges....if mit choses not to follow the ugc rules it can override the rulesmethod.....and the rest can follow the ugc rules by not overriding the rulesmethod() method
}
