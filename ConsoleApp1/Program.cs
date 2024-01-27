using System;

namespace ConsoleApp1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IBookLogicInterface logic = new BookLogic(new BookDataAccess());
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please select one of the three ooption");
                Console.WriteLine("----- Type L : to display all books");
                Console.WriteLine("----- Type D:{book title} to see the decription of the book");
                Console.WriteLine("----- Type E to exit");

                string command = Console.ReadLine();

                switch (command)
                {
                    case "L":
                        Console.WriteLine("List of all books: ");
                        var bookList = logic.GetBooks();
                        foreach (var b in bookList)
                        {
                            Console.Write($"--Title : {b.Title}");
                            Console.WriteLine();
                        }
                        break;
                    case string str when command.StartsWith("D"):
                        try
                        {
                            var part = str.Split(":"); //string array will be return
                            var book = logic.GetBookByTitle(part[1]);// part[1] = title of the book
                            Console.Write($"--Title : {book.Title} \n");
                            Console.WriteLine($"--Description : {book.Description}");
                        }
                        catch
                        {
                            Console.WriteLine("Please enter a vaild book title");
                        }
                        break;
                    case "E":
                        return;
                    default:
                        break;
                }

            }
        }
    }
}