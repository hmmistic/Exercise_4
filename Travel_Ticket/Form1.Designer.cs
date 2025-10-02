namespace Travel_Ticket
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            maskedTextBox3 = new MaskedTextBox();
            label6 = new Label();
            maskedTextBox4 = new MaskedTextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            listBox1 = new ListBox();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(326, 259);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Marşurut";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(maskedTextBox4);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(378, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(318, 259);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sərnişin məlumatları";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 128);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 73);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(35, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 47);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Haradan:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "İstanbul", "Bakı", "Berlin", "Praqa", "Tehran" });
            comboBox1.Location = new Point(98, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(169, 28);
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "İstanbul", "Bakı", "Berlin", "Praqa", "Tehran" });
            comboBox2.Location = new Point(98, 94);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(169, 28);
            comboBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 97);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 2;
            label2.Text = "Haraya:";
            // 
            // button1
            // 
            button1.Location = new Point(281, 44);
            button1.Name = "button1";
            button1.Size = new Size(27, 78);
            button1.TabIndex = 4;
            button1.Text = "<\r\n>\r\n";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 133);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 5;
            label3.Text = "Tarix:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(98, 133);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(169, 27);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(98, 174);
            maskedTextBox2.Mask = "00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(169, 27);
            maskedTextBox2.TabIndex = 8;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 174);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 7;
            label4.Text = "Saat:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 217);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 9;
            label5.Text = "Yer:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(98, 217);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 27);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 160);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 27);
            textBox2.TabIndex = 15;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(130, 117);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(169, 27);
            maskedTextBox3.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 117);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 13;
            label6.Text = "Telefon:";
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(130, 76);
            maskedTextBox4.Mask = "00000-9999";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(169, 27);
            maskedTextBox4.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 76);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 11;
            label7.Text = "ŞV/seria:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(75, 167);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 16;
            label8.Text = "Email:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 32);
            label9.Name = "label9";
            label9.Size = new Size(93, 20);
            label9.TabIndex = 18;
            label9.Text = "Ad və soyad:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(130, 32);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(169, 27);
            textBox3.TabIndex = 17;
            // 
            // button2
            // 
            button2.Location = new Point(130, 214);
            button2.Name = "button2";
            button2.Size = new Size(169, 30);
            button2.TabIndex = 19;
            button2.Text = "Bilet al";
            button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 359);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(684, 84);
            listBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(20, 453);
            button3.Name = "button3";
            button3.Size = new Size(157, 38);
            button3.TabIndex = 4;
            button3.Text = "Siyahıdan silmək";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(528, 453);
            button4.Name = "button4";
            button4.Size = new Size(168, 38);
            button4.TabIndex = 5;
            button4.Text = "Proqramdan çıxış";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(708, 503);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Travel ticket";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panel1;
        private TextBox textBox1;
        private Label label5;
        private MaskedTextBox maskedTextBox2;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private Label label3;
        private Button button1;
        private ComboBox comboBox2;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label9;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox3;
        private Label label6;
        private MaskedTextBox maskedTextBox4;
        private Label label7;
        private ListBox listBox1;
        private Button button3;
        private Button button4;
    }
}
