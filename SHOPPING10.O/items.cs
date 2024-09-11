using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPPING10.O
{
    class items
    {
        int itemid;
        string itemname;
        int itemprice;

        public items(int itemid, string itemname, int itemprice)
        {
            this.Itemid = itemid;
            this.Itemname = itemname;
            this.Itemprice = itemprice;
        }

        public int Itemid { get => itemid; set => itemid = value; }
        public string Itemname { get => itemname; set => itemname = value; }
        public int Itemprice { get => itemprice; set => itemprice = value; }
    }
}
