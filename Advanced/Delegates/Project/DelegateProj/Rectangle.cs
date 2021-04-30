namespace MulticastDelegate
{
    public delegate void RectDelegate(double x, double y);

    public class Rectangle
    {
        // public delegate void RectDelegate(double x, double y); // scope ?
        public void GetArea(double height, double weight)
        {
            System.Console.WriteLine("Area of Rectangle is " + (height * weight));
        }
        public void GetPerimeter(double height, double weight)
        {
            System.Console.WriteLine("Area of Rectangle is " + 2 * (height + weight));
        }
    }
}