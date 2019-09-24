using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace WinGost
{
    public partial class FrmMain : Form
    {
        byte[] encrByteFile, byteKey, decrByteFile;

        public FrmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик кнопки шифрования текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileEncryptButton_Click(object sender, EventArgs e)
        {
            E32 e32;

            if (decrTextBox.Text == "")
                MessageBox.Show("Введите данные для шифрования.");
            else
            {
                byte[] btFile = Encoding.Default.GetBytes(decrTextBox.Text);

                if ((byteKey == null) || (byteKey.Length != 32))
                    MessageBox.Show("Введдите 256-битный ключ.");
                else
                {
                    e32 = new E32(btFile, byteKey);
                    encrByteFile = e32.GetEncryptFile;
                    encrTextBox.Text = Encoding.Default.GetString(encrByteFile);
                }
            }
        }
        /// <summary>
        /// Обработчик кнопки дешефрования текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileDecryptButton_Click(object sender, EventArgs e)
        {
            D32 d32;

            if (decrTextBox.Text == "")
                MessageBox.Show("Введите данные для шифрования.");
            else
            {
                byte[] btFile = encrByteFile;

                if (byteKey.Length != 32)
                    MessageBox.Show("Введдите 256-битный ключ.");
                else
                {
                    d32 = new D32(btFile, byteKey);
                    decrByteFile = d32.GetDecryptFile;
                    encrTextBox.Text = Encoding.Default.GetString(decrByteFile);
                }
            }
        }
        /// <summary>
        /// Обработчик кнопки создания ключа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keyGenerateButton_Click(object sender, EventArgs e)
        {
            byteKey = CreateKey(tbPass.Text);
            keyTextBox.Text = BitConverter.ToString(byteKey);
        }
        /// <summary>
        /// Постоянная "соль" для ключа
        /// </summary>
        private static readonly byte[] Salt = new byte[] { 10, 20, 30, 40, 50, 60, 70, 80 };

        /// <summary>
        /// Создание 256 битного ключа
        /// </summary>
        /// <param name="password"></param>
        /// <param name="keyBytes"></param>
        /// <returns></returns>
        private static byte[] CreateKey(string password, int keyBytes = 32)
        {
            const int Iterations = 300;
            var keyGenerator = new Rfc2898DeriveBytes(password, Salt, Iterations);
            return keyGenerator.GetBytes(keyBytes);
        }

        /// <summary>
        /// Обработчик кнопки загрузки ключа шифрования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadKeyButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string key = openFileDialog1.FileName;
            byteKey = File.ReadAllBytes(key);
            keyTextBox.Text = Encoding.Default.GetString(byteKey);
        }

        /// <summary>
        /// Обработчик кнопки загрузки файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileLoadButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string file = openFileDialog1.FileName;
            decrByteFile = File.ReadAllBytes(file);
            decrTextBox.Text = Encoding.Default.GetString(decrByteFile);
        }
    }
}
