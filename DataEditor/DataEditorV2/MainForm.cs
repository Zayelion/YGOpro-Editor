using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using CCFun;
using YGOPRO;
using CCImage;

namespace DataEditorV2
{
	public partial class MainForm : Form
	{
        private string path,CDBfile, select_str, setfile;
        private string baidu = "http://pan.baidu.com/share/home?uk=3137506169";
        private StringBuilder SQL;
        private int Count, Pnum, P;
        private int MAX = 25;
        private string[] str;
        private void Resetname()
        {
            comboBox_setname1.Items.Clear();
            comboBox_setname2.Items.Clear();
            foreach (int key in SET.setname.Keys)
            {
                comboBox_setname1.Items.Add(SET.setname[key]);
                comboBox_setname2.Items.Add(SET.setname[key]);
            }
            comboBox_setname1.SelectedIndex = 0;
            comboBox_setname2.SelectedIndex = 0;
        }
        private void AddCDBlist()
        {
            int a = ToolStrip_cdblist.DropDownItems.Count;
            ToolStripMenuItem ts;
            foreach(string db in SET.LastCDB)
            {
                if (File.Exists(db))
                {
                    ts = new ToolStripMenuItem(db, null, ToolStrip_CDBlist_Click);
                    if (CDBfile.Equals(db))
                    {
                        ts.Checked = true;
                    }
                    ToolStrip_cdblist.DropDownItems.Add(ts);
                    a++;
                }
            }
        }
        private void Add_Strlist()
        {
            listBox_str.Items.Clear();
            for (int i = 0; i < 0x10; i++)
            {
                listBox_str.Items.Add(str[i]);
            }
        }
        private void Set_strlist()
        {
            int n = -1;
            try
            {
                n = listBox_str.SelectedIndex;
            }
            catch { }
            if (n >= 0)
            {
                str[n] = textBox_str.Text;
                Add_Strlist();
            }
        }
        private void GetSelect()
        {
            select_str= CCFile.GetSelect(GetCard());
        }
        private void intilControl()
        {
            int i;
            for (i = 0; i < 0x10; i++)
            {
                str[i] = "";
            }
            Add_Strlist();
            comboBox_rule.SelectedIndex = 0;
            comboBox_race.SelectedIndex = 0;
            comboBox_level.SelectedIndex = 0;
            comboBox_attribute.SelectedIndex = 0;
            textBox_name.Text = "";
            textBox_desc.Text = "";
            textBox_atk.Text = "";
            textBox_code.Text = "";
            textBox_def.Text = "";
            textBox_alias.Text = "";
            textBox_str.Text = "";
                        comboBox_setname1.SelectedIndex = 0;
            comboBox_setname2.SelectedIndex = 0;
            for (i = 0; i < 0x20; i++)
            {
                check_effect.SetItemChecked(i, false);
            }
            for (i = 0; i < 0x16; i++)
            {
                check_type.SetItemChecked(i, false);
            }
        }
        private void SetNum()
        {
            Pnum = Count / MAX;
            if (Pnum * MAX < Count)
            {
                Pnum++;
            }
            if (Pnum == 0)
                Pnum = 1;
            textBox_count.Text = Pnum.ToString();
            listView_Cards.Columns[1].Text = "名字   (" + Count.ToString() + ")";
        }
        private void Add_cardslist()
        {
            if (P > Pnum)
                P = Pnum;
            else if (P <= 0)
                P = 1;
            textBox_page.Text = P.ToString();
            int a = (P - 1) * MAX;
            int b = P * MAX;
            if (b > Count)
                b = Count;
            listView_Cards.Items.Clear();
            int i, j = 0, id = 0;
            for (i = a; i < b; i++, j++)
            {
                if (CDB.ids.ContainsKey(i))
                {
                    id = CDB.ids[i];
                    listView_Cards.Items.Add(id.ToString());
                    if (CDB.cards.ContainsKey(id))
                    {
                        listView_Cards.Items[j].SubItems.Add(CDB.cards[id].name);
                    }
                }
            }
        }
        private void ReadData()
        {
            CDB.Read(CDBfile, select_str);
            Count = CDB.ids.Count;
            SetNum();
                Add_cardslist();
        }       
        private void Setcard(int id)
        {
            if (CDB.cards.ContainsKey(id))
            {
                int index;
                int snum;
                CardData data = CDB.cards[id];
                textBox_code.Text = data.code.ToString();
                textBox_name.Text = data.name;
                textBox_desc.Text = data.text.Replace("\n", "\r\n");
                textBox_setname.Text = "0x"+data.setcode.ToString("x");
                listBox_str.Items.Clear();
                str = data.desc;
                for (index = 0; index < 0x10; index++)
                {
                    listBox_str.Items.Add(data.desc[index]);
                }
                textBox_atk.Text = data.attack.ToString();
                textBox_def.Text = data.defence.ToString();
                textBox_alias.Text = data.alias.ToString();
                comboBox_level.SelectedIndex = data.level;
                comboBox_rule.SelectedIndex = data.ot;
                comboBox_race.SelectedIndex = CCFile.GetSelectIndex(data.race);
                comboBox_attribute.SelectedIndex = CCFile.GetSelectIndex(data.attribute);
                snum = data.setcode & 0xffff;
                if (!SET.setname.ContainsKey(snum))
                {
                    SET.setname.Add(snum, data.name);
                    Resetname();
                }
                comboBox_setname1.Text = SET.setname[snum];
                snum = data.setcode >> 0x10;
                if (!SET.setname.ContainsKey(snum))
                {
                    SET.setname.Add(snum, data.name);
                    Resetname();
                }
                comboBox_setname2.Text = SET.setname[snum];
                SetChecked_type(data.type);
                SetChecked_category(data.category);
                textBox_str.Text = "";
                tabPage_jpg.BackgroundImage= CCFile.Setjpg(SET.GamePath,ToolStrip_yulan.Checked, id,SET.Length);
            }
        }
        private CardData GetCard()
        {
            int i = 0;
            CardData data = new CardData();
            {
                int.TryParse(textBox_code.Text, out data.code);
                int.TryParse(textBox_atk.Text, out data.attack);
                int.TryParse(textBox_def.Text, out data.defence);
                int.TryParse(textBox_alias.Text, out data.alias);
            }
            {
                data.level = comboBox_level.SelectedIndex;
                data.name = textBox_name.Text;
                data.text = textBox_desc.Text;
                data.desc = str;
                data.ot = comboBox_rule.SelectedIndex;
            }
            if (textBox_setname.Visible == true)
            {
                int.TryParse(textBox_setname.Text.Replace("0x",""), System.Globalization.NumberStyles.HexNumber, null, out data.setcode);
            }
            else
            {
                data.setcode = CCFile.Getint(SET.setname, comboBox_setname1.Text);
                data.setcode += (CCFile.Getint(SET.setname, comboBox_setname2.Text) << 0x10);
            }
            i = comboBox_race.SelectedIndex;
            if (i == 0)
            {
                data.race = 0;
            }
            else
            {
                data.race = ((int)1) << (i - 1);
            }
            i = comboBox_attribute.SelectedIndex;
            if (i == 0)
            {
                data.attribute = 0;
            }
            else
            {
                data.attribute = ((int)1) << (i - 1);
            }
            data.type = Get_type();
            data.category = Get_category();
            return data;
        }
        private long Get_category()
        {
            long category = 0;
            uint num = 1;
            int num4 = 0;
            while (num4 < 0x20)
            {
                if (check_effect.GetItemChecked(num4))
                {
                    category += num;
                }
                num4++;
                num = num << 1;
            }
            return category;
        }
        private int Get_type()
        {
            int type = 0;
            int num3 = 1, num4 = 0;
            while (num3 != 0x1000000)
            {
                if ((num3 != 8) && (num3 != 0x8000))
                {
                    if (check_type.GetItemChecked(num4))
                    {
                        type |= num3;
                    }
                    num4++;
                }
                num3 = num3 << 1;
            }
            return type;
        }       
        private void SetChecked_category(long category)
        {
            int index = 0;
            uint num;
            for (num = 1; index < 0x20; num = num << 1)
            {
                if ((num & category) != 0L)
                {
                    check_effect.SetItemChecked(index, true);
                }
                else
                {
                    check_effect.SetItemChecked(index, false);
                }
                index++;
            }
        }
        private void SetChecked_type(int type)
        {
            int index = 0;
            uint num;
            for (num = 1; num != 0x1000000; num = num << 1)
            {
                if ((num != 8) && (num != 0x8000))
                {
                    if ((num & type) != 0L)
                    {
                        check_type.SetItemChecked(index, true);
                    }
                    else
                    {
                        check_type.SetItemChecked(index, false);
                    }
                    index++;
                }
            }
        } 
		public MainForm()
		{
			InitializeComponent();
            path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
		}
		private void MainForm_Load(object sender, EventArgs e)
		{
			str=new string[0x10];
			SQL=new StringBuilder();
            setfile = path+@"data\DataEditorV2.conf";
            select_str = "";
            CDBfile = "";
			SET.ReadSet(setfile);
			SET.ReadSetName(path+@"data\setname.txt");
            SET.ReadCDB(path + @"data\lastcdb.conf");
            SET.Readrespace(path + @"data\respace.conf");
            if (SET.GamePath.Length < 3)
            {
                SET.GamePath = path;
            }
            intilControl();
            Resetname();
            ToolStrip_opengpath.ToolTipText = SET.GamePath;
            ToolStrip_gamepath.ToolTipText = SET.GamePath;
            ToolStrip_notepad.ToolTipText = SET.NPPpath;
            ToolStrip_game.ToolTipText = SET.GameName;
            ToolStrip_netdisk.ToolTipText = baidu;
            ToolStrip_about.ToolTipText = "作者：菜菜";
		}	
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SET.SaveSet(setfile);
            SET.Savesetname(path + @"data\setname.txt");
            SET.SaveCDB(path + @"data\lastcdb.conf");
		}				
		private void TextBox_str_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				Set_strlist();
			}
		}		
		private void TextBox_str_Leave(object sender, EventArgs e)
		{
			Set_strlist();
		}
		private void TextBox_page_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				if(int.TryParse(textBox_page.Text,out P))
				{
					Add_cardslist();
				}
			}
		}
        private void textBox_code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button_searchCard_Click(null, null);
            }
        }
        private void textBox_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button_searchCard_Click(null, null);
            }
        }
        private void textBox_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!CCFile.Check_KeyisInt(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBox_alias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!CCFile.Check_KeyisInt(e.KeyChar))
            {
                e.Handled = true;
            }
        }
		private void Button_searchCard_Click(object sender, EventArgs e)
		{
			GetSelect();
			P=1;
			ReadData();
		}				
		private void Button_forword_Click(object sender, EventArgs e)
		{
			P--;
			Add_cardslist();

		}		
		private void Button_next_Click(object sender, EventArgs e)
		{
			P++;
			Add_cardslist();
		}
		private void Button_lua_Click(object sender, EventArgs e)
		{
			if(textBox_code.Text.Length>0)
			{
                CCFile.CheckFolder(SET.GamePath+@"script");
				string luafile=SET.GamePath+@"script\c"+textBox_code.Text+".lua";
				if(!File.Exists(luafile))
				{		
					if(MessageBox.Show("是否创建？\n"+luafile,"提示",MessageBoxButtons.OKCancel)==DialogResult.OK)
					{
						CCFile.WriteText(luafile,"--"+textBox_name.Text+"\n",new UTF8Encoding(false));
					}
				}
				if(File.Exists(luafile))
				{
					if(File.Exists(SET.NPPpath))
					{
						CCFile.RUN(SET.NPPpath," \""+luafile+"\"");
					}
					else
					{
						luaEditor le=new luaEditor(luafile);
						le.Show();
					}
				}
			}
		}
		private void Button_addCard_Click(object sender, EventArgs e)
		{
            CardData data = GetCard();
			string sql=CDB.GetInsertSQL(data);
			if(CDB.Command(CDBfile,sql)<2)
			{
				MessageBox.Show("添加失败！\n卡片已经存在！","错误");
			}
			else
			{
				SQL.Append("delete from datas where id=");
				SQL.Append(data.code.ToString());
				SQL.Append(";delete from texts where id=");
				SQL.Append(data.code.ToString());
                SQL.Append(";");
				ReadData();
			}
		}		
		private void Button_moCard_Click(object sender, EventArgs e)
		{
			string sql1,sql2;
			int id;
			ListView.SelectedIndexCollection c =listView_Cards.SelectedIndices;
			if(c.Count>0)
			{
				if(int.TryParse(listView_Cards.Items[c[0]].SubItems[0].Text,out id))
				{
                    sql1 = CDB.GetUpdataSQL(CDB.cards[id]);
                    SQL.Append(sql1);
					sql2 =CDB.GetUpdataSQL(GetCard());
					//MessageBox.Show(sql[0]+"\n"+sql[1]);
                    if (CDB.Command(CDBfile, sql2) < 2)
					{
						MessageBox.Show("修改失败！\n如果修改密码，请先添加再删除。","错误");
					}
					else
					{
						ReadData();
					}
				}
			}	
		}		
		private void Button_delCard_Click(object sender, EventArgs e)
		{
			int Pid=0;
			StringBuilder dsql=new StringBuilder();
			ListView.SelectedIndexCollection c =listView_Cards.SelectedIndices;
			if(c.Count>0)
			{
				for(int i=0;i<c.Count;i++)
				{
					if(int.TryParse(listView_Cards.Items[c[i]].SubItems[0].Text,out Pid))
					{
						dsql.Append("delete from datas where id=");
						dsql.Append(Pid.ToString());
						dsql.Append(";delete from texts where id=");
						dsql.Append(Pid.ToString());dsql.Append(";");
						SQL.Append(CDB.GetInsertSQL(CDB.cards[Pid]));
					}
				}
                CDB.Command(CDBfile, dsql.ToString());
				dsql=null;
				ReadData();
			}
		}		
		private void Button_cancelCard_Click(object sender, EventArgs e)
		{
            if (SQL.Length > 0)
            {
                CDB.Command(CDBfile, SQL.ToString());
                ReadData();
                SQL.Remove(0, SQL.Length);
            }
		}	
		private void Button_resetCard_Click(object sender, EventArgs e)
		{
			intilControl();
		}		
		private void ListView_CardsSelectedIndexChanged(object sender, EventArgs e)
		{
			int n=-1,Pid=0;
			ListView.SelectedIndexCollection c =listView_Cards.SelectedIndices;
			if(c.Count>0)
			{
				n = c[0];
				if(int.TryParse(listView_Cards.Items[n].SubItems[0].Text,out Pid))
				{
					Setcard(Pid);
				}
			}
		}			
		private void ListView_Cards_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
            {
                case Keys.L: Button_forword_Click(null, null); break;
                case Keys.R: Button_next_Click(null, null); break;
                case Keys.Left: Button_forword_Click(null, null); break;
                case Keys.Right: Button_next_Click(null, null); break;
                case Keys.PageUp: Button_forword_Click(null, null); break;
                case Keys.PageDown: Button_next_Click(null, null); break;
                case Keys.Oemcomma: Button_forword_Click(null, null); break;
                case Keys.OemPeriod: Button_next_Click(null, null); break;
                case Keys.OemMinus: Button_forword_Click(null, null); break;
                case Keys.Oemplus: Button_next_Click(null, null); break;
                case Keys.Delete:Button_delCard_Click(null,null);break;
            }
		}	
		private void ListBox_str_SelectedIndexChanged(object sender, EventArgs e)
		{
			int n;
			try{
				n=listBox_str.SelectedIndex;
				textBox_str.Text=listBox_str.Items[n].ToString();
			}
			catch{}
		}									
		private void ToolStrip_game_Click(object sender, EventArgs e)
		{
			string str = " -debug ";
            string CDBname = CCFile.GetName(CDBfile);
            if (File.Exists(SET.GamePath + SET.GameName) && CDBname.Length > 0)
            {
            	if(!CDBname.Equals("cards.cdb",StringComparison.OrdinalIgnoreCase))
                    str += " -e" + CDBname;
            }
            MessageBox.Show("游戏参数："+str);
            CCFile.RUN(SET.GamePath + SET.GameName, str);
		}	
		private void ToolStrip_gamepath_Click(object sender, EventArgs e)
		{
			string str="";
			if(CCFile.SelectOpenFile(out str,"请选择游戏文件(ygopro_vs.exe)","exe",""))
			{
				if(File.Exists(str))
				{
					SET.GameName=CCFile.GetName(str);
					SET.GamePath=CCFile.GetPath(str);
					SET.SaveSet(setfile);
					ToolStrip_gamepath.ToolTipText=SET.GamePath;
					ToolStrip_game.ToolTipText=SET.GameName;
				}
			}
		}		
		private void ToolStrip_notepad_Click(object sender, EventArgs e)
		{
			if(CCFile.SelectOpenFile(out SET.NPPpath,"请选择lua编辑器(notepad++.exe)","exe",""))
			{
				if(File.Exists(SET.NPPpath))
				{
					SET.SaveSet(setfile);
					ToolStrip_notepad.ToolTipText=SET.NPPpath;
				}
			}
		}	
		private void ToolStrip_CDBlist_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem ts=(ToolStripMenuItem)sender;
			//MessageBox.Show(text);
            CDBfile = ts.Text;
            this.Text = CDBfile + "  -DataEditor V2";
			select_str="";
            intilControl();
			ReadData();
		}
		private void ToolStrip_newCDB_Click(object sender, EventArgs e)
		{
            string file;
			if(CCFile.SelectSaveFile(out file,"cdb","请输入新数据库的名字",SET.GamePath))
			{
                CDBfile = file;
				CDB.Create(file);
                SET.LastCDB.Add(file);
                this.Text = CDBfile + "  -DataEditor V2";
                ReadData();
			}
		}
        private void ToolStrip_openCDB_Click(object sender, EventArgs e)
        {
            string file;
            if (CCFile.SelectOpenFile(out file, "请输入新数据库的名字","cdb" ,""))
            {
                CDBfile = file;
                SET.LastCDB.Add(file);
                this.Text = CDBfile + "  -DataEditor V2";
                ReadData();
            }
        }	
		private void ToolStrip_ReadYDK_Click(object sender, EventArgs e)
		{
			string file;
			if(CCFile.SelectOpenFile(out file,"请选择卡组文件(.ydk)","ydk",SET.GamePath+"deck"))
			{
				CDB.Read(CDBfile,CCFile.ReadYDK(file));
				Count=CDB.ids.Count;
				SetNum();
				Add_cardslist();
			}
		}		
		private void ToolStrip_SearchJPG_Click(object sender, EventArgs e)
		{
			string path;
			if(CCFile.SelectFolder(out path,"请选择:\n需要读取的卡片的图片文件夹（jpg格式）",""))
			{
                CDB.Read(CDBfile, CCFile.FindFiles(path, "jpg", false));
				Count=CDB.ids.Count;
				SetNum();
				Add_cardslist();
			}
		}				
		private void ToolStrip_copycards_Click(object sender, EventArgs e)
		{
			string cdb="diy.cdb";
			if(CCFile.SelectOpenFile(out cdb,"数据将要复制到->选择的数据库","cdb",SET.GamePath))
			{
				CDB.Updata(cdb);
				MessageBox.Show("复制完成！","提示");
			}
		}
		private void ToolStrip_export_Click(object sender, EventArgs e)
		{
            ProcessForm pf = new ProcessForm(SET.GamePath, SET.GamePath + "Export\\");
            pf.ShowDialog();
		}
        private void ToolStrip_stratcut_Click(object sender, EventArgs e)
        {
            if (CDB.ids.Count>0&&MessageBox.Show("只支持裁剪简体版的卡图。\n\n裁剪后的图片保存在ExportImages文件夹。", "确定开始裁剪卡图？", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ProcessForm pf = new ProcessForm(SET.GamePath);
                pf.ShowDialog();
            }
        }
        private void ToolStrip_cutfolder_Click(object sender, EventArgs e)
        {
            string cpath = SET.GamePath + "ExportImages";
            if (Directory.Exists(cpath))
            {
                CCFile.Start(cpath);
            }
        }
        private void ToolStrip_cdblist_MouseEnter(object sender, EventArgs e)
        {
            ToolStrip_cdblist.DropDownItems.Clear();
            ToolStrip_cdblist.DropDownItems.Add(@"新建数据库(&D)", null, ToolStrip_newCDB_Click);
            ToolStrip_cdblist.DropDownItems[0].ToolTipText = "创建一个空白的数据库";
            ToolStrip_cdblist.DropDownItems.Add(@"打开数据库(&O)", null, ToolStrip_openCDB_Click);
            ToolStrip_cdblist.DropDownItems[1].ToolTipText = "打开一个其他位置的数据库";
            if (!SET.GamePath.Equals(path))
            {
                SET.AddCDB(CCFile.FindFiles(path, "cdb", true));
            }
            SET.AddCDB(CCFile.FindFiles(SET.GamePath, "cdb", true));
            AddCDBlist();
        }
        private void ToolStrip_MSE_Click(object sender, EventArgs e)
        {
            MSEForm mf = new MSEForm();
            mf.ShowDialog();
        }
        private void ToolStrip_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("感谢圆神，贴吧参与测试的吧友。\n作者：菜菜\n邮箱：2457774381@qq.com","关于DataEditorV2");
        }
        private void ToolStrip_resizeJPG_Click(object sender, EventArgs e)
        {
            ImageForm im = new ImageForm();
            im.ShowDialog();
        }
        private void ToolStrip_startcut_Click(object sender, EventArgs e)
        {
            string f;
            if (CCFile.SelectOpenFile(out f, "请选择MSE存档。", "mse-set", ""))
            {
                ProcessForm pf = new ProcessForm(f, path+"Images\\");
                pf.ShowDialog();
            }
        }
        private void ToolStrip_opencutjpg_Click(object sender, EventArgs e)
        {
            CCFile.Start(path+"Images\\");
        }
        private void ToolStrip_netdisk_Click(object sender, EventArgs e)
        {
            CCFile.Start(baidu);
        }
        private void ToolStrip_opengpath_Click(object sender, EventArgs e)
        {
            CCFile.Start(SET.GamePath);
        }
        private void label_setname_Click(object sender, EventArgs e)
        {
            if (textBox_setname.Visible == true)
            {
                textBox_setname.Visible = false;
            }
            else
            {
                textBox_setname.Visible = true;
            }
        }
        private void textBox_desc_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = textBox_desc.Text;
            int n = textBox_desc.SelectionStart;
            //MessageBox.Show(e.KeyChar.ToString());
            bool ok = false;
            foreach(char key in SET.Respace.Keys)
            {
                if(e.KeyChar==key)
                {
                    ok = true; text = text.Insert(n, SET.Respace[key]);
                    break;
                }
            }
            if (ok == true)
            {
                e.Handled = true; 
                textBox_desc.Text = text;
                textBox_desc.SelectionStart = n + 1;
            }
        }
        private void ToolStrip_yulan_Click(object sender, EventArgs e)
        {
            if(tabControl_text.SelectedTab!=tabPage_jpg&&ToolStrip_yulan.Checked==true)
            {
                tabControl_text.SelectedTab = tabPage_jpg;
            }
        }
        private void tabPage_jpg_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void tabPage_jpg_DragDrop(object sender, DragEventArgs e)
        {
            if (textBox_code.Text.Length > 0)
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string str = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();

                    if (str.EndsWith("jpg", StringComparison.CurrentCultureIgnoreCase) || str.EndsWith("png", StringComparison.CurrentCultureIgnoreCase) || str.EndsWith("bmp", StringComparison.CurrentCultureIgnoreCase))
                    {
                        if (MessageBox.Show("是否把调整图片", "提示", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                        {
                            CCFile.CheckFolder(SET.GamePath + "pics");
                            CCFile.CheckFolder(SET.GamePath + "pics\\thumbnail");
                            PIC.savejpg(PIC.zoom(PIC.GetBitmap(str), 177, 254), SET.GamePath + "pics\\" + textBox_code.Text + ".jpg", 96);
                            PIC.savejpg(PIC.zoom(PIC.GetBitmap(str), 44, 64), SET.GamePath + "pics\\thumbnail\\" + textBox_code.Text + ".jpg", 96);
                            MessageBox.Show("调整完成！");
                        }
                    }
                }
            }
        }

	}
}
