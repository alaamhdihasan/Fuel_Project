using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel.CLS_FRMS
{
    class CLS_FuelEntry
    {

        //Select Data of Fuel Entry 
        public DataTable SelectFuelEntry()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("FuelEntriesSelecting", null);
            dal.close();
            return Dt;
        }

        //------------------------------------------------------------
        //insert new bill and fuel to store
        public void InsertFuelEntry(int StoreID, string BillNo, DateTime BillDate, string FuelType, string StoreName, double Quantity, string CarNO,
            string CarType,string Driver, string TimeGetFuel, DateTime DateGetFuel, double QuantityNormal, string Notes, string month)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param;
            param = new SqlParameter[1];
            param[0] = new SqlParameter("@IDst", SqlDbType.Int);
            param[0].Value = StoreID;
            dal.open();
            DataTable dtQuan = dal.SelectingData("StoreSelectingQuantity", param);
            dal.close();

            if (Quantity + int.Parse(dtQuan.Rows[0][0].ToString()) <= int.Parse(dtQuan.Rows[0][1].ToString()))
            {
                param = new SqlParameter[14];
                param[0] = new SqlParameter("@BillNo", SqlDbType.VarChar, 50);
                param[0].Value = BillNo;
                param[1] = new SqlParameter("@BillDate", SqlDbType.Date);
                param[1].Value = BillDate;
                param[2] = new SqlParameter("@FuelType", SqlDbType.VarChar, 50);
                param[2].Value = FuelType;
                param[3] = new SqlParameter("@StoreName", SqlDbType.VarChar, 50);
                param[3].Value = StoreName;
                param[4] = new SqlParameter("@Quantity", SqlDbType.Real);
                param[4].Value = Quantity;
                param[5] = new SqlParameter("@CarNO", SqlDbType.VarChar, 50);
                param[5].Value = CarNO;
                param[6] = new SqlParameter("@CarType", SqlDbType.VarChar, 50);
                param[6].Value = CarType;
                param[7] = new SqlParameter("@RegisterName", SqlDbType.VarChar, 50);
                param[7].Value = Properties.Settings.Default.UserName;
                param[8] = new SqlParameter("@Driver", SqlDbType.VarChar, 50);
                param[8].Value = Driver;
                param[9] = new SqlParameter("@TimeGetFuel", SqlDbType.VarChar, 50);
                param[9].Value = TimeGetFuel;
                param[10] = new SqlParameter("@DateGetFuel", SqlDbType.Date);
                param[10].Value = DateGetFuel;
                param[11] = new SqlParameter("@QuantityNormal", SqlDbType.Real);
                param[11].Value = QuantityNormal;
                param[12] = new SqlParameter("@Notes", SqlDbType.Text);
                param[12].Value = Notes;
                param[13] = new SqlParameter("@month", SqlDbType.Text);
                param[13].Value = month;
                dal.open();
                dal.ExecuteCommand("FuelentriesInsertinto", param);
                dal.close();

                param = new SqlParameter[2];
                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = StoreID;             
                param[1] = new SqlParameter("@Quantity", SqlDbType.Real);
                param[1].Value = Quantity + int.Parse(dtQuan.Rows[0][0].ToString());
               
                dal.open();
                dal.ExecuteCommand("StoreUPdateInfoQuantity", param);
                dal.close();
            }
            else
                MessageBox.Show("المخزن ممتلئ");
        }

        //---------------------------------------------------------------
        //Update data of billFuel in database
        public void UpdateFuelEntray(int StoreID, int idfuel, string BillNo, DateTime BillDate, string FuelType, string StoreName, double Quantity, string CarNO,
            string CarType, double QuantityUpdate, string Driver, string TimeGetFuel, DateTime DateGetFuel, double QuantityNormal, string Notes,string month)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] paramStore;
            paramStore = new SqlParameter[1];
            paramStore[0] = new SqlParameter("@IDst", SqlDbType.Int);
            paramStore[0].Value = StoreID;
            dal.open();
            DataTable dtQuan = dal.SelectingData("StoreSelectingQuantity", paramStore);
            dal.close();
           
                if (QuantityUpdate + Convert.ToDouble(dtQuan.Rows[0][0]) <= Convert.ToDouble(dtQuan.Rows[0][1]))
                {
                    SqlParameter[] param = new SqlParameter[15];
                    param[0] = new SqlParameter("@id", SqlDbType.Int);
                    param[0].Value = idfuel;
                    param[1] = new SqlParameter("@BillNo", SqlDbType.VarChar, 50);
                    param[1].Value = BillNo;
                    param[2] = new SqlParameter("@BillDate", SqlDbType.Date);
                    param[2].Value = BillDate.Date;
                    param[3] = new SqlParameter("@FuelType", SqlDbType.VarChar, 50);
                    param[3].Value = FuelType;
                    param[4] = new SqlParameter("@StoreName", SqlDbType.VarChar, 50);
                    param[4].Value = StoreName;
                    param[5] = new SqlParameter("@Quantity", SqlDbType.Real);
                    param[5].Value = Quantity;
                    param[6] = new SqlParameter("@CarNO", SqlDbType.VarChar, 50);
                    param[6].Value = CarNO;
                    param[7] = new SqlParameter("@CarType", SqlDbType.VarChar, 50);
                    param[7].Value = CarType;
                    param[8] = new SqlParameter("@RegisterName", SqlDbType.VarChar, 50);
                    param[8].Value = Properties.Settings.Default.UserName;
                    param[9] = new SqlParameter("@Driver", SqlDbType.VarChar, 50);
                    param[9].Value = Driver;
                    param[10] = new SqlParameter("@TimeGetFuel", SqlDbType.VarChar, 50);
                    param[10].Value = TimeGetFuel;
                    param[11] = new SqlParameter("@DateGetFuel", SqlDbType.Date);
                    param[11].Value = DateGetFuel;
                    param[12] = new SqlParameter("@QuantityNormal", SqlDbType.Real);
                    param[12].Value = QuantityNormal;
                    param[13] = new SqlParameter("@Notes", SqlDbType.Text);
                    param[13].Value = Notes;
                    param[14] = new SqlParameter("@month", SqlDbType.Text);
                    param[14].Value = month;
                    dal.open();
                    dal.ExecuteCommand("Fuelentriesupdate", param);
                    dal.close();

                    param = new SqlParameter[2];
                    param[0] = new SqlParameter("@ID", SqlDbType.Int);
                    param[0].Value = StoreID;

                    param[1] = new SqlParameter("@Quantity", SqlDbType.Real);
                    param[1].Value = QuantityUpdate + Convert.ToDouble(dtQuan.Rows[0][0]);

                    dal.open();
                    dal.ExecuteCommand("StoreUPdateInfoQuantity", param);
                    dal.close();
                }
                else
                    MessageBox.Show("المخزن لا يكفي");
            
        }

        //--------------------------------------------------------------------
        //delete bill from data bill and from fuel store
        public void DeleteFuelEntry(int IDfuel, int StoreID, string StoreName, double Quantity)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] paramStore;
            paramStore = new SqlParameter[1];
            paramStore[0] = new SqlParameter("@IDst", SqlDbType.Int);
            paramStore[0].Value = StoreID;
            dal.open();
            DataTable dtQuan = dal.SelectingData("StoreSelectingQuantity", paramStore);
            dal.close();
            if (Convert.ToDouble(dtQuan.Rows[0][0]) - Quantity >= 0)
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = IDfuel;
                dal.open();
                dal.ExecuteCommand("FuelEntriesDeleting", param);
                dal.close();

                param = new SqlParameter[2];
                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = StoreID;
                
                param[1] = new SqlParameter("@Quantity", SqlDbType.Real);
                param[1].Value = Convert.ToDouble(dtQuan.Rows[0][0]) - Quantity;
               
                dal.open();
                dal.ExecuteCommand("StoreUPdateInfoQuantity", param);
                dal.close();
            }
            else
                MessageBox.Show("المخزن لا يكفي");
        }

        //-------------------------------------------------------------------
        //show Entry data in datagridview
        public DataTable showFuelEntrayData(DataGridView DgvFuelEntry, TextBox txtID, TextBox txtBillNo, DateTimePicker DateBill,
            ComboBox cmbFuelType, ComboBox cmbStoreName, TextBox txtQuantity, ComboBox cmbCarNo, ComboBox cmbCarType,
            TextBox txtDriver, DevExpress.XtraEditors.TimeEdit TimeGetFuel, DateTimePicker DateGetFuel, TextBox QuantityNormal, TextBox Notes, ComboBox month)
        {
            try
            {

                DgvFuelEntry.DataSource = null;
                txtID.DataBindings.Clear();
                txtBillNo.DataBindings.Clear();
                cmbFuelType.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                cmbCarNo.DataBindings.Clear();
                cmbCarType.DataBindings.Clear();
                txtDriver.DataBindings.Clear();
                TimeGetFuel.DataBindings.Clear();
                DateGetFuel.DataBindings.Clear();
                cmbStoreName.DataBindings.Clear();
                DateBill.DataBindings.Clear();
                QuantityNormal.DataBindings.Clear();
                Notes.DataBindings.Clear();
                month.DataBindings.Clear();

                DataTable Dt = SelectFuelEntry();
                DgvFuelEntry.DataSource = Dt;
                DgvFuelEntry.Columns[0].Visible = false;
                DgvFuelEntry.Columns[1].HeaderText = "رقم الفاتورة";
                DgvFuelEntry.Columns[2].HeaderText = "تاريخ الفاتورة";
                DgvFuelEntry.Columns[3].HeaderText = "نوع الوقود";
                DgvFuelEntry.Columns[4].HeaderText = "اسم المخزن";
                DgvFuelEntry.Columns[5].HeaderText = "الكمية طبيعي";
                DgvFuelEntry.Columns[6].HeaderText = "رقم السيارة";
                DgvFuelEntry.Columns[7].HeaderText = "نوع السيارة";
                DgvFuelEntry.Columns[8].Visible = false;
                DgvFuelEntry.Columns[9].Visible = false;
                DgvFuelEntry.Columns[10].Visible = false;
                DgvFuelEntry.Columns[11].HeaderText = "اسم السائق";
                DgvFuelEntry.Columns[12].HeaderText = "وقت الاستلام";
                DgvFuelEntry.Columns[13].HeaderText = "تاريخ الاستلام";
                DgvFuelEntry.Columns[14].HeaderText = "الكمية قياسي";
                DgvFuelEntry.Columns[15].Visible = false;
                DgvFuelEntry.Columns[16].Visible = false;

                txtID.DataBindings.Add("text", Dt, "id");
                txtBillNo.DataBindings.Add("text", Dt, "BillNo");
                DateBill.DataBindings.Add("text", Dt, "BillDate");
                cmbFuelType.DataBindings.Add("text", Dt, "FuelType");
                cmbStoreName.DataBindings.Add("text", Dt, "StoreName");
                cmbStoreName.SelectedIndex = cmbStoreName.FindStringExact(cmbStoreName.Text);
                txtQuantity.DataBindings.Add("text", Dt, "Quantity");
                cmbCarNo.DataBindings.Add("text", Dt, "CarNO");
                cmbCarType.DataBindings.Add("text", Dt, "CarType");
                txtDriver.DataBindings.Add("text", Dt, "Driver");              
                TimeGetFuel.DataBindings.Add("text", Dt, "TimeGetFuel");                         
                DateGetFuel.DataBindings.Add("text", Dt, "DateGetFuel");
                QuantityNormal.DataBindings.Add("text",Dt, "QuantityNormal");
                Notes.DataBindings.Add("text",Dt,"Notes");
                month.DataBindings.Add("text", Dt, "month");
                txtID.Visible = false;
                return Dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                DataTable dt = null;
                return dt;
            }
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



        //Archive bill for Fuel Entry
        //---------------------------------------------------------------------
        //select archive for fuel bill entray
        public DataTable selectFuelArchive(int idcon, TextBox txtArchiveID, TextBox txtImagePath, TextBox txtRegistername, TextBox txtAddingTime, TextBox txtAddingDate, ListView lsv)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@IDcon", SqlDbType.Int); param[0].Value = idcon;
            dal.open();
            DataTable Dt = dal.SelectingData("fuelArchieveSelecting", param);
            dal.close();

            txtArchiveID.DataBindings.Clear();
            
            txtImagePath.DataBindings.Clear();
            txtRegistername.DataBindings.Clear();
            txtAddingDate.DataBindings.Clear();
            txtAddingTime.DataBindings.Clear();

            txtArchiveID.DataBindings.Add("text", Dt, "id");
            
            txtImagePath.DataBindings.Add("text", Dt, "ImagePath");
            txtRegistername.DataBindings.Add("text", Dt, "RegisterName");
            txtAddingTime.DataBindings.Add("text", Dt, "AddingTime");
            txtAddingDate.DataBindings.Add("text", Dt, "AddingDate");

            ImageList imageListLarge = new ImageList();
            imageListLarge.ImageSize = new Size(250, 250);
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                try
                {
                    imageListLarge.Images.Add(Bitmap.FromFile(Dt.Rows[i][3].ToString()));
                }
                catch
                {
                    imageListLarge.Images.Add(iconfile(Path.GetExtension(Dt.Rows[i][3].ToString())));

                }

            }
            lsv.Items.Clear();
            lsv.LargeImageList = imageListLarge;
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                lsv.Items.Add(Dt.Rows[i][3].ToString(), i);
            }

            lsv.View = View.LargeIcon;
            return Dt;
        }

        //get data from image archive
        public DataTable GetDataByListView(string path, TextBox txtArchiveID, TextBox txtRegistername, TextBox txtAddingTime, TextBox txtAddingDate)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Path", SqlDbType.Text); param[0].Value = path;
            dal.open();
            DataTable Dt = dal.SelectingData("fuelArchieveSelectingByPath", param);
            dal.close();

            txtArchiveID.DataBindings.Clear();
          
            txtRegistername.DataBindings.Clear();
            txtAddingDate.DataBindings.Clear();
            txtAddingTime.DataBindings.Clear();

            txtArchiveID.DataBindings.Add("text", Dt, "id");
            
            txtRegistername.DataBindings.Add("text", Dt, "RegisterName");
            txtAddingTime.DataBindings.Add("text", Dt, "AddingTime");
            txtAddingDate.DataBindings.Add("text", Dt, "AddingDate");

            return Dt;
        }

        //add archive to fuel bill
        public void addArchiveFuel(int txtconID, int BillNo, string path)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@IDcon", SqlDbType.Int); param[0].Value = txtconID;
            param[1] = new SqlParameter("@BillNo", SqlDbType.Int); param[1].Value = BillNo;
            param[2] = new SqlParameter("@ImagePath", SqlDbType.Text); param[2].Value = path;
            param[3] = new SqlParameter("@RegisterName", SqlDbType.VarChar, 50); param[3].Value = Properties.Settings.Default.UserName;
            

            dal.open();
            dal.ExecuteCommand("FuelArchieveInsertInto", param);
            dal.close();
        }

        //delete archive from fuel archive bill
        public void deleteArchiveFuel(int IDFuelArchive)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int); param[0].Value = IDFuelArchive;
            dal.open();
            dal.ExecuteCommand("FuelArchieveDeleting", param);
            dal.close();
        }

        //===============================================================================================================================
        //===this function below for get file icon
        public Image iconfile(string fileex)
        {
            List<string> exWord = new List<string>(new string[] { ".doc", ".doc", ".wbk", ".docx", ".docm", ".dotx", ".dotm", ".docb" });

            List<string> exExcel = new List<string>(new string[] { ".xls", ".xlt", ".xlm", ".xlsx", ".xlsm", ".xltx", ".xltm", ".xlsb", ".xla", ".xlam", ".xll", ".xlw" });

            List<string> exVideo = new List<string>(new string[] { ".webm", ".mkv", ".flv", ".vob", ".ogv", ".ogg", ".drc", ".gif" , ".gifv", ".mng", ".avi", ".MTS", ".M2TS", ".TS",
                ".mov", ".qt", ".wmv", ".yuv", ".rm", ".rmvb", ".asf", ".amv", ".mp4", ".m4p ", ".m4v", ".mpg", ".mp2", ".mpeg", ".mpe", ".mpv" ,
                ".mpg", ".mpeg", ".m2v", ".m4v", ".svi", ".3gp", ".3g2", ".mxf", ".roq", ".nsv", ".flv", ".f4v" , ".f4p", ".f4a", ".f4b"});

            List<string> exPowerPoint = new List<string>(new string[] { ".ppt", ".pot", ".pps", ".pptx", ".pptm", ".potx", ".potm", ".ppam", ".ppsx", ".ppsm", ".sldx", ".sldm" });

            List<string> exAudio = new List<string>(new string[] { ".3gp", ".aa", ".aac", ".aax", ".act", ".aiff", ".alac", ".amr" , ".ape", ".au", ".awb", ".dct", ".dss", ".dvf",
                ".flac", ".gsm", ".iklax", ".ivs", ".m4a", ".m4b", ".m4p", ".mmf", ".mp3", ".mpc ", ".msv", ".nmf", ".nsf", ".mogg", ".oga", ".ogg" ,
                ".opus", ".rm", ".ra", ".raw", ".rf64", ".sln", ".tta", ".voc", ".vox", ".wav", ".wma", ".wv" , ".webm", ".8svx", ".cda" });

            if (exWord.Contains(fileex))
                return Properties.Resources.word;
            if (exExcel.Contains(fileex))
                return Properties.Resources.excel;
            if (exVideo.Contains(fileex))
                return Properties.Resources.video;
            if (exPowerPoint.Contains(fileex))
                return Properties.Resources.powerpoint;
            if (exAudio.Contains(fileex))
                return Properties.Resources.audio;
            if (fileex == ".pdf")
                return Properties.Resources.pdf;
            if (fileex == ".txt")
                return Properties.Resources.txt;

            return Properties.Resources.الاليات;
        }

    }
}
