using System;

namespace UpcastingAndDowncasting
{
    public class Text : Shape
    {
        public int FontSize { get; set; }
        public string FontAwesome { get; set; }

        public Text()
        {
        }
        public Text(int width, int height, int size)
            : base (width, width)
        {
            this.FontSize = size;
        }
    }
}