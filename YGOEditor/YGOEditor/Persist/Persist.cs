using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace YGOEditor.Helper
{

    class Persist
    {
        private string m_typeName;

        public string TypeName
        {
            get { return m_typeName; }
            set { m_typeName = value; }
        }
        private List<string> m_params;

        public List<string> Params
        {
            get { return m_params; }
            set { m_params = value; }
        }

        public Persist(string persistString)
        {
            m_params = new List<string>();

            string[] prasedString = persistString.Split(',');

            m_typeName = prasedString[0];

            if (prasedString.Length != 1)
            {
                for (int i = 1; i < prasedString.Length; i++)
                {
                    m_params.Add(prasedString[i]);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder strBldr = new StringBuilder();
            strBldr.Append(TypeName);
            strBldr.Append(",");

            foreach (string str in Params)
            {
                strBldr.Append(str);
                strBldr.Append(",");
            }

            strBldr.Remove(strBldr.Length - 1,1);
            return strBldr.ToString();
        }
    }
}
