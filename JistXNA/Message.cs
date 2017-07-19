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
        public MessageParameter[] Parameters { get; private set; }

        public Message(String Type, params MessageParameter[] Parameters)
        {
            this.Type = Type;
            this.Parameters = Parameters;
        }
    }
}
