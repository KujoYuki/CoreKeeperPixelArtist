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
            horizontalNumericUpDown.ReadOnly = !keepAspectCheckBox.Checked;
            // TODO verticalNumericUpDown.Value��ϊ�����
        }

        private void outputArtButton_Click(object sender, EventArgs e)
        {
            if (originPictureBox.Image is null)
            {
                MessageBox.Show("��ɓ��͉摜���Z�b�g���Ă�������");
            }

            //todo pixelPictureBox�Ƀh�b�g�G���o�͂��鏈��
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
    }
}
