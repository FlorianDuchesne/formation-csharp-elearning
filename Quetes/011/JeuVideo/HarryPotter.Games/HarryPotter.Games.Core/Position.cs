using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.Games.Core
{
    /// <summary>
    /// 2D position (x, y)
    /// </summary>
    public class Position
    {
        public Position() : this(1, 1) {}

        public Position(string type, int coordonnee)
        {
            if (type == "X")
            {
                this.X = coordonnee;
            } else
            {
                this.Y = coordonnee;
            }
        }

        public Position(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        #endregion
    }
}
