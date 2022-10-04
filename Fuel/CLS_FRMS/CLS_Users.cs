using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
namespace Fuel.CLS_FRMS
{
    class CLS_Users
    {
        //operation on user information table (UserInfo)
        public DataTable UserInfoSelecting()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("UserInfoSelecting", null);
            dal.close();

            return Dt;
        }

        public DataTable UserInfoSelectingByUerAndPass(string UserName, string Password)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            param[0].Value = UserName;
            param[1] = new SqlParameter("@Password", SqlDbType.VarChar, 50);
            param[1].Value = Password;
            dal.open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("UserInfoSelectingByUerAndPass", param);
            dal.close();

            return Dt;
        }

        public void UserInfoInsert(string UserName, string Password, string JopTitle)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            param[0].Value = UserName;
            param[1] = new SqlParameter("@Password", SqlDbType.VarChar, 50);
            param[1].Value = Password;
            param[2] = new SqlParameter("@JopTitle", SqlDbType.VarChar, 50);
            param[2].Value = JopTitle;
            param[3] = new SqlParameter("@RegisterName", SqlDbType.VarChar, 50);
            param[3].Value = Properties.Settings.Default.UserName;
  
            dal.open();
            dal.ExecuteCommand("UserInfoInsert", param);
            dal.close();
        }

        public void UserInfoUpdate(int id,string UserName, string Password, string JopTitle)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            param[1].Value = UserName;
            param[2] = new SqlParameter("@Password", SqlDbType.VarChar, 50);
            param[2].Value = Password;
            param[3] = new SqlParameter("@JopTitle", SqlDbType.VarChar, 50);
            param[3].Value = JopTitle;
            param[4] = new SqlParameter("@RegisterName", SqlDbType.VarChar, 50);
            param[4].Value = Properties.Settings.Default.UserName;

            dal.open();
            dal.ExecuteCommand("UserInfoUpdate", param);
            dal.close();
        }

        public void UserInfoDelete(int id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dal.open();
            dal.ExecuteCommand("UserInfoDelete", param);
            dal.close();
        }

        //----------------------------------------------------------------------------------------
        //operation on user premission table (UserPre)

        public DataTable UserPreSelecting(int idcon)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idcon", SqlDbType.VarChar, 50);
            param[0].Value = idcon;
           
            dal.open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("UserPreSelecting", param);
            dal.close();

            return Dt;
        }

        public void UserPreInsert(int idcon,string UserName, string Password, string FrmName,bool Add,bool Edit,bool Delete,bool Print)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@idcon", SqlDbType.VarChar, 50);
            param[0].Value = idcon;
            param[1] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            param[1].Value = UserName;
            param[2] = new SqlParameter("@Password", SqlDbType.VarChar, 50);
            param[2].Value = Password;
            param[3] = new SqlParameter("@FrmName", SqlDbType.VarChar, 50);
            param[3].Value = FrmName;
            param[4] = new SqlParameter("@Add", SqlDbType.Bit);
            param[4].Value = Add;
            param[5] = new SqlParameter("@Edit", SqlDbType.Bit);
            param[5].Value = Edit;
            param[6] = new SqlParameter("@Delete", SqlDbType.Bit);
            param[6].Value = Delete;
            param[7] = new SqlParameter("@Print", SqlDbType.Bit);
            param[7].Value = Print;
            param[8] = new SqlParameter("@RegisterName", SqlDbType.VarChar, 50);
            param[8].Value = Properties.Settings.Default.UserName;

            dal.open();
            dal.ExecuteCommand("UserPreInsert", param);
            dal.close();
        }

        public void UserPreUpdate(int id, string FrmName, bool Add, bool Edit, bool Delete, bool Print)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;           
            param[1] = new SqlParameter("@FrmName", SqlDbType.VarChar, 50);
            param[1].Value = FrmName;
            param[2] = new SqlParameter("@Add", SqlDbType.Bit);
            param[2].Value = Add;
            param[3] = new SqlParameter("@Edit", SqlDbType.Bit);
            param[3].Value = Edit;
            param[4] = new SqlParameter("@Delete", SqlDbType.Bit);
            param[4].Value = Delete;
            param[5] = new SqlParameter("@Print", SqlDbType.Bit);
            param[5].Value = Print;
            param[6] = new SqlParameter("@RegisterName", SqlDbType.VarChar, 50);
            param[6].Value = Properties.Settings.Default.UserName;

            dal.open();
            dal.ExecuteCommand("UserPreUpdate", param);
            dal.close();
        }

        public void UserPreDeleteAll(int idcon)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@idcon", SqlDbType.Int);
            param[0].Value = idcon;
            dal.open();
            dal.ExecuteCommand("UserPreDeleteAll", param);
            dal.close();
        }

        public void UserPreDelete(int id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dal.open();
            dal.ExecuteCommand("UserPreDelete", param);
            dal.close();
        }

        //-------------------------------------------------------------------------
        //Design
        public DataTable DataDesign(TextBox UserId,TextBox UserName,TextBox Password,TextBox JopTitle,TextBox RegisterName,TextBox AddingTime,TextBox AddingDate)
        {
            DataTable dtUser = UserInfoSelecting();
            UserId.DataBindings.Clear();
            UserName.DataBindings.Clear();
            Password.DataBindings.Clear();
            JopTitle.DataBindings.Clear();
            RegisterName.DataBindings.Clear();
            AddingTime.DataBindings.Clear();
            AddingDate.DataBindings.Clear();

            UserId.DataBindings.Add("text", dtUser, "id");
            UserName.DataBindings.Add("text", dtUser, "UserName");
            Password.DataBindings.Add("text", dtUser, "Password");
            JopTitle.DataBindings.Add("text", dtUser, "JopTitle");
            RegisterName.DataBindings.Add("text", dtUser, "RegisterName");
            AddingTime.DataBindings.Add("text", dtUser, "AddingTime");
            AddingDate.DataBindings.Add("text", dtUser, "AddingDate");

            return dtUser;
        }

        public DataTable DataDesignPre(DataGridView Dgv, TextBox PreId, System.Windows.Forms.ComboBox FrmName,CheckBox Add,CheckBox Edit,CheckBox Delete,CheckBox Print,int id)
        {
            DataTable dtUser = UserPreSelecting(id);
           
                PreId.DataBindings.Clear();
                FrmName.DataBindings.Clear();
                Add.DataBindings.Clear();
                Edit.DataBindings.Clear();
                Delete.DataBindings.Clear();
                Print.DataBindings.Clear();

                Dgv.DataSource = null;
                Dgv.DataSource = dtUser;
                Dgv.Columns[0].Visible = false;
                Dgv.Columns[1].Visible = false;
                Dgv.Columns[2].Visible = false;
                Dgv.Columns[3].Visible = false;
                Dgv.Columns[4].HeaderText = "الواجهة";
                Dgv.Columns[5].HeaderText = "اضافة";
                Dgv.Columns[6].HeaderText = "تعديل";
                Dgv.Columns[7].HeaderText = "حذف";
                Dgv.Columns[8].HeaderText = "طباعة";
                Dgv.Columns[9].HeaderText = "مدخل البيانات";
                Dgv.Columns[10].HeaderText = "وقت الادخال";
                Dgv.Columns[11].HeaderText = "تاريخ الادخال";

                PreId.DataBindings.Add("text", dtUser, "id");
                FrmName.DataBindings.Add("text", dtUser, "FrmName");
                Add.DataBindings.Add("Checked", dtUser, "PerAdd");
                Edit.DataBindings.Add("Checked", dtUser, "PerEdit");
                Delete.DataBindings.Add("Checked", dtUser, "PerDelete");
                Print.DataBindings.Add("Checked", dtUser, "PrePrint");
           
            return dtUser;
        }

        //---------------------------------------------------------------------------
        //Forms

        public DataTable FormsNameselecting(System.Windows.Forms.ComboBox FrmName)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("FrmNameSelecting", null);
            dal.close();
            FrmName.Items.Clear();
            for(int i = 0; i < Dt.Rows.Count; i++)
            {
                FrmName.Items.Add(Dt.Rows[i][1].ToString());
            }

            return Dt;
        }

        public void FormsPre(SimpleButton Backup, SimpleButton Recovery, SimpleButton Deptcaars, SimpleButton RpCars, SimpleButton Departments, SimpleButton Stores,
            GunaButton QuickControl, SimpleButton Places,
            SimpleButton FuelEntry, GunaButton QuickFuelEntry, SimpleButton RpFuelEntry, SimpleButton FuelExit, GunaButton QuickFuelExit, SimpleButton FuelExitPlaces, 
            GunaButton QuickFuelExitPlaces, SimpleButton RpFuelExit, SimpleButton Controler, SimpleButton Setting, SimpleButton Users)
        {
            DataTable dt = UserPreSelecting(Properties.Settings.Default.UserId);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][4].ToString() == ("نسخة احتياطية"))
                    Backup.Enabled = true;

                if (dt.Rows[i][4].ToString() == ("استعادة نسخة احتياطية"))
                    Recovery.Enabled = true;

                if (dt.Rows[i][4].ToString() == ("عجلات القسم"))
                    Deptcaars.Enabled = true;

                if (dt.Rows[i][4].ToString() == ("تقارير العجلات"))
                    RpCars.Enabled = true;

                if (dt.Rows[i][4].ToString() == ("اقسام العتبة"))
                    Departments.Enabled = true;

                if (dt.Rows[i][4].ToString() == ("المخازن"))
                {
                    Stores.Enabled = true;
                   
                }

                if (dt.Rows[i][4].ToString() == ("مواقع العتبة"))
                    Places.Enabled = true;

                if (dt.Rows[i][4].ToString() == ("ادخال وقود"))
                {
                    FuelEntry.Enabled = true;
                    QuickFuelEntry.Enabled = true;
                }
                if (dt.Rows[i][4].ToString() == ("تقاربر ادخال وقود"))
                    RpFuelEntry.Enabled = true;

                if (dt.Rows[i][4].ToString() == ("اخراج وقود"))
                {
                    FuelExit.Enabled = true;
                    QuickFuelExit.Enabled = true;
                }
                if (dt.Rows[i][4].ToString() == ("اخراج وقود (مواقع)"))
                {
                    FuelExitPlaces.Enabled = true;
                    QuickFuelExitPlaces.Enabled = true;
                }
                if (dt.Rows[i][4].ToString() == ("تقارير اخراج وقود"))
                    RpFuelExit.Enabled = true;

                if (dt.Rows[i][4].ToString() == ("المراقبة"))
                {
                    Controler.Enabled = true;
                    QuickControl.Enabled = true;
                }
                if (dt.Rows[i][4].ToString() == ("اعدادات النظام"))
                    Setting.Enabled = true;

                if (dt.Rows[i][4].ToString() == ("المستخدمين"))
                    Users.Enabled = true;
            }
        }
        public void FrmBtnPre(string FrmName, SimpleButton New, SimpleButton Add, SimpleButton Edit, SimpleButton Delete, SimpleButton Print)
        {
            DataTable dt = UserPreSelecting(Properties.Settings.Default.UserId);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][4].ToString() == (FrmName))
                {
                    if (dt.Rows[i][5].ToString() == "True")
                    {
                        Add.Enabled = true;
                        New.Enabled = true;
                    }
                    if (dt.Rows[i][6].ToString() == "True")
                        Edit.Enabled = true;
                    if (dt.Rows[i][7].ToString() == "True")
                        Delete.Enabled = true;
                    if (dt.Rows[i][8].ToString() == "True")
                        Print.Enabled = true;
                    break;
                }
            }
        }

        public void FrmBtnPre(string FrmName,SimpleButton New, SimpleButton Add, SimpleButton Edit, SimpleButton Delete)
        {
            DataTable dt = UserPreSelecting(Properties.Settings.Default.UserId);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][4].ToString() == (FrmName))
                {

                    if (dt.Rows[i][5].ToString() == "True")
                    {
                        Add.Enabled = true;
                        New.Enabled = true;
                    }
                    if (dt.Rows[i][6].ToString() == "True")
                        Edit.Enabled = true;
                    if (dt.Rows[i][7].ToString() == "True")
                        Delete.Enabled = true;
                    break;
                }
            }
        }

        public void FrmBtnPre(string FrmName, ToolStripMenuItem Morfacat, ToolStripMenuItem Computer, ToolStripMenuItem Delete, ToolStripMenuItem Print)
        {
            DataTable dt = UserPreSelecting(Properties.Settings.Default.UserId);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][4].ToString() == (FrmName))
                {

                    if (dt.Rows[i][5].ToString() == "True")
                        Morfacat.Enabled = true;
                    if (dt.Rows[i][6].ToString() == "True")
                        Computer.Enabled = true;
                    if (dt.Rows[i][7].ToString() == "True")
                        Delete.Enabled = true;
                    if (dt.Rows[i][8].ToString() == "True")
                        Print.Enabled = true;
                    break;
                }
            }
        }
    }
}
