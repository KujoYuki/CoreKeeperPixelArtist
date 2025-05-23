﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKPixelArtist.model
{
    public enum Variation
    {
        // 色塗り系アイテム
        Unpainted = 0,
        Yellow = 1,
        Green = 2,
        Red = 3,
        Purple = 4,
        Blue = 5,
        Brown = 6,
        White = 7,
        Black = 8,
        Orange = 9,
        Cyan = 10,
        Pink = 11,
        Gray = 12,
        Peach = 13,
        Teal = 14,

        // バケツの水源
        NormalWater,
        Lava,
        AcidWater,
        MoldWater,
        SeaWater,
        ShiningWater,
        GrimyWater,
    }
}
