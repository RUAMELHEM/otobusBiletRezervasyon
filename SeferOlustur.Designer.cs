namespace OtobusBiletRezervasyonu
{
    partial class SeferOlustur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button10 = new Button();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(84, 303);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(406, 308);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(183, 28);
            comboBox2.TabIndex = 3;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1, 308);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 4;
            label2.Text = "Nereden : ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(316, 311);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 5;
            label3.Text = "Nereye : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(336, 250);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 6;
            label4.Text = "Tarih :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(406, 245);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(183, 27);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button10
            // 
            button10.BackColor = Color.LightGray;
            button10.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.RosyBrown;
            button10.Location = new Point(268, 410);
            button10.Name = "button10";
            button10.Size = new Size(163, 36);
            button10.TabIndex = 11;
            button10.Text = "Satın Al";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.RosyBrown;
            button3.Location = new Point(480, 410);
            button3.Name = "button3";
            button3.Size = new Size(161, 35);
            button3.TabIndex = 16;
            button3.Text = "Bileti Yazdır";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(679, 60);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(257, 371);
            richTextBox1.TabIndex = 17;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(705, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 41);
            label1.TabIndex = 18;
            label1.Text = "Alınan Biletler ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(1, 255);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 19;
            label5.Text = "İsim : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 248);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 27);
            textBox1.TabIndex = 20;
            // 
            // SeferOlustur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 490);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(button10);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "SeferOlustur";
            Text = "SeferOlustur";
            Load += SeferOlustur_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button10;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button button3;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label5;
        private TextBox textBox1;
    }
}
