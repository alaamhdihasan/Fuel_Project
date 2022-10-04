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
    public partial class FRMLOGIN : DevExpress.XtraEditors.XtraForm
    {
        public FRMLOGIN()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserName = txtUserName.Text;
            Properties.Settings.Default.Password = txtPassword.Text;
            Properties.Settings.Default.Save();

            if (txtUserName.Text == "admin" && txtPassword.Text == "0000")
            {
                Setting frm = new Setting();
                frm.Show();

            }
            else
            {
                CLS_FRMS.CLS_Users Login = new CLS_FRMS.CLS_Users();
                DataTable Dt = Login.UserInfoSelectingByUerAndPass(txtUserName.Text, txtPassword.Text);
               

                if (Dt.Rows.Count > 0)
                {
                    Properties.Settings.Default.UserId = int.Parse(Dt.Rows[0][0].ToString());
                    Properties.Settings.Default.Save();
                    FRMMAIN frm = new FRMMAIN();
                    frm.ShowDialog();
                    this.Close();
                   
                }
                else
                {
                    MessageBox.Show("هذا المستخدم او كلمة المرور خطأ يرجى التحقق مرة اخرى", "خطأ اسم المستخدم او كلمة المرور", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                }
            }


        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(txtUserName);
            key.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(txtPassword);
            key.ShowDialog();
        }

        private void FRMLOGIN_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }
    }
}