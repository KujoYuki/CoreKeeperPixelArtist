using CKPixelArtist.model;
using System.Windows.Forms;

namespace CKPixelArtist
{
    public partial class Form1 : Form
    {
        public string ImagePath { get; set; } = string.Empty;

        /// <summary>
        /// ��������Ƃ����A�c���Ƃ̔䗦
        /// </summary>
        public double ImageRatio { get; set; } = default;

        public Form1()
        {
            InitializeComponent();

            colorModelComboBox.SelectedIndex = 0;
            limitItemComboBox.SelectedIndex = 0;
            //originPictureBox.AllowDrop = true;    // Hack D&D�������鎞�ɃR�����g�A�E�g���O��

            openImageFileDialog.InitialDirectory = Properties.Settings.Default.LastOpenedFolder == string.Empty ?
                Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) :
                Properties.Settings.Default.LastOpenedFolder;
        }

        #region D&D�ł̉摜�ǂݍ��݂�����
        // �h���b�O���h���b�v�ŉ摜��ǂݍ��ޏꍇ�̏����̓v���g�^�C�v������Ɏ�������������
        //private void originPictureBox_DragEnter(object sender, DragEventArgs e)
        //{
        //    // �h���b�O����Ă���f�[�^���t�@�C�����ǂ������m�F
        //    if (e.Data!.GetDataPresent(DataFormats.FileDrop))
        //    {
        //        e.Effect = DragDropEffects.Copy; // �h���b�v������
        //    }
        //    else
        //    {
        //        e.Effect = DragDropEffects.None; // �h���b�v������
        //    }
        //}

        //private void originPictureBox_DragDrop(object sender, DragEventArgs e)
        //{
        //    // �h���b�v���ꂽ�t�@�C�����擾
        //    string[] files = (string[])e.Data?.GetData(DataFormats.FileDrop)!;

        //    if (files.Length > 0 && IsImageFile(files[0]))
        //    {
        //        // �摜��PictureBox�ɕ\��
        //        originPictureBox.Image = Image.FromFile(files[0]);
        //    }
        //}

        //private bool IsImageFile(string filePath)
        //{
        //    // �g���q�ŉ摜�t�@�C�����ǂ����𔻒�
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

            // �I�����ꂽ�摜�t�@�C����PictureBox�ɕ\��
            originPictureBox.Image = Image.FromFile(openImageFileDialog.FileName);
            imageFilePathTextBox.Text = openImageFileDialog.FileName;

            // �I�����ꂽ�t�@�C���̃t�H���_��ۑ�
            string selectedFolder = Path.GetDirectoryName(openImageFileDialog.FileName)!;
            if (!string.IsNullOrEmpty(selectedFolder))
            {
                Properties.Settings.Default.LastOpenedFolder = selectedFolder;
                Properties.Settings.Default.Save(); // �ݒ��ۑ�
            }

            // �摜�̃A�X�y�N�g����v�Z
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
            // TODO verticalNumericUpDown.Value��ϊ�����
            //hack readonly���z��ƈقȂ�̂Ń`�F�b�N�{�b�N�X�}�E�X�z�C�[�����쓙���󂯕t���Ȃ��悤�ɂ���
            //TODO verticalNumericUpDown�̕��̒l�ύX�C�x���g��ǉ����A�A�X�y�N�g����ێ�������
        }

        private void outputArtButton_Click(object sender, EventArgs e)
        {
            if (originPictureBox.Image is null)
            {
                MessageBox.Show("��ɓ��͉摜���Z�b�g���Ă�������");
                return;
            }

            // �w�肳�ꂽ�c���T�C�Y���擾
            int targetWidth = (int)horizontalNumericUpDown.Value;
            int targetHeight = (int)verticalNumericUpDown.Value;

            // ���摜���擾
            Bitmap originalImage = new Bitmap(originPictureBox.Image);

            // �s�N�Z���A�[�g�𐶐�
            Bitmap pixelArtImage = GeneratePixelArt(originalImage, targetWidth, targetHeight);
            pixelPictureBox.Image = pixelArtImage;

            // �s�N�Z���̐F���R�A�L�ł̋ߎ��F�ɕϊ�����
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
                    // HSV���f���ł̏���
                    break;
                case ColorModel.HSL:
                    MessageBox.Show("HSL���f���̓��Ō��ݖ������ł�");
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
            // ���摜���w��T�C�Y�ɏk��
            Bitmap resizedImage = new Bitmap(originalImage, new Size(width, height));

            // HACK �Z���V�F�[�f�B���O���s��

            // �k���摜�����̃T�C�Y�Ɋg��i�s�N�Z���A�[�g���ɂ���j
            Bitmap pixelArtImage = new Bitmap(resizedImage.Width * 10, resizedImage.Height * 10);
            using (Graphics g = Graphics.FromImage(pixelArtImage))
            {
                // �g�厞�ɕ�Ԃ𖳌������ăs�N�Z������ۂ�
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
                g.DrawImage(resizedImage, new Rectangle(0, 0, pixelArtImage.Width, pixelArtImage.Height));
            }
            
            return pixelArtImage;
        }

        private void outputRecipeButton_Click(object sender, EventArgs e)
        {
            // TODO map tile�̃J���[��`�ŋ߂�������Excel�ŏo�͂���i�\�E�����񂩂璸���j
        }

        private void verticalNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void horizontalNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        //�������W�b�N�m�F�p
        private void debugButton_Click(object sender, EventArgs e)
        {
            string objectName = "�؂̔�";
            var debugPixel = new Pixel("723C11");
            debugPixel.ToHSV(out double hue, out double saturation, out double value);
            MessageBox.Show($"{objectName}\nHue: {hue:F2}, Saturation: {saturation:F2}, Value: {value:F2}");
        }
    }
}
