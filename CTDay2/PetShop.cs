using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDay2
{
    internal static class PetShop
    {
        public static string Name { get; } = "PetWorld";
        public static List<Cat> cats { get; } = new List<Cat>();

        public static void AddCat(Cat cat)
        {
            cats.Add(cat);
        }
    }
}
