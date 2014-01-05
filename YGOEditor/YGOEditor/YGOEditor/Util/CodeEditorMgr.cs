using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;

namespace YGOEditor.Custom
{
    class CodeEditorMgr
    {
        
        #region  Members
        public static List<CodeEditor> codeEditors = new List<CodeEditor>();
        private static bool m_showDocMap = false;
        
        
        public static bool ShowDocMap
        {
            get { return CodeEditorMgr.m_showDocMap; }
            set
            {
                CodeEditorMgr.m_showDocMap = value;
                if (codeEditors.Count == 0) return;

                foreach (CodeEditor ce in codeEditors)
                {
                    ce.ShowAllDocMap = value;
                }
            }
        }
        #endregion

        public static CodeEditor CreateCodeEditor()
        {
            CodeEditor ce = new CodeEditor();
            ce.ShowAllDocMap = m_showDocMap;
            codeEditors.Add(ce);
            return ce;
        }

        public static CodeEditor CreateCodeEditor(string fileName)
        {
            CodeEditor ce = new CodeEditor();
            ce.ShowAllDocMap = m_showDocMap;
            ce.LoadFile(fileName);
            codeEditors.Add(ce);
            return ce;
        }


        public static void LoadSetting()
        {
            ShowDocMap = Properties.Settings.Default.ShowDocMap;
        }

        public static void SaveSetting()
        {
            Properties.Settings.Default.ShowDocMap = ShowDocMap;
        }



    }
}
