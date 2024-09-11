using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPPING10.O
{
    class user
    {
        string username;
        int userid;

        public user(string username, int userid)
        {
            this.username = username;
            this.userid = userid;
        }

        public string Username { get => username; set => username = value; }
        public int Userid { get => userid; set => userid = value; }
    }
}
