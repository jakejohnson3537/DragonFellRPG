using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Monster : LivingObject
    {
        public string ImageName { get; set; }
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public int RewardExperiencePoints { get; private set; }

        public Monster(string name, string imageName,
                       int maximumHitPoints, int hitPoints,
                       int minimumDamage, int maxmumDamage,
                       int rewardExperiencePoints, int rewardGold)
        {
            Name = name;
            ImageName = string.Format("C:/Users/jakej/source/repos/SOSCSRPG/RPGUI/images/Monsters/{0}", imageName);
            MaximumHitPoints = maximumHitPoints;
            CurrentHitPoints = hitPoints;
            MinimumDamage = minimumDamage;
            MaximumDamage = maxmumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            Gold = rewardGold;
        }
        
    }
}
