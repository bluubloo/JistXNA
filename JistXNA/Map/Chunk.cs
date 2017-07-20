using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JistXNA.Map
{
    class Chunk
    {
        //Holds what type a tile is
        private uint[,] tileType;

        public Chunk()
        {
            tileType = new uint[64,64];
        }
    }
}
