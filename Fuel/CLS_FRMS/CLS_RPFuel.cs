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
    class CLS_RPFuel
    {

        //Report for bill between tow date
        public DataTable FUEL_BillEntrayBetweenTowDate(string storename, DateTimePicker dt1, DateTimePicker dt2)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@storename", SqlDbType.VarChar, 50); param[0].Value = storename;
            param[1] = new SqlParameter("@Date1", SqlDbType.VarChar, 50); param[1].Value = dt1.Text;
            param[2] = new SqlParameter("@Date2", SqlDbType.VarChar, 50); param[2].Value = dt2.Text;
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("RPFUEL_BillEntryBetweentowdate", param);
            dal.close();
            return Dt;
        }
        //Report for bill by month
        public DataTable FUEL_BillEntrayByMonth(string storename, string month, DateTimePicker dt1, DateTimePicker dt2)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@storename", SqlDbType.VarChar, 50); param[0].Value = storename;
            param[1] = new SqlParameter("@month", SqlDbType.VarChar, 50); param[1].Value = month;
            param[2] = new SqlParameter("@Date1", SqlDbType.VarChar, 50); param[2].Value = dt1.Text;
            param[3] = new SqlParameter("@Date2", SqlDbType.VarChar, 50); param[3].Value = dt2.Text;
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("RPFUEL_BillEntryByMonth", param);
            dal.close();
            return Dt;
        }

        //-------------------------------------------------------------
        //Report bill exit between date
        public DataTable FUEL_BillExitBetweenTowDate(DateTimePicker dt1, DateTimePicker dt2, string FuelType)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Date1", SqlDbType.VarChar, 50); param[0].Value = dt1.Text;
            param[1] = new SqlParameter("@Date2", SqlDbType.VarChar, 50); param[1].Value = dt2.Text;
            param[2] = new SqlParameter("@storename", SqlDbType.VarChar, 50); param[2].Value = FuelType;
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("RPFUEL_BillExitBetweentowdate", param);
            dal.close();

            return Dt;
        }

        //---------------------------------------------------------------
        //Report bill exit departments between tow date
        public DataTable FUEL_BillEXitDeptBetweenTowDate(string Dept, string FuelType, DateTimePicker dt1, DateTimePicker dt2)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Dept", SqlDbType.VarChar, 50); param[0].Value = Dept;
            param[1] = new SqlParameter("@StoreName", SqlDbType.VarChar, 50); param[1].Value = FuelType;
            param[2] = new SqlParameter("@Date1", SqlDbType.VarChar, 50); param[2].Value = dt1.Text;
            param[3] = new SqlParameter("@Date2", SqlDbType.VarChar, 50); param[3].Value = dt2.Text;
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("RPFUEL_BillExitDeptBetweentowdate", param);
            dal.close();
            return Dt;
        }

        //--------------------------------------------------------------
        //Report bill exit departments summary
        public DataTable FUEL_BillEXitDeptsSummaryBetweenTowDate(string FuelType, DateTimePicker dt1, DateTimePicker dt2)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@StoreName", SqlDbType.VarChar, 50); param[0].Value = FuelType;
            param[1] = new SqlParameter("@Date1", SqlDbType.VarChar, 50); param[1].Value = dt1.Text;
            param[2] = new SqlParameter("@Date2", SqlDbType.VarChar, 50); param[2].Value = dt2.Text;
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("RPFUEL_BillExitDeptsSummaryBetweentowdate", param);
            dal.close();
            return Dt;
        }

        //--------------------------------------------------------------
        //Report bill exit departments Invest summary
        public DataTable FUEL_BillEXitDeptsInvestSummaryBetweenTowDate(string FuelType,bool invest, DateTimePicker dt1, DateTimePicker dt2)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@StoreName", SqlDbType.VarChar, 50); param[0].Value = FuelType;
            param[1] = new SqlParameter("@DeprInvest", SqlDbType.VarChar, 50); param[1].Value = invest;
            param[2] = new SqlParameter("@Date1", SqlDbType.VarChar, 50); param[2].Value = dt1.Text;
            param[3] = new SqlParameter("@Date2", SqlDbType.VarChar, 50); param[3].Value = dt2.Text;
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("RPFUEL_BillExitDeptsInvestSummaryBetweentowdate", param);
            dal.close();
            return Dt;
        } 
        //-----------------------------------------------------------
        //Report bill exit for car between tow date
        public DataTable FUEL_BillEXitCarBetweenTowDate(string carNo, DateTimePicker dt1, DateTimePicker dt2)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@CarNO", SqlDbType.VarChar, 50); param[0].Value = carNo;
            param[1] = new SqlParameter("@Date1", SqlDbType.VarChar, 50); param[1].Value = dt1.Text;
            param[2] = new SqlParameter("@Date2", SqlDbType.VarChar, 50); param[2].Value = dt2.Text;
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("RPFUEL_BillExitCarBetweentowdate", param);
            dal.close();
            return Dt;
        }

        //-----------------------------------------------------------
        //Report bill exit for car summary between tow date
        public DataTable FUEL_BillEXitCarsSummaryBetweenTowDate(string FuelType, DateTimePicker dt1, DateTimePicker dt2)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@StoreName", SqlDbType.VarChar, 50); param[0].Value = FuelType;
            param[1] = new SqlParameter("@Date1", SqlDbType.VarChar, 50); param[1].Value = dt1.Text;
            param[2] = new SqlParameter("@Date2", SqlDbType.VarChar, 50); param[2].Value = dt2.Text;
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("RPFUEL_BillExitCarsSummaryBetweentowdate", param);
            dal.close();
            return Dt;
        }

        //---------------------------------------------------------
        //Report For Fuel Exit By Places

        //-------------------------------------------------------------
        //Report bill exit place between date
        public DataTable FUEL_BillExitPlaceBetweenTowDate(DateTimePicker dt1, DateTimePicker dt2, string FuelType)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Date1", SqlDbType.VarChar, 50); param[0].Value = dt1.Text;
            param[1] = new SqlParameter("@Date2", SqlDbType.VarChar, 50); param[1].Value = dt2.Text;
            param[2] = new SqlParameter("@storename", SqlDbType.VarChar, 50); param[2].Value = FuelType;
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("RPFUEL_BillExitPlaceBetweentowdate", param);
            dal.close();

            return Dt;
        }
        //Report bill exit place by month
        public DataTable FUEL_BillExitPlaceByMonth(DateTimePicker dt1, DateTimePicker dt2, string FuelType, string month)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Date1", SqlDbType.VarChar, 50); param[0].Value = dt1.Text;
            param[1] = new SqlParameter("@Date2", SqlDbType.VarChar, 50); param[1].Value = dt2.Text;
            param[2] = new SqlParameter("@storename", SqlDbType.VarChar, 50); param[2].Value = FuelType;
            param[3] = new SqlParameter("@month", SqlDbType.VarChar, 50); param[3].Value = month;
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("RPFUEL_BillExitPlaceByMonth", param);
            dal.close();

            return Dt;
        }

        //---------------------------------------------------------------
        //Report bill exit place departments between tow date
        public DataTable FUEL_BillEXitPlaceDeptBetweenTowDate(string Dept, string FuelType, DateTimePicker dt1, DateTimePicker dt2)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Dept", SqlDbType.VarChar, 50); param[0].Value = Dept;
            param[1] = new SqlParameter("@StoreName", SqlDbType.VarChar, 50); param[1].Value = FuelType;
            param[2] = new SqlParameter("@Date1", SqlDbType.VarChar, 50); param[2].Value = dt1.Text;
            param[3] = new SqlParameter("@Date2", SqlDbType.VarChar, 50); param[3].Value = dt2.Text;
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("RPFUEL_BillExitPlaceDeptBetweentowdate", param);
            dal.close();
            return Dt;
        }

        //--------------------------------------------------------------
        //Report bill exit place departments summary
        public DataTable FUEL_BillEXitPlaceDeptsSummaryBetweenTowDate(string FuelType, DateTimePicker dt1, DateTimePicker dt2)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@StoreName", SqlDbType.VarChar, 50); param[0].Value = FuelType;
            param[1] = new SqlParameter("@Date1", SqlDbType.VarChar, 50); param[1].Value = dt1.Text;
            param[2] = new SqlParameter("@Date2", SqlDbType.VarChar, 50); param[2].Value = dt2.Text;
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("RPFUEL_BillExitPlaceDeptsSummaryBetweentowdate", param);
            dal.close();
            return Dt;
        }

        //--------------------------------------------------------------
        //Report bill exit place departments Invest summary
        public DataTable FUEL_BillEXitPlaceDeptsInvestSummaryBetweenTowDate(string FuelType, bool invest, DateTimePicker dt1, DateTimePicker dt2)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@StoreName", SqlDbType.VarChar, 50); param[0].Value = FuelType;
            param[1] = new SqlParameter("@DeptInvest", SqlDbType.Bit); param[1].Value = invest;
            param[2] = new SqlParameter("@Date1", SqlDbType.VarChar, 50); param[2].Value = dt1.Text;
            param[3] = new SqlParameter("@Date2", SqlDbType.VarChar, 50); param[3].Value = dt2.Text;
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("RPFUEL_BillExitPlaceDeptsInvestSummaryBetweentowdate", param);
            dal.close();
            return Dt;
        }
        //-----------------------------------------------------------
        //Report bill exit  for place between tow date
        public DataTable FUEL_BillEXitPlacesBetweenTowDate(string carNo, DateTimePicker dt1, DateTimePicker dt2)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@place", SqlDbType.VarChar, 50); param[0].Value = carNo;
            param[1] = new SqlParameter("@Date1", SqlDbType.VarChar, 50); param[1].Value = dt1.Text;
            param[2] = new SqlParameter("@Date2", SqlDbType.VarChar, 50); param[2].Value = dt2.Text;
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("RPFUEL_BillExitPlacesBetweentowdate", param);
            dal.close();
            return Dt;
        }

        //-----------------------------------------------------------
        //Report bill exit for place summary between tow date
        public DataTable FUEL_BillEXitPlaceSummaryBetweenTowDate(string FuelType, DateTimePicker dt1, DateTimePicker dt2)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@store", SqlDbType.VarChar, 50); param[0].Value = FuelType;
            param[1] = new SqlParameter("@Date1", SqlDbType.VarChar, 50); param[1].Value = dt1.Text;
            param[2] = new SqlParameter("@Date2", SqlDbType.VarChar, 50); param[2].Value = dt2.Text;
            DataTable Dt = new DataTable();
            Dt = dal.SelectingData("RPFUEL_BillExitPlacesSummaryBetweentowdate", param);
            dal.close();
            return Dt;
        }


        //---------------------------------------------------------
        //design datagrid view for report
        public void Dgvdesign(DataGridView Dgv, DataTable Dt, ComboBox cbo, string RPtype)
        {
            Dgv.DataSource = Dt;
            if (RPtype == "ادخال")
            {
                switch (cbo.Text)
                {
                    case "فواتير بين تاريخين":

                        Dgv.DataSource = Dt;

                        Dgv.Columns[0].HeaderText = "رقم الفاتورة";
                        Dgv.Columns[1].HeaderText = "نوع الوقود";
                        Dgv.Columns[2].HeaderText = "الكمية لتر";
                        Dgv.Columns[3].HeaderText = "تاريخ الاستلام";
                        Dgv.Columns[4].HeaderText = "وقت الاستلام";
                        Dgv.Columns[5].HeaderText = "رقم العجلة";
                        Dgv.Columns[6].HeaderText = "نوع العجلة";
                        Dgv.Columns[7].HeaderText = "اسم السائق";
                        Dgv.Columns[8].HeaderText = "حصة شهر";
                        Dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                        break;
                    case "فواتير حسب الشهر":

                        Dgv.DataSource = Dt;

                        Dgv.Columns[0].HeaderText = "رقم الفاتورة";
                        Dgv.Columns[1].HeaderText = "نوع الوقود";
                        Dgv.Columns[2].HeaderText = "الكمية لتر";
                        Dgv.Columns[3].HeaderText = "تاريخ الاستلام";
                        Dgv.Columns[4].HeaderText = "وقت الاستلام";
                        Dgv.Columns[5].HeaderText = "رقم العجلة";
                        Dgv.Columns[6].HeaderText = "نوع العجلة";
                        Dgv.Columns[7].HeaderText = "اسم السائق";
                        Dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                        break;


                }
            }
            else if (RPtype == "اخراج")
            {
                switch (cbo.Text)
                {
                    case "فواتير بين تاريخين (عجلات)":
                    case "طباعة سلسلة فواتير تجهز عجلات بالوقود بين تاريخين":
                        Dgv.DataSource = Dt;
                        Dgv.Columns[0].HeaderText = "رقم الفاتورة";
                        Dgv.Columns[1].HeaderText = "تاريخ الفاتورة";
                        Dgv.Columns[2].HeaderText = "رقم العجلة";
                        Dgv.Columns[3].HeaderText = "نوع العجلة";
                        Dgv.Columns[4].HeaderText = "الكمية";
                        Dgv.Columns[5].HeaderText = "الجهة المستفيدة";
                        Dgv.Columns[6].HeaderText = "سعر اللتر";
                        Dgv.Columns[7].HeaderText = "المبلغ الكلي";
                        Dgv.Columns[8].Visible = false;
                        Dgv.Columns[9].HeaderText = "حصة شهر";
                        Dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                        break;

                    case "فواتير قسم بين تاريخين (عجلات)":

                        Dgv.DataSource = Dt;
                        Dgv.Columns[0].HeaderText = "رقم الفاتورة";
                        Dgv.Columns[1].HeaderText = "تاريخ الفاتورة";
                        Dgv.Columns[2].HeaderText = "رقم العجلة";
                        Dgv.Columns[3].HeaderText = "نوع العجلة";
                        Dgv.Columns[4].HeaderText = "الكمية";
                        Dgv.Columns[5].HeaderText = "سعر اللتر";
                        Dgv.Columns[6].HeaderText = "المبلغ الكلي";
                        Dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                        break;


                    case "صرفيات عجلة بين تاريخين (عجلات)":

                        Dgv.DataSource = Dt;
                        Dgv.Columns[0].HeaderText = "رقم الفاتورة";
                        Dgv.Columns[1].HeaderText = "تاريخ الفاتورة";
                        Dgv.Columns[2].HeaderText = "الكمية";
                        Dgv.Columns[3].HeaderText = "اسم السائق";
                        Dgv.Columns[4].HeaderText = "الجهة المستفيدة";
                        Dgv.Columns[5].HeaderText = "سعر اللتر";
                        Dgv.Columns[6].HeaderText = "المبلغ الكلي";
                        Dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                        break;

                    case "خلاصة عجلات بين تاريخين (عجلات)":

                        Dgv.DataSource = Dt;
                        Dgv.Columns[0].HeaderText = "رقم العجلة";
                        Dgv.Columns[1].HeaderText = "نوع العجلة";
                        Dgv.Columns[2].HeaderText = "الجهة المستفيدة";
                        Dgv.Columns[3].HeaderText = "الكمية";
                        
                        Dgv.Columns[4].HeaderText = "المبلغ الكلي";
                        Dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                        break;

                    //----------------------------------------------------------------------

                    case "فواتير بين تاريخين (مواقع)":
                    case "طباعة سلسلة فواتير تجهز المواقع بالوقود بين تاريخين":
                        Dgv.DataSource = Dt;
                        Dgv.Columns[0].HeaderText = "رقم الفاتورة";
                        Dgv.Columns[1].HeaderText = "تاريخ الفاتورة";
                        Dgv.Columns[2].HeaderText = "الموقع";                     
                        Dgv.Columns[3].HeaderText = "الكمية";
                        Dgv.Columns[4].HeaderText = "الجهة المستفيدة";
                        Dgv.Columns[5].HeaderText = "سعر اللتر";
                        Dgv.Columns[6].HeaderText = "المبلغ الكلي";
                        Dgv.Columns[7].Visible = false;
                        Dgv.Columns[8].HeaderText = "حصة شهر";
                        Dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                        break;

                    case "فواتير حسب الشهر (مواقع)":
                        Dgv.DataSource = Dt;
                        Dgv.Columns[0].HeaderText = "رقم الفاتورة";
                        Dgv.Columns[1].HeaderText = "تاريخ الفاتورة";
                        Dgv.Columns[2].HeaderText = "الموقع";
                        Dgv.Columns[3].HeaderText = "الكمية";
                        Dgv.Columns[4].HeaderText = "الجهة المستفيدة";
                        Dgv.Columns[5].HeaderText = "سعر اللتر";
                        Dgv.Columns[6].HeaderText = "المبلغ الكلي";
                        Dgv.Columns[7].Visible = false;
                        Dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                        break;

                    case "فواتير قسم بين تاريخين (مواقع)":

                        Dgv.DataSource = Dt;
                        Dgv.Columns[0].HeaderText = "رقم الفاتورة";
                        Dgv.Columns[1].HeaderText = "تاريخ الفاتورة";
                        Dgv.Columns[2].HeaderText = "الموقع";
                        Dgv.Columns[3].HeaderText = "الكمية";
                        Dgv.Columns[4].HeaderText = "سعر اللتر";
                        Dgv.Columns[5].HeaderText = "المبلغ الكلي";
                        Dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                        break;


                    case "صرفيات موقع بين تاريخين (مواقع)":

                        Dgv.DataSource = Dt;
                        Dgv.Columns[0].HeaderText = "رقم الفاتورة";
                        Dgv.Columns[1].HeaderText = "تاريخ الفاتورة";
                        Dgv.Columns[2].HeaderText = "نوع الوقود";
                        Dgv.Columns[3].HeaderText = "الكمية";                        
                        Dgv.Columns[4].HeaderText = "الجهة المستفيدة";
                        Dgv.Columns[5].HeaderText = "سعر اللتر";
                        Dgv.Columns[6].HeaderText = "المبلغ الكلي";
                        Dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                        break;

                   
                    default:
                        Dgv.DataSource = Dt;
                        Dgv.Columns[0].HeaderText = "الجهة المستفيدة";
                        Dgv.Columns[1].HeaderText = "الكمية";
                       
                        Dgv.Columns[2].HeaderText = "المبلغ الكلي";
                        Dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                        break;
                }
            }
        }
    
        public string mounthWord(int MounthNum)
        {
            string mounth = null;
            switch (MounthNum)
            {
                case 1: mounth= "كانون الثاني";
                    break;
                case 2:
                    mounth = "شباط";
                    break;
                case 3:
                    mounth = "أذار";
                    break;
                case 4:
                    mounth = "نيسان";
                    break;
                case 5:
                    mounth = "أيار";
                    break;
                case 6:
                    mounth = "حزيران";
                    break;
                case 7:
                    mounth = "تموز";
                    break;
                case 8:
                    mounth = "أب";
                    break;
                case 9:
                    mounth = "ايلول";
                    break;
                case 10:
                    mounth = "تشرين الاول";
                    break;
                case 11:
                    mounth = "تشرين الثاني";
                    break;
                case 12:
                    mounth = "كانون الاول";
                    break;
            }
            return mounth;
        }
    }
}
