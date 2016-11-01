using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4HW1
{
    enum Faction { REBEL, EMPIRE, UNAFFILIATED };

    class NPC : MobileObject
    {
        public NPC()
        {
            health = 100;
            attackDamage = 0;
            canAttack = false;
        }

        public string getFaction()
        {
            Random random = new Random();
            Faction npcFaction = new Faction();

            int result;
            result = random.Next(9);
            if(result == 1 || result == 2 || result == 3)
            {
                npcFaction = Faction.REBEL;
            }
            else if(result == 4 || result == 5 || result == 6)
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
