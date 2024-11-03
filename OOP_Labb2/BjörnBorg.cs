using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb2
{
    internal class BjörnBorg : Bear
    {
        public int SinglesTitles { get; set; } = 97;
        public override void Scare()
        {
            Console.WriteLine("Björn kastar sitt tennisracket på dig.");
        }
        public BjörnBorg(string species, int legs, int eyes, bool canFly, bool isExtinct, string animalSound, bool canClimbTrees) : base(species, legs, eyes, canFly, isExtinct, animalSound, canClimbTrees)
        {
        }
    }
}
