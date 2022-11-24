using System.Text;

namespace Lab5;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Введіть ключ: ");
        var key = Console.ReadLine();
        var path = @"C:Denisko\OOP\word.doc";

        var documentWorker = new DocumentWorker(path);

        switch (key)
        {
            case "pro":
                documentWorker = new ProDocumentWorker(path);
                break;
            case "exp":
                documentWorker = new ExpertDocumentWorker(path);
                break;
        }

        documentWorker.OpenDocument();
        documentWorker.SaveDocument("Денис Сподін, ФІТ 2 курс 3 група");
        documentWorker.EditDocument((oldText) => oldText + "\nНТЕУ");
        documentWorker.ChangeExtension("docx");
    }
}
