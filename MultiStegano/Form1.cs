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


    }
}
