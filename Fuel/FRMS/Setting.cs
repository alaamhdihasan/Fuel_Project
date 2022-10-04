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
using System.Data.SqlClient;
using System.Data.Sql;
using System.Net;

namespace Fuel.FRMS
{
    public partial class Setting : DevExpress.XtraEditors.XtraForm
    {
        public Setting()
        {
            InitializeComponent();

            txtServerName.Text = Properties.Settings.Default.ServerName;
            cbxServerIp.Text = Properties.Settings.Default.ServerIp;
            txtUserName.Text = Properties.Settings.Default.DBUserName;
            txtPassword.Text = Properties.Settings.Default.DBPassword;
            txtDBName.Text = Properties.Settings.Default.DBName;

            txtFuelBillPath.Text = Properties.Settings.Default.BillPath;
        }

        private void gunaButton12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(txtServerName);
            key.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(txtUserName);
            key.ShowDialog();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Keyboard key = new Keyboard(txtPassword);
            key.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtFuelBillPath.Text = dlg.SelectedPath;
                btnSave.Enabled = true;
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BillPath = txtFuelBillPath.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("تم الحفظ");
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ServerName = txtServerName.Text;
            Properties.Settings.Default.ServerIp = cbxServerIp.Text;
            Properties.Settings.Default.DBUserName = txtUserName.Text;
            Properties.Settings.Default.DBPassword = txtPassword.Text;
            Properties.Settings.Default.DBName = txtDBName.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("تم الحفظ");
        }

        private void Setting_Load(object sender, EventArgs e)
        {

            try { 
            DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
            for (int i = 0; i < servers.Rows.Count; i++)
            {
                string d = servers.Rows[i]["ServerName"].ToString();
                string ip = Dns.GetHostByName(d).AddressList[0].ToString();
                cbxServerIp.Items.Add(ip);

            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            try
            {
                listDatabases.Items.Clear();
                SqlConnection sqlcon = new SqlConnection(@"Data Source=" + cbxServerIp.Text + ";initial Catalog=master; persist Security info=True; user id=" + txtUserName.Text + ";password=" + txtPassword.Text + "");
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("select Name from sys.databases", sqlcon);
                SqlDataReader Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    listDatabases.Items.Add(Dr[0].ToString());

                }
                sqlcon.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void listDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDBName.Text = listDatabases.SelectedItem.ToString();

        }
    }
}