using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Reports
{
    public partial class Report24 : UserControl
    {
        public static Report24 _Rep24;
        public static Report24 Rep24
        {
            get
            {
                if (_Rep24 == null)
                {
                    _Rep24 = new Report24();
                }
                return _Rep24;
            }
        }
        public Report24()
        {
            InitializeComponent();
            dt_from.Value = DateTime.Now;
            dt_to.Value = DateTime.Now;

        }

        private void Report24_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (dt_from.Value > dt_to.Value)
            {
                MessageBox.Show("Date from must be before date to");

            }
            else
            {
                this.report_MostSellingItemsTableAdapter.Fill(this._V9_1DataSet.Report_MostSellingItems, dt_from.Value, dt_to.Value);

                this.reportViewer1.RefreshReport();
            }
        }
    }
}
