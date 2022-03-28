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
            Library.CreateLibrary(ReadLineStr("the library name"),
                ReadLineStr("located city"));
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
                        Console.WriteLine("\n*--------------------------------------------------------------------------------------------------------------------------------------------*\n");
                        Library.AddNewBook(new Book(
                            ReadLineStr("Book name"),
                            new Person(ReadLineStr("Author name"), ReadLineStr("Author surname"), ReadLineInt("Author age")),
                            ReadLineInt("Publish year")));
                        Console.WriteLine("\n✅ The book was successfully created");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\n ________   ________   ________   ___  __       \n|\\   __  \\ |\\   __  \\ |\\   __  \\ |\\  \\|\\  \\     \n\\ \\  \\|\\ /_\\ \\  \\|\\  \\\\ \\  \\|\\  \\\\ \\  \\/  /|_   \n \\ \\   __  \\\\ \\  \\\\\\  \\\\ \\  \\\\\\  \\\\ \\   ___  \\  \n  \\ \\  \\|\\  \\\\ \\  \\\\\\  \\\\ \\  \\\\\\  \\\\ \\  \\\\ \\  \\ \n   \\ \\_______\\\\ \\_______\\\\ \\_______\\\\ \\__\\\\ \\__\\\n    \\|_______| \\|_______| \\|_______| \\|__| \\|__|");
                        Console.WriteLine("\n*--------------------------------------------------------------*\n");

                        var book = Library.FindABook(ReadLineInt("book id"));
                        Console.WriteLine(book is null ? "\n❌  No results found" : book.GetTheBook());

                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("\n ________   _______    _____ ______    ________   ___      ___  _______      \n|\\   __  \\ |\\  ___ \\  |\\   _ \\  _   \\ |\\   __  \\ |\\  \\    /  /||\\  ___ \\     \n\\ \\  \\|\\  \\\\ \\   __/| \\ \\  \\\\\\__\\ \\  \\\\ \\  \\|\\  \\\\ \\  \\  /  / /\\ \\   __/|    \n \\ \\   _  _\\\\ \\  \\_|/__\\ \\  \\\\|__| \\  \\\\ \\  \\\\\\  \\\\ \\  \\/  / /  \\ \\  \\_|/__  \n  \\ \\  \\\\  \\|\\ \\  \\_|\\ \\\\ \\  \\    \\ \\  \\\\ \\  \\\\\\  \\\\ \\    / /    \\ \\  \\_|\\ \\ \n   \\ \\__\\\\ _\\ \\ \\_______\\\\ \\__\\    \\ \\__\\\\ \\_______\\\\ \\__/ /      \\ \\_______\\\n    \\|__|\\|__| \\|_______| \\|__|     \\|__| \\|_______| \\|__|/        \\|_______|");
                        Console.WriteLine("\n*--------------------------------------------------------------*\n");
                        Library.RemoveBookById(ReadLineInt("book id"));
                        // Library.PrintAllBooks();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("\n _______    ________   ___   _________        ________          ________   ________   ________   ___  __       \n|\\  ___ \\  |\\   ___ \\ |\\  \\ |\\___   ___\\     |\\   __  \\        |\\   __  \\ |\\   __  \\ |\\   __  \\ |\\  \\|\\  \\     \n\\ \\   __/| \\ \\  \\_|\\ \\\\ \\  \\\\|___ \\  \\_|     \\ \\  \\|\\  \\       \\ \\  \\|\\ /_\\ \\  \\|\\  \\\\ \\  \\|\\  \\\\ \\  \\/  /|_   \n \\ \\  \\_|/__\\ \\  \\ \\\\ \\\\ \\  \\    \\ \\  \\       \\ \\   __  \\       \\ \\   __  \\\\ \\  \\\\\\  \\\\ \\  \\\\\\  \\\\ \\   ___  \\  \n  \\ \\  \\_|\\ \\\\ \\  \\_\\\\ \\\\ \\  \\    \\ \\  \\       \\ \\  \\ \\  \\       \\ \\  \\|\\  \\\\ \\  \\\\\\  \\\\ \\  \\\\\\  \\\\ \\  \\\\ \\  \\ \n   \\ \\_______\\\\ \\_______\\\\ \\__\\    \\ \\__\\       \\ \\__\\ \\__\\       \\ \\_______\\\\ \\_______\\\\ \\_______\\\\ \\__\\\\ \\__\\");
                        Console.WriteLine("\n*--------------------------------------------------------------------------------------------------------------------*\n");
                        
                        var editABook = Library.FindABook(ReadLineInt("book id"));
                        if (editABook is null)
                        {
                            Console.WriteLine("\n❌  No results found");
                        }
                        else
                        {
                            Console.WriteLine("\n1) Edit name\n2) Edit publish year\n3) Edit authors\n4) Add a new author\n5) Remove a author\n6) exit\n");
                            switch (ReadLineInt("choice"))
                            {
                                case 1:
                                    Console.WriteLine();
                                    editABook.Name = ReadLineStr("book name");
                                    Console.WriteLine("\n✅ The 'book name' was successfully changed\n");
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("Which one ?\n");
                                    Console.WriteLine(editABook.GetAuthors(editABook.Authors));
                                    var author = editABook.FindAuthorById(ReadLineInt("book id"));
                                    if (author is null)
                                    {
                                        Console.WriteLine("\n❌  No results found");
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n _______    ________   ___   _________        ________   ___  ___   _________   ___  ___   ________   ________     \n|\\  ___ \\  |\\   ___ \\ |\\  \\ |\\___   ___\\     |\\   __  \\ |\\  \\|\\  \\ |\\___   ___\\|\\  \\|\\  \\ |\\   __  \\ |\\   __  \\    \n\\ \\   __/| \\ \\  \\_|\\ \\\\ \\  \\\\|___ \\  \\_|     \\ \\  \\|\\  \\\\ \\  \\\\\\  \\\\|___ \\  \\_|\\ \\  \\\\\\  \\\\ \\  \\|\\  \\\\ \\  \\|\\  \\   \n \\ \\  \\_|/__\\ \\  \\ \\\\ \\\\ \\  \\    \\ \\  \\       \\ \\   __  \\\\ \\  \\\\\\  \\    \\ \\  \\  \\ \\   __  \\\\ \\  \\\\\\  \\\\ \\   _  _\\  \n  \\ \\  \\_|\\ \\\\ \\  \\_\\\\ \\\\ \\  \\    \\ \\  \\       \\ \\  \\ \\  \\\\ \\  \\\\\\  \\    \\ \\  \\  \\ \\  \\ \\  \\\\ \\  \\\\\\  \\\\ \\  \\\\  \\| \n   \\ \\_______\\\\ \\_______\\\\ \\__\\    \\ \\__\\       \\ \\__\\ \\__\\\\ \\_______\\    \\ \\__\\  \\ \\__\\ \\__\\\\ \\_______\\\\ \\__\\\\ _\\ \n    \\|_______| \\|_______| \\|__|     \\|__|        \\|__|\\|__| \\|_______|     \\|__|   \\|__|\\|__| \\|_______| \\|__|\\|__|");
                                        Console.WriteLine("\n*------------------------------------------------------------------------------------------------------------------------*\n");
                                        Console.WriteLine("\n1) Edit name\n2) Edit surname\n3) Edit age\n4) Exit\n");
                                        switch (ReadLineInt("choice"))
                                        {
                                            case 1:
                                                Console.WriteLine();
                                                author.Name = ReadLineStr("name");
                                                break;
                                            case 2:
                                                Console.WriteLine();
                                                author.Surname = ReadLineStr("surname");
                                                break;
                                            case 3:
                                                Console.WriteLine();
                                                author.Age = ReadLineInt("age");
                                                break;
                                            case 4:
                                                break;
                                            default:
                                                Console.WriteLine();
                                                Console.WriteLine("\n❌  There is no such command!");
                                                break;
                                        }
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine();
                                    editABook.PublishYear = ReadLineInt("publish year");
                                    Console.WriteLine("\n✅ The 'publish year' was successfully changed\n");
                                    break;
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine("\n ________   ________   ________          ________   ___  ___   _________   ___  ___   ________   ________     \n|\\   __  \\ |\\   ___ \\ |\\   ___ \\        |\\   __  \\ |\\  \\|\\  \\ |\\___   ___\\|\\  \\|\\  \\ |\\   __  \\ |\\   __  \\    \n\\ \\  \\|\\  \\\\ \\  \\_|\\ \\\\ \\  \\_|\\ \\       \\ \\  \\|\\  \\\\ \\  \\\\\\  \\\\|___ \\  \\_|\\ \\  \\\\\\  \\\\ \\  \\|\\  \\\\ \\  \\|\\  \\   \n \\ \\   __  \\\\ \\  \\ \\\\ \\\\ \\  \\ \\\\ \\       \\ \\   __  \\\\ \\  \\\\\\  \\    \\ \\  \\  \\ \\   __  \\\\ \\  \\\\\\  \\\\ \\   _  _\\  \n  \\ \\  \\ \\  \\\\ \\  \\_\\\\ \\\\ \\  \\_\\\\ \\       \\ \\  \\ \\  \\\\ \\  \\\\\\  \\    \\ \\  \\  \\ \\  \\ \\  \\\\ \\  \\\\\\  \\\\ \\  \\\\  \\| \n   \\ \\__\\ \\__\\\\ \\_______\\\\ \\_______\\       \\ \\__\\ \\__\\\\ \\_______\\    \\ \\__\\  \\ \\__\\ \\__\\\\ \\_______\\\\ \\__\\\\ _\\ \n    \\|__|\\|__| \\|_______| \\|_______|        \\|__|\\|__| \\|_______|     \\|__|   \\|__|\\|__| \\|_______| \\|__|\\|__|");
                                    Console.WriteLine("\n*--------------------------------------------------------------------------------------------------------------*\n");
                                    editABook.AddNewAuthor(new Person(ReadLineStr("Author name"), ReadLineStr("Author surname"), ReadLineInt("Author age")));
                                    Console.WriteLine("\n✅ A new author has been successfully added.\n");
                                    break;
                                case 5:
                                    Console.WriteLine();
                                    Console.WriteLine("Which one ?\n");
                                    Console.WriteLine(editABook.GetAuthors(editABook.Authors));
                                    Console.WriteLine();
                                    var authorId = ReadLineInt("author's id");
                                    
                                    if (editABook.FindAuthorById(authorId) is null)
                                    {
                                        Console.WriteLine("\n❌  No results found");
                                    }
                                    else
                                    {
                                        if (editABook.Authors.Length <= 1)
                                        {
                                            Console.WriteLine("\n❌  The last author cannot be removed");
                                        }
                                        else
                                        {
                                            editABook.RemoveAuthorById(authorId);
                                            Console.WriteLine("\n✅ The author has been successfully removed.\n");
                                        }
                                       
                                    }
                                    break;
                                case 6:
                                    break;
                                default:
                                    Console.WriteLine("\n❌  There is no such command!");
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
                        Console.WriteLine("\n*---------------------------------------------*\n");
                        Console.WriteLine($"🏫 Library's name: '{Library.NameOfTheLibrary}'\n📍 Library's location: '{Library.LocatedCity}'\n📚 Book count: {Library.BookCount.ToString()} books");
                        break;
                    case 7: 
                        Console.Clear();
                        Console.WriteLine("\n _______    ________   ___   _________        _________   ___  ___   _______           ___        ___   ________   ________   ________   ________       ___    ___ \n|\\  ___ \\  |\\   ___ \\ |\\  \\ |\\___   ___\\     |\\___   ___\\|\\  \\|\\  \\ |\\  ___ \\         |\\  \\      |\\  \\ |\\   __  \\ |\\   __  \\ |\\   __  \\ |\\   __  \\     |\\  \\  /  /|\n\\ \\   __/| \\ \\  \\_|\\ \\\\ \\  \\\\|___ \\  \\_|     \\|___ \\  \\_|\\ \\  \\\\\\  \\\\ \\   __/|        \\ \\  \\     \\ \\  \\\\ \\  \\|\\ /_\\ \\  \\|\\  \\\\ \\  \\|\\  \\\\ \\  \\|\\  \\    \\ \\  \\/  / /\n \\ \\  \\_|/__\\ \\  \\ \\\\ \\\\ \\  \\    \\ \\  \\           \\ \\  \\  \\ \\   __  \\\\ \\  \\_|/__       \\ \\  \\     \\ \\  \\\\ \\   __  \\\\ \\   _  _\\\\ \\   __  \\\\ \\   _  _\\    \\ \\    / / \n  \\ \\  \\_|\\ \\\\ \\  \\_\\\\ \\\\ \\  \\    \\ \\  \\           \\ \\  \\  \\ \\  \\ \\  \\\\ \\  \\_|\\ \\       \\ \\  \\____ \\ \\  \\\\ \\  \\|\\  \\\\ \\  \\\\  \\|\\ \\  \\ \\  \\\\ \\  \\\\  \\|    \\/  /  /  \n   \\ \\_______\\\\ \\_______\\\\ \\__\\    \\ \\__\\           \\ \\__\\  \\ \\__\\ \\__\\\\ \\_______\\       \\ \\_______\\\\ \\__\\\\ \\_______\\\\ \\__\\\\ _\\ \\ \\__\\ \\__\\\\ \\__\\\\ _\\  __/  / /    \n    \\|_______| \\|_______| \\|__|     \\|__|            \\|__|   \\|__|\\|__| \\|_______|        \\|_______| \\|__| \\|_______| \\|__|\\|__| \\|__|\\|__| \\|__|\\|__||\\___/ /     \n                                                                                                                                                      \\|___|/");
                        Console.WriteLine("\n*-----------------------------------------------------------------------------------------------------------------------------------------------------------------*\n");
                        Console.WriteLine("\n1) Edit name\n2) Edit located city\n3) Exit\n");

                        switch (ReadLineInt("choice"))
                        {
                            case 1:
                                Console.WriteLine();
                                Library.NameOfTheLibrary = ReadLineStr("the library name");
                                Console.WriteLine("\n✅ The 'library's name' was successfully changed\n");
                                break;
                            case 2:
                                Console.WriteLine();
                                Library.LocatedCity = ReadLineStr("located city");
                                Console.WriteLine("\n✅ The 'library's location' was successfully changed\n");
                                break;
                            case 3:
                                break;
                            default:
                                Console.WriteLine("\n❌  There is no such command!");
                                break;
                        }
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine(" \n ________   ___  ___   _________   ___  ___   ________   ________   ________      \n|\\   __  \\ |\\  \\|\\  \\ |\\___   ___\\|\\  \\|\\  \\ |\\   __  \\ |\\   __  \\ |\\   ____\\     \n\\ \\  \\|\\  \\\\ \\  \\\\\\  \\\\|___ \\  \\_|\\ \\  \\\\\\  \\\\ \\  \\|\\  \\\\ \\  \\|\\  \\\\ \\  \\___|_    \n \\ \\   __  \\\\ \\  \\\\\\  \\    \\ \\  \\  \\ \\   __  \\\\ \\  \\\\\\  \\\\ \\   _  _\\\\ \\_____  \\   \n  \\ \\  \\ \\  \\\\ \\  \\\\\\  \\    \\ \\  \\  \\ \\  \\ \\  \\\\ \\  \\\\\\  \\\\ \\  \\\\  \\|\\|____|\\  \\  \n   \\ \\__\\ \\__\\\\ \\_______\\    \\ \\__\\  \\ \\__\\ \\__\\\\ \\_______\\\\ \\__\\\\ _\\  ____\\_\\  \\ \n    \\|__|\\|__| \\|_______|     \\|__|   \\|__|\\|__| \\|_______| \\|__|\\|__||\\_________\\\n                                                                      \\|_________|");
                        Console.WriteLine("\n*--------------------------------------------------------------------------------------*\n");
                        var bookId = ReadLineInt("book id");
                        if (Library.FindABook(bookId) is null)
                        {
                            Console.WriteLine("\n❌  No results found");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine(Library.FindABook(bookId).GetAuthors(Library.FindABook(bookId).Authors));
                        }
                        break;
                    
                    case 9:
                        Console.Clear();
                        Console.WriteLine("✅ Library has been successfully deleted\n");
                        Console.WriteLine("The program was stopped");
                        break;
                    
                    default: 
                        Console.WriteLine("\n❌  There is no such command!");
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
                                      "8) Get the all authors for a specific book\n" +
                                      "9) Delete library and stop program"
                    );
                    break;
            }
        }
        
    }
}