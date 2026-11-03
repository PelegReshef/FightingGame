using System;
using System.Collections.Generic;
using System.Text;

namespace FightingGame
{
    internal struct Attack
    {
        public Attack()
        {

        }
        public Attack(double dam, double knb)
        {
            Damage = dam;
            Knockback = knb;
        }
        public double Damage = 0;
        public double Knockback = 0;
    }
}
