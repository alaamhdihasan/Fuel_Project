using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Fuel.FRMS
{
    public partial class FRMControl : DevExpress.XtraEditors.XtraForm
    {
        public FRMControl()
        {
            InitializeComponent();
        }

        private void FRMControl_Load(object sender, EventArgs e)
        {
            try
            {
                CLS_FRMS.CLS_FuelExit dept = new CLS_FRMS.CLS_FuelExit();
                dept.controlDesign("اسبوعي", chartCar,chartPlace);
                dept.controlDesign("شهري", chartCarMonthly,chartPlaceMonthly);
                dept.controlDesign("سنوي", chartCarYear,chartPlaceYear);
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void gunaButton12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void chartCarYear_Click(object sender, EventArgs e)
        {

        }
    }
}