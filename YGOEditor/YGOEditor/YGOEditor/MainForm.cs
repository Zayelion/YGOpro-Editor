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
            
            m_deserializeDockConetent = new DeserializeDockContent(YEFormFactory.CreateForm);
            m_codeEditors =  new List<CodeEditor>();
        }
        #region  Const var
        private string m_ConfigFile = Properties.Settings.Default.ConfigFile;

        private bool m_showDocMap = false;
        #endregion

        #region Members
        private DeserializeDockContent m_deserializeDockConetent;
        private List<CodeEditor> m_codeEditors;

        
        #endregion

        

        #region Customs

        public void DockSaveAsXml()
        {
            try
            {
                dockPanel.SaveAsXml(m_ConfigFile);
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
                if (File.Exists(m_ConfigFile))
                    dockPanel.LoadFromXml(m_ConfigFile, GetContentFromPersistString);
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
            m_showDocMap = Properties.Settings.Default.ShowDocMap;

        }

        public void OpenFile(string fileName)
        {
            CodeEditor ce = new CodeEditor();
            m_codeEditors.Add(ce);
            ce.ShowDocMap = m_showDocMap;
            ce.Open(openFileDialog1.FileName);
            ce.Show(dockPanel);
        }

        public void CreateFile()
        {
            CodeEditor ce = new CodeEditor();
            m_codeEditors.Add(ce);
            ce.ShowDocMap = m_showDocMap;
            ce.Text = "New" + m_codeEditors.Count + ".lua";
            ce.Show(dockPanel);
        }

        
       
        #endregion



        #region Functions
        private void 文档结构图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_showDocMap = DocMapToolStripMenuItem.Checked;
            
            //Update CodeEditors
            foreach (CodeEditor ce in m_codeEditors)
            {
                ce.ShowDocMap = m_showDocMap;
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
