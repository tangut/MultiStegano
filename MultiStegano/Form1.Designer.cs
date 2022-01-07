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
            this.encryptTextBoxClearButton = new System.Windows.Forms.Button();
            this.modImgPath = new System.Windows.Forms.TextBox();
            this.origImgPath = new System.Windows.Forms.TextBox();
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
            this.AudioStego = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.modBytesPerSecondTextBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.modBlockAllignTextBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.modFChunkSizeTextBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.modDataStartPosTextBox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.modDChunkSizeTextBox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.modBitPerSampleTextBox = new System.Windows.Forms.TextBox();
            this.modChannelsTextBox = new System.Windows.Forms.TextBox();
            this.modSampleTextBox = new System.Windows.Forms.TextBox();
            this.modAudioFileTextBox = new System.Windows.Forms.TextBox();
            this.modAudioFileButton = new System.Windows.Forms.Button();
            this.chooseModAudioButton = new System.Windows.Forms.Button();
            this.chooseOrigAudioButton = new System.Windows.Forms.Button();
            this.changesAudioTextBox = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.modAudioPathTextBox = new System.Windows.Forms.TextBox();
            this.origAudioPathTextBox = new System.Windows.Forms.TextBox();
            this.analyzeAudioChangesButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.origBytesPerSecondTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.origBlockAllignTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.origFChunkSizeTextBox = new System.Windows.Forms.TextBox();
            this.decryptAudioButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.decryptAudioTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.origDataStartPosTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.creationalAudioTextBox = new System.Windows.Forms.TextBox();
            this.encryptAudioButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.encryptAudioTextBox = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.origDChunkSizeTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.origBitPerSampleTextBox = new System.Windows.Forms.TextBox();
            this.origChannelsTextBox = new System.Windows.Forms.TextBox();
            this.origSampleTextBox = new System.Windows.Forms.TextBox();
            this.origAudioFileTextBox = new System.Windows.Forms.TextBox();
            this.origAudioFileButton = new System.Windows.Forms.Button();
            this.VideoStego = new System.Windows.Forms.TabPage();
            this.clearDecryptTextButton = new System.Windows.Forms.Button();
            this.decryptVideoButton = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.decryptVideoTextBox = new System.Windows.Forms.RichTextBox();
            this.clearEncryptVideoTextButton = new System.Windows.Forms.Button();
            this.encryptTextInVideoButton = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.encryptTextVideoTextBox = new System.Windows.Forms.RichTextBox();
            this.openModVideoFileButton = new System.Windows.Forms.Button();
            this.openOrigVideoFileButton = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.modVideoFileTextBox = new System.Windows.Forms.TextBox();
            this.origVideoFileTextBox = new System.Windows.Forms.TextBox();
            this.modVideoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.origVideoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.FileVideoStego = new System.Windows.Forms.TabPage();
            this.openModVideoFileButtonV2 = new System.Windows.Forms.Button();
            this.openOrigVideoFileButtonV2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.modVideoFileTextBoxVer2 = new System.Windows.Forms.TextBox();
            this.origVideoFileTextBoxVer2 = new System.Windows.Forms.TextBox();
            this.modVideoPlayerVer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.origVideoPlayerVer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.encrypFileVideoButton = new System.Windows.Forms.Button();
            this.decryptFileVideoButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.ImageStego.SuspendLayout();
            this.colorBox.SuspendLayout();
            this.langBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encodedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            this.AudioStego.SuspendLayout();
            this.VideoStego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modVideoPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.origVideoPlayer)).BeginInit();
            this.FileVideoStego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modVideoPlayerVer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.origVideoPlayerVer2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ImageStego);
            this.tabControl1.Controls.Add(this.AudioStego);
            this.tabControl1.Controls.Add(this.VideoStego);
            this.tabControl1.Controls.Add(this.FileVideoStego);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(-5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1401, 802);
            this.tabControl1.TabIndex = 0;
            // 
            // ImageStego
            // 
            this.ImageStego.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ImageStego.Controls.Add(this.encryptTextBoxClearButton);
            this.ImageStego.Controls.Add(this.modImgPath);
            this.ImageStego.Controls.Add(this.origImgPath);
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
            this.ImageStego.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImageStego.Location = new System.Drawing.Point(4, 33);
            this.ImageStego.Name = "ImageStego";
            this.ImageStego.Padding = new System.Windows.Forms.Padding(3);
            this.ImageStego.Size = new System.Drawing.Size(1393, 765);
            this.ImageStego.TabIndex = 0;
            this.ImageStego.Text = "Изображение";
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
            // modImgPath
            // 
            this.modImgPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modImgPath.Location = new System.Drawing.Point(791, 566);
            this.modImgPath.Name = "modImgPath";
            this.modImgPath.ReadOnly = true;
            this.modImgPath.Size = new System.Drawing.Size(316, 22);
            this.modImgPath.TabIndex = 31;
            this.modImgPath.Text = "Путь к измененному файлу";
            // 
            // origImgPath
            // 
            this.origImgPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.origImgPath.Location = new System.Drawing.Point(153, 559);
            this.origImgPath.Name = "origImgPath";
            this.origImgPath.ReadOnly = true;
            this.origImgPath.Size = new System.Drawing.Size(318, 22);
            this.origImgPath.TabIndex = 30;
            this.origImgPath.Text = "Путь к оригинальному файлу";
            // 
            // colorBox
            // 
            this.colorBox.Controls.Add(this.redColorRadioButton);
            this.colorBox.Controls.Add(this.greenColorRadioButton);
            this.colorBox.Controls.Add(this.blueColorRadioButton);
            this.colorBox.Controls.Add(this.label4);
            this.colorBox.Location = new System.Drawing.Point(1077, 647);
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
            this.redColorRadioButton.Location = new System.Drawing.Point(7, 22);
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
            this.langBox.Location = new System.Drawing.Point(852, 665);
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
            this.DecodeButton.Location = new System.Drawing.Point(1145, 552);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(129, 49);
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
            this.OpenChangedImageButton.Location = new System.Drawing.Point(657, 552);
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
            this.label2.Location = new System.Drawing.Point(653, 6);
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
            this.encodedPictureBox.BackgroundImage = global::MultiStegano.Properties.Resources.Мона_Лиза_стегано;
            this.encodedPictureBox.Location = new System.Drawing.Point(657, 33);
            this.encodedPictureBox.Name = "encodedPictureBox";
            this.encodedPictureBox.Size = new System.Drawing.Size(617, 513);
            this.encodedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.encodedPictureBox.TabIndex = 1;
            this.encodedPictureBox.TabStop = false;
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.BackgroundImage = global::MultiStegano.Properties.Resources.Мона_Лиза;
            this.originalPictureBox.Location = new System.Drawing.Point(20, 33);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(599, 513);
            this.originalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.originalPictureBox.TabIndex = 0;
            this.originalPictureBox.TabStop = false;
            // 
            // AudioStego
            // 
            this.AudioStego.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AudioStego.Controls.Add(this.label21);
            this.AudioStego.Controls.Add(this.modBytesPerSecondTextBox);
            this.AudioStego.Controls.Add(this.label22);
            this.AudioStego.Controls.Add(this.modBlockAllignTextBox);
            this.AudioStego.Controls.Add(this.label23);
            this.AudioStego.Controls.Add(this.modFChunkSizeTextBox);
            this.AudioStego.Controls.Add(this.label24);
            this.AudioStego.Controls.Add(this.modDataStartPosTextBox);
            this.AudioStego.Controls.Add(this.label25);
            this.AudioStego.Controls.Add(this.modDChunkSizeTextBox);
            this.AudioStego.Controls.Add(this.label26);
            this.AudioStego.Controls.Add(this.label27);
            this.AudioStego.Controls.Add(this.label28);
            this.AudioStego.Controls.Add(this.modBitPerSampleTextBox);
            this.AudioStego.Controls.Add(this.modChannelsTextBox);
            this.AudioStego.Controls.Add(this.modSampleTextBox);
            this.AudioStego.Controls.Add(this.modAudioFileTextBox);
            this.AudioStego.Controls.Add(this.modAudioFileButton);
            this.AudioStego.Controls.Add(this.chooseModAudioButton);
            this.AudioStego.Controls.Add(this.chooseOrigAudioButton);
            this.AudioStego.Controls.Add(this.changesAudioTextBox);
            this.AudioStego.Controls.Add(this.label13);
            this.AudioStego.Controls.Add(this.label12);
            this.AudioStego.Controls.Add(this.modAudioPathTextBox);
            this.AudioStego.Controls.Add(this.origAudioPathTextBox);
            this.AudioStego.Controls.Add(this.analyzeAudioChangesButton);
            this.AudioStego.Controls.Add(this.label11);
            this.AudioStego.Controls.Add(this.origBytesPerSecondTextBox);
            this.AudioStego.Controls.Add(this.label10);
            this.AudioStego.Controls.Add(this.origBlockAllignTextBox);
            this.AudioStego.Controls.Add(this.label9);
            this.AudioStego.Controls.Add(this.origFChunkSizeTextBox);
            this.AudioStego.Controls.Add(this.decryptAudioButton);
            this.AudioStego.Controls.Add(this.label8);
            this.AudioStego.Controls.Add(this.decryptAudioTextBox);
            this.AudioStego.Controls.Add(this.label6);
            this.AudioStego.Controls.Add(this.origDataStartPosTextBox);
            this.AudioStego.Controls.Add(this.label14);
            this.AudioStego.Controls.Add(this.creationalAudioTextBox);
            this.AudioStego.Controls.Add(this.encryptAudioButton);
            this.AudioStego.Controls.Add(this.label15);
            this.AudioStego.Controls.Add(this.encryptAudioTextBox);
            this.AudioStego.Controls.Add(this.label16);
            this.AudioStego.Controls.Add(this.origDChunkSizeTextBox);
            this.AudioStego.Controls.Add(this.label17);
            this.AudioStego.Controls.Add(this.label18);
            this.AudioStego.Controls.Add(this.label19);
            this.AudioStego.Controls.Add(this.origBitPerSampleTextBox);
            this.AudioStego.Controls.Add(this.origChannelsTextBox);
            this.AudioStego.Controls.Add(this.origSampleTextBox);
            this.AudioStego.Controls.Add(this.origAudioFileTextBox);
            this.AudioStego.Controls.Add(this.origAudioFileButton);
            this.AudioStego.Location = new System.Drawing.Point(4, 33);
            this.AudioStego.Name = "AudioStego";
            this.AudioStego.Padding = new System.Windows.Forms.Padding(3);
            this.AudioStego.Size = new System.Drawing.Size(1393, 765);
            this.AudioStego.TabIndex = 1;
            this.AudioStego.Text = "Аудио";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(755, 387);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(286, 20);
            this.label21.TabIndex = 87;
            this.label21.Text = "Распределение ОЗУ байт в секунду:";
            // 
            // modBytesPerSecondTextBox
            // 
            this.modBytesPerSecondTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modBytesPerSecondTextBox.Location = new System.Drawing.Point(1047, 387);
            this.modBytesPerSecondTextBox.Name = "modBytesPerSecondTextBox";
            this.modBytesPerSecondTextBox.ReadOnly = true;
            this.modBytesPerSecondTextBox.Size = new System.Drawing.Size(129, 21);
            this.modBytesPerSecondTextBox.TabIndex = 86;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(856, 341);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(179, 20);
            this.label22.TabIndex = 85;
            this.label22.Text = "Размер кадра сэмпла:";
            // 
            // modBlockAllignTextBox
            // 
            this.modBlockAllignTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modBlockAllignTextBox.Location = new System.Drawing.Point(1047, 338);
            this.modBlockAllignTextBox.Name = "modBlockAllignTextBox";
            this.modBlockAllignTextBox.ReadOnly = true;
            this.modBlockAllignTextBox.Size = new System.Drawing.Size(131, 21);
            this.modBlockAllignTextBox.TabIndex = 84;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(920, 294);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(115, 20);
            this.label23.TabIndex = 83;
            this.label23.Text = "ID data-части:";
            // 
            // modFChunkSizeTextBox
            // 
            this.modFChunkSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modFChunkSizeTextBox.Location = new System.Drawing.Point(1047, 291);
            this.modFChunkSizeTextBox.Name = "modFChunkSizeTextBox";
            this.modFChunkSizeTextBox.ReadOnly = true;
            this.modFChunkSizeTextBox.Size = new System.Drawing.Size(131, 21);
            this.modFChunkSizeTextBox.TabIndex = 82;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(798, 241);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(237, 20);
            this.label24.TabIndex = 81;
            this.label24.Text = "Байт начала области данных:";
            // 
            // modDataStartPosTextBox
            // 
            this.modDataStartPosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modDataStartPosTextBox.Location = new System.Drawing.Point(1047, 238);
            this.modDataStartPosTextBox.Name = "modDataStartPosTextBox";
            this.modDataStartPosTextBox.ReadOnly = true;
            this.modDataStartPosTextBox.Size = new System.Drawing.Size(131, 21);
            this.modDataStartPosTextBox.TabIndex = 80;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(846, 187);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(195, 20);
            this.label25.TabIndex = 79;
            this.label25.Text = "Байт в области данных: ";
            // 
            // modDChunkSizeTextBox
            // 
            this.modDChunkSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modDChunkSizeTextBox.Location = new System.Drawing.Point(1048, 187);
            this.modDChunkSizeTextBox.Name = "modDChunkSizeTextBox";
            this.modDChunkSizeTextBox.ReadOnly = true;
            this.modDChunkSizeTextBox.Size = new System.Drawing.Size(130, 21);
            this.modDChunkSizeTextBox.TabIndex = 78;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(908, 140);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(133, 20);
            this.label26.TabIndex = 77;
            this.label26.Text = "Битов в сэмпле:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(957, 101);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(78, 20);
            this.label27.TabIndex = 76;
            this.label27.Text = "Каналов:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.Location = new System.Drawing.Point(843, 59);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(198, 20);
            this.label28.TabIndex = 75;
            this.label28.Text = "Частота дискретизации:";
            // 
            // modBitPerSampleTextBox
            // 
            this.modBitPerSampleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modBitPerSampleTextBox.Location = new System.Drawing.Point(1049, 143);
            this.modBitPerSampleTextBox.Name = "modBitPerSampleTextBox";
            this.modBitPerSampleTextBox.ReadOnly = true;
            this.modBitPerSampleTextBox.Size = new System.Drawing.Size(129, 21);
            this.modBitPerSampleTextBox.TabIndex = 74;
            // 
            // modChannelsTextBox
            // 
            this.modChannelsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modChannelsTextBox.Location = new System.Drawing.Point(1049, 101);
            this.modChannelsTextBox.Name = "modChannelsTextBox";
            this.modChannelsTextBox.ReadOnly = true;
            this.modChannelsTextBox.Size = new System.Drawing.Size(130, 21);
            this.modChannelsTextBox.TabIndex = 73;
            // 
            // modSampleTextBox
            // 
            this.modSampleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modSampleTextBox.Location = new System.Drawing.Point(1049, 57);
            this.modSampleTextBox.Name = "modSampleTextBox";
            this.modSampleTextBox.ReadOnly = true;
            this.modSampleTextBox.Size = new System.Drawing.Size(131, 21);
            this.modSampleTextBox.TabIndex = 72;
            // 
            // modAudioFileTextBox
            // 
            this.modAudioFileTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modAudioFileTextBox.Location = new System.Drawing.Point(612, 113);
            this.modAudioFileTextBox.Name = "modAudioFileTextBox";
            this.modAudioFileTextBox.ReadOnly = true;
            this.modAudioFileTextBox.Size = new System.Drawing.Size(242, 21);
            this.modAudioFileTextBox.TabIndex = 71;
            // 
            // modAudioFileButton
            // 
            this.modAudioFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modAudioFileButton.Location = new System.Drawing.Point(654, 40);
            this.modAudioFileButton.Name = "modAudioFileButton";
            this.modAudioFileButton.Size = new System.Drawing.Size(163, 57);
            this.modAudioFileButton.TabIndex = 70;
            this.modAudioFileButton.Text = "Открыть измененный файл";
            this.modAudioFileButton.UseVisualStyleBackColor = true;
            this.modAudioFileButton.Click += new System.EventHandler(this.modAudioFileButton_Click);
            // 
            // chooseModAudioButton
            // 
            this.chooseModAudioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseModAudioButton.Location = new System.Drawing.Point(453, 649);
            this.chooseModAudioButton.Name = "chooseModAudioButton";
            this.chooseModAudioButton.Size = new System.Drawing.Size(133, 56);
            this.chooseModAudioButton.TabIndex = 69;
            this.chooseModAudioButton.Text = "Выбрать измененный файл";
            this.chooseModAudioButton.UseVisualStyleBackColor = true;
            this.chooseModAudioButton.Click += new System.EventHandler(this.chooseModAudioButton_Click);
            // 
            // chooseOrigAudioButton
            // 
            this.chooseOrigAudioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseOrigAudioButton.Location = new System.Drawing.Point(453, 570);
            this.chooseOrigAudioButton.Name = "chooseOrigAudioButton";
            this.chooseOrigAudioButton.Size = new System.Drawing.Size(133, 57);
            this.chooseOrigAudioButton.TabIndex = 68;
            this.chooseOrigAudioButton.Text = "Выбрать оригинальный файл";
            this.chooseOrigAudioButton.UseVisualStyleBackColor = true;
            this.chooseOrigAudioButton.Click += new System.EventHandler(this.chooseOrigAudioButton_Click);
            // 
            // changesAudioTextBox
            // 
            this.changesAudioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changesAudioTextBox.Location = new System.Drawing.Point(592, 554);
            this.changesAudioTextBox.Name = "changesAudioTextBox";
            this.changesAudioTextBox.ReadOnly = true;
            this.changesAudioTextBox.Size = new System.Drawing.Size(349, 151);
            this.changesAudioTextBox.TabIndex = 67;
            this.changesAudioTextBox.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(519, 528);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 20);
            this.label13.TabIndex = 66;
            this.label13.Text = "Измененный файл:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(502, 496);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 20);
            this.label12.TabIndex = 65;
            this.label12.Text = "Оригинальный файл:";
            // 
            // modAudioPathTextBox
            // 
            this.modAudioPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modAudioPathTextBox.Location = new System.Drawing.Point(680, 522);
            this.modAudioPathTextBox.Name = "modAudioPathTextBox";
            this.modAudioPathTextBox.ReadOnly = true;
            this.modAudioPathTextBox.Size = new System.Drawing.Size(234, 21);
            this.modAudioPathTextBox.TabIndex = 64;
            // 
            // origAudioPathTextBox
            // 
            this.origAudioPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.origAudioPathTextBox.Location = new System.Drawing.Point(680, 487);
            this.origAudioPathTextBox.Name = "origAudioPathTextBox";
            this.origAudioPathTextBox.ReadOnly = true;
            this.origAudioPathTextBox.Size = new System.Drawing.Size(234, 21);
            this.origAudioPathTextBox.TabIndex = 63;
            // 
            // analyzeAudioChangesButton
            // 
            this.analyzeAudioChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.analyzeAudioChangesButton.Location = new System.Drawing.Point(680, 711);
            this.analyzeAudioChangesButton.Name = "analyzeAudioChangesButton";
            this.analyzeAudioChangesButton.Size = new System.Drawing.Size(174, 34);
            this.analyzeAudioChangesButton.TabIndex = 62;
            this.analyzeAudioChangesButton.Text = "Проанализировать изменения";
            this.analyzeAudioChangesButton.UseVisualStyleBackColor = true;
            this.analyzeAudioChangesButton.Click += new System.EventHandler(this.analyzeAudioChangesButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(138, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(286, 20);
            this.label11.TabIndex = 61;
            this.label11.Text = "Распределение ОЗУ байт в секунду:";
            // 
            // origBytesPerSecondTextBox
            // 
            this.origBytesPerSecondTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.origBytesPerSecondTextBox.Location = new System.Drawing.Point(428, 387);
            this.origBytesPerSecondTextBox.Name = "origBytesPerSecondTextBox";
            this.origBytesPerSecondTextBox.ReadOnly = true;
            this.origBytesPerSecondTextBox.Size = new System.Drawing.Size(129, 21);
            this.origBytesPerSecondTextBox.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(239, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 20);
            this.label10.TabIndex = 59;
            this.label10.Text = "Размер кадра сэмпла:";
            // 
            // origBlockAllignTextBox
            // 
            this.origBlockAllignTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.origBlockAllignTextBox.Location = new System.Drawing.Point(428, 338);
            this.origBlockAllignTextBox.Name = "origBlockAllignTextBox";
            this.origBlockAllignTextBox.ReadOnly = true;
            this.origBlockAllignTextBox.Size = new System.Drawing.Size(131, 21);
            this.origBlockAllignTextBox.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(303, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "ID data-части:";
            // 
            // origFChunkSizeTextBox
            // 
            this.origFChunkSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.origFChunkSizeTextBox.Location = new System.Drawing.Point(428, 291);
            this.origFChunkSizeTextBox.Name = "origFChunkSizeTextBox";
            this.origFChunkSizeTextBox.ReadOnly = true;
            this.origFChunkSizeTextBox.Size = new System.Drawing.Size(131, 21);
            this.origFChunkSizeTextBox.TabIndex = 56;
            // 
            // decryptAudioButton
            // 
            this.decryptAudioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decryptAudioButton.Location = new System.Drawing.Point(1078, 692);
            this.decryptAudioButton.Name = "decryptAudioButton";
            this.decryptAudioButton.Size = new System.Drawing.Size(147, 54);
            this.decryptAudioButton.TabIndex = 55;
            this.decryptAudioButton.Text = "Расшифровать";
            this.decryptAudioButton.UseVisualStyleBackColor = true;
            this.decryptAudioButton.Click += new System.EventHandler(this.decryptAudioButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(978, 543);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "Расшифрованный текст:";
            // 
            // decryptAudioTextBox
            // 
            this.decryptAudioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decryptAudioTextBox.Location = new System.Drawing.Point(982, 570);
            this.decryptAudioTextBox.Name = "decryptAudioTextBox";
            this.decryptAudioTextBox.ReadOnly = true;
            this.decryptAudioTextBox.Size = new System.Drawing.Size(317, 119);
            this.decryptAudioTextBox.TabIndex = 53;
            this.decryptAudioTextBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(181, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Байт начала области данных:";
            // 
            // origDataStartPosTextBox
            // 
            this.origDataStartPosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.origDataStartPosTextBox.Location = new System.Drawing.Point(428, 238);
            this.origDataStartPosTextBox.Name = "origDataStartPosTextBox";
            this.origDataStartPosTextBox.ReadOnly = true;
            this.origDataStartPosTextBox.Size = new System.Drawing.Size(131, 21);
            this.origDataStartPosTextBox.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(169, 671);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(212, 20);
            this.label14.TabIndex = 50;
            this.label14.Text = "Имя создаваемого файла:";
            // 
            // creationalAudioTextBox
            // 
            this.creationalAudioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creationalAudioTextBox.Location = new System.Drawing.Point(169, 694);
            this.creationalAudioTextBox.Name = "creationalAudioTextBox";
            this.creationalAudioTextBox.ReadOnly = true;
            this.creationalAudioTextBox.Size = new System.Drawing.Size(264, 21);
            this.creationalAudioTextBox.TabIndex = 49;
            // 
            // encryptAudioButton
            // 
            this.encryptAudioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encryptAudioButton.Location = new System.Drawing.Point(20, 667);
            this.encryptAudioButton.Name = "encryptAudioButton";
            this.encryptAudioButton.Size = new System.Drawing.Size(143, 54);
            this.encryptAudioButton.TabIndex = 48;
            this.encryptAudioButton.Text = "Зашифровать";
            this.encryptAudioButton.UseVisualStyleBackColor = true;
            this.encryptAudioButton.Click += new System.EventHandler(this.encryptAudioButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(16, 516);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(263, 20);
            this.label15.TabIndex = 47;
            this.label15.Text = "Введите текст для зашифровки:";
            // 
            // encryptAudioTextBox
            // 
            this.encryptAudioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encryptAudioTextBox.Location = new System.Drawing.Point(20, 539);
            this.encryptAudioTextBox.Name = "encryptAudioTextBox";
            this.encryptAudioTextBox.Size = new System.Drawing.Size(309, 119);
            this.encryptAudioTextBox.TabIndex = 46;
            this.encryptAudioTextBox.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(229, 193);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(195, 20);
            this.label16.TabIndex = 45;
            this.label16.Text = "Байт в области данных: ";
            // 
            // origDChunkSizeTextBox
            // 
            this.origDChunkSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.origDChunkSizeTextBox.Location = new System.Drawing.Point(429, 187);
            this.origDChunkSizeTextBox.Name = "origDChunkSizeTextBox";
            this.origDChunkSizeTextBox.ReadOnly = true;
            this.origDChunkSizeTextBox.Size = new System.Drawing.Size(130, 21);
            this.origDChunkSizeTextBox.TabIndex = 44;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(291, 146);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 20);
            this.label17.TabIndex = 43;
            this.label17.Text = "Битов в сэмпле:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(346, 107);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 20);
            this.label18.TabIndex = 42;
            this.label18.Text = "Каналов:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(226, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(198, 20);
            this.label19.TabIndex = 41;
            this.label19.Text = "Частота дискретизации:";
            // 
            // origBitPerSampleTextBox
            // 
            this.origBitPerSampleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.origBitPerSampleTextBox.Location = new System.Drawing.Point(430, 143);
            this.origBitPerSampleTextBox.Name = "origBitPerSampleTextBox";
            this.origBitPerSampleTextBox.ReadOnly = true;
            this.origBitPerSampleTextBox.Size = new System.Drawing.Size(129, 21);
            this.origBitPerSampleTextBox.TabIndex = 40;
            // 
            // origChannelsTextBox
            // 
            this.origChannelsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.origChannelsTextBox.Location = new System.Drawing.Point(430, 101);
            this.origChannelsTextBox.Name = "origChannelsTextBox";
            this.origChannelsTextBox.ReadOnly = true;
            this.origChannelsTextBox.Size = new System.Drawing.Size(130, 21);
            this.origChannelsTextBox.TabIndex = 39;
            // 
            // origSampleTextBox
            // 
            this.origSampleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.origSampleTextBox.Location = new System.Drawing.Point(430, 57);
            this.origSampleTextBox.Name = "origSampleTextBox";
            this.origSampleTextBox.ReadOnly = true;
            this.origSampleTextBox.Size = new System.Drawing.Size(131, 21);
            this.origSampleTextBox.TabIndex = 38;
            // 
            // origAudioFileTextBox
            // 
            this.origAudioFileTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.origAudioFileTextBox.Location = new System.Drawing.Point(20, 113);
            this.origAudioFileTextBox.Name = "origAudioFileTextBox";
            this.origAudioFileTextBox.ReadOnly = true;
            this.origAudioFileTextBox.Size = new System.Drawing.Size(247, 21);
            this.origAudioFileTextBox.TabIndex = 37;
            // 
            // origAudioFileButton
            // 
            this.origAudioFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.origAudioFileButton.Location = new System.Drawing.Point(20, 50);
            this.origAudioFileButton.Name = "origAudioFileButton";
            this.origAudioFileButton.Size = new System.Drawing.Size(163, 57);
            this.origAudioFileButton.TabIndex = 36;
            this.origAudioFileButton.Text = "Открыть оригинальный файл";
            this.origAudioFileButton.UseVisualStyleBackColor = true;
            this.origAudioFileButton.Click += new System.EventHandler(this.origAudioFileButton_Click);
            // 
            // VideoStego
            // 
            this.VideoStego.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.VideoStego.Controls.Add(this.clearDecryptTextButton);
            this.VideoStego.Controls.Add(this.decryptVideoButton);
            this.VideoStego.Controls.Add(this.label34);
            this.VideoStego.Controls.Add(this.decryptVideoTextBox);
            this.VideoStego.Controls.Add(this.clearEncryptVideoTextButton);
            this.VideoStego.Controls.Add(this.encryptTextInVideoButton);
            this.VideoStego.Controls.Add(this.label33);
            this.VideoStego.Controls.Add(this.encryptTextVideoTextBox);
            this.VideoStego.Controls.Add(this.openModVideoFileButton);
            this.VideoStego.Controls.Add(this.openOrigVideoFileButton);
            this.VideoStego.Controls.Add(this.label32);
            this.VideoStego.Controls.Add(this.label31);
            this.VideoStego.Controls.Add(this.label30);
            this.VideoStego.Controls.Add(this.label29);
            this.VideoStego.Controls.Add(this.modVideoFileTextBox);
            this.VideoStego.Controls.Add(this.origVideoFileTextBox);
            this.VideoStego.Controls.Add(this.modVideoPlayer);
            this.VideoStego.Controls.Add(this.origVideoPlayer);
            this.VideoStego.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VideoStego.Location = new System.Drawing.Point(4, 33);
            this.VideoStego.Name = "VideoStego";
            this.VideoStego.Padding = new System.Windows.Forms.Padding(3);
            this.VideoStego.Size = new System.Drawing.Size(1393, 765);
            this.VideoStego.TabIndex = 2;
            this.VideoStego.Text = "Видео";
            // 
            // clearDecryptTextButton
            // 
            this.clearDecryptTextButton.Location = new System.Drawing.Point(1205, 676);
            this.clearDecryptTextButton.Name = "clearDecryptTextButton";
            this.clearDecryptTextButton.Size = new System.Drawing.Size(103, 49);
            this.clearDecryptTextButton.TabIndex = 17;
            this.clearDecryptTextButton.Text = "Очистить";
            this.clearDecryptTextButton.UseVisualStyleBackColor = true;
            this.clearDecryptTextButton.Click += new System.EventHandler(this.clearDecryptTextButton_Click_1);
            // 
            // decryptVideoButton
            // 
            this.decryptVideoButton.Location = new System.Drawing.Point(1205, 518);
            this.decryptVideoButton.Name = "decryptVideoButton";
            this.decryptVideoButton.Size = new System.Drawing.Size(103, 49);
            this.decryptVideoButton.TabIndex = 16;
            this.decryptVideoButton.Text = "Извлечь сообщение";
            this.decryptVideoButton.UseVisualStyleBackColor = true;
            this.decryptVideoButton.Click += new System.EventHandler(this.decryptVideoButton_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(674, 499);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(198, 16);
            this.label34.TabIndex = 15;
            this.label34.Text = "Извлеченное сообщение:";
            // 
            // decryptVideoTextBox
            // 
            this.decryptVideoTextBox.Location = new System.Drawing.Point(674, 518);
            this.decryptVideoTextBox.Name = "decryptVideoTextBox";
            this.decryptVideoTextBox.ReadOnly = true;
            this.decryptVideoTextBox.Size = new System.Drawing.Size(525, 207);
            this.decryptVideoTextBox.TabIndex = 14;
            this.decryptVideoTextBox.Text = "";
            // 
            // clearEncryptVideoTextButton
            // 
            this.clearEncryptVideoTextButton.Location = new System.Drawing.Point(510, 676);
            this.clearEncryptVideoTextButton.Name = "clearEncryptVideoTextButton";
            this.clearEncryptVideoTextButton.Size = new System.Drawing.Size(124, 49);
            this.clearEncryptVideoTextButton.TabIndex = 13;
            this.clearEncryptVideoTextButton.Text = "Очистить";
            this.clearEncryptVideoTextButton.UseVisualStyleBackColor = true;
            this.clearEncryptVideoTextButton.Click += new System.EventHandler(this.clearEncryptVideoTextButton_Click);
            // 
            // encryptTextInVideoButton
            // 
            this.encryptTextInVideoButton.Location = new System.Drawing.Point(510, 511);
            this.encryptTextInVideoButton.Name = "encryptTextInVideoButton";
            this.encryptTextInVideoButton.Size = new System.Drawing.Size(124, 49);
            this.encryptTextInVideoButton.TabIndex = 12;
            this.encryptTextInVideoButton.Text = "Внедрить";
            this.encryptTextInVideoButton.UseVisualStyleBackColor = true;
            this.encryptTextInVideoButton.Click += new System.EventHandler(this.encryptTextInVideoButton_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(25, 492);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(278, 16);
            this.label33.TabIndex = 11;
            this.label33.Text = "Введите сообщение для внедрения: ";
            // 
            // encryptTextVideoTextBox
            // 
            this.encryptTextVideoTextBox.Location = new System.Drawing.Point(28, 511);
            this.encryptTextVideoTextBox.Name = "encryptTextVideoTextBox";
            this.encryptTextVideoTextBox.Size = new System.Drawing.Size(476, 214);
            this.encryptTextVideoTextBox.TabIndex = 10;
            this.encryptTextVideoTextBox.Text = "";
            // 
            // openModVideoFileButton
            // 
            this.openModVideoFileButton.Location = new System.Drawing.Point(717, 386);
            this.openModVideoFileButton.Name = "openModVideoFileButton";
            this.openModVideoFileButton.Size = new System.Drawing.Size(126, 59);
            this.openModVideoFileButton.TabIndex = 9;
            this.openModVideoFileButton.Text = "Открыть измененный файл";
            this.openModVideoFileButton.UseVisualStyleBackColor = true;
            this.openModVideoFileButton.Click += new System.EventHandler(this.openModVideoFileButton_Click);
            // 
            // openOrigVideoFileButton
            // 
            this.openOrigVideoFileButton.Location = new System.Drawing.Point(28, 386);
            this.openOrigVideoFileButton.Name = "openOrigVideoFileButton";
            this.openOrigVideoFileButton.Size = new System.Drawing.Size(123, 59);
            this.openOrigVideoFileButton.TabIndex = 8;
            this.openOrigVideoFileButton.Text = "Открыть оригинальный файл";
            this.openOrigVideoFileButton.UseVisualStyleBackColor = true;
            this.openOrigVideoFileButton.Click += new System.EventHandler(this.openOrigVideoFileButton_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label32.Location = new System.Drawing.Point(713, 350);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(116, 20);
            this.label32.TabIndex = 7;
            this.label32.Text = "Путь к файлу:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.Location = new System.Drawing.Point(23, 343);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(116, 20);
            this.label31.TabIndex = 6;
            this.label31.Text = "Путь к файлу:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(714, 22);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(154, 16);
            this.label30.TabIndex = 5;
            this.label30.Text = "Измененное видео:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(24, 22);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(168, 16);
            this.label29.TabIndex = 4;
            this.label29.Text = "Оригинальное видео:";
            // 
            // modVideoFileTextBox
            // 
            this.modVideoFileTextBox.Location = new System.Drawing.Point(835, 350);
            this.modVideoFileTextBox.Name = "modVideoFileTextBox";
            this.modVideoFileTextBox.ReadOnly = true;
            this.modVideoFileTextBox.Size = new System.Drawing.Size(302, 22);
            this.modVideoFileTextBox.TabIndex = 3;
            // 
            // origVideoFileTextBox
            // 
            this.origVideoFileTextBox.Location = new System.Drawing.Point(145, 341);
            this.origVideoFileTextBox.Name = "origVideoFileTextBox";
            this.origVideoFileTextBox.ReadOnly = true;
            this.origVideoFileTextBox.Size = new System.Drawing.Size(288, 22);
            this.origVideoFileTextBox.TabIndex = 2;
            // 
            // modVideoPlayer
            // 
            this.modVideoPlayer.Enabled = true;
            this.modVideoPlayer.Location = new System.Drawing.Point(717, 41);
            this.modVideoPlayer.Name = "modVideoPlayer";
            this.modVideoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("modVideoPlayer.OcxState")));
            this.modVideoPlayer.Size = new System.Drawing.Size(457, 294);
            this.modVideoPlayer.TabIndex = 1;
            // 
            // origVideoPlayer
            // 
            this.origVideoPlayer.Enabled = true;
            this.origVideoPlayer.Location = new System.Drawing.Point(28, 41);
            this.origVideoPlayer.Name = "origVideoPlayer";
            this.origVideoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("origVideoPlayer.OcxState")));
            this.origVideoPlayer.Size = new System.Drawing.Size(424, 294);
            this.origVideoPlayer.TabIndex = 0;
            // 
            // FileVideoStego
            // 
            this.FileVideoStego.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FileVideoStego.Controls.Add(this.decryptFileVideoButton);
            this.FileVideoStego.Controls.Add(this.encrypFileVideoButton);
            this.FileVideoStego.Controls.Add(this.openModVideoFileButtonV2);
            this.FileVideoStego.Controls.Add(this.openOrigVideoFileButtonV2);
            this.FileVideoStego.Controls.Add(this.label5);
            this.FileVideoStego.Controls.Add(this.label20);
            this.FileVideoStego.Controls.Add(this.label35);
            this.FileVideoStego.Controls.Add(this.label36);
            this.FileVideoStego.Controls.Add(this.modVideoFileTextBoxVer2);
            this.FileVideoStego.Controls.Add(this.origVideoFileTextBoxVer2);
            this.FileVideoStego.Controls.Add(this.modVideoPlayerVer2);
            this.FileVideoStego.Controls.Add(this.origVideoPlayerVer2);
            this.FileVideoStego.Location = new System.Drawing.Point(4, 33);
            this.FileVideoStego.Name = "FileVideoStego";
            this.FileVideoStego.Size = new System.Drawing.Size(1393, 765);
            this.FileVideoStego.TabIndex = 3;
            this.FileVideoStego.Text = "Файл в видео";
            // 
            // openModVideoFileButtonV2
            // 
            this.openModVideoFileButtonV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openModVideoFileButtonV2.Location = new System.Drawing.Point(764, 500);
            this.openModVideoFileButtonV2.Name = "openModVideoFileButtonV2";
            this.openModVideoFileButtonV2.Size = new System.Drawing.Size(126, 59);
            this.openModVideoFileButtonV2.TabIndex = 19;
            this.openModVideoFileButtonV2.Text = "Открыть измененный файл";
            this.openModVideoFileButtonV2.UseVisualStyleBackColor = true;
            this.openModVideoFileButtonV2.Click += new System.EventHandler(this.openModVideoFileButtonV2_Click);
            // 
            // openOrigVideoFileButtonV2
            // 
            this.openOrigVideoFileButtonV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openOrigVideoFileButtonV2.Location = new System.Drawing.Point(75, 500);
            this.openOrigVideoFileButtonV2.Name = "openOrigVideoFileButtonV2";
            this.openOrigVideoFileButtonV2.Size = new System.Drawing.Size(123, 59);
            this.openOrigVideoFileButtonV2.TabIndex = 18;
            this.openOrigVideoFileButtonV2.Text = "Открыть оригинальный файл";
            this.openOrigVideoFileButtonV2.UseVisualStyleBackColor = true;
            this.openOrigVideoFileButtonV2.Click += new System.EventHandler(this.openOrigVideoFileButtonV2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(760, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Путь к файлу:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(70, 457);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(116, 20);
            this.label20.TabIndex = 16;
            this.label20.Text = "Путь к файлу:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label35.Location = new System.Drawing.Point(761, 136);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(154, 16);
            this.label35.TabIndex = 15;
            this.label35.Text = "Измененное видео:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label36.Location = new System.Drawing.Point(71, 136);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(168, 16);
            this.label36.TabIndex = 14;
            this.label36.Text = "Оригинальное видео:";
            // 
            // modVideoFileTextBoxVer2
            // 
            this.modVideoFileTextBoxVer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modVideoFileTextBoxVer2.Location = new System.Drawing.Point(882, 464);
            this.modVideoFileTextBoxVer2.Name = "modVideoFileTextBoxVer2";
            this.modVideoFileTextBoxVer2.ReadOnly = true;
            this.modVideoFileTextBoxVer2.Size = new System.Drawing.Size(302, 22);
            this.modVideoFileTextBoxVer2.TabIndex = 13;
            // 
            // origVideoFileTextBoxVer2
            // 
            this.origVideoFileTextBoxVer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.origVideoFileTextBoxVer2.Location = new System.Drawing.Point(192, 455);
            this.origVideoFileTextBoxVer2.Name = "origVideoFileTextBoxVer2";
            this.origVideoFileTextBoxVer2.ReadOnly = true;
            this.origVideoFileTextBoxVer2.Size = new System.Drawing.Size(288, 22);
            this.origVideoFileTextBoxVer2.TabIndex = 12;
            // 
            // modVideoPlayerVer2
            // 
            this.modVideoPlayerVer2.Enabled = true;
            this.modVideoPlayerVer2.Location = new System.Drawing.Point(764, 155);
            this.modVideoPlayerVer2.Name = "modVideoPlayerVer2";
            this.modVideoPlayerVer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("modVideoPlayerVer2.OcxState")));
            this.modVideoPlayerVer2.Size = new System.Drawing.Size(457, 294);
            this.modVideoPlayerVer2.TabIndex = 11;
            // 
            // origVideoPlayerVer2
            // 
            this.origVideoPlayerVer2.Enabled = true;
            this.origVideoPlayerVer2.Location = new System.Drawing.Point(75, 155);
            this.origVideoPlayerVer2.Name = "origVideoPlayerVer2";
            this.origVideoPlayerVer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("origVideoPlayerVer2.OcxState")));
            this.origVideoPlayerVer2.Size = new System.Drawing.Size(424, 294);
            this.origVideoPlayerVer2.TabIndex = 10;
            // 
            // encrypFileVideoButton
            // 
            this.encrypFileVideoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encrypFileVideoButton.Location = new System.Drawing.Point(359, 500);
            this.encrypFileVideoButton.Name = "encrypFileVideoButton";
            this.encrypFileVideoButton.Size = new System.Drawing.Size(140, 59);
            this.encrypFileVideoButton.TabIndex = 20;
            this.encrypFileVideoButton.Text = "Внедрить файл";
            this.encrypFileVideoButton.UseVisualStyleBackColor = true;
            this.encrypFileVideoButton.Click += new System.EventHandler(this.encrypFileVideoButton_Click);
            // 
            // decryptFileVideoButton
            // 
            this.decryptFileVideoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decryptFileVideoButton.Location = new System.Drawing.Point(1081, 500);
            this.decryptFileVideoButton.Name = "decryptFileVideoButton";
            this.decryptFileVideoButton.Size = new System.Drawing.Size(140, 59);
            this.decryptFileVideoButton.TabIndex = 21;
            this.decryptFileVideoButton.Text = "Извлечь файл";
            this.decryptFileVideoButton.UseVisualStyleBackColor = true;
            this.decryptFileVideoButton.Click += new System.EventHandler(this.decryptFileVideoButton_Click);
            // 
            // MultiStegoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1316, 796);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MultiStegoForm";
            this.Text = "Стеганография в мультимедийных файлах";
            this.tabControl1.ResumeLayout(false);
            this.ImageStego.ResumeLayout(false);
            this.ImageStego.PerformLayout();
            this.colorBox.ResumeLayout(false);
            this.colorBox.PerformLayout();
            this.langBox.ResumeLayout(false);
            this.langBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encodedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            this.AudioStego.ResumeLayout(false);
            this.AudioStego.PerformLayout();
            this.VideoStego.ResumeLayout(false);
            this.VideoStego.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modVideoPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.origVideoPlayer)).EndInit();
            this.FileVideoStego.ResumeLayout(false);
            this.FileVideoStego.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modVideoPlayerVer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.origVideoPlayerVer2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ImageStego;
        private System.Windows.Forms.TabPage AudioStego;
        private System.Windows.Forms.TabPage VideoStego;
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
        private System.Windows.Forms.TextBox modImgPath;
        private System.Windows.Forms.TextBox origImgPath;
        private System.Windows.Forms.Button encryptTextBoxClearButton;
        private System.Windows.Forms.Button chooseModAudioButton;
        private System.Windows.Forms.Button chooseOrigAudioButton;
        private System.Windows.Forms.RichTextBox changesAudioTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox modAudioPathTextBox;
        private System.Windows.Forms.TextBox origAudioPathTextBox;
        private System.Windows.Forms.Button analyzeAudioChangesButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox origBytesPerSecondTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox origBlockAllignTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox origFChunkSizeTextBox;
        private System.Windows.Forms.Button decryptAudioButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox decryptAudioTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox origDataStartPosTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox creationalAudioTextBox;
        private System.Windows.Forms.Button encryptAudioButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox encryptAudioTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox origDChunkSizeTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox origBitPerSampleTextBox;
        private System.Windows.Forms.TextBox origChannelsTextBox;
        private System.Windows.Forms.TextBox origSampleTextBox;
        private System.Windows.Forms.TextBox origAudioFileTextBox;
        private System.Windows.Forms.Button origAudioFileButton;
        private AxWMPLib.AxWindowsMediaPlayer origVideoPlayer;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox modBytesPerSecondTextBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox modBlockAllignTextBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox modFChunkSizeTextBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox modDataStartPosTextBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox modDChunkSizeTextBox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox modBitPerSampleTextBox;
        private System.Windows.Forms.TextBox modChannelsTextBox;
        private System.Windows.Forms.TextBox modSampleTextBox;
        private System.Windows.Forms.TextBox modAudioFileTextBox;
        private System.Windows.Forms.Button modAudioFileButton;
        private AxWMPLib.AxWindowsMediaPlayer modVideoPlayer;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox modVideoFileTextBox;
        private System.Windows.Forms.TextBox origVideoFileTextBox;
        private System.Windows.Forms.Button openModVideoFileButton;
        private System.Windows.Forms.Button openOrigVideoFileButton;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.RichTextBox encryptTextVideoTextBox;
        private System.Windows.Forms.Button clearEncryptVideoTextButton;
        private System.Windows.Forms.Button encryptTextInVideoButton;
        private System.Windows.Forms.Button decryptVideoButton;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.RichTextBox decryptVideoTextBox;
        private System.Windows.Forms.Button clearDecryptTextButton;
        private System.Windows.Forms.TabPage FileVideoStego;
        private System.Windows.Forms.Button openModVideoFileButtonV2;
        private System.Windows.Forms.Button openOrigVideoFileButtonV2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox modVideoFileTextBoxVer2;
        private System.Windows.Forms.TextBox origVideoFileTextBoxVer2;
        private AxWMPLib.AxWindowsMediaPlayer modVideoPlayerVer2;
        private AxWMPLib.AxWindowsMediaPlayer origVideoPlayerVer2;
        private System.Windows.Forms.Button decryptFileVideoButton;
        private System.Windows.Forms.Button encrypFileVideoButton;
    }
}

