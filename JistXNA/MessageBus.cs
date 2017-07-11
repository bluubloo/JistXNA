using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JistXNA
{
    class MessageBus
    {
        //Publishes a message
        public static void Publish(Message m)
        {
            Log(m);
        }

        //Logs a message to the console
        private static void Log(Message m)
        {
            StringBuilder messageAsString = new StringBuilder();
            messageAsString.Append(m.Type + "[");
            foreach(Object p in m.Parameters)
            {
                messageAsString.Append(p.ToString() + ", ");
            }
            messageAsString.Remove(messageAsString.Length - 2, 2);
            messageAsString.Append("]");
            Console.WriteLine(messageAsString);
        }
    }
}
