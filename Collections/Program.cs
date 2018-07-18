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
            //List<string> list1 = new List<string>();

            ////Listához hozzáadás
            //list1.Add("alma");
            //list1.Add("korte");
            //list1.Add("barack");

            ////Adott indexre beszúrás
            //list1.Insert(1, "meggy");

            //foreach (string item in list1)
            //{
            //    Console.WriteLine(item);
            //}

            //bool contains = list1.Contains("alma");

            //if (list1.Contains("alma"))
            //{
            //    list1.Remove("alma");
            //}

            //int index = list1.IndexOf("korte");
            //int index2 = list1.IndexOf("korte2");

            ////Adott elem törlése
            //bool removeResult = list1.Remove("alma");
            ////bool removeResult2 = list1.Remove("alma2");

            ////Adott indexen lévő elem törlése
            //list1.RemoveAt(0);


            //foreach (string item in list1)
            //{
            //    Console.WriteLine(item);
            //}

            ////Összes elem törlése
            //list1.Clear();

            //Console.ReadKey();

            //List<Person> people = new List<Person>();

            //Person p1 = new Person();

            //p1.Name = "Béla";

            //people.Add(p1);

            //Person p2 = new Person();
            //p2.Name = "Aladár";

            //people.Add(p2);

            //foreach (Person person in people)
            //{
            //    Console.WriteLine(person.Name);
            //}

            //if (people.Contains(p1))
            //{
            //    people.Remove(p1);
            //}

            //foreach (Person person in people)
            //{
            //    Console.WriteLine(person.Name);
            //}

            //Person aladar = people[0];

            //Console.ReadKey();

            Dictionary<string, Person> phonebook = new Dictionary<string, Person>();

            Person p1 = new Person();
            p1.Name = "Béla";
            phonebook.Add("06301234567", p1);

            Person p2 = new Person();
            p2.Name = "Aladár";
            phonebook.Add("06707654321", p2);

            foreach (KeyValuePair<string, Person> item in phonebook)
            {
                Console.WriteLine("Név: {0}, telefonszám: {1}",
                    item.Value.Name, item.Key);
            }

            if (phonebook.ContainsKey("067076543210"))
            {
                Person foundPerson = phonebook["067076543210"];
            }

            Person foundPerson2 = phonebook["06707654321"];

            Console.ReadKey();
        }
    }
}
