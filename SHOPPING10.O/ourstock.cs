using System;
using System.Collections;

namespace SHOPPING10.O
{
     class ourstock
     {
        ArrayList gowdown = new ArrayList();
        int id = 0;
        public ourstock()
        {
              id++;
             gowdown.Add(new items(id, "lays", 98));
           


        }
        public void addstock(items it)
        {

            gowdown.Add(it);
        }
        public ArrayList getstock()
        {
            return gowdown;
        }

        
    }
}