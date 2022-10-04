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
    public partial class FRMRPCAR : DevExpress.XtraEditors.XtraForm
    {
        public FRMRPCAR()
        {
            InitializeComponent();
        }

        private void gunaButton12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMRPCAR_Load(object sender, EventArgs e)
        {
            string[] s = {"حسب نوع العجلة","حسب عائدية العجلة", "حسب الشعبة", "حسب نوع الوقود","حسب نوع العجلة والعائدية","خلاصة حسب نوع العجلة","خلاصة حسب العائدية" };
            for (int i = 0; i < s.Length; i++)
            {
                cbxRpType.Items.Add(s[i]);
            }
        }

        private void cbxRpType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            switch (cbxRpType.Text)
            {
                case "حسب نوع العجلة":
                    keyboard2.Visible = true;
                    cbxFirstInput.Visible = true;
                    lblFirstInput.Visible = true;
                    lblFirstInput.Text = "نوع العجلة:";
                    cbxSecondInput.Visible = false;
                    lblSecondInput.Visible = false;
                        cbxFirstInput.DataSource = null;
                        keyboard3.Visible = false;
                    cbxFirstInput.Items.Clear();
                    CLS_FRMS.CLS_Car carType = new CLS_FRMS.CLS_Car();
                    DataTable DtCar = carType.GetDataCar();
                    for (int i = 0; i < DtCar.Rows.Count; i++)
                    {
                        int j = 0;
                        while (j < cbxFirstInput.Items.Count && DtCar.Rows[i][2].ToString() != cbxFirstInput.Items[j].ToString())
                            j++;
                        if (j == cbxFirstInput.Items.Count && DtCar.Rows[i][2] != null && DtCar.Rows[i][2].ToString() != "")
                            cbxFirstInput.Items.Add(DtCar.Rows[i][2]);
                    }

                    break;
                case "حسب عائدية العجلة":

                    lblFirstInput.Text = "عائدية العجلة:";
                    keyboard2.Visible = true;
                    cbxFirstInput.Visible = true;
                    lblFirstInput.Visible = true;
                    cbxSecondInput.Visible = false;
                    lblSecondInput.Visible = false;
                    keyboard3.Visible = false;
                    cbxFirstInput.Items.Clear();
                        cbxFirstInput.DataSource = null;
                        CLS_FRMS.CLS_Car carDep = new CLS_FRMS.CLS_Car();
                    DataTable DtCarDep = carDep.GetDataCar();
                    for (int i = 0; i < DtCarDep.Rows.Count; i++)
                    {
                        int j = 0;
                        while (j < cbxFirstInput.Items.Count && DtCarDep.Rows[i][4].ToString() != cbxFirstInput.Items[j].ToString())
                            j++;
                        if (j == cbxFirstInput.Items.Count && DtCarDep.Rows[i][4] != null && DtCarDep.Rows[i][4].ToString() != "")
                            cbxFirstInput.Items.Add(DtCarDep.Rows[i][4]);
                    }

                    break;

                    case "حسب الشعبة":

                        lblFirstInput.Text = "الشعبة:";
                        keyboard2.Visible = true;
                        cbxFirstInput.Visible = true;
                        lblFirstInput.Visible = true;
                        cbxSecondInput.Visible = false;
                        lblSecondInput.Visible = false;
                        keyboard3.Visible = false;
                        cbxFirstInput.DataSource=null;
                        CLS_FRMS.CLS_Department carDivision = new CLS_FRMS.CLS_Department();
                        DataTable DtCarDivision = carDivision.GetDataPlaces();
                        cbxFirstInput.DataSource = DtCarDivision;
                        cbxFirstInput.DisplayMember = "Place";

                        break;
                    case "حسب نوع الوقود":
                    lblFirstInput.Text = "نوع الوقود:";
                    keyboard2.Visible = true;
                    cbxFirstInput.Visible = true;
                    lblFirstInput.Visible = true;
                    cbxSecondInput.Visible = false;
                    lblSecondInput.Visible = false;
                     cbxFirstInput.DataSource = null;
                     keyboard3.Visible = false;
                    cbxFirstInput.Items.Clear();
                    string[] s2 = { "بنزين", "كاز", "ديزل", "زيت الغاز" };
                    for (int i = 0; i < s2.Length; i++)
                    {
                        cbxFirstInput.Items.Add(s2[i]);
                    }

                    break;
                case "حسب نوع العجلة والعائدية":
                    keyboard2.Visible = true;
                    cbxFirstInput.Visible = true;
                    lblFirstInput.Visible = true;
                    cbxSecondInput.Visible = true;
                    lblSecondInput.Visible = true;
                    lblFirstInput.Text = "نوع العجلة:";
                        cbxFirstInput.DataSource = null;
                        lblSecondInput.Text = "عائدية العجلة:";
                    keyboard3.Visible = true;
                    cbxFirstInput.Items.Clear();
                    cbxSecondInput.Items.Clear();
                    CLS_FRMS.CLS_Car carTypeDept = new CLS_FRMS.CLS_Car();
                    DataTable DtCarTypeDept = carTypeDept.GetDataCar();
                    for (int i = 0; i < DtCarTypeDept.Rows.Count; i++)
                    {
                        int j = 0;
                        while (j < cbxFirstInput.Items.Count && DtCarTypeDept.Rows[i][2].ToString() != cbxFirstInput.Items[j].ToString())
                            j++;
                        if (j == cbxFirstInput.Items.Count && DtCarTypeDept.Rows[i][2] != null && DtCarTypeDept.Rows[i][2].ToString() != "")
                            cbxFirstInput.Items.Add(DtCarTypeDept.Rows[i][2]);

                        int z = 0;
                        while (z < cbxSecondInput.Items.Count && DtCarTypeDept.Rows[i][4].ToString() != cbxSecondInput.Items[z].ToString())
                            z++;
                        if (z == cbxSecondInput.Items.Count && DtCarTypeDept.Rows[i][4] != null && DtCarTypeDept.Rows[i][4].ToString() != "")
                            cbxSecondInput.Items.Add(DtCarTypeDept.Rows[i][4]);
                    }

                    break;
                case "خلاصة حسب نوع العجلة":
                    lblFirstInput.Text = "نوع العجلة:";
                        keyboard2.Visible = true;
                        cbxFirstInput.Visible = true;
                        lblFirstInput.Visible = true;
                        cbxSecondInput.Visible = false;
                    lblSecondInput.Visible = false;
                        cbxFirstInput.DataSource = null;
                        keyboard3.Visible = false;
                    cbxFirstInput.Items.Clear();
                    CLS_FRMS.CLS_Car carTypeSummry = new CLS_FRMS.CLS_Car();
                    DataTable DtCarsummry = carTypeSummry.GetDataCar();
                    for (int i = 0; i < DtCarsummry.Rows.Count; i++)
                    {
                        int j = 0;
                        while (j < cbxFirstInput.Items.Count && DtCarsummry.Rows[i][2].ToString() != cbxFirstInput.Items[j].ToString())
                            j++;
                        if (j == cbxFirstInput.Items.Count && DtCarsummry.Rows[i][2] != null && DtCarsummry.Rows[i][2].ToString() != "")
                            cbxFirstInput.Items.Add(DtCarsummry.Rows[i][2]);
                    }
                    break;
                case "خلاصة حسب العائدية":                   
                    keyboard2.Visible = false;
                    cbxFirstInput.Visible = false;
                    lblFirstInput.Visible = false;
                    keyboard3.Visible = false;
                    cbxSecondInput.Visible = false;
                    lblSecondInput.Visible = false;
                        cbxFirstInput.DataSource = null;
                        break;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(cbxRpType);
            key.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(cbxFirstInput);
            key.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(cbxSecondInput);
            key.ShowDialog();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            Dgv.DataSource = null;
            if (bgworker.IsBusy) { label1.Visible = true; }
            else { bgworker.RunWorkerAsync(); label1.Visible = false; }
            if (prog.Visible == false) { prog.Visible = true; }
            if (lb1.Visible == false) { lb1.Visible = true; }

        }

        private void bgworker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
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

                switch (name)
                {
                    case "حسب نوع العجلة":
                        CLS_FRMS.CLS_Car rp = new CLS_FRMS.CLS_Car();
                        DataTable Dt = new DataTable();
                        Dt = rp.SelectCarsByCarType(name1);
                        DataTable Cons = Dt.Copy();
                        Cons.Clear();
                        for (int i = 0; i < Dt.Rows.Count; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < 100; j++)
                            {
                                sum = sum + j;
                            }
                            lb1.Invoke((MethodInvoker)delegate { lb1.Text = i.ToString(); });
                            bgworker.ReportProgress(i);
                            Dgv.Invoke((MethodInvoker)delegate
                            {
                                Cons.ImportRow(Dt.Rows[i]);
                                CLS_FRMS.CLS_Car dgv = new CLS_FRMS.CLS_Car();
                                dgv.Dgvdesign(Dgv, Cons, cbxRpType);
                            });
                        }
                        break;


                    case "حسب عائدية العجلة":
                        CLS_FRMS.CLS_Car rp3 = new CLS_FRMS.CLS_Car();
                        DataTable Dt3 = new DataTable();
                        Dt3 = rp3.SelectCarsByCarDep(name1);
                        DataTable Cons3 = Dt3.Copy();
                        Cons3.Clear();
                        for (int i = 0; i < Dt3.Rows.Count; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < 100; j++)
                            {
                                sum = sum + j;
                            }
                            lb1.Invoke((MethodInvoker)delegate { lb1.Text = i.ToString(); });
                            bgworker.ReportProgress(i);
                            Dgv.Invoke((MethodInvoker)delegate
                            {
                                Cons3.ImportRow(Dt3.Rows[i]);
                                CLS_FRMS.CLS_Car dgv = new CLS_FRMS.CLS_Car();
                                dgv.Dgvdesign(Dgv, Cons3, cbxRpType);
                            });
                        }
                        break;
                    case "حسب الشعبة":
                        CLS_FRMS.CLS_Car rpDiv = new CLS_FRMS.CLS_Car();
                        DataTable DtDiv = new DataTable();
                        DtDiv = rpDiv.SelectCarsByCarDivision(name1);
                        DataTable ConsDiv = DtDiv.Copy();
                        ConsDiv.Clear();
                        for (int i = 0; i < DtDiv.Rows.Count; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < 100; j++)
                            {
                                sum = sum + j;
                            }
                            lb1.Invoke((MethodInvoker)delegate { lb1.Text = i.ToString(); });
                            bgworker.ReportProgress(i);
                            Dgv.Invoke((MethodInvoker)delegate
                            {
                                ConsDiv.ImportRow(DtDiv.Rows[i]);
                                CLS_FRMS.CLS_Car dgv = new CLS_FRMS.CLS_Car();
                                dgv.Dgvdesign(Dgv, ConsDiv, cbxRpType);
                            });
                        }
                        break;
                    case "حسب نوع الوقود":
                        CLS_FRMS.CLS_Car rp4 = new CLS_FRMS.CLS_Car();
                        DataTable Dt4 = new DataTable();
                        Dt4 = rp4.SelectCarsByCarFuel(name1);
                        DataTable Cons4 = Dt4.Copy();
                        Cons4.Clear();
                        for (int i = 0; i < Dt4.Rows.Count; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < 100; j++)
                            {
                                sum = sum + j;
                            }
                            lb1.Invoke((MethodInvoker)delegate { lb1.Text = i.ToString(); });
                            bgworker.ReportProgress(i);
                            Dgv.Invoke((MethodInvoker)delegate
                            {
                                Cons4.ImportRow(Dt4.Rows[i]);
                                CLS_FRMS.CLS_Car dgv = new CLS_FRMS.CLS_Car();
                                dgv.Dgvdesign(Dgv, Cons4, cbxRpType);
                            });
                        }
                        break;



                    case "حسب نوع العجلة والعائدية":
                        CLS_FRMS.CLS_Car rp9 = new CLS_FRMS.CLS_Car();
                        DataTable Dt9 = new DataTable();
                        Dt9 = rp9.SelectCarsByCarTypeandDep(name1, name2);
                        DataTable Cons9 = Dt9.Copy();
                        Cons9.Clear();
                        for (int i = 0; i < Dt9.Rows.Count; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < 100; j++)
                            {
                                sum = sum + j;
                            }
                            lb1.Invoke((MethodInvoker)delegate { lb1.Text = i.ToString(); });
                            bgworker.ReportProgress(i);
                            Dgv.Invoke((MethodInvoker)delegate
                            {
                                Cons9.ImportRow(Dt9.Rows[i]);
                                CLS_FRMS.CLS_Car dgv = new CLS_FRMS.CLS_Car();
                                dgv.Dgvdesign(Dgv, Cons9, cbxRpType);
                            });
                        }
                        break;



                    case "خلاصة حسب نوع العجلة":
                        CLS_FRMS.CLS_Car rp12 = new CLS_FRMS.CLS_Car();
                        DataTable Dt12 = new DataTable();
                        Dt12 = rp12.SummryCarType(name1);
                        DataTable Cons12 = Dt12.Copy();
                        Cons12.Clear();
                        for (int i = 0; i < Dt12.Rows.Count; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < 100; j++)
                            {
                                sum = sum + j;
                            }
                            lb1.Invoke((MethodInvoker)delegate { lb1.Text = i.ToString(); });
                            bgworker.ReportProgress(i);
                            Dgv.Invoke((MethodInvoker)delegate
                            {
                                Cons12.ImportRow(Dt12.Rows[i]);
                                CLS_FRMS.CLS_Car dgv = new CLS_FRMS.CLS_Car();
                                dgv.Dgvdesign(Dgv, Cons12, cbxRpType);
                            });
                        }
                        break;

                    case "خلاصة حسب العائدية":
                        CLS_FRMS.CLS_Car rp14 = new CLS_FRMS.CLS_Car();
                        DataTable Dt14 = new DataTable();
                        Dt14 = rp14.SummryCarDEpartment();
                        DataTable Cons14 = Dt14.Copy();
                        Cons14.Clear();
                        for (int i = 0; i < Dt14.Rows.Count; i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < 10; j++)
                            {
                                sum = sum + j;
                            }
                            lb1.Invoke((MethodInvoker)delegate { lb1.Text = i.ToString(); });
                            bgworker.ReportProgress(i);
                            Dgv.Invoke((MethodInvoker)delegate
                            {
                                Cons14.ImportRow(Dt14.Rows[i]);
                                CLS_FRMS.CLS_Car dgv = new CLS_FRMS.CLS_Car();
                                dgv.Dgvdesign(Dgv, Cons14, cbxRpType);
                            });
                        }
                        break;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bgworker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                switch (cbxRpType.Text)
                {
                    case "حسب نوع العجلة":
                        CLS_FRMS.CLS_Car rp = new CLS_FRMS.CLS_Car();
                        DataTable Dt = new DataTable();
                        Dt = rp.SelectCarsByCarType(cbxFirstInput.Text);
                        prog.Maximum = Dt.Rows.Count;
                        prog.Value = e.ProgressPercentage;
                        if (prog.Value == prog.Maximum - 1) { prog.Visible = false; prog.Value = 0; lb1.Visible = false; }
                        break;


                    case "حسب عائدية العجلة":
                        CLS_FRMS.CLS_Car rp3 = new CLS_FRMS.CLS_Car();
                        DataTable Dt3 = new DataTable();
                        Dt3 = rp3.SelectCarsByCarDep(cbxFirstInput.Text);
                        prog.Maximum = Dt3.Rows.Count;
                        prog.Value = e.ProgressPercentage;
                        if (prog.Value == prog.Maximum - 1) { prog.Visible = false; prog.Value = 0; lb1.Visible = false; }
                        break;
                    case "حسب الشعبة":
                        CLS_FRMS.CLS_Car rpDiv = new CLS_FRMS.CLS_Car();
                        DataTable DtDiv = new DataTable();
                        DtDiv = rpDiv.SelectCarsByCarDivision(cbxFirstInput.Text);
                        prog.Maximum = DtDiv.Rows.Count;
                        prog.Value = e.ProgressPercentage;
                        if (prog.Value == prog.Maximum - 1) { prog.Visible = false; prog.Value = 0; lb1.Visible = false; }
                        break;
                    case "حسب نوع الوقود":
                        CLS_FRMS.CLS_Car rp4 = new CLS_FRMS.CLS_Car();
                        DataTable Dt4 = new DataTable();
                        Dt4 = rp4.SelectCarsByCarFuel(cbxFirstInput.Text);
                        prog.Maximum = Dt4.Rows.Count;
                        prog.Value = e.ProgressPercentage;
                        if (prog.Value == prog.Maximum - 1) { prog.Visible = false; prog.Value = 0; lb1.Visible = false; }
                        break;



                    case "حسب نوع العجلة والعائدية":
                        CLS_FRMS.CLS_Car rp9 = new CLS_FRMS.CLS_Car();
                        DataTable Dt9 = new DataTable();
                        Dt9 = rp9.SelectCarsByCarTypeandDep(cbxFirstInput.Text, cbxSecondInput.Text);
                        prog.Maximum = Dt9.Rows.Count;
                        prog.Value = e.ProgressPercentage;
                        if (prog.Value == prog.Maximum - 1) { prog.Visible = false; prog.Value = 0; lb1.Visible = false; }
                        break;



                    case "خلاصة حسب نوع العجلة":
                        CLS_FRMS.CLS_Car rp12 = new CLS_FRMS.CLS_Car();
                        DataTable Dt12 = new DataTable();
                        Dt12 = rp12.SummryCarType(cbxFirstInput.Text);
                        prog.Maximum = Dt12.Rows.Count;
                        prog.Value = e.ProgressPercentage;
                        if (prog.Value == prog.Maximum - 1) { prog.Visible = false; prog.Value = 0; lb1.Visible = false; }
                        break;

                    case "خلاصة حسب العائدية":
                        CLS_FRMS.CLS_Car rp14 = new CLS_FRMS.CLS_Car();
                        DataTable Dt14 = new DataTable();
                        Dt14 = rp14.SummryCarDEpartment();
                        prog.Maximum = Dt14.Rows.Count;
                        prog.Value = e.ProgressPercentage;
                        if (prog.Value == prog.Maximum - 1) { prog.Visible = false; prog.Value = 0; lb1.Visible = false; }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cbxRpType.Text)
                {
                    case "حسب نوع العجلة":
                        (Dgv.DataSource as DataTable).DefaultView.RowFilter = string.Format("[CarNo] LIKE '%{0}%' OR [CarFuel] like'%{1}%' OR [TheBenficary] like'%{2}%'", txtSearch.Text, txtSearch.Text, txtSearch.Text);

                        break;


                    case "حسب عائدية العجلة":
                        (Dgv.DataSource as DataTable).DefaultView.RowFilter = string.Format("[CarNo] LIKE '%{0}%' OR [CarType] like'%{1}%' OR [CarFuel] like'%{2}%'", txtSearch.Text, txtSearch.Text, txtSearch.Text);

                        break;
                    case "حسب الشعبة":
                        (Dgv.DataSource as DataTable).DefaultView.RowFilter = string.Format("[CarNo] LIKE '%{0}%' OR [CarType] like'%{1}%' OR [CarFuel] like'%{2}%' or [TheBenficary] like'%{3}%'", txtSearch.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text);

                        break;
                    case "حسب نوع الوقود":
                        (Dgv.DataSource as DataTable).DefaultView.RowFilter = string.Format("[CarNo] LIKE '%{0}%' OR [CarType] like'%{1}%' OR [TheBenficary] like'%{2}%'", txtSearch.Text, txtSearch.Text, txtSearch.Text);

                        break;



                    case "حسب نوع العجلة والعائدية":
                        (Dgv.DataSource as DataTable).DefaultView.RowFilter = string.Format("[CarNo] LIKE '%{0}%' OR [CarFuel] like'%{1}%'", txtSearch.Text, txtSearch.Text);

                        break;



                    case "خلاصة حسب نوع العجلة":
                        (Dgv.DataSource as DataTable).DefaultView.RowFilter = string.Format("[TheBenficary] LIKE '%{0}%'", txtSearch.Text);

                        break;

                    case "خلاصة حسب العائدية":
                        (Dgv.DataSource as DataTable).DefaultView.RowFilter = string.Format("[TheBenficary] LIKE '%{0}%' OR [CarType] like'%{1}%'", txtSearch.Text, txtSearch.Text);

                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrintExitBill_Click(object sender, EventArgs e)
        {
            CLS_FRMS.CLS_Car rp = new CLS_FRMS.CLS_Car();
            DataTable Dt = new DataTable();
            DS.DSFuel dss = new DS.DSFuel();
            REPORTS.ReportViewer frm = new REPORTS.ReportViewer();
            switch (cbxRpType.Text)
            {
                case "حسب نوع العجلة":
                    Dt = rp.SelectCarsByCarType(cbxFirstInput.Text);
                    dss.Tables["CarsByType"].Clear();

                    for (int i = 0; i < Dt.Rows.Count; i++)
                    {

                        dss.Tables["CarsByType"].Rows.Add(i+1,Dt.Rows[i][0], Dt.Rows[i][1], Dt.Rows[i][2]);
                    }
                    REPORTS.CarsByType rpt = new REPORTS.CarsByType();


                    rpt.Parameters["RpType"].Value = "تقرير العجلات " + cbxRpType.Text + "\r\n نوع العجلة: " + cbxFirstInput.Text;

                    rpt.Parameters["CarCounts"].Value = Dt.Rows.Count;
                    rpt.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
                    rpt.DataSource = dss;
                    rpt.RequestParameters = false;
                    frm.documentViewer1.DocumentSource = rpt;
                    break;
             
                case "حسب عائدية العجلة":

                    Dt = rp.SelectCarsByCarDep(cbxFirstInput.Text);
                    dss.Tables["CarsbyDept"].Clear();

                    for (int i = 0; i < Dt.Rows.Count; i++)
                    {

                        dss.Tables["CarsbyDept"].Rows.Add(i+1,Dt.Rows[i][0], Dt.Rows[i][1], Dt.Rows[i][2]);
                    }
                    REPORTS.CarByDept rpt3 = new REPORTS.CarByDept();


                    rpt3.Parameters["RpType"].Value = "تقرير العجلات " + cbxRpType.Text + "\r\nعائدية العجلة: " + cbxFirstInput.Text;
                    rpt3.Parameters["CarsCount"].Value = Dt.Rows.Count;
                    rpt3.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
                    rpt3.DataSource = dss;
                    rpt3.RequestParameters = false;
                    frm.documentViewer1.DocumentSource = rpt3;
                    break;
                case "حسب الشعبة":

                    Dt = rp.SelectCarsByCarDivision(cbxFirstInput.Text);
                    dss.Tables["CarByDivision"].Clear();

                    for (int i = 0; i < Dt.Rows.Count; i++)
                    {

                        dss.Tables["CarByDivision"].Rows.Add(i + 1, Dt.Rows[i][0], Dt.Rows[i][1], Dt.Rows[i][2], Dt.Rows[i][3]);
                    }
                    REPORTS.CarByDivision rptDiv = new REPORTS.CarByDivision();


                    rptDiv.Parameters["RpType"].Value = "تقرير العجلات " + cbxRpType.Text + "\r\nالشعبة: " + cbxFirstInput.Text;
                    rptDiv.Parameters["CarCount"].Value = Dt.Rows.Count;
                    rptDiv.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
                    rptDiv.DataSource = dss;
                    rptDiv.RequestParameters = false;
                    frm.documentViewer1.DocumentSource = rptDiv;
                    break;
                case "حسب نوع الوقود":

                    Dt = rp.SelectCarsByCarFuel(cbxFirstInput.Text);
                    dss.Tables["CarFuel"].Clear();

                    for (int i = 0; i < Dt.Rows.Count; i++)
                    {

                        dss.Tables["CarFuel"].Rows.Add(i+1,Dt.Rows[i][0], Dt.Rows[i][1], Dt.Rows[i][2]);
                    }
                    REPORTS.carByFuel rpt4 = new REPORTS.carByFuel();


                    rpt4.Parameters["RpType"].Value = "تقرير العجلات " + cbxRpType.Text + "\r\nنوع الوقود: " + cbxFirstInput.Text;
                    rpt4.Parameters["CarsCount"].Value = Dt.Rows.Count;
                    rpt4.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
                    rpt4.DataSource = dss;
                    rpt4.RequestParameters = false;
                    frm.documentViewer1.DocumentSource = rpt4;
                    break;
                
               
               
               
                case "حسب نوع العجلة والعائدية":

                    Dt = rp.SelectCarsByCarTypeandDep(cbxFirstInput.Text, cbxSecondInput.Text);

                    dss.Tables["CarbytypeandDept"].Clear();

                    for (int i = 0; i < Dt.Rows.Count; i++)
                    {

                        dss.Tables["CarbytypeandDept"].Rows.Add(i+1,Dt.Rows[i][0], Dt.Rows[i][1]);
                    }
                    REPORTS.CarsByTypeAndDept rpt9 = new REPORTS.CarsByTypeAndDept();


                    rpt9.Parameters["RpType"].Value = "تقرير العجلات " + cbxRpType.Text + "\r\nنوع العجلة: " + cbxFirstInput.Text + " \r\nعائدية العجلة: " + cbxSecondInput.Text;

                    rpt9.Parameters["CarsCount"].Value = Dt.Rows.Count;
                    rpt9.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
                    rpt9.DataSource = dss;
                    rpt9.RequestParameters = false;
                    frm.documentViewer1.DocumentSource = rpt9;
                    break;

                

               
                case "خلاصة حسب نوع العجلة":

                    Dt = rp.SummryCarType(cbxFirstInput.Text);

                    dss.Tables["SummryCarbyType"].Clear();
                    int sum = 0;
                    for (int i = 0; i < Dt.Rows.Count; i++)
                    {
                        dss.Tables["SummryCarbyType"].Rows.Add(i + 1, Dt.Rows[i][0], Dt.Rows[i][1]);
                        sum += int.Parse(Dt.Rows[i][1].ToString());
                    }
                    REPORTS.SummryCarType rpt12 = new REPORTS.SummryCarType();

                    rpt12.Parameters["RpType"].Value = "تقرير العجلات " + cbxRpType.Text + "\r\nنوع العجلة: " + cbxFirstInput.Text;
                    rpt12.Parameters["CarsCount"].Value = sum.ToString();
                    rpt12.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
                    rpt12.DataSource = dss;
                    rpt12.RequestParameters = false;
                    frm.documentViewer1.DocumentSource = rpt12;
                    break;
              
                case "خلاصة حسب العائدية":

                    Dt = rp.SummryCarDEpartment();

                    dss.Tables["SummryCarbyDept"].Clear();
                    string dept = Dt.Rows[0][0].ToString();
                    int index = 1;
                    for (int i = 0; i < Dt.Rows.Count; i++)
                    {

                        if (dept != Dt.Rows[i][0].ToString())
                        {
                            index++;
                            dept = Dt.Rows[i][0].ToString();

                        }
                        dss.Tables["SummryCarbyDept"].Rows.Add(index, Dt.Rows[i][0], Dt.Rows[i][1], Dt.Rows[i][2]);

                    }
                    REPORTS.SummryByDept rpt14 = new REPORTS.SummryByDept();


                    rpt14.Parameters["RpType"].Value = "تقرير العجلات " + cbxRpType.Text;

                    rpt14.Parameters["UserName"].Value = Properties.Settings.Default.UserName.ToString();
                    rpt14.DataSource = dss;
                    rpt14.RequestParameters = false;
                    frm.documentViewer1.DocumentSource = rpt14;
                    break;
            }



            frm.ShowDialog();

        }
    }
}