using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
   
    internal static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();

        static QuestFactory()
        {
            
            
            

            // Declare the items need to complete the quest, and its reward items
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();

            itemsToComplete.Add(new ItemQuantity(9001, 5));
            itemsToComplete.Add(new ItemQuantity(9003, 4));
            itemsToComplete.Add(new ItemQuantity(9009, 3));
            rewardItems.Add(new ItemQuantity(1002, 1));
            rewardItems.Add(new ItemQuantity(1003, 1));
            rewardItems.Add(new ItemQuantity(1004, 1));

            //create list for each quest so we can add reward items to them seperatly
            List<ItemQuantity> quest1_Rewards = new List<ItemQuantity>();
            List<ItemQuantity> quest1_RequiredItems = new List<ItemQuantity>();
            quest1_Rewards.Add(rewardItems[0]);
            quest1_RequiredItems.Add(itemsToComplete[0]);

            List<ItemQuantity> quest2_Rewards = new List<ItemQuantity>();
            List<ItemQuantity> quest2_RequiredItems = new List<ItemQuantity>();
            quest2_Rewards.Add(rewardItems[1]);
            quest2_RequiredItems.Add(itemsToComplete[1]);

            List<ItemQuantity> quest3_Rewards = new List<ItemQuantity>();
            List<ItemQuantity> quest3_RequiredItems = new List<ItemQuantity>();
            quest3_Rewards.Add(rewardItems[2]);
            quest3_RequiredItems.Add(itemsToComplete[2]);


            // Create the quest
            _quests.Add(new Quest(1,
                                  "Clear the herb garden",
                                  "Defeat the snakes in the Herbalist's garden, careful of their venom.",
                                  quest1_RequiredItems,
                                  25, 20,
                                  quest1_Rewards));
            _quests.Add(new Quest(2,
                                  "Clear Farmer Teds' Field",
                                  "Help the farmer with the goblins that have been destroying his crops.",
                                  quest2_RequiredItems,
                                  25, 10,
                                  quest2_Rewards));

            _quests.Add(new Quest(3,
                                  "Slay the Wyvern in Bonedry Valley",
                                  "Test your might, and bravery against the king of the skies. Be ready this will be a challenge",
                                  quest3_RequiredItems,
                                  60, 20,
                                  quest3_Rewards));

        }

        internal static Quest GetQuestByID(int id)
        {
            return _quests.Where(quest => quest.ID == id).FirstOrDefault();
        }
    }
}
