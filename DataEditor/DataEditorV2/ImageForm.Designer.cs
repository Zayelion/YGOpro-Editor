namespace DataEditorV2
{
    partial class ImageForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_jpg = new System.Windows.Forms.TextBox();
            this.textBox_save = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_ex = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton_ygopro = new System.Windows.Forms.RadioButton();
            this.radioButton_other = new System.Windows.Forms.RadioButton();
            this.textBox_w = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_h = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar_quilty = new System.Windows.Forms.TrackBar();
            this.button_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_quilty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原图片文件夹";
            // 
            // textBox_jpg
            // 
            this.textBox_jpg.Location = new System.Drawing.Point(5, 28);
            this.textBox_jpg.Name = "textBox_jpg";
            this.textBox_jpg.Size = new System.Drawing.Size(280, 21);
            this.textBox_jpg.TabIndex = 1;
            this.textBox_jpg.Click += new System.EventHandler(this.textBox_jpg_Click);
            // 
            // textBox_save
            // 
            this.textBox_save.Location = new System.Drawing.Point(4, 147);
            this.textBox_save.Name = "textBox_save";
            this.textBox_save.Size = new System.Drawing.Size(281, 21);
            this.textBox_save.TabIndex = 3;
            this.textBox_save.Click += new System.EventHandler(this.textBox_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "调整后保存文件夹";
            // 
            // comboBox_ex
            // 
            this.comboBox_ex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ex.FormattingEnabled = true;
            this.comboBox_ex.Items.AddRange(new object[] {
            "png",
            "jpg",
            "bmp"});
            this.comboBox_ex.Location = new System.Drawing.Point(239, 5);
            this.comboBox_ex.Name = "comboBox_ex";
            this.comboBox_ex.Size = new System.Drawing.Size(46, 20);
            this.comboBox_ex.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "图片格式";
            // 
            // radioButton_ygopro
            // 
            this.radioButton_ygopro.AutoSize = true;
            this.radioButton_ygopro.Checked = true;
            this.radioButton_ygopro.Location = new System.Drawing.Point(69, 53);
            this.radioButton_ygopro.Name = "radioButton_ygopro";
            this.radioButton_ygopro.Size = new System.Drawing.Size(107, 16);
            this.radioButton_ygopro.TabIndex = 6;
            this.radioButton_ygopro.TabStop = true;
            this.radioButton_ygopro.Text = "YGOPRO游戏卡图";
            this.radioButton_ygopro.UseVisualStyleBackColor = true;
            // 
            // radioButton_other
            // 
            this.radioButton_other.AutoSize = true;
            this.radioButton_other.Location = new System.Drawing.Point(69, 73);
            this.radioButton_other.Name = "radioButton_other";
            this.radioButton_other.Size = new System.Drawing.Size(59, 16);
            this.radioButton_other.TabIndex = 7;
            this.radioButton_other.Text = "自定义";
            this.radioButton_other.UseVisualStyleBackColor = true;
            this.radioButton_other.CheckedChanged += new System.EventHandler(this.radioButton_other_CheckedChanged);
            // 
            // textBox_w
            // 
            this.textBox_w.Enabled = false;
            this.textBox_w.Location = new System.Drawing.Point(165, 73);
            this.textBox_w.MaxLength = 4;
            this.textBox_w.Name = "textBox_w";
            this.textBox_w.Size = new System.Drawing.Size(45, 21);
            this.textBox_w.TabIndex = 8;
            this.textBox_w.Text = "150";
            this.textBox_w.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "宽";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "高";
            // 
            // textBox_h
            // 
            this.textBox_h.Enabled = false;
            this.textBox_h.Location = new System.Drawing.Point(240, 72);
            this.textBox_h.MaxLength = 4;
            this.textBox_h.Name = "textBox_h";
            this.textBox_h.Size = new System.Drawing.Size(45, 21);
            this.textBox_h.TabIndex = 10;
            this.textBox_h.Text = "150";
            this.textBox_h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "调整方式";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "图片质量 95%";
            // 
            // trackBar_quilty
            // 
            this.trackBar_quilty.AutoSize = false;
            this.trackBar_quilty.Location = new System.Drawing.Point(88, 96);
            this.trackBar_quilty.Maximum = 100;
            this.trackBar_quilty.Minimum = 80;
            this.trackBar_quilty.Name = "trackBar_quilty";
            this.trackBar_quilty.Size = new System.Drawing.Size(197, 20);
            this.trackBar_quilty.TabIndex = 14;
            this.trackBar_quilty.Value = 96;
            this.trackBar_quilty.Scroll += new System.EventHandler(this.trackBar_quilty_Scroll);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(100, 173);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(88, 31);
            this.button_start.TabIndex = 15;
            this.button_start.Text = "开始调整";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 209);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.trackBar_quilty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_h);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_w);
            this.Controls.Add(this.radioButton_other);
            this.Controls.Add(this.radioButton_ygopro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_ex);
            this.Controls.Add(this.textBox_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_jpg);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图片调整";
            this.Load += new System.EventHandler(this.ImageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_quilty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_jpg;
        private System.Windows.Forms.TextBox textBox_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_ex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton_ygopro;
        private System.Windows.Forms.RadioButton radioButton_other;
        private System.Windows.Forms.TextBox textBox_w;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_h;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar_quilty;
        private System.Windows.Forms.Button button_start;
    }
}