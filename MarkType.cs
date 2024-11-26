using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiktaktoe
{
    /// <summary>
    /// the type of valeu a cell in a the game is currently at
    /// </summary>

    public enum MarkType
    {
        /// <summary>
        /// the cell hasn't been clicked yet
        /// </summary>
        Free,
        /// <summary>
        /// The cell is a O
        /// </summary>
        Nought,
        /// <summary>
        /// The cell is an X
        /// </summary>
        Cross
    }
}
