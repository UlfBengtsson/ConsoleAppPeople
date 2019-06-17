using System;
using System.Collections.Generic;

namespace ConsoleAppPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Person> people = new List<Person>();

            Person me = new Person("Ulf", "Bengtsson", 37);
            people.Add(me);

            me.Introduce();

            BirthdayParty(me);

            foreach (Person person in people)
            {
                person.Introduce();
            }

            Console.ReadKey(true);
        }

        private static void BirthdayParty(Person me)
        {
            Console.WriteLine($"Yaye it´s my {++me.Age} birthday!!!");
        }

        static void OnePerson()
        {
            //Person me = new Person();
            //me.FirstName = "Ulf";
            //me.LastName = "Bengtsson";

            //Person me = new Person("Ulf", "Bengtsson");
            Person me = new Person("Ulf", "Bengtsson", 37);

            //Console.WriteLine(me.FirstName + ' ' + me.LastName);
            //Console.WriteLine(me.FullName);

            me.Introduce();

            Console.ReadKey(true);
        }
    }
}
