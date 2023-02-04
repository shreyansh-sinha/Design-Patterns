using SimpleFactory;

public class DoorFactory
{
    public static IDoor makeWoodenDoor(float width, float height)
    {
        return new WoodenDoor(width, height);
    }
}