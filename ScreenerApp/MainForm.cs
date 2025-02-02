using Datafeed;
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
        private string _Token;

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
            var symbols = MT4_API.LoadSymbols(_Token);

            var securities = Securities.Load();

            _Securities = symbols.Select(s => {
                var security = securities.SingleOrDefault(w => w.SymbolName == s.Name);
                if (security == null)
                    return new Security() { Market = s.Market, SymbolName = s.Name };
                else
                    return new Security() { Market = security.Market, SymbolName = security.SymbolName, Active = true, Periods = security.Periods };
            }).ToList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadAccounts();

            /////////////////////////////
            //var securities = new List<Security>();
            //securities.Add(new Security() { Market = "CBOE", SymbolName = "Brent", W1 = true, D1 = true });
            //securities.Add(new Security() { Market = "CME", SymbolName = "EURUSD", M5 = true, M1 = true });
            //Securities.Save(securities);

            //var loaded = Securities.Load();
            ////////////////////////////////
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

            _Token = MT4_API.GetToken(account.User, account.Password, account.Host, account.Port);
            if (!string.IsNullOrEmpty(_Token))
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
        }

        private void btnLoadData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BindingList<ScreenerItem> items = new BindingList<ScreenerItem>();
            gridScreener.DataSource = items;

            items.Add(new ScreenerItem() { Market = "CME", SymbolName = "EURUSD", Period = "W1", DaysAgo5 = 0 });
            items.Add(new ScreenerItem() { Market = "CME", SymbolName = "EURUSD", Period = "D1", DaysAgo5 = 0 });
            items.Add(new ScreenerItem() { Market = "CME", SymbolName = "EURUSD", Period = "H4", DaysAgo5 = 0 });
            items.Add(new ScreenerItem() { Market = "CME", SymbolName = "EURUSD", Period = "H1", DaysAgo5 = 0 });
            items.Add(new ScreenerItem() { Market = "CME", SymbolName = "EURUSD", Period = "M15", DaysAgo5 = 0 });
            items.Add(new ScreenerItem() { Market = "CME", SymbolName = "EURUSD", Period = "M5", DaysAgo5 = 0 });
            items.Add(new ScreenerItem() { Market = "CME", SymbolName = "EURUSD", Period = "M1", DaysAgo5 = 0 });

            items.Add(new ScreenerItem() { Market = "CME", SymbolName = "GBPUSD", Period = "W1", DaysAgo5 = 0 });
            items.Add(new ScreenerItem() { Market = "CME", SymbolName = "GBPUSD", Period = "D1", DaysAgo5 = 0 });
            items.Add(new ScreenerItem() { Market = "CME", SymbolName = "GBPUSD", Period = "H4", DaysAgo5 = 0 });
            items.Add(new ScreenerItem() { Market = "CME", SymbolName = "GBPUSD", Period = "H1", DaysAgo5 = 0 });
            items.Add(new ScreenerItem() { Market = "CME", SymbolName = "GBPUSD", Period = "M15", DaysAgo5 = 0 });
            items.Add(new ScreenerItem() { Market = "CME", SymbolName = "GBPUSD", Period = "M5", DaysAgo5 = 0 });
            items.Add(new ScreenerItem() { Market = "CME", SymbolName = "GBPUSD", Period = "M1", DaysAgo5 = 0 });

            items.Add(new ScreenerItem() { Market = "CBOE", SymbolName = "Brent", Period = "W1", DaysAgo5 = 0 });
            items.Add(new ScreenerItem() { Market = "CBOE", SymbolName = "Brent", Period = "D1", DaysAgo5 = 0 });
            items.Add(new ScreenerItem() { Market = "CBOE", SymbolName = "Brent", Period = "H4", DaysAgo5 = 0 });
            items.Add(new ScreenerItem() { Market = "CBOE", SymbolName = "Brent", Period = "H1", DaysAgo5 = 0 });
            items.Add(new ScreenerItem() { Market = "CBOE", SymbolName = "Brent", Period = "M15", DaysAgo5 = 0 });
            items.Add(new ScreenerItem() { Market = "CBOE", SymbolName = "Brent", Period = "M5", DaysAgo5 = 0 });
            items.Add(new ScreenerItem() { Market = "CBOE", SymbolName = "Brent", Period = "M1", DaysAgo5 = 0 });
        }
    }
}
