using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    abstract class Renderer : SnakeGame
    {
        // Generic string drawable. During the game loop the contents of
        // this should repeatedly change depending on what is to be
        // drawn. It could be the walls, it could be the floor, it 
        // could be a single mover. Whatev. This array can hold all of these.
        // Generic instance.
        
        private Drawable<string> _drawableObjects = new Drawable<string>();          
        private CoordinatePair<int, int> _drawableLocation = new CoordinatePair<int, int>();

        public 

        public Renderer()
        {

        }
    }
}
