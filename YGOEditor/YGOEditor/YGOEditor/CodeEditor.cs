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
using YGOEditor.Util;

namespace YGOEditor
{
    public partial class CodeEditor : DockContent,IYEForm{

        #region Delegates
        public event EventHandler LoadedFile;

        #endregion

        #region Members
        private string _fileName;

        /// <summary>
        /// show docmap control
        /// </summary>
        public bool ShowDocMap {
            get {
                return !splitContainer1.Panel2Collapsed;
            }
            set {
                splitContainer1.Panel2Collapsed = !value;
            }
        }

        /// <summary>
        /// fastcoloredtextbox control
        /// </summary>
        public FastColoredTextBox FastColoredTB {
            get {
                return fastColoredTextBox1;
            }
        }

        /// <summary>
        /// get opened file name
        /// </summary>
        public string FileName {
            get {
                return _fileName;
            }
        }

        /// <summary>
        /// if can redo 
        /// </summary>
        public bool CanRedo {
            get {
                return fastColoredTextBox1.RedoEnabled;
            }
        }
        /// <summary>
        /// if can undo
        /// </summary>
        public bool CanUndo {
            get {
                return fastColoredTextBox1.UndoEnabled;
            }
        }

        #endregion


        #region Functions
        public CodeEditor()
        {
            InitializeComponent();
        }

        public void Open(string fileName, Encoding code = null)
        {
            if (code == null) code = Encoding.UTF8;

            try {
                fastColoredTextBox1.OpenBindingFile(fileName, code);
                _fileName = fileName;

                this.Text = Path.GetFileName(fileName);
                fastColoredTextBox1.OnTextChanged();

                //Make LoadedFile Event;
                CELoadedEventArgs e = new CELoadedEventArgs(fileName, code);
                if (LoadedFile != null) {
                    LoadedFile(this, e);
                }
            }
            catch (System.Exception ex) {
                MessageBox.Show("打开错误!" + ex.ToString(), "错误");
            }
            
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
        /// <summary>
        /// call fastcoloredtextbox redo
        /// </summary>
        public void Redo()
        {
            fastColoredTextBox1.Redo();
        }
        /// <summary>
        /// call fastcoloredtextbox undo
        /// </summary>
        public void Undo()
        {
            fastColoredTextBox1.Undo();
        }

        protected override string GetPersistString()
        {
                return GetType().ToString() + "," + _fileName;
        }
        #endregion


        #region IYEForm 成员

        public void SetParams(string[] param) {
            if (string.IsNullOrEmpty(param[0])) {
                return;
            }
            else {
                Open(param[0]);
            }
        }

        #endregion
}


    public class CELoadedEventArgs : EventArgs {

        #region Members
        /// <summary>
        /// file name
        /// </summary>
        public string FileName {
            get;
            set;
        }
        /// <summary>
        /// encoding
        /// </summary>
        public Encoding Enc {
            get;
            set;
        }
        #endregion

        public CELoadedEventArgs(string fileName,Encoding encoding) {
            FileName = fileName;
            Enc = encoding;
        }

    }

}
