using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.CS.Task1
{
    public static class ByteEnumerable
    {
        public static string ToByteArray(this byte[] bytes)
        {
            var sb = new StringBuilder();
            bytes.ToList().ForEach(b => sb.Append(b));
            return sb.ToString();
        }
    }
}
