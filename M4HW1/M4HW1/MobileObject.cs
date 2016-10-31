using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4HW1
{
    class MobileObject
    {
        private int _HealthPoints;
        private int _AttackDamage;
        private bool _CanAttack = false;

        public int health { get { return _HealthPoints; } set { _HealthPoints = value; } }
        public int attackDamage { get { return _AttackDamage; } set { _AttackDamage = value; } }
        public bool canAttack { get { return _CanAttack; } set { _CanAttack = value; } }

        public void onSpawn()
        {
            health = 100;
            attackDamage = 20;
            canAttack = true;
        }

        public void onDeath()
        {
            health = 0;
            attackDamage = 0;
            canAttack = false;
        }

        //public int onCombatStart()
        //{
        //    Random rand = new Random();

        //    int result;

        //    result = rand.Next(attackDamage) + 1;
        //    attackDamage = result;
        //    return result;

        //}
    }
}
