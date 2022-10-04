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
    class CLS_Car
    {

        public DataTable GetDataCar()//---------------------------------جلب بيانات جدول العجلات
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("CarsSelecting", null);
            dal.close();

            return Dt;
        }
        public void CarInsertInfo(string CarNo, string CarType, string CarFuel, string TheBenficary, string CarDivision)// -----------ادخال بيانات الى جدول العجلات
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@CarNo", SqlDbType.VarChar, 50);
            param[0].Value = CarNo;
            param[1] = new SqlParameter("@CarType", SqlDbType.VarChar, 50);
            param[1].Value = CarType;
            param[2] = new SqlParameter("@CarFuel", SqlDbType.VarChar, 50);
            param[2].Value = CarFuel;
            param[3] = new SqlParameter("@TheBenficary", SqlDbType.VarChar, 50);
            param[3].Value = TheBenficary;
            param[4] = new SqlParameter("@CarDivision", SqlDbType.VarChar, 50);
            param[4].Value = CarDivision;
            param[5] = new SqlParameter("@RegisterName", SqlDbType.VarChar, 50);
            param[5].Value = Properties.Settings.Default.UserName;
            dal.open();
            dal.ExecuteCommand("CarsInsert", param);
            dal.close();
           
        }
        public void CarUpdateInfo(int id, string CarNo, string CarType, string CarFuel, string TheBenficary, string CarDivision)//------تحديث بيانات جدول العجلات
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@CarNo", SqlDbType.VarChar, 50);
            param[1].Value = CarNo;
            param[2] = new SqlParameter("@CarType", SqlDbType.VarChar, 50);
            param[2].Value = CarType;
            param[3] = new SqlParameter("@CarFuel", SqlDbType.VarChar, 50);
            param[3].Value = CarFuel;
            param[4] = new SqlParameter("@TheBenficary", SqlDbType.VarChar, 50);
            param[4].Value = TheBenficary;
            param[5] = new SqlParameter("@CarDivision", SqlDbType.VarChar, 50);
            param[5].Value = CarDivision;
            param[6] = new SqlParameter("@RegisterName", SqlDbType.VarChar, 50);
            param[6].Value = Properties.Settings.Default.UserName;
            dal.open();
            dal.ExecuteCommand("CarsUpdate", param);
            dal.close();
           
        }
        public void CarDeleting(int ID)//--------الحذف من جدول العجلات
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = ID;
            dal.open();
            dal.ExecuteCommand("CarsDeleting", param);
            dal.close();
            
        }

        public DataTable CarDesign(DataGridView Dgv, TextBox id, TextBox CarNo, TextBox CarType,ComboBox CarFuel,ComboBox TheBenficary, ComboBox CarDivision)
        {
            id.DataBindings.Clear();
            CarNo.DataBindings.Clear();
            CarType.DataBindings.Clear();
            CarFuel.DataBindings.Clear();
            TheBenficary.DataBindings.Clear();
            CarDivision.DataBindings.Clear();
            Dgv.DataSource = null;

            DataTable dt = GetDataCar();

            Dgv.DataSource = dt;
            Dgv.Columns[0].Visible = false;
            Dgv.Columns[1].HeaderText = "رقم العجلة";
            Dgv.Columns[2].HeaderText = "نوع العجلة";
            Dgv.Columns[3].HeaderText = "نوع الوقود";
            Dgv.Columns[4].HeaderText = "عائدية العجلة";
            Dgv.Columns[5].Visible = false;
            Dgv.Columns[6].Visible = false;
            Dgv.Columns[7].Visible = false;
            Dgv.Columns[8].HeaderText = "الشعبة";

            id.DataBindings.Add("text", dt, "id");
            CarNo.DataBindings.Add("text", dt, "CarNo");
            CarType.DataBindings.Add("text", dt, "CarType");
            CarFuel.DataBindings.Add("text", dt, "CarFuel");
            TheBenficary.DataBindings.Add("text", dt, "TheBenficary");
            CarDivision.DataBindings.Add("text", dt, "CarDivision");

            return dt;
        }

        //====================================================================================================


        //==Report of Cars

        //===========================

        //=== This Function Below for get Cars info. by Car Type from Cars Table....
        public DataTable SelectCarsByCarType(string CarType)
        {
            DAL.DataAccessLayer GettingData = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CarType", SqlDbType.VarChar, 50); param[0].Value = CarType;

            GettingData.open();
            DataTable Dt = GettingData.SelectingData("RPCar_CarType", param);
            GettingData.close();
            return Dt;
        }

        //====================================================================================================

        //=== This Function Below for get Cars info. by Car Department from Cars table....
        public DataTable SelectCarsByCarDep(string CarDep)
        {
            DAL.DataAccessLayer GettingData = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CarDep", SqlDbType.VarChar, 50); param[0].Value = CarDep;

            GettingData.open();
            DataTable Dt = GettingData.SelectingData("RPCar_CarDep", param);
            GettingData.close();
            return Dt;
        }

        //====================================================================================================

        //=== This Function Below for get Cars info. by Car Division from Cars table....
        public DataTable SelectCarsByCarDivision(string CarDivision)
        {
            DAL.DataAccessLayer GettingData = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CarDivision", SqlDbType.VarChar, 50); param[0].Value = CarDivision;

            GettingData.open();
            DataTable Dt = GettingData.SelectingData("RPCar_CarDivision", param);
            GettingData.close();
            return Dt;
        }

        //====================================================================================================


        //=== This Function Below for get Cars info. by Car Fuel Type from DivisionCars....
        public DataTable SelectCarsByCarFuel(string CarFuel)
        {
            DAL.DataAccessLayer GettingData = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CarFuel", SqlDbType.VarChar, 50); param[0].Value = CarFuel;

            GettingData.open();
            DataTable Dt = GettingData.SelectingData("RPCar_Carfuel", param);
            GettingData.close();
            return Dt;
        }

        //====================================================================================================

        //=== This Function Below for get Cars info. by car Type and Car Department from DivisionCars....
        public DataTable SelectCarsByCarTypeandDep(string CarType, string CarDep)
        {
            DAL.DataAccessLayer GettingData = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@CarType", SqlDbType.VarChar, 50); param[0].Value = CarType;
            param[1] = new SqlParameter("@CarDep", SqlDbType.VarChar, 50); param[1].Value = CarDep;

            GettingData.open();
            DataTable Dt = GettingData.SelectingData("RPCar_CarTypeandDep", param);
            GettingData.close();
            return Dt;
        }

        //====================================================================================================


        //=== This Function Below for get Summary Cars info. by car Type from DivisionCars....
        public DataTable SummryCarType(string CarType)
        {
            DAL.DataAccessLayer GettingData = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CarType", SqlDbType.VarChar, 50); param[0].Value = CarType;

            GettingData.open();
            DataTable Dt = GettingData.SelectingData("RPCar_SummryCarByType", param);
            GettingData.close();
            return Dt;
        }

        //====================================================================================================


        //=== This Function Below for get Summary Cars info. by car Department from DivisionCars....
        public DataTable SummryCarDEpartment()
        {
            DAL.DataAccessLayer GettingData = new DAL.DataAccessLayer();
            GettingData.open();
            DataTable Dt = GettingData.SelectingData("RPCar_SummryCarByDepartment", null);
            GettingData.close();
            return Dt;
        }

        //====================================================================================================

        //design datagrid view for report
        public void Dgvdesign(DataGridView Dgv, DataTable Dt, ComboBox cbo)
        {
            Dgv.DataSource = Dt;
            switch (cbo.Text)
            {
                case "حسب نوع العجلة":
                    Dgv.Columns[0].HeaderText = "رقم السيارة";
                    Dgv.Columns[1].HeaderText = "نوع الوقود";
                    Dgv.Columns[2].HeaderText = "العائدية";
                    break;
               case "حسب عائدية العجلة":
                    Dgv.Columns[0].HeaderText = "رقم السيارة";
                    Dgv.Columns[1].HeaderText = "نوع السيارة";
                    Dgv.Columns[2].HeaderText = "نوع الوقود";
                    
                    break;
                case "حسب الشعبة":
                    Dgv.Columns[0].HeaderText = "رقم السيارة";
                    Dgv.Columns[1].HeaderText = "نوع السيارة";
                    Dgv.Columns[2].HeaderText = "نوع الوقود";
                    Dgv.Columns[3].HeaderText = "العائدية";
                    break;
                case "حسب نوع الوقود":
                    Dgv.Columns[0].HeaderText = "رقم السيارة";
                    Dgv.Columns[1].HeaderText = "نوع السيارة";
                    Dgv.Columns[2].HeaderText = "العائدية";
                    break;
                case "حسب نوع العجلة والعائدية":
                    Dgv.Columns[0].HeaderText = "رقم السيارة";
                    Dgv.Columns[1].HeaderText = "نوع الوقود";
                    break;
                case "خلاصة حسب نوع العجلة":
                    Dgv.Columns[0].HeaderText = "عائدية العجلة";
                    Dgv.Columns[1].HeaderText = "العدد";
                    break;
                case "خلاصة حسب العائدية":
                    Dgv.Columns[0].HeaderText = "العائدية";
                    Dgv.Columns[1].HeaderText = "نوع العجلة";
                    Dgv.Columns[2].HeaderText = "العدد";
                    break;
            }

            Dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }


    }
}
