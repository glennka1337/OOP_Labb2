namespace OOP_Labb2
{
    internal class Björn : Animal
    {
        public bool CanClimbTrees { get; set; } = true;
        public void MakeSound()
        {
            Console.WriteLine("s");
        }
    }
}
