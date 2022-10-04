using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.Utils.Drawing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Fuel.CLS_FRMS
{
    class CLS_Store
    {

        public DataTable GetDataStore()//---------------------------------جلب بيانات جدول المخازن
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("TheStoreSelecting", null);
            dal.close();

            return Dt;
        }

        public DataTable GetStoreQuantity(string StroeName)//---------------------------------جلب الكمية في المخازن
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@storename", SqlDbType.VarChar, 50);
            param[0].Value = StroeName;
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("TheStoreSelectingQuantity", param);
            dal.close();

            return Dt;
        }
        public void StoreInsertInfo(string StroeName, string StroeLocation, string FuelType, double MaxQuantity,double Quantity,string Descreption)// -----------ادخال بيانات الى جدول المخازن
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@StroeName", SqlDbType.VarChar, 50);
            param[0].Value = StroeName;
            param[1] = new SqlParameter("@StroeLocation", SqlDbType.VarChar, 50);
            param[1].Value = StroeLocation;
            param[2] = new SqlParameter("@FuelType", SqlDbType.VarChar, 50);
            param[2].Value = FuelType;
            param[3] = new SqlParameter("@MaxQuantity", SqlDbType.Real);
            param[3].Value = MaxQuantity;
            param[4] = new SqlParameter("@Quantity", SqlDbType.Real);
            param[4].Value = Quantity;
            param[5] = new SqlParameter("@Descreption", SqlDbType.VarChar, 50);
            param[5].Value = Descreption;
            param[6] = new SqlParameter("@RegisterName", SqlDbType.VarChar, 50);
            param[6].Value = Properties.Settings.Default.UserName;
            dal.open();
            dal.ExecuteCommand("StoreInsertInfo", param);
            dal.close();

        }
        public void StoreUpdateInfo(int id, string StroeName, string StroeLocation, string FuelType, double MaxQuantity, double Quantity, string Descreption)//------تحديث بيانات جدول المخازن
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@StroeName", SqlDbType.VarChar, 50);
            param[1].Value = StroeName;
            param[2] = new SqlParameter("@StroeLocation", SqlDbType.VarChar, 50);
            param[2].Value = StroeLocation;
            param[3] = new SqlParameter("@FuelType", SqlDbType.VarChar, 50);
            param[3].Value = FuelType;
            param[4] = new SqlParameter("@MaxQuantity", SqlDbType.Real);
            param[4].Value = MaxQuantity;
            param[5] = new SqlParameter("@Quantity", SqlDbType.Real);
            param[5].Value = Quantity;
            param[6] = new SqlParameter("@Descreption", SqlDbType.VarChar, 50);
            param[6].Value = Descreption;
            param[7] = new SqlParameter("@RegisterName", SqlDbType.VarChar, 50);
            param[7].Value = Properties.Settings.Default.UserName;
            dal.open();
            dal.ExecuteCommand("StoreUPdateInfo", param);
            dal.close();

        }
        public void StoreDeleting(int ID)//--------الحذف من جدول المخزن
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = ID;
            dal.open();
            dal.ExecuteCommand("StoriesDeleting", param);
            dal.close();

        }

        public void StoreUpdateInfoQuantity(int ID,double Quantity)//--------تعديل الكمية في المخزن
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = ID;
            param[1] = new SqlParameter("@Quantity", SqlDbType.Real);
            param[1].Value = Quantity;
            dal.open();
            dal.ExecuteCommand("StoreUPdateInfoQuantity", param);
            dal.close();

        }

        public DataTable StoreSelectingInfoQuantity(int ID)//--------جلب بيانات السعة من المخزن
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = ID;
           
            dal.open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("StoreSelectingQuantity", param);
            dal.close();

            return Dt;
        }

        public DataTable StoreDesign(DataGridView Dgv, TextBox id, TextBox StroeName, TextBox StroeLocation, System.Windows.Forms.ComboBox FuelType, TextBox MaxQuantity, TextBox Quantity, TextBox Descreption)
        {
            id.DataBindings.Clear();
            StroeName.DataBindings.Clear();
            StroeLocation.DataBindings.Clear();
            FuelType.DataBindings.Clear();
            MaxQuantity.DataBindings.Clear();
            Quantity.DataBindings.Clear();
            Descreption.DataBindings.Clear();
            Dgv.DataSource = null;

            DataTable dt = GetDataStore();

            Dgv.DataSource = dt;
            Dgv.Columns[0].Visible = false;
            Dgv.Columns[1].HeaderText = "اسم المخزن";
            Dgv.Columns[2].HeaderText = "موقع المخزن";
            Dgv.Columns[3].HeaderText = "نوع الوقود";            
            Dgv.Columns[4].HeaderText = "الكمية الحالية";
            Dgv.Columns[5].HeaderText = "السعة الكلية";
            Dgv.Columns[6].HeaderText = "ملاحظات";
            Dgv.Columns[7].Visible = false;
            Dgv.Columns[8].Visible = false;
            Dgv.Columns[9].Visible = false;

            id.DataBindings.Add("text", dt, "id");
            StroeName.DataBindings.Add("text", dt, "StoreName");
            StroeLocation.DataBindings.Add("text", dt, "StoreLocation");
            FuelType.DataBindings.Add("text", dt, "FuelType");
            MaxQuantity.DataBindings.Add("text", dt, "MaxQuantity");
            Quantity.DataBindings.Add("text", dt, "Quantity");
            Descreption.DataBindings.Add("text", dt, "Description");

            return dt;
        }


        //show data in stores in progress bar
        public void ShowStores(TableLayoutPanel StoresLayoutPanel, string page)
        {
            StoresLayoutPanel.Controls.Clear();
            DataTable dtStore = GetDataStore();
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("MaxQuantity", typeof(int));
            for (int i = 0; i < dtStore.Rows.Count; i++)
            {
                DataTable dtQuantity = GetStoreQuantity(dtStore.Rows[i][1].ToString());
                DataRow dr = dt.NewRow();
                dr["name"] = dtStore.Rows[i][1].ToString();
                if(dtQuantity.Rows[0][0].ToString()!=null && dtQuantity.Rows[0][0].ToString()!="")
                    dr["Quantity"] = int.Parse(dtQuantity.Rows[0][0].ToString());
                else
                    dr["Quantity"] = 0;
                dr["MaxQuantity"] = int.Parse(dtStore.Rows[i][5].ToString());
                dt.Rows.Add(dr);
            }
            if (dt.Rows.Count > 0)
            {
                StoresLayoutPanel.ColumnCount = dt.Rows.Count;

                double percent = 100 / dt.Rows.Count;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int Qun = Convert.ToInt32(dt.Rows[i][1]) * 100 / Convert.ToInt32(dt.Rows[i][2]);
                    StoresLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

                    Label storeName = new Label();
                    storeName.Text = (i + 1) + "-" + dt.Rows[i][0].ToString() + " " + dt.Rows[i][1].ToString() + "-" + dt.Rows[i][2].ToString();
                    storeName.Font = new System.Drawing.Font("JF Flat", 10, FontStyle.Bold);
                    StoresLayoutPanel.Controls.Add(storeName, i, 1);
                    storeName.Dock = DockStyle.Fill;
                    storeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    
                    ProgressBarControl pr = new ProgressBarControl();
                    pr.Text = Qun.ToString();
                    pr.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
                    pr.LookAndFeel.UseDefaultLookAndFeel = false;
                    pr.Properties.TextOrientation = TextOrientation.Horizontal;
                    pr.Properties.ProgressKind = DevExpress.XtraEditors.Controls.ProgressKind.Vertical;
                    pr.RightToLeft = RightToLeft.No;
                    pr.Font = new System.Drawing.Font("JF Flat", 15, FontStyle.Bold);

                    pr.Properties.StartColor = Color.Blue;
                    pr.Properties.EndColor = Color.Red;
                    pr.Properties.ShowTitle = true;


                    pr.Dock = DockStyle.Fill;
                    StoresLayoutPanel.Controls.Add(pr, i, 0);
                }
            }
        }

        //===================================================================================================
        //Fuel Price Data

        //---------------------------------------------------------------
        public void addFuelPOrice(int idcon, double Price , double percentageAdd , double PriceTransportInside, double priceTransportOutside)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@IDcon", SqlDbType.Int);
            param[0].Value = idcon;
            param[1] = new SqlParameter("@Price", SqlDbType.Real);
            param[1].Value = Price;
            param[2] = new SqlParameter("@percentageAdd", SqlDbType.Real);
            param[2].Value = percentageAdd;
            param[3] = new SqlParameter("@PriceTransportInside", SqlDbType.Real);
            param[3].Value = PriceTransportInside;
            param[4] = new SqlParameter("@priceTransportOutside", SqlDbType.Real);
            param[4].Value = priceTransportOutside;           
            param[5] = new SqlParameter("@RegisterName", SqlDbType.VarChar, 50);
            param[5].Value = Properties.Settings.Default.UserName;
            dal.open();
            dal.ExecuteCommand("FuelPriceInsert", param);
            dal.close();
        }

        //---------------------------------------------------------------
        public void updateFuelPOrice(int idcon, double Price, double percentageAdd, double PriceTransportInside, double priceTransportOutside)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@IDcon", SqlDbType.Int);
            param[0].Value = idcon;
            param[1] = new SqlParameter("@Price", SqlDbType.Real);
            param[1].Value = Price;
            param[2] = new SqlParameter("@percentageAdd", SqlDbType.Real);
            param[2].Value = percentageAdd;
            param[3] = new SqlParameter("@PriceTransportInside", SqlDbType.Real);
            param[3].Value = PriceTransportInside;
            param[4] = new SqlParameter("@priceTransportOutside", SqlDbType.Real);
            param[4].Value = priceTransportOutside;
            param[5] = new SqlParameter("@RegisterName", SqlDbType.VarChar, 50);
            param[5].Value = Properties.Settings.Default.UserName;
            dal.open();
            dal.ExecuteCommand("FuelPriceUpdate", param);
            dal.close();
        }
        //------------------------------------------------------------------------
        public DataTable GetDataFuelPrice(int id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dal.open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("FuelPriceSelecting", param);
            dal.close();

            return Dt;
        }

        //------------------------------------------------------------------------
        public void deleteDataFuelPrice(int id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@IDcon", SqlDbType.Int);
            param[0].Value = id;
            dal.open();
            dal.ExecuteCommand("FuelPriceDeleting", param);
            dal.close();

        }

        //-----------------------------------------------------------------------
        //Notification if store empty ofr full
        public List<Tuple<string, int>> notifcation()
        {
            List<Tuple<string, int>> textlist = new List<Tuple<string, int>>();            
            DataTable Dt = GetDataStore();
            
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                if (Convert.ToInt32(Dt.Rows[i][4])<= 0)
                {
                    textlist.Add(new Tuple<string, int>("(" + Dt.Rows[i][1].ToString() + ") المخزن فارغ", 1));
                }
                else if (Convert.ToInt32(Dt.Rows[i][4]) == Convert.ToInt32(Dt.Rows[i][5]))
                {
                    textlist.Add(new Tuple<string, int>("(" + Dt.Rows[i][1].ToString() + ") المخزن ممتلئ", 1));
                }

            }
            return textlist;
        }
    }
}
