using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKPixelArtist.model
{
    /// <summary>
    /// RGB値を基本形とした複数の表色系モデルへの変換処理
    /// 式差計算の都合上、全ての次元で重みを均等にするため、色相(Hue)等の値も0から100の範囲で正規化する。
    /// </summary>
    public record Pixel
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public Pixel(string RGB) 
        {
            string lowerColorCode = RGB.ToLower();
            R = Convert.ToInt32(lowerColorCode.Substring(0, 2), 16);
            G = Convert.ToInt32(lowerColorCode.Substring(2, 2), 16);
            B = Convert.ToInt32(lowerColorCode.Substring(4, 2), 16);
        }

        public void ToHSV(out double hue, out double saturation, out double value)
        {
            // RGB値を0〜1の範囲に正規化
            double r = R / 255.0;
            double g = G / 255.0;
            double b = B / 255.0;

            // 最大値と最小値を取得
            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));
            double delta = max - min;

            // Hueの計算
            if (delta == 0)
            {
                hue = 0; // 色相は定義されないが、0に設定
            }
            else if (max == r)
            {
                hue = 60 * (((g - b) / delta) % 6);
            }
            else if (max == g)
            {
                hue = 60 * (((b - r) / delta) + 2);
            }
            else // max == b
            {
                hue = 60 * (((r - g) / delta) + 4);
            }
            // 色相を0〜100の範囲に正規化
            hue = hue * 100 / 360;

            // Saturationの計算
            saturation = max == 0 ? 0 : delta / max * 100;

            // Valueの計算
            value = max * 100;
        }

        public void ToHSL(out double H, out double S, out double L)
        {
            //TODO : HSLの計算を実装
            throw new NotImplementedException();
        }

        public void ToLab(out double L, out double a, out double b)
        {
            // RGBをLabに変換するロジックをここに実装
            // 例: return new Lab(L, a, b);
            throw new NotImplementedException();
        }
    }
}
