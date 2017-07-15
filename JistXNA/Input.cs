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
        //Mouse position before update
        private Point mousePosition;

        //Keyboard state before update
        private KeyboardState keyboardState;

        public void Update()
        {
            //Check to see if mouse position has moved
            if(mousePosition == null || !mousePosition.Equals(Mouse.GetState().Position))
            {
                mousePosition = Mouse.GetState().Position;
                MessageBus.Publish(new Message("Mouse Moved", mousePosition.X, mousePosition.Y));
            }
            
            //Check to see if keyboard state has changed
            if(keyboardState == null || !keyboardState.Equals(Keyboard.GetState()))
            {
                KeyboardState newKeyboardState = Keyboard.GetState();
                //Publish a message for each key that was pressed since the last update
                Keys[] down = newKeyboardState.GetPressedKeys().Except(keyboardState.GetPressedKeys()).ToArray();
                for(int i = 0; i < down.Length; i++)
                {
                    MessageBus.Publish(new Message("Key Down", down[i]));
                }

                //Pulish a message for each key that was lifted up since the last update
                Keys[] up = keyboardState.GetPressedKeys().Except(newKeyboardState.GetPressedKeys()).ToArray();
                for (int i = 0; i < up.Length; i++)
                {
                    MessageBus.Publish(new Message("Key Up", up[i]));
                }
                keyboardState = newKeyboardState;
            }
        }
    }
}
