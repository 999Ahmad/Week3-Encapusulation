using Week3_Encapsulation;

class Program
{
    static void Main(string[] args)
    {
        // create a new instance (object) of the book class
        // Note how the object name differs from the class name
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");

        book.DisplayInfo();

        Book book1 = new Book("Ultimate C#", "Microsoft", "2233445");
        book1.DisplayInfo();
    }
}