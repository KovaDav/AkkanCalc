using System;
using System.Collections.Generic;
using System.Linq;

namespace AkkanCalculator
{
    public class Calculator
    {
        private List<Player> PlayerList = new List<Player>();
        private double GoldPerPerson;
        public Calculator(List<Player> list)
        {
            PlayerList = list;
            GoldPerPerson = ((((PlayerList.Sum(x => x.Gold)/PlayerList.Count)*2.06)*0.95)+((PlayerList.Sum(x => x.Gold)/PlayerList.Count)*2.94))/PlayerList.Count;
        }
        
        public void Result()
        {
            foreach (var player in PlayerList)
            {
                Console.WriteLine(player.Name + player.Gold);
            }
        }

        public void SendGold()
        {
            Player SendGoldTo = PlayerList.Find(x => x.Gold == 0);
            double SendableGold = PlayerList[0].Gold - GoldPerPerson;
            PlayerList[0].SendGold(SendGoldTo, SendableGold);
            PlayerList[1].SendGold(SendGoldTo, (GoldPerPerson - SendGoldTo.Gold) / 0.95);

            double Player2SendableGold = PlayerList[1].Gold - GoldPerPerson;

            Player SendGoldTo2 = PlayerList.Find(x => x.Gold == 0);
            
            PlayerList[1].SendGold(SendGoldTo2, Player2SendableGold);
            PlayerList[2].SendGold(SendGoldTo2, PlayerList[2].Gold-GoldPerPerson);
            
        }
        
    }
}