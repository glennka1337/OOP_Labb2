namespace OOP_Labb2
{
    internal class Animal
    {
        public string Species { get; set; } = "TBD";
        public int Legs { get; set; } = 4;
        public int Eyes { get; set; } = 2;
        public bool CanFly { get; set; } = false;
        public bool IsExtinct { get; set; } = false;

        public void OutputSpecies()
        {
            Console.WriteLine($"Species: {Species}");
        }
        public void PlaceHolder2()
        {

        }
    }
}
