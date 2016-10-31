using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4HW1
{
    class Player : MobileObject
    {
        int rebelRep = 0;
        int empireRep = 0;
        int unaffilliatedRep = 0;

        public Player()
        {
            health = 100;
            attackDamage = 25;
            canAttack = true;

            rebelRep = rebel;
            empireRep = empire;
            unaffilliatedRep = unaff;
        }

        public int rebel { get { return rebelRep; } set { rebelRep = value; } }
        public int empire { get { return empireRep; } set { empireRep = value; } }
        public int unaff { get { return unaffilliatedRep; } set { unaffilliatedRep = value; } }

        public string factionRep()
        {
            string output = "Rebel Repuation = " + rebelRep + "\n" +
                            "Empire Reputation = " + empireRep + "\n" +
                            "Unaffiliated Reputation = " + unaffilliatedRep;

            return output;
        }

        public int playerCombatStart()
        {
            Random rand = new Random();

            int result;

            result = rand.Next(25) + 1;
            attackDamage = result;
            return result;

        }
    }
}
