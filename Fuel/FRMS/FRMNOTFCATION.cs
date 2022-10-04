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
    public partial class FRMNOTFCATION : DevExpress.XtraEditors.XtraForm
    {
        public FRMNOTFCATION(List<Tuple<string, int>> notifclist)
        {
            InitializeComponent();
            adddata(notifclist);
        }

        public void adddata(List<Tuple<string, int>> notifclist)
        {
            foreach (var text in notifclist)
            {
                SimpleButton btn = new SimpleButton();
                btn.Font = new Font("JF Flat", 10, FontStyle.Bold);
                btn.Dock = DockStyle.Top;
                btn.ForeColor = Color.Black;
                btn.Appearance.BackColor = Color.Transparent;
                btn.AppearanceHovered.BackColor = Color.DodgerBlue;
                int x = 0;
                char[] buffer = text.Item1.ToCharArray();
                for (int i = 0; i < buffer.Length; i++)
                {
                    btn.Text += buffer[i];
                    if (x >= 20 && buffer[i] == ' ')
                    {
                        btn.Text += "\n\r";
                        x = 0;
                    }
                    x++;

                }
                btn.AutoSize = true;
                btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
                btn.ImageOptions.Image = Properties.Resources.reminder_32x32;
                panel1.Controls.Add(btn);

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}