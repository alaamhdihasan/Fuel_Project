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
    public partial class Keyboard : DevExpress.XtraEditors.XtraForm
    {
        TextBox txt = null;
        System.Windows.Forms.ComboBox cmb = null;
        public Keyboard(TextBox txt)
        {
            InitializeComponent();
            this.txt = txt;
        }
        public Keyboard(System.Windows.Forms.ComboBox cmb)
        {
            InitializeComponent();
            this.cmb = cmb;
        }
        private void gunaButton89_Click(object sender, EventArgs e)
        {
            tblEnglish.Visible = false;
            tblArabic.Visible = true;
            this.Size=new Size(672, 320);
        }

        private void gunaButton24_Click(object sender, EventArgs e)
        {
            tblEnglish.Visible = true;
            tblArabic.Visible = false;
            this.Size = new Size(672, 243);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "2";
            else
                cmb.Text += "2";
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "3";
            else
                cmb.Text += "3";
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "4";
            else
                cmb.Text += "4";
        }

        private void gunaButton25_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ذ";
            else
                cmb.Text += "ذ";
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "1";
            else
                cmb.Text += "1";
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "5";
            else
                cmb.Text += "5";
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "6";
            else
                cmb.Text += "6";
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "7";
            else
                cmb.Text += "7";
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "8";
            else
                cmb.Text += "8";
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "9";
            else
                cmb.Text += "9";
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "0";
            else
                cmb.Text += "0";
        }

        private void gunaButton12_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ض";
            else
                cmb.Text += "ض";
        }

        private void gunaButton13_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ص";
            else
                cmb.Text += "ص";
        }

        private void gunaButton14_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ث";
            else
                cmb.Text += "ث";
        }

        private void gunaButton15_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ق";
            else
                cmb.Text += "ق";
        }

        private void gunaButton16_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ف";
            else
                cmb.Text += "ف";
        }

        private void gunaButton17_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "غ";
            else
                cmb.Text += "غ";
        }

        private void gunaButton18_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ع";
            else
                cmb.Text += "ع";
        }

        private void gunaButton19_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ه";
            else
                cmb.Text += "ه";
        }

        private void gunaButton20_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "خ";
            else
                cmb.Text += "خ";
        }

        private void gunaButton21_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ح";
            else
                cmb.Text += "ح";
        }

        private void gunaButton22_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ج";
            else
                cmb.Text += "ج";
        }

        private void gunaButton23_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "د";
            else
                cmb.Text += "د";
        }

        private void gunaButton26_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ش";
            else
                cmb.Text += "ش";
        }

        private void gunaButton27_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "س";
            else
                cmb.Text += "س";
        }

        private void gunaButton28_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ي";
            else
                cmb.Text += "ي";
        }

        private void gunaButton29_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ل";
            else
                cmb.Text += "ل";
        }

        private void gunaButton30_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ا";
            else
                cmb.Text += "ا";
        }

        private void gunaButton31_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ت";
            else
                cmb.Text += "ت";
        }

        private void gunaButton32_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ن";
            else
                cmb.Text += "ن";
        }

        private void gunaButton33_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "م";
            else
                cmb.Text += "م";
        }

        private void gunaButton34_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ك";
            else
                cmb.Text += "ك";
        }

        private void gunaButton35_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ط";
            else
                cmb.Text += "ط";
        }

        private void gunaButton38_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ئ";
            else
                cmb.Text += "ئ";
        }

        private void gunaButton39_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ء";
            else
                cmb.Text += "ء";
        }

        private void gunaButton40_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ؤ";
            else
                cmb.Text += "ؤ";
        }

        private void gunaButton41_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ر";
            else
                cmb.Text += "ر";
        }

        private void gunaButton42_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "لا";
            else
                cmb.Text += "لا";
        }

        private void gunaButton43_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ى";
            else
                cmb.Text += "ى";
        }

        private void gunaButton44_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ة";
            else
                cmb.Text += "ة";
        }

        private void gunaButton45_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "و";
            else
                cmb.Text += "و";
        }

        private void gunaButton46_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ز";
            else
                cmb.Text += "ز";
        }

        private void gunaButton47_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ظ";
            else
                cmb.Text += "ظ";
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            if (txt != null && txt.Text.Length > 0)
                txt.Text = txt.Text.Substring(0, txt.Text.Length - 1);
            if (cmb != null && cmb.Text.Length > 0)
                cmb.Text = cmb.Text.Substring(0, cmb.Text.Length - 1);
        }

        private void gunaButton11_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += " ";
            else
                cmb.Text += " ";
        }

        private void gunaButton36_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton87_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton88_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += " ";
            else
                cmb.Text += " ";
        }

        private void gunaButton86_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "1";
            else
                cmb.Text += "1";
        }

        private void gunaButton85_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "2";
            else
                cmb.Text += "2";
        }

        private void gunaButton84_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "3";
            else
                cmb.Text += "3";
        }

        private void gunaButton83_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "4";
            else
                cmb.Text += "4";
        }

        private void gunaButton82_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "5";
            else
                cmb.Text += "5";
        }

        private void gunaButton81_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "6";
            else
                cmb.Text += "6";
        }

        private void gunaButton80_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "7";
            else
                cmb.Text += "7";
        }

        private void gunaButton79_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "8";
            else
                cmb.Text += "8";
        }

        private void gunaButton78_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "9";
            else
                cmb.Text += "9";
        }

        private void gunaButton77_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "0";
            else
                cmb.Text += "0";
        }

        private void gunaButton68_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "x";
            else
                cmb.Text += "x";
        }

        private void gunaButton67_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "z";
            else
                cmb.Text += "z";
        }

        private void gunaButton70_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "v";
            else
                cmb.Text += "v";
        }

        private void gunaButton69_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "c";
            else
                cmb.Text += "c";
        }

        private void gunaButton73_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "m";
            else
                cmb.Text += "m";
        }

        private void gunaButton72_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "n";
            else
                cmb.Text += "n";
        }

        private void gunaButton56_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "q";
            else
                cmb.Text += "q";
        }

        private void gunaButton55_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "w";
            else
                cmb.Text += "w";
        }

        private void gunaButton54_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "e";
            else
                cmb.Text += "e";
        }

        private void gunaButton53_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "r";
            else
                cmb.Text += "r";
        }

        private void gunaButton52_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "t";
            else
                cmb.Text += "t";
        }

        private void gunaButton51_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "y";
            else
                cmb.Text += "y";
        }

        private void gunaButton50_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "u";
            else
                cmb.Text += "u";
        }

        private void gunaButton49_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "i";
            else
                cmb.Text += "i";
        }

        private void gunaButton48_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "o";
            else
                cmb.Text += "o";
        }

        private void gunaButton37_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "p";
            else
                cmb.Text += "p";
        }

        private void gunaButton57_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "a";
            else
                cmb.Text += "a";
        }

        private void gunaButton58_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "s";
            else
                cmb.Text += "s";
        }

        private void gunaButton59_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "d";
            else
                cmb.Text += "d";
        }

        private void gunaButton60_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "f";
            else
                cmb.Text += "f";
        }

        private void gunaButton61_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "g";
            else
                cmb.Text += "g";
        }

        private void gunaButton62_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "h";
            else
                cmb.Text += "h";
        }

        private void gunaButton63_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "j";
            else
                cmb.Text += "j";
        }

        private void gunaButton64_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "k";
            else
                cmb.Text += "k";
        }

        private void gunaButton65_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "l";
            else
                cmb.Text += "l";
        }

        private void gunaButton71_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "b";
            else
                cmb.Text += "b";
        }

        private void gunaButton88_Click_1(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += " ";
            else
                cmb.Text += " ";
        }

        private void gunaButton66_Click(object sender, EventArgs e)
        {
            if (txt != null && txt.Text.Length > 0)
                txt.Text = txt.Text.Substring(0, txt.Text.Length - 1);
            if (cmb != null && cmb.Text.Length > 0)
                cmb.Text = cmb.Text.Substring(0, cmb.Text.Length - 1);
        }

        private void gunaButton74_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text += "ب";
            else
                cmb.Text += "ب";
        }
    }
}

    
