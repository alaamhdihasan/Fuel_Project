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
    public partial class FRMMAIN : DevExpress.XtraEditors.XtraForm
    {
        List<Tuple<string, int>> notifclist;

        public FRMMAIN()
        {
            InitializeComponent();
        }

        private void gunaLinePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {
            if (pnlLeft.Width == 200)
            {
                pnlLeft.Width = 50;
                picLogo.Visible = false;
                btnFile.Text = null;
                btnConstant.Text = null;
                btnFuelEntry.Text = null;
                btnFuelExit.Text = null;
                btnControl.Text = null;
                btnSitting.Text = null;
            }
            else if (pnlLeft.Width == 50)
            {
                pnlLeft.Width = 200;
                picLogo.Visible = true;
                btnFile.Text = "ملف";
                btnConstant.Text = "مدخلات ثابتة";
                btnFuelEntry.Text = "ادخال وقود";
                btnFuelExit.Text = "اخراج وقود";
                btnControl.Text = "لوحة المراقبة";
                btnSitting.Text = "الاعدادات";
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (pnlFile.Visible == false)
            {
                pnlControl.Visible = false;
                pnlSitting.Visible = false;
                pnlFuelExit.Visible = false;
                pnlFuelEntry.Visible = false;
                pnlConstantEntry.Visible = false;
                pnlFile.Visible = true;
                pnlFile.Width = 200;
                pnlFile.Dock = DockStyle.Right;
               
            }
            else
            {
                pnlFile.Visible = false;
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            pnlFile.Visible = false;
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            pnlConstantEntry.Visible = false;
        }

        private void btnConstant_Click(object sender, EventArgs e)
        {
            if (pnlConstantEntry.Visible == false)
            {
                pnlControl.Visible = false;
                pnlSitting.Visible = false;
                pnlFuelExit.Visible = false;
                pnlFuelEntry.Visible = false;
                pnlFile.Visible = false;
                pnlConstantEntry.Visible = true;
                pnlConstantEntry.Width = 200;
                pnlConstantEntry.Dock = DockStyle.Right;
            }
            else
            {
                pnlConstantEntry.Visible = false;
            }
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            pnlFile.Visible = false;
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            pnlFuelEntry.Visible = false;
        }

        private void btnFuelEntry_Click(object sender, EventArgs e)
        {
            if (pnlFuelEntry.Visible == false)
            {
                pnlControl.Visible = false;
                pnlSitting.Visible = false;
                pnlFuelExit.Visible = false;
                pnlConstantEntry.Visible = false;
                pnlFile.Visible = false;
                pnlFuelEntry.Visible = true;
                pnlFuelEntry.Width = 200;
                pnlFuelEntry.Dock = DockStyle.Right;
            }
            else
            {
                pnlFuelEntry.Visible = false;
            }
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            pnlFuelExit.Visible = false;
        }

        private void btnFuelExit_Click(object sender, EventArgs e)
        {
            if (pnlFuelExit.Visible == false)
            {
                pnlControl.Visible = false;
                pnlSitting.Visible = false;
                pnlConstantEntry.Visible = false;
                pnlFile.Visible = false;
                pnlFuelEntry.Visible = false;
                pnlFuelExit.Visible = true;
                pnlFuelExit.Width = 200;
                pnlFuelExit.Dock = DockStyle.Right;
            }
            else
            {
                pnlFuelExit.Visible = false;
            }
        }

        private void gunaButton13_Click(object sender, EventArgs e)
        {
            pnlSitting.Visible = false;
        }

        private void btnSitting_Click(object sender, EventArgs e)
        {
            if (pnlSitting.Visible == false)
            {
                pnlControl.Visible = false;
                pnlSitting.Visible = true;
                pnlConstantEntry.Visible = false;
                pnlFile.Visible = false;
                pnlFuelEntry.Visible = false;
                pnlFuelExit.Visible = false;
                pnlSitting.Width = 200;
                pnlSitting.Dock = DockStyle.Right;
            }
            else
            {
                pnlSitting.Visible = false;
            }
        }

        private void gunaButton15_Click(object sender, EventArgs e)
        {
            pnlControl.Visible = false;
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            if (pnlControl.Visible == false)
            {
                pnlControl.Visible = true;
                pnlSitting.Visible = false;
                pnlConstantEntry.Visible = false;
                pnlFile.Visible = false;
                pnlFuelEntry.Visible = false;
                pnlFuelExit.Visible = false;
                pnlControl.Width = 200;
                pnlControl.Dock = DockStyle.Right;
            }
            else
            {
                pnlControl.Visible = false;
            }
        }

        private void simpleButton34_Click(object sender, EventArgs e)
        {
            pnlFile.Visible = false;
            FRMBACKUP backup = new FRMBACKUP("backup");
            backup.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            pnlFile.Visible = false;
            FRMBACKUP backup = new FRMBACKUP("recovery");
            backup.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            FRMFUELENTRY f = new FRMFUELENTRY("ادخال وقود");
            f.ShowDialog();
            pnlFuelEntry.Visible = false;
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            FRMFUELEXIT f = new FRMFUELEXIT("اخراج وقود");
            f.ShowDialog();
            pnlFuelEntry.Visible = false;
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            FRMRPFUEL f = new FRMRPFUEL("تقارير ادخال وقود");
            f.ShowDialog();
            pnlFuelEntry.Visible = false;
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            FRMRPFUEL f = new FRMRPFUEL("تقارير اخراج وقود");
            f.ShowDialog();
            pnlFuelEntry.Visible = false;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            FRMCONTANT f = new FRMCONTANT("اقسام العتبة");
            f.ShowDialog();
            pnlConstantEntry.Visible = false;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            FRMCONTANT f = new FRMCONTANT("المخازن");
            f.ShowDialog();
            pnlConstantEntry.Visible = false;
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            FRMCONTANT f = new FRMCONTANT("عجلات القسم");
            f.ShowDialog();
            pnlConstantEntry.Visible = false;
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            FRMRPCAR f = new FRMRPCAR();
            f.ShowDialog();
            pnlConstantEntry.Visible = false;
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            Setting f = new Setting();
            f.ShowDialog();
            pnlSitting.Visible = false;
            
        }

        private void btnExitNew_Click(object sender, EventArgs e)
        {
            if (pnlFile.Visible == false)
            {
                pnlControl.Visible = false;
                pnlSitting.Visible = false;
                pnlFuelExit.Visible = false;
                pnlFuelEntry.Visible = false;
                pnlConstantEntry.Visible = false;
                pnlFile.Visible = true;
                pnlFile.Width = 200;
                pnlFile.Dock = DockStyle.Right;

            }
            else
            {
                pnlFile.Visible = false;
            }
        }

        private void FRMMAIN_Load(object sender, EventArgs e)
        {
            CLS_FRMS.CLS_Store store = new CLS_FRMS.CLS_Store();                      
            store.ShowStores(tblStore, "الرئيسية");

            CLS_FRMS.CLS_Store notifc = new CLS_FRMS.CLS_Store();
            notifclist = notifc.notifcation();
            lblnotfic.Text = notifclist.Count.ToString();

            CLS_FRMS.CLS_Users user = new CLS_FRMS.CLS_Users();
            user.FormsPre(btnBackup, btnRecovery, btnDeptCars, btnRpCars, btnDepartments, btnStores, btnQuickControl, btnPlaces, btnEntryFuel, btnQuickFuelEntry, btnRpEntryFuel,
                btnExitFuel, btnQuickFuelExitCar, btnFuelExitPlaces, btnQuickFuelExitPlace, btnRpExitFuel, btnControler, btnSittingFrm, btnUsers);
        }

        private void btnNotifcation_Click(object sender, EventArgs e)
        {
            FRMNOTFCATION f = new FRMNOTFCATION(notifclist);
            f.Location = new Point(btnNotifcation.Location.X, btnNotifcation.Location.Y);
            f.Show();
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            FRMUSERS f = new FRMUSERS("المستخدمين");
            f.ShowDialog();
            pnlSitting.Visible = false;
        }

        private void pnlFill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnControler_Click(object sender, EventArgs e)
        {
            FRMControl f = new FRMControl();
            f.ShowDialog();
            pnlControl.Visible = false;
        }

        private void btnPlaces_Click(object sender, EventArgs e)
        {
            FRMCONTANT f = new FRMCONTANT("مواقع العتبة");
            f.ShowDialog();
            pnlConstantEntry.Visible = false;
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            FRMFUELEXITPLACE f = new FRMFUELEXITPLACE("اخراج وقود (مواقع)");
            f.ShowDialog();
            pnlFuelExit.Visible = false;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            FRMFUELENTRY f = new FRMFUELENTRY("ادخال وقود");
            f.ShowDialog();
            pnlFuelEntry.Visible = false;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            FRMFUELEXIT f = new FRMFUELEXIT("اخراج وقود");
            f.ShowDialog();
            pnlFuelEntry.Visible = false;
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            FRMFUELEXITPLACE f = new FRMFUELEXITPLACE("اخراج وقود (مواقع)");
            f.ShowDialog();
            pnlFuelExit.Visible = false;
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            FRMControl f = new FRMControl();
            f.ShowDialog();
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CLS_FRMS.CLS_Store store = new CLS_FRMS.CLS_Store();
            store.ShowStores(tblStore, "الرئيسية");
        }
    }
}