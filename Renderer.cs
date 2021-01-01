using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    abstract class Renderer : SnakeGame
    {
        private FieldRenderer _fieldrenderer;
        //private Drawable<string> _drawableObjects;          
        //private CoordinatePair<int, int> _coordinatePair;

        //public Drawable<string> DrawableObject

        public abstract FieldRenderer FieldRenderer { get; set; }
        public abstract Drawable<string> DrawableObject { get; set; }
        public CoordinatePair<int, int> CoordinatePair { get; set; }

        public abstract void InjectWalls(Drawable<Wall> walls);
        public abstract void InjectPlayer(Drawable<Player> player);
        //public abstract void InjectApples(Drawable<Apple>[] apples);
        //public abstract void InjectEnemies(Drawable<Enemy>[] enemies);
        public abstract void RenderField(PlayField playfield);
    }
}
