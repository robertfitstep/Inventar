using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventar
{
    public class Weapon : ItemBase
    {
        public Weapon(int pCost, int pCount, double pWeight, string pName, ItemType pItemType) : base(pCost, pCount, pWeight, pName, pItemType)
        {
        }

        public override string DescribeItem()
        {
            string s = "";

            s = Name + " | Cost: " + cost + " | Type: " + itemType;

            return s;
        }
    }
}
