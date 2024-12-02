using Boxinggame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_game_H1
{
    public class ConsoleGUI
    {
        int _originalCursorTop;
        int _originalCursorBottom;
        int _newCursorTop;
        int _newCursorBottom;

        public int OriginalCursorTop
        {
            get { return _originalCursorTop; }
            set { _originalCursorTop = value; }
        }
        public int OriginalCursorBottom
        {
            get { return _originalCursorBottom; }
            set { _originalCursorBottom = value; }
        }
        public int NewCursorTop
        {
            get { return _newCursorTop; }
            set { _newCursorTop = value; }
        }
        public int NewCursorBottom
        {
            get { return _newCursorBottom; }
            set { _newCursorBottom = value; }
        }

        public void ScrollingMessage(string message)
        {
        Console.CursorVisible = false;

            foreach (char line in message.ToCharArray())
            {
                Console.Write(line);
                Thread.Sleep(10);
            }

        Console.CursorVisible = true;
        }

        public static void HealhTracker(Boxer b1, Boxer b2, MatchSettings match)
        {
            int originalCursorTop = Console.CursorTop;
            int originalCursorLeft = Console.CursorLeft;

            Console.CursorVisible = false;
            Console.SetCursorPosition(originalCursorTop + 4, 2);
            Console.Write($"Round: {match.currentMatch} {b1.Name} HP:[{b1.CurrentHealth:000}] {b2.Name} HP:[{b2:000}]".PadLeft(50, '-').PadRight(50, '-'));
            Console.SetCursorPosition(originalCursorLeft, originalCursorTop);
            Console.CursorVisible = true;

            return;
        }
        //public string CurrentMatchWriter()
    }




}
