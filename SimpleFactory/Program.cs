namespace SimpleFactory
{
    public class Program
    {
       public static void Main(String[] args)
       {
            var woodenDoor = DoorFactory.makeWoodenDoor(10, 20);
            Console.WriteLine(woodenDoor.GetWidth());
            Console.WriteLine(woodenDoor.GetHeight());
       }
    }
}
