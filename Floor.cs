using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Floor : Drawable<string>
    {
        private Player _thePlayer;
        private string _unvisitedFloorSpace = ". ";
        private string _visitedFloorSpace = "  ";
        private CoordinatePair<int, int> _floorSpaceCoordinatePair;
        private bool _alreadyVisited = false;

        public string FloorTile { get; set; }
        public CoordinatePair<int, int> CoordinatePair { get; set; }
        public bool AlreadyVisited { get; set; }

        public Floor(CoordinatePair<int, int> coords)
        {
            if (this.CoordinatePair = _thePlayer.CurrentLocation) AlreadyVisited = true; 
            if (this.AlreadyVisited) FloorTile = _visitedFloorSpace;
            if (!this.AlreadyVisited) FloorTile = _unvisitedFloorSpace;
        }
    }
}
