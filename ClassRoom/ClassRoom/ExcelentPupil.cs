using Lab5;

namespace Lab5
{
    public class ExcelentPupil : Pupil
    {
        public override void Level()
        {
            Console.WriteLine("Excelent pupil: ");
        }
        public override void Read()
        {
            Console.WriteLine("1. I like reading books, so I have read 3 books during 1 month");
        }

        public override void Relax()
        {
            Console.WriteLine("2. Who has goals, has no time for relaxing");
        }

        public override void Study()
        {
            Console.WriteLine("3. I always study, every day, every hour.");
        }

        public override void Write()
        {
            Console.WriteLine("4. If it is needed, It will be no problem for me to write my own book. However... I have already started a new one");
        }
    }
}
