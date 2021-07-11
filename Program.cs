using System;

namespace Tankas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....................\n Lets Start Combat! \n....................");
            Console.WriteLine("<    Turn Left");
            Console.WriteLine(">    Turn Right");
            Console.WriteLine("ENTER    FIRE!");
            Console.WriteLine("⟰   Move Forward");
            Console.WriteLine("⟱   Move Back");
            Console.WriteLine("i    Show Info");
            Console.WriteLine("ESC  Game Over\n");

            Tank tank1 = new Tank(Direction.Latvia, 0, 0, 0);
            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey();
                //Console.WriteLine(cki.Key);
                //Console.WriteLine(cki.KeyChar);
                if (cki.Key == ConsoleKey.LeftArrow)
                {
                    tank1.Left();
                }else if (cki.Key == ConsoleKey.RightArrow)
                {
                    tank1.Right();
                }else if (cki.Key == ConsoleKey.Enter)
                {
                    tank1.Fire();
                }
                else if (cki.Key == ConsoleKey.UpArrow)
                {
                    tank1.Forward();
                }
                else if (cki.Key == ConsoleKey.DownArrow)
                {
                    tank1.Back();
                    
                }else if (cki.Key == ConsoleKey.I)
                {
                    tank1.Info();
                }
            } while (tank1.moveCount < 15 && cki.Key != ConsoleKey.Escape);
            Console.WriteLine("GGame Over");
        }
    }
}