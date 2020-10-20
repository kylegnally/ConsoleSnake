using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Direction : Snake
    {
        public enum Dir
        {
            Up,
            Right,
            Down,
            Left
        }

        public Dir NewDirection { get; set; }
        public Dir OldDirection { get; set; }

        public Direction()
        {
            NewDirection = Dir.Down;
            OldDirection = NewDirection;
        }
    }
}
