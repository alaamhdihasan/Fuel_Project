
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fuel.CLS_FRMS
{
    class CLS_FuelExit
    {

        //===================================================================
        //Select Data of Fuel Selling 
        public DataTable SelectFuelExit()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("FuelSellingSelecting", null);
            dal.close();
            return Dt;
        }

        //Select summry Data of Fuel Selling car department
        public DataTable SummryDeptCar(DateTime date)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param;
            param = new SqlParameter[1];
            param[0] = new SqlParameter("@date", SqlDbType.Date);
            param[0].Value = date;
            dal.open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("SummryDept", param);
            dal.close();
            return Dt;
        }

        //Select summry Data of Fuel Selling Place department
        public DataTable SummryDeptPlace(DateTime date)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param;
            param = new SqlParameter[1];
            param[0] = new SqlParameter("@date", SqlDbType.Date);
            param[0].Value = date;
            dal.open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("SummryDeptPlace", param);
            dal.close();
            return Dt;
        }

        //Select Data of Fuel Selling Bill
        public DataTable SelectFuelExitBill(int id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param;
            param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            dal.open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("FuelSellingBill", param);
            dal.close();
            return Dt;
        }

        //Select last bill number of Fuel Selling 
        public DataTable SelectFuelLastBillNot()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("FuelExitSelectLastBillNo", null);
            dal.close();
            return Dt;
        }

        public void AddNewBill(int BillNo, DateTime BillDate)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param;
            param = new SqlParameter[18];
            param[0] = new SqlParameter("@BillNo", SqlDbType.VarChar, 50);
            param[0].Value = BillNo;
            param[1] = new SqlParameter("@BillDate", SqlDbType.Date);
            param[1].Value = BillDate;
            param[2] = new SqlParameter("@CarNO", SqlDbType.VarChar, 50);
            param[2].Value = "";
            param[3] = new SqlParameter("@CarType", SqlDbType.VarChar, 50);
            param[3].Value = "";
            param[4] = new SqlParameter("@Quantity", SqlDbType.Real);
            param[4].Value = 0;
            param[5] = new SqlParameter("@Drivername", SqlDbType.VarChar, 50);
            param[5].Value = "";
            param[6] = new SqlParameter("@TheBeneficiary", SqlDbType.VarChar, 500);
            param[6].Value = "";
            param[7] = new SqlParameter("@StoreName", SqlDbType.VarChar, 50);
            param[7].Value = "";
            param[8] = new SqlParameter("@FullPlace", SqlDbType.VarChar, 50);
            param[8].Value = "";
            param[9] = new SqlParameter("@ItemPrice", SqlDbType.Real);
            param[9].Value = 0;
            param[10] = new SqlParameter("@totalprice", SqlDbType.Real);
            param[10].Value = 0;
            param[11] = new SqlParameter("@DeptInvest", SqlDbType.Bit);
            param[11].Value = false;
            param[12] = new SqlParameter("@LitterPrice", SqlDbType.Real);
            param[12].Value = 0;
            param[13] = new SqlParameter("@TranPrice", SqlDbType.Real);
            param[13].Value = 0;
            param[14] = new SqlParameter("@percentage", SqlDbType.Real);
            param[14].Value = 0;
            param[15] = new SqlParameter("@RegisterName", SqlDbType.VarChar, 50);
            param[15].Value = Properties.Settings.Default.UserName;
            param[16] = new SqlParameter("@month", SqlDbType.VarChar, 50);
            param[16].Value = "";
            param[17] = new SqlParameter("@notes", SqlDbType.VarChar, 500);
            param[17].Value = "";
            dal.open();
            dal.ExecuteCommand("FuelsellingInsertInto", param);
            dal.close();
        }
        //------------------------------------------------------------
        //insert new bill and selling fuel to store
        public void InsertFuelExit(int StoreID, string BillNo, DateTime BillDate, string CarNO, string CarType, double Quantity, string DriverName, string TheBeneficiary, string StoreName, string FullPlace,
              double price, double totalprice,bool DeptInvest, double LitterPrice, double TranPrice, double percentage, string month, string notes)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param;
            param = new SqlParameter[1];
            param[0] = new SqlParameter("@IDst", SqlDbType.Int);
            param[0].Value = StoreID;
            dal.open();
            DataTable dtQuan = dal.SelectingData("StoreSelectingQuantity", param);
            dal.close();

            if (int.Parse(dtQuan.Rows[0][0].ToString()) - Quantity >= 0)
            {
                param = new SqlParameter[17];
                param[0] = new SqlParameter("@BillNo", SqlDbType.VarChar, 50);
                param[0].Value = BillNo;
                param[1] = new SqlParameter("@BillDate", SqlDbType.Date);
                param[1].Value = BillDate;
                param[2] = new SqlParameter("@CarNO", SqlDbType.VarChar, 50);
                param[2].Value = CarNO;
                param[3] = new SqlParameter("@CarType", SqlDbType.VarChar, 50);
                param[3].Value = CarType;
                param[4] = new SqlParameter("@Quantity", SqlDbType.Real);
                param[4].Value = Quantity;
                param[5] = new SqlParameter("@Drivername", SqlDbType.VarChar, 50);
                param[5].Value = DriverName;
                param[6] = new SqlParameter("@TheBeneficiary", SqlDbType.VarChar, 500);
                param[6].Value = TheBeneficiary;
                param[7] = new SqlParameter("@StoreName", SqlDbType.VarChar, 50);
                param[7].Value = StoreName;
                param[8] = new SqlParameter("@FullPlace", SqlDbType.VarChar, 50);
                param[8].Value = FullPlace;
                param[9] = new SqlParameter("@ItemPrice", SqlDbType.Real);
                param[9].Value = price;
                param[10] = new SqlParameter("@totalprice", SqlDbType.Real);
                param[10].Value = totalprice;
                param[11] = new SqlParameter("@DeptInvest", SqlDbType.Bit);
                param[11].Value = DeptInvest;
                param[12] = new SqlParameter("@LitterPrice", SqlDbType.Real);
                param[12].Value = LitterPrice;
                param[13] = new SqlParameter("@TranPrice", SqlDbType.Real);
                param[13].Value = TranPrice;
                param[14] = new SqlParameter("@percentage", SqlDbType.Real);
                param[14].Value = percentage;
                param[15] = new SqlParameter("@RegisterName", SqlDbType.VarChar, 50);
                param[15].Value =Properties.Settings.Default.UserName;
                param[16] = new SqlParameter("@month", SqlDbType.VarChar, 50);
                param[16].Value = month;
                param[17] = new SqlParameter("@notes", SqlDbType.VarChar, 500);
                param[17].Value = notes;
                dal.open();
                dal.ExecuteCommand("FuelsellingInsertInto", param);
                dal.close();

                param = new SqlParameter[2];
                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = StoreID;              
                param[1] = new SqlParameter("@Quantity", SqlDbType.Real);
                param[1].Value = int.Parse(dtQuan.Rows[0][0].ToString()) - Quantity;              
                dal.open();
                dal.ExecuteCommand("StoreUPdateInfoQuantity", param);
                dal.close();
            }
            else
                MessageBox.Show("الوقود في المخزن لا يكفي");
        }

        //---------------------------------------------------------------
        //Update data of billFuel in database
        public void UpdateFuelExit(int StoreID, int idfuel, string BillNo, DateTime BillDate, string CarNO, string CarType, double Quantity, string DriverName, string TheBeneficiary, string StoreName, string FullPlace,
              double QuantityUpdate, double price, double totalprice, bool DeptInvest, double LitterPrice, double TranPrice, double percentage, string month, string notes)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] paramStore;
            paramStore = new SqlParameter[1];
            paramStore[0] = new SqlParameter("@IDst", SqlDbType.Int);
            paramStore[0].Value = StoreID;
            dal.open();
            DataTable dtQuan = dal.SelectingData("StoreSelectingQuantity", paramStore);
            dal.close();

            if (Convert.ToDouble(dtQuan.Rows[0][0])+QuantityUpdate >=0)
            {

                SqlParameter[] param = new SqlParameter[19];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = idfuel;
                param[1] = new SqlParameter("@BillNo", SqlDbType.VarChar, 50);
                param[1].Value = BillNo;
                param[2] = new SqlParameter("@BillDate", SqlDbType.Date);
                param[2].Value = BillDate;
                param[3] = new SqlParameter("@CarNO", SqlDbType.VarChar, 50);
                param[3].Value = CarNO;
                param[4] = new SqlParameter("@CarType", SqlDbType.VarChar, 50);
                param[4].Value = CarType;
                param[5] = new SqlParameter("@Quantity", SqlDbType.Real);
                param[5].Value = Quantity;
                param[6] = new SqlParameter("@Drivername", SqlDbType.VarChar, 50);
                param[6].Value = DriverName;
                param[7] = new SqlParameter("@TheBeneficiary", SqlDbType.VarChar, 500);
                param[7].Value = TheBeneficiary;
                param[8] = new SqlParameter("@StoreName", SqlDbType.VarChar, 50);
                param[8].Value = StoreName;
                param[9] = new SqlParameter("@FullPlace", SqlDbType.VarChar, 50);
                param[9].Value = FullPlace;
                param[10] = new SqlParameter("@itemprice", SqlDbType.Real);
                param[10].Value = price;
                param[11] = new SqlParameter("@totalprice", SqlDbType.Real);
                param[11].Value = totalprice;
                param[12] = new SqlParameter("@DeptInvest", SqlDbType.Bit);
                param[12].Value = DeptInvest;
                param[13] = new SqlParameter("@LitterPrice", SqlDbType.Real);
                param[13].Value = LitterPrice;
                param[14] = new SqlParameter("@TranPrice", SqlDbType.Real);
                param[14].Value = TranPrice;
                param[15] = new SqlParameter("@percentage", SqlDbType.Real);
                param[15].Value = percentage;
                param[16] = new SqlParameter("@RegisterName", SqlDbType.VarChar, 50);
                param[16].Value = Properties.Settings.Default.UserName;
                param[17] = new SqlParameter("@month", SqlDbType.VarChar, 50);
                param[17].Value = month;
                param[18] = new SqlParameter("@notes", SqlDbType.VarChar, 500);
                param[18].Value = notes;

                dal.open();
                dal.ExecuteCommand("FuelsellingUpdate", param);
                dal.close();

                param = new SqlParameter[2];
                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = StoreID;
              
                param[1] = new SqlParameter("@Quantity", SqlDbType.Real);
                param[1].Value = Convert.ToDouble(dtQuan.Rows[0][0]) + QuantityUpdate;
              
                dal.open();
                dal.ExecuteCommand("StoreUPdateInfoQuantity", param);
                dal.close();
            }
            else
                MessageBox.Show("المخزن لا يكفي");
        }

        //--------------------------------------------------------------------
        //delete bill from data bill and from seliing fuel store
        public void DeleteFuelExit(int IDfuel, int StoreID, double Quantity)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] paramStore;
            paramStore = new SqlParameter[1];
            paramStore[0] = new SqlParameter("@IDst", SqlDbType.Int);
            paramStore[0].Value = StoreID;
            dal.open();
            DataTable dtQuan = dal.SelectingData("StoreSelectingQuantity", paramStore);
            dal.close();

            if (Convert.ToDouble(dtQuan.Rows[0][0]) + Quantity <= Convert.ToDouble(dtQuan.Rows[0][1]))
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = IDfuel;
                dal.open();
                dal.ExecuteCommand("FuelsellingDeleting", param);
                dal.close();

                param = new SqlParameter[2];
                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = StoreID;
                param[1] = new SqlParameter("@Quantity", SqlDbType.Real);
                param[1].Value = Convert.ToDouble(dtQuan.Rows[0][0]) + Quantity;
                dal.open();
                dal.ExecuteCommand("StoreUPdateInfoQuantity", param);
                dal.close();
            }
            else
                MessageBox.Show("المخزن لا يكفي");
        }

        //-------------------------------------------------------------------
        //show data in datagridview exit data
        public DataTable showFuelExitData(DataGridView DgvExitFuel, TextBox txtExitID, TextBox txtBillExitNo, DateTimePicker dteExitBill,
           ComboBox cmbExitCarNo, ComboBox cmbExitCarType, TextBox txtExitQuantity, TextBox txtDriveName, ComboBox cmbExitTheBeneficiary, CheckBox DeptInvest,
          ComboBox cmbExitStoreName, TextBox txtExitRegisterName, TextBox txtExitRegisterTime, TextBox txtExitRegisterDate, TextBox txtPrice, TextBox txtTotalPrice,
          TextBox LitterPrice, TextBox TranPrice, TextBox percentage, ComboBox month, TextBox notes)
        {
            try
            {
                DgvExitFuel.DataSource = null;
                txtExitID.DataBindings.Clear();
                txtBillExitNo.DataBindings.Clear();
                dteExitBill.DataBindings.Clear();
                cmbExitCarNo.DataBindings.Clear();
                cmbExitCarType.DataBindings.Clear();
                txtExitQuantity.DataBindings.Clear();
                txtDriveName.DataBindings.Clear();
                cmbExitTheBeneficiary.DataBindings.Clear();
                DeptInvest.DataBindings.Clear();
                cmbExitStoreName.DataBindings.Clear();
                txtExitRegisterName.DataBindings.Clear();
                txtExitRegisterTime.DataBindings.Clear();
                txtExitRegisterDate.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtTotalPrice.DataBindings.Clear();
                LitterPrice.DataBindings.Clear();
                TranPrice.DataBindings.Clear();
                percentage.DataBindings.Clear();
                month.DataBindings.Clear();
                notes.DataBindings.Clear();

                DataTable Dt = SelectFuelExit();
                DgvExitFuel.DataSource = Dt;
                DgvExitFuel.Columns[0].Visible = false;
                DgvExitFuel.Columns[1].HeaderText = "رقم الفاتورة";
                DgvExitFuel.Columns[2].HeaderText = "تاريخ الفاتورة";
                DgvExitFuel.Columns[3].HeaderText = "رقم السيارة";
                DgvExitFuel.Columns[4].HeaderText = "نوع السيارة";
                DgvExitFuel.Columns[5].HeaderText = "السعة";
                DgvExitFuel.Columns[6].HeaderText = "اسم السائق";
                DgvExitFuel.Columns[7].HeaderText = "الجهة المستفيدة";
                DgvExitFuel.Columns[8].HeaderText = "اسم المخزن";
                DgvExitFuel.Columns[9].HeaderText = "سعر اللتر";
                DgvExitFuel.Columns[10].HeaderText = "المبلغ الكلي";
                DgvExitFuel.Columns[11].Visible = false;
                DgvExitFuel.Columns[12].Visible = false;
                DgvExitFuel.Columns[13].Visible = false;
                DgvExitFuel.Columns[14].Visible = false;
                DgvExitFuel.Columns[15].Visible = false;
                DgvExitFuel.Columns[16].Visible = false;
                DgvExitFuel.Columns[17].Visible = false;
                DgvExitFuel.Columns[18].Visible = false;
                DgvExitFuel.Columns[19].Visible = false;
                DgvExitFuel.Columns[20].Visible = false;

                txtExitID.DataBindings.Add("text", Dt, "id");
                txtBillExitNo.DataBindings.Add("text", Dt, "BillNo");
                dteExitBill.DataBindings.Add("text", Dt, "BillDate");
                cmbExitCarNo.DataBindings.Add("text", Dt, "CarNo");
                cmbExitCarType.DataBindings.Add("text", Dt, "CarType");
                txtExitQuantity.DataBindings.Add("text", Dt, "Quantity");
                txtDriveName.DataBindings.Add("text", Dt, "DriverName");
                cmbExitTheBeneficiary.DataBindings.Add("text", Dt, "TheBeneficiary");
                if (cmbExitTheBeneficiary.Text != null && cmbExitTheBeneficiary.Text != "")
                {
                    cmbExitTheBeneficiary.SelectedIndex = cmbExitTheBeneficiary.FindStringExact(cmbExitTheBeneficiary.Text);
                    if (cmbExitTheBeneficiary.SelectedValue.ToString() == "True")
                        DeptInvest.Checked = true;
                    else
                        DeptInvest.Checked = false;
                }
                cmbExitStoreName.DataBindings.Add("text", Dt, "StoreName");
                cmbExitStoreName.SelectedIndex = cmbExitStoreName.FindStringExact(cmbExitStoreName.Text);
                txtExitRegisterName.DataBindings.Add("text", Dt, "RegisterName");
                txtExitRegisterTime.DataBindings.Add("text", Dt, "AddingTime");
                txtExitRegisterDate.DataBindings.Add("text", Dt, "AddingDate");
                txtPrice.DataBindings.Add("text", Dt, "ItemPrice");
                txtTotalPrice.DataBindings.Add("text", Dt, "TotalPrice");

                LitterPrice.DataBindings.Add("text", Dt, "LitterPrice");
                TranPrice.DataBindings.Add("text", Dt, "TranPrice");
                percentage.DataBindings.Add("text", Dt, "Percentage");
                month.DataBindings.Add("text", Dt, "month");
                notes.DataBindings.Add("text", Dt, "notes");
                txtExitID.Visible = false;
                return Dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                DataTable dt = null;
                return dt;
            }
        }

        //OTHERS
        //----------------------------------------------------------------------
        //add stores info to combobox
        public void StoreInfo(ComboBox cmb)
        {
            CLS_Store store = new CLS_Store();
            DataTable dt = store.GetDataStore();
            cmb.DataSource = dt;
            cmb.DisplayMember = "StoreName";
            cmb.ValueMember = "id";
        }

        //------------------------------------------------------------------------
        //serach car type by car Number   
        public void caarInfo(ComboBox cmb, ComboBox cartype)
        {
            CLS_Car GetCars = new CLS_Car();
            DataTable dtCar = GetCars.GetDataCar();
            cmb.DataSource = dtCar;
            cmb.DisplayMember = "CarNo";
            cmb.ValueMember = "CarType";
            cartype.DataSource = dtCar;
            cartype.DisplayMember = "CarType";
        }

        //------------------------------------------------------------------------
        //get data of departments
        public void BeneficiaryInfo(System.Windows.Forms.ComboBox cmb)
        {
            CLS_FRMS.CLS_Department Getdata = new CLS_FRMS.CLS_Department();
            DataTable dt = Getdata.GetDataDepartment();
            cmb.DataSource = dt;
            cmb.DisplayMember = "DepartmentName";
            cmb.ValueMember = "DepartmentInvest";
        }

        //------------------------------------------------------------------------
        //select data from fuel price
        public DataTable GetDataPrice(int id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int); param[0].Value = id;
            dal.open();
            DataTable Dt = dal.SelectingData("FuelPriceSelecting", param);
            dal.close();
            return Dt;
        }


        //----------------------------------------------------------------------
        //design controler form by data in fuel selling cars and places (monthly & weekly & yeare report)
        public void controlDesign(string type, Chart chCar,Chart chPlace)
        {
            DataTable dt=new DataTable();
            DataTable dt1 = new DataTable();
            if (type == "اسبوعي")
            {
                dt = SummryDeptCar(DateTime.Now.AddDays(-7));
                dt1 = SummryDeptPlace(DateTime.Now.AddDays(-7));
            }
            if (type == "شهري")
            {
                dt = SummryDeptCar(DateTime.Now.AddDays(-30));
                dt1 = SummryDeptPlace(DateTime.Now.AddDays(-30));
            }
            if (type == "سنوي")
            {
                dt = SummryDeptCar(DateTime.Now.AddDays(-360));
                dt1 = SummryDeptPlace(DateTime.Now.AddDays(-360));
            }

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                chCar.Series["FuelCar"].Points.AddXY(dt.Rows[i][0] + " (" + dt.Rows[i][1] + ")",dt.Rows[i][2]);
                chCar.Series["FuelCar"].Points[i].Label = dt.Rows[i][2].ToString();
               
                chCar.Series["FuelCar"].Points[i].ToolTip = dt.Rows[i][0] + " (" + dt.Rows[i][1] + ")";
            }
            chCar.Titles.Add("جرد صرفيات عجلات الاقسام من وقود "+type);

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                
                chPlace.Series["FuelPlace"].Points.AddXY(dt1.Rows[i][0].ToString() + " (" + dt1.Rows[i][1].ToString() + ")", dt1.Rows[i][2]);
                chPlace.Series["FuelPlace"].Points[i].Label = dt1.Rows[i][2].ToString();                
                chPlace.Series["FuelPlace"].Points[i].ToolTip = dt1.Rows[i][0] + " (" + dt1.Rows[i][1] + ")";
            }
            chPlace.Titles.Add("جرد صرفيات مواقع الاقسام من وقود " + type);
        }
    }
}
