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
using DevExpress.XtraReports.UI;

namespace Fuel.FRMS
{
    public partial class FRMRPFUEL : DevExpress.XtraEditors.XtraForm
    {
        string RPNAME;
        public FRMRPFUEL(string RPNAME)
        {
            InitializeComponent();
            this.RPNAME = RPNAME;
        }

        private void gunaButton12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMRPFUEL_Load(object sender, EventArgs e)
        {
            lblSystemName.Text = RPNAME;
            if (RPNAME == "تقارير اخراج وقود")
            {
                string[] s = { "فواتير بين تاريخين (عجلات)", "فواتير قسم بين تاريخين (عجلات)", "خلاصة صرفيات الاقسام بين تاريخين (عجلات)", "صرفيات عجلة بين تاريخين (عجلات)", "خلاصة عجلات بين تاريخين (عجلات)","خلاصة صرفيات الجهات الاستثمارية (عجلات)", "خلاصة صرفيات الجهات غير الاستثمارية (عجلات)" , "طباعة سلسلة فواتير تجهز عجلات بالوقود بين تاريخين" };
                for (int i = 0; i < s.Length; i++)
                {
                    cbxRpType.Items.Add(s[i]);
                }
                string[] s_place = { "فواتير بين تاريخين (مواقع)", "فواتير حسب الشهر (مواقع)", "فواتير قسم بين تاريخين (مواقع)", "خلاصة صرفيات الاقسام بين تاريخين (مواقع)", "صرفيات موقع بين تاريخين (مواقع)", "خلاصة مواقع بين تاريخين (مواقع)", "خلاصة صرفيات الجهات الاستثمارية (مواقع)", "خلاصة صرفيات الجهات غير الاستثمارية (مواقع)", "طباعة سلسلة فواتير تجهز المواقع بالوقود بين تاريخين" };
                for (int i = 0; i < s_place.Length; i++)
                {
                    cbxRpType.Items.Add(s_place[i]);
                }
            }
            if (RPNAME == "تقارير ادخال وقود")
            {
                string[] s = { "فواتير بين تاريخين", "فواتير حسب الشهر" };
                for (int i = 0; i < s.Length; i++)
                {
                    cbxRpType.Items.Add(s[i]);
                }
            }
        }

