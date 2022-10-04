using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel.USER_CONTROL
{
    public partial class NumberClick : UserControl
    {
        TextBox txt;
        ComboBox cmbo;
        public NumberClick()
        {
            InitializeComponent();
        }
        public void text(TextBox txt)
        {
            this.txt = txt;
            cmbo = null;
        }
        public void cmb(ComboBox cmbo)
        {
            this.cmbo = cmbo;
            txt = null;
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "5";
            else
                cmbo.Text += "5";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(txt != null)
            txt.Text += "1";
            else
            cmbo.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "2";
            else
                cmbo.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "3";
            else
                cmbo.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "4";
            else
                cmbo.Text += "4";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "6";
            else
                cmbo.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "7";
            else
                cmbo.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "8";
            else
                cmbo.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "9";
            else
                cmbo.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "0";
            else
                cmbo.Text += "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += ".";
            else
                cmbo.Text += ".";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (txt != null && txt.Text.Length > 0)
                txt.Text = txt.Text.Substring(0, txt.Text.Length - 1);
            if (cmbo != null && cmbo.Text.Length > 0)
                cmbo.Text = cmbo.Text.Substring(0, cmbo.Text.Length - 1);
        }
    }
}
