using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDay2
{
    internal class Snake : Animal
    {
        public virtual bool Poisonous { get; } = true;

        public override void Eat(int volume)
        {
            Console.WriteLine("The snake has eaten {volume}");
        }

        public void snakeprint()
        {
            base.print();
        }



    }
}
