using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingAndDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Text();
            Text text1 = (Text) shape;
            GetProperty(text1);
            Console.WriteLine("Width of text object is {0}", text1.Width);
        }

        static void GetProperty(Text shape)
        {
            if (shape is Text objText)
            {
                objText.Width = 100;
            }
        }
    }
}
