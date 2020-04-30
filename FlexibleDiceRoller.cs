using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    class FlexibleDiceRoller : IDiceRoller1 , IDiceRoller2
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        public FlexibleDiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RemoveAllDice()
        {
            this.dice.Clear();
            this.resultForEachRoll.Clear();
        }
        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }

        //7 zad
        public void uklanjanjekockice(int strana)
        {
            for (int i = 0; i < dice.Count; i++)
            {
                if (dice[i].numberOfSides)== strana{
                    dice.RemoveAt(i);
                    --i; //vracanje vrijednosti indexa
                }
            }

        }
    }

}
