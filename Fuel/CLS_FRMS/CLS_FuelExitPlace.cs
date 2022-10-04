using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel.CLS_FRMS
{
    class CLS_FuelExitPlace
    {
        //===================================================================
        //Select Data of Fuel Selling 
        public DataTable SelectFuelExit()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("FuelsellingPlaceSelect", null);
            dal.close();
            return Dt;
        }

        public void placeCombobox(ComboBox cbx)
        {
            CLS_Department dept = new CLS_Department();
            DataTable dt = dept.GetDataPlaces();
            cbx.Items.Clear();
            for(int i = 0; i < dt.Rows.Count;i++)
            {
                cbx.Items.Add(dt.Rows[i][2].ToString());
            }
        }

        //Select last bill number of Fuel Selling 
        public DataTable SelectFuelLastBillNot()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("FuelSellingSelectLastBillNo", null);
            dal.close();
            return Dt;
        }

        //Select Data of Fuel Selling Place Bill
        public DataTable SelectFuelExitPlaceBill(int id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param;
            param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            dal.open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("FuelSellingPlaceBill", param);
            dal.close();
            return Dt;
        }

        //Select last bill number of Fuel Selling 
        public void AddNewBill(int BillNo)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param;
            param = new SqlParameter[18];
            param[0] = new SqlParameter("@BillNo", SqlDbType.VarChar, 50);
            param[0].Value = BillNo;
            param[1] = new SqlParameter("@TheBeneficiary", SqlDbType.VarChar, 500);
            param[1].Value = "";
            param[2] = new SqlParameter("@Place", SqlDbType.VarChar, 500);
            param[2].Value = "";
            param[3] = new SqlParameter("@DeptInvest", SqlDbType.Bit);
            param[3].Value = false;
            param[4] = new SqlParameter("@StoreName", SqlDbType.VarChar, 50);
            param[4].Value = "";
            param[5] = new SqlParameter("@FuelType", SqlDbType.VarChar, 50);
            param[5].Value = "";
            param[6] = new SqlParameter("@FullPlace", SqlDbType.VarChar, 50);
            param[6].Value = "";
            param[7] = new SqlParameter("@OneLitterPrice", SqlDbType.Real);
            param[7].Value = 0;
            param[8] = new SqlParameter("@TranPrice", SqlDbType.Real);
            param[8].Value = 0;
            param[9] = new SqlParameter("@percentage", SqlDbType.Real);
            param[9].Value = 0;
            param[10] = new SqlParameter("@LitterPrice", SqlDbType.Real);
            param[10].Value = 0;
            param[11] = new SqlParameter("@Quantity", SqlDbType.Real);
            param[11].Value = 0;
            param[12] = new SqlParameter("@FreeQuantity", SqlDbType.Real);
            param[12].Value = 0;
            param[13] = new SqlParameter("@totalprice", SqlDbType.Real);
            param[13].Value = 0;
            param[14] = new SqlParameter("@RegisterName", SqlDbType.VarChar, 50);
            param[14].Value = Properties.Settings.Default.UserName;
            param[15] = new SqlParameter("@BillDate", SqlDbType.Date);
            param[15].Value = DateTime.Today;
            param[16] = new SqlParameter("@month", SqlDbType.VarChar, 50);
            param[16].Value = "";
            param[17] = new SqlParameter("@notes", SqlDbType.VarChar, 500);
            param[17].Value = "";
            dal.open();
            dal.ExecuteCommand("FuelsellingPlaceInsert", param);
            dal.close();
        }
        //------------------------------------------------------------
        //insert new bill and selling fuel to store
        public void InsertFuelExit(int StoreID, string BillNo, string TheBeneficiary, string place,
              bool DeptInvest, string StoreName, string FuelType,string FullPlace, double oneLiterPrice, double TranPrice, double percentage,
              double Literprice, double Quantity, double totalprice, double FreeQuantity, string BillDate, string month, string notes
            )
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
                param = new SqlParameter[18];
                param[0] = new SqlParameter("@BillNo", SqlDbType.VarChar, 50);
                param[0].Value = BillNo;
                param[1] = new SqlParameter("@TheBeneficiary", SqlDbType.VarChar, 500);
                param[1].Value = TheBeneficiary;
                param[2] = new SqlParameter("@Place", SqlDbType.VarChar, 500);
                param[2].Value = place;
                param[3] = new SqlParameter("@DeptInvest", SqlDbType.Bit);
                param[3].Value = DeptInvest;
                param[4] = new SqlParameter("@StoreName", SqlDbType.VarChar, 50);
                param[4].Value = StoreName;
                param[5] = new SqlParameter("@FuelType", SqlDbType.VarChar, 50);
                param[5].Value = FuelType;
                param[6] = new SqlParameter("@FullPlace", SqlDbType.VarChar, 50);
                param[6].Value = FullPlace;
                param[7] = new SqlParameter("@OneLitterPrice", SqlDbType.Real);
                param[7].Value = oneLiterPrice;
                param[8] = new SqlParameter("@TranPrice", SqlDbType.Real);
                param[8].Value = TranPrice;
                param[9] = new SqlParameter("@percentage", SqlDbType.Real);
                param[9].Value = percentage;
                param[10] = new SqlParameter("@LitterPrice", SqlDbType.Real);
                param[10].Value = Literprice;
                param[11] = new SqlParameter("@Quantity", SqlDbType.Real);
                param[11].Value = Quantity;
                param[12] = new SqlParameter("@FreeQuantity", SqlDbType.Real);
                param[12].Value = FreeQuantity;
                param[13] = new SqlParameter("@totalprice", SqlDbType.Real);
                param[13].Value = totalprice;
                param[14] = new SqlParameter("@RegisterName", SqlDbType.VarChar, 50);
                param[14].Value = Properties.Settings.Default.UserName;
                param[15] = new SqlParameter("@BillDate", SqlDbType.Date);
                param[15].Value = BillDate;
                param[16] = new SqlParameter("@month", SqlDbType.VarChar, 50);
                param[16].Value = month;
                param[17] = new SqlParameter("@notes", SqlDbType.VarChar, 500);
                param[17].Value = notes;
                dal.open();
                dal.ExecuteCommand("FuelsellingPlaceInsert", param);
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
        public void UpdateFuelExitPlace(int StoreID, int idfuel, string BillNo, DateTime BillDate, string TheBeneficiary, string place,
                  bool DeptInvest, string StoreName, string FuelType,string FullPlace, double oneLiterPrice, double TranPrice, double percentage,
                  double Literprice, double Quantity, double totalprice, double QuantityUpdate, double FreeQuantity, string month, string notes)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] paramStore;
            paramStore = new SqlParameter[1];
            paramStore[0] = new SqlParameter("@IDst", SqlDbType.Int);
            paramStore[0].Value = StoreID;
            dal.open();
            DataTable dtQuan = dal.SelectingData("StoreSelectingQuantity", paramStore);
            dal.close();

            if (Convert.ToDouble(dtQuan.Rows[0][0]) + QuantityUpdate >= 0)
            {

                SqlParameter[] param = new SqlParameter[19];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = idfuel;
                param[1] = new SqlParameter("@BillNo", SqlDbType.VarChar, 50);
                param[1].Value = BillNo;
                param[2] = new SqlParameter("@BillDate", SqlDbType.Date);
                param[2].Value = BillDate;
                param[3] = new SqlParameter("@TheBeneficiary", SqlDbType.VarChar, 500);
                param[3].Value = TheBeneficiary;
                param[4] = new SqlParameter("@Place", SqlDbType.VarChar, 500);
                param[4].Value = place;
                param[5] = new SqlParameter("@DeptInvest", SqlDbType.Bit);
                param[5].Value = DeptInvest;
                param[6] = new SqlParameter("@StoreName", SqlDbType.VarChar, 50);
                param[6].Value = StoreName;
                param[7] = new SqlParameter("@FuelType", SqlDbType.VarChar, 50);
                param[7].Value = FuelType;
                param[8] = new SqlParameter("@FullPlace", SqlDbType.VarChar, 50);
                param[8].Value = FullPlace;
                param[9] = new SqlParameter("@OneLitterPrice", SqlDbType.Real);
                param[9].Value = oneLiterPrice;
                param[10] = new SqlParameter("@TranPrice", SqlDbType.Real);
                param[10].Value = TranPrice;
                param[11] = new SqlParameter("@percentage", SqlDbType.Real);
                param[11].Value = percentage;
                param[12] = new SqlParameter("@LitterPrice", SqlDbType.Real);
                param[12].Value = Literprice;
                param[13] = new SqlParameter("@Quantity", SqlDbType.Real);
                param[13].Value = Quantity;
                param[14] = new SqlParameter("@FreeQuantity", SqlDbType.Real);
                param[14].Value = FreeQuantity;
                param[15] = new SqlParameter("@totalprice", SqlDbType.Real);
                param[15].Value = totalprice;
                param[16] = new SqlParameter("@RegisterName", SqlDbType.VarChar, 50);
                param[16].Value = Properties.Settings.Default.UserName;
                param[17] = new SqlParameter("@month", SqlDbType.VarChar, 50);
                param[17].Value = month;
                param[18] = new SqlParameter("@notes", SqlDbType.VarChar, 500);
                param[18].Value = notes;
                dal.open();
                dal.ExecuteCommand("FuelsellingPlaceUpdate", param);
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
                dal.ExecuteCommand("FuelsellingPlaceDelete", param);
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
        public DataTable showFuelExitPlaceData(DataGridView DgvExitFuel, TextBox txtExitID, TextBox txtBillExitNo, DateTimePicker dteExitBill,
           ComboBox TheBeneficiary, ComboBox place, CheckBox DeptInvest, ComboBox StoreName, ComboBox FuelType, ComboBox FullPlace, TextBox oneLiterPrice,
           TextBox TranPrice, TextBox percentage, TextBox Literprice, TextBox Quantity, TextBox totalprice, TextBox FreeQuantity, ComboBox month, TextBox notes)
        {
            try
            {
                DgvExitFuel.DataSource = null;
                txtExitID.DataBindings.Clear();
                txtBillExitNo.DataBindings.Clear();
                dteExitBill.DataBindings.Clear();
                TheBeneficiary.DataBindings.Clear();
                place.DataBindings.Clear();
                DeptInvest.DataBindings.Clear();
                StoreName.DataBindings.Clear();
                FuelType.DataBindings.Clear();
                FullPlace.DataBindings.Clear();
                oneLiterPrice.DataBindings.Clear();
                TranPrice.DataBindings.Clear();
                percentage.DataBindings.Clear();
                Literprice.DataBindings.Clear();
                Quantity.DataBindings.Clear();
                totalprice.DataBindings.Clear();
                FreeQuantity.DataBindings.Clear();
                month.DataBindings.Clear();
                notes.DataBindings.Clear();

                DataTable Dt = SelectFuelExit();
                DgvExitFuel.DataSource = Dt;
                DgvExitFuel.Columns[0].Visible = false;
                DgvExitFuel.Columns[1].HeaderText = "رقم الفاتورة";
                DgvExitFuel.Columns[2].HeaderText = "تاريخ الفاتورة";
                DgvExitFuel.Columns[3].HeaderText = "الجهة المستفيدة";
                DgvExitFuel.Columns[4].HeaderText = "الموقع";
                DgvExitFuel.Columns[5].Visible = false;
                DgvExitFuel.Columns[6].HeaderText = "اسم المخزن";
                DgvExitFuel.Columns[7].HeaderText = "نوع الوقود";
                DgvExitFuel.Columns[8].Visible = false;
                DgvExitFuel.Columns[9].Visible = false;
                DgvExitFuel.Columns[10].Visible = false;
                DgvExitFuel.Columns[11].HeaderText = "سعر اللتر";
                DgvExitFuel.Columns[12].HeaderText = "الكمية";
                DgvExitFuel.Columns[13].HeaderText = "المبلغ الكلي";           
                DgvExitFuel.Columns[14].Visible = false;
                DgvExitFuel.Columns[15].Visible = false;
                DgvExitFuel.Columns[16].Visible = false;
                DgvExitFuel.Columns[17].Visible = false;
                DgvExitFuel.Columns[18].HeaderText = "الكمية المجانية";
                DgvExitFuel.Columns[19].Visible = false;
                DgvExitFuel.Columns[20].Visible = false;

                txtExitID.DataBindings.Add("text", Dt, "id");
                txtBillExitNo.DataBindings.Add("text", Dt, "BillNO");
                dteExitBill.DataBindings.Add("text", Dt, "BillDate");
                TheBeneficiary.DataBindings.Add("text", Dt, "TheBeneficiary");
                place.DataBindings.Add("text", Dt, "Place");
                DeptInvest.DataBindings.Add("checked",Dt, "DeptInvest");
               
                StoreName.DataBindings.Add("text", Dt, "StoreName");
                StoreName.SelectedIndex = StoreName.FindStringExact(StoreName.Text);
                FuelType.DataBindings.Add("text", Dt, "FuelType");
                FullPlace.DataBindings.Add("text",Dt, "FullPlace");
                oneLiterPrice.DataBindings.Add("text", Dt, "OneLitterPrice");
                TranPrice.DataBindings.Add("text", Dt, "TranPrice");             
                percentage.DataBindings.Add("text", Dt, "Percentage");
                Literprice.DataBindings.Add("text", Dt, "LitterPrice");
                Quantity.DataBindings.Add("text", Dt, "Quantity");
                totalprice.DataBindings.Add("text", Dt, "TotalPrice");
                FreeQuantity.DataBindings.Add("text", Dt, "FreeQuantity");
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

     
    }
}
