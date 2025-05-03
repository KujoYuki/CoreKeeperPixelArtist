using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKPixelArtist.model
{
    public static class ColorHelper
    {
        public static string ToHex(Color color)
        {
            return $"{color.R:X2}{color.G:X2}{color.B:X2}";
        }
    }
}
