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

        Boxer boxer1 = new();

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
            foreach (char line in message.ToCharArray())
            {
                Console.CursorVisible = false;
                Console.Write(line);
                Thread.Sleep(10);
                Console.CursorVisible = true;
            }
        }

        public void HealhTracker(int b1, string b1Name ,int b2,string b2name, int match)
        {
            int originalCursorTop = Console.CursorTop;
            int originalCursorLeft = Console.CursorLeft;

            Console.CursorVisible = false;
            Console.SetCursorPosition(originalCursorTop + 4, 2);
            Console.Write($"Round: {match} {boxer1.Name} HP:[{boxer1.CurrentHealth:000}] {b2name} HP:[{b2:000}]".PadLeft(50, '-').PadRight(50, '-'));
            Console.SetCursorPosition(originalCursorLeft, originalCursorTop);
            Console.CursorVisible = true;
          
            return;
        }
        //public string CurrentMatchWriter()
    }




}
