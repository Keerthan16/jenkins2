using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;//remember to add this
namespace Project2
{
    class Collectionitems1
    {
        static void Arrayeg()
        {
            ArrayList a1 = new ArrayList();
            Console.WriteLine("capacity =" + a1.Capacity);
            a1.Add(10);
            a1.Add("devi");
            a1.Add(100.23f);
            a1.Add("a");
            Console.WriteLine("capacity =" + a1.Capacity);
            a1.Add(120);
            a1.Add("city");
            a1.Add(20);
            a1.Add("deva");
            Console.WriteLine("capacity =" + a1.Capacity); ///see the trends in capacity to understand dynamic lists
            a1.Add(178000);
            foreach(var r in a1)
            {
                Console.WriteLine(r);
            }

            Console.WriteLine("count of list is:{0}",a1.Count);
            Console.WriteLine("indexof of deva is:{0}", a1.IndexOf("deva"));
            Console.WriteLine("capacity of list is:{0}", a1.Capacity);
            a1.Remove("city");
            Console.WriteLine("new list:{0}", a1);



        }
        static void hashtableeg()
        {
            Hashtable ht = new Hashtable();
            ht.Add("n", "networks");
            ht.Add("o", "operating system");
            ht.Add("j", "java");
            ht.Add("u", "unix");
            Console.WriteLine("to check if ht contains O and give true?false"+ ht.Contains("o"));
            Console.WriteLine("to print dictionary");
            foreach(DictionaryEntry r in ht)//dictionaryentry should be used remember instread of var
            {
                Console.WriteLine(r.Key+" "+r.Value);
            }

        }
        static void Sortedlisteg()
        {
            SortedList s2 = new SortedList();
            s2.Add("n", "networks");
            s2.Add("o", "operating system");
            s2.Add("j", "java");
            s2.Add("u", "unix");

            foreach (DictionaryEntry r in s2)//dictionaryentry should be used remember instread of var
            {
                Console.WriteLine(r.Key + " " + r.Value);
            }

        }
        static void Main()
        {
            Collectionitems1 a11 = new Collectionitems1();
            Arrayeg();
            hashtableeg();
            Sortedlisteg();
        }
    }

    

}
