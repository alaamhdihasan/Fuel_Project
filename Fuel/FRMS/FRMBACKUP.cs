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
    public partial class FRMBACKUP : DevExpress.XtraEditors.XtraForm
    {
        string ActionName;
        public FRMBACKUP(string ActionName)
        {
            InitializeComponent();
            this.ActionName = ActionName;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FRMBACKUP_Load(object sender, EventArgs e)
        {
            if (ActionName == "backup")
            {
                btnBackup.Text = "انشاء نسخة احتياطة";
                btnBackup.Image = Properties.Resources.Add_Database_75px2;
            }
            else if (ActionName == "recovery")
            {
                btnBackup.Text = "استرجاع قاعدة البيانات";
                btnBackup.Image = Properties.Resources.Data_Backup_75px2;
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtPathSave.Text = dlg.SelectedPath;
                btnBackup.Enabled = true;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (txtPathSave.Text == string.Empty)
                {
                    MessageBox.Show("يرجى تحديد المسار");
                }
                else
                {
                    if (ActionName == "backup")
                    {
                          DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
                           dal.createBackup(txtPathSave.Text);
                        MessageBox.Show("تم انشاء نسخة احتايطة لقاعدة البيانات");
                    }
                    else if (ActionName == "recovery")
                    {
                            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
                          dal.Restore(txtPathSave.Text);
                        MessageBox.Show("تم استرجاع قاعدة البيانات");
                    }
                    btnBackup.Enabled = false;
                }
            //}
            //catch (Exception ee)
            //{
            //    MessageBox.Show(ee.Message);
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
