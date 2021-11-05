namespace MultiStegano
{
    partial class MultiStegoForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiStegoForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ImageStego = new System.Windows.Forms.TabPage();
            this.modImgPath = new System.Windows.Forms.TextBox();
            this.origImgPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LenghtTextBox = new System.Windows.Forms.TextBox();
            this.colorBox = new System.Windows.Forms.GroupBox();
            this.redColorRadioButton = new System.Windows.Forms.RadioButton();
            this.greenColorRadioButton = new System.Windows.Forms.RadioButton();
            this.blueColorRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.langBox = new System.Windows.Forms.GroupBox();
            this.russianLangRadioButton = new System.Windows.Forms.RadioButton();
            this.engLangRadioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.DecodeButton = new System.Windows.Forms.Button();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.imgEncryptTextBox = new System.Windows.Forms.TextBox();
            this.OpenChangedImageButton = new System.Windows.Forms.Button();
            this.OpenOriginalImageButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.encodedPictureBox = new System.Windows.Forms.PictureBox();
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.encryptTextBoxClearButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.ImageStego.SuspendLayout();
            this.colorBox.SuspendLayout();
            this.langBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encodedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ImageStego);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1395, 802);
            this.tabControl1.TabIndex = 0;
            // 
            // ImageStego
            // 
            this.ImageStego.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ImageStego.Controls.Add(this.encryptTextBoxClearButton);
            this.ImageStego.Controls.Add(this.modImgPath);
            this.ImageStego.Controls.Add(this.origImgPath);
            this.ImageStego.Controls.Add(this.label5);
            this.ImageStego.Controls.Add(this.LenghtTextBox);
            this.ImageStego.Controls.Add(this.colorBox);
            this.ImageStego.Controls.Add(this.langBox);
            this.ImageStego.Controls.Add(this.DecodeButton);
            this.ImageStego.Controls.Add(this.EncodeButton);
            this.ImageStego.Controls.Add(this.label3);
            this.ImageStego.Controls.Add(this.imgEncryptTextBox);
            this.ImageStego.Controls.Add(this.OpenChangedImageButton);
            this.ImageStego.Controls.Add(this.OpenOriginalImageButton);
            this.ImageStego.Controls.Add(this.label2);
            this.ImageStego.Controls.Add(this.label1);
            this.ImageStego.Controls.Add(this.encodedPictureBox);
            this.ImageStego.Controls.Add(this.originalPictureBox);
            this.ImageStego.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImageStego.Location = new System.Drawing.Point(4, 33);
            this.ImageStego.Name = "ImageStego";
            this.ImageStego.Padding = new System.Windows.Forms.Padding(3);
            this.ImageStego.Size = new System.Drawing.Size(1387, 765);
            this.ImageStego.TabIndex = 0;
            this.ImageStego.Text = "ImageStego";
            // 
            // modImgPath
            // 
            this.modImgPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modImgPath.Location = new System.Drawing.Point(883, 560);
            this.modImgPath.Name = "modImgPath";
            this.modImgPath.Size = new System.Drawing.Size(316, 22);
            this.modImgPath.TabIndex = 31;
            this.modImgPath.Text = "Путь к измененному файлу";
            // 
            // origImgPath
            // 
            this.origImgPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.origImgPath.Location = new System.Drawing.Point(153, 559);
            this.origImgPath.Name = "origImgPath";
            this.origImgPath.Size = new System.Drawing.Size(318, 22);
            this.origImgPath.TabIndex = 30;
            this.origImgPath.Text = "Путь к оригинальному файлу";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(728, 649);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "Предполагаемая длина сообщения:";
            // 
            // LenghtTextBox
            // 
            this.LenghtTextBox.Location = new System.Drawing.Point(731, 668);
            this.LenghtTextBox.Name = "LenghtTextBox";
            this.LenghtTextBox.Size = new System.Drawing.Size(256, 29);
            this.LenghtTextBox.TabIndex = 28;
            // 
            // colorBox
            // 
            this.colorBox.Controls.Add(this.redColorRadioButton);
            this.colorBox.Controls.Add(this.greenColorRadioButton);
            this.colorBox.Controls.Add(this.blueColorRadioButton);
            this.colorBox.Controls.Add(this.label4);
            this.colorBox.Location = new System.Drawing.Point(1181, 628);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(197, 99);
            this.colorBox.TabIndex = 27;
            this.colorBox.TabStop = false;
            // 
            // redColorRadioButton
            // 
            this.redColorRadioButton.AutoSize = true;
            this.redColorRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redColorRadioButton.ForeColor = System.Drawing.Color.Red;
            this.redColorRadioButton.Location = new System.Drawing.Point(6, 19);
            this.redColorRadioButton.Name = "redColorRadioButton";
            this.redColorRadioButton.Size = new System.Drawing.Size(52, 20);
            this.redColorRadioButton.TabIndex = 10;
            this.redColorRadioButton.TabStop = true;
            this.redColorRadioButton.Text = "Red";
            this.redColorRadioButton.UseVisualStyleBackColor = true;
            this.redColorRadioButton.CheckedChanged += new System.EventHandler(this.redColorRadioButton_CheckedChanged);
            // 
            // greenColorRadioButton
            // 
            this.greenColorRadioButton.AutoSize = true;
            this.greenColorRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greenColorRadioButton.ForeColor = System.Drawing.Color.Green;
            this.greenColorRadioButton.Location = new System.Drawing.Point(6, 45);
            this.greenColorRadioButton.Name = "greenColorRadioButton";
            this.greenColorRadioButton.Size = new System.Drawing.Size(63, 20);
            this.greenColorRadioButton.TabIndex = 11;
            this.greenColorRadioButton.TabStop = true;
            this.greenColorRadioButton.Text = "Green";
            this.greenColorRadioButton.UseVisualStyleBackColor = true;
            this.greenColorRadioButton.CheckedChanged += new System.EventHandler(this.greenColorRadioButton_CheckedChanged);
            // 
            // blueColorRadioButton
            // 
            this.blueColorRadioButton.AutoSize = true;
            this.blueColorRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blueColorRadioButton.ForeColor = System.Drawing.Color.Blue;
            this.blueColorRadioButton.Location = new System.Drawing.Point(6, 71);
            this.blueColorRadioButton.Name = "blueColorRadioButton";
            this.blueColorRadioButton.Size = new System.Drawing.Size(53, 20);
            this.blueColorRadioButton.TabIndex = 12;
            this.blueColorRadioButton.TabStop = true;
            this.blueColorRadioButton.Text = "Blue";
            this.blueColorRadioButton.UseVisualStyleBackColor = true;
            this.blueColorRadioButton.CheckedChanged += new System.EventHandler(this.blueColorRadioButton_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(-3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Цвет внедрения?";
            // 
            // langBox
            // 
            this.langBox.Controls.Add(this.russianLangRadioButton);
            this.langBox.Controls.Add(this.engLangRadioButton);
            this.langBox.Controls.Add(this.label7);
            this.langBox.Location = new System.Drawing.Point(1013, 649);
            this.langBox.Name = "langBox";
            this.langBox.Size = new System.Drawing.Size(151, 81);
            this.langBox.TabIndex = 26;
            this.langBox.TabStop = false;
            // 
            // russianLangRadioButton
            // 
            this.russianLangRadioButton.AutoSize = true;
            this.russianLangRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.russianLangRadioButton.Location = new System.Drawing.Point(6, 19);
            this.russianLangRadioButton.Name = "russianLangRadioButton";
            this.russianLangRadioButton.Size = new System.Drawing.Size(80, 20);
            this.russianLangRadioButton.TabIndex = 19;
            this.russianLangRadioButton.TabStop = true;
            this.russianLangRadioButton.Text = "Русский";
            this.russianLangRadioButton.UseVisualStyleBackColor = true;
            this.russianLangRadioButton.CheckedChanged += new System.EventHandler(this.russianLangRadioButton_CheckedChanged);
            // 
            // engLangRadioButton
            // 
            this.engLangRadioButton.AutoSize = true;
            this.engLangRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engLangRadioButton.Location = new System.Drawing.Point(6, 42);
            this.engLangRadioButton.Name = "engLangRadioButton";
            this.engLangRadioButton.Size = new System.Drawing.Size(103, 20);
            this.engLangRadioButton.TabIndex = 20;
            this.engLangRadioButton.TabStop = true;
            this.engLangRadioButton.Text = "Английский";
            this.engLangRadioButton.UseVisualStyleBackColor = true;
            this.engLangRadioButton.CheckedChanged += new System.EventHandler(this.engLangRadioButton_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(-3, -2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Выберите язык";
            // 
            // DecodeButton
            // 
            this.DecodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecodeButton.Location = new System.Drawing.Point(1217, 553);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(149, 48);
            this.DecodeButton.TabIndex = 9;
            this.DecodeButton.Text = "Декодировать";
            this.DecodeButton.UseVisualStyleBackColor = true;
            this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // EncodeButton
            // 
            this.EncodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncodeButton.Location = new System.Drawing.Point(497, 553);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(122, 49);
            this.EncodeButton.TabIndex = 8;
            this.EncodeButton.Text = "Закодировать";
            this.EncodeButton.UseVisualStyleBackColor = true;
            this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 626);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Сообщение(для зашифровки и при дешифровке):";
            // 
            // imgEncryptTextBox
            // 
            this.imgEncryptTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imgEncryptTextBox.Location = new System.Drawing.Point(20, 647);
            this.imgEncryptTextBox.Multiline = true;
            this.imgEncryptTextBox.Name = "imgEncryptTextBox";
            this.imgEncryptTextBox.Size = new System.Drawing.Size(599, 109);
            this.imgEncryptTextBox.TabIndex = 6;
            // 
            // OpenChangedImageButton
            // 
            this.OpenChangedImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenChangedImageButton.Location = new System.Drawing.Point(749, 552);
            this.OpenChangedImageButton.Name = "OpenChangedImageButton";
            this.OpenChangedImageButton.Size = new System.Drawing.Size(128, 49);
            this.OpenChangedImageButton.TabIndex = 5;
            this.OpenChangedImageButton.Text = "Открыть измененное";
            this.OpenChangedImageButton.UseVisualStyleBackColor = true;
            this.OpenChangedImageButton.Click += new System.EventHandler(this.OpenChangedImageButton_Click);
            // 
            // OpenOriginalImageButton
            // 
            this.OpenOriginalImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenOriginalImageButton.Location = new System.Drawing.Point(20, 552);
            this.OpenOriginalImageButton.Name = "OpenOriginalImageButton";
            this.OpenOriginalImageButton.Size = new System.Drawing.Size(115, 49);
            this.OpenOriginalImageButton.TabIndex = 4;
            this.OpenOriginalImageButton.Text = "Открыть оригинал";
            this.OpenOriginalImageButton.UseVisualStyleBackColor = true;
            this.OpenOriginalImageButton.Click += new System.EventHandler(this.OpenOriginalImageButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(745, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Измененное изображение:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Оригинальное изображение:";
            // 
            // encodedPictureBox
            // 
            this.encodedPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("encodedPictureBox.BackgroundImage")));
            this.encodedPictureBox.Location = new System.Drawing.Point(749, 33);
            this.encodedPictureBox.Name = "encodedPictureBox";
            this.encodedPictureBox.Size = new System.Drawing.Size(617, 513);
            this.encodedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.encodedPictureBox.TabIndex = 1;
            this.encodedPictureBox.TabStop = false;
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("originalPictureBox.BackgroundImage")));
            this.originalPictureBox.Location = new System.Drawing.Point(20, 33);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(599, 513);
            this.originalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.originalPictureBox.TabIndex = 0;
            this.originalPictureBox.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1387, 765);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AudioStego";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1387, 765);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "VideoStego";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // encryptTextBoxClearButton
            // 
            this.encryptTextBoxClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encryptTextBoxClearButton.Location = new System.Drawing.Point(626, 723);
            this.encryptTextBoxClearButton.Name = "encryptTextBoxClearButton";
            this.encryptTextBoxClearButton.Size = new System.Drawing.Size(93, 33);
            this.encryptTextBoxClearButton.TabIndex = 32;
            this.encryptTextBoxClearButton.Text = "Очистить";
            this.encryptTextBoxClearButton.UseVisualStyleBackColor = true;
            this.encryptTextBoxClearButton.Click += new System.EventHandler(this.encryptTextBoxClearButton_Click);
            // 
            // MultiStegoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 813);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MultiStegoForm";
            this.Text = "MultiStego";
            this.tabControl1.ResumeLayout(false);
            this.ImageStego.ResumeLayout(false);
            this.ImageStego.PerformLayout();
            this.colorBox.ResumeLayout(false);
            this.colorBox.PerformLayout();
            this.langBox.ResumeLayout(false);
            this.langBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encodedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ImageStego;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox encodedPictureBox;
        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenOriginalImageButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox imgEncryptTextBox;
        private System.Windows.Forms.Button OpenChangedImageButton;
        private System.Windows.Forms.Button DecodeButton;
        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.GroupBox colorBox;
        private System.Windows.Forms.RadioButton redColorRadioButton;
        private System.Windows.Forms.RadioButton greenColorRadioButton;
        private System.Windows.Forms.RadioButton blueColorRadioButton;
        private System.Windows.Forms.GroupBox langBox;
        private System.Windows.Forms.RadioButton russianLangRadioButton;
        private System.Windows.Forms.RadioButton engLangRadioButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LenghtTextBox;
        private System.Windows.Forms.TextBox modImgPath;
        private System.Windows.Forms.TextBox origImgPath;
        private System.Windows.Forms.Button encryptTextBoxClearButton;
    }
}

