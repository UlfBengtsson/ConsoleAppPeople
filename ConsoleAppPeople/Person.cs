using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppPeople
{
    class Person
    {// class scope - varibles will get a deafult value
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + ' ' + LastName;
            }
        }
        public int Age { get; set; }

        //Constructor - Req. First & Last name of person to create.
        public Person(string firstName, string lastName)
        {//Local scope - varibles don´t have a deafult value
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hello my name is {FullName} and i am {Age} years old.");
        }
    }
}
