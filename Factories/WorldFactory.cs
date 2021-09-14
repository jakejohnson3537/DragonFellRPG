using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(-2, -1, "Farmer's Field",
                "There are rows of corn growing here, with ferocious goblins hiding between them.",
                "C:/Users/jakej/source/repos/SOSCSRPG/RPGUI/images/FarmFields.png");
            
            newWorld.LocationAt(-2, -1).AddMonster(2, 100);

            newWorld.AddLocation(-1, -1, "Farmer's House",
                "This is the house of your neighbor, Farmer Ted.",
                "C:/Users/jakej/source/repos/SOSCSRPG/RPGUI/images/Farmhouse.png");
            newWorld.LocationAt(-1, -1).TraderHere =
                TraderFactory.GetTraderByName("Farmer Ted");

            newWorld.LocationAt(-1, -1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(2));

            newWorld.AddLocation(0, -1, "Home",
                "You really need to clean up, but time isnt on your side for you have an adventure to start!",
                "C:/Users/jakej/source/repos/SOSCSRPG/RPGUI/images/MushroomHome.png");

            newWorld.AddLocation(-1, 0, "Trading Shop",
                "The shop of Susan, the trader.",
                "C:/Users/jakej/source/repos/SOSCSRPG/RPGUI/images/Trader.png");
            newWorld.LocationAt(-1, 0).TraderHere =
                TraderFactory.GetTraderByName("Susan");

            newWorld.AddLocation(0, 0, "Town square",
                "You see a fountain here.",
                "C:/Users/jakej/source/repos/SOSCSRPG/RPGUI/images/TownSquare.png");

            newWorld.AddLocation(1, 0, "Stone drawbridge",
                "There is a bridge here, protecting the town from the monsters in the forest, but out from under the bridge come rumbling stone trolls ",
                "C:/Users/jakej/source/repos/SOSCSRPG/RPGUI/images/TownGate.png");

            newWorld.LocationAt(1, 0).AddMonster(4, 100);

            newWorld.AddLocation(2, 0, "Spider Forest",
                "The trees in this forest are covered with spider webs.",
                "C:/Users/jakej/source/repos/SOSCSRPG/RPGUI/images/SpiderForest.png");

            newWorld.LocationAt(2, 0).AddMonster(3, 100);

            newWorld.AddLocation(0, 1, "Herbalist's hut",
                "You see a small hut, with plants drying from the roof.",
                "C:/Users/jakej/source/repos/SOSCSRPG/RPGUI/images/HerbalistsHut.png");
            newWorld.LocationAt(0, 1).TraderHere =
                TraderFactory.GetTraderByName("Pete the Herbalist");

            newWorld.LocationAt(0, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));

            newWorld.AddLocation(0, 2, "Herbalist's garden",
                "There are many plants here, with snakes hiding behind them.",
                "C:/Users/jakej/source/repos/SOSCSRPG/RPGUI/images/HerbalistsGarden.png");

            newWorld.LocationAt(0, 2).AddMonster(1, 100);

            newWorld.AddLocation(1, 1, "Hilltop home",
                "You see smoke rising from a home on the hill, it seems to have burned down from very hot flames.",
                "C:/Users/jakej/source/repos/SOSCSRPG/RPGUI/images/TownHome3.gif");

            newWorld.AddLocation(1, 2, "Bonedry Valley",
                "The moment you leave from the schorced home a huge flying creature catches your eye, you see it towards the valley so you follow to see what it was!",
                "C:/Users/jakej/source/repos/SOSCSRPG/RPGUI/images/Valley.png");

            newWorld.LocationAt(1, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(3));

            newWorld.LocationAt(1, 2).AddMonster(5, 100);

            return newWorld;
        }
    }
}
