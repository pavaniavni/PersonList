using System;
using System.Collections;
namespace PersonLists
{
    public class PersonList
    {
        public static void Main(string[] args)
        {
            
            List<Person> list = new List<Person>();
            int total = 3;
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("Enter Person Name : ");
                string name = Console.ReadLine();
                

                Console.WriteLine("Enter Person Age : ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine();

                list.Add(new Person()
                {
                    PName = name,
                    PAge = age
                });
            }

            foreach (Person p in list)
            {
                Console.WriteLine(p.ToString());
            }

            Console.ReadLine();
        }

        public class Person
        {
            public string PName { get; set; }
            public int PAge { get; set; }


            public override string ToString()
            {
                return ("The Person Name and Age is : "+ PName + " - " + PAge);
                
            }
        }
    }
}
