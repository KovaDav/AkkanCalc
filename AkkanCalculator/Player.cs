using System;

namespace AkkanCalculator
{
    public class Player
    {
        public string Name { get; set; }
        public double Gold { get; set; }

        public Player(string name, double gold)
        {
            Name = name;
            Gold = gold*0.95;
        }

        public void GetGold(double gold)
        {
            Gold += gold * 0.95;
        }

        public void SendGold(Player reciever, double gold)
        {
            reciever.GetGold(gold);
            Gold -= gold;
            Console.WriteLine(Name+" sends "+gold+" to "+reciever.Name);
        }
    }
}