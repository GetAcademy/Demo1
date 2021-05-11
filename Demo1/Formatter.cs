using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatters
{
    class Formatter
    {
        public static string Format(string value, int i)
        {
            return i + ": " + value;
        }
    }
}
