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

        public MobileObject(int health, int attackDamage, bool canAttack)
        {
            _HealthPoints = health;
            _AttackDamage = attackDamage;
            _CanAttack = canAttack;

        }

        public int health { get { return _HealthPoints; } set { _HealthPoints = value; } }
        public int attackDamage { get { return _AttackDamage; } set { _AttackDamage = value; } }
        public bool canAttack { get { return _CanAttack; } set { _CanAttack = value; } }

        public void onSpawn()
        {
            _HealthPoints = health;
            _AttackDamage = attackDamage;
            _CanAttack = canAttack;
        }

        public void onDeath()
        {
            health = 0;
            attackDamage = 0;
            canAttack = false;
        }
    }
}
