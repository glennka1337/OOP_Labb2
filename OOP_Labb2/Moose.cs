namespace OOP_Labb2
{
    internal class Moose : Animal
    {
        public bool IsDrunk { get; set; } = false;
        public void EatApples(int applesEaten)
        {
            if (applesEaten > 7)
            {
                Console.WriteLine("Älgen är nu berusad.");
                IsDrunk = true;
            }
            else
            {
                Console.WriteLine("Gott med äpplen!");
            }
        }
        public Moose(string species, int legs, int eyes, bool canFly, bool isExtinct, string animalSound, bool isDrunk) : base(species, legs, eyes, canFly, isExtinct, animalSound)
        {
            IsDrunk = isDrunk;
        }
    }
}
