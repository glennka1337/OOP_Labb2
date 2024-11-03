namespace OOP_Labb2
{
    internal class BearCub : Bear
    {
        public int Age { get; set; } = 0;
        public override void Scare()
        {
            Console.WriteLine("Björnungen kallar på sin mamma som nu är väldigt aggressiv.");
        }
        public BearCub(string species, int legs, int eyes, bool canFly, bool isExtinct, string animalSound, bool canClimbTrees, int age) : base(species, legs, eyes, canFly, isExtinct, animalSound, canClimbTrees)
        {
            Age = age;
        }
    }
}
