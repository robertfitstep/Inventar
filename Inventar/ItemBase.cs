using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventar
{
    public enum ItemType
    {
        Weapon = 0,
        Armor = 1,
        Source = 2
    }

    public abstract class ItemBase
    {
        protected int cost;
        protected int count;
        protected double weight;
        protected string Name;
        protected ItemType itemType;

        public ItemBase(int pCost, int pCount, double pWeight, string pName, ItemType pItemType)
        {
            cost = pCost;
            count = pCount;
            weight = pWeight;
            Name = pName;
            itemType = pItemType;
        }
        
        public abstract string DescribeItem();

        public override string ToString()
        {
            return Name;
        }
    }
}
