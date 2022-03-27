using System;
using static Library_Console_App.Helpers.AdditionalEx;

namespace Library_Console_App.Models
{
    internal static class Simulation
    {
        public static void StartSimulation()
        {
            Console.WriteLine("\n ___        ___   ________   ________   ________   ________       ___    ___      ________   ________   ________   \n|\\  \\      |\\  \\ |\\   __  \\ |\\   __  \\ |\\   __  \\ |\\   __  \\     |\\  \\  /  /|    |\\   __  \\ |\\   __  \\ |\\   __  \\  \n\\ \\  \\     \\ \\  \\\\ \\  \\|\\ /_\\ \\  \\|\\  \\\\ \\  \\|\\  \\\\ \\  \\|\\  \\    \\ \\  \\/  / /    \\ \\  \\|\\  \\\\ \\  \\|\\  \\\\ \\  \\|\\  \\ \n \\ \\  \\     \\ \\  \\\\ \\   __  \\\\ \\   _  _\\\\ \\   __  \\\\ \\   _  _\\    \\ \\    / /      \\ \\   __  \\\\ \\   ____\\\\ \\   ____\\\n  \\ \\  \\____ \\ \\  \\\\ \\  \\|\\  \\\\ \\  \\\\  \\|\\ \\  \\ \\  \\\\ \\  \\\\  \\|    \\/  /  /        \\ \\  \\ \\  \\\\ \\  \\___| \\ \\  \\___|\n   \\ \\_______\\\\ \\__\\\\ \\_______\\\\ \\__\\\\ _\\ \\ \\__\\ \\__\\\\ \\__\\\\ _\\  __/  / /           \\ \\__\\ \\__\\\\ \\__\\     \\ \\__\\   \n    \\|_______| \\|__| \\|_______| \\|__|\\|__| \\|__|\\|__| \\|__|\\|__||\\___/ /             \\|__|\\|__| \\|__|      \\|__| ");

            Console.WriteLine("\n*------------------------------------------------------------------------------------------------------------------------*\n");

            Console.WriteLine("Please create a new Library!");
            Library.CreateLibrary(ReadLineStr("The Library name"),
                ReadLineStr("Located City"));
            Console.WriteLine("\n✅ The library was created successfully.");

            
            int inChoice; 
            do
            {
                Console.WriteLine();
                inChoice = ReadLineInt("choice (Enter '0' to display the menu)");
                switch (inChoice)
                {
                    case 0:
                        Console.Clear();
                        PrintMenus(1);
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n ________   ________   _______    ________   _________   _______           ________          ________   ________   ________   ___  __       \n|\\   ____\\ |\\   __  \\ |\\  ___ \\  |\\   __  \\ |\\___   ___\\|\\  ___ \\         |\\   __  \\        |\\   __  \\ |\\   __  \\ |\\   __  \\ |\\  \\|\\  \\     \n\\ \\  \\___| \\ \\  \\|\\  \\\\ \\   __/| \\ \\  \\|\\  \\\\|___ \\  \\_|\\ \\   __/|        \\ \\  \\|\\  \\       \\ \\  \\|\\ /_\\ \\  \\|\\  \\\\ \\  \\|\\  \\\\ \\  \\/  /|_   \n \\ \\  \\     \\ \\   _  _\\\\ \\  \\_|/__\\ \\   __  \\    \\ \\  \\  \\ \\  \\_|/__       \\ \\   __  \\       \\ \\   __  \\\\ \\  \\\\\\  \\\\ \\  \\\\\\  \\\\ \\   ___  \\  \n  \\ \\  \\____ \\ \\  \\\\  \\|\\ \\  \\_|\\ \\\\ \\  \\ \\  \\    \\ \\  \\  \\ \\  \\_|\\ \\       \\ \\  \\ \\  \\       \\ \\  \\|\\  \\\\ \\  \\\\\\  \\\\ \\  \\\\\\  \\\\ \\  \\\\ \\  \\ \n   \\ \\_______\\\\ \\__\\\\ _\\ \\ \\_______\\\\ \\__\\ \\__\\    \\ \\__\\  \\ \\_______\\       \\ \\__\\ \\__\\       \\ \\_______\\\\ \\_______\\\\ \\_______\\\\ \\__\\\\ \\__\\\n    \\|_______| \\|__|\\|__| \\|_______| \\|__|\\|__|     \\|__|   \\|_______|        \\|__|\\|__|        \\|_______| \\|_______| \\|_______| \\|__| \\|__|");
                        Console.WriteLine("\n*------------------------------------------------------------------------------------------------------------------------*\n");
                        Library.AddNewBook(new Book(
                            ReadLineStr("Book name"),
                            new Person(ReadLineStr("Author name"), ReadLineStr("Author surname"), ReadLineInt("Author age")),
                            ReadLineInt("Publish year")));
                            break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\n ________   ________   ________   ___  __       \n|\\   __  \\ |\\   __  \\ |\\   __  \\ |\\  \\|\\  \\     \n\\ \\  \\|\\ /_\\ \\  \\|\\  \\\\ \\  \\|\\  \\\\ \\  \\/  /|_   \n \\ \\   __  \\\\ \\  \\\\\\  \\\\ \\  \\\\\\  \\\\ \\   ___  \\  \n  \\ \\  \\|\\  \\\\ \\  \\\\\\  \\\\ \\  \\\\\\  \\\\ \\  \\\\ \\  \\ \n   \\ \\_______\\\\ \\_______\\\\ \\_______\\\\ \\__\\\\ \\__\\\n    \\|_______| \\|_______| \\|_______| \\|__| \\|__|");
                        Console.WriteLine("\n*--------------------------------------------------------------*\n");

                        var book = Library.FindABook(ReadLineInt("book id"));
                        Console.WriteLine(book is null ? "\n❌  No results found" : Book.GetTheBook());

                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("\n ________   _______    _____ ______    ________   ___      ___  _______      \n|\\   __  \\ |\\  ___ \\  |\\   _ \\  _   \\ |\\   __  \\ |\\  \\    /  /||\\  ___ \\     \n\\ \\  \\|\\  \\\\ \\   __/| \\ \\  \\\\\\__\\ \\  \\\\ \\  \\|\\  \\\\ \\  \\  /  / /\\ \\   __/|    \n \\ \\   _  _\\\\ \\  \\_|/__\\ \\  \\\\|__| \\  \\\\ \\  \\\\\\  \\\\ \\  \\/  / /  \\ \\  \\_|/__  \n  \\ \\  \\\\  \\|\\ \\  \\_|\\ \\\\ \\  \\    \\ \\  \\\\ \\  \\\\\\  \\\\ \\    / /    \\ \\  \\_|\\ \\ \n   \\ \\__\\\\ _\\ \\ \\_______\\\\ \\__\\    \\ \\__\\\\ \\_______\\\\ \\__/ /      \\ \\_______\\\n    \\|__|\\|__| \\|_______| \\|__|     \\|__| \\|_______| \\|__|/        \\|_______|");
                        Console.WriteLine("\n*--------------------------------------------------------------*\n");
                        Library.RemoveBookById(ReadLineInt("book id"));
                        Library.PrintAllBooks();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("\n _______    ________   ___   _________   \n|\\  ___ \\  |\\   ___ \\ |\\  \\ |\\___   ___\\ \n\\ \\   __/| \\ \\  \\_|\\ \\\\ \\  \\\\|___ \\  \\_| \n \\ \\  \\_|/__\\ \\  \\ \\\\ \\\\ \\  \\    \\ \\  \\  \n  \\ \\  \\_|\\ \\\\ \\  \\_\\\\ \\\\ \\  \\    \\ \\  \\ \n   \\ \\_______\\\\ \\_______\\\\ \\__\\    \\ \\__\\\n    \\|_______| \\|_______| \\|__|     \\|__|");
                        Console.WriteLine("\n*--------------------------------------------------------------*\n");

                        var editABook = Library.FindABook(ReadLineInt("book id"));
                        if (editABook is null)
                        {
                            Console.WriteLine("\n❌  No results found");
                        }
                        else
                        {
                            Console.WriteLine("\n1) Edit name\n2) Edit publish year\n3) Edit authors\n4) Add a new author\n");
                            switch (ReadLineInt("choice"))
                            {
                                case 1:
                                    Console.WriteLine();
                                    Book.ChangeBookName(ReadLineStr("book name"));
                                    Console.WriteLine("\n✅ The 'book name' was successfully changed");
                                    break;
                                case 2:
                                    Console.WriteLine();
                                    Book.PublishYear = ReadLineInt("publish year");
                                    Console.WriteLine("\n✅ The 'publish year' was successfully changed");
                                    break;
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine("\n ________   ________   ________     \n|\\   __  \\ |\\   ___ \\ |\\   ___ \\    \n\\ \\  \\|\\  \\\\ \\  \\_|\\ \\\\ \\  \\_|\\ \\   \n \\ \\   __  \\\\ \\  \\ \\\\ \\\\ \\  \\ \\\\ \\  \n  \\ \\  \\ \\  \\\\ \\  \\_\\\\ \\\\ \\  \\_\\\\ \\ \n   \\ \\__\\ \\__\\\\ \\_______\\\\ \\_______\\\n    \\|__|\\|__| \\|_______| \\|_______|");
                                    Console.WriteLine("\n*--------------------------------------------------------------*\n");
                                    Book.AddNewAuthor(new Person(ReadLineStr("Author name"), ReadLineStr("Author surname"), ReadLineInt("Author age")));
                                    Console.WriteLine("\n✅ A new author has been successfully added.");
                                    break;
                            }

                        }
                        break;
                    case 5:
                        Library.PrintAllBooks();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("\n ___   ________    ________  ________     \n|\\  \\ |\\   ___  \\ |\\  _____\\|\\   __  \\    \n\\ \\  \\\\ \\  \\\\ \\  \\\\ \\  \\__/ \\ \\  \\|\\  \\   \n \\ \\  \\\\ \\  \\\\ \\  \\\\ \\   __\\ \\ \\  \\\\\\  \\  \n  \\ \\  \\\\ \\  \\\\ \\  \\\\ \\  \\_|  \\ \\  \\\\\\  \\ \n   \\ \\__\\\\ \\__\\\\ \\__\\\\ \\__\\    \\ \\_______\\\n    \\|__| \\|__| \\|__| \\|__|     \\|_______|");
                        Console.WriteLine("\n*--------------------------------------------------------------*\n");
                        Console.WriteLine($"🏫 Library's name: '{Library.NameOfTheLibrary}'\n📍 Library's location: '{Library.LocatedCity}'\n📚 Book count: {Library.BookCount.ToString()} books");
                        break;
                    case 7:
                        Console.WriteLine(" \n ________   ___  ___   _________   ___  ___   ________   ________   ________      \n|\\   __  \\ |\\  \\|\\  \\ |\\___   ___\\|\\  \\|\\  \\ |\\   __  \\ |\\   __  \\ |\\   ____\\     \n\\ \\  \\|\\  \\\\ \\  \\\\\\  \\\\|___ \\  \\_|\\ \\  \\\\\\  \\\\ \\  \\|\\  \\\\ \\  \\|\\  \\\\ \\  \\___|_    \n \\ \\   __  \\\\ \\  \\\\\\  \\    \\ \\  \\  \\ \\   __  \\\\ \\  \\\\\\  \\\\ \\   _  _\\\\ \\_____  \\   \n  \\ \\  \\ \\  \\\\ \\  \\\\\\  \\    \\ \\  \\  \\ \\  \\ \\  \\\\ \\  \\\\\\  \\\\ \\  \\\\  \\|\\|____|\\  \\  \n   \\ \\__\\ \\__\\\\ \\_______\\    \\ \\__\\  \\ \\__\\ \\__\\\\ \\_______\\\\ \\__\\\\ _\\  ____\\_\\  \\ \n    \\|__|\\|__| \\|_______|     \\|__|   \\|__|\\|__| \\|_______| \\|__|\\|__||\\_________\\\n                                                                      \\|_________|");
                        Console.WriteLine("\n*--------------------------------------------------------------*\n");
                        var bookId = ReadLineInt("book id");
                        Console.WriteLine(Book.GetAuthors(Book.Authors));
                        break;
                    
                }
                
            } while (inChoice != 9);
        }

