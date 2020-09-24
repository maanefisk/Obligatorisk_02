using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_02
{
    class Bishop : Piece
    {
        public Bishop(string symbol="bonde") : base(symbol)
        {

        }

        public override bool Move(string fromPosition, string toPosition)
        {
            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];
            return Math.Abs(diffRow) == Math.Abs(diffCol);
        }
    }
}
