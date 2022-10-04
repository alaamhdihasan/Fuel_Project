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
    public partial class FRMFUELEXIT : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt1;
        CurrencyManager cm;
        DataTable dt;
        double PastQuntity;
        string SystemPer;
        public FRMFUELEXIT(string FrmName)
        {
            InitializeComponent();

            SystemPer= FrmName;
        }

        private void cmbExitCarNO_Click(object sender, EventArgs e)
        {
            try
            {
                if (numberClick1.Enabled == false)
                    numberClick1.Enabled = true;
                numberClick1.cmb(cmbExitCarNO);

            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }
        }

        private void txtExitQuantity_Click(object sender, EventArgs e)
        {
            try
            {
                if (numberClick1.Enabled == false)
                    numberClick1.Enabled = true;
                numberClick1.text(txtExitQuantity);

            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }
        }

        private void gunaButton12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(cmbExitCarType);
            key.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(txtDriveName);
            key.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(cmbExitTheBeneficiary);
            key.ShowDialog();
        }

        private void FRMFUELEXIT_Load(object sender, EventArgs e)
        {
            try
            {
                CLS_FRMS.CLS_FuelExit fuel = new CLS_FRMS.CLS_FuelExit();
                CLS_FRMS.CLS_Store store = new CLS_FRMS.CLS_Store();
                fuel.caarInfo(cmbExitCarNO, cmbExitCarType);
                fuel.BeneficiaryInfo(cmbExitTheBeneficiary);
                fuel.StoreInfo(cmbExitStoreName);
                dt1 = null;
                dt1 = fuel.showFuelExitData(DgvExitFuel, txtExitID, txtBillExitNo, dteExitBill, cmbExitCarNO, cmbExitCarType, txtExitQuantity,
                    txtDriveName, cmbExitTheBeneficiary, DeptInvest, cmbExitStoreName, txtExitRegisterName, txtExitRegisterTime, txtExitRegisterDate, txtprice, txttotalprice,
                    txtLitterPrice,txtTranPrice,txtPercentage, cbxMonth,txtnotes);

                store.ShowStores(StoresExitLayout, Name);
                dt = fuel.GetDataPrice(int.Parse(cmbExitStoreName.SelectedValue.ToString()));
                cm = (CurrencyManager)this.BindingContext[dt1];

                CLS_FRMS.CLS_Users user = new CLS_FRMS.CLS_Users();
                user.FrmBtnPre(SystemPer,btnExitNew,btnExitAdd,btnExitEdit,btnExitDelete,btnPrintExitBill);
            }
            catch (Exception ex) { }
        }

        private void btnExitNew_Click(object sender, EventArgs e)
        {

            try
            {
                txtExitID.DataBindings.Clear();
                txtBillExitNo.DataBindings.Clear();
                dteExitBill.DataBindings.Clear();
                cmbExitCarNO.DataBindings.Clear();
                cmbExitCarType.DataBindings.Clear();
                txtExitQuantity.DataBindings.Clear();
                txtDriveName.DataBindings.Clear();
                cmbExitTheBeneficiary.DataBindings.Clear();
                txtExitRegisterName.DataBindings.Clear();
                txtExitRegisterTime.DataBindings.Clear();
                txtExitRegisterDate.DataBindings.Clear();

                txtExitID.Text = null;
                txtBillExitNo.Text = null;
                txtExitQuantity.Text = null;
                cmbExitCarNO.Text = "";
                cmbExitCarType.Text = "";
                cmbExitTheBeneficiary.Text = "";
                txtDriveName.Text = null;
                txtExitQuantity.Enabled = true;
                dteExitBill.Value = DateTime.Now;
                txtExitRegisterName.Text = Properties.Settings.Default.UserName.ToString();

                CLS_FRMS.CLS_FuelExit AddDataFuel = new CLS_FRMS.CLS_FuelExit();

                DataTable dt = AddDataFuel.SelectFuelLastBillNot();
                if (dt.Rows.Count > 0)
                {
                    txtBillExitNo.Text = (int.Parse(dt.Rows[0][0].ToString()) + 1).ToString();
                }
                else
                    txtBillExitNo.Text = "1";
                AddDataFuel.AddNewBill(int.Parse(txtBillExitNo.Text), dteExitBill.Value);
                dt1 = null;
                dt1 = AddDataFuel.showFuelExitData(DgvExitFuel, txtExitID, txtBillExitNo, dteExitBill, cmbExitCarNO, cmbExitCarType, txtExitQuantity,
                      txtDriveName, cmbExitTheBeneficiary, DeptInvest, cmbExitStoreName, txtExitRegisterName, txtExitRegisterTime, txtExitRegisterDate, txtprice, txttotalprice,
                        txtLitterPrice, txtTranPrice, txtPercentage, cbxMonth, txtnotes);
                cm = (CurrencyManager)this.BindingContext[dt1];

                cm.Position = dt1.Rows.Count;

                cmbExitStoreName.Enabled = true;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void btnExitDelete_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult result = MessageBox.Show("هل تريد تأكيد الحذف؟", "تأكيد", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    CLS_FRMS.CLS_FuelExit DeleteDataFuel = new CLS_FRMS.CLS_FuelExit();
                    if (cmbExitStoreName.Text != null && cmbExitStoreName.Text != "")
                    {                
                        DeleteDataFuel.DeleteFuelExit(int.Parse(txtExitID.Text), int.Parse(cmbExitStoreName.SelectedValue.ToString()), Convert.ToDouble(txtExitQuantity.Text));
                    }
                    else
                    {
                        cmbExitStoreName.SelectedIndex = 0;
                        DeleteDataFuel.DeleteFuelExit(int.Parse(txtExitID.Text), int.Parse(cmbExitStoreName.SelectedValue.ToString()), 0);
                    }
                    dt1 = null;
                    dt1 = DeleteDataFuel.showFuelExitData(DgvExitFuel, txtExitID, txtBillExitNo, dteExitBill, cmbExitCarNO, cmbExitCarType, txtExitQuantity,
                           txtDriveName, cmbExitTheBeneficiary, DeptInvest, cmbExitStoreName, txtExitRegisterName, txtExitRegisterTime, txtExitRegisterDate, txtprice, txttotalprice,
                             txtLitterPrice, txtTranPrice, txtPercentage,cbxMonth, txtnotes);
                    cm = (CurrencyManager)this.BindingContext[dt1];
                    CLS_FRMS.CLS_Store store = new CLS_FRMS.CLS_Store();
                    store.ShowStores(StoresExitLayout, Name);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void btnExitAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double Quantity = Convert.ToDouble(txtExitQuantity.Text);
                Quantity *= -1;
                CLS_FRMS.CLS_FuelExit AddDataFuel = new CLS_FRMS.CLS_FuelExit();
                AddDataFuel.UpdateFuelExit( int.Parse(cmbExitStoreName.SelectedValue.ToString()), int.Parse(txtExitID.Text),
                    txtBillExitNo.Text,
                    dteExitBill.Value, cmbExitCarNO.Text, cmbExitCarType.Text, double.Parse(txtExitQuantity.Text),
                    txtDriveName.Text, cmbExitTheBeneficiary.Text, cmbExitStoreName.Text, cmbPlace.Text, Quantity,
                     double.Parse(txtprice.Text), double.Parse(txttotalprice.Text), DeptInvest.Checked, double.Parse(txtLitterPrice.Text),
                    double.Parse(txtTranPrice.Text), double.Parse(txtPercentage.Text),cbxMonth.Text, txtnotes.Text);

                dt1 = null;
                dt1 = AddDataFuel.showFuelExitData(DgvExitFuel, txtExitID, txtBillExitNo, dteExitBill, cmbExitCarNO, cmbExitCarType, txtExitQuantity,
                      txtDriveName, cmbExitTheBeneficiary, DeptInvest, cmbExitStoreName, txtExitRegisterName, txtExitRegisterTime, txtExitRegisterDate, txtprice, txttotalprice,
                        txtLitterPrice, txtTranPrice, txtPercentage,cbxMonth, txtnotes);
                cm = (CurrencyManager)this.BindingContext[dt1];
                CLS_FRMS.CLS_Store store = new CLS_FRMS.CLS_Store();
                store.ShowStores(StoresExitLayout, Name);
                txtExitQuantity.Enabled = false;
                cmbExitStoreName.Enabled = false;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void btnExitEdit_Click(object sender, EventArgs e)
        {
            try
            {
                double Quantity = Convert.ToDouble(txtExitQuantity.Text) - PastQuntity;
                Quantity *= -1;
                CLS_FRMS.CLS_FuelExit UpdateDataFuel = new CLS_FRMS.CLS_FuelExit();
                UpdateDataFuel.UpdateFuelExit(int.Parse(cmbExitStoreName.SelectedValue.ToString()), int.Parse(txtExitID.Text),
                    txtBillExitNo.Text, dteExitBill.Value, cmbExitCarNO.Text, cmbExitCarType.Text, double.Parse(txtExitQuantity.Text),
                    txtDriveName.Text, cmbExitTheBeneficiary.Text, cmbExitStoreName.Text, cmbPlace.Text,  Quantity, double.Parse(txtprice.Text),
                    double.Parse(txttotalprice.Text), DeptInvest.Checked,double.Parse(txtLitterPrice.Text),
                    double.Parse(txtTranPrice.Text), double.Parse(txtPercentage.Text),cbxMonth.Text, txtnotes.Text);
                dt1 = null;
                dt1 = UpdateDataFuel.showFuelExitData(DgvExitFuel, txtExitID, txtBillExitNo, dteExitBill, cmbExitCarNO, cmbExitCarType, txtExitQuantity,
                   txtDriveName, cmbExitTheBeneficiary, DeptInvest, cmbExitStoreName, txtExitRegisterName, txtExitRegisterTime, txtExitRegisterDate, txtprice, txttotalprice,
                     txtLitterPrice, txtTranPrice, txtPercentage,cbxMonth, txtnotes);
                cm = (CurrencyManager)this.BindingContext[dt1];
                CLS_FRMS.CLS_Store store = new CLS_FRMS.CLS_Store();
                store.ShowStores(StoresExitLayout, Name);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void txtExitSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (DgvExitFuel.DataSource as DataTable).DefaultView.RowFilter = string.Format("[BillNo] like '%{0}%' or [notes] like '%{1}%'", txtExitSearch.Text, txtnotes.Text);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void DgvExitFuel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbExitStoreName.SelectedIndex = cmbExitStoreName.FindStringExact(DgvExitFuel.SelectedRows[0].Cells[8].Value.ToString());
        }

        private void cmbExitCarNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbExitCarType.SelectedText = cmbExitCarNO.SelectedValue.ToString();

        }

        private void cmbExitTheBeneficiary_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (cmbExitTheBeneficiary.SelectedValue.ToString() == "True")
                {
                    DeptInvest.Checked = true; 
                    txtPercentage.Text = dt.Rows[0][3].ToString();                                     
                }
                else
                {
                    DeptInvest.Checked = false;
                    txtPercentage.Text = "0";
                }
                LitterPrice();
            }
            catch (Exception ee) { }

        }

        private void DeptInvest_MouseHover(object sender, EventArgs e)
        {
            ToolTip tb = new ToolTip();
            tb.Show("جهة استثمارية", DeptInvest);
        }
        
        private void txtExitQuantity_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (txtExitQuantity.Text != null && txtExitQuantity.Text != "")
                {
                    txttotalprice.Text = (double.Parse(txtExitQuantity.Text) * double.Parse(txtprice.Text)).ToString();
                }

            }
            catch (Exception ee) { }

        }

        private void cmbExitStoreName_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cmbExitStoreName_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                CLS_FRMS.CLS_FuelExit price = new CLS_FRMS.CLS_FuelExit();
                if (cmbExitStoreName.Text != null && cmbExitStoreName.Text != "")
                {
                    dt = price.GetDataPrice(int.Parse(cmbExitStoreName.SelectedValue.ToString()));
                    txtLitterPrice.Text = dt.Rows[0][2].ToString();
                    LitterPrice();
                }
            }
            catch (Exception ee) { }

        }

        private void LitterPrice()
        {
            try
            {
                txtprice.Text = null;
                double Litter;

                
                Litter = (double.Parse(txtLitterPrice.Text) + double.Parse(txtTranPrice.Text));
                if (DeptInvest.Checked == true)
                {
                    Litter += (double.Parse(txtLitterPrice.Text) + double.Parse(txtTranPrice.Text)) * (double.Parse(txtPercentage.Text) / 100);

                }
                txtprice.Text = Litter.ToString();
            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            cm.Position = dt1.Rows.Count;

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            cm.Position += 1;

        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            cm.Position -= 1;

        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            cm.Position = 0;

        }

        private void numberClick1_Load(object sender, EventArgs e)
        {

        }

        private void DgvExitFuel_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                PastQuntity = Convert.ToDouble(DgvExitFuel.SelectedRows[0].Cells[5].Value);
                if (cmbExitStoreName.Enabled == true)
                    cmbExitStoreName.Enabled = false;
            }
            catch { }
        }

        private void btnPrintExitBill_Click(object sender, EventArgs e)
        {

            CLS_FRMS.CLS_FuelExit rp = new CLS_FRMS.CLS_FuelExit();
            DataTable Dt = new DataTable();
            DS.DSFuel dss = new DS.DSFuel();
            REPORTS.ReportViewer frm = new REPORTS.ReportViewer();
           
            Dt = rp.SelectFuelExitBill(int.Parse(txtExitID.Text));
            dss.Tables["FuelExitBill"].Clear();

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                dss.Tables["FuelExitBill"].Rows.Add(Dt.Rows[i][0], Dt.Rows[i][2], Dt.Rows[i][3], Dt.Rows[i][4], Dt.Rows[i][5],Dt.Rows[i][6],
                    Dt.Rows[i][7], Dt.Rows[i][8], Dt.Rows[i][9], DateTime.Parse(Dt.Rows[i][10].ToString()).ToString("dd/MM/yyyy"), Dt.Rows[i][11], DateTime.Parse(Dt.Rows[i][1].ToString()).ToString("dd/MM/yyyy"),
                   Dt.Rows[i][12], Dt.Rows[i][13], Dt.Rows[i][14] );
            }
            REPORTS.FuelExitBill rpt = new REPORTS.FuelExitBill();

        
           rpt.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
         
           rpt.DataSource = dss;
           rpt.RequestParameters = false;
           frm.documentViewer1.DocumentSource = rpt;
            frm.ShowDialog();  
        }

        private void cmbPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
          
                if (cmbPlace.SelectedItem.ToString() == "داخل الكراج")
                {
                    txtTranPrice.Text = dt.Rows[0][4].ToString();
                  
                }
                else if (cmbPlace.SelectedItem.ToString() == "خارج الكراج")
                {
                    txtTranPrice.Text = dt.Rows[0][5].ToString();
                 
                }
                LitterPrice();
           
        }

        private void DeptInvest_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void cmbExitCarType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}