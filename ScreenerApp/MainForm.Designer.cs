namespace ScreenerApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleIconSet formatConditionRuleIconSet1 = new DevExpress.XtraEditors.FormatConditionRuleIconSet();
            DevExpress.XtraEditors.FormatConditionIconSet formatConditionIconSet1 = new DevExpress.XtraEditors.FormatConditionIconSet();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon1 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon2 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon3 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon4 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon5 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            this.colDays5Ago = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnConnectionsEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnSecurities = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoadData = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup2 = new DevExpress.XtraBars.BarButtonGroup();
            this.beAccount = new DevExpress.XtraBars.BarEditItem();
            this.cbAccounts = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnConnect = new DevExpress.XtraBars.BarButtonItem();
            this.rpMain = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridScreener = new DevExpress.XtraGrid.GridControl();
            this.gvScreener = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.bandMarket = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colMarket = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandSecutiry = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSymbol = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPeriod = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandChart = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandWPR5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandWPR21 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.chartGeneral = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).BeginInit();
            this.splitContainerControl2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).BeginInit();
            this.splitContainerControl2.Panel2.SuspendLayout();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridScreener)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvScreener)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // colDays5Ago
            // 
            this.colDays5Ago.Caption = "Зак5";
            this.colDays5Ago.FieldName = "Days5Ago";
            this.colDays5Ago.Name = "colDays5Ago";
            this.colDays5Ago.OptionsColumn.AllowEdit = false;
            this.colDays5Ago.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDays5Ago.UnboundDataType = typeof(int);
            this.colDays5Ago.Visible = true;
            this.colDays5Ago.Width = 35;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnConnectionsEdit,
            this.btnSecurities,
            this.btnLoadData,
            this.barButtonGroup1,
            this.barButtonGroup2,
            this.beAccount,
            this.btnConnect});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 18;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpMain});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbAccounts});
            this.ribbonControl1.Size = new System.Drawing.Size(1845, 150);
            // 
            // btnConnectionsEdit
            // 
            this.btnConnectionsEdit.Caption = "Настроить...";
            this.btnConnectionsEdit.Enabled = false;
            this.btnConnectionsEdit.Id = 1;
            this.btnConnectionsEdit.Name = "btnConnectionsEdit";
            // 
            // btnSecurities
            // 
            this.btnSecurities.Caption = "Инструменты";
            this.btnSecurities.Enabled = false;
            this.btnSecurities.Id = 3;
            this.btnSecurities.Name = "btnSecurities";
            this.btnSecurities.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSecurities_ItemClick);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Caption = "Получить";
            this.btnLoadData.Enabled = false;
            this.btnLoadData.Id = 4;
            this.btnLoadData.ItemAppearance.Normal.BackColor = System.Drawing.Color.Yellow;
            this.btnLoadData.ItemAppearance.Normal.Options.UseBackColor = true;
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoadData_ItemClick);
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 8;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barButtonGroup2
            // 
            this.barButtonGroup2.Caption = "barButtonGroup2";
            this.barButtonGroup2.Id = 11;
            this.barButtonGroup2.Name = "barButtonGroup2";
            // 
            // beAccount
            // 
            this.beAccount.Caption = "Аккаунт";
            this.beAccount.Edit = this.cbAccounts;
            this.beAccount.EditValue = "";
            this.beAccount.EditWidth = 150;
            this.beAccount.Id = 16;
            this.beAccount.Name = "beAccount";
            // 
            // cbAccounts
            // 
            this.cbAccounts.AutoHeight = false;
            this.cbAccounts.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAccounts.Name = "cbAccounts";
            // 
            // btnConnect
            // 
            this.btnConnect.Caption = "Подключиться";
            this.btnConnect.Id = 17;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnConnect_ItemClick);
            // 
            // rpMain
            // 
            this.rpMain.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
            this.rpMain.Name = "rpMain";
            this.rpMain.Text = "Основное";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.beAccount);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnConnectionsEdit);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnConnect);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Соединение";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSecurities);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLoadData);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Данные";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 150);
            this.splitContainerControl2.Name = "splitContainerControl2";
            // 
            // splitContainerControl2.Panel1
            // 
            this.splitContainerControl2.Panel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitContainerControl2.Panel1.Appearance.Options.UseBackColor = true;
            this.splitContainerControl2.Panel1.Controls.Add(this.gridScreener);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            // 
            // splitContainerControl2.Panel2
            // 
            this.splitContainerControl2.Panel2.Controls.Add(this.chartGeneral);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1845, 868);
            this.splitContainerControl2.SplitterPosition = 1147;
            this.splitContainerControl2.TabIndex = 2;
            // 
            // gridScreener
            // 
            this.gridScreener.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridScreener.Location = new System.Drawing.Point(0, 0);
            this.gridScreener.MainView = this.gvScreener;
            this.gridScreener.Name = "gridScreener";
            this.gridScreener.Size = new System.Drawing.Size(1147, 868);
            this.gridScreener.TabIndex = 1;
            this.gridScreener.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvScreener});
            // 
            // gvScreener
            // 
            this.gvScreener.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.bandMarket,
            this.bandSecutiry,
            this.bandChart,
            this.bandWPR5,
            this.bandWPR21});
            this.gvScreener.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colMarket,
            this.colSymbol,
            this.colPeriod,
            this.colDays5Ago});
            gridFormatRule1.Column = this.colDays5Ago;
            gridFormatRule1.Name = "Days5AgoFormatRule";
            formatConditionIconSet1.CategoryName = "Directional";
            formatConditionIconSetIcon1.PredefinedName = "Arrows5_1.png";
            formatConditionIconSetIcon1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            formatConditionIconSetIcon1.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon2.PredefinedName = "Arrows5_2.png";
            formatConditionIconSetIcon2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            formatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon3.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon4.PredefinedName = "Arrows5_4.png";
            formatConditionIconSetIcon4.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            formatConditionIconSetIcon4.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon5.PredefinedName = "Arrows5_5.png";
            formatConditionIconSetIcon5.Value = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            formatConditionIconSetIcon5.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon1);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon2);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon3);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon4);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon5);
            formatConditionIconSet1.Name = "Arrows5Colored";
            formatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleIconSet1.IconSet = formatConditionIconSet1;
            gridFormatRule1.Rule = formatConditionRuleIconSet1;
            this.gvScreener.FormatRules.Add(gridFormatRule1);
            this.gvScreener.GridControl = this.gridScreener;
            this.gvScreener.GroupCount = 1;
            this.gvScreener.Name = "gvScreener";
            this.gvScreener.OptionsDetail.EnableMasterViewMode = false;
            this.gvScreener.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMarket, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSymbol, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPeriod, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gvScreener.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvScreener_SelectionChanged);
            this.gvScreener.CustomColumnSort += new DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler(this.gvScreener_CustomColumnSort);
            // 
            // bandMarket
            // 
            this.bandMarket.Caption = "bandMarket";
            this.bandMarket.Columns.Add(this.colMarket);
            this.bandMarket.Name = "bandMarket";
            this.bandMarket.RowCount = 2;
            this.bandMarket.VisibleIndex = 0;
            this.bandMarket.Width = 191;
            // 
            // colMarket
            // 
            this.colMarket.Caption = "Рынок";
            this.colMarket.FieldName = "Market";
            this.colMarket.Name = "colMarket";
            this.colMarket.OptionsColumn.AllowEdit = false;
            this.colMarket.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colMarket.OptionsFilter.AllowFilter = false;
            this.colMarket.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colMarket.Visible = true;
            this.colMarket.Width = 191;
            // 
            // bandSecutiry
            // 
            this.bandSecutiry.AppearanceHeader.Options.UseTextOptions = true;
            this.bandSecutiry.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandSecutiry.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandSecutiry.Caption = "Инструмент";
            this.bandSecutiry.Columns.Add(this.colSymbol);
            this.bandSecutiry.Columns.Add(this.colPeriod);
            this.bandSecutiry.Name = "bandSecutiry";
            this.bandSecutiry.VisibleIndex = 1;
            this.bandSecutiry.Width = 382;
            // 
            // colSymbol
            // 
            this.colSymbol.Caption = "Символ";
            this.colSymbol.FieldName = "SymbolName";
            this.colSymbol.Name = "colSymbol";
            this.colSymbol.OptionsColumn.AllowEdit = false;
            this.colSymbol.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSymbol.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colSymbol.Visible = true;
            this.colSymbol.Width = 191;
            // 
            // colPeriod
            // 
            this.colPeriod.Caption = "Период";
            this.colPeriod.FieldName = "Period";
            this.colPeriod.Name = "colPeriod";
            this.colPeriod.OptionsColumn.AllowEdit = false;
            this.colPeriod.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPeriod.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom;
            this.colPeriod.Visible = true;
            this.colPeriod.Width = 191;
            // 
            // bandChart
            // 
            this.bandChart.AppearanceHeader.Options.UseTextOptions = true;
            this.bandChart.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandChart.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandChart.Caption = "График";
            this.bandChart.Columns.Add(this.colDays5Ago);
            this.bandChart.Name = "bandChart";
            this.bandChart.VisibleIndex = 2;
            this.bandChart.Width = 35;
            // 
            // bandWPR5
            // 
            this.bandWPR5.AppearanceHeader.Options.UseTextOptions = true;
            this.bandWPR5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandWPR5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandWPR5.Caption = "%R 5";
            this.bandWPR5.Name = "bandWPR5";
            this.bandWPR5.VisibleIndex = 3;
            this.bandWPR5.Width = 252;
            // 
            // bandWPR21
            // 
            this.bandWPR21.AppearanceHeader.Options.UseTextOptions = true;
            this.bandWPR21.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandWPR21.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandWPR21.Caption = "%R 21";
            this.bandWPR21.Name = "bandWPR21";
            this.bandWPR21.VisibleIndex = 4;
            this.bandWPR21.Width = 262;
            // 
            // chartGeneral
            // 
            this.chartGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartGeneral.Location = new System.Drawing.Point(0, 0);
            this.chartGeneral.Name = "chartGeneral";
            this.chartGeneral.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartGeneral.Size = new System.Drawing.Size(688, 868);
            this.chartGeneral.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1845, 1018);
            this.Controls.Add(this.splitContainerControl2);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).EndInit();
            this.splitContainerControl2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).EndInit();
            this.splitContainerControl2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridScreener)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvScreener)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnConnectionsEdit;
        private DevExpress.XtraBars.BarButtonItem btnSecurities;
        private DevExpress.XtraBars.BarButtonItem btnLoadData;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarEditItem beAccount;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbAccounts;
        private DevExpress.XtraBars.BarButtonItem btnConnect;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.GridControl gridScreener;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gvScreener;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandMarket;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMarket;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandSecutiry;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSymbol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPeriod;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandChart;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDays5Ago;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandWPR5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandWPR21;
        private DevExpress.XtraCharts.ChartControl chartGeneral;
    }
}