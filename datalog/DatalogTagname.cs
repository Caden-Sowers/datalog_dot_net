using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalog
{

    
    /// <summary>
    /// Basic structure of datalog (Tagname) file/database.
    /// </summary>
    public class DatalogTagname
    {
        public string Tagname { get; set; }
        public Int32 TagIndex { get; set; }
        public char TagType { get; set; }
        public sbyte TagDataType { get; set; }

        const int START_INDEX = 161;
        const int BUFFER_LEN = 264;
    }
}
