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
using TwainLib;
using System.IO;
using System.Diagnostics;

namespace Fuel.FRMS
{
    public partial class FRMFUELENTRY : DevExpress.XtraEditors.XtraForm
    {
        public string newpath;
        public string pathimage;
        public string nameimage;
        string SystemPer;
        DataTable dt1;
        CurrencyManager cm;

        public FRMFUELENTRY(string FrmName)
        {
            InitializeComponent();
            SystemPer = FrmName;
        }

        private void gunaButton12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            try
            {
                if (numberClick1.Enabled == false)
                    numberClick1.Enabled = true;
                numberClick1.text(txtQuantity);

            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }
        }

        private void cmbcarno_Enter(object sender, EventArgs e)
        {
            try
            {
                if (numberClick1.Enabled == false)
                    numberClick1.Enabled = true;
                numberClick1.cmb(cmbcarno);
            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }
        }

        private void txtBillNo_Enter(object sender, EventArgs e)
        {
            try
            {
                if (numberClick1.Enabled == false)
                    numberClick1.Enabled = true;
                numberClick1.text(txtBillNo);

            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }
        }

        private void DateBill_Enter(object sender, EventArgs e)
        {
            numberClick1.Enabled = false;
        }

        private void cmbCarType_Enter(object sender, EventArgs e)
        {
            numberClick1.Enabled = false;
        }

