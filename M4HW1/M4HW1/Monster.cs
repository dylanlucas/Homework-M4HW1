using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4HW1
{
    class Monster : MobileObject
    {
        public Monster()
        {
            health = 100;
            attackDamage = 20;
            canAttack = true;
        }

        public string getFaction()
        {
            Random rand = new Random();
            Faction npcFaction = new Faction();

            int result;
            result = rand.Next(3);
            if (result == 1)
            {
                npcFaction = Faction.REBEL;
            }
            else if (result == 2)
            {
                npcFaction = Faction.EMPIRE;
            }
            else
            {
                npcFaction = Faction.UNAFFILIATED;
            }

            return npcFaction.ToString();
        }
    }
}
