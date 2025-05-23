﻿using System;
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
        public static readonly Dictionary<(int ObjectId, Variation Variation), Pixel> PaintableColor = new Dictionary<(int ObjectId, Variation Variation), Pixel>
        {
            // ぬりぬりカベ
            { (351,Variation.Unpainted), new("9AA5D4") },
            { (351,Variation.Yellow), new("D4C22A") },
            { (351,Variation.Green), new("40A910") },
            { (351,Variation.Red), new("BB0A0A") },
            { (351,Variation.Purple), new("6D3189") },
            { (351,Variation.Blue), new("1C5DD8") },
            { (351,Variation.Brown), new("7C3A1C") },
            { (351,Variation.White), new("9DB4CB") },
            { (351,Variation.Black), new("3E3E3E") },
            { (351,Variation.Orange), new("E27929") },
            { (351,Variation.Cyan), new("1FC1B3") },
            { (351,Variation.Pink), new("F61E78") },
            { (351,Variation.Gray), new("83979F") },
            { (351,Variation.Peach), new("E07064") },
            { (351,Variation.Teal), new("1A8675") },
            
            // ぬりぬり床
            { (4708,Variation.Unpainted), new("AEBDF1") },
            { (4708,Variation.Yellow), new("FFE82E") },
            { (4708,Variation.Green), new("55B627") },
            { (4708,Variation.Red), new("DE0000") },
            { (4708,Variation.Purple), new("8B4FA7") },
            { (4708,Variation.Blue), new("2B6CE4") },
            { (4708,Variation.Brown), new("974B28") },
            { (4708,Variation.White), new("B2CEE9") },
            { (4708,Variation.Black), new("4C5455") },
            { (4708,Variation.Orange), new("ED9049") },
            { (4708,Variation.Cyan), new("29E2B4") },
            { (4708,Variation.Pink), new("FA4590") },
            { (4708,Variation.Gray), new("9DAFB7") },
            { (4708,Variation.Peach), new("FF977C") },
            { (4708,Variation.Teal), new("0F9E88") },

            // 光の床
            { (4713,Variation.Unpainted), new("9F9F9F") },
            { (4713,Variation.Yellow), new("FFF883") },
            { (4713,Variation.Green), new("9BE678") },
            { (4713,Variation.Red), new("F67373") },
            { (4713,Variation.Purple), new("BF7CDE") },
            { (4713,Variation.Blue), new("6D85FF") },
            { (4713,Variation.Brown), new("F6BA6C") },
            { (4713,Variation.White), new("FFFFFF") },
            { (4713,Variation.Black), new("2C2C2C") },
            { (4713,Variation.Orange), new("FFA35F") },
            { (4713,Variation.Cyan), new("96FFE8") },
            { (4713,Variation.Pink), new("FFB1E1") },
            { (4713,Variation.Gray), new("BAE4F6") },
            { (4713,Variation.Peach), new("FFB09B") },
            { (4713,Variation.Teal), new("4BB7AD") },

            // カーペット
            { (4750,Variation.Unpainted), new("7C477B") },
            { (4750,Variation.Yellow), new("FCFF00") },
            { (4750,Variation.Green), new("84F63F") },
            { (4750,Variation.Red), new("FF3E25") },
            { (4750,Variation.Purple), new("CD1FFF") },
            { (4750,Variation.Blue), new("4E36FF") },
            { (4750,Variation.Brown), new("D07100") },
            { (4750,Variation.White), new("FFF3F3") },
            { (4750,Variation.Black), new("0D202B") },
            { (4750,Variation.Orange), new("FF812D") },
            { (4750,Variation.Cyan), new("22ECE1") },
            { (4750,Variation.Pink), new("FF53CA") },
            { (4750,Variation.Gray), new("7E8789") },
            { (4750,Variation.Peach), new("FF8169") },
            { (4750,Variation.Teal), new("49A682") },

            // 奈落はアイテム不要なのでここに定義する
            { (233,Variation.Unpainted), new("1F1F1F") },
        };

        /// <summary>
        /// カベ/地面/クラフト系アイテムの色定義
        /// </summary>
        public static readonly IReadOnlyDictionary<(int ObjectId, Variation Variation), Pixel> CraftableColor = new Dictionary<(int ObjectId, Variation Variation), Pixel>
        {
            { (300,Variation.Unpainted), new("614927") },
            { (301,Variation.Unpainted), new("49677D") },
            { (302,Variation.Unpainted), new("6A6C72") },
            { (303,Variation.Unpainted), new("C16436") },
            { (320,Variation.Unpainted), new("946933") },
            { (321,Variation.Unpainted), new("A36153") },
            { (325,Variation.Unpainted), new("16831B") },
            { (326,Variation.Unpainted), new("599CBA") },
            { (327,Variation.Unpainted), new("B4939A") },
            { (328,Variation.Unpainted), new("AC8F3A") },
            { (329,Variation.Unpainted), new("466751") },
            { (330,Variation.Unpainted), new("314D57") },
            { (331,Variation.Unpainted), new("A69298") },
            { (332,Variation.Unpainted), new("383447") },
            { (333,Variation.Unpainted), new("0057A3") },
            { (334,Variation.Unpainted), new("3C4F39") },
            { (335,Variation.Unpainted), new("6DB1B4") },
            { (352,Variation.Unpainted), new("902613") },
            { (353,Variation.Unpainted), new("DE8EB2") },
            { (354,Variation.Unpainted), new("DDDDDD") },
            { (355,Variation.Unpainted), new("C0171A") },
            { (357,Variation.Unpainted), new("E0C961") },
            { (358,Variation.Unpainted), new("DBD489") },
            { (359,Variation.Unpainted), new("2A59EE") },
            { (360,Variation.Unpainted), new("463E66") },
            { (361,Variation.Unpainted), new("0FA1AE") },
            { (363,Variation.Unpainted), new("324655") },
            { (364,Variation.Unpainted), new("595664") },
            { (365,Variation.Unpainted), new("A84C1E") },
            { (400,Variation.Unpainted), new("7F5F30") },
            { (401,Variation.Unpainted), new("678397") },
            { (402,Variation.Unpainted), new("C77463") },
            { (403,Variation.Unpainted), new("3D9B41") },
            { (404,Variation.Unpainted), new("6CBCE0") },
            { (405,Variation.Unpainted), new("EBC0BE") },
            { (406,Variation.Unpainted), new("E88B69") },
            { (407,Variation.Unpainted), new("D3B958") },
            { (408,Variation.Unpainted), new("568064") },
            { (409,Variation.Unpainted), new("578084") },
            { (410,Variation.Unpainted), new("D29A7C") },
            { (411,Variation.Unpainted), new("554E6A") },
            { (412,Variation.Unpainted), new("86716E") },
            { (413,Variation.Unpainted), new("536460") },
            { (414,Variation.Unpainted), new("9BE7EB") },
            { (416,Variation.Unpainted), new("557287") },
            { (417,Variation.Unpainted), new("3988DB") },
            { (418,Variation.Unpainted), new("456A73") },
            { (437,Variation.Unpainted), new("C0BACF") },
            { (438,Variation.Unpainted), new("C77138") },
            { (4700,Variation.Unpainted), new("C7944F") },
            { (4702,Variation.Unpainted), new("704821") },
            { (4703,Variation.Unpainted), new("8C5826") },
            { (4704,Variation.Unpainted), new("81848C") },
            { (4706,Variation.Unpainted), new("615B55") },
            { (4707,Variation.Unpainted), new("7B746C") },
            { (4709,Variation.Unpainted), new("A81E2E") },
            { (4711,Variation.Unpainted), new("80242E") },
            { (4712,Variation.Unpainted), new("B51E2F") },
            { (4714,Variation.Unpainted), new("D56DB7") },
            { (4716,Variation.Unpainted), new("9F3DA4") },
            { (4717,Variation.Unpainted), new("C85CCC") },
            { (4718,Variation.Unpainted), new("C5C5C5") },
            { (4720,Variation.Unpainted), new("98A195") },
            { (4721,Variation.Unpainted), new("ACB3A9") },
            { (4725,Variation.Unpainted), new("FFF371") },
            { (4726,Variation.Unpainted), new("80F2FF") },
            { (4728,Variation.Unpainted), new("109AA6") },
            { (4729,Variation.Unpainted), new("0FD2BE") },
            { (4773,Variation.Unpainted), new("C58736") },
        };

        /// <summary>
        /// 採取系アイテムの色定義
        /// ブロックは壁と地面の色が異なるため別アイテムとして定義する
        /// </summary>
        public static readonly IReadOnlyDictionary<(int ObjectId, Variation Variation), Pixel> CollectableColor = new Dictionary<(int ObjectId, Variation Variation), Pixel>
        {
            { (39,Variation.NormalWater), new("1E3D81") },
            { (39,Variation.Lava), new("DE3501") },
            { (39,Variation.AcidWater), new("746733") },
            { (39,Variation.MoldWater), new("3D5587") },
            { (39,Variation.SeaWater), new("34D0FF") },
            { (39,Variation.ShiningWater), new("9AC6F3") },
            { (39,Variation.GrimyWater), new("3D3959") },
            { (1610,Variation.Unpainted), new("E1A368") },
            { (1612,Variation.Unpainted), new("FD6AAD") },
            { (1613,Variation.Unpainted), new("ADEBFD") },
            { (4751,Variation.Unpainted), new("3A8B41") },
            { (5505,Variation.Unpainted), new("CFF1FF") },
            { (5506,Variation.Unpainted), new("A3CE4A") },
            { (5507,Variation.Unpainted), new("2AA947") },
            { (5508,Variation.Unpainted), new("B7533C") },
            { (5509,Variation.Unpainted), new("F97443") },
            { (5510,Variation.Unpainted), new("7E574E") },
            { (5511,Variation.Unpainted), new("FCA694") },
            { (5512,Variation.Unpainted), new("D96217") },
            { (5513,Variation.Unpainted), new("C1A921") },
            { (5514,Variation.Unpainted), new("B856A5") },
            { (5515,Variation.Unpainted), new("3333EE") },
            { (5516,Variation.Unpainted), new("FF5400") },
            { (5517,Variation.Unpainted), new("0FA2B8") },
            { (5612,Variation.Unpainted), new("CDBD30") },
            { (5630,Variation.Unpainted), new("E5E5E5") },
            { (5636,Variation.Unpainted), new("614822") },
            { (5800,Variation.Unpainted), new("307CCD") },
            { (5842,Variation.Unpainted), new("8F7B77") },
            { (5845,Variation.Unpainted), new("4A61DA") },
            { (5848,Variation.Unpainted), new("BB4034") },
            { (5849,Variation.Unpainted), new("9F4E9F") },
            { (5860,Variation.Unpainted), new("DB5C3F") },
            { (5863,Variation.Unpainted), new("677FAE") },
            { (5864,Variation.Unpainted), new("EECD63") },
            { (5866,Variation.Unpainted), new("536D27") },
            { (5941,Variation.Unpainted), new("4CE9E0") },
            { (5945,Variation.Unpainted), new("DB8C26") },
            { (5953,Variation.Unpainted), new("26DE51") },
            { (5960,Variation.Unpainted), new("47687E") },
            { (5981,Variation.Unpainted), new("D7DCFB") },
            { (5986,Variation.Unpainted), new("365956") },
            { (6550,Variation.Unpainted), new("7A7A7A") },
            { (6651,Variation.Unpainted), new("687FAE") },
            { (10102,Variation.Unpainted), new("674F7A") },
            { (10103,Variation.Unpainted), new("85669C") },
            
            // 異なるIdで同色アイテム
            { (5611,Variation.Unpainted), new("723C11") },
            { (6827,Variation.Unpainted), new("723C11") },
            //{ (5821/5822/5823/5700/5710,Variation.Unpainted), new("828282") },    // 石板系は使わない
            { (5700,Variation.Unpainted), new("828282") },
            { (5710,Variation.Unpainted), new("828282") },
            //{ (5840/5520,Variation.Unpainted), new("4DA8CA") },
            { (5840,Variation.Unpainted), new("4DA8CA") },
            { (5520,Variation.Unpainted), new("4DA8CA") },
        };

        /// <summary>
        /// 通常入手不可アイテムの色定義
        /// 本当に全部の色を使いたい人向けの逸般向けアイテム
        /// TODO 使用モードは未検討
        /// </summary>
        public static readonly IReadOnlyDictionary<(int ObjectId, Variation Variation), Pixel> NotAvailableColor = new Dictionary<(int ObjectId, Variation Variation), Pixel>
        {
            { (366,Variation.Unpainted), new("B969D1") },  // ポイズンベリーのカベ
            // UNDONE 他にもいろいろ
        };

        /// <summary>
        /// アイテムの表示名定義
        /// ブロックはカベと地面の色が異なるため別アイテムとして定義する
        /// </summary>
        public static readonly IReadOnlyDictionary<int, string> ItemName = new Dictionary<int, string>
        {
            { 39, "バケツ" },
            { 233, "奈落" },  //TODO 提示アイテムとしてガラスの橋を設定することを検討する
            { 300, "土のブロック(カベ)" },
            { 301, "石のブロック(カベ)" },
            { 302, "石ブロックのカベ" },
            { 303, "粘土のブロック(カベ）" },
            { 320, "木のカベ" },
            { 321, "幼虫の巣のブロック(カベ)" },
            { 325, "草のブロック(カベ)" },
            { 326, "カビのブロック(カベ)" },
            { 327, "浜辺のブロック(カベ)" },
            { 329, "芝のブロック(カベ)" },
            { 330, "都市のブロック(カベ)" },
            { 331, "砂漠のブロック(カベ)" },
            { 332, "溶岩のブロック(カベ)" },
            { 333, "砂漠の神殿のブロック(カベ)" },
            { 334, "迷路のブロック(カベ)" },
            { 335, "雪のブロック(カベ)" },
            { 351, "ぬりぬりカベ" },
            { 352, "真紅石のカベ" },
            { 353, "サンゴのカベ" },
            { 354, "ガラクサイトのカベ" },
            { 355, "爆発物保管箱" },
            { 357, "牧草地のブロック（カベ）" },
            { 358, "わらブロックのカベ" },
            { 359, "結晶のブロック(カベ)" },
            { 360, "異星技術のブロック(カベ)" },
            { 361, "光の木のカベ" },
            { 363, "黒石のブロック(カベ)" },
            { 364, "化石のブロック(カベ)" },
            { 365, "オアシスのブロック(カベ)" },
            { 400, "土のブロック（地面）" },
            { 402, "幼虫の巣のブロック(地面)" },
            { 403, "草のブロック(地面)" },
            { 404, "カビのブロック(地面)" },
            { 405, "浜辺のブロック(地面)" },
            { 406, "粘土のブロック(地面）" },
            { 407, "砂のブロック(地面)" },
            { 408, "芝のブロック(地面)" },
            { 409, "都市のブロック(地面)" },
            { 410, "砂漠のブロック(地面)" },
            { 411, "溶岩のブロック(地面)" },
            { 412, "砂漠の神殿のブロック(地面)" },
            { 413, "迷路のブロック(地面)" },
            { 414, "雪のブロック(地面)" },
            { 415, "牧草地のブロック（地面）" },
            { 416, "黒石のブロック(地面)" },
            { 417, "結晶のブロック(地面)" },
            { 418, "異星技術のブロック(地面)" },
            { 437, "化石のブロック(地面)" },
            { 438, "オアシスのブロック(地面)" },
            { 1610, "木" },
            { 1612, "サンゴの木" },
            { 1613, "光の木" },
            { 4700, "木の床" },
            { 4702, "木のフェンス" },
            { 4703, "木の橋" },
            { 4704, "石の床" },
            { 4706, "石のフェンス" },
            { 4707, "石の橋" },
            { 4708, "ぬりぬり床" },
            { 4709, "真紅石の床" },
            { 4711, "真紅石のフェンス" },
            { 4712, "真紅石の橋" },
            { 4713, "光の床" },
            { 4714, "サンゴの床" },
            { 4716, "サンゴのフェンス" },
            { 4717, "サンゴの橋" },
            { 4718, "ガラクサイトの床" },
            { 4720, "ガラクサイトのフェンス" },
            { 4721, "ガラクサイトの橋" },
            { 4725, "わら織の床" },
            { 4726, "光の木の床" },
            { 4728, "光の木のフェンス" },
            { 4729, "光の木の橋" },
            { 4750, "カーペット" },
            { 4751, "手織りのマット" },
            { 4773, "鉄の格子" },
            { 5505, "石ゴケ" },
            { 5506, "草ゴケ" },
            { 5507, "都会ゴケ" },
            { 5508, "胞子だらけの土" },
            { 5509, "谷ゴケ" },
            { 5510, "粘土ゴケ" },
            { 5511, "サナギ" },
            { 5512, "スライムの地面" },
            { 5513, "酸のスライムの地面" },
            { 5514, "毒スライムの地面" },
            { 5515, "すべりやすいスライムの地面" },
            { 5516, "マグマスライムの地面" },
            { 5517, "結晶殻" },
            { 5612, "花の器" },
            { 5630, "カビの器" },
            { 5636, "生い茂る木の箱" },
            { 5800, "ビーチクラゲ" },
            { 5842, "流木の箱" },
            { 5845, "二色サンゴ" },
            { 5848, "真紅サンゴ" },
            { 5849, "皿サンゴ" },
            { 5860, "砂漠の花の器" },
            { 5863, "黒こげの箱" },
            { 5864, "神殿の箱" },
            { 5866, "オアシスの花の器" },
            { 5941, "異星技術の箱" },
            { 5945, "太陽の結晶" },
            { 5953, "放射線の結晶" },
            { 5960, "異星のフロアベント" },
            { 5981, "化石の塊" },
            { 5986, "汚れた石の床" },
            { 6550, "線路" },
            { 6651, "ベルトコンベア" },
            { 10102, "ブキミなカベ" },
            { 10103, "ブキミな床" },
            { 328, "砂のブロック(カベ)" },
            { 401, "石のブロック(地面)" },
            //{ 5611/6827, "木の箱/オフィスの箱" },
            { 5611, "木の箱" },
            { 6827, "オフィスの箱" },
            //{ 5821/5822/5823/5700/5710, "「石板」系/ケイヴリングの床タイル/ケイヴリングの暗い床タイル" },
            //{ 5821, "「石板」" }, //石板は2*2サイズのため、除外する
            //{ 5822, "「石板」" },
            //{ 5823, "「石板」" },
            { 5700, "ケイヴリングの床タイル" },
            { 5710, "ケイヴリングの暗い床タイル" },
            //{ 5840/5520, "都市の箱/古代の箱" },
            { 5840, "都市の箱" },
            { 5520, "古代の箱" },
        };
    }
}
