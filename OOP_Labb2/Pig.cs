namespace OOP_Labb2
{
    internal class Pig : Animal
    {
        public bool IsDirty { get; set; } = false;
        public void RollInMud()
        {
            Console.WriteLine("Grisen rullade i leran, den är nu smutsig.");
            IsDirty = true;
        }
        public Pig(string species, int legs, int eyes, bool canFly, bool isExtinct, string animalSound, bool isDirty) : base(species, legs, eyes, canFly, isExtinct, animalSound)
        {
            IsDirty = isDirty;
        }
    }
}
