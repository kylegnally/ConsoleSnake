using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{

    /// <summary>
    /// Class to hold generic drawable objects. Stores as an array, even of one member.
    /// Declare as desired type when instantiated.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Drawable<T>
    {
        public T[] DrawMe { get; set; }     // will this actually work if there's only one?       
    }
}
