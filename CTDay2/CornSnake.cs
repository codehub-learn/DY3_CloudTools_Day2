using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDay2
{
    internal class CornSnake : Snake
    {
        public static string GenusName { get; } = "Pantherophis";
        public override bool Poisonous { get; } = false;

        public void PrintName()
        {
            Console.WriteLine(Name);
        }
    }
}
