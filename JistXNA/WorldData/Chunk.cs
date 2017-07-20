using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JistXNA.WorldData
{
    class Chunk
    {
        public const int EDGE_SIZE = 64;

        //Location of this chunk in the world
        public int X, Y;

        //Holds what type a tile is
        private uint[,] tileType;

        private Chunk(int x, int y)
        {
            tileType = new uint[EDGE_SIZE, EDGE_SIZE];
        }

        public static Chunk GenerateGrass(int x, int y)
        {
            Chunk grassChunk = new Chunk(x, y);
            for(int i = 0; i < EDGE_SIZE; i++)
            {
                for(int j = 0; j < EDGE_SIZE; j++)
                {
                    grassChunk.tileType[i, j] = (uint)Tile.Type.Grass;
                }
            }
            return grassChunk;
        }
    }
}
