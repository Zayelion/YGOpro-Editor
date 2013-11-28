using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCFun;

namespace DataEditorV2
{
    public partial class ImageForm : Form
    {
        public ImageForm()
        {
            InitializeComponent();
        }
        private void ImageForm_Load(object sender, EventArgs e)
        {
            comboBox_ex.SelectedIndex = 0;
        }
        private void radioButton_other_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_other.Checked == false)
            {
                textBox_h.Enabled = false;
                textBox_w.Enabled = false;
            }
            else
            {
                textBox_h.Enabled = true;
                textBox_w.Enabled = true;
            }
        }
        private void trackBar_quilty_Scroll(object sender, EventArgs e)
        {
            label7.Text = "图片质量 " + trackBar_quilty.Value.ToString() + "%";
        }
        private void textBox_jpg_Click(object sender, EventArgs e)
        {
            string f;
            if (CCFile.SelectFolder(out f, "请选择需要调整的图片文件夹", ""))
            {
                textBox_jpg.Text = f;
            }
        }
        private void textBox_save_Click(object sender, EventArgs e)
        {
            string f;
            if (CCFile.SelectFolder(out f, "请选择调整后保存的文件夹", ""))
            {
                textBox_save.Text = f;
            }
        }
        private void button_start_Click(object sender, EventArgs e)
        {
            if (radioButton_ygopro.Checked == true)
            {
                ProcessForm pf = new ProcessForm(textBox_jpg.Text, textBox_save.Text, trackBar_quilty.Value, comboBox_ex.Text, 0, 0);
                pf.ShowDialog();
            }
            else
            {
                int w, h;
                int.TryParse(textBox_w.Text, out w);
                int.TryParse(textBox_h.Text, out h);
                if (w > 0 && h > 0)
                {
                    ProcessForm pf = new ProcessForm(textBox_jpg.Text, textBox_save.Text, trackBar_quilty.Value, comboBox_ex.Text, w,h);
                    pf.ShowDialog();
                }
            }
        }
    }
}
