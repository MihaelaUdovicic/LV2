using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    class Die
    {
        private int numberOfSides;
        private Random randomGenerator;
        public Die(int numberOfSides, Random randomGenerator)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = randomGenerator;
        }
        public int Roll()
        {
            int rolledNumber = randomGenerator.Next(1, numberOfSides + 1);
            return rolledNumber;
        }
    }
}


/*
 * ..............3.Zadatal..............

class Die
{
    private int numberOfSides;
    private RandomGenerator randomGenerator;

    public Die(int numberOfSides, RandomGenerator randomGenerator)
    {
        this.numberOfSides = numberOfSides;
        this.randomGenerator = RandomGenerator.GetInstance();
    }

    public int Roll()
    {
        int rolledNumber = randomGenerator.NextInt(1, numberOfSides + 1);
        return rolledNumber;
    }
}
  */


//........ORIGINAL..DIE........
//class Die
//{
//    private int numberOfSides;
//    private Random randomGenerator;
//    public Die(int numberOfSides)
//    {
//        this.numberOfSides = numberOfSides;
//        this.randomGenerator = new Random();
//    }
//    public int Roll()
//    {
//        rolledNumber = randomGenerator.Next(1, numberOfSides + 1);
//        return rolledNumber;
//    }
//}

