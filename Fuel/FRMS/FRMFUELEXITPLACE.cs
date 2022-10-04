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
    public partial class FRMFUELEXITPLACE : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt1;
        CurrencyManager cm;
        DataTable dtPrice;
        double PastQuntity;
        public FRMFUELEXITPLACE(string FrmName)
        {
            InitializeComponent();
            lblSystemName.Text = FrmName;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(cbxPlace);
            key.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(cmbExitStoreName);
            key.ShowDialog();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void gunaButton12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtExitQuantity_Enter(object sender, EventArgs e)
        {
            try
            {
                if (numberClick1.Enabled == false)
                    numberClick1.Enabled = true;
                numberClick1.text(txtExitQuantity);

            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }
        }

        private void FRMFUELEXITPLACE_Load(object sender, EventArgs e)
        {
            try
            {
                CLS_FRMS.CLS_FuelExitPlace fuel = new CLS_FRMS.CLS_FuelExitPlace();
                CLS_FRMS.CLS_FuelExit fuelexit = new CLS_FRMS.CLS_FuelExit();
                CLS_FRMS.CLS_Store store = new CLS_FRMS.CLS_Store();
                fuelexit.StoreInfo(cmbExitStoreName);
                dtPrice = fuelexit.GetDataPrice(int.Parse(cmbExitStoreName.SelectedValue.ToString()));
                
                fuelexit.BeneficiaryInfo(cmbExitTheBeneficiary);
                
                dt1 = null;
                dt1 = fuel.showFuelExitPlaceData(DgvExitFuel, txtExitID, txtBillExitNo, dteExitBill, cmbExitTheBeneficiary, cbxPlace,
                     DeptInvest, cmbExitStoreName, cbxFuelType, cmbPlaceFull, txtLitterPrice, txtTranPrice, txtPercentage, txtprice, txtExitQuantity, txttotalprice, txtFreeQuantity, cbxMonth, txtnotes);
                   
                store.ShowStores(StoresExitLayout, Name);
                
                cm = (CurrencyManager)this.BindingContext[dt1];

                CLS_FRMS.CLS_Users user = new CLS_FRMS.CLS_Users();
                user.FrmBtnPre(lblSystemName.Text, btnExitNew, btnExitAdd, btnExitEdit, btnExitDelete, btnPrintExitBill);
            }
            catch (Exception ex) { }
        }

        private void btnExitNew_Click(object sender, EventArgs e)
        {
            try
            {

                CLS_FRMS.CLS_FuelExitPlace AddDataFuel = new CLS_FRMS.CLS_FuelExitPlace();

                DataTable dt = AddDataFuel.SelectFuelLastBillNot();
                if (dt.Rows.Count > 0)
                {
                    txtBillExitNo.Text = (int.Parse(dt.Rows[0][0].ToString()) + 1).ToString();
                }
                else
                    txtBillExitNo.Text = "1";

                AddDataFuel.AddNewBill(int.Parse(txtBillExitNo.Text));
                dt1 = null;
                dt1 = AddDataFuel.showFuelExitPlaceData(DgvExitFuel, txtExitID, txtBillExitNo, dteExitBill, cmbExitTheBeneficiary, cbxPlace,
                     DeptInvest, cmbExitStoreName, cbxFuelType, cmbPlaceFull, txtLitterPrice, txtTranPrice, txtPercentage, txtprice, txtExitQuantity, txttotalprice, txtFreeQuantity, cbxMonth,txtnotes);

                cm = (CurrencyManager)this.BindingContext[dt1];

                cm.Position = dt1.Rows.Count;
                txtExitQuantity.Enabled = true;
                txtFreeQuantity.Enabled = true;
                cmbExitStoreName.Enabled = true;
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
                CLS_FRMS.CLS_FuelExitPlace AddDataFuel = new CLS_FRMS.CLS_FuelExitPlace();
                AddDataFuel.UpdateFuelExitPlace(int.Parse(cmbExitStoreName.SelectedValue.ToString()), int.Parse(txtExitID.Text), txtBillExitNo.Text,
                    dteExitBill.Value, cmbExitTheBeneficiary.Text, cbxPlace.Text, DeptInvest.Checked, cmbExitStoreName.Text, cbxFuelType.Text, cmbPlaceFull.Text,
                    double.Parse(txtLitterPrice.Text), double.Parse(txtTranPrice.Text), double.Parse(txtPercentage.Text),
                    double.Parse(txtprice.Text), double.Parse(txtExitQuantity.Text), double.Parse(txttotalprice.Text), Quantity, double.Parse(txtFreeQuantity.Text), cbxMonth.Text, txtnotes.Text);

                dt1 = null;
                dt1 = AddDataFuel.showFuelExitPlaceData(DgvExitFuel, txtExitID, txtBillExitNo, dteExitBill, cmbExitTheBeneficiary, cbxPlace,
                     DeptInvest, cmbExitStoreName, cbxFuelType, cmbPlaceFull, txtLitterPrice, txtTranPrice, txtPercentage, txtprice, txtExitQuantity, txttotalprice, txtFreeQuantity, cbxMonth, txtnotes);

                cm = (CurrencyManager)this.BindingContext[dt1];
                CLS_FRMS.CLS_Store store = new CLS_FRMS.CLS_Store();
                store.ShowStores(StoresExitLayout, Name);
                txtExitQuantity.Enabled = false;
                txtFreeQuantity.Enabled = false;
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
                DialogResult result = MessageBox.Show("هل تريد تأكيد التعديل؟", "تأكيد", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    double Quantity = Convert.ToDouble(txtExitQuantity.Text) - Convert.ToDouble(DgvExitFuel.SelectedRows[0].Cells[12].Value);
                    Quantity *= -1;
                    CLS_FRMS.CLS_FuelExitPlace UpdateDataFuel = new CLS_FRMS.CLS_FuelExitPlace();
                    UpdateDataFuel.UpdateFuelExitPlace(int.Parse(cmbExitStoreName.SelectedValue.ToString()), int.Parse(txtExitID.Text), txtBillExitNo.Text,
                        dteExitBill.Value, cmbExitTheBeneficiary.Text, cbxPlace.Text, DeptInvest.Checked, cmbExitStoreName.Text, cbxFuelType.Text, cmbPlaceFull.Text,
                        double.Parse(txtLitterPrice.Text), double.Parse(txtTranPrice.Text), double.Parse(txtPercentage.Text),
                        double.Parse(txtprice.Text), double.Parse(txtExitQuantity.Text), double.Parse(txttotalprice.Text), Quantity, double.Parse(txtFreeQuantity.Text), cbxMonth.Text, txtnotes.Text);

                    dt1 = null;
                    dt1 = UpdateDataFuel.showFuelExitPlaceData(DgvExitFuel, txtExitID, txtBillExitNo, dteExitBill, cmbExitTheBeneficiary, cbxPlace,
                         DeptInvest, cmbExitStoreName, cbxFuelType, cmbPlaceFull, txtLitterPrice, txtTranPrice, txtPercentage, txtprice, txtExitQuantity, txttotalprice, txtFreeQuantity, cbxMonth,txtnotes);

                    cm = (CurrencyManager)this.BindingContext[dt1];
                    CLS_FRMS.CLS_Store store = new CLS_FRMS.CLS_Store();
                    store.ShowStores(StoresExitLayout, Name);

                    cmbExitStoreName.Enabled = false;
                }
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
                    CLS_FRMS.CLS_FuelExitPlace DeleteDataFuel = new CLS_FRMS.CLS_FuelExitPlace();
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
                    dt1 = DeleteDataFuel.showFuelExitPlaceData(DgvExitFuel, txtExitID, txtBillExitNo, dteExitBill, cmbExitTheBeneficiary, cbxPlace,
                         DeptInvest, cmbExitStoreName, cbxFuelType, cmbPlaceFull, txtLitterPrice, txtTranPrice, txtPercentage, txtprice, txtExitQuantity, txttotalprice, txtFreeQuantity, cbxMonth, txtnotes);

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

        private void txtExitSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (DgvExitFuel.DataSource as DataTable).DefaultView.RowFilter = string.Format("[BillNo] like '%{0}%' or [Place] like '%{1}%' or [notes] like '%{2}%'", txtExitSearch.Text, txtExitSearch.Text, txtnotes.Text);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void DgvExitFuel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbExitStoreName.SelectedIndex = cmbExitStoreName.FindStringExact(DgvExitFuel.SelectedRows[0].Cells[6].Value.ToString());
        }

        private void cmbExitTheBeneficiary_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbxPlace.DataSource = null;
                CLS_FRMS.CLS_Department place = new CLS_FRMS.CLS_Department();
                DataTable dt = place.GetDataPlacesByDept(cmbExitTheBeneficiary.Text);
                cbxPlace.DataSource = dt;
                cbxPlace.DisplayMember = "Place";
                cbxPlace.ValueMember = "PlaceInvest";
            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }
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

        private void cmbExitStoreName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CLS_FRMS.CLS_FuelExit price = new CLS_FRMS.CLS_FuelExit();
                dtPrice = price.GetDataPrice(int.Parse(cmbExitStoreName.SelectedValue.ToString()));
                txtLitterPrice.Text = dtPrice.Rows[0][2].ToString();
                LitterPrice();
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

        private void DgvExitFuel_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                PastQuntity = Convert.ToDouble(DgvExitFuel.SelectedRows[0].Cells[12].Value);
                if (cmbExitStoreName.Enabled == true)
                    cmbExitStoreName.Enabled = false;
            }
            catch { }
        }

        private void cmbPlaceFull_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbPlaceFull.SelectedItem.ToString() == "داخل الكراج")
                {
                    txtTranPrice.Text = dtPrice.Rows[0][4].ToString();

                }
                else if (cmbPlaceFull.SelectedItem.ToString() == "خارج الكراج")
                {
                    txtTranPrice.Text = dtPrice.Rows[0][5].ToString();

                }
                LitterPrice();
            }
            catch { }
        }

        private void btnPrintExitBill_Click(object sender, EventArgs e)
        {
            CLS_FRMS.CLS_FuelExitPlace rp = new CLS_FRMS.CLS_FuelExitPlace();
            DataTable Dt = new DataTable();
            DS.DSFuel dss = new DS.DSFuel();
            REPORTS.ReportViewer frm = new REPORTS.ReportViewer();

            Dt = rp.SelectFuelExitPlaceBill(int.Parse(txtExitID.Text));
            dss.Tables["FuelExitPlaceBill"].Clear();

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                dss.Tables["FuelExitPlaceBill"].Rows.Add(Dt.Rows[i][0], DateTime.Parse(Dt.Rows[i][1].ToString()).ToString("dd/MM/yyyy"), Dt.Rows[i][2], Dt.Rows[i][3], Dt.Rows[i][4], Dt.Rows[i][5],
                    Dt.Rows[i][6], Dt.Rows[i][7], Dt.Rows[i][8], Dt.Rows[i][9], 
                   Dt.Rows[i][10], Dt.Rows[i][11],  DateTime.Parse(Dt.Rows[i][12].ToString()).ToString("dd/MM/yyyy"));
            }
            REPORTS.FuelExitPlaceBill rpt = new REPORTS.FuelExitPlaceBill();


            rpt.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();

            rpt.DataSource = dss;
            rpt.RequestParameters = false;
            frm.documentViewer1.DocumentSource = rpt;
            frm.ShowDialog();
        }

        private void cbxPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxPlace.Text != "" && cbxPlace.Text != null) {
                if (cbxPlace.SelectedValue.ToString() == "True")
                {
                    DeptInvest.Checked = true;
                    txtPercentage.Text = dtPrice.Rows[0][3].ToString();
                }
                else
                {
                    DeptInvest.Checked = false;
                    txtPercentage.Text = "0";
                }
                LitterPrice();
            }
            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }
        }

        private void txtPercentage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFreeQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtFreeQuantity.Text != null && txtFreeQuantity.Text != "")
            {
                double quan = double.Parse(txtExitQuantity.Text) - double.Parse(txtFreeQuantity.Text);
                if (quan < 0)
                    quan = 0;
                txttotalprice.Text = (quan * double.Parse(txtprice.Text)).ToString();
            }
        }

        private void txtFreeQuantity_Enter(object sender, EventArgs e)
        {
           
        }

        private void txttotalprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExitQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFreeQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dteExitBill_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}