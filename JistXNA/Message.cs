using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JistXNA
{
    class Message
    {
        public String Type { get; private set; }
        public Object[] Parameters { get; private set; }

        public Message(String Type, params Object[] Parameters)
        {
            this.Type = Type;
            this.Parameters = Parameters;
        }
    }
}
