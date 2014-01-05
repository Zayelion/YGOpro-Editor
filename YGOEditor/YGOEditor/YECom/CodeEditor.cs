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

namespace YGOEditor
{
    public partial class CodeEditor : DockContent
    {
        public bool ShowDocMap
        {
            get
            {
                return !this.splitContainer1.Panel2Collapsed;
            }

            set
            {
                this.splitContainer1.Panel2Collapsed = !value;
            }

        }

        public CodeEditor()
        {
            InitializeComponent();
        }

        public CodeEditor(string fileName):this()
        {
            
        }

        #region Members
        public string FileName
        {
            get;
            set;
        }

        #endregion

        #region Customs

        public static string TypeName 
        {
            get
            {
                return typeof(CodeEditor).ToString();
            }
        }

        #endregion

        #region Functions

        protected override string GetPersistString()
        {
            return GetType().ToString() + "," + FileName;
        }
            
        #endregion

    }
}
