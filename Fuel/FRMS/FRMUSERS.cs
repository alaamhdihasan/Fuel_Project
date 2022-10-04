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
    public partial class FRMUSERS : DevExpress.XtraEditors.XtraForm
    {
        DataTable DtUser;
        CurrencyManager cm;
        public FRMUSERS(string FrmName)
        {
            InitializeComponent();
            lblSystemName.Text = FrmName;
        }

        private void gunaButton12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtUserId.DataBindings.Clear();
            txtUserName.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            txtjopTitle.DataBindings.Clear();
            txtRegisterName.DataBindings.Clear();
            txtAddingTime.DataBindings.Clear();
            txtAddingDate.DataBindings.Clear();

            txtUserId.Text = null;
            txtUserName.Text = null;
            txtPassword.Text = null;
            txtjopTitle.Text = null;
            txtRegisterName.Text = null;
            txtAddingTime.Text = null;
            txtAddingDate.Text = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CLS_FRMS.CLS_Users user = new CLS_FRMS.CLS_Users();
            user.UserInfoInsert(txtUserName.Text,txtPassword.Text,txtjopTitle.Text);
            DtUser=user.DataDesign(txtUserId, txtUserName, txtPassword, txtjopTitle, txtRegisterName, txtAddingTime, txtAddingDate);
            cm = (CurrencyManager)this.BindingContext[DtUser];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CLS_FRMS.CLS_Users user = new CLS_FRMS.CLS_Users();
            user.UserInfoUpdate(int.Parse(txtUserId.Text), txtUserName.Text, txtPassword.Text, txtjopTitle.Text);
            DtUser=user.DataDesign(txtUserId, txtUserName, txtPassword, txtjopTitle, txtRegisterName, txtAddingTime, txtAddingDate);
            cm = (CurrencyManager)this.BindingContext[DtUser];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CLS_FRMS.CLS_Users user = new CLS_FRMS.CLS_Users();
            user.UserInfoDelete(int.Parse(txtUserId.Text));
            user.UserPreDeleteAll(int.Parse(txtUserId.Text));
            DtUser=user.DataDesign(txtUserId, txtUserName, txtPassword, txtjopTitle, txtRegisterName, txtAddingTime, txtAddingDate);
            cm = (CurrencyManager)this.BindingContext[DtUser];
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            cm.Position = DtUser.Rows.Count;
            CLS_FRMS.CLS_Users user = new CLS_FRMS.CLS_Users();
            user.DataDesignPre(Dgv, txtPreId, cbxFRMName, chxAdd, chxEdit, chxDelete, chxPrint, int.Parse(txtUserId.Text));
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            cm.Position += 1;
            CLS_FRMS.CLS_Users user = new CLS_FRMS.CLS_Users();
            user.DataDesignPre(Dgv, txtPreId, cbxFRMName, chxAdd, chxEdit, chxDelete, chxPrint, int.Parse(txtUserId.Text));
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            cm.Position -= 1;
            CLS_FRMS.CLS_Users user = new CLS_FRMS.CLS_Users();
            user.DataDesignPre(Dgv, txtPreId, cbxFRMName, chxAdd, chxEdit, chxDelete, chxPrint, int.Parse(txtUserId.Text));
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            cm.Position = 0;
            CLS_FRMS.CLS_Users user = new CLS_FRMS.CLS_Users();
            user.DataDesignPre(Dgv, txtPreId, cbxFRMName, chxAdd, chxEdit, chxDelete, chxPrint, int.Parse(txtUserId.Text));
        }

        private void FRMUSERS_Load(object sender, EventArgs e)
        {
            try { 
                CLS_FRMS.CLS_Users user = new CLS_FRMS.CLS_Users();

                DtUser = user.DataDesign(txtUserId, txtUserName, txtPassword, txtjopTitle, txtRegisterName, txtAddingTime, txtAddingDate);
                cm = (CurrencyManager)this.BindingContext[DtUser];

                user.DataDesignPre(Dgv, txtPreId, cbxFRMName, chxAdd, chxEdit, chxDelete, chxPrint, int.Parse(txtUserId.Text));

                user.FormsNameselecting(cbxFRMName);

                user.FrmBtnPre(lblSystemName.Text,btnNew, btnAdd, btnEdit, btnDelete);
                user.FrmBtnPre(lblSystemName.Text,btnPreNew, btnPreAdd, btnPreEdit, btnPreDelete);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            txtPreId.DataBindings.Clear();
            cbxFRMName.DataBindings.Clear();
            chxAdd.DataBindings.Clear();
            chxEdit.DataBindings.Clear();
            chxDelete.DataBindings.Clear();
            chxPrint.DataBindings.Clear();


            cbxFRMName.Text = null;
            chxAdd.Checked = false;
            chxEdit.Checked = false;
            chxDelete.Checked = false;
            chxPrint.Checked = false;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                CLS_FRMS.CLS_Users user = new CLS_FRMS.CLS_Users();
                user.UserPreInsert(int.Parse(txtUserId.Text),txtUserName.Text,txtPassword.Text,cbxFRMName.Text, chxAdd.Checked, chxEdit.Checked, chxDelete.Checked, chxPrint.Checked);
                user.DataDesignPre(Dgv, txtPreId, cbxFRMName, chxAdd, chxEdit, chxDelete, chxPrint, int.Parse(txtUserId.Text));

            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                CLS_FRMS.CLS_Users user = new CLS_FRMS.CLS_Users();
                user.UserPreUpdate(int.Parse(txtPreId.Text), cbxFRMName.Text, chxAdd.Checked, chxEdit.Checked, chxDelete.Checked, chxPrint.Checked);
                user.DataDesignPre(Dgv, txtPreId, cbxFRMName, chxAdd, chxEdit, chxDelete, chxPrint, int.Parse(txtUserId.Text));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                CLS_FRMS.CLS_Users user = new CLS_FRMS.CLS_Users();
                user.UserPreDelete(int.Parse(txtPreId.Text));
                user.DataDesignPre(Dgv, txtPreId, cbxFRMName, chxAdd, chxEdit, chxDelete, chxPrint, int.Parse(txtUserId.Text));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}