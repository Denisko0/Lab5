

namespace Lab5
{
    public class BadPupil : Pupil
    {
        public override void Level()
        {
            Console.WriteLine("Bad pupil: ");
        }
        public override void Read()
        {
            Console.WriteLine("1. I like comixes, but not books");
        }

        public override void Relax()
        {
            Console.WriteLine("2. I like relaxing so much, the most in my life");
        }

        public override void Study()
        {
            Console.WriteLine("3. Studying is so bored");
        }

        public override void Write()
        {
            Console.WriteLine("4. I can write, but do not want =)");
        }
    }
}