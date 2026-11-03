using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
            Console.Clear();
            foreach (var ch in chars)
            {
                Console.WriteLine("---");
                Console.WriteLine("pos: " + ch.Pos);
                Console.WriteLine("hp:" + ch.Health);
            }
            const int BoardSize = 40;
            char[] board = new char[BoardSize];
            Array.Fill(board, '_');
            foreach (var ch in chars)
            {
                double clamped = Math.Clamp(ch.Pos, -100.0, 100.0);
                int idx = (int)(clamped / (100 / BoardSize * 2) + (BoardSize / 2 - 1));
                idx = Math.Clamp(idx, 0, BoardSize - 1);
                board[idx] = '#';
            }
            Array.ForEach(board, x => Console.Write(x));
        }
    }
}
