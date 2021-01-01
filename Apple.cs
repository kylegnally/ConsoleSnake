using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Apple : Drawable<string>
    {
        private string _appleString = "o ";
        private CoordinatePair<int, int> _appleCoordinates;

        public string AnApple { get; }

        public CoordinatePair<int, int> AppleCoordinatePair { get; set; }

        public Apple(CoordinatePair<int, int> coords)
        {
            AnApple = _appleString;
            AppleCoordinatePair = coords;
        }
    }
}
