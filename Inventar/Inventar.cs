using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventar
{
    public class Inventory
    {
        private List<ItemBase> items = new List<ItemBase>();

        public List<ItemBase> Items
        {
            get { return items; }
        }

        public void CreateItem(int pCost, int pCount, double pWeight, string pName, ItemType pItemType)
        {
            ItemBase item = null;
            ItemType itemType = (ItemType)pItemType;
            switch (itemType)
            {
                case ItemType.Armor:
                    item = new Armor(pCost, pCount, pWeight, pName, itemType);
                    break;
                case ItemType.Source:
                    item = new Source(pCost, pCount, pWeight, pName, itemType);
                    break;
                case ItemType.Weapon:
                    item = new Weapon(pCost, pCount, pWeight, pName, itemType);
                    break;
                default:
                    break;
            }

            if (item == null) return;

            AddItem(item);
        }

        public void AddItem(ItemBase pItem)
        {
            items.Add(pItem);
        }

        public void RemoveItem(ItemBase pItem)
        {
            items.Remove(pItem);
        }

        public void RemoveItem(int pIndex)
        {
            if (pIndex < 0 || pIndex >= items.Count)
                return;

            items.RemoveAt(pIndex);
        }
    }
}
