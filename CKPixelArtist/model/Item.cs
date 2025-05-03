using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace CKPixelArtist.model
{
    public record Item
    {
        public Item(int id, int variation)
        {
            Id = id;
            Variation = variation;
            Name = Define.ItemName.ContainsKey(id) ? Define.ItemName[id] : "Unknown Item";
        }

        public static Item Empty => new Item(0, 0);

        public int Id { get; set; }

        public int Variation { get; set; }

        public string Name { get; set; }

        public Pixel Color => Define.PaintableColor.Concat(Define.CraftableColor).Concat(Define.CollectableColor)
            .ToDictionary()[(Id, (Variation)Variation)];

        public double Delta;
    }
}
