namespace CKPixelArtist
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            imageFilePathTextBox = new TextBox();
            verticalNumericUpDown = new NumericUpDown();
            originPictureBox = new PictureBox();
            pixelPictureBox = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            horizontalNumericUpDown = new NumericUpDown();
            keepAspectCheckBox = new CheckBox();
            colorModelComboBox = new ComboBox();
            selectImageFileButton = new Button();
            outputRecipeButton = new Button();
            limitItemComboBox = new ComboBox();
            label7 = new Label();
            outputArtButton = new Button();
            openImageFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)verticalNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)originPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pixelPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)horizontalNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 322);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "縦のマス数";
            // 
            // imageFilePathTextBox
            // 
            imageFilePathTextBox.Location = new Point(195, 286);
            imageFilePathTextBox.Name = "imageFilePathTextBox";
            imageFilePathTextBox.ReadOnly = true;
            imageFilePathTextBox.Size = new Size(600, 23);
            imageFilePathTextBox.TabIndex = 1;
            // 
            // verticalNumericUpDown
            // 
            verticalNumericUpDown.Location = new Point(81, 320);
            verticalNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            verticalNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            verticalNumericUpDown.Name = "verticalNumericUpDown";
            verticalNumericUpDown.Size = new Size(120, 23);
            verticalNumericUpDown.TabIndex = 2;
            verticalNumericUpDown.Value = new decimal(new int[] { 30, 0, 0, 0 });
            verticalNumericUpDown.ValueChanged += verticalNumericUpDown_ValueChanged;
            // 
            // originPictureBox
            // 
            originPictureBox.BorderStyle = BorderStyle.FixedSingle;
            originPictureBox.Location = new Point(12, 12);
            originPictureBox.Name = "originPictureBox";
            originPictureBox.Size = new Size(309, 258);
            originPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            originPictureBox.TabIndex = 3;
            originPictureBox.TabStop = false;
            // 
            // pixelPictureBox
            // 
            pixelPictureBox.BorderStyle = BorderStyle.FixedSingle;
            pixelPictureBox.Location = new Point(448, 12);
            pixelPictureBox.Name = "pixelPictureBox";
            pixelPictureBox.Size = new Size(309, 258);
            pixelPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pixelPictureBox.TabIndex = 4;
            pixelPictureBox.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 351);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 5;
            label2.Text = "横のマス数";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 385);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "表色系";
            // 
            // horizontalNumericUpDown
            // 
            horizontalNumericUpDown.Location = new Point(81, 349);
            horizontalNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            horizontalNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            horizontalNumericUpDown.Name = "horizontalNumericUpDown";
            horizontalNumericUpDown.Size = new Size(120, 23);
            horizontalNumericUpDown.TabIndex = 7;
            horizontalNumericUpDown.Value = new decimal(new int[] { 30, 0, 0, 0 });
            horizontalNumericUpDown.ValueChanged += horizontalNumericUpDown_ValueChanged;
            // 
            // keepAspectCheckBox
            // 
            keepAspectCheckBox.AutoSize = true;
            keepAspectCheckBox.Checked = true;
            keepAspectCheckBox.CheckState = CheckState.Checked;
            keepAspectCheckBox.Location = new Point(218, 350);
            keepAspectCheckBox.Name = "keepAspectCheckBox";
            keepAspectCheckBox.Size = new Size(116, 19);
            keepAspectCheckBox.TabIndex = 9;
            keepAspectCheckBox.Text = "アスペクト比を維持";
            keepAspectCheckBox.UseVisualStyleBackColor = true;
            keepAspectCheckBox.CheckedChanged += keepAspectCheckBox_CheckedChanged;
            // 
            // colorModelComboBox
            // 
            colorModelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            colorModelComboBox.FormattingEnabled = true;
            colorModelComboBox.Items.AddRange(new object[] { "HSV", "Lab*", "RGB" });
            colorModelComboBox.Location = new Point(80, 382);
            colorModelComboBox.Name = "colorModelComboBox";
            colorModelComboBox.Size = new Size(121, 23);
            colorModelComboBox.TabIndex = 10;
            // 
            // selectImageFileButton
            // 
            selectImageFileButton.Location = new Point(12, 286);
            selectImageFileButton.Name = "selectImageFileButton";
            selectImageFileButton.Size = new Size(162, 23);
            selectImageFileButton.TabIndex = 12;
            selectImageFileButton.Text = "素材の画像ファイルを選択";
            selectImageFileButton.UseVisualStyleBackColor = true;
            selectImageFileButton.Click += selectImageFileButton_Click;
            // 
            // outputRecipeButton
            // 
            outputRecipeButton.Location = new Point(448, 406);
            outputRecipeButton.Name = "outputRecipeButton";
            outputRecipeButton.Size = new Size(181, 23);
            outputRecipeButton.TabIndex = 16;
            outputRecipeButton.Text = "素材配置をExcelで出力";
            outputRecipeButton.UseVisualStyleBackColor = true;
            outputRecipeButton.Click += outputRecipeButton_Click;
            // 
            // limitItemComboBox
            // 
            limitItemComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            limitItemComboBox.FormattingEnabled = true;
            limitItemComboBox.Items.AddRange(new object[] { "着色可能アイテム", "着色/製作可能アイテム", "全てのアイテム" });
            limitItemComboBox.Location = new Point(80, 411);
            limitItemComboBox.Name = "limitItemComboBox";
            limitItemComboBox.Size = new Size(121, 23);
            limitItemComboBox.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 414);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 17;
            label7.Text = "素材制限";
            // 
            // outputArtButton
            // 
            outputArtButton.Location = new Point(448, 377);
            outputArtButton.Name = "outputArtButton";
            outputArtButton.Size = new Size(75, 23);
            outputArtButton.TabIndex = 19;
            outputArtButton.Text = "ドット絵生成";
            outputArtButton.UseVisualStyleBackColor = true;
            outputArtButton.Click += outputArtButton_Click;
            // 
            // openImageFileDialog
            // 
            openImageFileDialog.FileName = "openFileDialog1";
            openImageFileDialog.Filter = "画像ファイル|*.jpg;*.jpeg;*.png;*.bmp";
            openImageFileDialog.Title = "画像ファイルを選択してください。";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(807, 511);
            Controls.Add(outputArtButton);
            Controls.Add(limitItemComboBox);
            Controls.Add(label7);
            Controls.Add(outputRecipeButton);
            Controls.Add(selectImageFileButton);
            Controls.Add(colorModelComboBox);
            Controls.Add(keepAspectCheckBox);
            Controls.Add(horizontalNumericUpDown);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pixelPictureBox);
            Controls.Add(originPictureBox);
            Controls.Add(verticalNumericUpDown);
            Controls.Add(imageFilePathTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "CKPixelArtist";
            ((System.ComponentModel.ISupportInitialize)verticalNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)originPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pixelPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)horizontalNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox imageFilePathTextBox;
        private NumericUpDown verticalNumericUpDown;
        private PictureBox originPictureBox;
        private PictureBox pixelPictureBox;
        private Label label2;
        private Label label3;
        private NumericUpDown horizontalNumericUpDown;
        private CheckBox keepAspectCheckBox;
        private ComboBox colorModelComboBox;
        private Button selectImageFileButton;
        private Button outputRecipeButton;
        private ComboBox limitItemComboBox;
        private Label label7;
        private Button outputArtButton;
        private OpenFileDialog openImageFileDialog;
    }
}
