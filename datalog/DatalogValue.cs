using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalog
{
    /// <summary>
    /// Basic struct of datalog (String) and (Float) file/database.
    /// Datalog values can be float or string
    /// </summary>
    public class DatalogValue<T>
    {

        public DateTime Timestamp { get; set; }
        public Int32 TagIndex { get; set; }
        public T Value { get; set; }
        public SByte Status { get; set; }
        public char Marker { get; set; }
        public Int32 Internal { get; set; }
        public string Tagname { get; set; }

        const int START_INDEX = 289;
        const int BUFFER_LEN = 39;
    }
}
