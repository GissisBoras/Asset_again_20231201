
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace Asset_20231201
{
    class Program

    {



        static void Main()

        {

            List<Tool> assetItems = new List<Tool>(); // List contining assets

            while (true)
            {

                DisplayMenu();

                string choice = Console.ReadLine();

                switch (choice)
                // Använder switch/case i stället för en if else loops
                // för att hantera användarens val

                {

                    case "1":
                        {
                            Tool.AddTool(assetItems); // Kalla på metod för att lägga till nytt verktyg
                            break;
                        }

                    case "2":
                        {

                            Tool.ShowAssets(); // Kalla på metod för att visa (skriva ut) verkyg
                            break;
                        }

                    case "q":

                        return; // Exit the program

                    default:
                        {
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                        }
                }
            }


            static void DisplayMenu()

            {
                //Skriv ut menyn

                Console.WriteLine("\nMenu");
                Console.WriteLine("\n====");
                Console.WriteLine();
                Console.WriteLine("1. Add asset");
                Console.WriteLine("2. Show assets");

                Console.WriteLine("q. Quit");
                Console.Write("Enter your choice: ");

            }

        }

    }


}



