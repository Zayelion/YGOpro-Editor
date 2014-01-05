using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;

namespace YGOEditor
{
    public partial class CodeEditor : DockContent
    {

        public CodeEditor()
        {
            InitializeComponent();
        }

        private bool m_showDocMap;
        private string m_fileName;

        public bool ShowDocMap
        {
            get
            {
                return !splitContainer1.Panel2Collapsed;
            }

            set
            {
                splitContainer1.Panel2Collapsed = !value;
            }

        }
        public FastColoredTextBox FastColoredTB
        {
            get
            {
                return fastColoredTextBox1;
            }
        }
        public string FileName
        {
            get
            {
                return m_fileName;
            }
        }
        #region Functions

        public void Open(string fileName, Encoding code = null)
        {
            if (code == null) code = Encoding.UTF8;
            m_fileName = fileName;
            fastColoredTextBox1.OpenBindingFile(fileName, code);
            this.Text = Path.GetFileName(fileName);
            fastColoredTextBox1.OnTextChanged();
        }

        /// <summary>
        /// save as
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="code"></param>
        public void Save(string fileName, Encoding code = null)
        {
            if (code == null) code = Encoding.UTF8;
            fastColoredTextBox1.SaveToFile(fileName, code);
        }
        /// <summary>
        /// save override
        /// </summary>
        public void Save()
        {
            Save(FileName, null);
        }

        public void Redo()
        {
            fastColoredTextBox1.Redo();
        }

        public void Undo()
        {
            fastColoredTextBox1.Undo();
        }

        protected override string GetPersistString()
        {
                return GetType().ToString() + "," + m_fileName;
        }
            
        #endregion

    }

}
