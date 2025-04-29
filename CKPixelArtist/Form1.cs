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
            horizontalNumericUpDown.ReadOnly = !keepAspectCheckBox.Checked;
            // TODO verticalNumericUpDown.Valueを変換する
        }

        private void outputArtButton_Click(object sender, EventArgs e)
        {
            if (originPictureBox.Image is null)
            {
                MessageBox.Show("先に入力画像をセットしてください");
            }

            //todo pixelPictureBoxにドット絵を出力する処理
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
    }
}
