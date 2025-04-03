namespace ConsoleApp15
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Point point = new Point();
            Console.WriteLine(point);
            
            point.MoveBy(2, 4, 6);
            Console.WriteLine(point);

            
            User user = new User("Илья", "Кузнецов", "Попович", 52);
            Console.WriteLine(user);

            
            Pc pc = new Pc("Compucter", 4096, 2048, 1024);
            Console.WriteLine(pc.Info());

            
            NoteBook notebook = new NoteBook("Notebook", 4096, 2048, 1024, 2);
            Console.WriteLine(notebook.Info());

            
            Phone phone = new Phone("Phone", 4096, 2048, 1024, "IOS", 5);
            Console.WriteLine(phone.Info());

            
            Square square = new Square(0, 2, 3);
            Console.WriteLine(square.Perimeter());
            Console.WriteLine(square.Area());

            
            Triangle triangle = new Triangle(5, 5, 6);
            Console.WriteLine(triangle.Perimetr());
            Console.WriteLine(triangle.Area());

            
            Mail mail = new Mail(628400, "Питре", "Пушкина", 666, 13, 32, "Hello");
            Console.WriteLine(mail);

            
            Circle circle = new Circle(0, 12);
            Console.WriteLine(circle);

            
            Block block = new Block(0, 2, 4);
            Console.WriteLine(block);
        }
    } 
}
