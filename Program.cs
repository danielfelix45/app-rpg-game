using System;
using RPG_Game.src.Entities;

namespace RPG_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Arus arus = new Arus("Arus", 42, "Knight", 469, 72);
            Wedge wedge = new Wedge("Wedge", 42, "Ninja", 292, 89);
            Jenica jenica = new Jenica("Jenica", 42, "White Wizard", 325, 474);
            Topapa topapa = new Topapa("Topapa", 42, "Black Wizard", 106, 611);


            Console.WriteLine(arus.Attack(10));
            Console.WriteLine(wedge.Attack(10));
            Console.WriteLine(jenica.Attack(10));
            Console.WriteLine(topapa.Attack(10));
        }
    }
}
