
namespace YGOPRO
{
    /// <summary>数据</summary>
    public struct CardData
    {
        /// <summary>密码</summary>
        public int code;
        /// <summary>规则</summary>
        public int ot;
        /// <summary>同名卡</summary>
        public int alias;
        /// <summary>系列</summary>
        public int setcode;
        /// <summary>类型</summary>
        public int type;
        /// <summary>等级</summary>
        public int level;
        /// <summary>属性</summary>
        public int attribute;
        /// <summary>种族</summary>
        public int race;
        /// <summary>攻击</summary>
        public int attack;
        /// <summary>防御</summary>
        public int defence;
        /// <summary>效果分类</summary>
        public long category;
        /// <summary>名字</summary>
        public string name;
        /// <summary>描述</summary>
        public string text;
        /// <summary>脚本文字</summary>
        public string[] desc;
    }
    /// <summary>属性</summary>
    public enum ATTRIBUTE : int
    {
        /// <summary>地</summary>
        ATTRIBUTE_EARTH = 0x01,
        /// <summary>水</summary>
        ATTRIBUTE_WATER = 0x02,
        /// <summary>炎</summary>
        ATTRIBUTE_FIRE = 0x04,
        /// <summary>风</summary>
        ATTRIBUTE_WIND = 0x08,
        /// <summary>光</summary>
        ATTRIBUTE_LIGHT = 0x10,
        /// <summary>暗</summary>
        ATTRIBUTE_DARK = 0x20,
        /// <summary>神</summary>
        ATTRIBUTE_DEVINE = 0x40,
    }
    /// <summary>类型</summary>
    public enum TYPE : int
    {
        /// <summary>怪兽</summary>
        TYPE_MONSTER = 0x1,
        /// <summary>魔法</summary>
        TYPE_SPELL = 0x2,
        /// <summary>陷阱</summary>
        TYPE_TRAP = 0x4,
        /// <summary>通常</summary>
        TYPE_NORMAL = 0x10,
        /// <summary>效果</summary>
        TYPE_EFFECT = 0x20,
        /// <summary>融合</summary>
        TYPE_FUSION = 0x40,
        /// <summary>仪式</summary>
        TYPE_RITUAL = 0x80,
        /// <summary>陷阱怪兽</summary>
        TYPE_TRAPMONSTER = 0x100,
        /// <summary>灵魂</summary>
        TYPE_SPIRIT = 0x200,
        /// <summary>同盟</summary>
        TYPE_UNION = 0x400,
        /// <summary>二重</summary>
        TYPE_DUAL = 0x800,
        /// <summary>调整</summary>
        TYPE_TUNER = 0x1000,
        /// <summary>同调</summary>
        TYPE_SYNCHRO = 0x2000,
        /// <summary>衍生物</summary>
        TYPE_TOKEN = 0x4000,
        /// <summary>速攻</summary>
        TYPE_QUICKPLAY = 0x10000,
        /// <summary>永续</summary>
        TYPE_CONTINUOUS = 0x20000,
        /// <summary>装备</summary>
        TYPE_EQUIP = 0x40000,
        /// <summary>场地</summary>
        TYPE_FIELD = 0x80000,
        /// <summary>反击</summary>
        TYPE_COUNTER = 0x100000,
        /// <summary>反转</summary>
        TYPE_FLIP = 0x200000,
        /// <summary>卡通</summary>
        TYPE_TOON = 0x400000,
        /// <summary>超量</summary>
        TYPE_XYZ = 0x800000,
    }
    /// <summary>种族</summary>
    public enum RACE : int
    {
        /// <summary>战士</summary>
        RACE_WARRIOR = 0x1,
        /// <summary>魔法使</summary>
        RACE_SPELLCASTER = 0x2,
        /// <summary>天使</summary>
        RACE_FAIRY = 0x4,
        /// <summary>恶魔</summary>
        RACE_FIEND = 0x8,
        /// <summary>不死</summary>
        RACE_ZOMBIE = 0x10,
        /// <summary>机械</summary>
        RACE_MACHINE = 0x20,
        /// <summary>水</summary>
        RACE_AQUA = 0x40,
        /// <summary>炎</summary>
        RACE_PYRO = 0x80,
        /// <summary>岩石</summary>
        RACE_ROCK = 0x100,
        /// <summary>鸟兽</summary>
        RACE_WINDBEAST = 0x200,
        /// <summary>植物</summary>
        RACE_PLANT = 0x400,
        /// <summary>昆虫</summary>
        RACE_INSECT = 0x800,
        /// <summary>雷</summary>
        RACE_THUNDER = 0x1000,
        /// <summary>龙</summary>
        RACE_DRAGON = 0x2000,
        /// <summary>兽</summary>
        RACE_BEAST = 0x4000,
        /// <summary>兽战士</summary>
        RACE_BEASTWARRIOR = 0x8000,
        /// <summary>恐龙</summary>
        RACE_DINOSAUR = 0x10000,
        /// <summary>鱼</summary>
        RACE_FISH = 0x20000,
        /// <summary>海龙</summary>
        RACE_SEASERPENT = 0x40000,
        /// <summary>爬虫类</summary>
        RACE_REPTILE = 0x80000,
        /// <summary>念动力</summary>
        RACE_PSYCHO = 0x100000,
        /// <summary>幻神兽</summary>
        RACE_DEVINE = 0x200000,
        /// <summary>创造神</summary>
        RACE_CREATORGOD = 0x400000,
    }
}
