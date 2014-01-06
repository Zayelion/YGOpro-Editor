using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Configuration;
using YGOEditor.Util;

namespace YGOEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            _deserializeDockConetent = new DeserializeDockContent(YEFormFactory.CreateForm);
        }
        #region  Const var
        private string _configFile = Properties.Settings.Default.ConfigFile;

        private bool _showDocMap = false;
        #endregion

        #region Members
        private DeserializeDockContent _deserializeDockConetent;

        
        #endregion

        

        #region Customs

        public void DockSaveAsXml()
        {
            try
            {
                dockPanel.SaveAsXml(_configFile);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("保存配置失败！" + ex.Message, "错误");
            }
        }

        public void DockLoadXml()
        {
            try
            {
                if (File.Exists(_configFile))
                    dockPanel.LoadFromXml(_configFile,_deserializeDockConetent);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("恢复面板失败！" + ex.Message, "错误");
            }
        }

        /// <summary>
        /// 保存用户首选项设置
        /// </summary>
        public void SaveAppSetting()
        {
            Properties.Settings.Default.ShowDocMap = DocMapToolStripMenuItem.Checked;


            //final
            Properties.Settings.Default.Save();
        }
        /// <summary>
        /// 加载用户首选项设置
        /// </summary>
        public void LoadAppSetting()
        {
           DocMapToolStripMenuItem.Checked = CodeEditor.ShowDocMapOnCreate = Properties.Settings.Default.ShowDocMap;
        }

        public void OpenFile(string fileName)
        {
            CodeEditor ce = new CodeEditor();
            _codeEditors.Add(ce);
            ce.ShowDocMap = _showDocMap;
            ce.Open(openFileDialog1.FileName);
            ce.Show(dockPanel);
        }

        public void CreateFile()
        {
            CodeEditor ce = new CodeEditor();
            _codeEditors.Add(ce);
            ce.ShowDocMap = _showDocMap;
            ce.Text = "New" + _codeEditors.Count + ".lua";
            ce.Show(dockPanel);
        }

        #endregion



        #region Functions
        private void 文档结构图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _showDocMap = DocMapToolStripMenuItem.Checked;
            
            //Update CodeEditors
            foreach (DockContent dc in dockPanel.Contents) {
                if (dc is CodeEditor) {
                    CodeEditor ce = dc as CodeEditor;
                    ce.ShowDocMap = _showDocMap;
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DockSaveAsXml();
            SaveAppSetting();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadAppSetting();
            DockLoadXml();
        }        
        
        private void OpenDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                OpenFile(openFileDialog1.FileName);
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateFile();
        }


        #endregion
    }

}
