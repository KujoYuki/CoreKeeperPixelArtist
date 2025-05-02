using CKPixelArtist.model;
using System.Windows.Forms;

namespace CKPixelArtist
{
    public partial class Form1 : Form
    {
        public string ImagePath { get; set; } = string.Empty;

        /// <summary>
        /// 横幅を基準とした、縦幅との比率
        /// </summary>
        public double ImageRatio { get; set; } = default;

        public Form1()
        {
            InitializeComponent();

            colorModelComboBox.SelectedIndex = 0;
            limitItemComboBox.SelectedIndex = 0;
            //originPictureBox.AllowDrop = true;    // Hack D&Dを許可する時にコメントアウトを外す

            openImageFileDialog.InitialDirectory = Properties.Settings.Default.LastOpenedFolder == string.Empty ?
                Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) :
                Properties.Settings.Default.LastOpenedFolder;
        }

        #region D&Dでの画像読み込みを検討
        // ドラッグ＆ドロップで画像を読み込む場合の処理はプロトタイプ完成後に実装を検討する
        //private void originPictureBox_DragEnter(object sender, DragEventArgs e)
        //{
        //    // ドラッグされているデータがファイルかどうかを確認
        //    if (e.Data!.GetDataPresent(DataFormats.FileDrop))
        //    {
        //        e.Effect = DragDropEffects.Copy; // ドロップを許可
        //    }
        //    else
        //    {
        //        e.Effect = DragDropEffects.None; // ドロップを拒否
        //    }
        //}

        //private void originPictureBox_DragDrop(object sender, DragEventArgs e)
        //{
        //    // ドロップされたファイルを取得
        //    string[] files = (string[])e.Data?.GetData(DataFormats.FileDrop)!;

        //    if (files.Length > 0 && IsImageFile(files[0]))
        //    {
        //        // 画像をPictureBoxに表示
        //        originPictureBox.Image = Image.FromFile(files[0]);
        //    }
        //}

        //private bool IsImageFile(string filePath)
        //{
        //    // 拡張子で画像ファイルかどうかを判定
        //    string extension = Path.GetExtension(filePath)?.ToLower()!;
        //    return extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".bmp" || extension == ".gif";
        //}
        #endregion


        private void selectImageFileButton_Click(object sender, EventArgs e)
        {

            if (openImageFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            // 選択された画像ファイルをPictureBoxに表示
            originPictureBox.Image = Image.FromFile(openImageFileDialog.FileName);
            imageFilePathTextBox.Text = openImageFileDialog.FileName;

            // 選択されたファイルのフォルダを保存
            string selectedFolder = Path.GetDirectoryName(openImageFileDialog.FileName)!;
            if (!string.IsNullOrEmpty(selectedFolder))
            {
                Properties.Settings.Default.LastOpenedFolder = selectedFolder;
                Properties.Settings.Default.Save(); // 設定を保存
            }

            // 画像のアスペクト比を計算
            ImageRatio = (double)originPictureBox.Image.Width / originPictureBox.Image.Height;
            horizontalNumericUpDown.Value = originPictureBox.Image.Width;
            if (keepAspectCheckBox.Checked)
            {
                verticalNumericUpDown.Value = Convert.ToInt32((double)horizontalNumericUpDown.Value * ImageRatio);
            }
            verticalNumericUpDown.Value = originPictureBox.Image.Height;
        }

        private void keepAspectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            horizontalNumericUpDown.ReadOnly = keepAspectCheckBox.Checked;
            // TODO verticalNumericUpDown.Valueを変換する
            //hack readonlyが想定と異なるのでチェックボックスマウスホイール操作等も受け付けないようにする
            //TODO verticalNumericUpDownの方の値変更イベントを追加し、アスペクト比を維持させる
        }

        private void outputArtButton_Click(object sender, EventArgs e)
        {
            if (originPictureBox.Image is null)
            {
                MessageBox.Show("先に入力画像をセットしてください");
                return;
            }

            // 指定された縦横サイズを取得
            int targetWidth = (int)horizontalNumericUpDown.Value;
            int targetHeight = (int)verticalNumericUpDown.Value;

            // 元画像を取得
            Bitmap originalImage = new Bitmap(originPictureBox.Image);

            // ピクセルアートを生成
            Bitmap pixelArtImage = GeneratePixelArt(originalImage, targetWidth, targetHeight);
            pixelPictureBox.Image = pixelArtImage;

            // ピクセルの色をコアキでの近似色に変換する
            SoumulizePixelArt(pixelArtImage, (MaterialColorLimit)limitItemComboBox.SelectedIndex, (ColorModel)colorModelComboBox.SelectedIndex);
        }

        private void SoumulizePixelArt(Bitmap pixelArtImage, MaterialColorLimit colorLimit, ColorModel colorModel)
        {
            Dictionary<(int ObjectId, Variation Variation), Pixel> availableColorDic = Define.PaintableColor;

            switch (colorLimit)
            {
                case MaterialColorLimit.PaintableMode:
                    break;
                case MaterialColorLimit.CraftableMode:
                    availableColorDic.Concat(Define.CraftableColor);
                    break;
                case MaterialColorLimit.SoumuMode:
                    availableColorDic.Concat(Define.CraftableColor).Concat(Define.CollectableColor);
                    break;
                default:
                    break;
            }

            switch (colorModel)
            {
                case ColorModel.HSV:
                    // HSVモデルでの処理
                    break;
                case ColorModel.HSL:
                    MessageBox.Show("HSLモデルはβ版現在未実装です");
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(colorModel), colorModel, null);
            }

            int width = pixelArtImage.Width;
            int height = pixelArtImage.Height;

            Bitmap resizedImage = new Bitmap(pixelPictureBox.Image);
            soumulizedPictureBox.Image = resizedImage;
        }

        private Bitmap GeneratePixelArt(Bitmap originalImage, int width, int height)
        {
            // 元画像を指定サイズに縮小
            Bitmap resizedImage = new Bitmap(originalImage, new Size(width, height));

            // HACK セルシェーディングを行う

            // 縮小画像を元のサイズに拡大（ピクセルアート風にする）
            Bitmap pixelArtImage = new Bitmap(resizedImage.Width * 10, resizedImage.Height * 10);
            using (Graphics g = Graphics.FromImage(pixelArtImage))
            {
                // 拡大時に補間を無効化してピクセル感を保つ
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
                g.DrawImage(resizedImage, new Rectangle(0, 0, pixelArtImage.Width, pixelArtImage.Height));
            }
            
            return pixelArtImage;
        }

        private void outputRecipeButton_Click(object sender, EventArgs e)
        {
            // TODO map tileのカラー定義で近しい物をExcelで出力する（ソウムさんから頂く）
        }

        private void verticalNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void horizontalNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        //内部ロジック確認用
        private void debugButton_Click(object sender, EventArgs e)
        {
            string objectName = "木の箱";
            var debugPixel = new Pixel("723C11");
            debugPixel.ToHSV(out double hue, out double saturation, out double value);
            MessageBox.Show($"{objectName}\nHue: {hue:F2}, Saturation: {saturation:F2}, Value: {value:F2}");
        }
    }
}
