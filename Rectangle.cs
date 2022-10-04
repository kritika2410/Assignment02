namespace shapes
{
    public class Rectangle
    {
        private int length;
        private int width;

        Rectangle()
        {
            length = 1;
            width = 1;
        }

        Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        // Displays the current length of rectangle
        public int GetCurrentLength()
        {
            return length;
        }
        // Sets new length of rectangle
        public int SetNewLength(int length)
        {
            this.length = length;
            return length;
        }
        //Displays current width of rectangle
        public int GetCurrentWidth()
        {
            return width;
        }
        // Sets new width
        public int SetNewWidth(int width)
        {
            this.width = width;
            return width;
        }
        // Returns perimeter 
        public int GetPerimeter()
        {
            int ans = 2 * (length + width);
            return ans;
        }
        // Returns Area of rectangle
        public int GetArea()
        {
            int ans = width * length;
            return ans;
        }

        public static void Main(String[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine($"The current length of rectangle is "+rectangle.GetCurrentLength());
            Console.WriteLine($"The current width of rectangle is "+rectangle.GetCurrentWidth());
            Console.WriteLine("".PadRight(70, '-'));
            // To accept length and width from user
            Console.WriteLine("\nPlease enter the length-");
            int newLength = int.Parse(Console.ReadLine());
            rectangle.SetNewLength(newLength);

            Console.WriteLine("\nPlease enter the width- ");
            int newWidth = int.Parse(Console.ReadLine());
            rectangle.SetNewWidth(newWidth);
            Console.WriteLine("".PadRight(70, '-'));
            Console.WriteLine($"\n Perimeter of rectangle = " + rectangle.GetPerimeter());
            Console.WriteLine($"\n Area of rectangle = " + rectangle.GetArea());



        }
    }
}