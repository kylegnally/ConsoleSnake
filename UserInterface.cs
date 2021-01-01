using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class UserInterface
    {
        //private string _returnString;

        private string[] _userFeedback =
        {
            "\n\nEnter the width of the square grid as a whole number.\nI would suggest a size not much larger than 24.",
            "\n\nEnter the height of the square grid as a whole number.\nI would suggest a size not much larger than 24.",
            "Enter the X coordinate of the initial starting location: ",
            "Enter the Y coordinate of the initial starting location: ",
            "This question must have an answer in the form of an integer (a whole number) for this universe to exist.",
            "Grid created.",
            "The player's position is: ",
            "You've attempted to move into a wall. Walls are impassable. Because they're walls.",
            "Press an arrow key to move around the grid. Press the Escape key (ESC) to exit."
        };

        public string UserFeedback { get; set; }

        public UserInterface()
        {
            Console.WriteLine();
        }
        #region Comments
        //public string GetGridSize()
        //{
        //    _returnString = "";
        //    return _returnString = "\n\nEnter the size of one side of the square grid as a whole number.\n" +
        //                           "I would suggest a size not much larger than 24.";
        //}

        //public string GetXStartingPoint()
        //{
        //    _returnString = "";
        //    return _returnString = "Enter the X coordinate of the initial starting location: ";
        //}

        //    public string GetYStartingPoint()
        //    {
        //        _returnString = "";
        //        return _returnString = "Enter the Y coordinate of the initial starting location: ";
        //    }

        //    public string GridCreatedMessage()
        //    {
        //        _returnString = "";
        //        return _returnString = "Grid created.";
        //    }

        //    public string PlayerLocation()
        //    {
        //        _returnString = "";
        //        return _returnString = "The player's position is: ";
        //    }

        //    public string CannotMoveIntoWalls()
        //    {
        //        _returnString = "";
        //        return _returnString = "You've attempted to move into a wall. Walls are impassable. Because they're walls.";
        //    }

        //    public string PressArrowToMove()
        //    {
        //        _returnString = "";
        //        return _returnString = "Press an arrow key to move around the grid. Press the Escape key (ESC) to exit.";
        //    }

        //    public string SaySomethingDammit()
        //    {
        //        _returnString = "";
        //        return _returnString = "This question must have an answer in the form of an integer (a whole number) for this universe to exist.";
        //    }
        #endregion
    }
}
