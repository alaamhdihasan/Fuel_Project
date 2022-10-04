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
    public partial class FUELPRICE : DevExpress.XtraEditors.XtraForm
    {
        int id;
        public FUELPRICE(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FUELPRICE_Load(object sender, EventArgs e)
        {
            try
            {
                CLS_FRMS.CLS_Store price = new CLS_FRMS.CLS_Store();
                DataTable dt = price.GetDataFuelPrice(id);
                txtPrice.Text = dt.Rows[0][2].ToString();
                txtPercentageAdd.Text = dt.Rows[0][3].ToString();
                txtpricetransInside.Text = dt.Rows[0][4].ToString();
                txtpricetransOutside.Text = dt.Rows[0][5].ToString();
            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintExitBill_Click(object sender, EventArgs e)
        {

            try
            {
                CLS_FRMS.CLS_Store price = new CLS_FRMS.CLS_Store();
                price.updateFuelPOrice(id, double.Parse(txtPrice.Text), double.Parse(txtPercentageAdd.Text), double.Parse(txtpricetransInside.Text), double.Parse(txtpricetransOutside.Text));
                this.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }
    }
}