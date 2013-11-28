using System.IO;
using System.Text;
using System.Collections.Generic;
using YGOPRO;

namespace MSEHelper
{
    public class MSE
    {
        private static string[] race;
        private static string[] effect;
        private static string[] attribute;
        private static string[] enattribute;
        private static string List_txt = "list.txt";
        public static void MSEmake(Dictionary<int, CardData> cards,string jpath, string lang, string style)
        {
            intil();
            int n = cards.Count;
            string jpg = "";
            string Lang = "";
            StringBuilder st = new StringBuilder();
            StringBuilder mseset = new StringBuilder(mse_start(style, lang));
            foreach (int id in cards.Keys)
            {
                jpg = jpath + id.ToString() + ".jpg";
                if (cards[id].ot == 2 && lang == "日文")
                {
                    Lang = "英文";
                }
                else
                {
                    Lang = lang;
                }
                if (File.Exists(jpg))
                {
                    st.Append(id.ToString() + ".jpg\r\n");
                    mseset.Append(Cardinfo(cards[id], Lang, true));
                }
                else
                {
                    mseset.Append(Cardinfo(cards[id], Lang, false));
                }
            }
            mseset.Append(mse_end());
            WriteText(jpath + "set", mseset.ToString());
            mseset.Remove(0, mseset.Length);
            mseset = null;
            st.Append("set\r\n");
            WriteText(jpath + List_txt, st.ToString());
            st.Remove(0, st.Length);
            st = null;
        }
        private static string Cardinfo(CardData card, string lang, bool jpg)
        {
            StringBuilder st = new StringBuilder();
            switch (lang)
            {
                case "简体": race = cnrace(); effect = cneffect(); break;
                case "繁体": race = twrace(); effect = tweffect(); break;
                case "日文": race = jprace(); effect = jpeffect(); break;
                case "英文": race = enrace(); effect = eneffect(); break;
                default: race = null; effect = null; break;
            }
            if (race != null && effect != null)
            {
                string[] ty = _TYPE(card.type);
                st.Append("card:\r\n");
                st.Append("	has styling: false\r\n");
                st.Append("	card type: "); st.Append(ty[0]); st.Append("\r\n");
                st.Append("	name: "); st.Append(card.name); st.Append("\r\n");
                st.Append("	attribute: "); st.Append(_ATTRIBUTE(ty[0],card.attribute,lang)); st.Append("\r\n");
                st.Append("	level: "); st.Append(_LEVEL(ty[0],ty[1],card.level,lang)); st.Append("\r\n");
                if (jpg == false)
                    st.Append("	image: \r\n");
                else
                {
                    st.Append("	image: "); st.Append(card.code.ToString()); st.Append(".jpg\r\n");
                }
                if (ty[0] != "魔法" && ty[0] != "陷阱")
                {
                    string ss,s1, s2, Race = _RACE(card.race);
                    st.Append("	type 1: <word-list-monster4>"); st.Append(Race); st.Append(@"</word-list-monster4>"); st.Append("\r\n");
                    st.Append("	type 2: <word-list-card4>"); st.Append(ty[1]); st.Append(@"</word-list-card4>"); st.Append("\r\n");
                    st.Append("	type 3: <word-list-c4>"); st.Append(ty[2]); st.Append(@"</word-list-c4>"); st.Append("\r\n");
                    if (lang == "英文")
                        ss = "／";
                    else
                        ss = "・";
                    if (ty[1].Length>0)
                        s1 = @"<sep-soft>"+ss+"</sep-soft>";
                    else
                        s1 = @"<sep>" + ss + "</sep>";
                    if (ty[2].Length>0)
                        s2 = "<sep-soft>／</sep-soft>";
                    else
                        s2 = @"<sep>／</sep>";
                    st.Append("	monster type: <word-list-monster4>"); st.Append(Race); st.Append(@"</word-list-monster4>"); st.Append(s1); st.Append("<word-list-card4>"); st.Append(ty[1]); st.Append(@"</word-list-card4>"); st.Append(s2); st.Append("<word-list-c4>"); st.Append(ty[2]); st.Append(@"</word-list-c4>"); st.Append("\r\n");
                }
                st.Append("	rule text:\r\n");
                st.Append("		"); st.Append(_TEXT(ty[0],card.text,lang)); st.Append("\r\n");
                if (ty[0] != "魔法" && ty[0] != "陷阱")
                {
                    st.Append("	attack: "); st.Append(_ATKDEF(card.attack)); st.Append("\r\n");
                    st.Append("	defense: "); st.Append(_ATKDEF(card.defence)); st.Append("\r\n");
                }
                st.Append("	gamecode: "); st.Append(_CODE(card.code)); st.Append("\r\n");
            }
            string temp=st.ToString();
            st.Remove(0, st.Length);
            st = null;
            return temp;
        }
        private static string mse_start(string style, string lang)
        {
            StringBuilder st = new StringBuilder();
            st.Append("mse version: 0.3.8\r\n");
            st.Append("game: yugioh\r\n");
            st.Append("stylesheet: "); st.Append(style); st.Append("\r\n");
            st.Append("styling:\r\n");
            st.Append("	yugioh-"); st.Append(style); st.Append(":\r\n");
            st.Append("		卡片语言: "); st.Append(lang); st.Append("\r\n");
            if (lang == "英文")
            {
                st.Append("		版权: 无\r\n");
            }
            return st.ToString();
        }
        private static string mse_end()
        {
            return "version control:\r\n	type: none\r\napprentice code:\r\n";
        }
        private static string[] _TYPE(int t)
        {
            string[] ty = new string[3];
            string t1 = "", t2 = "";
            ty[1] = ""; ty[2] = "";
            if ((t & (int)TYPE.TYPE_TOKEN) != 0)
            {
                t1 = "衍生物";
            }
            else if ((t & (int)TYPE.TYPE_MONSTER) != 0)
            {
                t1 = "怪兽";
                if ((t & (int)TYPE.TYPE_NORMAL) != 0)
                    t2 = "通常";
                else if ((t & (int)TYPE.TYPE_FUSION) != 0)
                {
                    t2 = "融合"; ty[1] = effect[2];
                }
                else if ((t & (int)TYPE.TYPE_RITUAL) != 0)
                {
                    t2 = "仪式"; ty[1] = effect[3];
                }
                else if ((t & (int)TYPE.TYPE_SYNCHRO) != 0)
                {
                    t2 = "同调"; ty[1] = effect[0];
                }
                else if ((t & (int)TYPE.TYPE_XYZ) != 0)
                {
                    t2 = "超量"; ty[1] = effect[1];
                }
                else if ((t & (int)TYPE.TYPE_TRAPMONSTER) != 0)
                    t2 = "陷阱";
                else
                    t2 = "效果";
                if ((t & (int)TYPE.TYPE_TUNER) != 0)
                    ty[2] = effect[5];
                else if ((t & (int)TYPE.TYPE_SPIRIT) != 0)
                    ty[2] = effect[6];
                else if ((t & (int)TYPE.TYPE_UNION) != 0)
                    ty[2] = effect[9];
                else if ((t & (int)TYPE.TYPE_DUAL) != 0)
                    ty[2] = effect[8];
                else if ((t & (int)TYPE.TYPE_TOON) != 0)
                    ty[2] = effect[7];
                else if ((t & (int)TYPE.TYPE_EFFECT) != 0)
                    ty[2] = effect[4];
                if (ty[1].Length<=0)
                {
                    ty[1] = ty[2]; ty[2] = "";
                }
            }
            else if ((t & (int)TYPE.TYPE_SPELL) != 0)
            {
                t1 = "魔法";
                if ((t & (int)TYPE.TYPE_QUICKPLAY) != 0)
                    ty[1] = "速攻";
                else if ((t & (int)TYPE.TYPE_CONTINUOUS) != 0)
                    ty[1] = "永续";
                else if ((t & (int)TYPE.TYPE_EQUIP) != 0)
                    ty[1] = "装备";
                else if ((t & (int)TYPE.TYPE_FIELD) != 0)
                    ty[1] = "场地";
                else if ((t & (int)TYPE.TYPE_RITUAL) != 0)
                    ty[1] = "仪式";
                else
                    ty[1] = "通常";
            }
            else if ((t & (int)TYPE.TYPE_TRAP) != 0)
            {
                t1 = "陷阱";
                if ((t & (int)TYPE.TYPE_COUNTER) != 0)
                    ty[1] = "反击";
                else if ((t & (int)TYPE.TYPE_CONTINUOUS) != 0)
                    ty[1] = "永续";
                else
                    ty[1] = "通常";
            }
            ty[0] = t2 + t1;
            return ty;
        }
        private static string _ATTRIBUTE(string type, int attri,string lang)
        {
            int a = -1;
            switch (attri)
            {
                case (int)ATTRIBUTE.ATTRIBUTE_EARTH: a = 0; break;
                case (int)ATTRIBUTE.ATTRIBUTE_WATER: a=1; break;
                case (int)ATTRIBUTE.ATTRIBUTE_FIRE: a=2; break;
                case (int)ATTRIBUTE.ATTRIBUTE_WIND: a = 3; ; break;
                case (int)ATTRIBUTE.ATTRIBUTE_LIGHT: a=4; break;
                case (int)ATTRIBUTE.ATTRIBUTE_DARK: a= 5; break;
                case (int)ATTRIBUTE.ATTRIBUTE_DEVINE:a=6 ; break;
                default:
                    if (type == "魔法")
                        a = 7;
                    else if (type == "陷阱")
                        a = 8;
                    break;
            }


            if (a >= 0)
            {
                if (lang == "英文")
                    return enattribute[a];
                else
                    return attribute[a];
            }
            else
                return "";
        }
        private static string _CODE(int id)
        {
            string temp = id.ToString();
            int i,a = 8 - temp.Length;
            for (i = 0; i < a; i++)
            {
                temp = "0" + temp;
            }
            return temp;
        }
        private static string _RACE(int r)
        {
            string ra = "";
            switch (r)
            {
                case (int)RACE.RACE_WARRIOR: ra = race[0]; break;
                case (int)RACE.RACE_SPELLCASTER: ra = race[1]; break;
                case (int)RACE.RACE_FAIRY: ra = race[2]; break;
                case (int)RACE.RACE_FIEND: ra = race[3]; break;
                case (int)RACE.RACE_ZOMBIE: ra = race[4]; break;
                case (int)RACE.RACE_MACHINE: ra = race[5]; break;
                case (int)RACE.RACE_AQUA: ra = race[6]; break;
                case (int)RACE.RACE_PYRO: ra = race[7]; break;
                case (int)RACE.RACE_ROCK: ra = race[8]; break;
                case (int)RACE.RACE_WINDBEAST: ra = race[9]; break;
                case (int)RACE.RACE_PLANT: ra = race[10]; break;
                case (int)RACE.RACE_INSECT: ra = race[11]; break;
                case (int)RACE.RACE_THUNDER: ra = race[12]; break;
                case (int)RACE.RACE_DRAGON: ra = race[13]; break;
                case (int)RACE.RACE_BEAST: ra = race[14]; break;
                case (int)RACE.RACE_BEASTWARRIOR: ra = race[15]; break;
                case (int)RACE.RACE_DINOSAUR: ra = race[16]; break;
                case (int)RACE.RACE_FISH: ra = race[17]; break;
                case (int)RACE.RACE_SEASERPENT: ra = race[18]; break;
                case (int)RACE.RACE_REPTILE: ra = race[19]; break;
                case (int)RACE.RACE_PSYCHO: ra = race[20]; break;
                case (int)RACE.RACE_DEVINE: ra = race[21]; break;
                case (int)RACE.RACE_CREATORGOD: ra = race[22]; break;
                default: ra = ""; break;
            }
            return ra;
        }
        private static string _ATKDEF(int i)
        {
            if (i < 0)
                return "<sym-auto>?</sym-auto>";
            else
                return i.ToString();
        }
        private static string _TEXT(string type, string desc,string lang)
        {
            StringBuilder st = new StringBuilder();
            st.Append(desc);
            st.Replace("\r\n", "\n");
            if (lang == "日文")
            {
                st.Replace("。\n", "。");
            }
            if (lang == "简体" || lang == "繁体")
            {
                st.Replace("。●", "。\n●");
            }
            st.Replace("\n", "\n		");
            st.Replace(" ", @"　");
            string temp = st.ToString();
            st.Remove(0, st.Length);
            st = null;
            return temp;
        }
        private static string _LEVEL(string type, string type1, int l,string Lang)
        {
            int i = 0;
            string le = "";
            if (type == "魔法" || type == "陷阱")
            {
                if (Lang == "英文")
                {
                    if (type == "陷阱")
                        le = "Trap Card ";
                    else
                        le = "Spell Card ";
                    switch (type1)
                    {
                        case "速攻": le += @"<sym>速攻</sym>"; break;
                        case "装备": le += @"<sym>装备</sym>"; break;
                        case "场地": le += @"<sym>场地</sym>"; break;
                        case "仪式": le += @"<sym>仪式</sym>"; break;
                        case "反击": le += @"<sym>反击</sym>"; break;
                        case "永续": le += @"<sym>永续</sym>"; break;
                    }
                }
                else
                {
                    switch (type1)
                    {
                        case "速攻": le = @"<sym><sym-auto>!</sym-auto></sym>"; break;
                        case "装备": le = @"<sym><sym-auto>+</sym-auto></sym>"; break;
                        case "场地": le = @"<sym><sym-auto>&</sym-auto></sym>"; break;
                        case "仪式": le = @"<sym><sym-auto>#</sym-auto></sym>"; break;
                        case "通常": le = @"<sym><sym-auto>^</sym-auto></sym>"; break;
                        case "反击": le = @"<sym><sym-auto>$</sym-auto></sym>"; break;
                        case "永续": le = @"<sym><sym-auto>%</sym-auto></sym>"; break;
                    }
                }
            }
            else
            {
                for (i = 0; i < l; i++)
                    le += @"<sym-auto>*</sym-auto>";
            }
            return le;
        }
        private static void WriteText(string file, string str)
        {
            using (FileStream f = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(f, Encoding.UTF8);
                sw.Write(str);
                sw.Close();
                f.Close();
                str = null;
            }
        }
        private static string[] twrace()
        {
            return new string[]{
                "戰士族",
                "魔法使族",
                "天使族",
                "惡魔族",
                 "不死族",
                 "機械族",
                 "水族",
                 "炎族",
                 "岩石族",
                 "鳥獸族",
                 "植物族",
                 "昆蟲族",
                  "雷族",  
                  "龍族",  
                   "獸族", 
                   "獸戰士族",
                   "恐龍族",                   
                    "魚族",                    
                    "爬蟲類族",
                    "念動力族",                                     
                    "海龍族",   
                    "幻神獸族",
                    "創造神族"};
        }
        private static string[] tweffect()
        {
            return new string[]{
                    "同調",
                    "超量",
                    "融合",
                    "儀式",
                    "效果",
                    "調整",
                    "靈魂",
                    "卡通",
                    "二重",
                    "同盟",
                    "黑暗同調",
                    "黑暗調整"};
        }
        private static string[] enrace()
        {
            return new string[]{
                "Warrior",
                "Spellcaster",
                "Fairy",
                "Fiend",
                "Zombie",
                "Machine",
                "Aqua",
                "Pyro",
                "Rock",
                "Winged Beast",
                "Plant",
                "Insect",
                "Thunder",
                "Dragon",
                "Beast",
                "Beast-Warrior",
                "Dinosaur",
                "Fish",
                "Sea Serpent", 
                "Reptile",   
                "Psychic",
                "Divine-Beast",
                "Created-Divine"
            };
        }
        private static string[] eneffect()
        {
            return new string[]{
                "Synchro",
                "Xyz",
                "Fusion",
                "Ritual",
                "Effect",
                "Tuner",
                "Spirit",
                "Toon",
                "Gemini",
                "Union",
                "Dark Synchro",
                "Dark Tuner"};
        }
        private static string[] jprace()
        {
            return new string[]{
                "戰士族",
                "魔法使い族",
                "天使族",
                "惡魔族",
                "アンデット族",
                "機械族",
                "水族",
                "炎族",
                "岩石族",
                "鳥獸族",
                "植物族",
                "昆虫族",
                "雷族",
                "ドラゴン族",
                "獸族",
                "獸戰士族",
                "恐竜族",
                "魚族",
                "海竜族",
                "爬虫類族", 
                "サイキック族",                 
                "幻神獸族",
                "創造神族"};
        }
        private static string[] jpeffect()
        {
            return new string[]{
                "シンクロ",
                "エクシーズ",
                "融合",
                "儀式",
                "効果",
                "チューナー",
                "スピリット",
                "トゥーン",
                "デュアル",
                "ユニオン",
                "ダークシンクロ",
                "ダークチューナー"};
        }
        private static string[] cnrace()
        {
            return new string[]{
                    "战士族",
                    "魔法使族",
                    "天使族",
                    "恶魔族",
                    "不死族",
                    "机械族",
                    "水族",
                    "炎族",
                    "岩石族",
                    "鸟兽族",
                    "植物族",
                    "昆虫族",
                    "雷族",
                    "龙族",
                    "兽族",
                    "兽战士族",
                    "恐龙族",
                    "鱼族",
                    "海龙族",
                    "爬虫类族",
                    "念动力族",
                    "幻神兽族",
                    "创造神族"};
        }
        private static string[] cneffect()
        {
            return new string[]{
                    "同调",
                    "超量",
                    "融合",
                    "仪式",
                    "效果",
                    "调整",
                    "灵魂",
                    "卡通",
                    "二重",
                    "同盟",
                    "黑暗同调",
                    "黑暗调整"};
        }
        private static void intil()
        {
            enattribute = new string[] {"earth","water","fire","wind","light","dark","divine","spell","trap"};
            attribute= new string[] {"地","水","炎","风","光","暗","神","魔法","陷阱"};
        }
    }
}

