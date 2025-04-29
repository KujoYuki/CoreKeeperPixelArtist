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
        /// <summary>
        /// 色塗り系アイテムの色定義
        /// </summary>
        public static readonly Dictionary<(int ObjectId, PaintColor Variation), Pixel> PaintableColor = new Dictionary<(int ObjectId, PaintColor Variation), Pixel>
        {
            // ぬりぬり壁
            { (351,PaintColor.Red), new("FF0000") },
            { (351,PaintColor.Blue), new("0000FF") },

            // ぬりぬり床
        };

        /// <summary>
        /// クラフト系アイテムの色定義
        /// </summary>
        public static readonly IReadOnlyDictionary<(int ObjectId, PaintColor Variation), Pixel> CraftableColor = new Dictionary<(int ObjectId, PaintColor Variation), Pixel>
        {
            { (351,PaintColor.Red), new("FF0000") },
            { (351,PaintColor.Blue), new("0000FF") },
        };

        /// <summary>
        /// 採取系アイテムの色定義
        /// ブロックは壁と地面の色が異なるため別アイテムとして定義する
        /// </summary>
        public static readonly IReadOnlyDictionary<(int ObjectId, PaintColor Variation), Pixel> CollectableColor = new Dictionary<(int ObjectId, PaintColor Variation), Pixel>
        {
            { (300,PaintColor.Unpainted), new("614927") },
            { (351,PaintColor.Blue), new("0000FF") },
        };

        public static readonly IReadOnlyDictionary<(int ObjectId, PaintColor Variation), Pixel> NotAvailableColor = new Dictionary<(int ObjectId, PaintColor Variation), Pixel>
        {
            { (366,PaintColor.Unpainted), new("b969d1") },  // ポイズンベリーの壁
        };

        /// <summary>
        /// アイテムの表示名定義
        /// ブロックは壁と地面の色が異なるため別アイテムとして定義する
        /// </summary>
        public static readonly IReadOnlyDictionary<int, string> ItemName = new Dictionary<int, string>
        {
            { 0, "奈落"}, //TODO 奈落にガラスの橋を設定することを検討する
            { 300, "土の壁"},
            { 301, "石の壁"},
            { 302, "石ブロックの壁"},
            { 303, "粘土の壁"},
            { 320, "木の壁"},
            { 321, "幼虫の壁"},
            { 325, "草の壁"},
            { 326, "カビの壁"},
            { 327, "砂浜の壁"},
            { 328, "砂の壁"},
            { 329, "芝の壁"},
            { 330, "都市の壁"},
            { 331, "砂漠の壁"},
            { 332, "溶岩の壁"},
            { 333, "神殿の壁"},
            { 334, "迷宮の壁"},
            { 335, "雪の壁"},
            //{ 350, "黒曜石の壁"},
            { 351, "ぬりぬり壁"},
            { 352, "真紅石の壁"},
            { 353, "サンゴの壁"},
            { 354, "ガラクサイトの壁"},
            { 355, "爆発物保管庫"},
            { 357, "牧場の壁"},
            { 358, "わら織の壁"},
            { 359, "結晶の壁"},
            { 360, "異星技術の壁"},
            { 361, "光り木の壁"},
            { 362, "テルミットの壁"},
            { 363, "黒石の壁"},
            { 364, "化石の壁"},
            { 365, "オアシスの壁"},
            { 400, "土の地面"},
            { 401, "石の地面"},
            { 402, "幼虫の地面"},
            { 403, "草の地面"},
            { 404, "カビの地面"},
            { 405, "砂浜の地面"},
            { 406, "粘土の地面"},
            { 407, "砂の地面"},
            { 408, "芝の地面"},
            { 409, "都市の地面"},
            { 410, "砂漠の地面"},
            { 411, "溶岩の地面"},
            { 412, "神殿の地面"},
            { 413, "迷宮の地面"},
            { 414, "雪の地面"},
            { 415, "牧場の地面"},
            { 416, "黒石の地面"},
            { 417, "結晶の地面"},
            { 418, "異性技術の地面"},
            { 437, "通路の地面"},
            { 438, "オアシスの地面"},
            //{ 450, "黒曜石の地面"},

            //undone 他の各種着色アイテム
        };
    }
}
