namespace Login_Paneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            checkBox1 = new CheckBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 198);
            label1.Name = "label1";
            label1.Size = new Size(87, 18);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı ID:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(208, 195);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(184, 26);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(208, 240);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 26);
            textBox1.TabIndex = 2;
            textBox1.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 243);
            label2.Name = "label2";
            label2.Size = new Size(45, 18);
            label2.TabIndex = 3;
            label2.Text = "Şifre:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSeaGreen;
            panel2.Location = new Point(-1, 513);
            panel2.Name = "panel2";
            panel2.Size = new Size(1029, 29);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(313, 285);
            button1.Name = "button1";
            button1.Size = new Size(79, 29);
            button1.TabIndex = 6;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(92, 292);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(107, 22);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Beni Hatırla";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 21);
            label3.Name = "label3";
            label3.Size = new Size(175, 18);
            label3.TabIndex = 0;
            label3.Text = "Online Ders Giriş Paneli";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(526, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(456, 332);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 53);
            panel1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1029, 540);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Kullanıcı Giriş Paneli";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private Label label2;
        private Panel panel2;
        private Button button1;
        private Label label3;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
