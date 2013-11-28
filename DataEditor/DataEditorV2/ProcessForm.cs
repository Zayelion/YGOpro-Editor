using System;
using System.IO;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Text;
using CCImage;
using YGOPRO;
using CCFun;

namespace DataEditorV2
{
    public partial class ProcessForm : Form
    {
        delegate void _ProcessBar1();
        _ProcessBar1 pb1;
        delegate void _Label1();
        _Label1 lb1;
        delegate void _Form();
        _Form fm;
        private bool stop;
        private Thread t;
        private string title, path1, path2, ex, file;
        private int NUM, a,zl, w, h;
        private string[] names;
        public ProcessForm(string gpath,string cpath)
        {
            InitializeComponent();
            title = "复制图片,脚本";
            this.path1 = gpath;
            this.path2 = cpath;
        }
        public ProcessForm(string path)
        {
            InitializeComponent();
            title = "裁剪图片";
            this.path1 = path;
            this.path2 = path + "ExportImages\\";
        }
        public ProcessForm(string jpgpath, string savepath, int zl, string ex,int w,int h)
        {
            InitializeComponent();
            title = "图片调整";
            this.path1 = jpgpath;
            this.path2 = savepath;
            this.zl = zl;
            this.ex = ex;
            this.w = w;
            this.h = h;
        }
        public ProcessForm(string file,string path1,string path2)
        {
            InitializeComponent();
            title = "提取图片";
            this.file = file;
            this.path1 = path1;
            this.path2 = path2;
        }
        private void ProcessForm_Load(object sender, EventArgs e)
        {
            t = null;
            stop = true;
            this.Text = title;
            switch (title)
            {
                case "复制图片,脚本":
                    stop = false;
                    CCFile.CheckFolder(path2);
                    CCFile.CheckFolder(path2 + "pics");
                    CCFile.CheckFolder(path2 + "pics\\field");
                    CCFile.CheckFolder(path2 + "pics\\thumbnail");
                    CCFile.CheckFolder(path2 + "script");
                    NUM = CDB.ids.Count;
                    t = new Thread(Copy);
                    break;
                case "裁剪图片":
                    stop = false;
                    CCFile.CheckFolder(path2);
                    NUM = CDB.cards.Count;
                    t = new Thread(Cut);
                    break;
                case "图片调整":
                    stop = false;
                    CCFile.CheckFolder(path2);
                    CCFile.CheckFolder(path2 + "pics");
                    CCFile.CheckFolder(path2 + "pics\\thumbnail");
                    names = CCFile.FindFiles(path1, ex,false);
                    NUM = names.Length;
                    t = new Thread(ReSize); 
                    break;
                case "提取图片":
                    stop = false;
                    label1.Text = "提取中。。。";
                    progressBar1.Style = ProgressBarStyle.Marquee;
                    NUM = 1;
                    t = new Thread(Get_setjpg);
                    break;
            }
            if (t != null && NUM > 0)
            {
                pb1 = new _ProcessBar1(ProcessADD);
                lb1 = new _Label1(Setlabel);
                fm = new _Form(closeForm);
                progressBar1.Maximum = NUM;
                t.IsBackground = true;
                t.Start();
            }
            else
            {
                stop = true;
                this.Close();
            }
        }
        private void ProcessForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (stop == false)
            {
                if (MessageBox.Show("正在复制中。\n是否退出？", "提示", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    stop = true;
                    if (t != null)
                    {
                        
                    }
                    e.Cancel = true;
                }
            }
        }
        private void ProcessADD()
        {
            progressBar1.Value++;
        }
        private void Setlabel()
        {
            label1.Text = a.ToString() + "/" + NUM.ToString();
        }
        private void closeForm()
        {
            this.Close();
        }
        private void Cut()
        {
            a = 0;
            foreach (int id in CDB.cards.Keys)
            {
                if (stop == false)
                {
                    a++;
                    PIC.CutJPG(path1, id, CDB.cards[id].type, path2,SET.Length,SET.Length);
                    progressBar1.Invoke(pb1);
                    label1.Invoke(lb1);
                }
                else
                {
                    break;
                }
            }
            if (stop == true)
            {
                MessageBox.Show("已经取消！");
            }
            else
            {
                stop = true;
                MessageBox.Show("裁剪完成。\n文件在" + path2);
            }
            this.Invoke(fm);
        }
        private void Copy()
        {
            a = 0;
            foreach (int id in CDB.ids.Values)
            {
                if (stop == false)
                {
                    a++;
                    CCFile.CopyData(path1, path2, id);
                    progressBar1.Invoke(pb1);
                    label1.Invoke(lb1);
                }
                else
                {
                    break;
                }
            }
            if (stop == true)
            {
                MessageBox.Show("已经取消！");
            }
            else
            {
                stop = true;
                MessageBox.Show("复制完成。\n文件在" + path2);
            }
            this.Invoke(fm);
        }
        private void ReSize()
        {
            a = 0;
            string fjpg="";
            Bitmap bmp=null;
            foreach (string name in names)
            {
                if (stop == false)
                {
                    a++;
                    fjpg = path1 + name + "." + ex;
                    if (File.Exists(fjpg))
                    {
                        bmp = PIC.GetBitmap(fjpg);
                        if (w == 0 && h == 0)
                        {
                            PIC.savejpg(PIC.zoom(bmp, 177, 254), path2 + "pics\\" + name + ".jpg", zl);
                            PIC.savejpg(PIC.zoom(bmp, 44, 64), path2 + "pics\\thumbnail\\" + name + ".jpg", zl);
                        }
                        else
                        {
                            PIC.savejpg(PIC.zoom(bmp, w, h), path2 + name + ".jpg", zl);
                        }
                    }
                    progressBar1.Invoke(pb1);
                    label1.Invoke(lb1);
                }
                else
                {
                    break;
                }
            }
            if (stop == true)
            {
                MessageBox.Show("已经取消！");
            }
            else
            {
                stop = true;
                MessageBox.Show("图片调整完成。\n文件在" + path2);
            }
            this.Invoke(fm);
        }
        private void Get_setjpg()
        {
            string ostr = " e -tzip " + file + " -aoa";
            CCFile.CheckFolder(path1);
            CCFile.CheckFolder(path2);
            CCFile._7zip(path1, path2, ostr);
            int t, w, i = 0;
            string img, id;
            if (File.Exists(path2 + "set"))
            {
                string temp = File.ReadAllText(path2+"set", Encoding.UTF8);
                t = temp.IndexOf("stylesheet: ");
                w = temp.IndexOf("\r\n", t);
                t = temp.IndexOf("card:\r\n", w);
                while (t >= 0)
                {
                    if (stop == false)
                    {
                        i++;
                        try
                        {
                            t = temp.IndexOf("image: ", t);
                            w = temp.IndexOf("\r\n", t);
                        }
                        catch { }
                        if ((w - t - 7) > 0 && (w - t - 7) <= 16)
                        {
                            img = temp.Substring(t + 7, w - t - 7);
                            try
                            {
                                t = temp.IndexOf("gamecode: ", w);
                                w = temp.IndexOf("\r\n", t);
                            }
                            catch { t = w + 2; }
                            if ((w - t - 10) > 0 && (w - t - 10) <= 16)
                            {
                                id = temp.Substring(t + 10, w - t - 10);
                                if (File.Exists(path2 + img))
                                {
                                    if (img.IndexOf(".jpg") >= 0)
                                    {
                                        File.Move(path2 + img, path2 + img);
                                    }
                                    else
                                    {
                                        File.Move(path2 + img, path2 + id + ".png");
                                    }
                                }
                            }
                        }
                        t = temp.IndexOf("card:\r\n", w);
                    }
                    else
                    {
                        break;
                    }
                }
                File.Delete(path2 + "set");
            }
            if (stop == true)
            {
                MessageBox.Show("已经取消！");
            }
            else
            {
                stop = true;
                MessageBox.Show("图片提取完成。\n图片在\n" + path2);
            }
            this.Invoke(fm);
        }
    }
}
