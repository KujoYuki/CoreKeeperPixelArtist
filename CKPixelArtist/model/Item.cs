using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKPixelArtist.model
{
    public class Item
    {
        public int Id { get; set; }
        public int Variation { get; set; }
        public Pixel Color => new Pixel(RGB);

    }
}
