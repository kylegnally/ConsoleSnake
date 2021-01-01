using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Enemy : Drawable<string>
    {
        private string _enemyString = "x ";
        private CoordinatePair<int, int> _coordinatePair;

        public string AnEnemy { get; }
        public CoordinatePair<int, int> EnemyCoordinatePair { get; set; }

        public Enemy(CoordinatePair<int, int> coords)
        {
            AnEnemy = _enemyString;
            EnemyCoordinatePair = coords;
        }
    }
}
