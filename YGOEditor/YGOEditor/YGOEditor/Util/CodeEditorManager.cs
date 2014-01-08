using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YGOEditor.Util {
    public class CodeEditorManager {

        private static List<CodeEditor> ces = new List<CodeEditor>();
        private static bool _showAllDocMap;
        

        public static List<CodeEditor> CodeEditors {
            get {
                return ces;
            }
        }

        public static bool ShowAllDocMap {
            get {
                return _showAllDocMap;
            }
            set {
                _showAllDocMap = value;
                foreach (CodeEditor ce in ces) {
                    ce.ShowDocMap = value;
                }
            }
        }

        public static CodeEditor Create(string fileName) {
            try {
                CodeEditor ce = new CodeEditor();
                ce.Open(fileName);
                ce.ShowDocMap = _showAllDocMap;
                ces.Add(ce);
                return ce;
            }
            catch (System.Exception ex) {
                throw ex;
            }
        }

        public static CodeEditor Create() {
            CodeEditor ce = new CodeEditor();
            ce.Text = "New" + CodeEditorManager.CodeEditors.Count + ".lua";
            ce.ShowDocMap = _showAllDocMap;
            ces.Add(ce);
            return ce;
        }
    }
}
