using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public class SnakeGame
    {
        public List<Coord> TailCoordsList;

        private bool WasAppleEaten { get; set; }
        private bool GameIsPlaying { get; set; }
        private bool GameIsPaused { get; set; }


        private Apple AnApple { get; set; }
        private Direction Direction { get; set; }
        private Input Input { get; set; }
        private Snake Player { get; set; }
        private PlayField Playfield { get; set; }
        private Renderer Renderer { get; set; }
        private Stopwatch Tick { get; set; }

        public SnakeGame()
        {

        }

        private void Initialize()
        {

        }

        private void OnKeyDown()
        {

        }

        private void UpdatePlayField()
        {

        }
    }
}
