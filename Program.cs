using System;

namespace Linked_List_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList programList = new LinkedList();

            int userInput;
            Console.WriteLine("add items to list and look at list");

            while (true)
            {


                Console.WriteLine();
                Console.WriteLine("1.list all items");
                Console.WriteLine("2.show head");
                Console.WriteLine("3.add items");
                Console.WriteLine("4.remove items");
                Console.WriteLine("5.search items");
                Console.WriteLine("6.print");
                Console.WriteLine("7.exit");
                userInput = parseinput();
                UserOptions(userInput, programList);
                Console.WriteLine();
                if (userInput == 7)
                    break;
            }
        }

        static void UserOptions(int number, LinkedList programList)
        {
            string newItems;
            switch (number)
            {
                case 1:
                    Console.WriteLine("here is a list of all items that are in the list.");
                    programList.PrintAllNodes();
                    
                    break;
                case 2:
                    Console.WriteLine("here is the first item in the list "+programList.GetFirst());
                    
                    break;
                case 3:
                    Console.WriteLine("enter what you would like to be added to the list");
                    newItems = getuserItem();
                    programList.AddLast(newItems);
                    Console.WriteLine(newItems + " was added");
                    
                    break;
                case 4:
                    Console.WriteLine("enter the item you want to remove.");
                    newItems = getuserItem();
                    Console.WriteLine(programList.RemoveNode(newItems));
                    
                    break;
                case 5:
                    Console.WriteLine("enter the item you want to search for.");
                    newItems = getuserItem();
                    Console.WriteLine(programList.SearchNodes(newItems));
                    Console.WriteLine();
                    break;
                case 6:
                    Console.WriteLine("here is a list of all items that are in the list.");
                    programList.PrintAllNodes();
                    Console.WriteLine();
                    break;
                case 7:
                    Console.WriteLine();
                    break;
            }
        }
        static int parseinput()
        {
            int number;
            while (true)
            {
                bool success = Int32.TryParse(Console.ReadLine(), out number);
                if (success)
                {
                    Console.WriteLine();
                    return number;
                }
                else
                {
                    Console.WriteLine("error not a valid value try again");
                }
            }
        }
        static string getuserItem()
        {
            string userItem;
            userItem = Console.ReadLine();
            userItem.ToUpper();
            return userItem;
        }
    }

}
