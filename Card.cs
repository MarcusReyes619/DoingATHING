using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoingATHING
{
    enum Rarity
    {
        COMMON,
        RARE,
        IDONTCAREATTHISPOINT
    }
    internal class Card
    {
        string name;
        Rarity rarity;
        int number;
        string discription;

        public Card(string name, Rarity rarity, int number, string discription)
        {
            this.name = name;
            this.rarity = rarity;
            this.number = number;
            this.discription = discription;
        }
    }
}
