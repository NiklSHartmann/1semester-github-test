using _230313_SYS_Warehouse_2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230313_SYS_Warehouse_2
{
    public class Program
    {
        public Database Database { get; set; }
        public Logic Logic { get; set; }


        static void Main(string[] args)
        {
            var database = new Database();
            var logic = new Logic();
            Database.CreateDummyData();
            //boolean to ask wether or not the program is running
            bool running = true;
            
            //as long as the program is running, this while loop will allow the user to access the database via different cases..
            //when the user is done accessing the database via one  of the different cases,
            //the while loop will repeat the loop and allow the user to once gain access the database via differnet cases.
            
            while (running)
            {
                //prompts the user to choose how they want to access the database via number input. 
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1 - Create new product");
                Console.WriteLine("2 - Update product");
                Console.WriteLine("3 - Delete product");
                Console.WriteLine("4 - Show all current stock");
                Console.WriteLine("5 - Calculate total stock value");
                Console.WriteLine("6 - Show specific product");
                Console.WriteLine("0 - Exit program");

                string input = Console.ReadLine();

                switch (input)
                {
                    //create new product
                    case "1":
                        {
                            Logic.Case1();
                            break;
                        }
                    //Update product
                    case "2":
                        {
                            Logic.Case2();
                            break;
                        }
                    //Delete Product
                    case "3":
                        {
                            Logic.Case3();
                            break;
                        }
                    //Show all current stock
                    case "4":
                        {
                            Logic.Case4();
                            break;
                        }
                    //Calculate total stock value
                    case "5":
                        {
                            Logic.Case5();
                            break;
                        }
                    //show a specific product from warehouse
                    case "6":
                        {
                            Logic.Case6();
                            break;
                        }
                    //exit program
                    case "0":
                        {
                            Environment.Exit(0);
                            running = false;
                            break;
                        }
                    // if user inputs an invalid option, console will prompt them to try again
                    default:
                        {
                            Console.WriteLine("Invalid operation. Try again");
                            break;
                        }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}