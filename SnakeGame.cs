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

        //private bool WasAppleEaten { get; set; }
        //private bool GameIsPlaying { get; set; }
        //private bool GameIsPaused { get; set; }


        //private Apple AnApple { get; set; }
        //private Direction Direction { get; set; }
        //private Input Input { get; set; }
        private Snake Player { get; set; }
        private PlayField Playfield { get; set; }
        private Renderer Renderer { get; set; }
        //private Stopwatch Tick { get; set; }

        public SnakeGame()
        {
            Preflight();
        }

        private void Preflight()
        {
            UserInterface aMenu = new UserInterface();
            SetupGame(aMenu);
        }

        private void SetupGame(UserInterface aMenu)
        {
            string[] userInput = new string[(aMenu.UserFeedback.Length)];
            Console.Clear();

            for (int i = 0; i <= aMenu.UserFeedback.Length; i++)
            {
                userInput[i] = null;
                Console.WriteLine(aMenu.UserFeedback[i]);
                Console.WriteLine();
                userInput[i] = Console.ReadLine();
            }

            PlayField aPlayfield = new PlayField(userInput);

        }

        private void OnKeyDown()
        {

        }

        private void UpdatePlayField()
        {

        }
    }
}
