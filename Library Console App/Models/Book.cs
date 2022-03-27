using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Library_Console_App.Models
{
    public class Book: IEnumerable
    {
        private static int _bookId;
        private static int _publishYear;
        private static Person[] _persons;


        public static string Name { get; set; }

        public static Person Author { get; set; }

        public static Person[] Authors => _persons;

        public int BookId { get; set; }
        public Person this[int index]
        {
            get => _persons [index];
            set => _persons [index] = value;
        }
        public int PublishYear
        {
            get => _publishYear;
            set
            {
                if (value.ToString().Length < 4)
                {
                    value = DateTime.Now.Year - value;
                }
                
                if (value <= DateTime.Now.Year)
                {
                    _publishYear = value;
                }
            }
        }
        
        static Book()
        {
            _bookId = 0;
            _persons = Array.Empty<Person>();
        }

        private Book()
        {
            BookId = ++_bookId;
        }

        public Book(string name, Person author, int publishYear):this()
        {
            Name = name;
            Author = author;
            PublishYear = publishYear;
            AddNewAuthor(Author);
        }

        public void ChangeBookName(string bookName)
        {
            Name = bookName;
        }
        
        public void AddNewAuthor(Person person)
        {
            Array.Resize(ref _persons, _persons.Length + 1);
            _persons[^1] = person;
        }
        
        public static void PrintAllAuthors()
        {
            Console.WriteLine(" \n ________   ___  ___   _________   ___  ___   ________   ________   ________      \n|\\   __  \\ |\\  \\|\\  \\ |\\___   ___\\|\\  \\|\\  \\ |\\   __  \\ |\\   __  \\ |\\   ____\\     \n\\ \\  \\|\\  \\\\ \\  \\\\\\  \\\\|___ \\  \\_|\\ \\  \\\\\\  \\\\ \\  \\|\\  \\\\ \\  \\|\\  \\\\ \\  \\___|_    \n \\ \\   __  \\\\ \\  \\\\\\  \\    \\ \\  \\  \\ \\   __  \\\\ \\  \\\\\\  \\\\ \\   _  _\\\\ \\_____  \\   \n  \\ \\  \\ \\  \\\\ \\  \\\\\\  \\    \\ \\  \\  \\ \\  \\ \\  \\\\ \\  \\\\\\  \\\\ \\  \\\\  \\|\\|____|\\  \\  \n   \\ \\__\\ \\__\\\\ \\_______\\    \\ \\__\\  \\ \\__\\ \\__\\\\ \\_______\\\\ \\__\\\\ _\\  ____\\_\\  \\ \n    \\|__|\\|__| \\|_______|     \\|__|   \\|__|\\|__| \\|_______| \\|__|\\|__||\\_________\\\n                                                                      \\|_________|");
            Console.WriteLine("\n*--------------------------------------------------------------*\n");
            foreach (var person in _persons)
            {
                Console.WriteLine($"\nAuthor Id: {person.PersonId.ToString()}\nFull name: {person.GetFullName()}\nAuthor's age: {person.Age.ToString()}\n");
                Console.WriteLine("*--------------------------------*");
            }
        }

        public static void RemoveAuthorById(int id)
        {
            _persons = _persons.Where(person => person.PersonId != id).ToArray();
        }

        public string GetAuthors(Person[] persons)
        {
            var templateStr = new StringBuilder();
            foreach (var person in persons)
            {
                templateStr.Append("\n" + person.GetFullName());
            }

            return templateStr.ToString();
        }

        public string GetTheBook()
        {
            return $"\nBook Id: {_bookId.ToString()}\nName: {Name}\nHead Author:{Author.GetFullName()}\nPublish Year: {_publishYear.ToString()}\n";
        }
        
        public IEnumerator GetEnumerator()
        {
            return _persons.GetEnumerator();
        }
        
    }
}