using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YugiohApplication
{
    class LifePointCalculator
    {
        // basic params
        public string Name;
        public string DeckName;

        // Initialize for both player life points
        public int PlayerLifePts = 8000;
        
        // Base params for adding a certain amount
        //of Life pts
        public int AmtThousand = 1000;
        public int AmtEight = 800;

        //param for turn counter based
        // on cards that rely on number of turns
        public int TurnCounter = 0;

        public void DisplayPlayerInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Deck: " + DeckName);
            Console.WriteLine(PlayerLifePts);
        }
        public void AddThousandLPs()
        {
            PlayerLifePts += AmtThousand;
        }
        public void SubThousandLPs()
        {
            PlayerLifePts -= AmtThousand;
        }
        public void AddCustomAmount(int value)
        {
            PlayerLifePts += value;
        }
    }
}
