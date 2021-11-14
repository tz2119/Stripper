using System.ComponentModel;
using Strip;
using System.Windows.Forms;
using System.Drawing;
using System;
namespace Stripper.Forms {
	partial class StripperForm {
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && this.components != null) {
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StripperForm));
            this.btnPreview = new System.Windows.Forms.Button();
            this.menuStrip = new Strip.MenuStripEx();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAsName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVisualStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuForeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSource = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.btnCheck = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPreview.Location = new System.Drawing.Point(795, 451);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(86, 29);
            this.btnPreview.TabIndex = 5;
            this.btnPreview.Text = "プレビュー";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuTool});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(890, 26);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.toolStripSeparator1,
            this.menuSave,
            this.menuAsName,
            this.toolStripSeparator3,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFile.Size = new System.Drawing.Size(85, 22);
            this.menuFile.Text = "ファイル(&F)";
            // 
            // menuOpen
            // 
            this.menuOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuOpen.Size = new System.Drawing.Size(201, 22);
            this.menuOpen.Text = "開く(&O)";
            this.menuOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // menuSave
            // 
            this.menuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuSave.Name = "menuSave";
            this.menuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSave.Size = new System.Drawing.Size(201, 22);
            this.menuSave.Text = "上書き保存(&S)";
            this.menuSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // menuAsName
            // 
            this.menuAsName.Name = "menuAsName";
            this.menuAsName.Size = new System.Drawing.Size(201, 22);
            this.menuAsName.Text = "名前を付けて保存(&A)";
            this.menuAsName.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(198, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(201, 22);
            this.menuExit.Text = "終了(&X)";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuTool
            // 
            this.menuTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVisualStyle,
            this.menuForeColor});
            this.menuTool.Name = "menuTool";
            this.menuTool.Size = new System.Drawing.Size(74, 22);
            this.menuTool.Text = "ツール(&T)";
            // 
            // menuVisualStyle
            // 
            this.menuVisualStyle.Checked = true;
            this.menuVisualStyle.CheckOnClick = true;
            this.menuVisualStyle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuVisualStyle.Name = "menuVisualStyle";
            this.menuVisualStyle.Size = new System.Drawing.Size(202, 22);
            this.menuVisualStyle.Text = "ビジュアルスタイル(&V)";
            this.menuVisualStyle.Click += new System.EventHandler(this.menuVisualStyle_Click);
            // 
            // menuForeColor
            // 
            this.menuForeColor.Name = "menuForeColor";
            this.menuForeColor.Size = new System.Drawing.Size(202, 22);
            this.menuForeColor.Text = "文字色(&F)";
            this.menuForeColor.Click += new System.EventHandler(this.menuForeColor_Click);
            // 
            // btnSource
            // 
            this.btnSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSource.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSource.Location = new System.Drawing.Point(578, 451);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(211, 29);
            this.btnSource.TabIndex = 4;
            this.btnSource.Text = "ソースをクリップボードにコピー";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndo.Enabled = false;
            this.btnUndo.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUndo.Location = new System.Drawing.Point(505, 452);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(67, 28);
            this.btnUndo.TabIndex = 3;
            this.btnUndo.Text = "元に戻す";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // propertyGrid
            // 
            this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.propertyGrid.Location = new System.Drawing.Point(6, 29);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.propertyGrid.Size = new System.Drawing.Size(489, 409);
            this.propertyGrid.TabIndex = 1;
            this.propertyGrid.ToolbarVisible = false;
            this.propertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid_PropertyValueChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheck.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheck.Location = new System.Drawing.Point(432, 452);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(67, 28);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "場所確認";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(505, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 408);
            this.panel1.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(890, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StripperForm
            // 
            this.ClientSize = new System.Drawing.Size(890, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnSource);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "StripperForm";
            this.Text = "Stripper V0.0.0";
            this.Load += new System.EventHandler(this.Form_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private Button btnPreview;
		private MenuStripEx menuStrip;
		private Button btnSource;
		private ToolStripMenuItem menuTool;
		private ToolStripMenuItem menuVisualStyle;
		private Button btnUndo;
		private PropertyGrid propertyGrid;
		private Button btnCheck;
		private ToolStripMenuItem menuFile;
		private ToolStripMenuItem menuOpen;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem menuSave;
		private ToolStripMenuItem menuAsName;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripMenuItem menuExit;
        private Panel panel1;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem menuForeColor;
    }
}



