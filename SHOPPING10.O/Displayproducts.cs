using System;
using System.Collections;

namespace SHOPPING10.O
{
    class Display
    {
        ArrayList van = new ArrayList();
        public ArrayList Displayproducts(ourstock stk)
        {
            ArrayList van = stk.getstock();
            Console.WriteLine("ID \t Name\t   Price");
            foreach (items it in van)
            {
                Console.WriteLine(it.Itemid + "\t" + it.Itemname + "\t" + it.Itemprice);
            }
            return van;
        }
    }
}