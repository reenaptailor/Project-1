using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 20);
            Console.WriteLine(
             "Width ={0}, Length ={1}, Area = {2}",
              rect.Width, rect.Length, rect.GetArea());
              Console.ReadLine();
        }
    }   
    
}