        private static void PrintMenus(int menuNum)
        {
            switch (menuNum)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("\n _____ ______    _______    ________    ___  ___     \n|\\   _ \\  _   \\ |\\  ___ \\  |\\   ___  \\ |\\  \\|\\  \\    \n\\ \\  \\\\\\__\\ \\  \\\\ \\   __/| \\ \\  \\\\ \\  \\\\ \\  \\\\\\  \\   \n \\ \\  \\\\|__| \\  \\\\ \\  \\_|/__\\ \\  \\\\ \\  \\\\ \\  \\\\\\  \\  \n  \\ \\  \\    \\ \\  \\\\ \\  \\_|\\ \\\\ \\  \\\\ \\  \\\\ \\  \\\\\\  \\ \n   \\ \\__\\    \\ \\__\\\\ \\_______\\\\ \\__\\\\ \\__\\\\ \\_______\\\n    \\|__|     \\|__| \\|_______| \\|__| \\|__| \\|_______|");
                    Console.WriteLine("\n*--------------------------------------------------------------*\n");
                    Console.WriteLine("\n" + 
                                      "0) Display the menu\n" +
                                      "1) Create a new book\n" +
                                      "2) Find a book\n" +
                                      "3) Edit a book\n" +
                                      "4) Remove a book\n" +
                                      "5) Print all book\n" +
                                      "6) Library info\n" + 
                                      "7) Edit library\n" +
                                      "8) Get the all authors for a specific book"
                    );
                    break;
            }
        }
        
    }
}