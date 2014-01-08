using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YGOEditor.Util {
    public class Persist {

        private string _persistString;

        /// <summary>
        /// get typeName from persist string
        /// </summary>
        public string TypeName {
            get {
                string[] prasedStr = _persistString.Split(',');
                return prasedStr[0];
            }
        }

        /// <summary>
        /// get params form persist string
        /// </summary>
        public string[] Params {
            get {
                //analys params
                string[] prasedStr = _persistString.Split(',');

                string[] retStr = new string[prasedStr.Length-1];

                for (int i = 1; i < prasedStr.Length; i++){
                    retStr[i - 1] = prasedStr[i];
                }

                return retStr;
            }
        }

        public Persist(string persistString) {
            _persistString = persistString;
        }

    }
}
