namespace OOP_Labb2
{
    internal class Bear : Animal
    {
        public bool CanClimbTrees { get; set; } = true;
        
        public virtual void Scare()
        {
            Console.WriteLine("Björnen blir nu aggressiv.");
        }
        public Bear(string species, int legs, int eyes, bool canFly, bool isExtinct, string animalSound, bool canClimbTrees) : base(species, legs, eyes, canFly, isExtinct, animalSound)
        {
            CanClimbTrees = canClimbTrees;
        }
    }
}
