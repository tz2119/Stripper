using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Stripper {
    [Serializable()]
    [DefaultProperty("ButtonCheckedGradientBegin")]
    public class UserColorTable : ProfessionalColorTable {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public UserColorTable() {
            ToolStripManager.RenderMode = ToolStripManagerRenderMode.Professional;
            ToolStripProfessionalRenderer renderer = (ToolStripProfessionalRenderer)ToolStripManager.Renderer;

            this.ColorTable = new Dictionary<string, Color>();
            this.ColorTable["ButtonCheckedGradientBegin"] = renderer.ColorTable.ButtonCheckedGradientBegin;
            this.ColorTable["ButtonCheckedGradientEnd"] = renderer.ColorTable.ButtonCheckedGradientEnd;
            this.ColorTable["ButtonCheckedGradientMiddle"] = renderer.ColorTable.ButtonCheckedGradientMiddle;
            this.ColorTable["ButtonCheckedHighlight"] = renderer.ColorTable.ButtonCheckedHighlight;
            this.ColorTable["ButtonCheckedHighlightBorder"] = renderer.ColorTable.ButtonCheckedHighlightBorder;
            this.ColorTable["ButtonPressedBorder"] = renderer.ColorTable.ButtonPressedBorder;
            this.ColorTable["ButtonPressedGradientBegin"] = renderer.ColorTable.ButtonPressedGradientBegin;
            this.ColorTable["ButtonPressedGradientEnd"] = renderer.ColorTable.ButtonPressedGradientEnd;
            this.ColorTable["ButtonPressedGradientMiddle"] = renderer.ColorTable.ButtonPressedGradientMiddle;
            this.ColorTable["ButtonPressedHighlight"] = renderer.ColorTable.ButtonPressedHighlight;
            this.ColorTable["ButtonPressedHighlightBorder"] = renderer.ColorTable.ButtonPressedHighlightBorder;
            this.ColorTable["ButtonSelectedBorder"] = renderer.ColorTable.ButtonSelectedBorder;
            this.ColorTable["ButtonSelectedGradientBegin"] = renderer.ColorTable.ButtonSelectedGradientBegin;
            this.ColorTable["ButtonSelectedGradientEnd"] = renderer.ColorTable.ButtonSelectedGradientEnd;
            this.ColorTable["ButtonSelectedGradientMiddle"] = renderer.ColorTable.ButtonSelectedGradientMiddle;
            this.ColorTable["ButtonSelectedHighlight"] = renderer.ColorTable.ButtonSelectedHighlight;
            this.ColorTable["ButtonSelectedHighlightBorder"] = renderer.ColorTable.ButtonSelectedHighlightBorder;
            this.ColorTable["CheckBackground"] = renderer.ColorTable.CheckBackground;
            this.ColorTable["CheckPressedBackground"] = renderer.ColorTable.CheckPressedBackground;
            this.ColorTable["CheckSelectedBackground"] = renderer.ColorTable.CheckSelectedBackground;
            this.ColorTable["GripDark"] = renderer.ColorTable.GripDark;
            this.ColorTable["GripLight"] = renderer.ColorTable.GripLight;
            this.ColorTable["ImageMarginGradientBegin"] = renderer.ColorTable.ImageMarginGradientBegin;
            this.ColorTable["ImageMarginGradientEnd"] = renderer.ColorTable.ImageMarginGradientEnd;
            this.ColorTable["ImageMarginGradientMiddle"] = renderer.ColorTable.ImageMarginGradientMiddle;
            this.ColorTable["ImageMarginRevealedGradientBegin"] = renderer.ColorTable.ImageMarginRevealedGradientBegin;
            this.ColorTable["ImageMarginRevealedGradientEnd"] = renderer.ColorTable.ImageMarginRevealedGradientEnd;
            this.ColorTable["ImageMarginRevealedGradientMiddle"] = renderer.ColorTable.ImageMarginRevealedGradientMiddle;
            this.ColorTable["MenuBorder"] = renderer.ColorTable.MenuBorder;
            this.ColorTable["MenuItemBorder"] = renderer.ColorTable.MenuItemBorder;
            this.ColorTable["MenuItemPressedGradientBegin"] = renderer.ColorTable.MenuItemPressedGradientBegin;
            this.ColorTable["MenuItemPressedGradientEnd"] = renderer.ColorTable.MenuItemPressedGradientEnd;
            this.ColorTable["MenuItemPressedGradientMiddle"] = renderer.ColorTable.MenuItemPressedGradientMiddle;
            this.ColorTable["MenuItemSelected"] = renderer.ColorTable.MenuItemSelected;
            this.ColorTable["MenuItemSelectedGradientBegin"] = renderer.ColorTable.MenuItemSelectedGradientBegin;
            this.ColorTable["MenuItemSelectedGradientEnd"] = renderer.ColorTable.MenuItemSelectedGradientEnd;
            this.ColorTable["MenuStripGradientBegin"] = renderer.ColorTable.MenuStripGradientBegin;
            this.ColorTable["MenuStripGradientEnd"] = renderer.ColorTable.MenuStripGradientEnd;
            this.ColorTable["OverflowButtonGradientBegin"] = renderer.ColorTable.OverflowButtonGradientBegin;
            this.ColorTable["OverflowButtonGradientEnd"] = renderer.ColorTable.OverflowButtonGradientEnd;
            this.ColorTable["OverflowButtonGradientMiddle"] = renderer.ColorTable.OverflowButtonGradientMiddle;
            this.ColorTable["RaftingContainerGradientBegin"] = renderer.ColorTable.RaftingContainerGradientBegin;
            this.ColorTable["RaftingContainerGradientEnd"] = renderer.ColorTable.RaftingContainerGradientEnd;
            this.ColorTable["SeparatorDark"] = renderer.ColorTable.SeparatorDark;
            this.ColorTable["SeparatorLight"] = renderer.ColorTable.SeparatorLight;
            this.ColorTable["StatusStripBorder"] = renderer.ColorTable.StatusStripBorder;
            this.ColorTable["StatusStripGradientBegin"] = renderer.ColorTable.StatusStripGradientBegin;
            this.ColorTable["StatusStripGradientEnd"] = renderer.ColorTable.StatusStripGradientEnd;
            this.ColorTable["ToolStripBorder"] = renderer.ColorTable.ToolStripBorder;
            this.ColorTable["ToolStripContentPanelGradientBegin"] = renderer.ColorTable.ToolStripContentPanelGradientBegin;
            this.ColorTable["ToolStripContentPanelGradientEnd"] = renderer.ColorTable.ToolStripContentPanelGradientEnd;
            this.ColorTable["ToolStripDropDownBackground"] = renderer.ColorTable.ToolStripDropDownBackground;
            this.ColorTable["ToolStripGradientBegin"] = renderer.ColorTable.ToolStripGradientBegin;
            this.ColorTable["ToolStripGradientEnd"] = renderer.ColorTable.ToolStripGradientEnd;
            this.ColorTable["ToolStripGradientMiddle"] = renderer.ColorTable.ToolStripGradientMiddle;
            this.ColorTable["ToolStripPanelGradientBegin"] = renderer.ColorTable.ToolStripPanelGradientBegin;
            this.ColorTable["ToolStripPanelGradientEnd"] = renderer.ColorTable.ToolStripPanelGradientEnd;
            base.UseSystemColors = false;
        }

        [Browsable(false)]
        public override Color ButtonCheckedGradientBegin { get { return this.ColorTable["ButtonCheckedGradientBegin"]; } }
        [Browsable(false)]
        public override Color ButtonCheckedGradientEnd { get { return this.ColorTable["ButtonCheckedGradientEnd"]; } }
        [Browsable(false)]
        public override Color ButtonCheckedGradientMiddle { get { return this.ColorTable["ButtonCheckedGradientMiddle"]; } }
        [Browsable(false)]
        public override Color ButtonCheckedHighlight { get { return this.ColorTable["ButtonCheckedHighlight"]; } }
        [Browsable(false)]
        public override Color ButtonCheckedHighlightBorder { get { return this.ColorTable["ButtonCheckedHighlightBorder"]; } }
        [Browsable(false)]
        public override Color ButtonPressedBorder { get { return this.ColorTable["ButtonPressedBorder"]; } }
        [Browsable(false)]
        public override Color ButtonPressedGradientBegin { get { return this.ColorTable["ButtonPressedGradientBegin"]; } }
        [Browsable(false)]
        public override Color ButtonPressedGradientEnd { get { return this.ColorTable["ButtonPressedGradientEnd"]; } }
        [Browsable(false)]
        public override Color ButtonPressedGradientMiddle { get { return this.ColorTable["ButtonPressedGradientMiddle"]; } }
        [Browsable(false)]
        public override Color ButtonPressedHighlight { get { return this.ColorTable["ButtonPressedHighlight"]; } }
        [Browsable(false)]
        public override Color ButtonPressedHighlightBorder { get { return this.ColorTable["ButtonPressedHighlightBorder"]; } }
        [Browsable(false)]
        public override Color ButtonSelectedBorder { get { return this.ColorTable["ButtonSelectedBorder"]; } }
        [Browsable(false)]
        public override Color ButtonSelectedGradientBegin { get { return this.ColorTable["ButtonSelectedGradientBegin"]; } }
        [Browsable(false)]
        public override Color ButtonSelectedGradientEnd { get { return this.ColorTable["ButtonSelectedGradientEnd"]; } }
        [Browsable(false)]
        public override Color ButtonSelectedGradientMiddle { get { return this.ColorTable["ButtonSelectedGradientMiddle"]; } }
        [Browsable(false)]
        public override Color ButtonSelectedHighlight { get { return this.ColorTable["ButtonSelectedHighlight"]; } }
        [Browsable(false)]
        public override Color ButtonSelectedHighlightBorder { get { return this.ColorTable["ButtonSelectedHighlightBorder"]; } }
        [Browsable(false)]
        public override Color CheckBackground { get { return this.ColorTable["CheckBackground"]; } }
        [Browsable(false)]
        public override Color CheckPressedBackground { get { return this.ColorTable["CheckPressedBackground"]; } }
        [Browsable(false)]
        public override Color CheckSelectedBackground { get { return this.ColorTable["CheckSelectedBackground"]; } }
        [Browsable(false)]
        public override Color GripDark { get { return this.ColorTable["GripDark"]; } }
        [Browsable(false)]
        public override Color GripLight { get { return this.ColorTable["GripLight"]; } }
        [Browsable(false)]
        public override Color ImageMarginGradientBegin { get { return this.ColorTable["ImageMarginGradientBegin"]; } }
        [Browsable(false)]
        public override Color ImageMarginGradientEnd { get { return this.ColorTable["ImageMarginGradientEnd"]; } }
        [Browsable(false)]
        public override Color ImageMarginGradientMiddle { get { return this.ColorTable["ImageMarginGradientMiddle"]; } }
        [Browsable(false)]
        public override Color ImageMarginRevealedGradientBegin { get { return this.ColorTable["ImageMarginRevealedGradientBegin"]; } }
        [Browsable(false)]
        public override Color ImageMarginRevealedGradientEnd { get { return this.ColorTable["ImageMarginRevealedGradientEnd"]; } }
        [Browsable(false)]
        public override Color ImageMarginRevealedGradientMiddle { get { return this.ColorTable["ImageMarginRevealedGradientMiddle"]; } }
        [Browsable(false)]
        public override Color MenuBorder { get { return this.ColorTable["MenuBorder"]; } }
        [Browsable(false)]
        public override Color MenuItemBorder { get { return this.ColorTable["MenuItemBorder"]; } }
        [Browsable(false)]
        public override Color MenuItemPressedGradientBegin { get { return this.ColorTable["MenuItemPressedGradientBegin"]; } }
        [Browsable(false)]
        public override Color MenuItemPressedGradientEnd { get { return this.ColorTable["MenuItemPressedGradientEnd"]; } }
        [Browsable(false)]
        public override Color MenuItemPressedGradientMiddle { get { return this.ColorTable["MenuItemPressedGradientMiddle"]; } }
        [Browsable(false)]
        public override Color MenuItemSelected { get { return this.ColorTable["MenuItemSelected"]; } }
        [Browsable(false)]
        public override Color MenuItemSelectedGradientBegin { get { return this.ColorTable["MenuItemSelectedGradientBegin"]; } }
        [Browsable(false)]
        public override Color MenuItemSelectedGradientEnd { get { return this.ColorTable["MenuItemSelectedGradientEnd"]; } }
        [Browsable(false)]
        public override Color MenuStripGradientBegin { get { return this.ColorTable["MenuStripGradientBegin"]; } }
        [Browsable(false)]
        public override Color MenuStripGradientEnd { get { return this.ColorTable["MenuStripGradientEnd"]; } }
        [Browsable(false)]
        public override Color OverflowButtonGradientBegin { get { return this.ColorTable["OverflowButtonGradientBegin"]; } }
        [Browsable(false)]
        public override Color OverflowButtonGradientEnd { get { return this.ColorTable["OverflowButtonGradientEnd"]; } }
        [Browsable(false)]
        public override Color OverflowButtonGradientMiddle { get { return this.ColorTable["OverflowButtonGradientMiddle"]; } }
        [Browsable(false)]
        public override Color RaftingContainerGradientBegin { get { return this.ColorTable["RaftingContainerGradientBegin"]; } }
        [Browsable(false)]
        public override Color RaftingContainerGradientEnd { get { return this.ColorTable["RaftingContainerGradientEnd"]; } }
        [Browsable(false)]
        public override Color SeparatorDark { get { return this.ColorTable["SeparatorDark"]; } }
        [Browsable(false)]
        public override Color SeparatorLight { get { return this.ColorTable["SeparatorLight"]; } }
        [Browsable(false)]
        public override Color StatusStripBorder { get { return this.ColorTable["StatusStripBorder"]; } }
        [Browsable(false)]
        public override Color StatusStripGradientBegin { get { return this.ColorTable["StatusStripGradientBegin"]; } }
        [Browsable(false)]
        public override Color StatusStripGradientEnd { get { return this.ColorTable["StatusStripGradientEnd"]; } }
        [Browsable(false)]
        public override Color ToolStripBorder { get { return this.ColorTable["ToolStripBorder"]; } }
        [Browsable(false)]
        public override Color ToolStripContentPanelGradientBegin { get { return this.ColorTable["ToolStripContentPanelGradientBegin"]; } }
        [Browsable(false)]
        public override Color ToolStripContentPanelGradientEnd { get { return this.ColorTable["ToolStripContentPanelGradientEnd"]; } }
        [Browsable(false)]
        public override Color ToolStripDropDownBackground { get { return this.ColorTable["ToolStripDropDownBackground"]; } }
        [Browsable(false)]
        public override Color ToolStripGradientBegin { get { return this.ColorTable["ToolStripGradientBegin"]; } }
        [Browsable(false)]
        public override Color ToolStripGradientEnd { get { return this.ColorTable["ToolStripGradientEnd"]; } }
        [Browsable(false)]
        public override Color ToolStripGradientMiddle { get { return this.ColorTable["ToolStripGradientMiddle"]; } }
        [Browsable(false)]
        public override Color ToolStripPanelGradientBegin { get { return this.ColorTable["ToolStripPanelGradientBegin"]; } }
        [Browsable(false)]
        public override Color ToolStripPanelGradientEnd { get { return this.ColorTable["ToolStripPanelGradientEnd"]; } }
        [Browsable(false)]
        public new bool UseSystemColors { get { return base.UseSystemColors; } }
        [Browsable(false)]
        public Dictionary<string, Color> ColorTable { get; set; }

        [Category("00 共通"), DisplayName("グリップ(移動ハンドル)シャドウ効果色"), Description("GripDark\nグリップ (移動ハンドル) のシャドウ効果に使用する色を設定します。")]
        public Color GripDark2 { get { Color c = this.ColorTable["GripDark"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["GripDark"] = value; } }

        [Category("00 共通"), DisplayName("グリップ(移動ハンドル)強調表示効果色"), Description("GripLight\nグリップ (移動ハンドル) の強調表示効果に使用する色を設定します。")]
        public Color GripLight2 { get { Color c = this.ColorTable["GripLight"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["GripLight"] = value; } }

        [Category("00 共通"), DisplayName("セパレーターシャドウ効果色"), Description("SeparatorDark\nToolStripSeparator のシャドウ効果に使用する色を設定します。")]
        public Color SeparatorDark2 { get { Color c = this.ColorTable["SeparatorDark"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["SeparatorDark"] = value; } }

        [Category("00 共通"), DisplayName("セパレーター強調表示効果色"), Description("SeparatorLight\nToolStripSeparator の強調表示効果に使用する色を設定します。")]
        public Color SeparatorLight2 { get { Color c = this.ColorTable["SeparatorLight"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["SeparatorLight"] = value; } }

        [Category("00 共通"), DisplayName("ToolStripContainer開始色(未使用)"), Description("RaftingContainerGradientBegin\nToolStripContainer で使用するグラデーションの開始色を設定します。")]
        public Color RaftingContainerGradientBegin2 { get { Color c = this.ColorTable["RaftingContainerGradientBegin"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["RaftingContainerGradientBegin"] = value; } }

        [Category("00 共通"), DisplayName("ToolStripContainer終了色(未使用)"), Description("RaftingContainerGradientEnd\nToolStripContainer で使用するグラデーションの終了色を設定します。")]
        public Color RaftingContainerGradientEnd2 { get { Color c = this.ColorTable["RaftingContainerGradientEnd"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["RaftingContainerGradientEnd"] = value; } }

        [Category("00 共通"), DisplayName("ToolStripContentPanel開始色(未使用)"), Description("ToolStripContentPanelGradientBegin\nToolStripContentPanel で使用するグラデーションの開始色を設定します。")]
        public Color ToolStripContentPanelGradientBegin2 { get { Color c = this.ColorTable["ToolStripContentPanelGradientBegin"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ToolStripContentPanelGradientBegin"] = value; } }

        [Category("00 共通"), DisplayName("ToolStripContentPanel終了色"), Description("ToolStripContentPanelGradientEnd\nToolStripContentPanel で使用するグラデーションの終了色を設定します。")]
        public Color ToolStripContentPanelGradientEnd2 { get { Color c = this.ColorTable["ToolStripContentPanelGradientEnd"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ToolStripContentPanelGradientEnd"] = value; } }

        [Category("00 共通"), DisplayName("ToolStripPanel開始色"), Description("ToolStripPanelGradientBegin\nToolStripPanel で使用するグラデーションの開始色を設定します。")]
        public Color ToolStripPanelGradientBegin2 { get { Color c = this.ColorTable["ToolStripPanelGradientBegin"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ToolStripPanelGradientBegin"] = value; } }

        [Category("00 共通"), DisplayName("ToolStripPanel終了色"), Description("ToolStripPanelGradientEnd\nToolStripPanel で使用するグラデーションの終了色を設定します。")]
        public Color ToolStripPanelGradientEnd2 { get { Color c = this.ColorTable["ToolStripPanelGradientEnd"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ToolStripPanelGradientEnd"] = value; } }


        [Category("01 メニューバー"), DisplayName("背景開始色"), Description("MenuStripGradientBegin\nMenuStrip で使用するグラデーションの開始色を設定します。")]
        public Color MenuStripGradientBegin2 { get { Color c = this.ColorTable["MenuStripGradientBegin"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["MenuStripGradientBegin"] = value; } }

        [Category("01 メニューバー"), DisplayName("背景終了色"), Description("MenuStripGradientEnd\nMenuStrip で使用するグラデーションの終了色を設定します。")]
        public Color MenuStripGradientEnd2 { get { Color c = this.ColorTable["MenuStripGradientEnd"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["MenuStripGradientEnd"] = value; } }

        [Category("01 メニューバー"), DisplayName("最上位メニュー選択開始色"), Description("TMenuItemSelectedGradientBegin\noolStripMenuItem が選択された場合に使用するグラデーションの開始色を設定します。")]
        public Color MenuItemSelectedGradientBegin2 { get { Color c = this.ColorTable["MenuItemSelectedGradientBegin"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["MenuItemSelectedGradientBegin"] = value; } }

        [Category("01 メニューバー"), DisplayName("最上位メニュー選択終了色"), Description("MenuItemSelectedGradientEnd\nToolStripMenuItem が選択された場合に使用するグラデーションの終了色を設定します。")]
        public Color MenuItemSelectedGradientEnd2 { get { Color c = this.ColorTable["MenuItemSelectedGradientEnd"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["MenuItemSelectedGradientEnd"] = value; } }

        [Category("01 メニューバー"), DisplayName("最上位メニュー選択枠線色"), Description("MenuItemBorder\nToolStripMenuItem で使用する境界線の色を設定します。")]
        public Color MenuItemBorder2 { get { Color c = this.ColorTable["MenuItemBorder"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["MenuItemBorder"] = value; } }

        [Category("01 メニューバー"), DisplayName("最上位メニュークリック枠線色"), Description("MenuBorder\nMenuStrip の境界線の色を設定します。")]
        public Color MenuBorder2 { get { Color c = this.ColorTable["MenuBorder"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["MenuBorder"] = value; } }

        [Category("01 メニューバー"), DisplayName("最上位メニュークリック背景開始色"), Description("MenuItemPressedGradientBegin\n最上位の ToolStripMenuItem が押されている場合に使用するグラデーションの開始色を設定します。")]
        public Color MenuItemPressedGradientBegin2 { get { Color c = this.ColorTable["MenuItemPressedGradientBegin"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["MenuItemPressedGradientBegin"] = value; } }

        [Category("01 メニューバー"), DisplayName("最上位メニュークリック背景中間色"), Description("MenuItemPressedGradientMiddle\n最上位の ToolStripMenuItem が押されている場合に使用するグラデーションの中間色を設定します。")]
        public Color MenuItemPressedGradientMiddle2 { get { Color c = this.ColorTable["MenuItemPressedGradientMiddle"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["MenuItemPressedGradientMiddle"] = value; } }

        [Category("01 メニューバー"), DisplayName("最上位メニュークリック背景終了色"), Description("MenuItemPressedGradientEnd\n最上位の ToolStripMenuItem が押されている場合に使用するグラデーションの終了色を設定します。")]
        public Color MenuItemPressedGradientEnd2 { get { Color c = this.ColorTable["MenuItemPressedGradientEnd"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["MenuItemPressedGradientEnd"] = value; } }

        [Category("01 メニューバー"), DisplayName("最上位メニュー以外の選択背景色"), Description("MenuItemSelected\n最上位の ToolStripMenuItem 以外の ToolStripMenuItem が選択され場合に使用する純色を設定します。")]
        public Color MenuItemSelected2 { get { Color c = this.ColorTable["MenuItemSelected"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["MenuItemSelected"] = value; } }

        [Category("01 メニューバー"), DisplayName("メニュー背景色"), Description("ToolStripDropDownBackground\nToolStripDropDown の純色の背景色を設定します。")]
        public Color ToolStripDropDownBackground2 { get { Color c = this.ColorTable["ToolStripDropDownBackground"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ToolStripDropDownBackground"] = value; } }

        [Category("01 メニューバー"), DisplayName("メニューオン背景色"), Description("CheckBackground\nチェック ボタンがオンで、グラデーションが使用される場合に使用する純色を設定します。")]
        public Color CheckBackground2 { get { Color c = this.ColorTable["CheckBackground"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["CheckBackground"] = value; } }

        [Category("01 メニューバー"), DisplayName("メニューオンクリック背景色"), Description("CheckPressedBackground\nボタンがオンにされて選択され、グラデーションが使用されるときに使用する純色を設定します。")]
        public Color CheckPressedBackground2 { get { Color c = this.ColorTable["CheckPressedBackground"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["CheckPressedBackground"] = value; } }

        [Category("01 メニューバー"), DisplayName("メニューオン選択背景色"), Description("CheckSelectedBackground\nチェック ボタンがオンで、グラデーションが使用される場合に使用する純色を設定します。")]
        public Color CheckSelectedBackground2 { get { Color c = this.ColorTable["CheckSelectedBackground"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["CheckSelectedBackground"] = value; } }

        [Category("01 メニューバー"), DisplayName("メニューマージン開始色"), Description("ImageMarginGradientBegin\nToolStripDropDownMenu のイメージのマージンで使用するグラデーションの開始色を設定します。")]
        public Color ImageMarginGradientBegin2 { get { Color c = this.ColorTable["ImageMarginGradientBegin"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ImageMarginGradientBegin"] = value; } }

        [Category("01 メニューバー"), DisplayName("メニューマージン中間色"), Description("ImageMarginGradientMiddle\nToolStripDropDownMenu のイメージのマージンで使用するグラデーションの中間色を設定します。")]
        public Color ImageMarginGradientMiddle2 { get { Color c = this.ColorTable["ImageMarginGradientMiddle"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ImageMarginGradientMiddle"] = value; } }

        [Category("01 メニューバー"), DisplayName("メニューマージン終了色"), Description("ToolStripDropDownMenu のイメージのマージンで使用するグラデーションの終了色を設定します。")]
        public Color ImageMarginGradientEnd2 { get { Color c = this.ColorTable["ImageMarginGradientEnd"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ImageMarginGradientEnd"] = value; } }

        [Category("01 メニューバー"), DisplayName("メニューマージン開始色(未使用)"), Description("ImageMarginRevealedGradientBegin\nToolStripDropDownMenu に項目が表示される場合にイメージのマージンで使用するグラデーションの開始色を設定します。")]
        public Color ImageMarginRevealedGradientBegin2 { get { Color c = this.ColorTable["ImageMarginRevealedGradientBegin"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ImageMarginRevealedGradientBegin"] = value; } }

        [Category("01 メニューバー"), DisplayName("メニューマージン中間色(未使用)"), Description("ImageMarginRevealedGradientMiddle\nToolStripDropDownMenu で項目が表示される場合にイメージのマージンで使用するグラデーションの中間色を設定します。")]
        public Color ImageMarginRevealedGradientMiddle2 { get { Color c = this.ColorTable["ImageMarginRevealedGradientMiddle"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ImageMarginRevealedGradientMiddle"] = value; } }

        [Category("01 メニューバー"), DisplayName("メニューマージン終了色(未使用)"), Description("ImageMarginRevealedGradientEnd\nToolStripDropDownMenu に項目が表示される場合にイメージのマージンで使用するグラデーションの終了色を設定します。")]
        public Color ImageMarginRevealedGradientEnd2 { get { Color c = this.ColorTable["ImageMarginRevealedGradientEnd"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ImageMarginRevealedGradientEnd"] = value; } }


        [Category("02 ツールバー"), DisplayName("背景開始色"), Description("ToolStripGradientBegin\nToolStrip の背景で使用するグラデーションの開始色を設定します。")]
        public Color ToolStripGradientBegin2 { get { Color c = this.ColorTable["ToolStripGradientBegin"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ToolStripGradientBegin"] = value; } }

        [Category("02 ツールバー"), DisplayName("背景中間色"), Description("ToolStripGradientMiddle\nToolStrip の背景で使用するグラデーションの中間色を設定します。")]
        public Color ToolStripGradientMiddle2 { get { Color c = this.ColorTable["ToolStripGradientMiddle"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ToolStripGradientMiddle"] = value; } }

        [Category("02 ツールバー"), DisplayName("背景終了色"), Description("ToolStripGradientEnd\nToolStrip の背景で使用するグラデーションの終了色を設定します。")]
        public Color ToolStripGradientEnd2 { get { Color c = this.ColorTable["ToolStripGradientEnd"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ToolStripGradientEnd"] = value; } }

        [Category("02 ツールバー"), DisplayName("下線色"), Description("ToolStripBorder\nToolStrip の下端に使用する境界線の色を設定します。")]
        public Color ToolStripBorder2 { get { Color c = this.ColorTable["ToolStripBorder"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ToolStripBorder"] = value; } }

        [Category("02 ツールバー"), DisplayName("ボタン選択開始色"), Description("ButtonSelectedGradientBegin\nボタンがオンの場合に使用するグラデーションの開始色を設定します。")]
        public Color ButtonSelectedGradientBegin2 { get { Color c = this.ColorTable["ButtonSelectedGradientBegin"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ButtonSelectedGradientBegin"] = value; } }

        [Category("02 ツールバー"), DisplayName("ボタン選択中間色"), Description("ButtonSelectedGradientMiddle\nボタンがオンの場合に使用するグラデーションの中間色を設定します。")]
        public Color ButtonSelectedGradientMiddle2 { get { Color c = this.ColorTable["ButtonSelectedGradientMiddle"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ButtonSelectedGradientMiddle"] = value; } }

        [Category("02 ツールバー"), DisplayName("ボタン選択終了色"), Description("ButtonSelectedGradientEnd\nボタンがオンの場合に使用するグラデーションの終了色を設定します。")]
        public Color ButtonSelectedGradientEnd2 { get { Color c = this.ColorTable["ButtonSelectedGradientEnd"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ButtonSelectedGradientEnd"] = value; } }

        [Category("02 ツールバー"), DisplayName("ボタン選択背景色(UseSystemColors=true)"), Description("ButtonSelectedHighlight\nボタンがオンの場合に使用する純色を設定します。")]
        public Color ButtonSelectedHighlight2 { get { Color c = this.ColorTable["ButtonSelectedHighlight"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ButtonSelectedHighlight"] = value; } }

        [Category("02 ツールバー"), DisplayName("ボタン選択(オン)枠線色"), Description("ButtonSelectedBorder\nButtonSelectedGradientBegin、 ButtonSelectedGradientMiddle、および ButtonSelectedGradientEnd の各色で使用する境界線の色を設定します。")]
        public Color ButtonSelectedBorder2 { get { Color c = this.ColorTable["ButtonSelectedBorder"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ButtonSelectedBorder"] = value; } }

        [Category("02 ツールバー"), DisplayName("ボタン選択枠線色"), Description("ButtonSelectedHighlightBorder\nButtonSelectedHighlight で使用する境界線の色を設定します。")]
        public Color ButtonSelectedHighlightBorder2 { get { Color c = this.ColorTable["ButtonSelectedHighlightBorder"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ButtonSelectedHighlightBorder"] = value; } }

        [Category("02 ツールバー"), DisplayName("ボタンオン背景開始色"), Description("ButtonCheckedGradientBegin\nボタンがオンの場合に使用するグラデーションの開始色を設定します。")]
        public Color ButtonCheckedGradientBegin2 { get { Color c = this.ColorTable["ButtonCheckedGradientBegin"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ButtonCheckedGradientBegin"] = value; } }

        [Category("02 ツールバー"), DisplayName("ボタンオン背景中間色"), Description("ButtonCheckedGradientMiddle\nボタンがオンの場合に使用するグラデーションの中間色を設定します。")]
        public Color ButtonCheckedGradientMiddle2 { get { Color c = this.ColorTable["ButtonCheckedGradientMiddle"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ButtonCheckedGradientMiddle"] = value; } }

        [Category("02 ツールバー"), DisplayName("ボタンオン背景終了色"), Description("ButtonCheckedGradientEnd\nボタンがオンの場合に使用するグラデーションの終了色を設定します。")]
        public Color ButtonCheckedGradientEnd2 { get { Color c = this.ColorTable["ButtonCheckedGradientEnd"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ButtonCheckedGradientEnd"] = value; } }

        [Category("02 ツールバー"), DisplayName("ボタンオン背景色(UseSystemColors=true)"), Description("ButtonCheckedHighlight\nボタンがオンの場合に使用する純色を設定します。")]
        public Color ButtonCheckedHighlight2 { get { Color c = this.ColorTable["ButtonCheckedHighlight"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ButtonCheckedHighlight"] = value; } }

        [Category("02 ツールバー"), DisplayName("ボタンオン枠線色(未使用)"), Description("ButtonCheckedHighlightBorder\nButtonCheckedHighlight で使用する境界線の色を設定します。")]
        public Color ButtonCheckedHighlightBorder2 { get { Color c = this.ColorTable["ButtonCheckedHighlightBorder"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ButtonCheckedHighlightBorder"] = value; } }

        [Category("02 ツールバー"), DisplayName("ボタンオン選択またはクリック開始色"), Description("ButtonPressedGradientBegin\nボタンが押されている場合に使用するグラデーションの開始色を設定します。")]
        public Color ButtonPressedGradientBegin2 { get { Color c = this.ColorTable["ButtonPressedGradientBegin"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ButtonPressedGradientBegin"] = value; } }

        [Category("02 ツールバー"), DisplayName("ボタンオン選択またはクリック中間色"), Description("ButtonPressedGradientMiddle\nボタンが押されている場合に使用するグラデーションの中間色を設定します。")]
        public Color ButtonPressedGradientMiddle2 { get { Color c = this.ColorTable["ButtonPressedGradientMiddle"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ButtonPressedGradientMiddle"] = value; } }

        [Category("02 ツールバー"), DisplayName("ボタンオン選択またはクリック終了色"), Description("ButtonPressedGradientEnd\nボタンが押されている場合に使用するグラデーションの終了色を設定します。")]
        public Color ButtonPressedGradientEnd2 { get { Color c = this.ColorTable["ButtonPressedGradientEnd"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ButtonPressedGradientEnd"] = value; } }

        [Category("02 ツールバー"), DisplayName("ボタンクリック背景色(UseSystemColors=true)"), Description("ButtonPressedHighlight\nボタンが押されている場合に使用する純色を設定します。")]
        public Color ButtonPressedHighlight2 { get { Color c = this.ColorTable["ButtonPressedHighlight"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ButtonPressedHighlight"] = value; } }

        [Category("02 ツールバー"), DisplayName("ボタンクリック枠線色(未使用)"), Description("ButtonPressedBorder\nButtonPressedGradientBegin、 ButtonPressedGradientMiddle、および ButtonPressedGradientEnd の各色で使用する境界線の色を設定します。")]
        public Color ButtonPressedBorder2 { get { Color c = this.ColorTable["ButtonPressedBorder"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ButtonPressedBorder"] = value; } }

        [Category("02 ツールバー"), DisplayName("ボタンクリック枠線色(未使用)"), Description("ButtonPressedHighlightBorder\nButtonPressedHighlight で使用する境界線の色を設定します。")]
        public Color ButtonPressedHighlightBorder2 { get { Color c = this.ColorTable["ButtonPressedHighlightBorder"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["ButtonPressedHighlightBorder"] = value; } }

        [Category("02 ツールバー"), DisplayName("オーバーフローボタン開始色"), Description("OverflowButtonGradientBegin\nToolStripOverflowButton で使用するグラデーションの開始色を設定します。")]
        public Color OverflowButtonGradientBegin2 { get { Color c = this.ColorTable["OverflowButtonGradientBegin"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["OverflowButtonGradientBegin"] = value; } }

        [Category("02 ツールバー"), DisplayName("オーバーフローボタン中間色"), Description("OverflowButtonGradientMiddle\nToolStripOverflowButton で使用するグラデーションの中間色を設定します。")]
        public Color OverflowButtonGradientMiddle2 { get { Color c = this.ColorTable["OverflowButtonGradientMiddle"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["OverflowButtonGradientMiddle"] = value; } }

        [Category("02 ツールバー"), DisplayName("オーバーフローボタン終了色"), Description("OverflowButtonGradientEnd\nToolStripOverflowButton で使用するグラデーションの終了色を設定します。")]
        public Color OverflowButtonGradientEnd2 { get { Color c = this.ColorTable["OverflowButtonGradientEnd"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["OverflowButtonGradientEnd"] = value; } }

        [Category("03 ステータスバー"), DisplayName("枠線色"), Description("StatusStripBorder\nStatusStrip の上端に使用する境界線の色を設定します。")]
        public Color StatusStripBorder2 { get { Color c = this.ColorTable["StatusStripBorder"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["StatusStripBorder"] = value; } }

        [Category("03 ステータスバー"), DisplayName("背景開始色"), Description("StatusStripGradientBegin\nStatusStrip で使用するグラデーションの開始色を設定します。")]
        public Color StatusStripGradientBegin2 { get { Color c = this.ColorTable["StatusStripGradientBegin"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["StatusStripGradientBegin"] = value; } }

        [Category("03 ステータスバー"), DisplayName("背景終了色"), Description("StatusStripGradientEnd\nStatusStrip で使用するグラデーションの終了色を設定します。")]
        public Color StatusStripGradientEnd2 { get { Color c = this.ColorTable["StatusStripGradientEnd"]; return Color.FromArgb(c.A, c.R, c.G, c.B); } set { this.ColorTable["StatusStripGradientEnd"] = value; } }

        [Category("その他"), DisplayName("システムカラーを使用する"), Description("現在の visual スタイルに一致する色ではなく、System.Drawing.SystemColors を使用するかどうかを示す値を設定します。")]
        public bool UseSystemColors2 { get { return base.UseSystemColors; } set { base.UseSystemColors = value; } }

        /// <summary>
        /// 指定した箇所の色を設定します。
        /// </summary>
        /// <param name="name"></param>
        /// <param name="c"></param>
        public void SetColor(string name, Color c) {
            this.ColorTable[name] = c;
        }

        /// <summary>
        /// 指定した箇所の色を取得します。
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Color GetColor(string name) {
            return this.ColorTable[name];
        }

        /// <summary>
        /// ソースコードを取得します。
        /// </summary>
        /// <returns></returns>
        public string GetSource() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"using System.Windows.Forms;");
            sb.AppendLine($"using System.Drawing;");
            sb.AppendLine($"");
            sb.AppendLine($"namespace ColorTables {{");
            sb.AppendLine($"    public class SampleColorTable : ProfessionalColorTable {{");
            sb.AppendLine($"");
            sb.AppendLine($"        public SampleColorTable() {{");
            sb.AppendLine($"            this.UseSystemColors = {this.UseSystemColors.ToString().ToLower()};");
            sb.AppendLine($"        }}");
            sb.AppendLine($"");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ボタンがオンの場合に使用するグラデーションの開始色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ButtonCheckedGradientBegin => {this.getColorString(true, this.ColorTable["ButtonCheckedGradientBegin"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ボタンがオンの場合に使用するグラデーションの終了色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ButtonCheckedGradientEnd => {this.getColorString(true, this.ColorTable["ButtonCheckedGradientEnd"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ボタンがオンの場合に使用するグラデーションの中間色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ButtonCheckedGradientMiddle => {this.getColorString(true, this.ColorTable["ButtonCheckedGradientMiddle"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ボタンがオンの場合に使用する純色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ButtonCheckedHighlight => {this.getColorString(this.ColorTable["ButtonCheckedHighlight"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ButtonCheckedHighlight で使用する境界線の色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ButtonCheckedHighlightBorder => {this.getColorString(this.ColorTable["ButtonCheckedHighlightBorder"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ButtonPressedGradientBegin、 ButtonPressedGradientMiddle、および ButtonPressedGradientEnd の各色で使用する境界線の色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ButtonPressedBorder => {this.getColorString(this.ColorTable["ButtonPressedBorder"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ボタンが押されている場合に使用するグラデーションの開始色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ButtonPressedGradientBegin => {this.getColorString(true, this.ColorTable["ButtonPressedGradientBegin"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ボタンが押されている場合に使用するグラデーションの終了色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ButtonPressedGradientEnd => {this.getColorString(true, this.ColorTable["ButtonPressedGradientEnd"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ボタンが押されている場合に使用するグラデーションの中間色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ButtonPressedGradientMiddle => {this.getColorString(true, this.ColorTable["ButtonPressedGradientMiddle"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ボタンが押されている場合に使用する純色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ButtonPressedHighlight => {this.getColorString(this.ColorTable["ButtonPressedHighlight"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ButtonPressedHighlight で使用する境界線の色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ButtonPressedHighlightBorder => {this.getColorString(this.ColorTable["ButtonPressedHighlightBorder"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ButtonSelectedGradientBegin、 ButtonSelectedGradientMiddle、および ButtonSelectedGradientEnd の各色で使用する境界線の色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ButtonSelectedBorder => {this.getColorString(this.ColorTable["ButtonSelectedBorder"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ボタンがオンの場合に使用するグラデーションの開始色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ButtonSelectedGradientBegin => {this.getColorString(true, this.ColorTable["ButtonSelectedGradientBegin"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ボタンがオンの場合に使用するグラデーションの終了色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ButtonSelectedGradientEnd => {this.getColorString(true, this.ColorTable["ButtonSelectedGradientEnd"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ボタンがオンの場合に使用するグラデーションの中間色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ButtonSelectedGradientMiddle => {this.getColorString(true, this.ColorTable["ButtonSelectedGradientMiddle"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ボタンがオンの場合に使用する純色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ButtonSelectedHighlight => {this.getColorString(this.ColorTable["ButtonSelectedHighlight"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ButtonSelectedHighlight で使用する境界線の色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ButtonSelectedHighlightBorder => {this.getColorString(this.ColorTable["ButtonSelectedHighlightBorder"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// チェック ボタンがオンで、グラデーションが使用される場合に使用する純色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color CheckBackground => {this.getColorString(this.ColorTable["CheckBackground"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// チェック ボタンがオンで、グラデーションが使用されるときに使用する純色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color CheckPressedBackground => {this.getColorString(this.ColorTable["CheckPressedBackground"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// チェック ボタンがオンで、グラデーションが使用される場合に使用する純色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color CheckSelectedBackground => {this.getColorString(this.ColorTable["CheckSelectedBackground"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// グリップ (移動ハンドル) のシャドウ効果に使用する色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color GripDark => {this.getColorString(this.ColorTable["GripDark"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// グリップ (移動ハンドル) の強調表示効果に使用する色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color GripLight => {this.getColorString(this.ColorTable["GripLight"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStripDropDownMenu のイメージのマージンで使用するグラデーションの開始色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ImageMarginGradientBegin => {this.getColorString(this.ColorTable["ImageMarginGradientBegin"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStripDropDownMenu のイメージのマージンで使用するグラデーションの終了色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ImageMarginGradientEnd => {this.getColorString(this.ColorTable["ImageMarginGradientEnd"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStripDropDownMenu のイメージのマージンで使用するグラデーションの中間色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ImageMarginGradientMiddle => {this.getColorString(this.ColorTable["ImageMarginGradientMiddle"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStripDropDownMenu に項目が表示される場合にイメージのマージンで使用するグラデーションの開始色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ImageMarginRevealedGradientBegin => {this.getColorString(this.ColorTable["ImageMarginRevealedGradientBegin"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStripDropDownMenu に項目が表示される場合にイメージのマージンで使用するグラデーションの終了色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ImageMarginRevealedGradientEnd => {this.getColorString(this.ColorTable["ImageMarginRevealedGradientEnd"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStripDropDownMenu で項目が表示される場合にイメージのマージンで使用するグラデーションの中間色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ImageMarginRevealedGradientMiddle => {this.getColorString(this.ColorTable["ImageMarginRevealedGradientMiddle"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// MenuStrip の境界線の色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color MenuBorder => {this.getColorString(this.ColorTable["MenuBorder"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStripMenuItem で使用する境界線の色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color MenuItemBorder => {this.getColorString(this.ColorTable["MenuItemBorder"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// 最上位の ToolStripMenuItem が押されている場合に使用するグラデーションの開始色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color MenuItemPressedGradientBegin => {this.getColorString(true, this.ColorTable["MenuItemPressedGradientBegin"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// 最上位の ToolStripMenuItem が押されている場合に使用するグラデーションの終了色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color MenuItemPressedGradientEnd => {this.getColorString(true, this.ColorTable["MenuItemPressedGradientEnd"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// 最上位の ToolStripMenuItem が押されている場合に使用するグラデーションの中間色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color MenuItemPressedGradientMiddle => {this.getColorString(true, this.ColorTable["MenuItemPressedGradientMiddle"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// 最上位の ToolStripMenuItem 以外の ToolStripMenuItem が選択され場合に使用する純色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color MenuItemSelected => {this.getColorString(this.ColorTable["MenuItemSelected"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStripMenuItem が選択された場合に使用するグラデーションの開始色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color MenuItemSelectedGradientBegin => {this.getColorString(true, this.ColorTable["MenuItemSelectedGradientBegin"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStripMenuItem が選択された場合に使用するグラデーションの終了色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color MenuItemSelectedGradientEnd => {this.getColorString(true, this.ColorTable["MenuItemSelectedGradientEnd"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// MenuStrip で使用するグラデーションの開始色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color MenuStripGradientBegin => {this.getColorString(this.ColorTable["MenuStripGradientBegin"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// MenuStrip で使用するグラデーションの終了色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color MenuStripGradientEnd => {this.getColorString(this.ColorTable["MenuStripGradientEnd"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStripOverflowButton で使用するグラデーションの開始色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color OverflowButtonGradientBegin => {this.getColorString(this.ColorTable["OverflowButtonGradientBegin"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStripOverflowButton で使用するグラデーションの終了色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color OverflowButtonGradientEnd => {this.getColorString(this.ColorTable["OverflowButtonGradientEnd"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStripOverflowButton で使用するグラデーションの中間色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color OverflowButtonGradientMiddle => {this.getColorString(this.ColorTable["OverflowButtonGradientMiddle"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStripContainer で使用するグラデーションの開始色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color RaftingContainerGradientBegin => {this.getColorString(this.ColorTable["RaftingContainerGradientBegin"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStripContainer で使用するグラデーションの終了色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color RaftingContainerGradientEnd => {this.getColorString(this.ColorTable["RaftingContainerGradientEnd"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStripSeparator のシャドウ効果に使用する色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color SeparatorDark => {this.getColorString(this.ColorTable["SeparatorDark"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStripSeparator の強調表示効果に使用する色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color SeparatorLight => {this.getColorString(this.ColorTable["SeparatorLight"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// StatusStrip の上端に使用する境界線の色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color StatusStripBorder => {this.getColorString(this.ColorTable["StatusStripBorder"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// StatusStrip で使用するグラデーションの開始色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color StatusStripGradientBegin => {this.getColorString(this.ColorTable["StatusStripGradientBegin"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// StatusStrip で使用するグラデーションの終了色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color StatusStripGradientEnd => {this.getColorString(this.ColorTable["StatusStripGradientEnd"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStrip の下端に使用する境界線の色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ToolStripBorder => {this.getColorString(this.ColorTable["ToolStripBorder"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStripContentPanel で使用するグラデーションの開始色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ToolStripContentPanelGradientBegin => {this.getColorString(this.ColorTable["ToolStripContentPanelGradientBegin"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStripContentPanel で使用するグラデーションの終了色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ToolStripContentPanelGradientEnd => {this.getColorString(this.ColorTable["ToolStripContentPanelGradientEnd"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStripDropDown の純色の背景色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ToolStripDropDownBackground => {this.getColorString(this.ColorTable["ToolStripDropDownBackground"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStrip の背景で使用するグラデーションの開始色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ToolStripGradientBegin => {this.getColorString(this.ColorTable["ToolStripGradientBegin"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStrip の背景で使用するグラデーションの終了色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ToolStripGradientEnd => {this.getColorString(this.ColorTable["ToolStripGradientEnd"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStrip の背景で使用するグラデーションの中間色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ToolStripGradientMiddle => {this.getColorString(this.ColorTable["ToolStripGradientMiddle"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStripPanel で使用するグラデーションの開始色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ToolStripPanelGradientBegin => {this.getColorString(this.ColorTable["ToolStripPanelGradientBegin"])}");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// ToolStripPanel で使用するグラデーションの終了色を取得します。");
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        public override Color ToolStripPanelGradientEnd => {this.getColorString(this.ColorTable["ToolStripPanelGradientEnd"])}");
            sb.AppendLine($"    }}");
            sb.AppendLine($"}}");

            return sb.ToString();
        }

        private string getColorString(Color c) {
            return getColorString(false, c);
        }

        private string getColorString(bool isAlpha, Color c) {
            //if (c.ToKnownColor() == 0) {
            //	return "Color.FromArgb(" + c.R + "," + c.G + "," + c.B + ");";
            //} else {
            //	return "Color.FromKnownColor(KnownColor." + c.ToKnownColor().ToString() + ");";
            //}
            if (isAlpha) {
                return $"Color.FromArgb(this.Alpha, {c.R}, {c.G}, {c.B});";
            }
            return $"Color.FromArgb({c.A}, {c.R}, {c.G}, {c.B});";
        }

        public void Check(string name) {
            List<string> list = new List<string>(this.ColorTable.Keys);
            foreach (string str in list) {
                this.ColorTable[str] = Color.White;
            }
            //this.colors[name] = Color.Red;
        }
    }
}
