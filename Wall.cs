using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Wall : Drawable<string>
    {
        private string _wallString = "% ";
        private CoordinatePair<int, int> _wallCoordinatePair;

        public string AWall { get; }
        public CoordinatePair<int, int> WallCoordinatePair { get; set; }

        public Wall(CoordinatePair<int, int> coords)
        {
            AWall = _wallString;
            WallCoordinatePair = coords;
        }
    }
}
