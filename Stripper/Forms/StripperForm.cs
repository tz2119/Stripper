using Strip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
namespace Stripper.Forms {
    partial class StripperForm : Form {

        private const string FILTER = "カラーテーブル(*.ct)|*.ct|すべてのファイル(*.*)|*.*";
        private string filePath = string.Empty;
        private string fileName = string.Empty;
        private UserColorTable userColorTable;
        private UserColorTable userColorTableCheck;
        private PreviewForm previewForm;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public StripperForm() {
            this.InitializeComponent();
            this.userColorTable = new UserColorTable();
            this.userColorTableCheck = new UserColorTable();
            this.Text = this.version;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Load(object sender, EventArgs e) {
            ToolStripManager.VisualStylesEnabled = true;
            ToolStripManager.RenderMode = ToolStripManagerRenderMode.Professional;
            ToolStripManager.Renderer = new ToolStripProfessionalRenderer(this.userColorTable) {
                RoundedEdges = true
            };
            this.propertyGrid.SelectedObject = this.userColorTable;
            this.btnPreview_Click(null, EventArgs.Empty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPreview_Click(object sender, EventArgs e) {
            if (this.previewForm == null || !this.previewForm.Visible) {
                // フォーム設定
                this.previewForm = new PreviewForm();
                this.previewForm.Owner = this;
                // トップレベルウィンドウを false にする。
                // これをしないとパネルに追加する際、エラーになる
                this.previewForm.TopLevel = false;
                // サイズ設定
                this.previewForm.Size = this.panel1.Size;
                //フォームのコントロールに追加する
                this.panel1.Controls.Add(this.previewForm);
                //フォームを表示する
                this.previewForm.Show();
                //最前面へ移動
                this.previewForm.BringToFront();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        private void setColor(Color c) {
            ToolStripManager.Renderer = new ToolStripProfessionalRenderer(this.userColorTable);
        }

        /// <summary>
        /// 
        /// </summary>
        private void setHtmlColor() {
            ToolStripManager.Renderer = new ToolStripProfessionalRenderer(this.userColorTable);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuExit_Click(object sender, EventArgs e) {
            base.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSource_Click(object sender, EventArgs e) {
            Clipboard.SetDataObject(this.userColorTable.GetSource(), true);
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuVisualStyle_Click(object sender, EventArgs e) {
            ToolStripManager.VisualStylesEnabled = !ToolStripManager.VisualStylesEnabled;
            if (this.previewForm != null) {
                this.previewForm.Refresh();
            }
            this.Refresh();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuForeColor_Click(object sender, EventArgs e) {
            ColorDialog cd = new ColorDialog();
            cd.Color = this.previewForm.menuStrip.ForeColor ;
            if (cd.ShowDialog() == DialogResult.OK) {
                this.previewForm.toolStrip.ForeColor = cd.Color;
                this.previewForm.statusStrip.ForeColor = cd.Color;
                foreach (ToolStripMenuItem menu in this.previewForm.menuStrip.Items) {
                    menu.ForeColor = cd.Color;
                    foreach (ToolStripItem item in menu.DropDownItems) {
                        item.ForeColor = cd.Color;
                    }
                }
                foreach (ToolStripItem item in this.previewForm.contextMenuStrip.Items) {
                    item.ForeColor = cd.Color;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheck_Click(object sender, EventArgs e) {
            this.btnUndo.Enabled = true;
            this.userColorTableCheck.Check(this.propertyGrid.SelectedGridItem.Label);
            this.propertyGrid.SelectedObject = this.userColorTableCheck;
            ToolStripManager.Renderer = new ToolStripProfessionalRenderer(this.userColorTableCheck);
            this.propertyGrid.Refresh();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUndo_Click(object sender, EventArgs e) {
            this.btnUndo.Enabled = false;
            this.propertyGrid.SelectedObject = this.userColorTable;
            ToolStripManager.Renderer = new ToolStripProfessionalRenderer(this.userColorTable);
            this.propertyGrid.Refresh();
        }
        private void propertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e) {
            if (this.previewForm != null) {
                this.previewForm.Refresh();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "カラーテーブル(*.ct)|*.ct|すべてのファイル(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                Dictionary<string, Color> dictionary = StripperUtils.LoadFromBinaryFile(openFileDialog.FileName) as Dictionary<string, Color>;
                if (dictionary != null) {
                    this.filePath = openFileDialog.FileName;
                    this.fileName = openFileDialog.SafeFileName;
                    this.Text = this.fileName + " - " + this.version;
                    this.userColorTable.ColorTable = dictionary;
                    this.propertyGrid.Refresh();
                    if (this.previewForm != null) {
                        this.previewForm.Refresh();
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "カラーテーブル(*.ct)|*.ct|すべてのファイル(*.*)|*.*";
            // 保存の場合
            if (sender.Equals(this.menuSave)) {
                if (!string.IsNullOrEmpty(this.filePath)) {
                    this.Text = this.fileName + " - " + this.version;
                    StripperUtils.SaveToBinaryFile(this.userColorTable.ColorTable, this.filePath);
                    return;
                }
                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    this.filePath = saveFileDialog.FileName;
                    this.fileName = Path.GetFileName(saveFileDialog.FileName);
                    this.Text = this.fileName + " - " + this.version;
                    StripperUtils.SaveToBinaryFile(this.userColorTable.ColorTable, this.filePath);
                    return;
                }
            } else {
                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    this.filePath = saveFileDialog.FileName;
                    this.fileName = Path.GetFileName(saveFileDialog.FileName);
                    this.Text = this.fileName + " - " + this.version;
                    StripperUtils.SaveToBinaryFile(this.userColorTable.ColorTable, this.filePath);
                }
            }
        }

        /// <summary>
        /// バージョン情報を取得します。
        /// </summary>
        public string version {
            get {
                Assembly executingAssembly = Assembly.GetExecutingAssembly();
                Version version = executingAssembly.GetName().Version;
                return "Stripper V" + version.ToString();
            }
        }
    }
}
