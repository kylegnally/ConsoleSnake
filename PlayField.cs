using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class PlayField : SnakeGame
    {
        private readonly Random _random = new Random();
        private FieldRenderer _renderer = new FieldRenderer();

        public int Height { get; set; }
        public int Width { get; set; }

        public PlayField(List<Coord> tailCoords)
        {
           
        }

        public PlayField(int height, int width)
        {
            Height = height;
            Width = width;
        }

        protected PlayField() { }

        public void SetSnakeField(List<Coord> tailCoords)
        {            
            Height = Console.WindowHeight;
            Width = Console.WindowWidth;
        }
    }
}
