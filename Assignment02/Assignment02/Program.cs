using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter length of rectangle : ");
            int length = 0;
            while (!int.TryParse(Console.ReadLine(), out length) || (length < 0) )
            {
                Console.Write("Please Enter a valid length of rectangle : "); 
            }
            
            Console.Write("Enter width of rectangle : ");
            int width = 0;
            while (!int.TryParse(Console.ReadLine(), out width) || (width < 0))
            {
                Console.Write("Please Enter a valid width of rectangle : ");
            }
            Rectangle rectangle = new Rectangle(length, width);
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("1.Get Rectangle Length");
                Console.WriteLine("2.Change Rectangle Length");
                Console.WriteLine("3.Get Rectangle Width");
                Console.WriteLine("4.Change Rectangle Width");
                Console.WriteLine("5.Get Rectangle Perimeter");
                Console.WriteLine("6.Get Rectangle Area");
                Console.WriteLine("7.Exit");
                String input = Console.ReadLine();
                if (input.Equals("1"))
                {
                    Console.WriteLine("Rectangle Length = " + rectangle.GetCurrentLength() + "\n");
                } 
                else if (input.Equals("2"))
                {
                    Console.Write("Enter new length of rectangle : ");
                    while (!int.TryParse(Console.ReadLine(), out length) || (length < 0))
                    {
                        Console.Write("Please Enter a valid length of rectangle : ");
                    }
                    rectangle.SetNewLength(length);
                    Console.WriteLine();
                }
                else if (input.Equals("3"))
                {
                    Console.WriteLine("Rectangle Width = " + rectangle.GetCurrentWidth() + "\n");
                }
                else if (input.Equals("4"))
                {
                    Console.Write("Enter new width of rectangle : ");
              
                    while (!int.TryParse(Console.ReadLine(), out width) || (width < 0))
                    {
                        Console.Write("Please Enter a valid width of rectangle : ");
                    }
                    rectangle.SetNewWidth(width);
                    Console.WriteLine();
                }
                else if (input.Equals("5"))
                {
                    Console.WriteLine("Rectangle Perimeter = " + rectangle.GetPerimeter() + "\n");
                }
                else if (input.Equals("6"))
                {
                    Console.WriteLine("Rectangle Area = " + rectangle.GetArea() + "\n");
                }
                else if (input.Equals("7"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input!\n");
                }
            }

            
            

        }
    }
}
