using Datafeed;
using DevExpress.Charts.Native;
using DevExpress.Data.Filtering;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
using ScreenerApp.Configuration;
using ScreenerLib;
using ScreenerLib.Interfaces;
using ScreenerLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenerApp
{
    public partial class MainForm : Form
    {
        private List<Account> _Accounts;
        private List<Security> _Securities;

        private Account CurrentAccount;
        private IDatafeedProvider Provider { get; set; }

        // series
        private Series seriesBar = new Series("SeriesBar", ViewType.Stock);
        //private Series seriesWPR5 = new Series("SeriesWPR5", ViewType.Line);
        //private Series seriesWPR21 = new Series("SeriesWPR21", ViewType.Line);

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

        private async Task LoadSecuritiesAsync()
        {
            var symbols = await Provider.GetAvailableSymbolsAsync();

            var securities = Securities.Load(CurrentAccount.Name);

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

            ConfigureChart();
        }

        private void ConfigureChart()
        {
            // Bind the series to data.
            chartGeneral.Series.Clear();
            seriesBar.SetFinancialDataMembers("Time", "Low", "High", "Open", "Close");
            seriesBar.ArgumentScaleType = ScaleType.DateTime;
            seriesBar.LegendTextPattern = "{A}";
            chartGeneral.Series.Add(seriesBar);

            // Customize the series view settings.
            StockSeriesView view = (StockSeriesView)seriesBar.View;

            view.LineThickness = 2;
            view.LevelLineLength = 0.25;

            // LastPoint config
            view.LastPoint.LabelDisplayMode = SidePointDisplayMode.DiagramEdge;
            view.LastPoint.Label.BackColor = Color.White;
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

            // Pane
            diagram.Panes.Clear();
            var pane2 = new XYDiagramPane("IndicatorsPane");
            
            diagram.Panes.Add(pane2);

            diagram.SecondaryAxesY.Clear();
            var secondaryAxisY = new SecondaryAxisY("IndicatorsYAxis");
            secondaryAxisY.WholeRange.SetMinMaxValues(-100, 0);
            secondaryAxisY.VisualRange.SetMinMaxValues(-100, 0);
            secondaryAxisY.ConstantLines.Add(new ConstantLine("overBuy", -20));
            secondaryAxisY.ConstantLines.Add(new ConstantLine("overSell", -80));
            diagram.SecondaryAxesY.Add(secondaryAxisY);

            // Indicators
            view.Indicators.Clear();
            var indicatorWPR5 = new WilliamsR("WP%R5");
            indicatorWPR5.PointsCount = 5;
            indicatorWPR5.Pane = diagram.Panes["IndicatorsPane"];
            indicatorWPR5.AxisY = diagram.SecondaryAxesY["IndicatorsYAxis"];
            //indicatorWPR5.ShowInLegend = true;
            view.Indicators.Add(indicatorWPR5);

            var indicatorWPR21 = new WilliamsR("WP%R21");
            indicatorWPR5.PointsCount = 21;
            indicatorWPR21.Pane = diagram.Panes["IndicatorsPane"];
            indicatorWPR21.AxisY = diagram.SecondaryAxesY["IndicatorsYAxis"];
            //indicatorWPR21.ShowInLegend = true;
            view.Indicators.Add(indicatorWPR21);

            // Pane Layout
            diagram.PaneLayout.AutoLayoutMode = PaneAutoLayoutMode.Grid;
            diagram.PaneLayout.RowDefinitions.Clear();
            diagram.PaneLayout.RowDefinitions.Add(new LayoutDefinition { SizeMode = PaneSizeMode.UseWeight, Weight = 2 });
            diagram.PaneLayout.RowDefinitions.Add(new LayoutDefinition { SizeMode = PaneSizeMode.UseWeight, Weight = 1 });

            // legend
            chartGeneral.Legend.Visibility = DefaultBoolean.False;
            //chartGeneral.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Right;
            //chartGeneral.Legend.AlignmentVertical = LegendAlignmentVertical.Top;

            // Add a title to the chart.
            chartGeneral.Titles.Clear();
            chartGeneral.Titles.Add(new ChartTitle());
            chartGeneral.Titles[0].Text = "";

            // Crosshair Options
            //chartGeneral.CrosshairOptions.ContentShowMode = CrosshairContentShowMode.Legend;
            chartGeneral.CrosshairOptions.CrosshairLabelMode = CrosshairLabelMode.ShowCommonForAllSeries;
            chartGeneral.CrosshairOptions.ShowOnlyInFocusedPane = false;
            chartGeneral.CrosshairOptions.ShowArgumentLabels = true;
        }

        private async void btnConnect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnConnect.Enabled = false;

            ProgressForm.Description = "Connecting...";
            SplashScreenManager.ShowForm(this, typeof(ProgressForm), true, true, false, ParentFormState.Locked);

            try
            {
                var account = _Accounts.SingleOrDefault(w => w.Name == beAccount.EditValue.ToString());
                if (account == null)
                {
                    MessageBox.Show(this, "Выберите аккаунт для подключения", "Подключение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnConnect.Enabled = true;
                    return;
                }

                var provider = DatafeedProviderFactory.CreateProvider(account.Provider);
                CurrentAccount = account;
                Provider = provider;

                if (await Provider.ConnectAsync(account.Json))
                {
                    btnConnect.ItemAppearance.Normal.BackColor = Color.LightGreen;
                    btnSecurities.Enabled = true;
                    btnLoadData.Enabled = true;

                    await LoadSecuritiesAsync();
                }
                else
                {
                    btnConnect.ItemAppearance.Normal.BackColor = Color.OrangeRed;
                    btnSecurities.Enabled = false;
                    btnLoadData.Enabled = false;
                }
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
            
            btnConnect.Enabled = true;
        }

        private async void btnSecurities_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dialog = new SecuritiesList();
            dialog.Securities = _Securities;

            dialog.ShowDialog(this);

            await LoadSecuritiesAsync();
        }

        private async void btnLoadData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProgressForm.Description = "Retrieving history data...";
            SplashScreenManager.ShowForm(this, typeof(ProgressForm), true, true, false, ParentFormState.Locked);

            try
            {
                BindingList<ScreenerItem> items = new BindingList<ScreenerItem>();
                gridScreener.DataSource = items;

                var calculator = new Calculator();

                var history = await Provider.GetHistoricalDataAsync(_Securities.Where(w => w.Periods.Length > 0).ToList(), 40);

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
            finally
            {
                SplashScreenManager.CloseForm(false);
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

        private void gvScreener_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            int rowHandle = gvScreener.GetSelectedRows().Length == 1 ? gvScreener.GetSelectedRows()[0] : -1;
            if (rowHandle < 0)
                return;

            ConfigureChart();

            // Bind the series to data.
            var screenerItem = GetScreenerItem(rowHandle);
            seriesBar.DataSource = screenerItem.Bars;

            // set title
            chartGeneral.Titles[0].Text = $"{screenerItem.SymbolName} - {screenerItem.Period}";

            //chartGeneral.RefreshData();
        }

        private void ccePeriods_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if(e.AcceptValue)
            {
                //gvScreener.ActiveFilterCriteria = GroupOperator.
                gvScreener.ActiveFilterString = $"[Period] in ({string.Join(",", ccePeriods.Items.Where(w => w.CheckState == CheckState.Checked).Select(s=> $"'{s}'").ToList())})";
            }
        }
    }
}
