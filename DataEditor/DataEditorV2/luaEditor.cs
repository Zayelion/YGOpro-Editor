
using System;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCFun;

namespace DataEditorV2
{
	public partial class luaEditor : Form
	{
		public luaEditor(string file)
		{
			InitializeComponent();
			this.file=file;
		}
		private string file;
		private Encoding enc=new UTF8Encoding(false);
		private void LuaEditorLoad(object sender, EventArgs e)
		{
			Read(enc);
			ToolStrip_utf8.Checked=true;
			this.Text=file+"  -LuaEditor";
		}
		
		private void ToolStrip_saveClick(object sender, EventArgs e)
		{
			CCFile.WriteText(file,textBox1.Text,enc);
		}
		
		private void ToolStrip_utf8Click(object sender, EventArgs e)
		{
			Read(enc);
			ToolStrip_gb2312.Checked=false;
			ToolStrip_anis.Checked=false;
		}
		
		private void ToolStrip_gb2312Click(object sender, EventArgs e)
		{
			Read(Encoding.GetEncoding("GB2312"));
			ToolStrip_anis.Checked=false;
			ToolStrip_utf8.Checked=false;
		}
		
		private void Read(Encoding encode)
		{
			string str;
            if (CCFile.ReadText(file, out str, encode))
			{
                str = str.Replace("\n", "\r\n");
				textBox1.Text=str;
			}
		}
		
		private void ToolStrip_anisClick(object sender, EventArgs e)
		{
			Read(Encoding.Default);
			ToolStrip_gb2312.Checked=false;
			ToolStrip_utf8.Checked=false;
		}
		
		private void ToolStrip_exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		private void ToolStrip_whiteClick(object sender, EventArgs e)
		{
			textBox1.BackColor=Color.White;
			ToolStrip_green.Checked=false;
		}
		
		private void ToolStrip_greenClick(object sender, EventArgs e)
		{
			textBox1.BackColor=Color.Honeydew;
			ToolStrip_white.Checked=false;
		}
		
		private void ToolStrip_smallClick(object sender, EventArgs e)
		{
			textBox1.Font =new Font("Consolas", 11,FontStyle.Regular);
			ToolStrip_middle.Checked=false;
			ToolStrip_big.Checked=false;
			ToolStrip_de.Checked=false;
		}
		
		private void ToolStrip_middleClick(object sender, EventArgs e)
		{
			textBox1.Font =new Font("Consolas", 13,FontStyle.Regular);
			ToolStrip_small.Checked=false;
			ToolStrip_big.Checked=false;
			ToolStrip_de.Checked=false;
		}
		
		private void ToolStrip_bigClick(object sender, EventArgs e)
		{
			textBox1.Font =new Font("Consolas", 15,FontStyle.Regular);
			ToolStrip_small.Checked=false;
			ToolStrip_middle.Checked=false;
			ToolStrip_de.Checked=false;
		}
		
		private void ToolStrip_deClick(object sender, EventArgs e)
		{
			textBox1.Font =new Font("Consolas", 12,FontStyle.Regular);
			ToolStrip_small.Checked=false;
			ToolStrip_middle.Checked=false;
			ToolStrip_big.Checked=false;
		}

        private void ToolStrip_open_Click(object sender, EventArgs e)
        {
            string f;
            if (CCFile.SelectOpenFile(out f, "请选择脚本文件(.lua)", "lua", SET.GamePath + "script"))
            {
                if (System.IO.File.Exists(f))
                {
                    file = f;
                    this.Text= f;
                    Read(enc);
                }
            }
        }
	}
}
