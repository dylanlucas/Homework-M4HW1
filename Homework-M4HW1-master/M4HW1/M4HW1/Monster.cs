﻿using System;
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
    }
}
