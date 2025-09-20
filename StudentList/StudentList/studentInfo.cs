using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    internal class studentInfo
    {
        public int stID { get; set; }
        public string stLN { get; set; }
        public string stFN { get; set; }

        public studentInfo (int id, string ln, string fn)
        {
            this.stID = id;
            this.stLN = ln;
            this.stFN = fn;
        }
    }
}
