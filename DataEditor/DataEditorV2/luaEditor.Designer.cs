/*
 * 用户： User_ke
 * 日期: 2013/9/24 
*/
namespace DataEditorV2
{
	partial class luaEditor
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_open = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_save = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_utf8 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_gb2312 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_anis = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Skin = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Color = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_white = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_green = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_fontsize = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_small = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_middle = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_big = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_de = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.HideSelection = false;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox1.Location = new System.Drawing.Point(0, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(684, 437);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.ToolStrip_Skin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_open,
            this.ToolStrip_save,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // ToolStrip_open
            // 
            this.ToolStrip_open.Name = "ToolStrip_open";
            this.ToolStrip_open.Size = new System.Drawing.Size(118, 22);
            this.ToolStrip_open.Text = "打开(&O)";
            this.ToolStrip_open.Click += new System.EventHandler(this.ToolStrip_open_Click);
            // 
            // ToolStrip_save
            // 
            this.ToolStrip_save.Name = "ToolStrip_save";
            this.ToolStrip_save.Size = new System.Drawing.Size(118, 22);
            this.ToolStrip_save.Text = "保存(&S)";
            this.ToolStrip_save.Click += new System.EventHandler(this.ToolStrip_saveClick);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.退出ToolStripMenuItem.Text = "退出(&Q)";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.ToolStrip_exit_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_utf8,
            this.ToolStrip_gb2312,
            this.ToolStrip_anis});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.编辑ToolStripMenuItem.Text = "编码(&E)";
            // 
            // ToolStrip_utf8
            // 
            this.ToolStrip_utf8.CheckOnClick = true;
            this.ToolStrip_utf8.Name = "ToolStrip_utf8";
            this.ToolStrip_utf8.Size = new System.Drawing.Size(162, 22);
            this.ToolStrip_utf8.Text = "UTF8编码(&U)";
            this.ToolStrip_utf8.Click += new System.EventHandler(this.ToolStrip_utf8Click);
            // 
            // ToolStrip_gb2312
            // 
            this.ToolStrip_gb2312.CheckOnClick = true;
            this.ToolStrip_gb2312.Name = "ToolStrip_gb2312";
            this.ToolStrip_gb2312.Size = new System.Drawing.Size(162, 22);
            this.ToolStrip_gb2312.Text = "GB2312编码(&G)";
            this.ToolStrip_gb2312.Click += new System.EventHandler(this.ToolStrip_gb2312Click);
            // 
            // ToolStrip_anis
            // 
            this.ToolStrip_anis.CheckOnClick = true;
            this.ToolStrip_anis.Name = "ToolStrip_anis";
            this.ToolStrip_anis.Size = new System.Drawing.Size(162, 22);
            this.ToolStrip_anis.Text = "ANIS编码(&A)";
            this.ToolStrip_anis.Click += new System.EventHandler(this.ToolStrip_anisClick);
            // 
            // ToolStrip_Skin
            // 
            this.ToolStrip_Skin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_Color,
            this.ToolStrip_fontsize});
            this.ToolStrip_Skin.Name = "ToolStrip_Skin";
            this.ToolStrip_Skin.Size = new System.Drawing.Size(59, 21);
            this.ToolStrip_Skin.Text = "外观(&S)";
            // 
            // ToolStrip_Color
            // 
            this.ToolStrip_Color.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_white,
            this.ToolStrip_green});
            this.ToolStrip_Color.Name = "ToolStrip_Color";
            this.ToolStrip_Color.Size = new System.Drawing.Size(138, 22);
            this.ToolStrip_Color.Text = "背景色(&C)";
            // 
            // ToolStrip_white
            // 
            this.ToolStrip_white.Checked = true;
            this.ToolStrip_white.CheckOnClick = true;
            this.ToolStrip_white.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStrip_white.Name = "ToolStrip_white";
            this.ToolStrip_white.Size = new System.Drawing.Size(112, 22);
            this.ToolStrip_white.Text = "白色";
            this.ToolStrip_white.Click += new System.EventHandler(this.ToolStrip_whiteClick);
            // 
            // ToolStrip_green
            // 
            this.ToolStrip_green.CheckOnClick = true;
            this.ToolStrip_green.Name = "ToolStrip_green";
            this.ToolStrip_green.Size = new System.Drawing.Size(112, 22);
            this.ToolStrip_green.Text = "淡绿色";
            this.ToolStrip_green.Click += new System.EventHandler(this.ToolStrip_greenClick);
            // 
            // ToolStrip_fontsize
            // 
            this.ToolStrip_fontsize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_small,
            this.ToolStrip_middle,
            this.ToolStrip_big,
            this.ToolStrip_de});
            this.ToolStrip_fontsize.Name = "ToolStrip_fontsize";
            this.ToolStrip_fontsize.Size = new System.Drawing.Size(138, 22);
            this.ToolStrip_fontsize.Text = "字体大小(&F)";
            // 
            // ToolStrip_small
            // 
            this.ToolStrip_small.CheckOnClick = true;
            this.ToolStrip_small.Name = "ToolStrip_small";
            this.ToolStrip_small.Size = new System.Drawing.Size(100, 22);
            this.ToolStrip_small.Text = "小";
            this.ToolStrip_small.Click += new System.EventHandler(this.ToolStrip_smallClick);
            // 
            // ToolStrip_middle
            // 
            this.ToolStrip_middle.CheckOnClick = true;
            this.ToolStrip_middle.Name = "ToolStrip_middle";
            this.ToolStrip_middle.Size = new System.Drawing.Size(100, 22);
            this.ToolStrip_middle.Text = "中";
            this.ToolStrip_middle.Click += new System.EventHandler(this.ToolStrip_middleClick);
            // 
            // ToolStrip_big
            // 
            this.ToolStrip_big.CheckOnClick = true;
            this.ToolStrip_big.Name = "ToolStrip_big";
            this.ToolStrip_big.Size = new System.Drawing.Size(100, 22);
            this.ToolStrip_big.Text = "大";
            this.ToolStrip_big.Click += new System.EventHandler(this.ToolStrip_bigClick);
            // 
            // ToolStrip_de
            // 
            this.ToolStrip_de.Checked = true;
            this.ToolStrip_de.CheckOnClick = true;
            this.ToolStrip_de.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStrip_de.Name = "ToolStrip_de";
            this.ToolStrip_de.Size = new System.Drawing.Size(100, 22);
            this.ToolStrip_de.Text = "默认";
            this.ToolStrip_de.Click += new System.EventHandler(this.ToolStrip_deClick);
            // 
            // luaEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "luaEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "luaEditor";
            this.Load += new System.EventHandler(this.LuaEditorLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_de;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_big;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_middle;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_small;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_fontsize;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_green;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_white;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_Color;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_Skin;
		private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_anis;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_gb2312;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_utf8;
		private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_save;
		private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_open;
	}
}
