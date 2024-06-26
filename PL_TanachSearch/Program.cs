using Bll;
using DTO;
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Welcome to Tanach Search!");

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Search for a word in Tanach");
            Console.WriteLine("2. Search for a number in Tanach");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter a word to search: ");
                    Console.InputEncoding = Encoding.UTF8;
                    string wordToSearch = Console.ReadLine();
                    SearchWord(wordToSearch);
                    break;

                case "2":
                    Console.Write("Enter a number to search: ");
                    if (int.TryParse(Console.ReadLine(), out int numberToSearch))
                    {
                        SearchNumber(numberToSearch);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;

                case "3":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }

    static void SearchWord(string word)
    {
        Console.InputEncoding = Encoding.UTF8;

        ClassBll bll = new ClassBll();
        List<SearchResult> results = bll.TanachSearchWord(word);
        if(results.Count > 0) 
        { 
            Console.WriteLine("Search results:");
            foreach (SearchResult result in results)
            {
                Console.WriteLine(result.ToString());
            }
        }
        else
        {
            Console.WriteLine("No results found.");
        }
    }

    static void SearchNumber(int number)
    {
        ClassBll bll = new ClassBll();
        var results = bll.SesrchNumber(number);

        if (results.Count > 0)
        {
            Console.WriteLine("Search results:");
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
        else
        {
            Console.WriteLine("No results found.");
        }
    }
}
