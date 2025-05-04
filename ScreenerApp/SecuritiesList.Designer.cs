namespace ScreenerApp
{
    partial class SecuritiesList
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
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gridSecurities = new DevExpress.XtraGrid.GridControl();
            this.gvSecurities = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cePeriod = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colMarket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSymbolName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colW1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colH4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colM30 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colM15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colM5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colM1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSecurities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSecurities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 695);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1031, 50);
            this.panelControl1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(826, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(944, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gridSecurities
            // 
            this.gridSecurities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSecurities.Location = new System.Drawing.Point(0, 0);
            this.gridSecurities.MainView = this.gvSecurities;
            this.gridSecurities.Name = "gridSecurities";
            this.gridSecurities.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cePeriod});
            this.gridSecurities.Size = new System.Drawing.Size(1031, 695);
            this.gridSecurities.TabIndex = 1;
            this.gridSecurities.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSecurities});
            // 
            // gvSecurities
            // 
            this.gvSecurities.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colActive,
            this.colMarket,
            this.colSymbolName,
            this.colMN1,
            this.colW1,
            this.colD1,
            this.colH4,
            this.colH1,
            this.colM30,
            this.colM15,
            this.colM5,
            this.colM1,
            this.colDescription});
            this.gvSecurities.GridControl = this.gridSecurities;
            this.gvSecurities.GroupCount = 1;
            this.gvSecurities.Name = "gvSecurities";
            this.gvSecurities.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMarket, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSymbolName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colActive
            // 
            this.colActive.Caption = "Вкл/Выкл";
            this.colActive.ColumnEdit = this.cePeriod;
            this.colActive.FieldName = "Active";
            this.colActive.MaxWidth = 60;
            this.colActive.MinWidth = 60;
            this.colActive.Name = "colActive";
            this.colActive.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 0;
            this.colActive.Width = 60;
            // 
            // cePeriod
            // 
            this.cePeriod.AutoHeight = false;
            this.cePeriod.Name = "cePeriod";
            // 
            // colMarket
            // 
            this.colMarket.Caption = "Рынок";
            this.colMarket.FieldName = "Market";
            this.colMarket.MaxWidth = 100;
            this.colMarket.MinWidth = 100;
            this.colMarket.Name = "colMarket";
            this.colMarket.OptionsColumn.AllowEdit = false;
            this.colMarket.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colMarket.Visible = true;
            this.colMarket.VisibleIndex = 1;
            this.colMarket.Width = 100;
            // 
            // colSymbolName
            // 
            this.colSymbolName.Caption = "Символ";
            this.colSymbolName.FieldName = "SymbolName";
            this.colSymbolName.MaxWidth = 100;
            this.colSymbolName.MinWidth = 100;
            this.colSymbolName.Name = "colSymbolName";
            this.colSymbolName.OptionsColumn.AllowEdit = false;
            this.colSymbolName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colSymbolName.Visible = true;
            this.colSymbolName.VisibleIndex = 1;
            this.colSymbolName.Width = 100;
            // 
            // colMN1
            // 
            this.colMN1.Caption = "MN1";
            this.colMN1.ColumnEdit = this.cePeriod;
            this.colMN1.FieldName = "MN1";
            this.colMN1.MaxWidth = 40;
            this.colMN1.MinWidth = 40;
            this.colMN1.Name = "colMN1";
            this.colMN1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colMN1.Visible = true;
            this.colMN1.VisibleIndex = 2;
            this.colMN1.Width = 40;
            // 
            // colW1
            // 
            this.colW1.Caption = "W1";
            this.colW1.ColumnEdit = this.cePeriod;
            this.colW1.FieldName = "W1";
            this.colW1.MaxWidth = 40;
            this.colW1.MinWidth = 40;
            this.colW1.Name = "colW1";
            this.colW1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colW1.Visible = true;
            this.colW1.VisibleIndex = 3;
            this.colW1.Width = 40;
            // 
            // colD1
            // 
            this.colD1.Caption = "D1";
            this.colD1.ColumnEdit = this.cePeriod;
            this.colD1.FieldName = "D1";
            this.colD1.MaxWidth = 40;
            this.colD1.MinWidth = 40;
            this.colD1.Name = "colD1";
            this.colD1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colD1.Visible = true;
            this.colD1.VisibleIndex = 4;
            this.colD1.Width = 40;
            // 
            // colH4
            // 
            this.colH4.Caption = "H4";
            this.colH4.ColumnEdit = this.cePeriod;
            this.colH4.FieldName = "H4";
            this.colH4.MaxWidth = 40;
            this.colH4.MinWidth = 40;
            this.colH4.Name = "colH4";
            this.colH4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colH4.Visible = true;
            this.colH4.VisibleIndex = 5;
            this.colH4.Width = 40;
            // 
            // colH1
            // 
            this.colH1.Caption = "H1";
            this.colH1.ColumnEdit = this.cePeriod;
            this.colH1.FieldName = "H1";
            this.colH1.MaxWidth = 40;
            this.colH1.MinWidth = 40;
            this.colH1.Name = "colH1";
            this.colH1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colH1.Visible = true;
            this.colH1.VisibleIndex = 6;
            this.colH1.Width = 40;
            // 
            // colM30
            // 
            this.colM30.Caption = "M30";
            this.colM30.ColumnEdit = this.cePeriod;
            this.colM30.FieldName = "M30";
            this.colM30.MaxWidth = 40;
            this.colM30.MinWidth = 40;
            this.colM30.Name = "colM30";
            this.colM30.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colM30.Visible = true;
            this.colM30.VisibleIndex = 7;
            this.colM30.Width = 40;
            // 
            // colM15
            // 
            this.colM15.Caption = "M15";
            this.colM15.ColumnEdit = this.cePeriod;
            this.colM15.FieldName = "M15";
            this.colM15.MaxWidth = 40;
            this.colM15.MinWidth = 40;
            this.colM15.Name = "colM15";
            this.colM15.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colM15.Visible = true;
            this.colM15.VisibleIndex = 8;
            this.colM15.Width = 40;
            // 
            // colM5
            // 
            this.colM5.Caption = "M5";
            this.colM5.ColumnEdit = this.cePeriod;
            this.colM5.FieldName = "M5";
            this.colM5.MaxWidth = 40;
            this.colM5.MinWidth = 40;
            this.colM5.Name = "colM5";
            this.colM5.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colM5.Visible = true;
            this.colM5.VisibleIndex = 9;
            this.colM5.Width = 40;
            // 
            // colM1
            // 
            this.colM1.Caption = "M1";
            this.colM1.ColumnEdit = this.cePeriod;
            this.colM1.FieldName = "M1";
            this.colM1.MaxWidth = 40;
            this.colM1.MinWidth = 40;
            this.colM1.Name = "colM1";
            this.colM1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colM1.Visible = true;
            this.colM1.VisibleIndex = 10;
            this.colM1.Width = 40;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Описание";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 11;
            // 
            // SecuritiesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 745);
            this.Controls.Add(this.gridSecurities);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SecuritiesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Инструменты";
            this.Load += new System.EventHandler(this.SecuritiesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSecurities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSecurities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private DevExpress.XtraGrid.GridControl gridSecurities;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSecurities;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit cePeriod;
        private DevExpress.XtraGrid.Columns.GridColumn colMarket;
        private DevExpress.XtraGrid.Columns.GridColumn colSymbolName;
        private DevExpress.XtraGrid.Columns.GridColumn colMN1;
        private DevExpress.XtraGrid.Columns.GridColumn colW1;
        private DevExpress.XtraGrid.Columns.GridColumn colD1;
        private DevExpress.XtraGrid.Columns.GridColumn colH4;
        private DevExpress.XtraGrid.Columns.GridColumn colH1;
        private DevExpress.XtraGrid.Columns.GridColumn colM30;
        private DevExpress.XtraGrid.Columns.GridColumn colM15;
        private DevExpress.XtraGrid.Columns.GridColumn colM5;
        private DevExpress.XtraGrid.Columns.GridColumn colM1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}