        private void cbxRpType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxRpType.Text)
            {
                case "فواتير بين تاريخين":
                case "طباعة سلسلة فواتير تجهز عجلات بالوقود بين تاريخين":
                    lblFirstInput.Text = "اسم المخزن";
                    cbxFirstInput.DataSource = null;
                    cbxSecondInput.DataSource = null;
                    cbxSecondInput.Visible = false;
                    lblSecondInput.Visible = false;
                    cbxFirstInput.Text = null;
                    cbxSecondInput.Text = null;
                    cbxFirstInput.Items.Clear();
                    CLS_FRMS.CLS_Store Getdata = new CLS_FRMS.CLS_Store();
                    DataTable dt = Getdata.GetDataStore();
                    for (int i = 0; i < dt.Rows.Count; i++) { cbxFirstInput.Items.Add(dt.Rows[i][1].ToString()); }


                    break;
                case "فواتير حسب الشهر":
                    lblFirstInput.Text = "اسم المخزن";
                    lblSecondInput.Text = "الشهر";
                    cbxFirstInput.DataSource = null;
                    cbxSecondInput.DataSource = null;
                    cbxSecondInput.Visible = true;
                    lblSecondInput.Visible = true;
                    cbxFirstInput.Text = null;
                    cbxSecondInput.Text = null;
                    cbxFirstInput.Items.Clear();
                    cbxSecondInput.Items.Clear();
                    CLS_FRMS.CLS_Store Getdatamonth = new CLS_FRMS.CLS_Store();
                    DataTable dtmonth = Getdatamonth.GetDataStore();
                    for (int i = 0; i < dtmonth.Rows.Count; i++) { cbxFirstInput.Items.Add(dtmonth.Rows[i][1].ToString()); }
                    string[] s_place = { "كانون الثاني", "شباط", "آذار", "نيسان", "أيار", "حزيران", "تموز", "آب", "أيلول", "تشرين الأول", "تشرين الثاني", "كانون الأول", "كمية دوار" };
                    for (int i = 0; i < s_place.Length; i++)
                    {
                        cbxSecondInput.Items.Add(s_place[i]);
                    }

                    break;
                case "فواتير قسم بين تاريخين (عجلات)":
               
                    cbxFirstInput.DataSource = null;
                    cbxSecondInput.DataSource = null;
                    lblFirstInput.Text = "القسم:";
                    cbxSecondInput.Visible = true;
                    lblSecondInput.Visible = true;
                    cbxFirstInput.Text = null;
                    cbxSecondInput.Text = null;
                    lblSecondInput.Text = "اسم المخزن:";
                    cbxFirstInput.Items.Clear();
                    CLS_FRMS.CLS_Department Getdata0 = new CLS_FRMS.CLS_Department();
                    DataTable dt0 = Getdata0.GetDataDepartment();
                    for (int i = 0; i < dt0.Rows.Count; i++) { cbxFirstInput.Items.Add(dt0.Rows[i][1].ToString()); }
                    cbxSecondInput.Items.Clear();
                    CLS_FRMS.CLS_Store Getdata1 = new CLS_FRMS.CLS_Store();
                    DataTable dt1 = Getdata1.GetDataStore();
                    for (int i = 0; i < dt1.Rows.Count; i++) { cbxSecondInput.Items.Add(dt1.Rows[i][1].ToString()); }


                    break;
                case "فواتير بين تاريخين (عجلات)":
                    
                    lblFirstInput.Text = "اسم المخزن";
                    cbxFirstInput.DataSource = null;
                    cbxSecondInput.DataSource = null;
                    cbxSecondInput.Visible = false;
                    lblSecondInput.Visible = false;
                    cbxFirstInput.Text = null;
                    cbxSecondInput.Text = null;
                    cbxFirstInput.Items.Clear();
                    CLS_FRMS.CLS_Store Getdata2 = new CLS_FRMS.CLS_Store();
                    DataTable dt2 = Getdata2.GetDataStore();
                    for (int i = 0; i < dt2.Rows.Count; i++) { cbxFirstInput.Items.Add(dt2.Rows[i][1].ToString()); }

                    break;
                case "خلاصة صرفيات الاقسام بين تاريخين (عجلات)":
                    cbxFirstInput.DataSource = null;
                    cbxSecondInput.DataSource = null;
                    lblFirstInput.Text = "اسم المخزن";
                    cbxSecondInput.Visible = false;
                    lblSecondInput.Visible = false;
                    cbxFirstInput.Text = null;
                    cbxSecondInput.Text = null;
                    cbxFirstInput.Items.Clear();
                    CLS_FRMS.CLS_Store Getdata3 = new CLS_FRMS.CLS_Store();
                    DataTable dt3 = Getdata3.GetDataStore();
                    for (int i = 0; i < dt3.Rows.Count; i++) { cbxFirstInput.Items.Add(dt3.Rows[i][1].ToString()); }

                    break;
                case "صرفيات عجلة بين تاريخين (عجلات)":
                    cbxFirstInput.DataSource = null;
                    cbxSecondInput.DataSource = null;
                    cbxSecondInput.Visible = true;
                    lblSecondInput.Visible = true;
                    cbxFirstInput.Text = null;
                    cbxSecondInput.Text = null;
                    lblSecondInput.Text = "نوع العجلة";                    
                    lblFirstInput.Text = "رقم العجلة";
                    CLS_FRMS.CLS_FuelEntry CAR = new CLS_FRMS.CLS_FuelEntry();
                    CAR.caarInfo(cbxFirstInput, cbxSecondInput);
                    break;
                case "خلاصة عجلات بين تاريخين (عجلات)":
                    lblFirstInput.Text = "اسم المخزن";
                    cbxFirstInput.Text = null;
                    cbxSecondInput.Text = null;
                    cbxFirstInput.DataSource = null;
                    cbxSecondInput.DataSource = null;
                    cbxSecondInput.Visible = false;
                    lblSecondInput.Visible = false;
                    cbxFirstInput.Items.Clear();
                    CLS_FRMS.CLS_Store Getdata6 = new CLS_FRMS.CLS_Store();
                    DataTable dt6 = Getdata6.GetDataStore();
                    for (int i = 0; i < dt6.Rows.Count; i++) { cbxFirstInput.Items.Add(dt6.Rows[i][1].ToString()); }

                    break;
                case "خلاصة صرفيات الجهات الاستثمارية (عجلات)":
                    lblFirstInput.Text = "اسم المخزن";
                    cbxFirstInput.Text = null;
                    cbxSecondInput.Text = null;
                    cbxFirstInput.DataSource = null;
                    cbxSecondInput.DataSource = null;
                    cbxSecondInput.Visible = false;
                    lblSecondInput.Visible = false;
                    cbxFirstInput.Items.Clear();
                    CLS_FRMS.CLS_Store Getdata7 = new CLS_FRMS.CLS_Store();
                    DataTable dt7 = Getdata7.GetDataStore();
                    for (int i = 0; i < dt7.Rows.Count; i++) { cbxFirstInput.Items.Add(dt7.Rows[i][1].ToString()); }

                    break;
                case "خلاصة صرفيات الجهات غير الاستثمارية (عجلات)":
                    lblFirstInput.Text = "اسم المخزن";
                    cbxFirstInput.Text = null;
                    cbxSecondInput.Text = null;
                    cbxFirstInput.DataSource = null;
                    cbxSecondInput.DataSource = null;
                    cbxSecondInput.Visible = false;
                    lblSecondInput.Visible = false;
                    cbxFirstInput.Items.Clear();
                    CLS_FRMS.CLS_Store Getdata8 = new CLS_FRMS.CLS_Store();
                    DataTable dt8 = Getdata8.GetDataStore();
                    for (int i = 0; i < dt8.Rows.Count; i++) { cbxFirstInput.Items.Add(dt8.Rows[i][1].ToString()); }

                    break;

                //------------------------------------------------------------------------------------------------------
                case "فواتير بين تاريخين (مواقع)":
                case "طباعة سلسلة فواتير تجهز المواقع بالوقود بين تاريخين":
                    cbxFirstInput.DataSource = null;
                    lblFirstInput.Text = "اسم المخزن";
                    cbxFirstInput.DataSource = null;
                    cbxSecondInput.DataSource = null;
                    cbxSecondInput.Visible = false;
                    lblSecondInput.Visible = false;
                    cbxFirstInput.Text = null;
                    cbxSecondInput.Text = null;
                    cbxFirstInput.Items.Clear();
                    CLS_FRMS.CLS_Store Getdata11 = new CLS_FRMS.CLS_Store();
                    DataTable dt11 = Getdata11.GetDataStore();
                    for (int i = 0; i < dt11.Rows.Count; i++) { cbxFirstInput.Items.Add(dt11.Rows[i][1].ToString()); }

                    break;
                case "فواتير حسب الشهر (مواقع)":

                    cbxSecondInput.DataSource = null;
                    lblFirstInput.Text = "الشهر:";
                    cbxSecondInput.Visible = true;
                    lblSecondInput.Visible = true;
                    cbxFirstInput.Text = null;
                    cbxSecondInput.Text = null;
                    lblSecondInput.Text = "اسم المخزن:";
                    cbxFirstInput.Items.Clear();
                    string[] s_place1 = { "كانون الثاني", "شباط", "آذار", "نيسان", "أيار", "حزيران", "تموز", "آب", "أيلول", "تشرين الأول", "تشرين الثاني", "كانون الأول", "كمية دوار" };
                    for (int i = 0; i < s_place1.Length; i++)
                    {
                        cbxFirstInput.Items.Add(s_place1[i]);
                    }
                    cbxSecondInput.Items.Clear();
                    CLS_FRMS.CLS_Store GetdataStore = new CLS_FRMS.CLS_Store();
                    DataTable dtStore = GetdataStore.GetDataStore();
                    for (int i = 0; i < dtStore.Rows.Count; i++) { cbxSecondInput.Items.Add(dtStore.Rows[i][1].ToString()); }


                    break;
                case "فواتير قسم بين تاريخين (مواقع)":
               
                    cbxSecondInput.DataSource = null;
                    lblFirstInput.Text = "القسم:";
                    cbxSecondInput.Visible = true;
                    lblSecondInput.Visible = true;
                    cbxFirstInput.Text = null;
                    cbxSecondInput.Text = null;
                    lblSecondInput.Text = "اسم المخزن:";
                    cbxFirstInput.Items.Clear();
                    CLS_FRMS.CLS_Department Getdata9 = new CLS_FRMS.CLS_Department();
                    DataTable dt9 = Getdata9.GetDataDepartment();
                    for (int i = 0; i < dt9.Rows.Count; i++) { cbxFirstInput.Items.Add(dt9.Rows[i][1].ToString()); }
                    cbxSecondInput.Items.Clear();
                    CLS_FRMS.CLS_Store Getdata10 = new CLS_FRMS.CLS_Store();
                    DataTable dt10 = Getdata10.GetDataStore();
                    for (int i = 0; i < dt10.Rows.Count; i++) { cbxSecondInput.Items.Add(dt10.Rows[i][1].ToString()); }


                    break;
                
                case "خلاصة صرفيات الاقسام بين تاريخين (مواقع)":
                    cbxFirstInput.DataSource = null;
                    cbxSecondInput.DataSource = null;
                    lblFirstInput.Text = "اسم المخزن";
                    cbxSecondInput.Visible = false;
                    lblSecondInput.Visible = false;
                    cbxFirstInput.Text = null;
                    cbxSecondInput.Text = null;
                    cbxFirstInput.Items.Clear();
                    CLS_FRMS.CLS_Store Getdata12 = new CLS_FRMS.CLS_Store();
                    DataTable dt12 = Getdata12.GetDataStore();
                    for (int i = 0; i < dt12.Rows.Count; i++) { cbxFirstInput.Items.Add(dt12.Rows[i][1].ToString()); }

                    break;
                case "صرفيات موقع بين تاريخين (مواقع)":
                    cbxFirstInput.DataSource = null;
                    cbxSecondInput.DataSource = null;
                    cbxSecondInput.Visible = false;
                    lblSecondInput.Visible = false;
                    cbxFirstInput.Text = null;
                    lblFirstInput.Text = "الموقع";
                    CLS_FRMS.CLS_FuelExitPlace place = new CLS_FRMS.CLS_FuelExitPlace();
                    place.placeCombobox(cbxFirstInput);
                   
                    break;
                case "خلاصة مواقع بين تاريخين (مواقع)":
                    lblFirstInput.Text = "اسم المخزن";
                    cbxFirstInput.Text = null;
                    cbxSecondInput.Text = null;
                    cbxFirstInput.DataSource = null;
                    cbxSecondInput.DataSource = null;
                    cbxSecondInput.Visible = false;
                    lblSecondInput.Visible = false;
                    cbxFirstInput.Items.Clear();
                    CLS_FRMS.CLS_Store Getdata13 = new CLS_FRMS.CLS_Store();
                    DataTable dt13 = Getdata13.GetDataStore();
                    for (int i = 0; i < dt13.Rows.Count; i++) { cbxFirstInput.Items.Add(dt13.Rows[i][1].ToString()); }

                    break;
                case "خلاصة صرفيات الجهات الاستثمارية (مواقع)":
                    lblFirstInput.Text = "اسم المخزن";
                    cbxFirstInput.Text = null;
                    cbxSecondInput.Text = null;
                    cbxFirstInput.DataSource = null;
                    cbxSecondInput.DataSource = null;
                    cbxSecondInput.Visible = false;
                    lblSecondInput.Visible = false;
                    cbxFirstInput.Items.Clear();
                    CLS_FRMS.CLS_Store Getdata14 = new CLS_FRMS.CLS_Store();
                    DataTable dt14 = Getdata14.GetDataStore();
                    for (int i = 0; i < dt14.Rows.Count; i++) { cbxFirstInput.Items.Add(dt14.Rows[i][1].ToString()); }

                    break;
                case "خلاصة صرفيات الجهات غير الاستثمارية (مواقع)":
                    lblFirstInput.Text = "اسم المخزن";
                    cbxFirstInput.Text = null;
                    cbxSecondInput.Text = null;
                    cbxFirstInput.DataSource = null;
                    cbxSecondInput.DataSource = null;
                    cbxSecondInput.Visible = false;
                    lblSecondInput.Visible = false;
                    cbxFirstInput.Items.Clear();
                    CLS_FRMS.CLS_Store Getdata15 = new CLS_FRMS.CLS_Store();
                    DataTable dt15 = Getdata15.GetDataStore();
                    for (int i = 0; i < dt15.Rows.Count; i++) { cbxFirstInput.Items.Add(dt15.Rows[i][1].ToString()); }

                    break;
            }
        }


        private void btnShow_Click(object sender, EventArgs e)
        {

            Dgv.DataSource = null;
            if (bgwork.IsBusy) { label1.Visible = true; }
            else { bgwork.RunWorkerAsync(); label1.Visible = false; }
            if (prog.Visible == false) { prog.Visible = true; }
            if (lb1.Visible == false) { lb1.Visible = true; }

        }

        private void btnPrintExitBill_Click(object sender, EventArgs e)
        {
            CLS_FRMS.CLS_RPFuel rp = new CLS_FRMS.CLS_RPFuel();
            DataTable Dt = new DataTable();
            DS.DSFuel dss = new DS.DSFuel();
            REPORTS.ReportViewer frm = new REPORTS.ReportViewer();
            if (RPNAME == "تقارير ادخال وقود")
            {
                switch (cbxRpType.Text)
                {
                    case "فواتير بين تاريخين":
                        Dt = rp.FUEL_BillEntrayBetweenTowDate(cbxFirstInput.Text, dt1, dt2);
                        dss.Tables["BillBetweenTwoDateEntry"].Clear();
                        int count = 0;
                        for (int i = 0; i < Dt.Rows.Count; i++)
                        {
                            count += Convert.ToInt32(Dt.Rows[i][2]);
                            dss.Tables["BillBetweenTwoDateEntry"].Rows.Add(i + 1, Dt.Rows[i][0], Dt.Rows[i][1], String.Format("{0:#,###,###}", Dt.Rows[i][2]),DateTime.Parse(Dt.Rows[i][3].ToString()).ToString("dd/MM/yyyy"), Dt.Rows[i][4], Dt.Rows[i][5], Dt.Rows[i][6], Dt.Rows[i][7], Dt.Rows[i][8]);
                        }
                        REPORTS.BillsBetweenTwoDateEntry rpt = new REPORTS.BillsBetweenTwoDateEntry();

                        if(dt1.Value.Month==dt2.Value.Month && dt1.Value.Day==1 && dt2.Value.Day>=30)
                            rpt.Parameters["RpType"].Value = "فواتير ادخال الوقود للقسم لشهر "+ rp.mounthWord(dt1.Value.Month);
                        else
                            rpt.Parameters["RpType"].Value = "فواتير ادخال الوقود للقسم بين تاريخين";
                        rpt.Parameters["RpTypeDetials"].Value = "المخزن : " + cbxFirstInput.Text + "\r\n  من  : " + dt1.Text + "\r\n  الى : " + dt2.Text;
                        rpt.Parameters["Count"].Value = Dt.Rows.Count;
                        rpt.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
                        rpt.Parameters["Date"].Value = DateTime.Now.ToString("dd/MM/yyyy");
                        rpt.Parameters["Quantity"].Value = String.Format("{0:#,###,###}", count);
                        rpt.DataSource = dss;
                        rpt.RequestParameters = false;
                        frm.documentViewer1.DocumentSource = rpt;
                        frm.ShowDialog();
                        break;

                    case "فواتير حسب الشهر":
                        Dt = rp.FUEL_BillEntrayByMonth(cbxFirstInput.Text, cbxSecondInput.Text, dt1, dt2);
                        dss.Tables["BillBetweenEntryByMonth"].Clear();
                        count = 0;
                        for (int i = 0; i < Dt.Rows.Count; i++)
                        {
                            count += Convert.ToInt32(Dt.Rows[i][2]);
                            dss.Tables["BillBetweenEntryByMonth"].Rows.Add(i + 1, Dt.Rows[i][0], Dt.Rows[i][1], String.Format("{0:#,###,###}", Dt.Rows[i][2]), DateTime.Parse(Dt.Rows[i][3].ToString()).ToString("dd/MM/yyyy"), Dt.Rows[i][4], Dt.Rows[i][5], Dt.Rows[i][6], Dt.Rows[i][7]);
                        }
                        REPORTS.BillsEntryByMonth rpt1 = new REPORTS.BillsEntryByMonth();

                       
                        rpt1.Parameters["RpType"].Value = "فواتير ادخال الوقود للقسم حسب الشهر";
                        rpt1.Parameters["RpTypeDetials"].Value = "المخزن : " + cbxFirstInput.Text + "\r\nحصة شهر : " + cbxSecondInput.Text + "\r\n  من  : " + dt1.Text + "\r\n  الى : " + dt2.Text;
                        rpt1.Parameters["Count"].Value = Dt.Rows.Count;
                        rpt1.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
                        rpt1.Parameters["Date"].Value = DateTime.Now.ToString("dd/MM/yyyy");
                        rpt1.Parameters["Quantity"].Value = String.Format("{0:#,###,###}", count);
                        rpt1.DataSource = dss;
                        rpt1.RequestParameters = false;
                        frm.documentViewer1.DocumentSource = rpt1;
                        frm.ShowDialog();
                        break;


                }
            }
            if (RPNAME == "تقارير اخراج وقود")
            {
                switch (cbxRpType.Text)
                {
                    case "فواتير بين تاريخين (عجلات)":
                   
                        Dt = rp.FUEL_BillExitBetweenTowDate(dt1, dt2, cbxFirstInput.Text);
                        dss.Tables["BillExitBetweentowdate"].Clear();
                        int count = 0;
                        for (int i = 0; i < Dt.Rows.Count; i++)
                        {
                            count += Convert.ToInt32(Dt.Rows[i][4]);
                            dss.Tables["BillExitBetweentowdate"].Rows.Add(i + 1, Dt.Rows[i][0], DateTime.Parse(Dt.Rows[i][1].ToString()).ToString("dd/MM/yyyy"),  Dt.Rows[i][2], Dt.Rows[i][3], String.Format("{0:#,###,###}", Dt.Rows[i][4]), Dt.Rows[i][5], String.Format("{0:#,###,###}", Dt.Rows[i][6]), String.Format("{0:#,###,###}", Dt.Rows[i][7]), Dt.Rows[i][9]);
                        }
                        REPORTS.BillExitBetweentowdate rpt = new REPORTS.BillExitBetweentowdate();

                        if (dt1.Value.Month == dt2.Value.Month && dt1.Value.Day == 1 && dt2.Value.Day >= 30)
                            rpt.Parameters["RpType"].Value = "فواتير تجهيز عجلات بالوقود لشهر " + rp.mounthWord(dt1.Value.Month);
                        else
                            rpt.Parameters["RpType"].Value = "فواتير تجهيز عجلات بالوقود بين تاريخين";
                        rpt.Parameters["RpTypeDetials"].Value = "المخزن : " + cbxFirstInput.Text + "\r\n  من  : " + dt1.Text + "\r\n  الى : " + dt2.Text;
                        rpt.Parameters["Count"].Value = Dt.Rows.Count;
                        rpt.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
                        rpt.Parameters["Date"].Value = DateTime.Now.ToString("dd/MM/yyyy");
                        rpt.Parameters["Quantity"].Value = String.Format("{0:#,###,###}", count);
                        rpt.DataSource = dss;
                        rpt.RequestParameters = false;
                        frm.documentViewer1.DocumentSource = rpt;
                        frm.ShowDialog();
                        break;

                    case "فواتير قسم بين تاريخين (عجلات)":
                        Dt = rp.FUEL_BillEXitDeptBetweenTowDate(cbxFirstInput.Text, cbxSecondInput.Text, dt1, dt2);
                        dss.Tables["BillExitDeptBetweentowdate"].Clear();
                        count = 0;
                        for (int i = 0; i < Dt.Rows.Count; i++)
                        {
                            count += Convert.ToInt32(Dt.Rows[i][4]);
                            dss.Tables["BillExitDeptBetweentowdate"].Rows.Add(i + 1, Dt.Rows[i][0], DateTime.Parse(Dt.Rows[i][1].ToString()).ToString("dd/MM/yyyy"), Dt.Rows[i][2], Dt.Rows[i][3], String.Format("{0:#,###,###}", Dt.Rows[i][4]), String.Format("{0:#,###,###}", Dt.Rows[i][5]), String.Format("{0:#,###,###}", Dt.Rows[i][6]));
                        }
                        REPORTS.BillExitDeptBetweentowdate rpt1 = new REPORTS.BillExitDeptBetweentowdate();

                        if (dt1.Value.Month == dt2.Value.Month && dt1.Value.Day == 1 && dt2.Value.Day >= 30)
                            rpt1.Parameters["RpType"].Value = "فواتير تجهيز عجلات قسم بالوقود لشهر " + rp.mounthWord(dt1.Value.Month);
                        else
                            rpt1.Parameters["RpType"].Value = "فواتير تجهيز عجلات قسم بالوقود بين تاريخين";
                        rpt1.Parameters["RpTypeDetials"].Value = "المخزن : " + cbxFirstInput.Text + "\r\n  من  : " + dt1.Text + "\r\n  الى : " + dt2.Text;
                        rpt1.Parameters["Count"].Value = Dt.Rows.Count;
                        rpt1.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
                        rpt1.Parameters["Date"].Value = DateTime.Now.ToString("dd/MM/yyyy");
                        rpt1.Parameters["Quantity"].Value = String.Format("{0:#,###,###}", count);
                        rpt1.DataSource = dss;
                        rpt1.RequestParameters = false;
                        frm.documentViewer1.DocumentSource = rpt1;
                        frm.ShowDialog();
                        break;

                    case "خلاصة صرفيات الاقسام بين تاريخين (عجلات)":
                        Dt = rp.FUEL_BillEXitDeptsSummaryBetweenTowDate(cbxFirstInput.Text, dt1, dt2);
                        dss.Tables["BillExitDeptsSummaryBetweentowdate"].Clear();
                        count = 0;
                        for (int i = 0; i < Dt.Rows.Count; i++)
                        {
                            count += Convert.ToInt32(Dt.Rows[i][1]);
                            dss.Tables["BillExitDeptsSummaryBetweentowdate"].Rows.Add(i + 1, Dt.Rows[i][0], String.Format("{0:#,###,###}", Dt.Rows[i][1]), String.Format("{0:#,###,###}", Dt.Rows[i][2]));
                        }
                        REPORTS.BillExitDeptsSummaryBetweentowdate rpt2 = new REPORTS.BillExitDeptsSummaryBetweentowdate();

                        if (dt1.Value.Month == dt2.Value.Month && dt1.Value.Day == 1 && dt2.Value.Day >= 30)
                            rpt2.Parameters["RpType"].Value = "خلاصة صرفيات عجلات الاقسام من الوقود لشهر " + rp.mounthWord(dt1.Value.Month);
                        else
                            rpt2.Parameters["RpType"].Value = "خلاصة صرفيات عجلات الاقسام من الوقود بين تاريخين ";
                        rpt2.Parameters["RpTypeDetials"].Value = "المخزن : " + cbxFirstInput.Text + "\r\n  من  : " + dt1.Text + "\r\n  الى : " + dt2.Text;
                        rpt2.Parameters["Count"].Value = Dt.Rows.Count;
                        rpt2.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
                        rpt2.Parameters["Date"].Value = DateTime.Now.ToString("dd/MM/yyyy");
                        rpt2.Parameters["Quantity"].Value = String.Format("{0:#,###,###}", count);
                        rpt2.DataSource = dss;
                        rpt2.RequestParameters = false;
                        frm.documentViewer1.DocumentSource = rpt2;
                        frm.ShowDialog();
                        break;

                    case "صرفيات عجلة بين تاريخين (عجلات)":
                        Dt = rp.FUEL_BillEXitCarBetweenTowDate(cbxFirstInput.Text, dt1, dt2);
                        dss.Tables["BillExitCarBetweentowdate"].Clear();
                        count = 0;
                        for (int i = 0; i < Dt.Rows.Count; i++)
                        {
                            count += Convert.ToInt32(Dt.Rows[i][2]);
                            dss.Tables["BillExitCarBetweentowdate"].Rows.Add(i + 1, Dt.Rows[i][0], DateTime.Parse(Dt.Rows[i][1].ToString()).ToString("dd/MM/yyyy"), String.Format("{0:#,###,###}", Dt.Rows[i][2]), Dt.Rows[i][3], Dt.Rows[i][4], String.Format("{0:#,###,###}", Dt.Rows[i][5]), String.Format("{0:#,###,###}", Dt.Rows[i][6]));
                        }
                        REPORTS.BillExitCarBetweentowdate rpt3 = new REPORTS.BillExitCarBetweentowdate();

                        if (dt1.Value.Month == dt2.Value.Month && dt1.Value.Day == 1 && dt2.Value.Day >= 30)
                            rpt3.Parameters["RpType"].Value = "صرفيات عجلة من الوقود لشهر " + rp.mounthWord(dt1.Value.Month);
                        else
                            rpt3.Parameters["RpType"].Value = "صرفيات عجلة من الوقود بين تاريخين ";
                        rpt3.Parameters["RpTypeDetials"].Value = "رقم العجلة : " + cbxFirstInput.Text + "\r\n نوع العجلة : " + cbxSecondInput.Text + "\r\n  من  : " + dt1.Text + "\r\n  الى : " + dt2.Text;
                        rpt3.Parameters["Count"].Value = Dt.Rows.Count;
                        rpt3.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
                        rpt3.Parameters["Date"].Value = DateTime.Now.ToString("dd/MM/yyyy");
                        rpt3.Parameters["Quantity"].Value = String.Format("{0:#,###,###}", count);
                        rpt3.DataSource = dss;
                        rpt3.RequestParameters = false;
                        frm.documentViewer1.DocumentSource = rpt3;
                        frm.ShowDialog();
                        break;

                    case "خلاصة عجلات بين تاريخين (عجلات)":
                        Dt = rp.FUEL_BillEXitCarsSummaryBetweenTowDate(cbxFirstInput.Text, dt1, dt2);
                        dss.Tables["BillExitCarsSummaryBetweentowdate"].Clear();
                        count = 0;
                        for (int i = 0; i < Dt.Rows.Count; i++)
                        {
                            count += Convert.ToInt32(Dt.Rows[i][3]);
                            dss.Tables["BillExitCarsSummaryBetweentowdate"].Rows.Add(i + 1, Dt.Rows[i][0], Dt.Rows[i][1], Dt.Rows[i][2], String.Format("{0:#,###,###}", Dt.Rows[i][3]), String.Format("{0:#,###,###}", Dt.Rows[i][4]));
                        }
                        REPORTS.BillExitCarsSummaryBetweentowdate rpt4 = new REPORTS.BillExitCarsSummaryBetweentowdate();

                        if (dt1.Value.Month == dt2.Value.Month && dt1.Value.Day == 1 && dt2.Value.Day >= 30)
                            rpt4.Parameters["RpType"].Value = "خلاصة صرفيات عجلات الاقسام من الوقود لشهر " + rp.mounthWord(dt1.Value.Month);
                        else
                            rpt4.Parameters["RpType"].Value = "خلاصة صرفيات عجلات الاقسام من الوقود بين تاريخين ";
                        rpt4.Parameters["RpTypeDetials"].Value = "المخزن : " + cbxFirstInput.Text + "\r\n  من  : " + dt1.Text + "\r\n  الى : " + dt2.Text;
                        rpt4.Parameters["Count"].Value = Dt.Rows.Count;
                        rpt4.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
                        rpt4.Parameters["Date"].Value = DateTime.Now.ToString("dd/MM/yyyy");
                        rpt4.Parameters["Quantity"].Value = String.Format("{0:#,###,###}", count);
                        rpt4.DataSource = dss;
                        rpt4.RequestParameters = false;
                        frm.documentViewer1.DocumentSource = rpt4;
                        frm.ShowDialog();
                        break;

                    case "خلاصة صرفيات الجهات الاستثمارية (عجلات)":
                        Dt = rp.FUEL_BillEXitDeptsInvestSummaryBetweenTowDate(cbxFirstInput.Text, true, dt1, dt2);
                        dss.Tables["BillExitDeptsSummaryBetweentowdate"].Clear();
                        count = 0;
                        for (int i = 0; i < Dt.Rows.Count; i++)
                        {
                            count += Convert.ToInt32(Dt.Rows[i][1]);
                            dss.Tables["BillExitDeptsSummaryBetweentowdate"].Rows.Add(i + 1, Dt.Rows[i][0], String.Format("{0:#,###,###}", Dt.Rows[i][1]), String.Format("{0:#,###,###}", Dt.Rows[i][2]));
                        }
                        REPORTS.BillExitDeptsSummaryBetweentowdate rpt5 = new REPORTS.BillExitDeptsSummaryBetweentowdate();

                        if (dt1.Value.Month == dt2.Value.Month && dt1.Value.Day == 1 && dt2.Value.Day >= 30)
                            rpt5.Parameters["RpType"].Value = "خلاصة صرفيات عجلات الجهات الاستثمارية من الوقود لشهر " + rp.mounthWord(dt1.Value.Month);
                        else
                            rpt5.Parameters["RpType"].Value = "خلاصة صرفيات عجلات الجهات الاستثمارية من الوقود بين تاريخين ";
                        rpt5.Parameters["RpTypeDetials"].Value = "المخزن : " + cbxFirstInput.Text + "\r\n  من  : " + dt1.Text + "\r\n  الى : " + dt2.Text;
                        rpt5.Parameters["Count"].Value = Dt.Rows.Count;
                        rpt5.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
                        rpt5.Parameters["Date"].Value = DateTime.Now.ToString("dd/MM/yyyy");
                        rpt5.Parameters["Quantity"].Value = String.Format("{0:#,###,###}", count);
                        rpt5.DataSource = dss;
                        rpt5.RequestParameters = false;
                        frm.documentViewer1.DocumentSource = rpt5;
                        frm.ShowDialog();
                        break;

                    case "خلاصة صرفيات الجهات غير الاستثمارية (عجلات)":
                        Dt = rp.FUEL_BillEXitDeptsInvestSummaryBetweenTowDate(cbxFirstInput.Text, false, dt1, dt2);
                        dss.Tables["BillExitDeptsSummaryBetweentowdate"].Clear();
                        count = 0;
                        for (int i = 0; i < Dt.Rows.Count; i++)
                        {
                            count += Convert.ToInt32(Dt.Rows[i][1]);
                            dss.Tables["BillExitDeptsSummaryBetweentowdate"].Rows.Add(i + 1, Dt.Rows[i][0], String.Format("{0:#,###,###}", Dt.Rows[i][1]), String.Format("{0:#,###,###}", Dt.Rows[i][2]));
                        }
                        REPORTS.BillExitDeptsSummaryBetweentowdate rpt6 = new REPORTS.BillExitDeptsSummaryBetweentowdate();

                        if (dt1.Value.Month == dt2.Value.Month && dt1.Value.Day == 1 && dt2.Value.Day >= 30)
                            rpt6.Parameters["RpType"].Value = "خلاصة صرفيات عجلات الجهات غير الاستثمارية من الوقود لشهر " + rp.mounthWord(dt1.Value.Month);
                        else
                            rpt6.Parameters["RpType"].Value = "خلاصة صرفيات عجلات الجهات غير الاستثمارية من الوقود بين تاريخين ";
                        rpt6.Parameters["RpTypeDetials"].Value = "المخزن : " + cbxFirstInput.Text + "\r\n  من  : " + dt1.Text + "\r\n  الى : " + dt2.Text;
                        rpt6.Parameters["Count"].Value = Dt.Rows.Count;
                        rpt6.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
                        rpt6.Parameters["Date"].Value = DateTime.Now.ToString("dd/MM/yyyy");
                        rpt6.Parameters["Quantity"].Value = String.Format("{0:#,###,###}", count);
                        rpt6.DataSource = dss;
                        rpt6.RequestParameters = false;
                        frm.documentViewer1.DocumentSource = rpt6;
                        frm.ShowDialog();
                        break;

                    case "طباعة سلسلة فواتير تجهز عجلات بالوقود بين تاريخين":
                        Dt = rp.FUEL_BillExitBetweenTowDate(dt1, dt2, cbxFirstInput.Text);
                        CLS_FRMS.CLS_FuelExit rpBill = new CLS_FRMS.CLS_FuelExit();
                        DataTable DtBill = new DataTable();
                        DS.DSFuel dssBill = new DS.DSFuel();
                        REPORTS.ReportViewer frmBill = new REPORTS.ReportViewer();
                        DialogResult result = MessageBox.Show("هل تريد تأكيد طباعة فواتير عدد "+Dt.Rows.Count+"؟", "تأكيد", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            for (int j = 0; j < Dt.Rows.Count; j++)
                            {


                                DtBill = rpBill.SelectFuelExitBill(int.Parse(Dt.Rows[j][8].ToString()));
                                dssBill.Tables["FuelExitBill"].Clear();

                                for (int i = 0; i < DtBill.Rows.Count; i++)
                                {
                                    dssBill.Tables["FuelExitBill"].Rows.Add(DtBill.Rows[i][0], DtBill.Rows[i][2], DtBill.Rows[i][3], DtBill.Rows[i][4], DtBill.Rows[i][5], DtBill.Rows[i][6],
                                        DtBill.Rows[i][7], DtBill.Rows[i][8], DtBill.Rows[i][9], DateTime.Parse(DtBill.Rows[i][10].ToString()).ToString("dd/MM/yyyy"), DtBill.Rows[i][11], DateTime.Parse(DtBill.Rows[i][1].ToString()).ToString("dd/MM/yyyy"),
                                       DtBill.Rows[i][12], DtBill.Rows[i][13], DtBill.Rows[i][14]);
                                }
                                REPORTS.FuelExitBill rptBill = new REPORTS.FuelExitBill();


                                rptBill.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();

                                rptBill.DataSource = dssBill;
                                rptBill.RequestParameters = false;
                                ReportPrintTool printTool = new ReportPrintTool(rptBill);
                                if (j == 0)
                                    printTool.PrintDialog();
                                else
                                    printTool.Print();

                            }
                        }
                        break;


                   //----------------------------------------------------------------------------------------------------------

                    case "فواتير بين تاريخين (مواقع)":
                        Dt = rp.FUEL_BillExitPlaceBetweenTowDate(dt1, dt2, cbxFirstInput.Text);
                        dss.Tables["BillExitPlaceBetweentowdate"].Clear();
                        int totalprice = 0, totalquantity=0;
                        for (int i = 0; i < Dt.Rows.Count; i++)
                        {
                            totalquantity += Convert.ToInt32(Dt.Rows[i][3]);
                            totalprice += Convert.ToInt32(Dt.Rows[i][6]);
                            dss.Tables["BillExitPlaceBetweentowdate"].Rows.Add(i + 1, Dt.Rows[i][0], DateTime.Parse(Dt.Rows[i][1].ToString()).ToString("dd/MM/yyyy"), Dt.Rows[i][2], String.Format("{0:#,###,###}", Dt.Rows[i][3]), Dt.Rows[i][4], Dt.Rows[i][5], String.Format("{0:#,###,###}", Dt.Rows[i][6]), Dt.Rows[i][8]);
                        }
                        REPORTS.BillExitPlaceBetweeTowDate rpt7 = new REPORTS.BillExitPlaceBetweeTowDate();

                        if (dt1.Value.Month == dt2.Value.Month && dt1.Value.Day == 1 && dt2.Value.Day >= 30)
                            rpt7.Parameters["RpType"].Value = "فواتير تجهيز المواقع بالوقود لشهر " + rp.mounthWord(dt1.Value.Month);
                        else
                            rpt7.Parameters["RpType"].Value = "فواتير تجهيز المواقع بالوقود";
                        rpt7.Parameters["RpTypeDetials"].Value ="المخزن : " + cbxFirstInput.Text + "\r\n  من  : " + dt1.Text + "\r\n  الى : " + dt2.Text;
                        rpt7.Parameters["Count"].Value = Dt.Rows.Count;
                        rpt7.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
                        rpt7.Parameters["Date"].Value = DateTime.Now.ToString("dd/MM/yyyy");
                        rpt7.Parameters["TotalQuantity"].Value = String.Format("{0:#,###,###}", totalquantity) ;
                        rpt7.Parameters["TotalPrice"].Value = String.Format("{0:#,###,###}", totalprice) +"د.ع.";
                        rpt7.DataSource = dss;
                        rpt7.RequestParameters = false;
                        frm.documentViewer1.DocumentSource = rpt7;
                        frm.ShowDialog();
                        break;
                    case "فواتير حسب الشهر (مواقع)":
                        Dt = rp.FUEL_BillExitPlaceByMonth(dt1, dt2,  cbxSecondInput.Text, cbxFirstInput.Text);
                        dss.Tables["BillExitPlaceByMonth"].Clear();
                        totalprice = 0; totalquantity = 0;
                        for (int i = 0; i < Dt.Rows.Count; i++)
                        {
                            totalquantity += Convert.ToInt32(Dt.Rows[i][3]);
                            totalprice += Convert.ToInt32(Dt.Rows[i][6]);
                            dss.Tables["BillExitPlaceByMonth"].Rows.Add(i + 1, Dt.Rows[i][0], DateTime.Parse(Dt.Rows[i][1].ToString()).ToString("dd/MM/yyyy"), Dt.Rows[i][2], String.Format("{0:#,###,###}", Dt.Rows[i][3]), Dt.Rows[i][4], Dt.Rows[i][5], String.Format("{0:#,###,###}", Dt.Rows[i][6]));
                        }
                        REPORTS.BillsExitPlaceByMonth rptmonth = new REPORTS.BillsExitPlaceByMonth();

                      
                        rptmonth.Parameters["RpType"].Value = "فواتير تجهيز المواقع بالوقود حسب الشهر";
                        rptmonth.Parameters["RpTypeDetials"].Value = "المخزن : " + cbxSecondInput.Text + "\r\nحصة شهر : " + cbxFirstInput.Text + "\r\n  من  : " + dt1.Text + "\r\n  الى : " + dt2.Text;
                        rptmonth.Parameters["Count"].Value = Dt.Rows.Count;
                        rptmonth.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
                        rptmonth.Parameters["Date"].Value = DateTime.Now.ToString("dd/MM/yyyy");
                        rptmonth.Parameters["Quantity"].Value = String.Format("{0:#,###,###}", totalquantity);
                       
                        rptmonth.DataSource = dss;
                        rptmonth.RequestParameters = false;
                        frm.documentViewer1.DocumentSource = rptmonth;
                        frm.ShowDialog();
                        break;

                    case "فواتير قسم بين تاريخين (مواقع)":
                        Dt = rp.FUEL_BillEXitPlaceDeptBetweenTowDate(cbxFirstInput.Text, cbxSecondInput.Text, dt1, dt2);
                        dss.Tables["BillExitPlaceDeptBetweentowdate"].Clear();
                        totalquantity = 0;
                        for (int i = 0; i < Dt.Rows.Count; i++)
                        {
                            totalquantity += Convert.ToInt32(Dt.Rows[i][3]);
                            dss.Tables["BillExitPlaceDeptBetweentowdate"].Rows.Add(i + 1, Dt.Rows[i][0], DateTime.Parse(Dt.Rows[i][1].ToString()).ToString("dd/MM/yyyy"), Dt.Rows[i][2], String.Format("{0:#,###,###}", Dt.Rows[i][3]), String.Format("{0:#,###,###}", Dt.Rows[i][4]), String.Format("{0:#,###,###}", Dt.Rows[i][5]));
                        }
                        REPORTS.BillExitPlaceDeptBetweenTowDate rpt8 = new REPORTS.BillExitPlaceDeptBetweenTowDate();

                        if (dt1.Value.Month == dt2.Value.Month && dt1.Value.Day == 1 && dt2.Value.Day >= 30)
                            rpt8.Parameters["RpType"].Value = "فواتير تجهيز المواقع بالوقود حسب القسم لشهر " + rp.mounthWord(dt1.Value.Month);
                        else
                            rpt8.Parameters["RpType"].Value = "فواتير تجهيز المواقع بالوقود حسب القسم";
                        rpt8.Parameters["RpDetials"].Value = "القسم : " + cbxFirstInput.Text + "\r\n المخزن  : " + cbxSecondInput.Text + "\r\n من  : " + dt1.Text + "\r\n  الى : " + dt2.Text;

                        rpt8.Parameters["Count"].Value = Dt.Rows.Count;
                        rpt8.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
                        rpt8.Parameters["Date"].Value = DateTime.Now.ToString("dd/MM/yyyy");
                        rpt8.Parameters["Quantity"].Value = String.Format("{0:#,###,###}", totalquantity);
                        rpt8.DataSource = dss;
                        rpt8.RequestParameters = false;
                        frm.documentViewer1.DocumentSource = rpt8;
                        frm.ShowDialog();
                        break;
                    case "خلاصة صرفيات الاقسام بين تاريخين (مواقع)":
                        Dt = rp.FUEL_BillEXitPlaceDeptsSummaryBetweenTowDate(cbxFirstInput.Text, dt1, dt2);
                        dss.Tables["BillExitPlaceDeptsSummaryBetweentowdate"].Clear();
                        totalquantity = 0;
                        for (int i = 0; i < Dt.Rows.Count; i++)
                        {
                            totalquantity += Convert.ToInt32(Dt.Rows[i][1]);

                            dss.Tables["BillExitPlaceDeptsSummaryBetweentowdate"].Rows.Add(i + 1, Dt.Rows[i][0], String.Format("{0:#,###,###}", Dt.Rows[i][1]), String.Format("{0:#,###,###}", Dt.Rows[i][2]));
                        }
                        REPORTS.BillExitPlaceDeptsSummaryBetweenTowDate rpt9 = new REPORTS.BillExitPlaceDeptsSummaryBetweenTowDate();

                        if (dt1.Value.Month == dt2.Value.Month && dt1.Value.Day == 1 && dt2.Value.Day >= 30)
                            rpt9.Parameters["RpType"].Value = "خلاصة صرفيات مواقع الاقسام من الوقود لشهر " + rp.mounthWord(dt1.Value.Month);
                        else
                            rpt9.Parameters["RpType"].Value = "خلاصة صرفيات الاقسام من الوقود";

                        rpt9.Parameters["RpTypeDetials"].Value = " المخزن : " + cbxFirstInput.Text + "\r\n من  : " + dt1.Text + "\r\n الى : " + dt2.Text;

                        rpt9.Parameters["Count"].Value = Dt.Rows.Count;
                        rpt9.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
                        rpt9.Parameters["Date"].Value = DateTime.Now.ToString("dd/MM/yyyy");
                        rpt9.Parameters["Quantity"].Value = String.Format("{0:#,###,###}", totalquantity);
                        rpt9.DataSource = dss;
                        rpt9.RequestParameters = false;
                        frm.documentViewer1.DocumentSource = rpt9;
                        frm.ShowDialog();
                        break;
                    case "صرفيات موقع بين تاريخين (مواقع)":
                        Dt = rp.FUEL_BillEXitPlacesBetweenTowDate(cbxFirstInput.Text, dt1, dt2);
                        dss.Tables["BillExitPlacePlaceBetweentowdate"].Clear();
                        totalquantity = 0;
                        for (int i = 0; i < Dt.Rows.Count; i++)
                        {
                            totalquantity += Convert.ToInt32(Dt.Rows[i][3]);
                            dss.Tables["BillExitPlacePlaceBetweentowdate"].Rows.Add(i + 1, Dt.Rows[i][0], DateTime.Parse(Dt.Rows[i][1].ToString()).ToString("dd/MM/yyyy"), Dt.Rows[i][2], String.Format("{0:#,###,###}", Dt.Rows[i][3]), Dt.Rows[i][4], String.Format("{0:#,###,###}", Dt.Rows[i][5]), String.Format("{0:#,###,###}", Dt.Rows[i][6]));
                        }
                        REPORTS.BillExitPlacePlaceBetweenTowDate rpt10 = new REPORTS.BillExitPlacePlaceBetweenTowDate();

                        if (dt1.Value.Month == dt2.Value.Month && dt1.Value.Day == 1 && dt2.Value.Day >= 30)
                            rpt10.Parameters["RpType"].Value = "صرفيات موقع من الوقود لشهر " + rp.mounthWord(dt1.Value.Month);
                        else
                            rpt10.Parameters["RpType"].Value = "صرفيات موقع من الوقود";
                        rpt10.Parameters["RpTypeDetials"].Value = " الموقع : " + cbxFirstInput.Text + "\r\n من  : " + dt1.Text + "\r\n  الى : " + dt2.Text;

                        rpt10.Parameters["Count"].Value = Dt.Rows.Count;
                        rpt10.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
                        rpt10.Parameters["Date"].Value = DateTime.Now.ToString("dd/MM/yyyy");
                        rpt10.Parameters["Quantity"].Value = String.Format("{0:#,###,###}", totalquantity);
                        rpt10.DataSource = dss;
                        rpt10.RequestParameters = false;
                        frm.documentViewer1.DocumentSource = rpt10;
                        frm.ShowDialog();
                        break;
                    case "خلاصة مواقع بين تاريخين (مواقع)":
                        Dt = rp.FUEL_BillEXitPlaceSummaryBetweenTowDate(cbxFirstInput.Text, dt1, dt2);
                        dss.Tables["BillExitPlaceSummryBetweentowdate"].Clear();
                        totalquantity = 0;
                        for (int i = 0; i < Dt.Rows.Count; i++)
                        {
                            totalquantity += Convert.ToInt32(Dt.Rows[i][1]);
                            dss.Tables["BillExitPlaceSummryBetweentowdate"].Rows.Add(i + 1, String.Format("{0:#,###,###}", Dt.Rows[i][1]), Dt.Rows[i][0],  String.Format("{0:#,###,###}", Dt.Rows[i][2]));
                        }
                        REPORTS.BillExitPlaceSummryBetweenTwoDate rpt11 = new REPORTS.BillExitPlaceSummryBetweenTwoDate();

                        if (dt1.Value.Month == dt2.Value.Month && dt1.Value.Day == 1 && dt2.Value.Day >= 30)
                            rpt11.Parameters["RpType"].Value = "خلاصة صرفيات المواقع من الوقود لشهر " + rp.mounthWord(dt1.Value.Month);
                        else
                            rpt11.Parameters["RpType"].Value = "خلاصة صرفيات المواقع من الوقود";
                        rpt11.Parameters["RpTypeDetials"].Value =  " المخزن  : " + cbxFirstInput.Text + "\r\n من  : " + dt1.Text + "\r\n الى : " + dt2.Text;

                        rpt11.Parameters["Count"].Value = Dt.Rows.Count;
                        rpt11.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
                        rpt11.Parameters["Date"].Value = DateTime.Now.ToString("dd/MM/yyyy");
                        rpt11.Parameters["Quantity"].Value = String.Format("{0:#,###,###}", totalquantity);
                        rpt11.DataSource = dss;
                        rpt11.RequestParameters = false;
                        frm.documentViewer1.DocumentSource = rpt11;
                        frm.ShowDialog();
                        break;
                    case "خلاصة صرفيات الجهات الاستثمارية (مواقع)":
                        Dt = rp.FUEL_BillEXitPlaceDeptsInvestSummaryBetweenTowDate(cbxFirstInput.Text, true, dt1, dt2);
                        dss.Tables["BillExitPlaceDeptsSummaryBetweentowdate"].Clear();
                        totalquantity = 0;
                        for (int i = 0; i < Dt.Rows.Count; i++)
                        {
                            totalquantity += Convert.ToInt32(Dt.Rows[i][1]);
                            dss.Tables["BillExitPlaceDeptsSummaryBetweentowdate"].Rows.Add(i + 1, Dt.Rows[i][0], String.Format("{0:#,###,###}", Dt.Rows[i][1]), String.Format("{0:#,###,###}", Dt.Rows[i][2]));
                        }
                        REPORTS.BillExitPlaceDeptsSummaryBetweenTowDate rpt12 = new REPORTS.BillExitPlaceDeptsSummaryBetweenTowDate();

                        if (dt1.Value.Month == dt2.Value.Month && dt1.Value.Day == 1 && dt2.Value.Day >= 30)
                            rpt12.Parameters["RpType"].Value = "خلاصة صرفيات مواقع الجهات الاستثمارية من الوقود لشهر " + rp.mounthWord(dt1.Value.Month);
                        else
                            rpt12.Parameters["RpType"].Value = "خلاصة صرفيات مواقع الجهات الاستثمارية من الوقود";
                        rpt12.Parameters["RpTypeDetials"].Value = " المخزن : " + cbxFirstInput.Text + "\r\n تاريخ اول  : " + dt1.Text + "\r\n  تاريخ ثاني : " + dt2.Text;

                        rpt12.Parameters["Count"].Value = Dt.Rows.Count;
                        rpt12.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
                        rpt12.Parameters["Date"].Value = DateTime.Now.ToString("dd/MM/yyyy");
                        rpt12.Parameters["Quantity"].Value = String.Format("{0:#,###,###}", totalquantity);
                        rpt12.DataSource = dss;
                        rpt12.RequestParameters = false;
                        frm.documentViewer1.DocumentSource = rpt12;
                        frm.ShowDialog();
                        break;
                    case "خلاصة صرفيات الجهات غير الاستثمارية (مواقع)":
                        Dt = rp.FUEL_BillEXitPlaceDeptsInvestSummaryBetweenTowDate(cbxFirstInput.Text, false, dt1, dt2);
                        dss.Tables["BillExitPlaceDeptsSummaryBetweentowdate"].Clear();
                        totalquantity = 0;
                        for (int i = 0; i < Dt.Rows.Count; i++)
                        {
                            totalquantity += Convert.ToInt32(Dt.Rows[i][1]);
                            dss.Tables["BillExitPlaceDeptsSummaryBetweentowdate"].Rows.Add(i + 1, Dt.Rows[i][0], String.Format("{0:#,###,###}", Dt.Rows[i][1]), String.Format("{0:#,###,###}", Dt.Rows[i][2]));
                        }
                        REPORTS.BillExitPlaceDeptsSummaryBetweenTowDate rpt13 = new REPORTS.BillExitPlaceDeptsSummaryBetweenTowDate();
                        if (dt1.Value.Month == dt2.Value.Month && dt1.Value.Day == 1 && dt2.Value.Day >= 30)
                            rpt13.Parameters["RpType"].Value = "خلاصة صرفيات مواقع الجهات غير الاستثمارية من الوقود لشهر " + rp.mounthWord(dt1.Value.Month);
                        else
                            rpt13.Parameters["RpType"].Value = "خلاصة صرفيات مواقع الجهات غير الاستثمارية من الوقود";
                        rpt13.Parameters["RpTypeDetials"].Value = " المخزن : " + cbxFirstInput.Text + "\r\n تاريخ اول  : " + dt1.Text + "\r\n  تاريخ ثاني : " + dt2.Text;

                        rpt13.Parameters["Count"].Value = Dt.Rows.Count;
                        rpt13.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
                        rpt13.Parameters["Date"].Value = DateTime.Now.ToString("dd/MM/yyyy");
                        rpt13.Parameters["Quantity"].Value =  String.Format("{0:#,###,###}", totalquantity);
                        rpt13.DataSource = dss;
                        rpt13.RequestParameters = false;
                        frm.documentViewer1.DocumentSource = rpt13;
                        frm.ShowDialog();
                        break;

                    case "طباعة سلسلة فواتير تجهز المواقع بالوقود بين تاريخين":
                        Dt = rp.FUEL_BillExitPlaceBetweenTowDate(dt1, dt2, cbxFirstInput.Text);
                        CLS_FRMS.CLS_FuelExitPlace rpPlaceBill = new CLS_FRMS.CLS_FuelExitPlace();
                        DataTable DtPlaceBill = new DataTable();
                        DS.DSFuel dssPlaceBill = new DS.DSFuel();

                        DialogResult result1 = MessageBox.Show("هل تريد تأكيد طباعة فواتير عدد " + Dt.Rows.Count + "؟", "تأكيد", MessageBoxButtons.YesNo);
                        if (result1 == DialogResult.Yes)
                        {
                           
                            for (int j = 0; j < Dt.Rows.Count; j++)
                            {
                                DtPlaceBill = rpPlaceBill.SelectFuelExitPlaceBill(int.Parse(Dt.Rows[j][7].ToString()));
                                dssPlaceBill.Tables["FuelExitPlaceBill"].Clear();

                                for (int i = 0; i < DtPlaceBill.Rows.Count; i++)
                                {
                                    dssPlaceBill.Tables["FuelExitPlaceBill"].Rows.Add(DtPlaceBill.Rows[i][0], DateTime.Parse(DtPlaceBill.Rows[i][1].ToString()).ToString("dd/MM/yyyy"), DtPlaceBill.Rows[i][2], DtPlaceBill.Rows[i][3], DtPlaceBill.Rows[i][4], DtPlaceBill.Rows[i][5],
                                        DtPlaceBill.Rows[i][6], DtPlaceBill.Rows[i][7], DtPlaceBill.Rows[i][8], DtPlaceBill.Rows[i][9],
                                       DtPlaceBill.Rows[i][10], DtPlaceBill.Rows[i][11], DateTime.Parse(DtPlaceBill.Rows[i][12].ToString()).ToString("dd/MM/yyyy"));
                                }
                                REPORTS.FuelExitPlaceBill rptPlaceBill = new REPORTS.FuelExitPlaceBill();


                                rptPlaceBill.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();

                                rptPlaceBill.DataSource = dssPlaceBill;
                                rptPlaceBill.RequestParameters = false;
                                ReportPrintTool printTool = new ReportPrintTool(rptPlaceBill);
                                if (j == 0)
                                    printTool.PrintDialog();
                                else
                                    printTool.Print();
                            }
                           
                        }
                        break;
                }

            }
           
        }

        private void bgwork_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            if (RPNAME == "تقارير ادخال وقود")
            {
                switch (cbxRpType.Text)
                {
                    case "فواتير بين تاريخين":
                        CLS_FRMS.CLS_RPFuel rp = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt = new DataTable();
                        Dt = rp.FUEL_BillEntrayBetweenTowDate(cbxFirstInput.Text, dt1, dt2);
                        prog.Maximum = Dt.Rows.Count;
                        prog.Value = e.ProgressPercentage;
                        if (prog.Value == prog.Maximum - 1) { prog.Visible = false; prog.Value = 0; lb1.Visible = false; }
                        break;
                    case "فواتير حسب الشهر":
                        CLS_FRMS.CLS_RPFuel rp1 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt1 = new DataTable();
                        Dt1 = rp1.FUEL_BillEntrayByMonth(cbxFirstInput.Text, cbxSecondInput.Text, dt1, dt2);
                        prog.Maximum = Dt1.Rows.Count;
                        prog.Value = e.ProgressPercentage;
                        if (prog.Value == prog.Maximum - 1) { prog.Visible = false; prog.Value = 0; lb1.Visible = false; }
                        break;
                }
            }
            if (RPNAME == "تقارير اخراج وقود")
            {
                switch (cbxRpType.Text)
                {
                    case "فواتير بين تاريخين (عجلات)":
                    case "طباعة سلسلة فواتير تجهز عجلات بالوقود بين تاريخين":
                        CLS_FRMS.CLS_RPFuel rp = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt = new DataTable();
                        Dt = rp.FUEL_BillExitBetweenTowDate(dt1, dt2, cbxFirstInput.Text);
                        prog.Maximum = Dt.Rows.Count;
                        prog.Value = e.ProgressPercentage;
                        if (prog.Value == prog.Maximum - 1) { prog.Visible = false; prog.Value = 0; lb1.Visible = false; }
                        break;
                    case "فواتير قسم بين تاريخين (عجلات)":
                        CLS_FRMS.CLS_RPFuel rp1 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt1 = new DataTable();
                        Dt1 = rp1.FUEL_BillEXitDeptBetweenTowDate(cbxFirstInput.Text, cbxSecondInput.Text, dt1, dt2);
                        prog.Maximum = Dt1.Rows.Count;
                        prog.Value = e.ProgressPercentage;
                        if (prog.Value == prog.Maximum - 1) { prog.Visible = false; prog.Value = 0; lb1.Visible = false; }
                        break;
                    case "خلاصة صرفيات الاقسام بين تاريخين (عجلات)":
                        CLS_FRMS.CLS_RPFuel rp2 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt2 = new DataTable();
                        Dt2 = rp2.FUEL_BillEXitDeptsSummaryBetweenTowDate(cbxFirstInput.Text, dt1, dt2);
                        prog.Maximum = Dt2.Rows.Count;
                        prog.Value = e.ProgressPercentage;
                        if (prog.Value == prog.Maximum - 1) { prog.Visible = false; prog.Value = 0; lb1.Visible = false; }
                        break;
                    case "صرفيات عجلة بين تاريخين (عجلات)":
                        CLS_FRMS.CLS_RPFuel rp3 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt3 = new DataTable();
                        Dt3 = rp3.FUEL_BillEXitCarBetweenTowDate(cbxFirstInput.Text, dt1, dt2);
                        prog.Maximum = Dt3.Rows.Count;
                        prog.Value = e.ProgressPercentage;
                        if (prog.Value == prog.Maximum - 1) { prog.Visible = false; prog.Value = 0; lb1.Visible = false; }
                        break;
                    case "خلاصة عجلات بين تاريخين (عجلات)":
                        CLS_FRMS.CLS_RPFuel rp4 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt4 = new DataTable();
                        Dt4 = rp4.FUEL_BillEXitCarsSummaryBetweenTowDate(cbxFirstInput.Text, dt1, dt2);
                        prog.Maximum = Dt4.Rows.Count;
                        prog.Value = e.ProgressPercentage;
                        if (prog.Value == prog.Maximum - 1) { prog.Visible = false; prog.Value = 0; lb1.Visible = false; }
                        break;
                    case "خلاصة صرفيات الجهات الاستثمارية (عجلات)":
                        CLS_FRMS.CLS_RPFuel rp5 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt5 = new DataTable();
                        Dt5 = rp5.FUEL_BillEXitDeptsInvestSummaryBetweenTowDate(cbxFirstInput.Text,true, dt1, dt2);
                        prog.Maximum = Dt5.Rows.Count;
                        prog.Value = e.ProgressPercentage;
                        if (prog.Value == prog.Maximum - 1) { prog.Visible = false; prog.Value = 0; lb1.Visible = false; }
                        break;
                    case "خلاصة صرفيات الجهات غير الاستثمارية (عجلات)":
                        CLS_FRMS.CLS_RPFuel rp6 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt6 = new DataTable();
                        Dt6 = rp6.FUEL_BillEXitDeptsInvestSummaryBetweenTowDate(cbxFirstInput.Text, false, dt1, dt2);
                        prog.Maximum = Dt6.Rows.Count;
                        prog.Value = e.ProgressPercentage;
                        if (prog.Value == prog.Maximum - 1) { prog.Visible = false; prog.Value = 0; lb1.Visible = false; }
                        break;

                    //-------------------------------------------------------------------------------------------


                    case "فواتير بين تاريخين (مواقع)":
                    case "طباعة سلسلة فواتير تجهز المواقع بالوقود بين تاريخين":
                        CLS_FRMS.CLS_RPFuel rp7 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt7 = new DataTable();
                        Dt7 = rp7.FUEL_BillExitPlaceBetweenTowDate(dt1, dt2, cbxFirstInput.Text);
                        prog.Maximum = Dt7.Rows.Count;
                        prog.Value = e.ProgressPercentage;
                        if (prog.Value == prog.Maximum - 1) { prog.Visible = false; prog.Value = 0; lb1.Visible = false; }
                        break;
                    case "فواتير حسب الشهر (مواقع)":
                        CLS_FRMS.CLS_RPFuel rpmonth = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dtmonth = new DataTable();
                        Dtmonth = rpmonth.FUEL_BillExitPlaceByMonth(dt1, dt2,  cbxSecondInput.Text,cbxFirstInput.Text);
                        prog.Maximum = Dtmonth.Rows.Count;
                        prog.Value = e.ProgressPercentage;
                        if (prog.Value == prog.Maximum - 1) { prog.Visible = false; prog.Value = 0; lb1.Visible = false; }
                        break;
                    case "فواتير قسم بين تاريخين (مواقع)":
                        CLS_FRMS.CLS_RPFuel rp8 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt8 = new DataTable();
                        Dt8 = rp8.FUEL_BillEXitPlaceDeptBetweenTowDate(cbxFirstInput.Text, cbxSecondInput.Text, dt1, dt2);
                        prog.Maximum = Dt8.Rows.Count;
                        prog.Value = e.ProgressPercentage;
                        if (prog.Value == prog.Maximum - 1) { prog.Visible = false; prog.Value = 0; lb1.Visible = false; }
                        break;
                    case "خلاصة صرفيات الاقسام بين تاريخين (مواقع)":
                        CLS_FRMS.CLS_RPFuel rp9 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt9 = new DataTable();
                        Dt9 = rp9.FUEL_BillEXitPlaceDeptsSummaryBetweenTowDate(cbxFirstInput.Text, dt1, dt2);
                        prog.Maximum = Dt9.Rows.Count;
                        prog.Value = e.ProgressPercentage;
                        if (prog.Value == prog.Maximum - 1) { prog.Visible = false; prog.Value = 0; lb1.Visible = false; }
                        break;
                    case "صرفيات موقع بين تاريخين (مواقع)":
                        CLS_FRMS.CLS_RPFuel rp10 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt10 = new DataTable();
                        Dt10 = rp10.FUEL_BillEXitPlacesBetweenTowDate(cbxFirstInput.Text, dt1, dt2);
                        prog.Maximum = Dt10.Rows.Count;
                        prog.Value = e.ProgressPercentage;
                        if (prog.Value == prog.Maximum - 1) { prog.Visible = false; prog.Value = 0; lb1.Visible = false; }
                        break;
                    case "خلاصة مواقع بين تاريخين (مواقع)":
                        CLS_FRMS.CLS_RPFuel rp11= new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt11= new DataTable();
                        Dt11 = rp11.FUEL_BillEXitPlaceSummaryBetweenTowDate(cbxFirstInput.Text, dt1, dt2);
                        prog.Maximum = Dt11.Rows.Count;
                        prog.Value = e.ProgressPercentage;
                        if (prog.Value == prog.Maximum - 1) { prog.Visible = false; prog.Value = 0; lb1.Visible = false; }
                        break;
                    case "خلاصة صرفيات الجهات الاستثمارية (مواقع)":
                        CLS_FRMS.CLS_RPFuel rp12 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt12 = new DataTable();
                        Dt12 = rp12.FUEL_BillEXitPlaceDeptsInvestSummaryBetweenTowDate(cbxFirstInput.Text, true, dt1, dt2);
                        prog.Maximum = Dt12.Rows.Count;
                        prog.Value = e.ProgressPercentage;
                        if (prog.Value == prog.Maximum - 1) { prog.Visible = false; prog.Value = 0; lb1.Visible = false; }
                        break;
                    case "خلاصة صرفيات الجهات غير الاستثمارية (مواقع)":
                        CLS_FRMS.CLS_RPFuel rp13 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt13 = new DataTable();
                        Dt13 = rp13.FUEL_BillEXitPlaceDeptsInvestSummaryBetweenTowDate(cbxFirstInput.Text, false, dt1, dt2);
                        prog.Maximum = Dt13.Rows.Count;
                        prog.Value = e.ProgressPercentage;
                        if (prog.Value == prog.Maximum - 1) { prog.Visible = false; prog.Value = 0; lb1.Visible = false; }
                        break;
                }
            }

        }

        private void bgwork_DoWork(object sender, DoWorkEventArgs e)
        {

            string name = "";
            if (cbxRpType.InvokeRequired)
            {
                cbxRpType.Invoke(new MethodInvoker(delegate { name = cbxRpType.Text; }));
            }
            string name1 = "";
            if (cbxFirstInput.InvokeRequired)
            {
                cbxFirstInput.Invoke(new MethodInvoker(delegate { name1 = cbxFirstInput.Text; }));
            }
            string name2 = "";
            if (cbxSecondInput.InvokeRequired)
            {
                cbxSecondInput.Invoke(new MethodInvoker(delegate { name2 = cbxSecondInput.Text; }));
            }
            string Datetime1 = "";
            if (dt1.InvokeRequired)
            {
                dt1.Invoke(new MethodInvoker(delegate { Datetime1 = dt1.Text; }));
            }
            string Datetime2 = "";
            if (dt2.InvokeRequired)
            {
                dt2.Invoke(new MethodInvoker(delegate { Datetime2 = dt2.Text; }));
            }
            if (RPNAME == "تقارير اخراج وقود")
            {
                switch (name)
                {
                    case "فواتير بين تاريخين (عجلات)":
                    case "طباعة سلسلة فواتير تجهز عجلات بالوقود بين تاريخين":
                        CLS_FRMS.CLS_RPFuel rp = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt = new DataTable();
                        Dt = rp.FUEL_BillExitBetweenTowDate(dt1, dt2, name1);
                        DataTable Cons = Dt.Copy();
                        Cons.Clear();
                        for (int i = 0; i < Dt.Rows.Count; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < 1000; j++)
                            {
                                sum = sum + j;
                            }
                            lb1.Invoke((MethodInvoker)delegate { lb1.Text = i.ToString(); });
                            bgwork.ReportProgress(i);
                            Dgv.Invoke((MethodInvoker)delegate
                            {
                                Cons.ImportRow(Dt.Rows[i]);
                                CLS_FRMS.CLS_RPFuel dgv = new CLS_FRMS.CLS_RPFuel();
                                dgv.Dgvdesign(Dgv, Cons, cbxRpType, "اخراج");
                            });
                        }
                        break;
                    case "فواتير قسم بين تاريخين (عجلات)":
                        CLS_FRMS.CLS_RPFuel rp1 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt1 = new DataTable();


                        Dt1 = rp1.FUEL_BillEXitDeptBetweenTowDate(name1, name2, dt1, dt2);
                        DataTable Cons2 = Dt1.Copy();
                        Cons2.Clear();
                        for (int i = 0; i < Dt1.Rows.Count; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < 1000; j++)
                            {
                                sum = sum + j;
                            }
                            lb1.Invoke((MethodInvoker)delegate { lb1.Text = i.ToString(); });
                            bgwork.ReportProgress(i);
                            Dgv.Invoke((MethodInvoker)delegate
                            {
                                Cons2.ImportRow(Dt1.Rows[i]);
                                CLS_FRMS.CLS_RPFuel dgv = new CLS_FRMS.CLS_RPFuel();
                                dgv.Dgvdesign(Dgv, Cons2, cbxRpType, "اخراج");
                            });
                        }
                        break;
                    case "خلاصة صرفيات الاقسام بين تاريخين (عجلات)":
                        CLS_FRMS.CLS_RPFuel rp2 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt2 = new DataTable();
                        Dt2 = rp2.FUEL_BillEXitDeptsSummaryBetweenTowDate(name1, dt1, dt2);
                        DataTable Cons3 = Dt2.Copy();
                        Cons3.Clear();
                        for (int i = 0; i < Dt2.Rows.Count; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < 1000; j++)
                            {
                                sum = sum + j;
                            }
                            lb1.Invoke((MethodInvoker)delegate { lb1.Text = i.ToString(); });
                            bgwork.ReportProgress(i);
                            Dgv.Invoke((MethodInvoker)delegate
                            {
                                Cons3.ImportRow(Dt2.Rows[i]);
                                CLS_FRMS.CLS_RPFuel dgv = new CLS_FRMS.CLS_RPFuel();
                                dgv.Dgvdesign(Dgv, Cons3, cbxRpType, "اخراج");
                            });
                        }
                        break;
                    case "صرفيات عجلة بين تاريخين (عجلات)":
                        CLS_FRMS.CLS_RPFuel rp3 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt3 = new DataTable();
                        Dt3 = rp3.FUEL_BillEXitCarBetweenTowDate(name1, dt1, dt2);
                        DataTable Cons4 = Dt3.Copy();
                        Cons4.Clear();
                        for (int i = 0; i < Dt3.Rows.Count; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < 1000; j++)
                            {
                                sum = sum + j;
                            }
                            lb1.Invoke((MethodInvoker)delegate { lb1.Text = i.ToString(); });
                            bgwork.ReportProgress(i);
                            Dgv.Invoke((MethodInvoker)delegate
                            {
                                Cons4.ImportRow(Dt3.Rows[i]);
                                CLS_FRMS.CLS_RPFuel dgv = new CLS_FRMS.CLS_RPFuel();
                                dgv.Dgvdesign(Dgv, Cons4, cbxRpType, "اخراج");
                            });
                        }
                        break;
                    case "خلاصة عجلات بين تاريخين (عجلات)":
                        CLS_FRMS.CLS_RPFuel rp4 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt4 = new DataTable();
                        Dt4 = rp4.FUEL_BillEXitCarsSummaryBetweenTowDate(name1, dt1, dt2);
                        DataTable Cons5 = Dt4.Copy();
                        Cons5.Clear();
                        for (int i = 0; i < Dt4.Rows.Count; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < 1000; j++)
                            {
                                sum = sum + j;
                            }
                            lb1.Invoke((MethodInvoker)delegate { lb1.Text = i.ToString(); });
                            bgwork.ReportProgress(i);
                            Dgv.Invoke((MethodInvoker)delegate
                            {
                                Cons5.ImportRow(Dt4.Rows[i]);
                                CLS_FRMS.CLS_RPFuel dgv = new CLS_FRMS.CLS_RPFuel();
                                dgv.Dgvdesign(Dgv, Cons5, cbxRpType, "اخراج");
                            });
                        }
                        break;
                    case "خلاصة صرفيات الجهات الاستثمارية (عجلات)":
                        CLS_FRMS.CLS_RPFuel rp5 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt5 = new DataTable();
                        Dt5 = rp5.FUEL_BillEXitDeptsInvestSummaryBetweenTowDate(name1, true, dt1, dt2);
                        DataTable Cons6 = Dt5.Copy();
                        Cons6.Clear();
                        for (int i = 0; i < Dt5.Rows.Count; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < 1000; j++)
                            {
                                sum = sum + j;
                            }
                            lb1.Invoke((MethodInvoker)delegate { lb1.Text = i.ToString(); });
                            bgwork.ReportProgress(i);
                            Dgv.Invoke((MethodInvoker)delegate
                            {
                                Cons6.ImportRow(Dt5.Rows[i]);
                                CLS_FRMS.CLS_RPFuel dgv = new CLS_FRMS.CLS_RPFuel();
                                dgv.Dgvdesign(Dgv, Cons6, cbxRpType, "اخراج");
                            });
                        }
                        break;
                    case "خلاصة صرفيات الجهات غير الاستثمارية (عجلات)":
                        CLS_FRMS.CLS_RPFuel rp6 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt6 = new DataTable();
                        Dt6 = rp6.FUEL_BillEXitDeptsInvestSummaryBetweenTowDate(name1, false, dt1, dt2);
                        DataTable Cons7 = Dt6.Copy();
                        Cons7.Clear();
                        for (int i = 0; i < Dt6.Rows.Count; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < 1000; j++)
                            {
                                sum = sum + j;
                            }
                            lb1.Invoke((MethodInvoker)delegate { lb1.Text = i.ToString(); });
                            bgwork.ReportProgress(i);
                            Dgv.Invoke((MethodInvoker)delegate
                            {
                                Cons7.ImportRow(Dt6.Rows[i]);
                                CLS_FRMS.CLS_RPFuel dgv = new CLS_FRMS.CLS_RPFuel();
                                dgv.Dgvdesign(Dgv, Cons7, cbxRpType, "اخراج");
                            });
                        }
                        break;
                    //-------------------------------------------------------------------------------

                    case "فواتير بين تاريخين (مواقع)":
                    case "طباعة سلسلة فواتير تجهز المواقع بالوقود بين تاريخين":
                        CLS_FRMS.CLS_RPFuel rp7 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt7 = new DataTable();
                        Dt7 = rp7.FUEL_BillExitPlaceBetweenTowDate(dt1, dt2, name1);
                        DataTable Cons8 = Dt7.Copy();
                        Cons8.Clear();
                        for (int i = 0; i < Dt7.Rows.Count; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < 1000; j++)
                            {
                                sum = sum + j;
                            }
                            lb1.Invoke((MethodInvoker)delegate { lb1.Text = i.ToString(); });
                            bgwork.ReportProgress(i);
                            Dgv.Invoke((MethodInvoker)delegate
                            {
                                Cons8.ImportRow(Dt7.Rows[i]);
                                CLS_FRMS.CLS_RPFuel dgv = new CLS_FRMS.CLS_RPFuel();
                                dgv.Dgvdesign(Dgv, Cons8, cbxRpType, "اخراج");
                            });
                        }
                        break;
                    case "فواتير حسب الشهر (مواقع)":
                        CLS_FRMS.CLS_RPFuel rpmonth = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dtmonth = new DataTable();
                        Dtmonth = rpmonth.FUEL_BillExitPlaceByMonth(dt1, dt2, name2,name1);
                        DataTable Consmonth = Dtmonth.Copy();
                        Consmonth.Clear();
                        for (int i = 0; i < Dtmonth.Rows.Count; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < 1000; j++)
                            {
                                sum = sum + j;
                            }
                            lb1.Invoke((MethodInvoker)delegate { lb1.Text = i.ToString(); });
                            bgwork.ReportProgress(i);
                            Dgv.Invoke((MethodInvoker)delegate
                            {
                                Consmonth.ImportRow(Dtmonth.Rows[i]);
                                CLS_FRMS.CLS_RPFuel dgv = new CLS_FRMS.CLS_RPFuel();
                                dgv.Dgvdesign(Dgv, Consmonth, cbxRpType, "اخراج");
                            });
                        }
                        break;
                    case "فواتير قسم بين تاريخين (مواقع)":
                        CLS_FRMS.CLS_RPFuel rp8 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt8 = new DataTable();


                        Dt8 = rp8.FUEL_BillEXitPlaceDeptBetweenTowDate(name1, name2, dt1, dt2);
                        DataTable Cons9 = Dt8.Copy();
                        Cons9.Clear();
                        for (int i = 0; i < Dt8.Rows.Count; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < 1000; j++)
                            {
                                sum = sum + j;
                            }
                            lb1.Invoke((MethodInvoker)delegate { lb1.Text = i.ToString(); });
                            bgwork.ReportProgress(i);
                            Dgv.Invoke((MethodInvoker)delegate
                            {
                                Cons9.ImportRow(Dt8.Rows[i]);
                                CLS_FRMS.CLS_RPFuel dgv = new CLS_FRMS.CLS_RPFuel();
                                dgv.Dgvdesign(Dgv, Cons9, cbxRpType, "اخراج");
                            });
                        }
                        break;
                    case "خلاصة صرفيات الاقسام بين تاريخين (مواقع)":
                        CLS_FRMS.CLS_RPFuel rp9 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt9 = new DataTable();
                        Dt9 = rp9.FUEL_BillEXitPlaceDeptsSummaryBetweenTowDate(name1, dt1, dt2);
                        DataTable Cons10 = Dt9.Copy();
                        Cons10.Clear();
                        for (int i = 0; i < Dt9.Rows.Count; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < 1000; j++)
                            {
                                sum = sum + j;
                            }
                            lb1.Invoke((MethodInvoker)delegate { lb1.Text = i.ToString(); });
                            bgwork.ReportProgress(i);
                            Dgv.Invoke((MethodInvoker)delegate
                            {
                                Cons10.ImportRow(Dt9.Rows[i]);
                                CLS_FRMS.CLS_RPFuel dgv = new CLS_FRMS.CLS_RPFuel();
                                dgv.Dgvdesign(Dgv, Cons10, cbxRpType, "اخراج");
                            });
                        }
                        break;
                    case "صرفيات موقع بين تاريخين (مواقع)":
                        CLS_FRMS.CLS_RPFuel rp10 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt10 = new DataTable();
                        Dt10 = rp10.FUEL_BillEXitPlacesBetweenTowDate(name1, dt1, dt2);
                        DataTable Cons11 = Dt10.Copy();
                        Cons11.Clear();
                        for (int i = 0; i < Dt10.Rows.Count; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < 1000; j++)
                            {
                                sum = sum + j;
                            }
                            lb1.Invoke((MethodInvoker)delegate { lb1.Text = i.ToString(); });
                            bgwork.ReportProgress(i);
                            Dgv.Invoke((MethodInvoker)delegate
                            {
                                Cons11.ImportRow(Dt10.Rows[i]);
                                CLS_FRMS.CLS_RPFuel dgv = new CLS_FRMS.CLS_RPFuel();
                                dgv.Dgvdesign(Dgv, Cons11, cbxRpType, "اخراج");
                            });
                        }
                        break;
                    case "خلاصة مواقع بين تاريخين (مواقع)":
                        CLS_FRMS.CLS_RPFuel rp11 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt11 = new DataTable();
                        Dt11 = rp11.FUEL_BillEXitPlaceSummaryBetweenTowDate(name1, dt1, dt2);
                        DataTable Cons12 = Dt11.Copy();
                        Cons12.Clear();
                        for (int i = 0; i < Dt11.Rows.Count; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < 1000; j++)
                            {
                                sum = sum + j;
                            }
                            lb1.Invoke((MethodInvoker)delegate { lb1.Text = i.ToString(); });
                            bgwork.ReportProgress(i);
                            Dgv.Invoke((MethodInvoker)delegate
                            {
                                Cons12.ImportRow(Dt11.Rows[i]);
                                CLS_FRMS.CLS_RPFuel dgv = new CLS_FRMS.CLS_RPFuel();
                                dgv.Dgvdesign(Dgv, Cons12, cbxRpType, "اخراج");
                            });
                        }
                        break;
                    case "خلاصة صرفيات الجهات الاستثمارية (مواقع)":
                        CLS_FRMS.CLS_RPFuel rp12 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt12 = new DataTable();
                        Dt12 = rp12.FUEL_BillEXitPlaceDeptsInvestSummaryBetweenTowDate(name1, true, dt1, dt2);
                        DataTable Cons13 = Dt12.Copy();
                        Cons13.Clear();
                        for (int i = 0; i < Dt12.Rows.Count; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < 1000; j++)
                            {
                                sum = sum + j;
                            }
                            lb1.Invoke((MethodInvoker)delegate { lb1.Text = i.ToString(); });
                            bgwork.ReportProgress(i);
                            Dgv.Invoke((MethodInvoker)delegate
                            {
                                Cons13.ImportRow(Dt12.Rows[i]);
                                CLS_FRMS.CLS_RPFuel dgv = new CLS_FRMS.CLS_RPFuel();
                                dgv.Dgvdesign(Dgv, Cons13, cbxRpType, "اخراج");
                            });
                        }
                        break;
                    case "خلاصة صرفيات الجهات غير الاستثمارية (مواقع)":
                        CLS_FRMS.CLS_RPFuel rp13 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt13 = new DataTable();
                        Dt13 = rp13.FUEL_BillEXitPlaceDeptsInvestSummaryBetweenTowDate(name1, false, dt1, dt2);
                        DataTable Cons14 = Dt13.Copy();
                        Cons14.Clear();
                        for (int i = 0; i < Dt13.Rows.Count; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < 1000; j++)
                            {
                                sum = sum + j;
                            }
                            lb1.Invoke((MethodInvoker)delegate { lb1.Text = i.ToString(); });
                            bgwork.ReportProgress(i);
                            Dgv.Invoke((MethodInvoker)delegate
                            {
                                Cons14.ImportRow(Dt13.Rows[i]);
                                CLS_FRMS.CLS_RPFuel dgv = new CLS_FRMS.CLS_RPFuel();
                                dgv.Dgvdesign(Dgv, Cons14, cbxRpType, "اخراج");
                            });
                        }
                        break;
                }
            }
            else if (RPNAME == "تقارير ادخال وقود")
            {
                switch (name)
                {
                    case "فواتير بين تاريخين":
                        CLS_FRMS.CLS_RPFuel rp = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt = new DataTable();
                        Dt = rp.FUEL_BillEntrayBetweenTowDate(name1, dt1, dt2);
                        DataTable Cons = Dt.Copy();
                        Cons.Clear();
                        for (int i = 0; i < Dt.Rows.Count; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < 1000; j++)
                            {
                                sum = sum + j;
                            }
                            lb1.Invoke((MethodInvoker)delegate { lb1.Text = i.ToString(); });
                            bgwork.ReportProgress(i);
                            Dgv.Invoke((MethodInvoker)delegate
                            {
                                Cons.ImportRow(Dt.Rows[i]);
                                CLS_FRMS.CLS_RPFuel dgv = new CLS_FRMS.CLS_RPFuel();
                                dgv.Dgvdesign(Dgv, Cons, cbxRpType, "ادخال");
                            });
                        }
                        break;
                    case "فواتير حسب الشهر":
                        CLS_FRMS.CLS_RPFuel rp1 = new CLS_FRMS.CLS_RPFuel();
                        DataTable Dt1 = new DataTable();
                        Dt1 = rp1.FUEL_BillEntrayByMonth(name1,name2, dt1, dt2);
                        DataTable Cons1 = Dt1.Copy();
                        Cons1.Clear();
                        for (int i = 0; i < Dt1.Rows.Count; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < 1000; j++)
                            {
                                sum = sum + j;
                            }
                            lb1.Invoke((MethodInvoker)delegate { lb1.Text = i.ToString(); });
                            bgwork.ReportProgress(i);
                            Dgv.Invoke((MethodInvoker)delegate
                            {
                                Cons1.ImportRow(Dt1.Rows[i]);
                                CLS_FRMS.CLS_RPFuel dgv = new CLS_FRMS.CLS_RPFuel();
                                dgv.Dgvdesign(Dgv, Cons1, cbxRpType, "ادخال");
                            });
                        }
                        break;
                }
            }

        }

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            (Dgv.DataSource as DataTable).DefaultView.RowFilter = string.Format("[BillNo] LIKE '%{0}%'", txtSearch.Text);

        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}