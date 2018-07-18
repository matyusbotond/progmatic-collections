using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>();

            //Listához hozzáadás
            list1.Add("alma");
            list1.Add("korte");
            list1.Add("barack");

            //Adott indexre beszúrás
            list1.Insert(1, "meggy");

            foreach (string item in list1)
            {
                Console.WriteLine(item);
            }
            
            bool contains = list1.Contains("alma");

            if (list1.Contains("alma"))
            {
                list1.Remove("alma");
            }

            int index = list1.IndexOf("korte");
            int index2 = list1.IndexOf("korte2");

            //Adott elem törlése
            bool removeResult = list1.Remove("alma");
            //bool removeResult2 = list1.Remove("alma2");

            //Adott indexen lévő elem törlése
            list1.RemoveAt(0);


            foreach (string item in list1)
            {
                Console.WriteLine(item);
            }

            //Összes elem törlése
            list1.Clear();

            Console.ReadKey();
        }
    }
}
