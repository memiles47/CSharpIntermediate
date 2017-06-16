using System;

namespace Casting
{
    public class Shape
    {
        public int Width { get; set; }
        public int Heigth { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }

        public void Draw()
        {
            Console.WriteLine("Drawing shape on monitor");
        }
    }
}