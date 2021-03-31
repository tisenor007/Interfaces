using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interfaces");
            Console.WriteLine();

            Goblin goblin = new Goblin();
            Bat bat = new Bat();

            goblin.Move();//inheritance
            bat.Move();//inheritance

            bat.Fly();

            //Interfaces allows certain classes to have different functions / interfaces but ensures you give them meaning or the game will crash

            Console.ReadKey(true);
        }
    }
}
