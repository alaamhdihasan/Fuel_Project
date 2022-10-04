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
    public partial class FRMCONTANT : DevExpress.XtraEditors.XtraForm
    {
        string FrmName=null;
        CurrencyManager CmCar;
        DataTable DtCar;
        CurrencyManager CmStore;
        DataTable DtStore;
        CurrencyManager CmPlace;
        DataTable DtPlace;

        public FRMCONTANT(string FrmName)
        {
            InitializeComponent();
            this.FrmName = FrmName;
        }

        private void gunaButton12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDeptInvest.Checked == true)           
                cbxDeptInvest.Text = "جهة استثمارية";
            else
                cbxDeptInvest.Text = "جهة غير استثمارية";
        }

        private void FRMCONTANT_Load(object sender, EventArgs e)
        {
            CLS_FRMS.CLS_Users user = new CLS_FRMS.CLS_Users();
            lblSystemName.Text = FrmName;
            if (FrmName == "المخازن")
            {
                tblStore.Visible = true;
                tblDepartment.Visible = false;
                tblCar.Visible = false;
                tblPlaces.Visible = false;
                try
                {
                    CLS_FRMS.CLS_Store store = new CLS_FRMS.CLS_Store();
                    DtStore = store.StoreDesign(DgvStore, txtStoreid, txtStoreName, txtStoreLocation, cbxFuelType, txtStoreMaxQuantity,txtStoreQuantity,txtStoreNotice);
                    CmStore = (CurrencyManager)this.BindingContext[DtStore];

                    user.FrmBtnPre(FrmName,btnStoreNew, btnStoreAdd, btnStoreEdit, btnStoreDelete);
                    if (btnStoreAdd.Enabled == true && btnStoreEdit.Enabled == true)
                        btnStorePrice.Enabled = true;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                if (FrmName == "اقسام العتبة")
                {
                    tblStore.Visible = false;
                    tblDepartment.Visible = true;
                    tblCar.Visible = false;
                    tblPlaces.Visible = false;
                    try
                    {
                        CLS_FRMS.CLS_Department dept = new CLS_FRMS.CLS_Department();
                        dept.DeptDesign(DgvDepartment, txtDeptId, txtDeptName, cbxDeptInvest);

                        user.FrmBtnPre(FrmName,btnDeptNew, btnDeptAdd, btnDeptEdit, btnDeptDelete);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                else
                {
                    if (FrmName == "عجلات القسم")
                    {
                        tblStore.Visible = false;
                        tblDepartment.Visible = false;
                        tblCar.Visible = true;
                        tblPlaces.Visible = false;

                        CLS_FRMS.CLS_Department place = new CLS_FRMS.CLS_Department();
                        DataTable dt = place.GetDataDepartment();
                        cbxTheBeneficiary.DataSource = dt;
                        cbxTheBeneficiary.DisplayMember = "DepartmentName";

                        DataTable dt1 = place.GetDataPlaces();
                        cbxCarDivision.DataSource = dt1;
                        cbxCarDivision.DisplayMember = "Place";
                        try
                        {
                            CLS_FRMS.CLS_Car car = new CLS_FRMS.CLS_Car();
                            DtCar= car.CarDesign(DgvCar, txtCarId, txtCarNo, txtCartype,cbxCarFuel,cbxTheBeneficiary,cbxCarDivision);
                            CmCar = (CurrencyManager)this.BindingContext[DtCar];

                            user.FrmBtnPre(FrmName,btnCarNew, btnCarAdd, btnCarEdit, btnCarDelete);
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }else
                    {
                        if(FrmName=="مواقع العتبة")
                        {
                            tblStore.Visible = false;
                            tblDepartment.Visible = false;
                            tblCar.Visible = false;
                            tblPlaces.Visible = true;
                            try
                            {
                                CLS_FRMS.CLS_Department place = new CLS_FRMS.CLS_Department();
                                DataTable dt = place.GetDataDepartment();
                                cbxPlaceDept.DataSource = dt;
                                cbxPlaceDept.DisplayMember = "DepartmentName";
                                cbxPlaceDept.ValueMember = "id";
                                DtPlace = place.DesignPlaces(DgvPlace, txtPlaceId, cbxPlaceDept, txtPlace, txtPlaceRegisterName, txtPlaceAddingTime,txtPlaceAddingDate, chxPlaceInvest);
                                CmPlace = (CurrencyManager)this.BindingContext[DtPlace];

                                user.FrmBtnPre(FrmName, btnPlaceNew, btnPlaceAdd, btnPlaceEdit, btnPlaceDelete);
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message); }
                        }
                    }
                }
            }
           


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(txtStoreName);
            key.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(txtStoreLocation);
            key.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(txtStoreMaxQuantity);
            key.ShowDialog();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(txtStoreQuantity);
            key.ShowDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(txtStoreNotice);
            key.ShowDialog();
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(txtCarNo);
            key.ShowDialog();
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(txtCartype);
            key.ShowDialog();
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(cbxCarFuel);
            key.ShowDialog();
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(cbxTheBeneficiary);
            key.ShowDialog();
        }

        private void btnExitNew_Click(object sender, EventArgs e)
        {
            txtDeptName.DataBindings.Clear();
            txtDeptName.Text = null;
            cbxDeptInvest.DataBindings.Clear();
            cbxDeptInvest.Checked = false;
        }

        private void btnExitAdd_Click(object sender, EventArgs e)
        {
            try
            {
                CLS_FRMS.CLS_Department dept = new CLS_FRMS.CLS_Department();
                dept.insertintoDepartments(txtDeptName.Text,cbxDeptInvest.Checked);
                dept.DeptDesign(DgvDepartment, txtDeptId, txtDeptName, cbxDeptInvest);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnExitEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("هل تريد التعديل على هذا القسم!", "تأكييد", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) { 
                    CLS_FRMS.CLS_Department dept = new CLS_FRMS.CLS_Department();
                    dept.DepartmentsUpdatedata(int.Parse(txtDeptId.Text), txtDeptName.Text, cbxDeptInvest.Checked);
                    dept.DeptDesign(DgvDepartment, txtDeptId, txtDeptName, cbxDeptInvest);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnExitDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("هل تريد حذف هذا القسم!", "تأكييد", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CLS_FRMS.CLS_Department dept = new CLS_FRMS.CLS_Department();
                    dept.DepartmentsDeleting(int.Parse(txtDeptId.Text));
                    dept.DeptDesign(DgvDepartment, txtDeptId, txtDeptName, cbxDeptInvest);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            try
            {
                CLS_FRMS.CLS_Car car = new CLS_FRMS.CLS_Car();
                car.CarInsertInfo(txtCarNo.Text,txtCartype.Text,cbxCarFuel.Text,cbxTheBeneficiary.Text,cbxCarDivision.Text);
                DtCar=  car.CarDesign(DgvCar, txtCarId, txtCarNo, txtCartype, cbxCarFuel, cbxTheBeneficiary,cbxCarDivision);
                CmCar = (CurrencyManager)this.BindingContext[DtCar];

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {
            txtCarNo.DataBindings.Clear();
            txtCarNo.Text = null;
            txtCartype.DataBindings.Clear();
            txtCartype.Text = null;
            cbxCarFuel.DataBindings.Clear();
            cbxTheBeneficiary.DataBindings.Clear();
            cbxTheBeneficiary.DataSource = null;
            cbxCarDivision.DataSource = null;
            CLS_FRMS.CLS_Department place = new CLS_FRMS.CLS_Department();
            DataTable dt = place.GetDataDepartment();
            cbxTheBeneficiary.DataSource = dt;
            cbxTheBeneficiary.DisplayMember = "DepartmentName";

            DataTable dt1 = place.GetDataPlaces();
            cbxCarDivision.DataSource = dt1;
            cbxCarDivision.DisplayMember = "Place";
        }

        private void simpleButton20_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("هل تريد التعديل على هذه العجلة!", "تأكييد", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CLS_FRMS.CLS_Car car = new CLS_FRMS.CLS_Car();
                    car.CarUpdateInfo(int.Parse(txtCarId.Text), txtCarNo.Text, txtCartype.Text, cbxCarFuel.Text, cbxTheBeneficiary.Text,cbxCarDivision.Text);
                    DtCar= car.CarDesign(DgvCar, txtCarId, txtCarNo, txtCartype, cbxCarFuel, cbxTheBeneficiary,cbxCarDivision);
                    CmCar = (CurrencyManager)this.BindingContext[DtCar];

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void simpleButton19_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("هل تريد حذف هذه العجلة!", "تأكييد", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CLS_FRMS.CLS_Car car = new CLS_FRMS.CLS_Car();
                    car.CarDeleting(int.Parse(txtCarId.Text));
                    DtCar= car.CarDesign(DgvCar, txtCarId, txtCarNo, txtCartype, cbxCarFuel, cbxTheBeneficiary,cbxCarDivision);
                    CmCar = (CurrencyManager)this.BindingContext[DtCar];

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void simpleButton23_Click(object sender, EventArgs e)
        {
            CmCar.Position = DtCar.Rows.Count;

        }

        private void simpleButton24_Click(object sender, EventArgs e)
        {
            CmCar.Position += 1; 

        }

        private void simpleButton26_Click(object sender, EventArgs e)
        {
            CmCar.Position -= 1;
        }

        private void simpleButton25_Click(object sender, EventArgs e)
        {
            CmCar.Position = 0;
        }

        private void txtSearchCar_TextChanged(object sender, EventArgs e)
        {
            (DgvCar.DataSource as DataTable).DefaultView.RowFilter = string.Format("[CarNo] LIKE '%{0}%' OR [CarType] like'%{1}%' OR [CarFuel] like'%{2}%' OR [TheBenficary] like'%{3}%' ", txtSearchCar.Text, txtSearchCar.Text, txtSearchCar.Text, txtSearchCar.Text);
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(cbxFuelType);
            key.ShowDialog();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {

            try
            {
                CLS_FRMS.CLS_Store store = new CLS_FRMS.CLS_Store();
                store.StoreInsertInfo(txtStoreName.Text, txtStoreLocation.Text, cbxFuelType.Text,double.Parse(txtStoreMaxQuantity.Text),double.Parse(txtStoreQuantity.Text),txtStoreNotice.Text);

                DtStore = store.StoreDesign(DgvStore, txtStoreid, txtStoreName, txtStoreLocation, cbxFuelType, txtStoreMaxQuantity, txtStoreQuantity, txtStoreNotice);
                store.addFuelPOrice(int.Parse(txtStoreid.Text), 0, 0, 0,0);
                CmStore = (CurrencyManager)this.BindingContext[DtStore];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            txtStoreName.DataBindings.Clear();
            txtStoreName.Text = null;
            txtStoreLocation.DataBindings.Clear();
            txtStoreLocation.Text = null;
            cbxFuelType.DataBindings.Clear();
            txtStoreMaxQuantity.DataBindings.Clear();
            txtStoreMaxQuantity.Text = null;
            txtStoreQuantity.DataBindings.Clear();
            txtStoreQuantity.Text = null;
            txtStoreNotice.DataBindings.Clear();
            txtStoreNotice.Text = null;
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("هل تريد التعديل على هذا المخزن!", "تأكييد", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CLS_FRMS.CLS_Store store = new CLS_FRMS.CLS_Store();
                    store.StoreUpdateInfo(int.Parse(txtStoreid.Text), txtStoreName.Text, txtStoreLocation.Text, cbxFuelType.Text, double.Parse(txtStoreMaxQuantity.Text), double.Parse(txtStoreQuantity.Text), txtStoreNotice.Text);
                    DtStore = store.StoreDesign(DgvStore, txtStoreid, txtStoreName, txtStoreLocation, cbxFuelType, txtStoreMaxQuantity, txtStoreQuantity, txtStoreNotice);
                    CmStore = (CurrencyManager)this.BindingContext[DtStore];
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("هل تريد حذف هذا المخزن!", "تأكييد", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CLS_FRMS.CLS_Store store = new CLS_FRMS.CLS_Store();
                    store.StoreDeleting(int.Parse(txtStoreid.Text));
                    store.deleteDataFuelPrice(int.Parse(txtStoreid.Text));
                    DtStore = store.StoreDesign(DgvStore, txtStoreid, txtStoreName, txtStoreLocation, cbxFuelType, txtStoreMaxQuantity, txtStoreQuantity, txtStoreNotice);
                    CmStore = (CurrencyManager)this.BindingContext[DtStore];
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            CmStore.Position = DtStore.Rows.Count;
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            CmStore.Position += 1; 
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            CmStore.Position -= 1;
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            CmStore.Position = 0;
        }

        private void txtStoreSearch_TextChanged(object sender, EventArgs e)
        {
            (DgvStore.DataSource as DataTable).DefaultView.RowFilter = string.Format("[StoreName] LIKE '%{0}%' OR [StoreLocation] like'%{1}%' OR [FuelType] like'%{2}%' OR [MaxQuantity] like'%{3}%' OR [Quantity] like'%{4}%'", txtStoreSearch.Text, txtStoreSearch.Text, txtStoreSearch.Text, txtStoreSearch.Text, txtStoreSearch.Text);
        }

        private void btnStorePrice_Click(object sender, EventArgs e)
        {
            FRMS.FUELPRICE f = new FRMS.FUELPRICE(int.Parse(txtStoreid.Text));
            f.ShowDialog();
        }

        private void tableLayoutPanel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPlaceNew_Click(object sender, EventArgs e)
        {
            txtPlaceId.DataBindings.Clear();
            cbxPlaceDept.DataBindings.Clear();
            txtPlace.DataBindings.Clear();
            txtPlaceRegisterName.DataBindings.Clear();
            txtPlaceAddingTime.DataBindings.Clear();
            txtPlaceAddingDate.DataBindings.Clear();
            chxPlaceInvest.DataBindings.Clear();

            txtPlaceId.Text = null;
            cbxPlaceDept.Text = null;
            txtPlace.Text = null;
            txtPlaceRegisterName.Text = null;
            txtPlaceAddingTime.Text = null;
            txtPlaceAddingDate.Text = null;
            chxPlaceInvest.Checked = false;
        }

        private void btnPlaceAdd_Click(object sender, EventArgs e)
        {
            try
            {
                CLS_FRMS.CLS_Department place = new CLS_FRMS.CLS_Department();
                place.insertintoPlaces(int.Parse(cbxPlaceDept.SelectedValue.ToString()), cbxPlaceDept.Text, txtPlace.Text, chxPlaceInvest.Checked);
                DtPlace = place.DesignPlaces(DgvPlace, txtPlaceId, cbxPlaceDept, txtPlace, txtPlaceRegisterName, txtPlaceAddingTime, txtPlaceAddingDate, chxPlaceInvest);
                CmPlace = (CurrencyManager)this.BindingContext[DtPlace];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnPlaceEdit_Click(object sender, EventArgs e)
        {
            try
            {
                CLS_FRMS.CLS_Department place = new CLS_FRMS.CLS_Department();
                place.UpdatedataPlaces(int.Parse(txtPlaceId.Text), int.Parse(cbxPlaceDept.SelectedValue.ToString()), cbxPlaceDept.Text, txtPlace.Text, chxPlaceInvest.Checked);
                DtPlace = place.DesignPlaces(DgvPlace, txtPlaceId, cbxPlaceDept, txtPlace, txtPlaceRegisterName, txtPlaceAddingTime, txtPlaceAddingDate, chxPlaceInvest);
                CmPlace = (CurrencyManager)this.BindingContext[DtPlace];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnPlaceDelete_Click(object sender, EventArgs e)
        {
            try
            {
                CLS_FRMS.CLS_Department place = new CLS_FRMS.CLS_Department();
                place.DeletingPlaces(int.Parse(txtPlaceId.Text));

                DtPlace = place.DesignPlaces(DgvPlace, txtPlaceId, cbxPlaceDept, txtPlace, txtPlaceRegisterName, txtPlaceAddingTime, txtPlaceAddingDate, chxPlaceInvest);
                CmPlace = (CurrencyManager)this.BindingContext[DtPlace];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void simpleButton19_Click_1(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(cbxPlaceDept);
            key.ShowDialog();
        }

        private void simpleButton20_Click_1(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(txtPlace);
            key.ShowDialog();
        }

        private void txtPlaceSearch_TextChanged(object sender, EventArgs e)
        {
            (DgvPlace.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Department] LIKE '%{0}%' OR [Place] like'%{1}%'", txtPlaceSearch.Text, txtPlaceSearch.Text);

        }

        private void btnPlaceFirst_Click(object sender, EventArgs e)
        {
            CmPlace.Position = 0;
        }

        private void btnPlaceBack_Click(object sender, EventArgs e)
        {
            CmPlace.Position -= 1;
        }

        private void btnPlaceNext_Click(object sender, EventArgs e)
        {
            CmPlace.Position += 1;
        }

        private void btnPlaceLast_Click(object sender, EventArgs e)
        {
            CmPlace.Position = DtPlace.Rows.Count;
        }

        private void simpleButton6_Click_1(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(cbxCarDivision);
            key.ShowDialog();
        }
    }
}