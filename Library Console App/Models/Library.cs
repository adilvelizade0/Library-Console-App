using System;
using System.Collections;
using System.Linq;

namespace Library_Console_App.Models
{
    public class Library: IEnumerable
    {
        private static Book[] _books;

        public static string NameOfTheLibrary { get; set; }
        public static string LocatedCity { get; set; }
        public static int BookCount => _books.Length;
        public Book this[int index]
        {
            get => _books [index];
            set => _books [index] = value;
        }

        static Library()
        {
            _books = Array.Empty<Book>();
        }
        
        public static void CreateLibrary(string nameOfTheLibrary, string locatedCity)
        {
            NameOfTheLibrary = nameOfTheLibrary;
            LocatedCity = locatedCity;
        }

        private static int CalculateId(Book[] books)
        {
            var sumOfId1 = 0;

            for (var i = 1; i <= books.Length; i++)
            {
                sumOfId1 += i;
            }

            var sumOfId2 = books.Sum(book => book.BookId);

            return sumOfId1 - sumOfId2 == 0 ? 0 : sumOfId1 - sumOfId2;
        }

        public static void AddNewBook(Book book)
        {
            if (_books.Length == 0)
            {
                Array.Resize(ref _books, _books.Length + 1);
                _books[^1] = book;
            }
            else
            {
                Array.Sort(_books,(Book a,Book b) => a.BookId - b.BookId);
                Array.Resize(ref _books, _books.Length + 1);
                _books[^1] = book;
                _books[^1].BookId = 0;

                if (CalculateId(_books) != 0)
                {
                    Console.WriteLine(CalculateId(_books));
                    book.BookId = CalculateId(_books);
                    _books[^1] = book;
                }
                else
                {
                    book.BookId = _books[^1].BookId + 1;
                }
                
                Array.Sort(_books,(Book a,Book b) => a.BookId - b.BookId);
            }
        }
        
        public static void RemoveBookById(int id)
        {
            if (!Array.Exists(_books,book => book.BookId == id))
            {
                Console.WriteLine("\n ❌ No results found");
            }
            else if (_books.Length == 1)
            {
                _books = Array.Empty<Book>();
                Book.SetBookId(0);
                Console.WriteLine("\n✅ The book was successfully deleted!");
            }
            else
            {
                _books = _books.Where(book => book.BookId != id).ToArray();
                Console.WriteLine("\n✅ The book was successfully deleted!");
            }
           
        }

        public static Book FindABook(int id)
        {
            return !Array.Exists(_books,book => book.BookId == id) ? null : Array.Find(_books, book => book.BookId == id);
        }

        public static void PrintAllBooks()
        {
            Console.Clear();
            Console.WriteLine(" \n ________   ________   ________   ___  __     ________      \n|\\   __  \\ |\\   __  \\ |\\   __  \\ |\\  \\|\\  \\  |\\   ____\\     \n\\ \\  \\|\\ /_\\ \\  \\|\\  \\\\ \\  \\|\\  \\\\ \\  \\/  /|_\\ \\  \\___|_    \n \\ \\   __  \\\\ \\  \\\\\\  \\\\ \\  \\\\\\  \\\\ \\   ___  \\\\ \\_____  \\   \n  \\ \\  \\|\\  \\\\ \\  \\\\\\  \\\\ \\  \\\\\\  \\\\ \\  \\\\ \\  \\\\|____|\\  \\  \n   \\ \\_______\\\\ \\_______\\\\ \\_______\\\\ \\__\\\\ \\__\\ ____\\_\\  \\ \n    \\|_______| \\|_______| \\|_______| \\|__| \\|__||\\_________\\\n                                                \\|_________|");
            Console.WriteLine("\n*--------------------------------------------------------------*\n");
            if (_books.Length == 0)
            {
                Console.WriteLine("There is nothing yet (Enter 1 to add to the book)");
            }
            foreach (var book in _books)
            {
                Console.WriteLine($"\nBook Id: {book.BookId.ToString()}\nName: {book.Name}\nHead author: {book.Author.GetFullName()}\nPublish Year: {book.PublishYear.ToString()}\n");
                Console.WriteLine("*--------------------------------*");
            }
        }
        
        
        public IEnumerator GetEnumerator()
        {
            return _books.GetEnumerator();
        }
        
    }
}