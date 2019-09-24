namespace WinGost
{
    partial class FrmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.loadKeyButton = new System.Windows.Forms.Button();
            this.keyGenerateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.encrTextBox = new System.Windows.Forms.TextBox();
            this.decrTextBox = new System.Windows.Forms.TextBox();
            this.fileEncryptButton = new System.Windows.Forms.Button();
            this.fileDecryptButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ключ:";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(121, 10);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.ReadOnly = true;
            this.keyTextBox.Size = new System.Drawing.Size(177, 22);
            this.keyTextBox.TabIndex = 1;
            // 
            // loadKeyButton
            // 
            this.loadKeyButton.Location = new System.Drawing.Point(305, 8);
            this.loadKeyButton.Name = "loadKeyButton";
            this.loadKeyButton.Size = new System.Drawing.Size(75, 23);
            this.loadKeyButton.TabIndex = 2;
            this.loadKeyButton.Text = "Загрузить";
            this.loadKeyButton.UseVisualStyleBackColor = true;
            this.loadKeyButton.Click += new System.EventHandler(this.loadKeyButton_Click);
            // 
            // keyGenerateButton
            // 
            this.keyGenerateButton.Location = new System.Drawing.Point(305, 37);
            this.keyGenerateButton.Name = "keyGenerateButton";
            this.keyGenerateButton.Size = new System.Drawing.Size(104, 23);
            this.keyGenerateButton.TabIndex = 4;
            this.keyGenerateButton.Text = "Создать ключ";
            this.keyGenerateButton.UseVisualStyleBackColor = true;
            this.keyGenerateButton.Click += new System.EventHandler(this.keyGenerateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.encrTextBox);
            this.groupBox1.Controls.Add(this.decrTextBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 189);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Текст";
            // 
            // encrTextBox
            // 
            this.encrTextBox.Location = new System.Drawing.Point(245, 21);
            this.encrTextBox.Multiline = true;
            this.encrTextBox.Name = "encrTextBox";
            this.encrTextBox.ReadOnly = true;
            this.encrTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.encrTextBox.Size = new System.Drawing.Size(209, 162);
            this.encrTextBox.TabIndex = 1;
            // 
            // decrTextBox
            // 
            this.decrTextBox.Location = new System.Drawing.Point(6, 21);
            this.decrTextBox.Multiline = true;
            this.decrTextBox.Name = "decrTextBox";
            this.decrTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.decrTextBox.Size = new System.Drawing.Size(209, 162);
            this.decrTextBox.TabIndex = 0;
            // 
            // fileEncryptButton
            // 
            this.fileEncryptButton.Location = new System.Drawing.Point(67, 267);
            this.fileEncryptButton.Name = "fileEncryptButton";
            this.fileEncryptButton.Size = new System.Drawing.Size(99, 23);
            this.fileEncryptButton.TabIndex = 7;
            this.fileEncryptButton.Text = "Зашифровать";
            this.fileEncryptButton.UseVisualStyleBackColor = true;
            this.fileEncryptButton.Click += new System.EventHandler(this.fileEncryptButton_Click);
            // 
            // fileDecryptButton
            // 
            this.fileDecryptButton.Location = new System.Drawing.Point(308, 267);
            this.fileDecryptButton.Name = "fileDecryptButton";
            this.fileDecryptButton.Size = new System.Drawing.Size(114, 23);
            this.fileDecryptButton.TabIndex = 8;
            this.fileDecryptButton.Text = "Расшифровать";
            this.fileDecryptButton.UseVisualStyleBackColor = true;
            this.fileDecryptButton.Click += new System.EventHandler(this.fileDecryptButton_Click);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(121, 37);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(178, 22);
            this.tbPass.TabIndex = 9;
            this.tbPass.Text = "123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Кодовая фраза:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 299);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.fileDecryptButton);
            this.Controls.Add(this.fileEncryptButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.keyGenerateButton);
            this.Controls.Add(this.loadKeyButton);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифрование алгоритмом ГОСТ 28147-89";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button loadKeyButton;
        private System.Windows.Forms.Button keyGenerateButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox encrTextBox;
        private System.Windows.Forms.TextBox decrTextBox;
        private System.Windows.Forms.Button fileEncryptButton;
        private System.Windows.Forms.Button fileDecryptButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label2;
    }
}

