using ScreenerLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenerApp
{
    public partial class SecuritiesList : Form
    {
        public List<Security> Securities { get; set; }

        public SecuritiesList()
        {
            InitializeComponent();
        }

        private void SecuritiesList_Load(object sender, EventArgs e)
        {
            BindingList<Security> items = new BindingList<Security>(Securities);
            gridSecurities.DataSource = items;

            gvSecurities.Columns[nameof(Security.Market)].Group();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var securities = Securities.Where(w => w.Periods.Length > 0).ToList();
            Configuration.Securities.Save(securities);

            MessageBox.Show(this, "Сохранение инструментов выполнено успешно", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
