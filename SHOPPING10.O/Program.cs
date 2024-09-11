using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPPING10.O
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager mgr = new Manager();
            Console.ReadLine();
        }
    }

     class Manager
     {
        ArrayList vanproducts = new ArrayList();
      
        public Manager()
        {
            ourstock stk = new ourstock();
            string loginchoice;
            do
            {
                Console.WriteLine("Enter 1 for Customer login\n Enter 2 for employee login");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Welcome to Customer portal");
                        Display dps = new Display();
                        vanproducts = dps.Displayproducts(stk);
                        Shopping shp = new Shopping(vanproducts);
                        break;
                    case 2:
                       
                            Console.WriteLine("Enter useername");
                            string username = Console.ReadLine();
                            Console.WriteLine("Enter password");
                            int password = Convert.ToInt32(Console.ReadLine());
                       
                        credentials crd = new credentials();
                        Boolean user = crd.checkuser(new user(username, password));
                        if (user)
                        {
                            Console.WriteLine("Welcome to Employee portal");

                            ArrayList mystok = stk.getstock();

                            Console.WriteLine("how many products you want to add");
                            int qtt = Convert.ToInt32(Console.ReadLine());
                            int i ;
                            int idd = 0;
                            int pprice = 0;
                            string pname = "";
                            for (i = 1; i <= qtt; i++)
                            {
                                foreach (items itm in mystok)
                                {
                                    idd = itm.Itemid;
                                    

                                }
                                Console.WriteLine("Enter product name");
                                pname = Console.ReadLine();
                                Console.WriteLine("Enter product price");
                                pprice = Convert.ToInt32(Console.ReadLine());
                                idd++;
                                stk.addstock(new items(idd++, pname, pprice));
                            }
                            


                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid username or password");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Entry");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                }
                Console.WriteLine("Enter y to continue");
                loginchoice = Console.ReadLine();

            } while (loginchoice == "y");
        }
  }

     class credentials
     {
        public Boolean checkuser(user usr)
        {
            if (usr.Username.Equals("owais") && usr.Userid.Equals(9909))
                return true;
            else
                return false;
        }

     }
}
