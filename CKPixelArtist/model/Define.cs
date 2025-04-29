using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKPixelArtist.model
{
    public static class Define
    {
        static readonly IReadOnlyDictionary<(int ObjectId, PaintColor Variation), Pixel> ColorModel = new Dictionary<(int ObjectId, PaintColor Variation), Pixel>
        {
            { (351,PaintColor.Red), new("FF0000") },
            { (351,PaintColor.Blue), new("0000FF") },
        };
    }
}
