namespace OOP_Labb2
{
    internal class Animal
    {
        public string Species { get; set; } = "";
        public int Legs { get; set; } = 4;
        public int Eyes { get; set; } = 2;
        public bool CanFly { get; set; } = false;
        public bool IsExtinct { get; set; } = false;
        public string AnimalSound { get; set; } = "";

        public void OutputSpecies()
        {
            Console.WriteLine($"Species: {Species}");
        }
        public virtual void MakeSound()
        {
            Console.WriteLine(AnimalSound);
        }

        public void Eat()
        {
            Console.WriteLine($"The {Species} eats.");
        }

        public Animal(string species, int legs, int eyes, bool canFly, bool isExtinct, string animalSound)
        {
            Species = species;
            Legs = legs;
            Eyes = eyes;
            CanFly = canFly;
            IsExtinct = isExtinct;
            AnimalSound = animalSound;
        }
    }
}
