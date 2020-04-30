using System;
using System.Text;
using System.Collections.Generic;


namespace LV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int strane = 6;
            int bacanja = 20;
            DiceRoller dr = new DiceRoller();

            for (int i = 0; i < bacanja; i++)
            {
                Die d = new Die(strane);
                dr.InsertDie(d);

                dr.RollAllDice();
            }
            IList<int> rez = dr.GetRollingResults();

            dr.IspisListe(rez);

            Console.WriteLine("Count: " + dr.DiceCount);


        }


    }
}


// //.............2.Zadatak.................

//static void Main(string[] args)
//        {
//            int strane = 6;
//            int bacanja = 20;
//            DiceRoller dr = new DiceRoller();
//            Random rand = new Random();

//            for (int i = 0; i < bacanja; i++)
//            {
//                Die d = new Die(strane, rand);
//                dr.InsertDie(d);

//                dr.RollAllDice();
//            }
//            IList<int> rez = dr.GetRollingResults();

//            dr.IspisListe(rez);

//            Console.WriteLine("Count: " + dr.DiceCount);


//        }



    

//    //....................3.Zadatak.....................

//static void Main(string[] args)
//{
//    int strane = 6;
//    int bacanja = 20;
//    DiceRoller dr = new DiceRoller();
//    RandomGenerator rand = RandomGenerator.GetInstance();

//    for (int i = 0; i < bacanja; i++)
//    {
//        Die d = new Die(strane, rand);
//        dr.InsertDie(d);

//        dr.RollAllDice();
//    }

//    IList<int> rez = dr.GetRollingResults();

//    dr.IspisListe(rez);

//    Console.WriteLine("Count: " + dr.DiceCount);


//}


