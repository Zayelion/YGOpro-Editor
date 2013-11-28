
namespace DataEditorV2
{
	partial class MainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ToolStrip_cdblist = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip_File = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip_ReadYDK = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip_SearchJPG = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip_opengpath = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip_copycards = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip_export = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip_Tools = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip_setpath = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip_gamepath = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip_notepad = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip_game = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip_cutJPG = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip_stratcut = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip_yulan = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip_cutfolder = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip_resizeJPG = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip_MSE = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip_Getjpg = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip_startcut = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip_opencutjpg = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip_netdisk = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStrip_about = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.button_searchCard = new System.Windows.Forms.Button();
			this.button_resetCard = new System.Windows.Forms.Button();
			this.button_addCard = new System.Windows.Forms.Button();
			this.button_moCard = new System.Windows.Forms.Button();
			this.button_delCard = new System.Windows.Forms.Button();
			this.button_cancelCard = new System.Windows.Forms.Button();
			this.listView_Cards = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.button_next = new System.Windows.Forms.Button();
			this.button_forword = new System.Windows.Forms.Button();
			this.textBox_page = new System.Windows.Forms.TextBox();
			this.textBox_count = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.check_effect = new System.Windows.Forms.CheckedListBox();
			this.check_type = new System.Windows.Forms.CheckedListBox();
			this.label_def = new System.Windows.Forms.Label();
			this.textBox_def = new System.Windows.Forms.TextBox();
			this.textBox_atk = new System.Windows.Forms.TextBox();
			this.label_atk = new System.Windows.Forms.Label();
			this.textBox_alias = new System.Windows.Forms.TextBox();
			this.label_alias = new System.Windows.Forms.Label();
			this.label_code = new System.Windows.Forms.Label();
			this.textBox_code = new System.Windows.Forms.TextBox();
			this.label_category = new System.Windows.Forms.Label();
			this.label_type = new System.Windows.Forms.Label();
			this.label_setname = new System.Windows.Forms.Label();
			this.label_attribute = new System.Windows.Forms.Label();
			this.label_level = new System.Windows.Forms.Label();
			this.label_rule = new System.Windows.Forms.Label();
			this.label_race = new System.Windows.Forms.Label();
			this.comboBox_setname2 = new System.Windows.Forms.ComboBox();
			this.comboBox_setname1 = new System.Windows.Forms.ComboBox();
			this.comboBox_race = new System.Windows.Forms.ComboBox();
			this.comboBox_level = new System.Windows.Forms.ComboBox();
			this.comboBox_attribute = new System.Windows.Forms.ComboBox();
			this.comboBox_rule = new System.Windows.Forms.ComboBox();
			this.textBox_str = new System.Windows.Forms.TextBox();
			this.listBox_str = new System.Windows.Forms.ListBox();
			this.textBox_name = new System.Windows.Forms.TextBox();
			this.label_cardname = new System.Windows.Forms.Label();
			this.button_lua = new System.Windows.Forms.Button();
			this.textBox_desc = new System.Windows.Forms.TextBox();
			this.tabControl_text = new System.Windows.Forms.TabControl();
			this.tab_luaText = new System.Windows.Forms.TabPage();
			this.label_scripttext = new System.Windows.Forms.Label();
			this.tabPage_jpg = new System.Windows.Forms.TabPage();
			this.textBox_setname = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.tabControl_text.SuspendLayout();
			this.tab_luaText.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ToolStrip_cdblist,
									this.ToolStrip_File,
									this.ToolStrip_Tools});
			this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.ShowItemToolTips = true;
			this.menuStrip1.Size = new System.Drawing.Size(234, 25);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ToolStrip_cdblist
			// 
			this.ToolStrip_cdblist.Name = "ToolStrip_cdblist";
			this.ToolStrip_cdblist.Size = new System.Drawing.Size(61, 21);
			this.ToolStrip_cdblist.Text = "数据(&D)";
			this.ToolStrip_cdblist.ToolTipText = "新建和打开游戏目录的数据库";
			this.ToolStrip_cdblist.MouseEnter += new System.EventHandler(this.ToolStrip_cdblist_MouseEnter);
			// 
			// ToolStrip_File
			// 
			this.ToolStrip_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ToolStrip_ReadYDK,
									this.ToolStrip_SearchJPG,
									this.ToolStrip_opengpath,
									this.ToolStrip_copycards,
									this.ToolStrip_export});
			this.ToolStrip_File.Name = "ToolStrip_File";
			this.ToolStrip_File.Size = new System.Drawing.Size(58, 21);
			this.ToolStrip_File.Text = "文件(&F)";
			this.ToolStrip_File.ToolTipText = "文件相关的操作";
			// 
			// ToolStrip_ReadYDK
			// 
			this.ToolStrip_ReadYDK.Name = "ToolStrip_ReadYDK";
			this.ToolStrip_ReadYDK.Size = new System.Drawing.Size(165, 22);
			this.ToolStrip_ReadYDK.Text = "按卡组读取(&Y)";
			this.ToolStrip_ReadYDK.ToolTipText = "把ydk卡组的卡片显示到列表";
			this.ToolStrip_ReadYDK.Click += new System.EventHandler(this.ToolStrip_ReadYDK_Click);
			// 
			// ToolStrip_SearchJPG
			// 
			this.ToolStrip_SearchJPG.Name = "ToolStrip_SearchJPG";
			this.ToolStrip_SearchJPG.Size = new System.Drawing.Size(165, 22);
			this.ToolStrip_SearchJPG.Text = "按图片读取(&P)";
			this.ToolStrip_SearchJPG.ToolTipText = "按搜索到的卡图添加卡片到列表";
			this.ToolStrip_SearchJPG.Click += new System.EventHandler(this.ToolStrip_SearchJPG_Click);
			// 
			// ToolStrip_opengpath
			// 
			this.ToolStrip_opengpath.Name = "ToolStrip_opengpath";
			this.ToolStrip_opengpath.Size = new System.Drawing.Size(165, 22);
			this.ToolStrip_opengpath.Text = "打开游戏目录(&G)";
			this.ToolStrip_opengpath.Click += new System.EventHandler(this.ToolStrip_opengpath_Click);
			// 
			// ToolStrip_copycards
			// 
			this.ToolStrip_copycards.Name = "ToolStrip_copycards";
			this.ToolStrip_copycards.Size = new System.Drawing.Size(165, 22);
			this.ToolStrip_copycards.Text = "当前卡片复制到";
			this.ToolStrip_copycards.ToolTipText = "把当前列表的所有卡片数据复制到其他数据库";
			this.ToolStrip_copycards.Click += new System.EventHandler(this.ToolStrip_copycards_Click);
			// 
			// ToolStrip_export
			// 
			this.ToolStrip_export.Name = "ToolStrip_export";
			this.ToolStrip_export.Size = new System.Drawing.Size(165, 22);
			this.ToolStrip_export.Text = "导出图片和脚本";
			this.ToolStrip_export.ToolTipText = "把当前列表所有卡片的卡图和脚本复制到Export文件夹";
			this.ToolStrip_export.Click += new System.EventHandler(this.ToolStrip_export_Click);
			// 
			// ToolStrip_Tools
			// 
			this.ToolStrip_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ToolStrip_setpath,
									this.ToolStrip_game,
									this.ToolStrip_cutJPG,
									this.ToolStrip_resizeJPG,
									this.ToolStrip_MSE,
									this.ToolStrip_Getjpg,
									this.ToolStrip_netdisk,
									this.ToolStrip_about});
			this.ToolStrip_Tools.Name = "ToolStrip_Tools";
			this.ToolStrip_Tools.Size = new System.Drawing.Size(59, 21);
			this.ToolStrip_Tools.Text = "工具(&T)";
			this.ToolStrip_Tools.ToolTipText = "设置和其他功能";
			// 
			// ToolStrip_setpath
			// 
			this.ToolStrip_setpath.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ToolStrip_gamepath,
									this.ToolStrip_notepad});
			this.ToolStrip_setpath.Name = "ToolStrip_setpath";
			this.ToolStrip_setpath.Size = new System.Drawing.Size(189, 22);
			this.ToolStrip_setpath.Text = "设置路径(&S)";
			// 
			// ToolStrip_gamepath
			// 
			this.ToolStrip_gamepath.Name = "ToolStrip_gamepath";
			this.ToolStrip_gamepath.Size = new System.Drawing.Size(185, 22);
			this.ToolStrip_gamepath.Text = "选择游戏(&G)";
			this.ToolStrip_gamepath.Click += new System.EventHandler(this.ToolStrip_gamepath_Click);
			// 
			// ToolStrip_notepad
			// 
			this.ToolStrip_notepad.Name = "ToolStrip_notepad";
			this.ToolStrip_notepad.Size = new System.Drawing.Size(185, 22);
			this.ToolStrip_notepad.Text = "notepad++路径(&N)";
			this.ToolStrip_notepad.Click += new System.EventHandler(this.ToolStrip_notepad_Click);
			// 
			// ToolStrip_game
			// 
			this.ToolStrip_game.Name = "ToolStrip_game";
			this.ToolStrip_game.Size = new System.Drawing.Size(189, 22);
			this.ToolStrip_game.Text = "启动游戏(&G)";
			this.ToolStrip_game.ToolTipText = "把当前数据库作参数启动游戏";
			this.ToolStrip_game.Click += new System.EventHandler(this.ToolStrip_game_Click);
			// 
			// ToolStrip_cutJPG
			// 
			this.ToolStrip_cutJPG.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ToolStrip_stratcut,
									this.ToolStrip_yulan,
									this.ToolStrip_cutfolder});
			this.ToolStrip_cutJPG.Name = "ToolStrip_cutJPG";
			this.ToolStrip_cutJPG.Size = new System.Drawing.Size(189, 22);
			this.ToolStrip_cutJPG.Text = "图片裁剪(&C)";
			// 
			// ToolStrip_stratcut
			// 
			this.ToolStrip_stratcut.Name = "ToolStrip_stratcut";
			this.ToolStrip_stratcut.Size = new System.Drawing.Size(178, 22);
			this.ToolStrip_stratcut.Text = "裁剪当前列表(&A)";
			this.ToolStrip_stratcut.ToolTipText = "把当前卡片的图片裁剪中间部分";
			this.ToolStrip_stratcut.Click += new System.EventHandler(this.ToolStrip_stratcut_Click);
			// 
			// ToolStrip_yulan
			// 
			this.ToolStrip_yulan.CheckOnClick = true;
			this.ToolStrip_yulan.Name = "ToolStrip_yulan";
			this.ToolStrip_yulan.Size = new System.Drawing.Size(178, 22);
			this.ToolStrip_yulan.Text = "预览当前卡片(&D)";
			this.ToolStrip_yulan.ToolTipText = "预览裁剪后的图片";
			this.ToolStrip_yulan.Click += new System.EventHandler(this.ToolStrip_yulan_Click);
			// 
			// ToolStrip_cutfolder
			// 
			this.ToolStrip_cutfolder.Name = "ToolStrip_cutfolder";
			this.ToolStrip_cutfolder.Size = new System.Drawing.Size(178, 22);
			this.ToolStrip_cutfolder.Text = "打开保存文件夹(&O)";
			this.ToolStrip_cutfolder.ToolTipText = "打开裁剪图片保存文件夹";
			this.ToolStrip_cutfolder.Click += new System.EventHandler(this.ToolStrip_cutfolder_Click);
			// 
			// ToolStrip_resizeJPG
			// 
			this.ToolStrip_resizeJPG.Name = "ToolStrip_resizeJPG";
			this.ToolStrip_resizeJPG.Size = new System.Drawing.Size(189, 22);
			this.ToolStrip_resizeJPG.Text = "图片调整(&R)";
			this.ToolStrip_resizeJPG.ToolTipText = "调整图片大小和格式";
			this.ToolStrip_resizeJPG.Click += new System.EventHandler(this.ToolStrip_resizeJPG_Click);
			// 
			// ToolStrip_MSE
			// 
			this.ToolStrip_MSE.Name = "ToolStrip_MSE";
			this.ToolStrip_MSE.Size = new System.Drawing.Size(189, 22);
			this.ToolStrip_MSE.Text = "导出MSE存档(&M)";
			this.ToolStrip_MSE.ToolTipText = "把当前列表的卡片做成MSE存档";
			this.ToolStrip_MSE.Click += new System.EventHandler(this.ToolStrip_MSE_Click);
			// 
			// ToolStrip_Getjpg
			// 
			this.ToolStrip_Getjpg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ToolStrip_startcut,
									this.ToolStrip_opencutjpg});
			this.ToolStrip_Getjpg.Name = "ToolStrip_Getjpg";
			this.ToolStrip_Getjpg.Size = new System.Drawing.Size(189, 22);
			this.ToolStrip_Getjpg.Text = "提取MSE存档图片(&T)";
			this.ToolStrip_Getjpg.ToolTipText = "把MSE存档的图片提取出来";
			// 
			// ToolStrip_startcut
			// 
			this.ToolStrip_startcut.Name = "ToolStrip_startcut";
			this.ToolStrip_startcut.Size = new System.Drawing.Size(160, 22);
			this.ToolStrip_startcut.Text = "开始提取图片";
			this.ToolStrip_startcut.Click += new System.EventHandler(this.ToolStrip_startcut_Click);
			// 
			// ToolStrip_opencutjpg
			// 
			this.ToolStrip_opencutjpg.Name = "ToolStrip_opencutjpg";
			this.ToolStrip_opencutjpg.Size = new System.Drawing.Size(160, 22);
			this.ToolStrip_opencutjpg.Text = "打开保存文件夹";
			this.ToolStrip_opencutjpg.Click += new System.EventHandler(this.ToolStrip_opencutjpg_Click);
			// 
			// ToolStrip_netdisk
			// 
			this.ToolStrip_netdisk.Name = "ToolStrip_netdisk";
			this.ToolStrip_netdisk.Size = new System.Drawing.Size(189, 22);
			this.ToolStrip_netdisk.Text = "作者网盘分享(&N)";
			this.ToolStrip_netdisk.Click += new System.EventHandler(this.ToolStrip_netdisk_Click);
			// 
			// ToolStrip_about
			// 
			this.ToolStrip_about.Name = "ToolStrip_about";
			this.ToolStrip_about.Size = new System.Drawing.Size(189, 22);
			this.ToolStrip_about.Text = "关于DataEditorV2";
			this.ToolStrip_about.Click += new System.EventHandler(this.ToolStrip_about_Click);
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(234, 0);
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(234, 24);
			this.toolStripContainer1.TabIndex = 1;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
			// 
			// button_searchCard
			// 
			this.button_searchCard.BackColor = System.Drawing.SystemColors.Control;
			this.button_searchCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_searchCard.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_searchCard.Location = new System.Drawing.Point(279, 457);
			this.button_searchCard.Name = "button_searchCard";
			this.button_searchCard.Size = new System.Drawing.Size(60, 28);
			this.button_searchCard.TabIndex = 0;
			this.button_searchCard.Text = "搜索(&S)";
			this.button_searchCard.UseVisualStyleBackColor = false;
			this.button_searchCard.Click += new System.EventHandler(this.Button_searchCard_Click);
			// 
			// button_resetCard
			// 
			this.button_resetCard.BackColor = System.Drawing.SystemColors.Control;
			this.button_resetCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_resetCard.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_resetCard.Location = new System.Drawing.Point(346, 457);
			this.button_resetCard.Name = "button_resetCard";
			this.button_resetCard.Size = new System.Drawing.Size(60, 28);
			this.button_resetCard.TabIndex = 1;
			this.button_resetCard.Text = "清空(&Q)";
			this.button_resetCard.UseVisualStyleBackColor = false;
			this.button_resetCard.Click += new System.EventHandler(this.Button_resetCard_Click);
			// 
			// button_addCard
			// 
			this.button_addCard.BackColor = System.Drawing.SystemColors.Control;
			this.button_addCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_addCard.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_addCard.Location = new System.Drawing.Point(527, 456);
			this.button_addCard.Name = "button_addCard";
			this.button_addCard.Size = new System.Drawing.Size(64, 28);
			this.button_addCard.TabIndex = 19;
			this.button_addCard.Text = "添加(&A)";
			this.button_addCard.UseVisualStyleBackColor = false;
			this.button_addCard.Click += new System.EventHandler(this.Button_addCard_Click);
			// 
			// button_moCard
			// 
			this.button_moCard.BackColor = System.Drawing.SystemColors.Control;
			this.button_moCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_moCard.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_moCard.Location = new System.Drawing.Point(598, 456);
			this.button_moCard.Name = "button_moCard";
			this.button_moCard.Size = new System.Drawing.Size(64, 28);
			this.button_moCard.TabIndex = 20;
			this.button_moCard.Text = "修改(&M)";
			this.button_moCard.UseVisualStyleBackColor = false;
			this.button_moCard.Click += new System.EventHandler(this.Button_moCard_Click);
			// 
			// button_delCard
			// 
			this.button_delCard.BackColor = System.Drawing.SystemColors.Control;
			this.button_delCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_delCard.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_delCard.Location = new System.Drawing.Point(740, 456);
			this.button_delCard.Name = "button_delCard";
			this.button_delCard.Size = new System.Drawing.Size(64, 28);
			this.button_delCard.TabIndex = 22;
			this.button_delCard.Text = "删除(&D)";
			this.button_delCard.UseVisualStyleBackColor = false;
			this.button_delCard.Click += new System.EventHandler(this.Button_delCard_Click);
			// 
			// button_cancelCard
			// 
			this.button_cancelCard.BackColor = System.Drawing.SystemColors.Control;
			this.button_cancelCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_cancelCard.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_cancelCard.Location = new System.Drawing.Point(413, 457);
			this.button_cancelCard.Name = "button_cancelCard";
			this.button_cancelCard.Size = new System.Drawing.Size(60, 28);
			this.button_cancelCard.TabIndex = 23;
			this.button_cancelCard.Text = "撤销(&Z)";
			this.button_cancelCard.UseVisualStyleBackColor = false;
			this.button_cancelCard.Click += new System.EventHandler(this.Button_cancelCard_Click);
			// 
			// listView_Cards
			// 
			this.listView_Cards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2});
			this.listView_Cards.FullRowSelect = true;
			this.listView_Cards.GridLines = true;
			this.listView_Cards.HideSelection = false;
			this.listView_Cards.Location = new System.Drawing.Point(2, 26);
			this.listView_Cards.Name = "listView_Cards";
			this.listView_Cards.Size = new System.Drawing.Size(232, 428);
			this.listView_Cards.TabIndex = 8;
			this.listView_Cards.UseCompatibleStateImageBehavior = false;
			this.listView_Cards.View = System.Windows.Forms.View.Details;
			this.listView_Cards.SelectedIndexChanged += new System.EventHandler(this.ListView_CardsSelectedIndexChanged);
			this.listView_Cards.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListView_Cards_KeyDown);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "密码";
			this.columnHeader1.Width = 62;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "名字";
			this.columnHeader2.Width = 165;
			// 
			// button_next
			// 
			this.button_next.BackColor = System.Drawing.SystemColors.Control;
			this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_next.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_next.Location = new System.Drawing.Point(174, 457);
			this.button_next.Name = "button_next";
			this.button_next.Size = new System.Drawing.Size(58, 28);
			this.button_next.TabIndex = 10;
			this.button_next.Text = "下一页";
			this.button_next.UseVisualStyleBackColor = false;
			this.button_next.Click += new System.EventHandler(this.Button_next_Click);
			// 
			// button_forword
			// 
			this.button_forword.BackColor = System.Drawing.SystemColors.Control;
			this.button_forword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_forword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_forword.Location = new System.Drawing.Point(2, 457);
			this.button_forword.Margin = new System.Windows.Forms.Padding(0);
			this.button_forword.Name = "button_forword";
			this.button_forword.Size = new System.Drawing.Size(58, 28);
			this.button_forword.TabIndex = 9;
			this.button_forword.Text = "上一页";
			this.button_forword.UseVisualStyleBackColor = false;
			this.button_forword.Click += new System.EventHandler(this.Button_forword_Click);
			// 
			// textBox_page
			// 
			this.textBox_page.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox_page.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.textBox_page.Location = new System.Drawing.Point(64, 460);
			this.textBox_page.MaxLength = 8;
			this.textBox_page.Name = "textBox_page";
			this.textBox_page.Size = new System.Drawing.Size(44, 23);
			this.textBox_page.TabIndex = 11;
			this.textBox_page.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox_page.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_page_KeyDown);
			// 
			// textBox_count
			// 
			this.textBox_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox_count.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.textBox_count.Location = new System.Drawing.Point(124, 460);
			this.textBox_count.Name = "textBox_count";
			this.textBox_count.ReadOnly = true;
			this.textBox_count.Size = new System.Drawing.Size(44, 23);
			this.textBox_count.TabIndex = 12;
			this.textBox_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(111, 465);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(11, 12);
			this.label1.TabIndex = 13;
			this.label1.Text = "/";
			// 
			// check_effect
			// 
			this.check_effect.BackColor = System.Drawing.SystemColors.Control;
			this.check_effect.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.check_effect.CheckOnClick = true;
			this.check_effect.ColumnWidth = 72;
			this.check_effect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.check_effect.FormattingEnabled = true;
			this.check_effect.Items.AddRange(new object[] {
									"魔陷破坏",
									"怪兽破坏",
									"除外卡片",
									"送去墓地",
									"返回手牌",
									"返回卡组",
									"手牌破坏",
									"卡组破坏",
									"抽卡辅助",
									"卡组检索",
									"卡片回收",
									"表示变更",
									"控制权",
									"攻守变化",
									"贯穿伤害",
									"多次攻击",
									"限制攻击",
									"直接攻击",
									"特殊召唤",
									"衍生物",
									"种族相关",
									"属性相关",
									"LP伤害",
									"LP回复",
									"破坏耐性",
									"效果耐性",
									"指示物",
									"幸运相关",
									"融合相关",
									"同调相关",
									"超量相关",
									"效果无效"});
			this.check_effect.Location = new System.Drawing.Point(237, 291);
			this.check_effect.MultiColumn = true;
			this.check_effect.Name = "check_effect";
			this.check_effect.Size = new System.Drawing.Size(292, 162);
			this.check_effect.TabIndex = 18;
			// 
			// check_type
			// 
			this.check_type.BackColor = System.Drawing.SystemColors.Control;
			this.check_type.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.check_type.CheckOnClick = true;
			this.check_type.ColumnWidth = 72;
			this.check_type.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.check_type.FormattingEnabled = true;
			this.check_type.Items.AddRange(new object[] {
									"怪兽",
									"魔法",
									"陷阱",
									"通常",
									"效果",
									"融合",
									"仪式",
									"陷阱怪兽",
									"灵魂",
									"同盟",
									"二重",
									"调整",
									"同调",
									"衍生物",
									"速攻",
									"永续",
									"装备",
									"场地",
									"反击",
									"反转",
									"卡通",
									"超量"});
			this.check_type.Location = new System.Drawing.Point(239, 159);
			this.check_type.MultiColumn = true;
			this.check_type.Name = "check_type";
			this.check_type.Size = new System.Drawing.Size(290, 108);
			this.check_type.TabIndex = 17;
			// 
			// label_def
			// 
			this.label_def.AutoSize = true;
			this.label_def.Location = new System.Drawing.Point(439, 59);
			this.label_def.Name = "label_def";
			this.label_def.Size = new System.Drawing.Size(23, 12);
			this.label_def.TabIndex = 142;
			this.label_def.Text = "DEF";
			// 
			// textBox_def
			// 
			this.textBox_def.Location = new System.Drawing.Point(468, 54);
			this.textBox_def.MaxLength = 5;
			this.textBox_def.Name = "textBox_def";
			this.textBox_def.Size = new System.Drawing.Size(52, 21);
			this.textBox_def.TabIndex = 9;
			this.textBox_def.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBox_atk
			// 
			this.textBox_atk.Location = new System.Drawing.Point(380, 54);
			this.textBox_atk.MaxLength = 5;
			this.textBox_atk.Name = "textBox_atk";
			this.textBox_atk.Size = new System.Drawing.Size(53, 21);
			this.textBox_atk.TabIndex = 8;
			this.textBox_atk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label_atk
			// 
			this.label_atk.AutoSize = true;
			this.label_atk.Location = new System.Drawing.Point(351, 59);
			this.label_atk.Name = "label_atk";
			this.label_atk.Size = new System.Drawing.Size(23, 12);
			this.label_atk.TabIndex = 139;
			this.label_atk.Text = "ATK";
			// 
			// textBox_alias
			// 
			this.textBox_alias.Location = new System.Drawing.Point(437, 110);
			this.textBox_alias.MaxLength = 10;
			this.textBox_alias.Name = "textBox_alias";
			this.textBox_alias.Size = new System.Drawing.Size(84, 21);
			this.textBox_alias.TabIndex = 13;
			this.textBox_alias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBox_alias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_alias_KeyPress);
			// 
			// label_alias
			// 
			this.label_alias.AutoSize = true;
			this.label_alias.Location = new System.Drawing.Point(392, 114);
			this.label_alias.Name = "label_alias";
			this.label_alias.Size = new System.Drawing.Size(41, 12);
			this.label_alias.TabIndex = 137;
			this.label_alias.Text = "同名卡";
			// 
			// label_code
			// 
			this.label_code.AutoSize = true;
			this.label_code.Location = new System.Drawing.Point(237, 113);
			this.label_code.Name = "label_code";
			this.label_code.Size = new System.Drawing.Size(29, 12);
			this.label_code.TabIndex = 136;
			this.label_code.Text = "密码";
			// 
			// textBox_code
			// 
			this.textBox_code.Location = new System.Drawing.Point(269, 109);
			this.textBox_code.MaxLength = 10;
			this.textBox_code.Name = "textBox_code";
			this.textBox_code.Size = new System.Drawing.Size(78, 21);
			this.textBox_code.TabIndex = 12;
			this.textBox_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBox_code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_code_KeyDown);
			this.textBox_code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_code_KeyPress);
			// 
			// label_category
			// 
			this.label_category.AutoSize = true;
			this.label_category.Location = new System.Drawing.Point(237, 274);
			this.label_category.Name = "label_category";
			this.label_category.Size = new System.Drawing.Size(65, 12);
			this.label_category.TabIndex = 134;
			this.label_category.Text = "效果分类：";
			// 
			// label_type
			// 
			this.label_type.AutoSize = true;
			this.label_type.Location = new System.Drawing.Point(237, 140);
			this.label_type.Name = "label_type";
			this.label_type.Size = new System.Drawing.Size(65, 12);
			this.label_type.TabIndex = 133;
			this.label_type.Text = "卡片分类：";
			// 
			// label_setname
			// 
			this.label_setname.AutoSize = true;
			this.label_setname.Location = new System.Drawing.Point(236, 84);
			this.label_setname.Name = "label_setname";
			this.label_setname.Size = new System.Drawing.Size(29, 12);
			this.label_setname.TabIndex = 132;
			this.label_setname.Text = "系列";
			this.label_setname.Click += new System.EventHandler(this.label_setname_Click);
			// 
			// label_attribute
			// 
			this.label_attribute.AutoSize = true;
			this.label_attribute.Location = new System.Drawing.Point(348, 33);
			this.label_attribute.Name = "label_attribute";
			this.label_attribute.Size = new System.Drawing.Size(29, 12);
			this.label_attribute.TabIndex = 131;
			this.label_attribute.Text = "属性";
			// 
			// label_level
			// 
			this.label_level.AutoSize = true;
			this.label_level.Location = new System.Drawing.Point(438, 34);
			this.label_level.Name = "label_level";
			this.label_level.Size = new System.Drawing.Size(29, 12);
			this.label_level.TabIndex = 130;
			this.label_level.Text = "星数";
			// 
			// label_rule
			// 
			this.label_rule.AutoSize = true;
			this.label_rule.Location = new System.Drawing.Point(237, 33);
			this.label_rule.Name = "label_rule";
			this.label_rule.Size = new System.Drawing.Size(29, 12);
			this.label_rule.TabIndex = 129;
			this.label_rule.Text = "规则";
			// 
			// label_race
			// 
			this.label_race.AutoSize = true;
			this.label_race.Location = new System.Drawing.Point(237, 59);
			this.label_race.Name = "label_race";
			this.label_race.Size = new System.Drawing.Size(29, 12);
			this.label_race.TabIndex = 128;
			this.label_race.Text = "种族";
			// 
			// comboBox_setname2
			// 
			this.comboBox_setname2.DropDownHeight = 450;
			this.comboBox_setname2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_setname2.FormattingEnabled = true;
			this.comboBox_setname2.IntegralHeight = false;
			this.comboBox_setname2.Items.AddRange(new object[] {
									"(N/A)"});
			this.comboBox_setname2.Location = new System.Drawing.Point(397, 82);
			this.comboBox_setname2.Name = "comboBox_setname2";
			this.comboBox_setname2.Size = new System.Drawing.Size(124, 20);
			this.comboBox_setname2.TabIndex = 11;
			// 
			// comboBox_setname1
			// 
			this.comboBox_setname1.DropDownHeight = 450;
			this.comboBox_setname1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_setname1.FormattingEnabled = true;
			this.comboBox_setname1.IntegralHeight = false;
			this.comboBox_setname1.Items.AddRange(new object[] {
									"(N/A)"});
			this.comboBox_setname1.Location = new System.Drawing.Point(269, 82);
			this.comboBox_setname1.Name = "comboBox_setname1";
			this.comboBox_setname1.Size = new System.Drawing.Size(124, 20);
			this.comboBox_setname1.TabIndex = 10;
			// 
			// comboBox_race
			// 
			this.comboBox_race.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_race.FormattingEnabled = true;
			this.comboBox_race.Items.AddRange(new object[] {
									"(N/A)",
									"战士",
									"魔法使",
									"天使",
									"恶魔",
									"不死",
									"机械",
									"水",
									"炎",
									"岩石",
									"鸟兽",
									"植物",
									"昆虫",
									"雷",
									"龙",
									"兽",
									"兽战士",
									"恐龙",
									"鱼",
									"海龙",
									"爬虫类",
									"念动力",
									"幻神兽",
									"创造神"});
			this.comboBox_race.Location = new System.Drawing.Point(269, 55);
			this.comboBox_race.Name = "comboBox_race";
			this.comboBox_race.Size = new System.Drawing.Size(74, 20);
			this.comboBox_race.TabIndex = 7;
			// 
			// comboBox_level
			// 
			this.comboBox_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_level.FormattingEnabled = true;
			this.comboBox_level.Items.AddRange(new object[] {
									"(N/A)",
									"1★",
									"2★",
									"3★",
									"4★",
									"5★",
									"6★",
									"7★",
									"8★",
									"9★",
									"10★",
									"11★",
									"12★",
									"13★"});
			this.comboBox_level.Location = new System.Drawing.Point(467, 29);
			this.comboBox_level.Name = "comboBox_level";
			this.comboBox_level.Size = new System.Drawing.Size(52, 20);
			this.comboBox_level.TabIndex = 6;
			// 
			// comboBox_attribute
			// 
			this.comboBox_attribute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_attribute.FormattingEnabled = true;
			this.comboBox_attribute.Items.AddRange(new object[] {
									"(N/A)",
									"地",
									"水",
									"炎",
									"风",
									"光",
									"暗",
									"神"});
			this.comboBox_attribute.Location = new System.Drawing.Point(380, 29);
			this.comboBox_attribute.Name = "comboBox_attribute";
			this.comboBox_attribute.Size = new System.Drawing.Size(52, 20);
			this.comboBox_attribute.TabIndex = 5;
			// 
			// comboBox_rule
			// 
			this.comboBox_rule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_rule.FormattingEnabled = true;
			this.comboBox_rule.Items.AddRange(new object[] {
									"(N/A)",
									"OCG",
									"TCG",
									"OCG&TCG",
									"Anime"});
			this.comboBox_rule.Location = new System.Drawing.Point(269, 29);
			this.comboBox_rule.Name = "comboBox_rule";
			this.comboBox_rule.Size = new System.Drawing.Size(75, 20);
			this.comboBox_rule.TabIndex = 4;
			// 
			// textBox_str
			// 
			this.textBox_str.Location = new System.Drawing.Point(3, 385);
			this.textBox_str.MaxLength = 400;
			this.textBox_str.Multiline = true;
			this.textBox_str.Name = "textBox_str";
			this.textBox_str.Size = new System.Drawing.Size(270, 41);
			this.textBox_str.TabIndex = 16;
			this.textBox_str.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_str_KeyDown);
			this.textBox_str.Leave += new System.EventHandler(this.TextBox_str_Leave);
			// 
			// listBox_str
			// 
			this.listBox_str.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listBox_str.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.listBox_str.FormattingEnabled = true;
			this.listBox_str.ItemHeight = 12;
			this.listBox_str.Location = new System.Drawing.Point(2, 237);
			this.listBox_str.Name = "listBox_str";
			this.listBox_str.ScrollAlwaysVisible = true;
			this.listBox_str.Size = new System.Drawing.Size(270, 146);
			this.listBox_str.TabIndex = 15;
			this.listBox_str.SelectedIndexChanged += new System.EventHandler(this.ListBox_str_SelectedIndexChanged);
			// 
			// textBox_name
			// 
			this.textBox_name.Location = new System.Drawing.Point(268, 3);
			this.textBox_name.MaxLength = 200;
			this.textBox_name.Name = "textBox_name";
			this.textBox_name.Size = new System.Drawing.Size(252, 21);
			this.textBox_name.TabIndex = 3;
			this.textBox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_name_KeyDown);
			// 
			// label_cardname
			// 
			this.label_cardname.AutoSize = true;
			this.label_cardname.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label_cardname.Location = new System.Drawing.Point(237, 4);
			this.label_cardname.Name = "label_cardname";
			this.label_cardname.Size = new System.Drawing.Size(32, 17);
			this.label_cardname.TabIndex = 143;
			this.label_cardname.Text = "名字";
			// 
			// button_lua
			// 
			this.button_lua.BackColor = System.Drawing.SystemColors.Control;
			this.button_lua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button_lua.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button_lua.Location = new System.Drawing.Point(669, 456);
			this.button_lua.Name = "button_lua";
			this.button_lua.Size = new System.Drawing.Size(64, 28);
			this.button_lua.TabIndex = 21;
			this.button_lua.Text = "脚本(&L)";
			this.button_lua.UseVisualStyleBackColor = false;
			this.button_lua.Click += new System.EventHandler(this.Button_lua_Click);
			// 
			// textBox_desc
			// 
			this.textBox_desc.AcceptsReturn = true;
			this.textBox_desc.AcceptsTab = true;
			this.textBox_desc.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.textBox_desc.Location = new System.Drawing.Point(3, 3);
			this.textBox_desc.Multiline = true;
			this.textBox_desc.Name = "textBox_desc";
			this.textBox_desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_desc.Size = new System.Drawing.Size(270, 211);
			this.textBox_desc.TabIndex = 14;
			this.textBox_desc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_desc_KeyPress);
			// 
			// tabControl_text
			// 
			this.tabControl_text.AllowDrop = true;
			this.tabControl_text.Controls.Add(this.tab_luaText);
			this.tabControl_text.Controls.Add(this.tabPage_jpg);
			this.tabControl_text.Location = new System.Drawing.Point(524, -1);
			this.tabControl_text.Margin = new System.Windows.Forms.Padding(0);
			this.tabControl_text.Name = "tabControl_text";
			this.tabControl_text.SelectedIndex = 0;
			this.tabControl_text.Size = new System.Drawing.Size(284, 455);
			this.tabControl_text.TabIndex = 154;
			// 
			// tab_luaText
			// 
			this.tab_luaText.BackColor = System.Drawing.SystemColors.Control;
			this.tab_luaText.Controls.Add(this.textBox_desc);
			this.tab_luaText.Controls.Add(this.listBox_str);
			this.tab_luaText.Controls.Add(this.textBox_str);
			this.tab_luaText.Controls.Add(this.label_scripttext);
			this.tab_luaText.Location = new System.Drawing.Point(4, 22);
			this.tab_luaText.Name = "tab_luaText";
			this.tab_luaText.Padding = new System.Windows.Forms.Padding(3);
			this.tab_luaText.Size = new System.Drawing.Size(276, 429);
			this.tab_luaText.TabIndex = 0;
			this.tab_luaText.Text = "卡片文字";
			// 
			// label_scripttext
			// 
			this.label_scripttext.AutoSize = true;
			this.label_scripttext.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label_scripttext.Location = new System.Drawing.Point(4, 217);
			this.label_scripttext.Name = "label_scripttext";
			this.label_scripttext.Size = new System.Drawing.Size(68, 17);
			this.label_scripttext.TabIndex = 149;
			this.label_scripttext.Text = "脚本文本：";
			// 
			// tabPage_jpg
			// 
			this.tabPage_jpg.AllowDrop = true;
			this.tabPage_jpg.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage_jpg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.tabPage_jpg.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tabPage_jpg.Location = new System.Drawing.Point(4, 22);
			this.tabPage_jpg.Name = "tabPage_jpg";
			this.tabPage_jpg.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_jpg.Size = new System.Drawing.Size(276, 429);
			this.tabPage_jpg.TabIndex = 1;
			this.tabPage_jpg.Text = "卡片图片";
			this.tabPage_jpg.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabPage_jpg_DragDrop);
			this.tabPage_jpg.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabPage_jpg_DragEnter);
			// 
			// textBox_setname
			// 
			this.textBox_setname.Location = new System.Drawing.Point(269, 81);
			this.textBox_setname.MaxLength = 200;
			this.textBox_setname.Name = "textBox_setname";
			this.textBox_setname.Size = new System.Drawing.Size(253, 21);
			this.textBox_setname.TabIndex = 155;
			this.textBox_setname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox_setname.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(808, 488);
			this.Controls.Add(this.textBox_setname);
			this.Controls.Add(this.tabControl_text);
			this.Controls.Add(this.button_lua);
			this.Controls.Add(this.textBox_name);
			this.Controls.Add(this.label_cardname);
			this.Controls.Add(this.label_def);
			this.Controls.Add(this.textBox_def);
			this.Controls.Add(this.textBox_atk);
			this.Controls.Add(this.label_atk);
			this.Controls.Add(this.textBox_alias);
			this.Controls.Add(this.label_alias);
			this.Controls.Add(this.label_code);
			this.Controls.Add(this.textBox_code);
			this.Controls.Add(this.label_category);
			this.Controls.Add(this.label_type);
			this.Controls.Add(this.label_setname);
			this.Controls.Add(this.label_attribute);
			this.Controls.Add(this.label_level);
			this.Controls.Add(this.label_rule);
			this.Controls.Add(this.label_race);
			this.Controls.Add(this.comboBox_setname2);
			this.Controls.Add(this.comboBox_setname1);
			this.Controls.Add(this.comboBox_race);
			this.Controls.Add(this.comboBox_level);
			this.Controls.Add(this.comboBox_attribute);
			this.Controls.Add(this.comboBox_rule);
			this.Controls.Add(this.check_effect);
			this.Controls.Add(this.check_type);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_count);
			this.Controls.Add(this.textBox_page);
			this.Controls.Add(this.button_next);
			this.Controls.Add(this.button_forword);
			this.Controls.Add(this.listView_Cards);
			this.Controls.Add(this.button_cancelCard);
			this.Controls.Add(this.button_delCard);
			this.Controls.Add(this.button_moCard);
			this.Controls.Add(this.button_addCard);
			this.Controls.Add(this.button_resetCard);
			this.Controls.Add(this.button_searchCard);
			this.Controls.Add(this.toolStripContainer1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DataEditorV2";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.tabControl_text.ResumeLayout(false);
			this.tab_luaText.ResumeLayout(false);
			this.tab_luaText.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_export;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_copycards;
		private System.Windows.Forms.TextBox textBox_desc;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_cdblist;
		private System.Windows.Forms.Button button_lua;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_notepad;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_gamepath;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_setpath;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Getjpg;
		private System.Windows.Forms.Label label_cardname;
        private System.Windows.Forms.TextBox textBox_name;
		private System.Windows.Forms.ListBox listBox_str;
		private System.Windows.Forms.TextBox textBox_str;
		private System.Windows.Forms.ComboBox comboBox_rule;
		private System.Windows.Forms.ComboBox comboBox_attribute;
		private System.Windows.Forms.ComboBox comboBox_level;
		private System.Windows.Forms.ComboBox comboBox_race;
		private System.Windows.Forms.ComboBox comboBox_setname1;
		private System.Windows.Forms.ComboBox comboBox_setname2;
		private System.Windows.Forms.Label label_race;
		private System.Windows.Forms.Label label_rule;
		private System.Windows.Forms.Label label_level;
		private System.Windows.Forms.Label label_attribute;
		private System.Windows.Forms.Label label_setname;
		private System.Windows.Forms.Label label_type;
		private System.Windows.Forms.Label label_category;
		private System.Windows.Forms.TextBox textBox_code;
		private System.Windows.Forms.Label label_code;
		private System.Windows.Forms.Label label_alias;
		private System.Windows.Forms.TextBox textBox_alias;
		private System.Windows.Forms.Label label_atk;
		private System.Windows.Forms.TextBox textBox_atk;
		private System.Windows.Forms.TextBox textBox_def;
		private System.Windows.Forms.Label label_def;
		private System.Windows.Forms.CheckedListBox check_type;
		private System.Windows.Forms.CheckedListBox check_effect;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_count;
		private System.Windows.Forms.TextBox textBox_page;
		private System.Windows.Forms.Button button_forword;
		private System.Windows.Forms.Button button_next;
		private System.Windows.Forms.ListView listView_Cards;
		private System.Windows.Forms.Button button_cancelCard;
		private System.Windows.Forms.Button button_delCard;
		private System.Windows.Forms.Button button_moCard;
		private System.Windows.Forms.Button button_addCard;
		private System.Windows.Forms.Button button_resetCard;
		private System.Windows.Forms.Button button_searchCard;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_game;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_cutJPG;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_resizeJPG;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_MSE;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_Tools;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_SearchJPG;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_ReadYDK;
		private System.Windows.Forms.ToolStripMenuItem ToolStrip_File;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_yulan;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_cutfolder;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_stratcut;
        private System.Windows.Forms.TabControl tabControl_text;
        private System.Windows.Forms.TabPage tab_luaText;
        private System.Windows.Forms.Label label_scripttext;
        private System.Windows.Forms.TabPage tabPage_jpg;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_about;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_startcut;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_opencutjpg;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_netdisk;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_opengpath;
        private System.Windows.Forms.TextBox textBox_setname;
	}
}
