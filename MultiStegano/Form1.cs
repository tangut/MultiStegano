﻿using MultiStegano.Entities;
using MultiStegano.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiStegano
{
    public partial class MultiStegoForm : Form
    {

        public MultiStegoForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        #region Image steganography

        private void OpenOriginalImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.PNG)|*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                originalPictureBox.ImageLocation = dialog.FileName.ToString();
                origImgPath.Text = dialog.FileName.ToString();
            }
        }

        private void OpenChangedImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.PNG)|*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                encodedPictureBox.ImageLocation = dialog.FileName.ToString();
                modImgPath.Text = dialog.FileName.ToString();
            }
        }

        // внедрение цвета сообщения
        private void redColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton redColorRadioButton = (RadioButton)sender;
        }

        private void greenColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton greenColorRadioButton = (RadioButton)sender;
        }

        private void blueColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton blueColorRadioButton = (RadioButton)sender;
        }

        // выбор языка
        private void russianLangRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton russianLangRadioButton = (RadioButton)sender;
        }

        private void engLangRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton engLangRadioButton = (RadioButton)sender;
        }

        // кодирование изображения
        private void EncodeButton_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (origImgPath.Text == "Путь к оригинальному файлу" || origImgPath.Text == "")
                {
                    MessageBox.Show("Сначала нужно выбрать изображение.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                if (imgEncryptTextBox.Text == "")
                {
                    MessageBox.Show("Сначала нужно ввести текст для внедрения.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                if (!(redColorRadioButton.Checked || greenColorRadioButton.Checked || blueColorRadioButton.Checked))
                {
                    MessageBox.Show("Сначала выберите цвет для внедрения.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                if (!(russianLangRadioButton.Checked || engLangRadioButton.Checked))
                {
                    MessageBox.Show("Сначала выберите язык сообщения.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                Colors color = Colors.RED; // цвет в любом случае проинициализируется корректно далее
                if (redColorRadioButton.Checked)
                {
                    color = Colors.RED;
                }
                if (greenColorRadioButton.Checked)
                {
                    color = Colors.GREEN;
                }
                if (blueColorRadioButton.Checked)
                {
                    color = Colors.BLUE;
                }
                if (engLangRadioButton.Checked)
                {
                    Bitmap modImg = ImageUtils.EncodeEnglish(origImgPath.Text, imgEncryptTextBox.Text, color);
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.Filter = "Image files (*.PNG)|*.png";

                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        originalPictureBox.ImageLocation = origImgPath.Text;
                        modImgPath.Text = saveFile.FileName.ToString();
                        encodedPictureBox.ImageLocation = modImgPath.Text;

                        modImg.Save(modImgPath.Text);
                    }
                }
                else
                {
                    Bitmap modImg = ImageUtils.EncodeRussian(origImgPath.Text, imgEncryptTextBox.Text, color);
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.Filter = "Image files (*.PNG)|*.png";

                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        originalPictureBox.ImageLocation = origImgPath.Text;
                        modImgPath.Text = saveFile.FileName.ToString();
                        encodedPictureBox.ImageLocation = modImgPath.Text;

                        modImg.Save(modImgPath.Text);
                    }
                }
                break;
            }
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (!(redColorRadioButton.Checked || greenColorRadioButton.Checked || blueColorRadioButton.Checked))
                {
                    MessageBox.Show("Сначала выберите предполагаемый цвет для внедрения.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                if (!(russianLangRadioButton.Checked || engLangRadioButton.Checked))
                {
                    MessageBox.Show("Сначала выберите предполагаемый язык сообщения.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                if (modImgPath.Text == "" || modImgPath.Text == "Путь к измененному файлу")
                {
                    MessageBox.Show("Сначала выберите изображение с вшитым сообщением.", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                Colors color = Colors.RED; // цвет в любом случае проинициализируется корректно далее
                if (redColorRadioButton.Checked)
                {
                    color = Colors.RED;
                }
                if (greenColorRadioButton.Checked)
                {
                    color = Colors.GREEN;
                }
                if (blueColorRadioButton.Checked)
                {
                    color = Colors.BLUE;
                }
                if (engLangRadioButton.Checked)
                {
                    String ecnodedText = ImageUtils.DecodeEnglish(modImgPath.Text, LenghtTextBox.Text, color);
                    imgEncryptTextBox.Text = "Дешифрованный текст: " + ecnodedText;
                }
                else
                {
                    String encodedText = ImageUtils.DecodeRussian(modImgPath.Text, LenghtTextBox.Text, color);
                    imgEncryptTextBox.Text = "Дешифрованный текст: " + encodedText;
                }
                break;
            }
        }

        private void encryptTextBoxClearButton_Click(object sender, EventArgs e)
        {
            imgEncryptTextBox.Text = "";
        }


        #endregion

        #region Audio steganography
        private static WavFile origWavFile = new WavFile();
        private static WavFile modWavFile = new WavFile();

        private void origAudioFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Wav files (*.WAV)|*.wav";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                origAudioFileTextBox.Text = dialog.FileName.ToString();
                origWavFile = WavUtils.CreateWavFile(origAudioFileTextBox.Text);
                origSampleTextBox.Text = Convert.ToString(origWavFile.dwSamplesPerSec) + " Гц";
                origChannelsTextBox.Text = Convert.ToString(origWavFile.wChannels);
                origBitPerSampleTextBox.Text = Convert.ToString(origWavFile.wBitsPerSample);
                origDChunkSizeTextBox.Text = Convert.ToString(origWavFile.dwDChunkSize) + " Байт";
                origDataStartPosTextBox.Text = Convert.ToString(origWavFile.dataStartPos);
                origFChunkSizeTextBox.Text = Convert.ToString(origWavFile.dwFChunkSize);
                origBlockAllignTextBox.Text = Convert.ToString(origWavFile.wBlockAlign);
                origBytesPerSecondTextBox.Text = Convert.ToString(origWavFile.dwAvgBytesPerSec);
            }
        }


        private void modAudioFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Wav files (*.WAV)|*.wav";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                modAudioFileTextBox.Text = dialog.FileName.ToString();
                modWavFile = WavUtils.CreateWavFile(modAudioFileTextBox.Text);
                modSampleTextBox.Text = Convert.ToString(modWavFile.dwSamplesPerSec) + " Гц";
                modChannelsTextBox.Text = Convert.ToString(modWavFile.wChannels);
                modBitPerSampleTextBox.Text = Convert.ToString(modWavFile.wBitsPerSample);
                modDChunkSizeTextBox.Text = Convert.ToString(modWavFile.dwDChunkSize) + " Байт";
                modDataStartPosTextBox.Text = Convert.ToString(modWavFile.dataStartPos);
                modFChunkSizeTextBox.Text = Convert.ToString(modWavFile.dwFChunkSize);
                modBlockAllignTextBox.Text = Convert.ToString(modWavFile.wBlockAlign);
                modBytesPerSecondTextBox.Text = Convert.ToString(modWavFile.dwAvgBytesPerSec);
            }
        }

        // зашифровка сообщения в аудиофайл
        private void encryptAudioButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Wav files (*.WAV)|*.wav";
            UInt32 bytesPerSample = origWavFile.dwAvgBytesPerSec;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                creationalAudioTextBox.Text = saveFile.FileName.ToString();
                WavUtils.WriteFile(origWavFile, origAudioFileTextBox.Text, creationalAudioTextBox.Text, encryptAudioTextBox.Text);
            }
        }

        #endregion Audio steganography
    }
}
