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

namespace YGOEditor {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();

            _deserializeDockConetent = new DeserializeDockContent(GetContentFromPersistString);
            _effectView = new EffectView();
        }

       
        #region  Const var
        private string _configFile = Properties.Settings.Default.ConfigFile;

        private bool _showDocMap = false;
        #endregion

        #region Members
        private DeserializeDockContent _deserializeDockConetent;
        private EffectView _effectView;
        
        #endregion



        #region Customs

        private IDockContent GetContentFromPersistString(string persistString) {

            Persist ps = new Persist(persistString);

            if (ps.TypeName == typeof(CodeEditor).ToString()) {
                if ( ps.Params == null || string.IsNullOrEmpty(ps.Params[0]))
                    return null;

                CodeEditor ce = CodeEditorManager.Create(ps.Params[0]);
                ce.Text = ps.Params[1];
                return ce;
            }

            return null;
        }

        public void DockSaveAsXml() {
            try {
                dockPanel.SaveAsXml(_configFile);
            }
            catch (System.Exception ex) {
                MessageBox.Show("保存配置失败！" + ex.Message, "错误");
            }
        }

        public void DockLoadXml() {
            try {
                if (File.Exists(_configFile))
                    dockPanel.LoadFromXml(_configFile, _deserializeDockConetent);
            }
            catch (System.Exception ex) {
                MessageBox.Show("恢复面板失败！" + ex.Message, "错误");
            }
        }

        /// <summary>
        /// 保存用户首选项设置
        /// </summary>
        public void SaveAppSetting() {
            Properties.Settings.Default.ShowDocMap = DocMapToolStripMenuItem.Checked;


            //final
            Properties.Settings.Default.Save();
        }
        /// <summary>
        /// 加载用户首选项设置
        /// </summary>
        public void LoadAppSetting() {
            CodeEditorManager.ShowAllDocMap = DocMapToolStripMenuItem.Checked =  Properties.Settings.Default.ShowDocMap;
        }

        #endregion



        #region Functions
        private void 文档结构图ToolStripMenuItem_Click(object sender, EventArgs e) {
            CodeEditorManager.ShowAllDocMap = _showDocMap = DocMapToolStripMenuItem.Checked;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            DockSaveAsXml();
            SaveAppSetting();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            LoadAppSetting();
            DockLoadXml();
        }

        private void OpenDocToolStripMenuItem_Click(object sender, EventArgs e) {
//             DialogResult result = openFileDialog1.ShowDialog();
//             if (result == DialogResult.OK) {
//                 OpenFile(openFileDialog1.FileName);
//             }

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                try {
                    DockContent dc = CodeEditorManager.Create(openFileDialog1.FileName);
                    dc.MdiParent = this;
                    dc.Show(dockPanel);
                }
                catch (System.Exception ex) {
                    MessageBox.Show("打开错误！" + ex.Message);
                }
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e) {
//             CreateFile();
            DockContent dc = CodeEditorManager.Create();
            dc.MdiParent = this;
            dc.Show(dockPanel);
        }


        #endregion

        private void 效果管理器ToolStripMenuItem_Click(object sender, EventArgs e) {
            _effectView.Show(dockPanel);
        }
    }

}
