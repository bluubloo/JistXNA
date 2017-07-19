using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JistXNA
{
    class MessageParameter
    {
        public Object Value { get; set; }
        public int ID { get; set; }

        public MessageParameter(int id, Object value)
        {
            this.ID = id;
            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
