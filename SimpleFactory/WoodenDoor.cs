namespace SimpleFactory
{
    public class WoodenDoor : IDoor
    {
        private float Width;
        private float Height;

        public WoodenDoor(float width, float height)
        {
            Width = width;
            Height = height;
        }

        public float GetWidth()
        {
            return this.Width;
        }

        public float GetHeight()
        {
            return this.Height;
        }
    }
}
