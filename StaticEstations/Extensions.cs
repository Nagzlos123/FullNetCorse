using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtensions
{
    public static class Extensions
    {
        public static string AddExtraLineWithText(this string text, string text2)
        {
            text += $"/n--------{text2}--------/n";
            return text;
        }
    }
}