        private void مرفقاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
            var b = TwainOperations.ScanImages();
            foreach (var Itm in b)
            {
                pathimage = Itm;
                nameimage = System.IO.Path.GetFileName(pathimage);
                newpath = Properties.Settings.Default.BillPath + nameimage;
                picsave.Load(Itm);
                picsave.Image.Save(newpath);
                txtImagePath.Text = newpath;
                lsv.Items.Add(txtImagePath.Text);

                txtArchiveAddingTime.Text = DateTime.Now.ToString("HH:MM tt");
                txtArchiveAddingDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
                txtArchiveRegisterName.Text = Properties.Settings.Default.UserName.ToString();

                CLS_FRMS.CLS_FuelEntry archadding = new CLS_FRMS.CLS_FuelEntry();
                archadding.addArchiveFuel(int.Parse(txtID.Text), int.Parse(txtBillNo.Text), txtImagePath.Text);

            }
            CLS_FRMS.CLS_FuelEntry Getarchive = new CLS_FRMS.CLS_FuelEntry();
            DataTable Dt = Getarchive.selectFuelArchive(int.Parse(txtID.Text), txtArchiveID, txtImagePath, txtArchiveRegisterName, txtArchiveAddingTime, txtArchiveAddingDate, lsv);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void numberClick1_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(cmbCarType);
            key.ShowDialog();
        }

        private void FRMFUELENTRY_Load(object sender, EventArgs e)
        {
            try { 
            CLS_FRMS.CLS_FuelEntry fuel = new CLS_FRMS.CLS_FuelEntry();
            fuel.StoreInfo(cmbStoreName);
            fuel.caarInfo(cmbcarno, cmbCarType);
            dt1 = null;
            dt1 = fuel.showFuelEntrayData(DgvFuelEntry, txtID, txtBillNo, DateBill, cmbFuelType, cmbStoreName, txtQuantity,
               cmbcarno, cmbCarType, txtDriver, TimeGetFuel, DateGetFuel, txtQuantityNormal,txtNotes, cbxMonth);
            CLS_FRMS.CLS_Store store = new CLS_FRMS.CLS_Store();
            store.ShowStores(StoresLayout, Name);

            TimeGetFuel.Time = Convert.ToDateTime(DgvFuelEntry.SelectedRows[0].Cells[12].Value.ToString());
            cm = (CurrencyManager)this.BindingContext[dt1];
            if (txtID.Text != null && txtID.Text != "")
            {
                
                DataTable Dt = fuel.selectFuelArchive(int.Parse(txtID.Text), txtArchiveID, txtImagePath, txtArchiveRegisterName, txtArchiveAddingTime, txtArchiveAddingDate, lsv);
            }

                CLS_FRMS.CLS_Users user = new CLS_FRMS.CLS_Users();
                user.FrmBtnPre(SystemPer,btnNew, btnAdd, btnEdit, btnDelete);
                user.FrmBtnPre(SystemPer, مرفقاتToolStripMenuItem, فرديToolStripMenuItem, حذفToolStripMenuItem, طباعةToolStripMenuItem);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            try
            {
                (DgvFuelEntry.DataSource as DataTable).DefaultView.RowFilter = string.Format("[BillNo] like '%{0}%'", txtSearch.Text);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                txtID.DataBindings.Clear();
                txtBillNo.DataBindings.Clear();
                cmbFuelType.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                cmbcarno.DataBindings.Clear();
                cmbCarType.DataBindings.Clear();
                txtDriver.DataBindings.Clear();
                TimeGetFuel.DataBindings.Clear();
                DateGetFuel.DataBindings.Clear();
                cmbStoreName.DataBindings.Clear();
                DateBill.DataBindings.Clear();
                txtQuantityNormal.DataBindings.Clear();

                txtID.Text = null;
                txtBillNo.Text = null;
                txtQuantity.Text = null;
                cmbCarType.Text = "";
                cmbcarno.Text = "";
                txtDriver.Text = null;
                cmbStoreName.Enabled = true;
                txtQuantityNormal.Text = null;
                txtQuantity.Enabled = true;

                DateBill.Value = DateTime.Now;
                DateGetFuel.Value = DateTime.Now;
                TimeGetFuel.Text = DateTime.Now.ToString("hh:mm tt");


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                CLS_FRMS.CLS_FuelEntry AddDataFuel = new CLS_FRMS.CLS_FuelEntry();
                AddDataFuel.InsertFuelEntry(int.Parse(cmbStoreName.SelectedValue.ToString()), txtBillNo.Text, DateBill.Value,
                    cmbFuelType.SelectedItem.ToString(), cmbStoreName.Text, double.Parse(txtQuantity.Text), cmbcarno.Text,
                    cmbCarType.Text, txtDriver.Text, TimeGetFuel.Text, DateGetFuel.Value,double.Parse(txtQuantityNormal.Text), txtNotes.Text, cbxMonth.Text);
                dt1 = null;
                dt1 = AddDataFuel.showFuelEntrayData(DgvFuelEntry, txtID, txtBillNo, DateBill, cmbFuelType, cmbStoreName, txtQuantity,
                      cmbcarno, cmbCarType, txtDriver, TimeGetFuel, DateGetFuel, txtQuantityNormal, txtNotes, cbxMonth);
                cm = (CurrencyManager)this.BindingContext[dt1];
                CLS_FRMS.CLS_Store store = new CLS_FRMS.CLS_Store();
                store.ShowStores(StoresLayout, Name);
                cmbStoreName.Enabled = false;
                txtQuantity.Enabled = false;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                cmbStoreName.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("هل تريد تأكيد التعديل؟", "تأكيد", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    
                    double Quantity = Convert.ToDouble(txtQuantity.Text) - Convert.ToDouble(DgvFuelEntry.SelectedRows[0].Cells[5].Value);
                    CLS_FRMS.CLS_FuelEntry UpdateDataFuel = new CLS_FRMS.CLS_FuelEntry();
                    UpdateDataFuel.UpdateFuelEntray(int.Parse(cmbStoreName.SelectedValue.ToString()), int.Parse(txtID.Text), txtBillNo.Text, DateBill.Value, cmbFuelType.SelectedItem.ToString(), cmbStoreName.Text,
                      double.Parse(txtQuantity.Text), cmbcarno.Text, cmbCarType.Text, Quantity,txtDriver.Text,TimeGetFuel.Text,DateGetFuel.Value, double.Parse(txtQuantityNormal.Text), txtNotes.Text, cbxMonth.Text);
                    dt1 = null;
                    dt1 = UpdateDataFuel.showFuelEntrayData(DgvFuelEntry, txtID, txtBillNo, DateBill, cmbFuelType, cmbStoreName, txtQuantity,
                      cmbcarno, cmbCarType, txtDriver, TimeGetFuel, DateGetFuel, txtQuantityNormal, txtNotes, cbxMonth);
                    cm = (CurrencyManager)this.BindingContext[dt1];
                    CLS_FRMS.CLS_Store store = new CLS_FRMS.CLS_Store();
                    store.ShowStores(StoresLayout, Name);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("هل تريد تأكيد الحذف؟", "تأكيد", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    CLS_FRMS.CLS_FuelEntry DeleteDataFuel = new CLS_FRMS.CLS_FuelEntry();
                    DeleteDataFuel.DeleteFuelEntry(int.Parse(txtID.Text), int.Parse(cmbStoreName.SelectedValue.ToString()), cmbStoreName.Text, double.Parse(txtQuantity.Text));
                    dt1 = null;
                    dt1 = DeleteDataFuel.showFuelEntrayData(DgvFuelEntry, txtID, txtBillNo, DateBill, cmbFuelType, cmbStoreName, txtQuantity,
                          cmbcarno, cmbCarType, txtDriver, TimeGetFuel, DateGetFuel, txtQuantityNormal, txtNotes,cbxMonth);
                    cm = (CurrencyManager)this.BindingContext[dt1];
                    CLS_FRMS.CLS_Store store = new CLS_FRMS.CLS_Store();
                    store.ShowStores(StoresLayout, Name);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void DgvFuelEntry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbStoreName.SelectedIndex = cmbStoreName.FindStringExact(DgvFuelEntry.SelectedRows[0].Cells[4].Value.ToString());
        }

        private void cmbcarno_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCarType.Text = cmbcarno.SelectedValue.ToString();
        }

        private void DgvFuelEntry_SelectionChanged(object sender, EventArgs e)
        {

            if (txtID.Text != null && txtID.Text != "")
            {
                CLS_FRMS.CLS_FuelEntry Getarchive = new CLS_FRMS.CLS_FuelEntry();
                DataTable Dt = Getarchive.selectFuelArchive(int.Parse(txtID.Text), txtArchiveID, txtImagePath, txtArchiveRegisterName, txtArchiveAddingTime, txtArchiveAddingDate, lsv);
                TimeGetFuel.Time = Convert.ToDateTime(DgvFuelEntry.SelectedRows[0].Cells[12].Value.ToString());

            }

        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            cm.Position = dt1.Rows.Count;

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            cm.Position += 1;
            
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            cm.Position = 0;
            
        }

        private void lsv_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lsv.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = lsv.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                String text = lsv.Items[intselectedindex].Text;

                CLS_FRMS.CLS_FuelEntry GetData = new CLS_FRMS.CLS_FuelEntry();
                DataTable Dt = GetData.GetDataByListView(text, txtArchiveID, txtArchiveRegisterName, txtArchiveAddingTime, txtArchiveAddingDate);
            }

        }

        private void lsv_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (lsv.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = lsv.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                String text = lsv.Items[intselectedindex].Text;
                System.Diagnostics.Process.Start(text);
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CLS_FRMS.CLS_FuelEntry archdelete = new CLS_FRMS.CLS_FuelEntry();
                archdelete.deleteArchiveFuel(int.Parse(txtArchiveID.Text));

                CLS_FRMS.CLS_FuelEntry Getarchive = new CLS_FRMS.CLS_FuelEntry();
                DataTable Dt = Getarchive.selectFuelArchive(int.Parse(txtID.Text), txtArchiveID, txtImagePath, txtArchiveRegisterName, txtArchiveAddingTime, txtArchiveAddingDate, lsv);
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void فرديToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "select an images|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filetype = Path.GetExtension(ofd.FileName);
                    if (filetype == ".jpg" || filetype == ".png" || filetype == ".bmp")
                    {
                        pathimage = ofd.FileName;
                        nameimage = Path.GetFileName(pathimage);
                        Random x = new Random();
                        newpath = Properties.Settings.Default.BillPath + x.Next().ToString() + Path.GetExtension(nameimage);

                       
                        picsave.Load(ofd.FileName);
                        picsave.Image.Save(newpath);
                        txtImagePath.Text = newpath;
                        lsv.Items.Add(txtImagePath.Text);
                    }
                    else 
                    {

                        string filename = Path.GetFileName(ofd.FileName);
                        newpath = Properties.Settings.Default.BillPath + filename;
                        File.Copy(ofd.FileName, newpath);

                        Random x = new Random();
                        filename = Properties.Settings.Default.BillPath + x.Next().ToString() + Path.GetExtension(ofd.FileName);

                        File.Move(newpath, filename);

                        txtImagePath.Text = filename;
                        lsv.Items.Add(txtImagePath.Text);                       
                      
                    }


                    CLS_FRMS.CLS_FuelEntry archadding = new CLS_FRMS.CLS_FuelEntry();
                    archadding.addArchiveFuel(int.Parse(txtID.Text), int.Parse(txtBillNo.Text), txtImagePath.Text);

                    CLS_FRMS.CLS_FuelEntry Getarchive = new CLS_FRMS.CLS_FuelEntry();
                    DataTable Dt = Getarchive.selectFuelArchive(int.Parse(txtID.Text), txtArchiveID, txtImagePath, txtArchiveRegisterName, txtArchiveAddingTime, txtArchiveAddingDate, lsv);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void lsv_MouseMove(object sender, MouseEventArgs e)
        {
            if (chk_showbook.Checked == true)
            {

                if (lsv.HitTest(e.X, e.Y).Item != null)
                {
                    try
                    {
                        picload.Image = null;
                        GC.Collect();
                        picload.Image = Image.FromFile(lsv.HitTest(e.X, e.Y).Item.Text);
                        picload.Visible = true;
                        CLS_FRMS.CLS_FuelEntry GetData = new CLS_FRMS.CLS_FuelEntry();
                        DataTable Dt = GetData.GetDataByListView(lsv.HitTest(e.X, e.Y).Item.Text, txtArchiveID, txtArchiveRegisterName, txtArchiveAddingTime, txtArchiveAddingDate);
                    }
                    catch (Exception ex) { }
                }
                else
                {
                    picload.Image = null;
                    GC.Collect();
                    picload.Visible = false;
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            cm.Position -= 1;

        }

        private void طباعةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = txtImagePath.Text;
            p.StartInfo.Verb = "Print";
            p.Start();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_showbook.Checked == false)
                picload.Visible = false;
           

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(txtDriver);
            key.ShowDialog();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDriver_TextChanged(object sender, EventArgs e)
        {

        }
    }
}