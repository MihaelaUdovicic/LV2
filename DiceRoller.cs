using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    class DiceRoller
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;

        private FileLogger fileL;
        private ConsoleLogger ConL;

        public DiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
            this.fileL = new FileLogger("File");
            this.ConL = new ConsoleLogger("Console");

        }

        public void InsertDie(Die die)
        {
            dice.Add(die);
        }

        public void RollAllDice()
        {
            //clear results of previous rolling
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }

        //View of the results
        public IList<int> GetRollingResults()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<int>(this.resultForEachRoll);
        }

        public int DiceCount
        {
            get { return dice.Count; }
        }



        public void IspisListe(IList<int> lista)
        {
            foreach (int i in lista)
            {
                Console.WriteLine(i );
            }
        }

        public void FLogRollingResults()
        {
            foreach (int result in this.resultForEachRoll)
            {
                fileL.Log(result.ToString());
            }
        }
        public void CLogRollingResults()
        {
            foreach (int result in this.resultForEachRoll)
            {
                ConL.Log(result.ToString());
            }
        }
    }
}
