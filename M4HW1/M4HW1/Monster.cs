using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4HW1
{
    class Monster : MobileObject
    {
        public Monster(int health, int attackDamage, bool canAttack)
            : base(health, attackDamage, canAttack)
        {
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

        public int mobCombatStart()
        {
            Random rand = new Random();

            int result;

            result = rand.Next(20) + 1;
            attackDamage = result;
            return result;

        }
    }
}
