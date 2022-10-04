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
    class CLS_Department
    {
        public DataTable GetDataDepartment()//---------------------------------جلب بيانات جدول الاقسام
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("DepartmentsSelecting", null);
            dal.close();

            return Dt;
        }
        public void insertintoDepartments(string tbnamedepartment, bool DeptInvest)// -----------ادخال بيانات الى جدول الاقسام
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@DepartmentName", SqlDbType.VarChar, 500);
            param[0].Value = tbnamedepartment;
            param[1] = new SqlParameter("@DepartmentInvest", SqlDbType.Bit);
            param[1].Value = DeptInvest;
            param[2] = new SqlParameter("@RegisterName", SqlDbType.VarChar, 50);
            param[2].Value = Properties.Settings.Default.UserName;
            dal.open();
            dal.ExecuteCommand("DepartmentsInsertinto", param);
            dal.close();
            GetDataDepartment();

        }
        public void DepartmentsUpdatedata(int id, string tbnamedepartment, bool DeptInvest)//------تحديث بيانات جدول الاقسام
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@DepartmentName", SqlDbType.VarChar, 500);
            param[1].Value = tbnamedepartment;
            param[2] = new SqlParameter("@DepartmentInvest", SqlDbType.Bit);
            param[2].Value = DeptInvest;
            param[3] = new SqlParameter("@RegisterName", SqlDbType.VarChar, 50);
            param[3].Value = Properties.Settings.Default.UserName;
            dal.open();
            dal.ExecuteCommand("DepartmentsUpdate", param);
            dal.close();
            GetDataDepartment();

        }
        public void DepartmentsDeleting(int ID)//--------الحذف من جدول الاقسام
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            dal.open();
            dal.ExecuteCommand("DepartmentsDeleting", param);
            dal.close();
            GetDataDepartment();
        }

        public DataTable DeptDesign(DataGridView Dgv,TextBox id,TextBox DeptName,CheckBox DeptInvest)
        {
            id.DataBindings.Clear();
            DeptName.DataBindings.Clear();
            DeptInvest.DataBindings.Clear();
            Dgv.DataSource = null;

            DataTable dt = GetDataDepartment();

            Dgv.DataSource = dt;
            Dgv.Columns[0].Visible = false;
            Dgv.Columns[1].HeaderText = "القسم";
            Dgv.Columns[2].HeaderText = "الجهات الاستثمارية";
            Dgv.Columns[3].Visible = false;
            Dgv.Columns[4].Visible = false;
            Dgv.Columns[5].Visible = false;

            id.DataBindings.Add("text", dt, "id");
            DeptName.DataBindings.Add("text", dt, "DepartmentName");
            DeptInvest.DataBindings.Add("checked", dt, "DepartmentInvest");

            return dt;
        }

        //=======================================================================================================
        //attaba Places

        public DataTable GetDataPlaces()//---------------------------------جلب بيانات جدول المواقع
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("PlacesSelecting", null);
            dal.close();

            return Dt;
        }

        public DataTable GetDataPlacesByDept(string dept)//---------------------------------جلب بيانات جدول المواقع بواسطة القسم 
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Dept", SqlDbType.VarChar,50);
            param[0].Value = dept;
            dal.open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("PlacesSelectingByIdCon", param);
            dal.close();

            return Dt;
        }
        public void insertintoPlaces(int idcon,string Dept, string Place, bool PlaceInvest)// -----------ادخال بيانات الى جدول المواقع
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@idcon", SqlDbType.Int);
            param[0].Value = idcon;
            param[1] = new SqlParameter("@Dept", SqlDbType.VarChar, 500);
            param[1].Value = Dept;
            param[2] = new SqlParameter("@Place", SqlDbType.VarChar, 500);
            param[2].Value = Place;
            param[3] = new SqlParameter("@PlaceInvest", SqlDbType.Bit);
            param[3].Value = PlaceInvest;
            param[4] = new SqlParameter("@RegisterName", SqlDbType.VarChar, 50);
            param[4].Value = Properties.Settings.Default.UserName;
            dal.open();
            dal.ExecuteCommand("PlacesInsert", param);
            dal.close();
            GetDataDepartment();

        }
        public void UpdatedataPlaces(int id, int idcon,string Dept, string Place, bool PlaceInvest)//------تحديث بيانات جدول المواقع
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@idcon", SqlDbType.Int);
            param[1].Value = idcon;
            param[2] = new SqlParameter("@Dept", SqlDbType.VarChar, 500);
            param[2].Value = Dept;
            param[3] = new SqlParameter("@Place", SqlDbType.VarChar,500);
            param[3].Value = Place;
            param[4] = new SqlParameter("@PlaceInvest", SqlDbType.Bit);
            param[4].Value = PlaceInvest;
            param[5] = new SqlParameter("@RegisterName", SqlDbType.VarChar, 50);
            param[5].Value = Properties.Settings.Default.UserName;
            dal.open();
            dal.ExecuteCommand("PlacesUpdate", param);
            dal.close();
            GetDataDepartment();

        }
        public void DeletingPlaces(int ID)//--------الحذف من جدول المواقع
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = ID;
            dal.open();
            dal.ExecuteCommand("PlacesDelete", param);
            dal.close();
            GetDataDepartment();
        }

        public DataTable DesignPlaces(DataGridView Dgv, TextBox id, ComboBox DeptName, TextBox place, TextBox RegisterName, TextBox AddintTime, TextBox AddingDate, CheckBox PlaceInvest)//--------عرض بيانات جدول المواقع
        {
            id.DataBindings.Clear();
            DeptName.DataBindings.Clear();
            place.DataBindings.Clear();
            RegisterName.DataBindings.Clear();
            AddintTime.DataBindings.Clear();
            AddingDate.DataBindings.Clear();
            PlaceInvest.DataBindings.Clear();
            Dgv.DataSource = null;

            DataTable dt = GetDataPlaces();

            Dgv.DataSource = dt;
            Dgv.Columns[0].Visible = false;
            Dgv.Columns[1].Visible = false;
            Dgv.Columns[2].HeaderText = "الموقع";
            Dgv.Columns[3].Visible = false;
            Dgv.Columns[4].Visible = false;
            Dgv.Columns[5].Visible = false;
            Dgv.Columns[6].HeaderText = "القسم";
            Dgv.Columns[7].HeaderText = "جهة استثمارية";

            id.DataBindings.Add("text", dt, "id");
            DeptName.DataBindings.Add("text", dt, "Department");
            place.DataBindings.Add("text", dt, "Place");
            RegisterName.DataBindings.Add("text", dt, "RegisterName");
            AddintTime.DataBindings.Add("text", dt, "AddingTime");
            AddingDate.DataBindings.Add("text", dt, "AddingDate");
            PlaceInvest.DataBindings.Add("checked", dt, "PlaceInvest");
            return dt;
        }
    }
}
