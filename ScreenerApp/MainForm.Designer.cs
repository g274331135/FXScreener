﻿namespace ScreenerApp
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
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
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnConnectionsEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnSecurities = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoadData = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup2 = new DevExpress.XtraBars.BarButtonGroup();
            this.beAccount = new DevExpress.XtraBars.BarEditItem();
            this.cbAccounts = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.rpMain = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnConnect = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridScreener)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvScreener)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).BeginInit();
            this.splitContainerControl2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).BeginInit();
            this.splitContainerControl2.Panel2.SuspendLayout();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 150);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainerControl1.Panel1.Appearance.Options.UseBackColor = true;
            this.splitContainerControl1.Panel1.Controls.Add(this.gridScreener);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1845, 868);
            this.splitContainerControl1.SplitterPosition = 654;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // gridScreener
            // 
            this.gridScreener.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridScreener.Location = new System.Drawing.Point(0, 0);
            this.gridScreener.MainView = this.gvScreener;
            this.gridScreener.Name = "gridScreener";
            this.gridScreener.Size = new System.Drawing.Size(1845, 654);
            this.gridScreener.TabIndex = 0;
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
            this.colPeriod});
            this.gvScreener.GridControl = this.gridScreener;
            this.gvScreener.Name = "gvScreener";
            // 
            // bandMarket
            // 
            this.bandMarket.Columns.Add(this.colMarket);
            this.bandMarket.Name = "bandMarket";
            this.bandMarket.VisibleIndex = 0;
            this.bandMarket.Width = 75;
            // 
            // colMarket
            // 
            this.colMarket.Caption = "Рынок";
            this.colMarket.FieldName = "Market";
            this.colMarket.Name = "colMarket";
            this.colMarket.Visible = true;
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
            this.bandSecutiry.Width = 150;
            // 
            // colSymbol
            // 
            this.colSymbol.Caption = "Символ";
            this.colSymbol.FieldName = "SymbolName";
            this.colSymbol.Name = "colSymbol";
            this.colSymbol.Visible = true;
            // 
            // colPeriod
            // 
            this.colPeriod.Caption = "Период";
            this.colPeriod.FieldName = "Period";
            this.colPeriod.Name = "colPeriod";
            this.colPeriod.Visible = true;
            // 
            // bandChart
            // 
            this.bandChart.AppearanceHeader.Options.UseTextOptions = true;
            this.bandChart.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandChart.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandChart.Caption = "График";
            this.bandChart.Name = "bandChart";
            this.bandChart.VisibleIndex = 2;
            // 
            // bandWPR5
            // 
            this.bandWPR5.AppearanceHeader.Options.UseTextOptions = true;
            this.bandWPR5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandWPR5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandWPR5.Caption = "%R 5";
            this.bandWPR5.Name = "bandWPR5";
            this.bandWPR5.VisibleIndex = 3;
            // 
            // bandWPR21
            // 
            this.bandWPR21.AppearanceHeader.Options.UseTextOptions = true;
            this.bandWPR21.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandWPR21.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandWPR21.Caption = "%R 21";
            this.bandWPR21.Name = "bandWPR21";
            this.bandWPR21.VisibleIndex = 4;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            // 
            // splitContainerControl2.Panel1
            // 
            this.splitContainerControl2.Panel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitContainerControl2.Panel1.Appearance.Options.UseBackColor = true;
            this.splitContainerControl2.Panel1.Controls.Add(this.chartControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            // 
            // splitContainerControl2.Panel2
            // 
            this.splitContainerControl2.Panel2.Controls.Add(this.chartControl2);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1845, 204);
            this.splitContainerControl2.SplitterPosition = 923;
            this.splitContainerControl2.TabIndex = 0;
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(923, 204);
            this.chartControl1.TabIndex = 0;
            // 
            // chartControl2
            // 
            this.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl2.Location = new System.Drawing.Point(0, 0);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl2.Size = new System.Drawing.Size(912, 204);
            this.chartControl2.TabIndex = 1;
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
            // btnConnect
            // 
            this.btnConnect.Caption = "Подключиться";
            this.btnConnect.Id = 17;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnConnect_ItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1845, 1018);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridScreener)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvScreener)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).EndInit();
            this.splitContainerControl2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).EndInit();
            this.splitContainerControl2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridScreener;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gvScreener;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMarket;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSymbol;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPeriod;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnConnectionsEdit;
        private DevExpress.XtraBars.BarButtonItem btnSecurities;
        private DevExpress.XtraBars.BarButtonItem btnLoadData;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandMarket;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandSecutiry;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandChart;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandWPR5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandWPR21;
        private DevExpress.XtraBars.BarEditItem beAccount;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbAccounts;
        private DevExpress.XtraBars.BarButtonItem btnConnect;
    }
}