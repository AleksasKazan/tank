using System;
using System.Collections.Generic;

namespace Tankas
{
    public class Tank
    {
        public int PositionX;
        public int PositionY;
        public Direction Direction;
        public int moveCount;
        public int FireCount;
        private int countLatvia;
        private int countBelarus;
        private int countPoland;
        private int countSweden;
        List<string> iterations = new List<string>();

        public Tank(Direction direction, int positionX, int positionY, int fireCount)
        {
            Direction = direction;
            PositionX = positionX;
            PositionY = positionY;
            FireCount = fireCount;
        }

        public void Fire()
        {
            if (FireCount < 10)
            {
                Console.WriteLine("\nFIRE !!!");
                FireCount++;
                Console.WriteLine($"Left bullets: {10-FireCount}\n");
                if (Direction == Direction.Latvia)
                {
                    countLatvia++;
                }
                else if (Direction == Direction.Belarus)
                {
                    countBelarus++;
                }
                else if (Direction == Direction.Poland)
                {
                    countPoland++;
                }
                else
                {
                    countSweden++;
                }
            }
            else
            {
                Console.WriteLine("No more bullets");
            }
            var iteration = $"\nFire: {FireCount}\nDirection: {Direction}\nPosition X Y: ({PositionX} {PositionY})";
            iterations.Add(iteration);
            foreach (string item in iterations)
            {
                Console.WriteLine(item);
            }
        }

        public void Info()
        {
            Console.WriteLine($"\n\nDirection: {Direction}\nPosition X Y: ({PositionX} {PositionY})\nFires: {FireCount}\nMoves: {moveCount}\nFires to Latvia: {countLatvia}\nFires to Belarus: {countBelarus}\nFires to Poland: {countPoland}\nFires to Sweden: {countSweden}");
        }

        public void Forward()
        {
            if (Direction == Direction.Latvia)
            {
                PositionY++;
            }
            else if (Direction == Direction.Belarus)
            {
                PositionX++;
            }
            else if (Direction == Direction.Poland)
            {
                PositionY--;
            }
            else PositionX--;
            moveCount++;
            Console.WriteLine("Forward");
        }

        public void Back()
        {
            Console.WriteLine("Back");
            if (Direction == Direction.Latvia)
            {
                PositionY--;
            }
            else if (Direction == Direction.Belarus)
            {
                PositionX--;
            }
            else if (Direction == Direction.Poland)
            {
                PositionY++;
            }
            else PositionX++;
            moveCount++;
        }

        public void Right()
        {
            Console.WriteLine("Right");
            if ((int)Direction > 2)
            {
                Direction = (Direction)(-1);
            }
            Direction++;
        }

        public void Left()
        {
            Console.WriteLine("Left");
            if ((int)Direction < 1)
            {
                Direction = (Direction)(4);
            }
            Direction--;
        }
    }
}
