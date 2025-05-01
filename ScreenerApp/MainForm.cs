using Datafeed;
using DevExpress.Charts.Native;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using ScreenerApp.Configuration;
using ScreenerLib;
using ScreenerLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ScreenerApp
{
    public partial class MainForm : Form
    {
        private List<Account> _Accounts;
        private List<Security> _Securities;

        private Account CurentAccount;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadAccounts()
        {
            _Accounts = Accounts.Load();
            cbAccounts.Items.AddRange(_Accounts);
            beAccount.EditValue = _Accounts[0];
            cbAccounts.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        private void LoadSecurities()
        {
            var symbols = MT4_API.LoadSymbols();

            var securities = Securities.Load(CurentAccount.Name);

            _Securities = symbols.Select(s => {
                var security = securities.SingleOrDefault(w => w.SymbolName == s.Name);
                if (security == null)
                    return new Security() { Market = s.Market, SymbolName = s.Name };
                else
                    return new Security() { Market = security.Market, SymbolName = security.SymbolName, Periods = security.Periods };
            }).ToList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadAccounts();
        }

        private void btnConnect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnConnect.Enabled = false;

            var account = _Accounts.SingleOrDefault(w => w.Name == beAccount.EditValue.ToString());
            if(account == null)
            {
                MessageBox.Show(this, "Выберите аккаунт для подключения", "Подключение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnConnect.Enabled = true;
                return;
            }

            CurentAccount = account;

            if (MT4_API.Connect(account.User, account.Password, account.Host, account.Port))
            {
                btnConnect.ItemAppearance.Normal.BackColor = Color.LightGreen;
                btnSecurities.Enabled = true;
                btnLoadData.Enabled = true;

                LoadSecurities();
            }
            else
            {
                btnConnect.ItemAppearance.Normal.BackColor = Color.OrangeRed;
                btnSecurities.Enabled = false;
                btnLoadData.Enabled = false;
            }
            
            btnConnect.Enabled = true;
        }

        private void btnSecurities_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dialog = new SecuritiesList();
            dialog.Securities = _Securities;

            dialog.ShowDialog(this);

            LoadSecurities();
        }

        private void btnLoadData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            BindingList<ScreenerItem> items = new BindingList<ScreenerItem>();
            gridScreener.DataSource = items;

            var calculator = new Calculator();

            var history = MT4_API.GetQuoteHistory(_Securities.Where(w=> w.Periods.Length > 0).ToList());

            foreach (var h in history)
            {
                var item = new ScreenerItem();
                item.SymbolName = h.SymbolName;
                item.Market = _Securities.SingleOrDefault(w => w.SymbolName == h.SymbolName).Market;
                item.Period = h.Period;
                item.Bars = h.Bars;

                item.Days5Ago = calculator.Calc_DaysAgo5(h.Bars);

                items.Add(item);
            }
        }

        private void gvScreener_CustomColumnSort(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs e)
        {
            if (e.Column.FieldName == "Period")
            {
                e.Handled = true;

                e.Result = Comparer<int>.Default.Compare(
                    Period.PeriodToMinutes(e.Value1.ToString()), 
                    Period.PeriodToMinutes(e.Value2.ToString())
                );
            }
        }

        private ScreenerItem GetScreenerItem(int rowHandle)
        {
            var symbol = gvScreener.GetRowCellValue(rowHandle, "SymbolName").ToString();
            var period = gvScreener.GetRowCellValue(rowHandle, "Period").ToString();

            var bindingList = (BindingList<ScreenerItem>)gridScreener.DataSource;
            return bindingList.SingleOrDefault(w=> w.SymbolName == symbol && w.Period == period);
        }

        private void gvScreener_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void gvScreener_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            int rowHandle = gvScreener.GetSelectedRows().Length == 1 ? gvScreener.GetSelectedRows()[0] : -1;
            if (rowHandle == -1)
                return;

            // Create a stock series.
            Series series1 = new Series("SeriesBar", ViewType.Stock);

            // Bind the series to data.
            var screenerItem = GetScreenerItem(rowHandle);
            series1.DataSource = screenerItem.Bars;
            series1.SetFinancialDataMembers("Time", "Low", "High", "Open", "Close");

            // Specify that date-time arguments are expected.
            series1.ArgumentScaleType = ScaleType.DateTime;
            //Axis.

            // Add the series to the chart.
            chartGeneral.Series.Clear();
            chartGeneral.Series.Add(series1);

            // Customize the series view settings.
            StockSeriesView view = (StockSeriesView)series1.View;

            view.LineThickness = 2;
            view.LevelLineLength = 0.25;

            // LastPoint config
            view.LastPoint.LabelDisplayMode = SidePointDisplayMode.DiagramEdge;
            view.LastPoint.Label.BackColor = Color.Transparent;
            view.LastPoint.Label.TextColor = Color.Red;
            view.LastPoint.Label.Border.Color = Color.Red;

            // Specify the series reduction options.
            view.ReductionOptions.ColorMode = ReductionColorMode.OpenToCloseValue;
            view.ReductionOptions.Level = StockLevel.Close;
            view.ReductionOptions.Visible = true;

            // Set point colors.
            view.Color = Color.Green;
            view.ReductionOptions.Color = Color.Red;

            // Access the chart's diagram.
            XYDiagram diagram = (XYDiagram)chartGeneral.Diagram;
            diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Minute;
            diagram.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Manual;

            // Exclude empty ranges from the X-axis range
            // to avoid gaps in the chart's data.
            diagram.AxisX.DateTimeScaleOptions.SkipRangesWithoutPoints = true;

            // Hide the range without points at the beginning of the y-axis.
            diagram.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            diagram.AxisY.Alignment = AxisAlignment.Far;

            // Hide the legend.
            chartGeneral.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Add a title to the chart.
            //chartGeneral.Titles.Add(new ChartTitle());
            //chartGeneral.Titles[0].Text = "Stock Chart";
        }
    }
}
