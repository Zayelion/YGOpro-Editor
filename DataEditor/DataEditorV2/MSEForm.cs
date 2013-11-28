using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MSEHelper;
using YGOPRO;
using CCFun;

namespace DataEditorV2
{
    public partial class MSEForm : Form
    {
        public MSEForm()
        {
            InitializeComponent();
            path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        }
        private string path;
        private bool isok = false;
        private void MSEForm_Load(object sender, EventArgs e)
        {
            comboBox_lang.SelectedIndex = 0;
            comboBox_style.SelectedIndex = 0;
        }
        private void button_ok_Click(object sender, EventArgs e)
        {
            if (isok == true)
            {
                button_ok.Enabled = false;
                button_ok.Text = "请等待";
                MSE.MSEmake(CDB.cards, textBox_jpg.Text, comboBox_lang.Text, comboBox_style.Text);
                string str = " a -tzip " + textBox_save.Text + @" @list.txt";
                CCFile._7zip(path, textBox_jpg.Text, str);
                File.Delete(textBox_jpg.Text + "set");
                File.Delete(textBox_jpg.Text + "list.txt");
                MessageBox.Show("制作完成");
                button_ok.Text = "开始导出";
                button_ok.Enabled = true;
            }
        }
        private void textBox_jpg_Click(object sender, EventArgs e)
        {
            string f;
            if (CCFile.SelectFolder(out f, "请选择素材图片的文件夹", ""))
            {
                textBox_jpg.Text = f;
            }
        }
        private void textBox_save_Click(object sender, EventArgs e)
        {
            string f;
            if (CCFile.SelectSaveFile(out f,@"mse-set","请保存MSE存档",""))
            {
                textBox_save.Text = f;
                isok = true;
            }
        }
    }
}
