using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace JistXNA
{
    //Keeps track of input and sends messages when input has changed
    class Input
    {
        private Point mousePosition;

        public void Update()
        {
            if(mousePosition == null || !mousePosition.Equals(Mouse.GetState().Position))
            {
                mousePosition = Mouse.GetState().Position;
                MessageBus.Publish(new Message("Mouse Moved", mousePosition.X, mousePosition.Y));
            }
            
        }
    }
}
