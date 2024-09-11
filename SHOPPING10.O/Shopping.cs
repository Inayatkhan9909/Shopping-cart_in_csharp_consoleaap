using System;
using System.Collections;

namespace SHOPPING10.O
{
    class Shopping
    {
        ArrayList trolly = new ArrayList();
        public Shopping(ArrayList vanproducts)
        {
            string choice;
            do
            {
                Console.WriteLine("Enter product id to buy");
                int id = Convert.ToInt32(Console.ReadLine());
                switch (id)
                {
                    case 1:
                        try
                        {
                            trolly.Add(vanproducts[0]);
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Product out of stock");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case 2:
                        try
                        {
                            trolly.Add(vanproducts[1]);
                        }
                       catch
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Product out of stock");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case 3:
                        try
                        {
                            trolly.Add(vanproducts[2]);
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Product out of stock");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case 4:
                        try
                        {
                            trolly.Add(vanproducts[3]);
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Product out of stock");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Product id");
                        break;
                }
                Console.WriteLine("Enter y to continue shopping");
                choice = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            } while (choice == "y");
           

            Billing bil = new Billing();
            bil.generatebill(trolly);
        }
        
        
    }
}