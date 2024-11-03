namespace OOP_Labb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var björn = new Bear("Bear", 4, 2, false, false, "Roaarrrr", true);
            var älg = new Moose("Moose", 4, 2, false, false, "Moooo", false);
            var borg = new BjörnBorg("Human", 2, 2, false, false, "Tjena! Jag spelar tennis.", false);
            var björnunge = new BearCub("Bear", 4, 2, false, false, "Raur", false, 1);

            björn.Scare();
            björn.MakeSound();
            björn.Eat();
            Console.WriteLine();
            älg.EatApples(8);
            älg.MakeSound();
            Console.WriteLine();
            borg.Scare();
            borg.MakeSound();
            borg.OutputSpecies();
            Console.WriteLine();
            björnunge.Scare();
            björnunge.MakeSound();
            
        }
    }
}
