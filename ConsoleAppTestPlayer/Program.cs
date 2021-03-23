using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestPlayer
{
    class Program
    {
        public static List<Player> Playerlist()
        {
            List<Player> plist = new List<Player>
            {
                new Player{PlayerId=2,PlayerName="Dhoni",PlayerTeam="India"},
                new Player{PlayerId=3,PlayerName="Sachin",PlayerTeam="India"},
                new Player{PlayerName="Virat",PlayerTeam="India"},
                new Player{PlayerId=5,PlayerTeam="Emgland"},
                new Player{PlayerId=44,PlayerName="Kane",PlayerTeam="New Zealand"}

            };

            return plist;
        }
        static void Main(string[] args)
        {
        }
    }
}
