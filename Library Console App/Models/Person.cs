using System;

namespace Library_Console_App.Models
{
    public class Person
    {
        private int _age;
        private static int _personId;

       
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PersonId { get; set; }
        public int Age { 
            get => _age;
            set => _age = value <= 150 ? value : 0;
        }

        static Person()
        {
            _personId = 0;
        }
        
        private Person()
        {
            PersonId = ++_personId;
        }
        
        public Person(string name, string surname, int age):this()
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string GetFullName()
        {
            return $"{Name} {Surname}";
        }
    }
}