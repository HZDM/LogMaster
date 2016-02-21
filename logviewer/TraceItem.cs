using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logviewer
{
    class TraceItem
    {
        public uint Idx { get; set; }

        public DateTime Time { get; set; }


        public uint UserId { get; set; }

        public byte[] payLoad { get; set; }

        public override string ToString()
        {
            return String.Format("{0,8:D}  {1:dd/MM/yyyy HH:mm:ss}  {2,8:X}  ", this.Idx, this.Time, this.UserId);
        }
    }
}
