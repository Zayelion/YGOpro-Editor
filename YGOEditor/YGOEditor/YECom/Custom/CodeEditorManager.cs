using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;

namespace YGOEditor.Custom
{
    class CodeEditorHelper
    {
        
        #region  Members
        public static List<CodeEditor> codeEditors = new List<CodeEditor>();
        private static bool m_showDocMap = false;
        
        
        public static bool ShowDocMap
        {
            get { return CodeEditorHelper.m_showDocMap; }
            set
            {
                CodeEditorHelper.m_showDocMap = value;
                if (codeEditors.Count == 0) return;

                foreach (CodeEditor ce in codeEditors)
                {
                    ce.ShowDocMap = value;
                }
            }
        }
        #endregion

        public static CodeEditor CreateCodeEditor()
        {
            CodeEditor ce = new CodeEditor();
            ce.ShowDocMap = m_showDocMap;
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
