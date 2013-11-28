using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Data.SQLite;

namespace YGOPRO
{
	public class CDB
	{
		public static Dictionary<int,int> ids=new Dictionary<int, int>();
		public static Dictionary<int,CardData> cards=new Dictionary<int, CardData>();
		public static void Create(string Db)
        {
            if (File.Exists(Db))
                File.Delete(Db);
            SQLiteConnection.CreateFile(Db);
            StringBuilder st = new StringBuilder(@"CREATE TABLE texts(id integer primary key,name text,desc text");
            for (int i = 1; i <= 16; i++)
            {
                st.Append(",str");
                st.Append(i.ToString());
                st.Append(" text");
            }
            st.Append(");");
            st.Append(@"CREATE TABLE datas(id integer primary key,ot integer,alias integer,setcode integer,type integer,atk integer,def integer,level integer,race integer,attribute integer,category integer)");
            Command(Db,st.ToString());
            st.Remove(0,st.Length);
            st=null;
        }
		public static int Command(string DB, string SQL)
        {
            int result=0;
            if (File.Exists(DB))
            {
                using (SQLiteConnection con = new SQLiteConnection(@"Data Source=" + DB))
                {
                    con.Open();
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                        using (SQLiteCommand cmd = new SQLiteCommand(con))
                        {
                            
                                    cmd.CommandText = SQL;
                                    result=cmd.ExecuteNonQuery();
                        }
                        trans.Commit();
                    }
                    con.Close();
                }
            }
            return result;
        }
		public static void Read(string DB, string SELECT)
        {
			int ic=0, i=0;
			ids.Clear();
			cards.Clear();
            if (File.Exists(DB))
            {
                using (SQLiteConnection con = new SQLiteConnection(@"Data Source=" + DB))
                {
                    con.Open();
                    string SQL="SELECT datas.*,texts.* FROM datas,texts WHERE datas.id=texts.id "+SELECT;
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                        using (SQLiteCommand cmd = new SQLiteCommand(con))
                        {
                                cmd.CommandText = SQL;
                                using(SQLiteDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                    	CardData data=new CardData();
                                    	data.desc =new String[0x10];
                                        data.code = reader.GetInt32(0);
                                        data.ot = reader.GetInt32(1);
                                        data.alias = reader.GetInt32(2);
                                        data.setcode = reader.GetInt32(3);
                                        data.type = reader.GetInt32(4);
                                        data.attack = reader.GetInt32(5);
                                        data.defence = reader.GetInt32(6);
                                        data.level = reader.GetInt32(7);
                                        data.race = reader.GetInt32(8);
                                        data.attribute = reader.GetInt32(9);
                                        data.category = reader.GetInt32(10);
                                        data.name = reader.GetString(12);
                                        data.text = reader.GetString(13);
                                        for (i = 0; i < 0x10; i++)
                                        {
                                            data.desc[i] = reader.GetString(14 + i);
                                        }
                                        cards.Add(data.code, data);
                                        ids.Add(ic, data.code);
                                        ic++;
                                    }
                                    reader.Close();
                                }
                        }
                        trans.Commit();
                    }
                    con.Close();
                }
            }
        }
        public static void Read(string DB, string[] IDs)
        {
            int ic = 0, i = 0;
            ids.Clear();
            cards.Clear();
            string SQL = "";
            if (File.Exists(DB))
            {
                using (SQLiteConnection con = new SQLiteConnection(@"Data Source=" + DB))
                {
                    con.Open();
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                        using (SQLiteCommand cmd = new SQLiteCommand(con))
                        {
                            foreach (string id in IDs)
                            {
                                SQL = "SELECT datas.*,texts.* FROM datas,texts WHERE datas.id=texts.id and datas.id=" + id;
                                cmd.CommandText = SQL;
                                using (SQLiteDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        CardData data = new CardData();
                                        data.desc = new String[0x10];
                                        data.code = reader.GetInt32(0);
                                        data.ot = reader.GetInt32(1);
                                        data.alias = reader.GetInt32(2);
                                        data.setcode = reader.GetInt32(3);
                                        data.type = reader.GetInt32(4);
                                        data.attack = reader.GetInt32(5);
                                        data.defence = reader.GetInt32(6);
                                        data.level = reader.GetInt32(7);
                                        data.race = reader.GetInt32(8);
                                        data.attribute = reader.GetInt32(9);
                                        data.category = reader.GetInt32(10);
                                        data.name = reader.GetString(12);
                                        data.text = reader.GetString(13);
                                        for (i = 0; i < 0x10; i++)
                                        {
                                            data.desc[i] = reader.GetString(14 + i);
                                        }
                                        if (!ids.ContainsValue(data.code))
                                        {
                                            cards.Add(data.code, data);
                                            ids.Add(ic, data.code);
                                            ic++;
                                        }
                                    }
                                    reader.Close();
                                }
                            }
                        }
                        trans.Commit();
                    }
                    con.Close();
                }
            }
        }
		public static int Updata(string DB)
        {
            int result=0,id=0;
            string sql="";
            if (File.Exists(DB))
            {
                using (SQLiteConnection con = new SQLiteConnection(@"Data Source=" + DB))
                {
                    con.Open();
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                        using (SQLiteCommand cmd = new SQLiteCommand(con))
                        {
                            foreach(int i in ids.Keys)
                            {
                            	id=ids[i];
                            	sql=GetInsertSQL(cards[id]);
                                cmd.CommandText = sql;
                                result+=cmd.ExecuteNonQuery();
                            }
                        }
                        trans.Commit();
                    }
                    con.Close();
                }
            }
            return result;
        }
		public static string GetInsertSQL(CardData data)
        {
			StringBuilder st=new StringBuilder();
			st.Append("INSERT or ignore into datas values(");st.Append(data.code.ToString());st.Append(",");
			st.Append(data.ot.ToString());st.Append(",");st.Append(data.alias.ToString());st.Append(",");
			st.Append(data.setcode.ToString());st.Append(",");st.Append(data.type.ToString());st.Append(",");
			st.Append(data.attack.ToString());;st.Append(",");st.Append(data.defence.ToString());st.Append(",");
			st.Append(data.level.ToString());st.Append(",");st.Append(data.race.ToString());st.Append(",");
			st.Append(data.attribute.ToString());st.Append(",");st.Append(data.category.ToString());st.Append(")");
			st.Append(";INSERT or ignore into texts values(");st.Append(data.code.ToString());st.Append(",'");
			st.Append(data.name.Replace("'","''"));st.Append("','");st.Append(data.text.Replace("'","''"));
            for(int i=0;i<0x10;i++)
            {
            	st.Append("','");st.Append(data.desc[i].Replace("'","''"));
            }
            st.Append("');");
            string sql=st.ToString();
            return sql;
        }
		public static string GetUpdataSQL(CardData data)
		{
			StringBuilder st=new StringBuilder();
			st.Append("update datas set ot=");st.Append(data.ot.ToString());
			st.Append(",alias=");st.Append(data.alias.ToString());
			st.Append(",setcode=");st.Append(data.setcode.ToString());
			st.Append(",type=");st.Append(data.type.ToString());
			st.Append(",atk=");st.Append(data.attack.ToString());
			st.Append(",def=");st.Append(data.defence.ToString());
			st.Append(",level=");st.Append(data.level.ToString());
			st.Append(",race=");st.Append( data.race.ToString());
			st.Append(",attribute=");st.Append(data.attribute.ToString());
			st.Append(",category=");st.Append(data.category.ToString());
			st.Append(" where id=");st.Append(data.code.ToString());
			st.Append("; update texts set name='");st.Append(data.name.Replace("'","''"));
			st.Append("',desc='");st.Append(data.text.Replace("'","''"));st.Append("', ");
            for(int i=0;i<0x10;i++)
            {
            	st.Append("str");st.Append((i+1).ToString());st.Append("='");st.Append(data.desc[i].Replace("'","''"));
            	if(i<15)
            	{
            		st.Append("',");
            	}
            }
            st.Append("' where id=");st.Append(data.code.ToString());
            st.Append(";");
            string sql=st.ToString();
            return sql;
		}
	}
}

