using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JistXNA.WorldData;
using Microsoft.Xna.Framework.Graphics;

namespace JistXNA.Drawing
{
    class WorldRenderer
    {
        Dictionary<Tile.Type, Texture2D> tiles;

        public WorldRenderer()
        {
            tiles = new Dictionary<Tile.Type, Texture2D>();
        }

        public void LoadTileTexture(Tile.Type ID, Texture2D texture)
        {
            tiles.Add(ID, texture);
            Console.WriteLine("Loaded: " + texture.Name + " " + ID);
        }
    }
}
