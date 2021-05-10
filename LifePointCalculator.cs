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
        const int amtThousand = 1000;
        const int amtEight = 800;

        static Random random = new Random();

        private int diceRoll = random.Next(1, 7);

        public void DisplayPlayerInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Deck: " + DeckName);
            Console.WriteLine(PlayerLifePts);
        }
        public void AddThousandLPs()
        {
            PlayerLifePts += amtThousand;
        }
        public void SubThousandLPs()
        {
            PlayerLifePts -= amtThousand;
        }
        public void AddCustomAmount(int value)
        {
            PlayerLifePts += value;
        }
        public void SubCustomAmount(int value)
        {
            PlayerLifePts -= value;
        }
        public void SubEight()
        {
            PlayerLifePts -= amtEight;
        }
        public int GetDiceRoll()
        {
            return diceRoll;
        }
        

    }
}
