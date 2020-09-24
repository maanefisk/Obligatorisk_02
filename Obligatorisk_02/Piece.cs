using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_02
{
    abstract class Piece
    {
        public string Symbol { get; }

        protected Piece(string symbol)
        {
            Symbol = symbol;
        }

        public abstract bool Move(string fromPosition, string toPosition);
    }
}
