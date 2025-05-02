using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKPixelArtist.model
{
    public class Item
    {
        public Item(int id, int variation)
        {
            Id = id;
            Variation = variation;
            Name = Define.ItemName.ContainsKey(id) ? Define.ItemName[id] : "Unknown Item";
        }

        public int Id { get; set; }

        public int Variation { get; set; }

        public string Name { get; set; }

        public Pixel Color => Define.CollectableColor[(Id, (Variation)Variation)];

    }
}
