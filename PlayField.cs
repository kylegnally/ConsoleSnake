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

        public int PlayerStartX { get; set; }
        public int PlayerStartY { get; set; }


        //public PlayField(List<Coord> tailCoords)
        //{

        //}

        public PlayField(string[] input)
        {
            Width = Int32.Parse(input[1]);
            Height = Int32.Parse(input[2]);
            PlayerStartX = Int32.Parse(input[3]);
            PlayerStartY = Int32.Parse(input[4]);
        }

        protected PlayField() { }

        //public void SetSnakeField(List<Coord> tailCoords)
        //{            
        //    Height = Console.WindowHeight;
        //    Width = Console.WindowWidth;
        //}
    }
}
