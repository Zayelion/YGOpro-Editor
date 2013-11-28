using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using CCFun;

namespace DataEditorV2
{

	public class SET
	{
		public static string GamePath;
		public static string NPPpath;
		public static string GameName;
        public static int Length;
        public static Dictionary<char, string> Respace = new Dictionary<char, string>();
        public static List<string> LastCDB = new List<string>();
		public static Dictionary<int,string> setname=new Dictionary<int,string>();
		public static bool ReadSet(string file)
		{
			NPPpath=@"notepad++.exe";
			GamePath=@"";
			if(!File.Exists(file))
				return false;
			using(FileStream f=new FileStream(file,FileMode.Open,FileAccess.Read))
			{
				StreamReader sr=new StreamReader(f,Encoding.UTF8);
				string str=	sr.ReadLine();
				while(str!=null)
				{
                    if (str.StartsWith("Length"))
                    {
                        int.TryParse(str.Substring(7), out Length);
                    }
                    else if (str.StartsWith("GameName"))
                    {
                        GameName = str.Substring(9);
                        if (GameName.Length < 4)
                        {
                            GameName = "ygopro_vs.exe";
                        }
                    }
                    else if (str.StartsWith("GamePath"))
                    {
                        GamePath = str.Substring(9);
                        if (str.LastIndexOf(@"\") != str.Length - 1 && GamePath.Length > 2)
                        {
                            GamePath += @"\";
                        }
                    }
                    else if (str.StartsWith("NPPpath"))
                    {
                        NPPpath = str.Substring(8);
                        if (NPPpath.Length < 1)
                            NPPpath = "空";
                    }
					str=sr.ReadLine();
				}
				sr.Close();
				f.Close();
			}
            if(Length<150||Length>250)
            {
                Length=150;
            }
			return true;
		}
		public static bool ReadSetName(string file)
		{
            setname.Clear();
			if(File.Exists(file))
			{
				using(FileStream f=new FileStream(file,FileMode.Open,FileAccess.Read))
				{
					int a=0;
					StreamReader sr=new StreamReader(f,Encoding.UTF8);
					string str=sr.ReadLine();
					while(str!=null)
					{
						a=str.IndexOf(" ");
						setname.Add(HexString(str.Substring(2,a-2)),str.Substring(a+1,str.Length-a-1));
						str=sr.ReadLine();
					}
					sr.Close();
					f.Close();
				}
				return true;
			}
			return false;
		}	
		private static int HexString(string hex)
		{
			int n=0;
			try{
				n=int.Parse(hex,NumberStyles.HexNumber);
			}
			catch{}
			return n;
		}
		public static int Getsetname(string str)
		{
			int a=0;
			foreach(int key in setname.Keys)
			{
				if(str.Equals(setname[key]))
				{
					a=key;
				}
			}
			return a;
		}
		public static void SaveSet(string file)
		{
			StringBuilder st=new StringBuilder();
			st.Append(@"##这是DataEditor V2的配置文件");
			st.Append("\r\n");/*
			st.Append(@"##MAX是搜索结果每页最大数量");
			st.Append("\r\n");
			st.Append(@"MAX "+MAX.ToString());
			st.Append("\r\n");*/
            st.Append(@"##Length是裁剪图片的宽高");
            st.Append("\r\n");
            st.Append(@"Length " + Length.ToString());
            st.Append("\r\n");
            st.Append(@"##GameName是游戏王YGOPRO的exe文件名 ");
			st.Append("\r\n");
			st.Append(@"GameName "+GameName);
			st.Append("\r\n");
			st.Append(@"##GamePath是游戏王YGOPRO的文件夹路径 ");
			st.Append("\r\n");
			st.Append(@"GamePath "+GamePath);
			st.Append("\r\n");
			st.Append(@"##NPPpath是notepad++的exe路径");
			st.Append("\r\n");
			st.Append(@"NPPpath "+NPPpath);
			CCFile.WriteText(file,st.ToString(),Encoding.UTF8);
			st=null;
		}
        public static void Savesetname(string file)
        {
            StringBuilder st = new StringBuilder();
            foreach (int key in setname.Keys)
            {
                st.Append("0x");
                st.Append(key.ToString("x"));
                st.Append(" ");
                st.Append(setname[key]);
                st.Append("\r\n");
            }
            CCFile.WriteText(file, st.ToString(), Encoding.UTF8);
            st = null;
        }
        public static void AddCDB(string[] cdbs)
        {
            if (cdbs != null)
            {
                foreach (string cdb in cdbs)
                {
                    if (LastCDB.IndexOf(cdb) < 0)
                    {
                        LastCDB.Add(cdb);
                    }
                }
            }
        }
        public static bool ReadCDB(string file)
        {
            LastCDB.Clear();
            if (!File.Exists(file))
                return false;
            using (FileStream f = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(f, Encoding.UTF8);
                string str = sr.ReadLine();
                while (str != null)
                {
                    if (File.Exists(str))
                    {
                        LastCDB.Add(str);
                    }
                    str = sr.ReadLine();
                }
                sr.Close();
                f.Close();
            }
            return true;
        }
        public static bool SaveCDB(string file)
        {
            using (FileStream f = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(f, Encoding.UTF8);
                foreach (string db in LastCDB)
                {
                    sw.WriteLine(db);
                }
                sw.Close();
                f.Close();
            }
            return true;
        }
        public static bool Readrespace(string file)
        {
            Respace.Clear();
            if (!File.Exists(file))
                return false;
            using (FileStream f = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(f, Encoding.UTF8);
                string str = sr.ReadLine();
                while (str != null)
                {

                    if (str.Length > 2)
                    {
                        Respace.Add(str.ToCharArray(0,1)[0],str.Substring(2, 1));
                    }
                    else if (str.Length > 0)
                    {
                        Respace.Add(str.ToCharArray(0, 1)[0], "");
                    }
                    str = sr.ReadLine();
                }
                sr.Close();
                f.Close();
            }
            return true;
        }
	}
}
