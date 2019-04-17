using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHelpers
{
    public class StringHelper
    {
        public string ToUpper(string toConvert)
        {
            return toConvert.ToUpper();
        }
        public string ToLower(string toConvert)
        {
            return toConvert.ToLower();
        }
        public string CutToLength(string toCut, int length)
        {
            return toCut.Substring(0, length);
        }
        public bool IsNullOrWhite(string toCheck)
        {
            return String.IsNullOrWhiteSpace(toCheck);
        }
        public string ReplaceSth(string toConvert, string toRemove, string toEnter)
        {
            return toConvert.Replace(toRemove, toEnter);
        }
    }
}
