namespace DataEditorV2
{
    partial class MSEForm
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
        	this.textBox_jpg = new System.Windows.Forms.TextBox();
        	this.textBox_save = new System.Windows.Forms.TextBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.comboBox_style = new System.Windows.Forms.ComboBox();
        	this.label3 = new System.Windows.Forms.Label();
        	this.comboBox_lang = new System.Windows.Forms.ComboBox();
        	this.button_ok = new System.Windows.Forms.Button();
        	this.groupBox1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// textBox_jpg
        	// 
        	this.textBox_jpg.Location = new System.Drawing.Point(5, 68);
        	this.textBox_jpg.Name = "textBox_jpg";
        	this.textBox_jpg.Size = new System.Drawing.Size(260, 21);
        	this.textBox_jpg.TabIndex = 1;
        	this.textBox_jpg.Click += new System.EventHandler(this.textBox_jpg_Click);
        	// 
        	// textBox_save
        	// 
        	this.textBox_save.Location = new System.Drawing.Point(7, 141);
        	this.textBox_save.Name = "textBox_save";
        	this.textBox_save.Size = new System.Drawing.Size(275, 21);
        	this.textBox_save.TabIndex = 3;
        	this.textBox_save.Click += new System.EventHandler(this.textBox_save_Click);
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(8, 126);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(77, 12);
        	this.label2.TabIndex = 2;
        	this.label2.Text = "存档保存路径";
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Controls.Add(this.label1);
        	this.groupBox1.Controls.Add(this.label4);
        	this.groupBox1.Controls.Add(this.comboBox_style);
        	this.groupBox1.Controls.Add(this.label3);
        	this.groupBox1.Controls.Add(this.textBox_jpg);
        	this.groupBox1.Controls.Add(this.comboBox_lang);
        	this.groupBox1.Location = new System.Drawing.Point(7, 8);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(275, 115);
        	this.groupBox1.TabIndex = 4;
        	this.groupBox1.TabStop = false;
        	this.groupBox1.Text = "存档设置";
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(6, 50);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(125, 12);
        	this.label1.TabIndex = 4;
        	this.label1.Text = "添加图片文件夹的图片";
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(6, 24);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(53, 12);
        	this.label4.TabIndex = 3;
        	this.label4.Text = "卡片风格";
        	// 
        	// comboBox_style
        	// 
        	this.comboBox_style.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.comboBox_style.FormattingEnabled = true;
        	this.comboBox_style.Items.AddRange(new object[] {
        	        	        	"style1",
        	        	        	"ygopro",
        	        	        	"standard",
        	        	        	"style2"});
        	this.comboBox_style.Location = new System.Drawing.Point(62, 20);
        	this.comboBox_style.Name = "comboBox_style";
        	this.comboBox_style.Size = new System.Drawing.Size(81, 20);
        	this.comboBox_style.TabIndex = 2;
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(149, 24);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(53, 12);
        	this.label3.TabIndex = 1;
        	this.label3.Text = "卡片语言";
        	// 
        	// comboBox_lang
        	// 
        	this.comboBox_lang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.comboBox_lang.FormattingEnabled = true;
        	this.comboBox_lang.Items.AddRange(new object[] {
        	        	        	"简体",
        	        	        	"繁体",
        	        	        	"英文",
        	        	        	"日文"});
        	this.comboBox_lang.Location = new System.Drawing.Point(208, 20);
        	this.comboBox_lang.Name = "comboBox_lang";
        	this.comboBox_lang.Size = new System.Drawing.Size(58, 20);
        	this.comboBox_lang.TabIndex = 0;
        	// 
        	// button_ok
        	// 
        	this.button_ok.Location = new System.Drawing.Point(92, 165);
        	this.button_ok.Name = "button_ok";
        	this.button_ok.Size = new System.Drawing.Size(104, 34);
        	this.button_ok.TabIndex = 5;
        	this.button_ok.Text = "开始导出";
        	this.button_ok.UseVisualStyleBackColor = true;
        	this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
        	// 
        	// MSEForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(289, 201);
        	this.Controls.Add(this.button_ok);
        	this.Controls.Add(this.groupBox1);
        	this.Controls.Add(this.textBox_save);
        	this.Controls.Add(this.label2);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        	this.MaximizeBox = false;
        	this.Name = "MSEForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "导出MSE存档";
        	this.Load += new System.EventHandler(this.MSEForm_Load);
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox_jpg;
        private System.Windows.Forms.TextBox textBox_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_style;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_lang;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label label1;
    }
}