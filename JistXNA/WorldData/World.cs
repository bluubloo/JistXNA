using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JistXNA.WorldData
{
    class World
    {
        //The chunks currently in memory
        private List<Chunk> loaded;

        public World()
        {
            loaded = new List<Chunk>();
        }

        public void Load(Chunk toLoad)
        {
            loaded.Add(toLoad);
        }

        public Chunk[] GetChunksWithin(double left, double top, double right, double bottom)
        {
            //Divide the values so they relate to chunks
            int chunkLeft = (int)Math.Floor(left / Chunk.EDGE_SIZE);
            int chunkTop = (int)Math.Floor(top / Chunk.EDGE_SIZE);
            int chunkRight = (int)Math.Ceiling(right / Chunk.EDGE_SIZE);
            int chunkBottom = (int)Math.Ceiling(bottom / Chunk.EDGE_SIZE);

            List<Chunk> chunksWithin = new List<Chunk>();

            foreach(Chunk c in loaded)
            {
                //Check if chunks are visible in given window
                if(c.X >= chunkLeft && c.X <= chunkRight && c.Y >= chunkTop && c.Y <= chunkBottom)
                {
                    chunksWithin.Add(c);
                }
            }
            return chunksWithin.ToArray();
        }
    }
}
