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
        public int PlayerOneLifePts = 8000;
        public int PlayerTwoLifePts = 8000;

        // Base params for adding a certain amount
        //of Life pts
        public int AddThousand = 1000;
        public int PayEight = 800;

        //param for turn counter based
        // on cards that rely on number of turns
        public int TurnCounter = 0;

        public void DisplayPlayerInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Deck: " + DeckName);
        }
        public void AddThousandLPs()
        {
            PlayerOneLifePts += AddThousand;
        }
    }
}
