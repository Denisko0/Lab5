
namespace Lab5
{
    public class GoodPupil : Pupil
    {
        public override void Level()
        {
            Console.WriteLine("Good pupil: ");
        }
        public override void Read()
        {
            Console.WriteLine("1. I like reading comixes:");
        }

        public override void Relax()
        {
            Console.WriteLine("2. I like relaxing so much");
        }

        public override void Study()
        {
            Console.WriteLine("3. I like studying like as relaxing");
        }

        public override void Write()
        {
            Console.WriteLine("4. I can write a text, but I not big");
        }
    }
}