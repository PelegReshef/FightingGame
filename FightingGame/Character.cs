using System;
using System.Collections.Generic;
using System.Text;

namespace FightingGame
{
    internal class Character
    {
        public double Pos { get; set; } = 0;
        public double Health { get; set; } = 100;

        public bool FacingPositive { get; set; } = true;

        public void AbsorbAttack(Attack att)
        {
            Health -= att.Damage;
            Pos -= att.Knockback * (FacingPositive ? 1 : -1);

        }
        public Attack BasicAttack(Character other)
        {
            const int maxDam = 30;
            double distance = Math.Abs(Pos - other.Pos);
            double dam = Math.Min(maxDam, maxDam / 2 / distance); 
            return new Attack(dam, Math.Min(3 / Math.Sqrt(distance), 3));
            
        }

    }
}
