using Engine.Models;
using System;
using System.Collections.Generic;

namespace Engine.Factories
{
    public static class MonsterFactory
    {
        //private static List<Monster> _currentMonster;

        //static MonsterFactory()
        //{
        //    _currentMonster = new List<Monster>();

        //    _currentMonster.Add(new Monster("Snake", "Snake.png", 4, 4, 5, 1));
        //    _currentMonster.Add(new Monster("Rat", "Rat.png", 5, 5, 5, 1));
        //    _currentMonster.Add(new Monster("Giant Spider", "GiantSpider.png", 10, 10, 10, 3));
            
        //}
        public static Monster GetMonster(int monsterID)
        {
           

            switch (monsterID)
            {
                case 1:
                    Monster snake =
                        new Monster("Venomous Snake", "VenomousSnake.png", 4, 4, 1, 2, 5, 1);

                    AddLootItem(snake, 9001, 99);
                    AddLootItem(snake, 9002, 75);

                    return snake;

                case 2:
                    Monster goblin =
                        new Monster("Goblin", "GoblinGrunt.png", 5, 5, 1, 2, 5, 1);

                    AddLootItem(goblin, 9003, 85);
                    AddLootItem(goblin, 9004, 75);

                    return goblin;

                case 3:
                    Monster giantSpider =
                        new Monster("Giant Spider", "SpiderLord.png", 7, 7, 1, 5, 10, 3);

                    AddLootItem(giantSpider, 9005, 45);
                    AddLootItem(giantSpider, 9006, 65);

                    return giantSpider;

                case 4:
                    Monster stoneTroll =
                        new Monster("Stone Troll", "troll_2.png", 15, 15, 1, 3, 10, 3);

                    AddLootItem(stoneTroll, 9007, 35);
                    AddLootItem(stoneTroll, 9008, 75);

                    return stoneTroll;

                case 5:
                    Monster EarthWyvern =
                        new Monster("Earth Wyvern", "Dragon.png", 12, 12, 3, 6, 10, 3);

                    AddLootItem(EarthWyvern, 9009, 15);
                    AddLootItem(EarthWyvern, 9010, 55);

                    return EarthWyvern;

                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }

        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.AddItemToInventory(ItemFactory.CreateGameItem(itemID));
            }
        }
    }
}