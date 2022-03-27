using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Library_Console_App.Models
{
    public class Book: IEnumerable
    {
        private static int _bookId;
        private int _publishYear;
        private Person[] _persons;


        public string Name { get; set; }
        public Person Author { get; set; }
        public Person[] Authors => _persons;

        public int BookId { get; }
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
            
        }

        private Book()
        {
            BookId = ++_bookId;
            _persons = Array.Empty<Person>();
        }

        public Book(string name, Person author, int publishYear):this()
        {
            Name = name;
            Author = author;
            PublishYear = publishYear;
            AddNewAuthor(Author);
        }
        
        public void AddNewAuthor(Person person)
        {
            Array.Resize(ref _persons, _persons.Length + 1);
            _persons[^1] = person;
        }
        
        public void PrintAllAuthors()
        {
            Console.WriteLine(" \n ________   ___  ___   _________   ___  ___   ________   ________   ________      \n|\\   __  \\ |\\  \\|\\  \\ |\\___   ___\\|\\  \\|\\  \\ |\\   __  \\ |\\   __  \\ |\\   ____\\     \n\\ \\  \\|\\  \\\\ \\  \\\\\\  \\\\|___ \\  \\_|\\ \\  \\\\\\  \\\\ \\  \\|\\  \\\\ \\  \\|\\  \\\\ \\  \\___|_    \n \\ \\   __  \\\\ \\  \\\\\\  \\    \\ \\  \\  \\ \\   __  \\\\ \\  \\\\\\  \\\\ \\   _  _\\\\ \\_____  \\   \n  \\ \\  \\ \\  \\\\ \\  \\\\\\  \\    \\ \\  \\  \\ \\  \\ \\  \\\\ \\  \\\\\\  \\\\ \\  \\\\  \\|\\|____|\\  \\  \n   \\ \\__\\ \\__\\\\ \\_______\\    \\ \\__\\  \\ \\__\\ \\__\\\\ \\_______\\\\ \\__\\\\ _\\  ____\\_\\  \\ \n    \\|__|\\|__| \\|_______|     \\|__|   \\|__|\\|__| \\|_______| \\|__|\\|__||\\_________\\\n                                                                      \\|_________|");
            Console.WriteLine();
            foreach (var person in _persons)
            {
                Console.WriteLine($"\nAuthor Id: {person.PersonId.ToString()}\nFull name: {person.GetFullName()}\nAuthor's age: {person.Age.ToString()}\n");
                Console.WriteLine("*--------------------------------*");
            }
        }

        public void RemoveAuthorById(int id)
        {
            _persons = _persons.Where(person => person.PersonId != id).ToArray();
        }

        public string GetAuthors(Person[] persons)
        {
            if (persons == null)
                throw new ArgumentNullException(nameof(persons));
            
            var templateStr = new StringBuilder();
            for (var index = 0; index < persons.Length; index++)
            {
                var person = persons[index];
                templateStr.Append($"{(index + 1).ToString()}) " + person.GetFullName() + "\n");
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