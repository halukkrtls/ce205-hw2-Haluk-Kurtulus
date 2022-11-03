using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE205_HW3
{
    internal class Util
    {
        public static string GetNodeLetter(int index)
        {
            return Convert.ToChar(65 + index).ToString();
        }
    }
}
