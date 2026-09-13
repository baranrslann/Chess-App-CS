using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ChessUI
{
   public static class ChessCursors
    {
        public static readonly Cursor WCursor = LoadCursor("Assets/CursorW.cur");
        public static readonly Cursor BCursor = LoadCursor("Assets/CursorB.cur");

        private static Cursor LoadCursor(string filePath)
        {
            Stream stream = Application.GetResourceStream(new Uri(filePath, UriKind.Relative)).Stream;
            return new Cursor(stream, true);
        }
    }
}
