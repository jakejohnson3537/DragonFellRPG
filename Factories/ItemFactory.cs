using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static List<GameItem> _standardGameItems;

        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();

            _standardGameItems.Add(new Weapon(1001, "Pointy Stick", 1, 1, 2));
            _standardGameItems.Add(new Weapon(1002, "Rusty Sword", 5, 1, 3));
            _standardGameItems.Add(new Weapon(1003, "Spear", 10, 3, 6)); 
            _standardGameItems.Add(new Weapon(1004, "Posion Daggers", 15, 3, 8));
            _standardGameItems.Add(new GameItem(9001, "Snake fang", 1));
            _standardGameItems.Add(new GameItem(9002, "Snakeskin", 4));
            _standardGameItems.Add(new GameItem(9003, "Goblin ear", 1));
            _standardGameItems.Add(new GameItem(9004, "Goblin armor", 2));
            _standardGameItems.Add(new GameItem(9005, "Spider fang", 1));
            _standardGameItems.Add(new GameItem(9006, "Spider silk", 2));
            _standardGameItems.Add(new GameItem(9007, "Troll eye", 5));
            _standardGameItems.Add(new GameItem(9008, "Stone troll flesh", 3));
            _standardGameItems.Add(new GameItem(9009, "Wyvern scale", 10));
            _standardGameItems.Add(new GameItem(9010, "Wyvern claw", 7));

        }

        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);

            if (standardItem != null)
            {
                if (standardItem is Weapon)
                {
                    return (standardItem as Weapon).Clone();
                }

                return standardItem.Clone();
            }

            return null;
        }
    }
}
