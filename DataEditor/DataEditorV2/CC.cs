using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using CCImage;
using YGOPRO;

namespace CCFun
{
	public class CCFile
	{
        private static string _7za = @"data\7zip\7za.exe";
		public static bool SelectFolder(out string Floder,string str,string path)
		{
			Floder="";
            using (FolderBrowserDialog f = new FolderBrowserDialog())
            {
            	f.Description=str;
            	f.SelectedPath=path;
                f.ShowDialog();
                Floder = f.SelectedPath.ToString();
                if (!Floder.EndsWith(@"\")&&Floder.Length>0)
                     Floder += @"\";
            }
            if(Floder.Length>0)
            	return true;
            else 
            	return false;
		}
		public static bool SelectSaveFile(out string file,string ex,string title,string path)
		{
			file="";
            using (SaveFileDialog f = new SaveFileDialog ())
            {
            	f.Title=title;
            	f.InitialDirectory=path;
                f.Filter=ex+"文件|*."+ex+"|所有文件|*.*";
                f.ShowDialog();
                file = f.FileName;
            } 
            if(file.Length>0)
            	return true;
            else
            	return false;
		}
		public static bool SelectOpenFile(out string file,string title,string ex,string path)
		{
			file="";
            using (OpenFileDialog f = new OpenFileDialog ())
            {
            	f.Title=title;
            	f.InitialDirectory=path;
                f.Filter=ex+"文件|*."+ex+"|所有文件|*.*";
                f.ShowDialog();
                file = f.FileName;
            } 
            if(file.Length>0)
            	return true;
            else
            	return false;
		}
		public static void WriteText(string file,string str,Encoding encode)
		{
			using(FileStream f=new FileStream(file,FileMode.Create,FileAccess.Write))
			{
				StreamWriter sw=new StreamWriter(f,encode);
				sw.Write(str);
				sw.Close();
				f.Close();
			}
		}
        public static bool ReadText(string file, out string str, Encoding encode)
        {
            str = "";
            if (!File.Exists(file))
                return false;
            using (FileStream f = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(f, encode);
                str = sr.ReadToEnd();
                sr.Close();
                f.Close();
            }
            return true;
        }
		public static void RUN(string file,string str)
		{
			string path=file.Substring(0,file.LastIndexOf("\\"));
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = file;
            p.StartInfo.Arguments = str;
            p.StartInfo.WorkingDirectory = path;
            p.Start();
		}
		public static string GetName(string file)
		{
			int a=file.LastIndexOf(@"\");
			return file.Substring(a+1);
		}
		public static string GetPath(string str)
		{
			int a=str.LastIndexOf("\\");
			return str.Substring(0,a+1);
		}
        public static void CheckFolder(string f)
        {
            if (!Directory.Exists(f))
                Directory.CreateDirectory(f);
        }
        public static void CopyData(string gpath,string cpath,int id)
        {
            string png= @"pics\field\" + id.ToString()+ ".png";
            string jpg1 = @"pics\" + id.ToString() + ".jpg";
            string jpg2=@"pics\thumbnail\" + id.ToString() + ".jpg";
            string lua=@"script\c" + id.ToString() + ".lua";
            if (File.Exists(gpath+png))
            {
                File.Copy(gpath + png, cpath + png, true);
            }
            if (File.Exists(gpath + jpg1))
            {
                File.Copy(gpath + jpg1, cpath + jpg1, true);
            }
            if (File.Exists(gpath + jpg2))
            {
                File.Copy(gpath + jpg2, cpath + jpg2, true);
            }
            if (File.Exists(gpath + lua))
            {
                File.Copy(gpath + lua, cpath + lua, true);
            }
        }
        public static void _7zip(string path,string jpath, string str)
        {
            if (File.Exists(path+_7za))
            {
                using (Process process = new Process())
                {
                    process.StartInfo.FileName =  path+_7za;
                    process.StartInfo.Arguments = str;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.WorkingDirectory = jpath;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                }
            }
            else
                MessageBox.Show("没有txt\\7z.exe");
        }
        public static string[] FindFiles(string path, string ex,bool havepath)
        {
            string[] ids = null;
            if (Directory.Exists(path))
            {
                DirectoryInfo Dir = new DirectoryInfo(path);
                FileInfo[] fs = Dir.GetFiles(@"*." + ex);
                if (fs.Length > 0)
                {
                    ids = new string[fs.Length];
                    int i = 0;
                    foreach (FileInfo f in fs)
                    {
                        if (havepath == true)
                        {
                            ids[i] = path+f.ToString();
                        }
                        else
                        {
                            ids[i] = f.ToString().Replace("." + ex, "");
                        }
                        i++;
                    }
                    fs = null;
                }
            }
            return ids;
        }
        public static int Getint(Dictionary<int, string> dic, string str)
        {
            int i = 0;
            foreach (int key in dic.Keys)
            {
                if (str.Equals(dic[key]))
                    i = key;
            }
            return i;
        }
        public static int GetSelectIndex(int i)
        {
            uint num = 1;
            int index = 0;
            int ri = 0;
            if (i != 0)
            {
                while ((num & i) == 0L)
                {
                    num = num << 1;
                    index++;
                }
                ri = index + 1;
            }
            return ri;
        }
        public static bool Check_KeyisInt(char key)
        {
            if (char.IsDigit(key) || key == (char)Keys.Delete || key == (char)Keys.Back)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string GetSelect(CardData data)
        {
            StringBuilder sb = new StringBuilder();
            if (data.text.Equals("setname"))
            {
                sb.Append(" group by datas.setcode");
            }
            else
            {
                if (data.ot > 0)
                {
                    sb.Append(" and datas.ot=");
                    sb.Append(data.ot.ToString());
                }
                if (data.attribute > 0)
                {
                    sb.Append(" and datas.attribute=");
                    sb.Append(data.attribute.ToString());
                }
                if (data.race > 0)
                {
                    sb.Append(" and datas.race=");
                    sb.Append(data.race.ToString());
                }
                if (data.level > 0)
                {
                    sb.Append(" and datas.level=");
                    sb.Append(data.level.ToString());
                }
                if (data.name.Length > 0)
                {
                    sb.Append(@" and texts.name like '%");
                    sb.Append(data.name);
                    sb.Append(@"%'");
                }
                if (data.text.Length > 0)
                {
                    sb.Append(@" and texts.desc like '%");
                    sb.Append(data.text);
                    sb.Append(@"%'");
                }
                if (data.code > 0)
                {
                    sb.Append(" and datas.id>=");
                    sb.Append(data.code.ToString());
                }
                if (data.alias > 0)
                {
                    sb.Append(" and datas.id<=");
                    sb.Append(data.alias.ToString());
                }
                if (data.attack > 0)
                {
                    sb.Append(" and datas.atk=");
                    sb.Append(data.attack.ToString());
                }
                if (data.defence > 0)
                {
                    sb.Append(" and datas.def=");
                    sb.Append(data.defence.ToString());
                }
                if (data.setcode > 0)
                {
                    sb.Append(" and datas.setcode=");
                    sb.Append(data.setcode.ToString());
                }
            }
            string temp= sb.ToString();
            sb.Remove(0, sb.Length);
            sb = null;
            //MessageBox.Show(select_str);
            return temp;
        }
        public static Bitmap Setjpg(string gpath,bool yulan,int id,int leng)
        {
            string jpgfile = gpath + "pics\\" + id.ToString() + ".jpg";
            if (File.Exists(jpgfile))
            {
                if (yulan == true)
                {
                    if (CDB.cards.ContainsKey(id))
                    {
                        return PIC.CutJPG(gpath, id, CDB.cards[id].type, leng, leng);
                    }
                }
                else
                {
                    return PIC.GetBitmap(jpgfile);
                }
            }
            else
            {
                jpgfile = "./data/Images/cover.jpg";
                if (File.Exists(jpgfile))
                {
                    return  PIC.GetBitmap(jpgfile);
                }
            }
            return null;
        }
        public static string[] ReadYDK(string file)
        {
            string str;
            List<string> IDs = new List<string>();
            if (File.Exists(file))
            {
                using (FileStream f = new FileStream(file, FileMode.Open, FileAccess.Read))
                {
                    StreamReader sr = new StreamReader(f, Encoding.UTF8);
                    str = sr.ReadLine();
                    while (str != null)
                    {
                        if (!str.StartsWith("!") && !str.StartsWith("#"))
                        {
                            IDs.Add(str);
                        }
                        str = sr.ReadLine();
                    }
                    sr.Close();
                    f.Close();
                }
            }
            string[] codes = IDs.ToArray();
            IDs.Clear();
            IDs = null;
            return codes;
        }
        public static void Start(string fo)
        {
            if (fo.StartsWith("http"))
            {
                Process.Start(fo);
            }
            else
            {
                if (Directory.Exists(fo))
                {
                    Process.Start(fo);
                }
            }
        }
	}
}
