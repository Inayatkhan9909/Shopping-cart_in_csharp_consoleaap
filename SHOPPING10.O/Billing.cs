using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPPING10.O
{
   
        class Billing
        {
            public void generatebill(ArrayList trolly)
            {


                int sum = 0;

                foreach (items pp in trolly)
                {
                    sum = sum + pp.Itemprice;
                }
                Console.WriteLine("Total amount\t" + sum);
                Console.WriteLine("Enter 1 for Discount avaliability");
                int avl = Convert.ToInt32(Console.ReadLine());
                if (avl == 1)
                {
                    Console.WriteLine("Enter yes if you are first time user ");

                    string user = Console.ReadLine();
                    if (user == "yes")
                    {
                        Console.WriteLine("Congratulations you have got 10% discount");
                        int dis, dst = 0;
                        foreach (items pa in trolly)
                        {
                            dis = sum * 10 / 100;
                            dst = sum - dis;
                        }
                        Console.WriteLine("Discounted Total\t" + dst);
                        Console.WriteLine("________________Thank you for shopping with us______________");
                    }
                    else
                    {
                        Console.WriteLine("Enter yes if you are member ");

                        string us = Console.ReadLine();
                        if (us == "yes")
                        {
                            Console.WriteLine("Congratulations you have got 20% discount");
                            int memdis, memdst = 0;
                            foreach (items pa in trolly)
                            {
                                memdis = sum * 20 / 100;
                                memdst = sum - memdis;
                            }
                            Console.WriteLine("Discounted Total\t" + memdst);
                            Console.WriteLine("________________Thank you for shopping with us______________");
                        }
                        else
                        {
                            Console.WriteLine("________________Thank you for shopping with us______________");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("________________Thank you for shopping with us______________");
                }
            }
        }
    


}
