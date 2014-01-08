using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGOEditor.Util;

namespace Testor {
    class Program {
        static void Main(string[] args) {
            string str = "Codeeditor,";
            string str1 = "Codeeditor";

            Persist ps = new Persist(str);
            Persist ps1 = new Persist(str1);

            Console.WriteLine();

        }
    }
}
