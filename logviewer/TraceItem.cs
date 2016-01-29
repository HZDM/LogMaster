using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logviewer
{
    class TraceItem
    {
        public int Idx { get; set; }

        public DateTime Time { get; set; }

        public uint UserId { get; set; }

        public byte[] payLoad { get; set; }

    }
}
