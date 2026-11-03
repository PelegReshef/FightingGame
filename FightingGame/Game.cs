using System;
using System.Collections.Generic;
using System.Text;

namespace FightingGame
{
    internal class Game
    {
        public void Play()
        {
            Character c1 = new Character()
            {
                Pos = -0.1,
                FacingPositive = true
            };
            Character c2 = new Character()
            {
                Pos = 0.1,
                FacingPositive = false
            };
            while (true)
            {
                PrintChars(c2, c1);
                c2.AbsorbAttack(c1.BasicAttack(c2));

                if (c1.Health <= 0)
                {
                    Console.WriteLine("c2 won");
                    break;
                }

                c1.AbsorbAttack(c2.BasicAttack(c1));
                if (c2.Health <= 0)
                {
                    Console.WriteLine("c1 won");
                    break;
                }

                Console.ReadKey();
            }
        }
        public void PrintChars(params Character[] chars)
        {
            foreach (var ch in chars)
            {
                Console.WriteLine(ch.Pos);
                Console.WriteLine(ch.Health);
            }
        }
    }
}
