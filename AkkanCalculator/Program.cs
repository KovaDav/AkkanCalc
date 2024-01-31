using System;
using System.Collections.Generic;

namespace AkkanCalculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Player Player1 = new Player("Frodo", 10000);
            Player Player2 = new Player("Tamo", 10000);
            Player Player3 = new Player("Pako", 10000);
            Player Player4 = new Player("Trickster", 0);
            Player Player5 = new Player("Inga", 0);

            
            
            List<Player> PlayerList = new List<Player>(); 
            PlayerList.Add(Player1);
            PlayerList.Add(Player2);
            PlayerList.Add(Player3);
            PlayerList.Add(Player4);
            PlayerList.Add(Player5);
            
            Calculator calculator = new Calculator(PlayerList);
            calculator.SendGold();

            calculator.Result();
        }
    }
}