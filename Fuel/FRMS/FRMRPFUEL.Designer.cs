namespace Fuel.FRMS
{
    partial class FRMRPFUEL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMRPFUEL));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSystemName = new DevExpress.XtraEditors.LabelControl();
            this.gunaButton12 = new Guna.UI.WinForms.GunaButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.prog = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.cbxSecondInput = new System.Windows.Forms.ComboBox();
            this.cbxFirstInput = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.lblFirstInput = new DevExpress.XtraEditors.LabelControl();
            this.lblSecondInput = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbxRpType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnShow = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintExitBill = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bgwork = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblSystemName);
            this.panel1.Controls.Add(this.gunaButton12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1295, 50);
            this.panel1.TabIndex = 2;
            // 
            // lblSystemName
            // 
            this.lblSystemName.Appearance.Font = new System.Drawing.Font("JF Flat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblSystemName.Appearance.Options.UseFont = true;
            this.lblSystemName.Appearance.Options.UseForeColor = true;
            this.lblSystemName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSystemName.Location = new System.Drawing.Point(1231, 0);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Padding = new System.Windows.Forms.Padding(0, 5, 50, 0);
            this.lblSystemName.Size = new System.Drawing.Size(64, 46);
            this.lblSystemName.TabIndex = 16;
            this.lblSystemName.Text = "0";
            // 
            // gunaButton12
            // 
            this.gunaButton12.Animated = true;
            this.gunaButton12.AnimationHoverSpeed = 0.07F;
            this.gunaButton12.AnimationSpeed = 0.07F;
            this.gunaButton12.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton12.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton12.BorderColor = System.Drawing.Color.Black;
            this.gunaButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton12.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton12.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaButton12.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton12.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton12.ForeColor = System.Drawing.Color.White;
            this.gunaButton12.Image = global::Fuel.Properties.Resources.Cancel2_32px;
            this.gunaButton12.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton12.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton12.Location = new System.Drawing.Point(0, 0);
            this.gunaButton12.Name = "gunaButton12";
            this.gunaButton12.OnHoverBaseColor = System.Drawing.Color.Red;
            this.gunaButton12.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton12.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton12.OnHoverImage = null;
            this.gunaButton12.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton12.Radius = 15;
            this.gunaButton12.Size = new System.Drawing.Size(42, 50);
            this.gunaButton12.TabIndex = 15;
            this.gunaButton12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton12.Click += new System.EventHandler(this.gunaButton12_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1245, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(50, 699);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lb1);
            this.panel4.Controls.Add(this.prog);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 699);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1245, 50);
            this.panel4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JF Flat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(984, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = ".....Working";
            this.label1.Visible = false;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.ForeColor = System.Drawing.Color.White;
            this.lb1.Location = new System.Drawing.Point(744, 15);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(18, 23);
            this.lb1.TabIndex = 4;
            this.lb1.Text = "0";
            this.lb1.Visible = false;
            // 
            // prog
            // 
            this.prog.Location = new System.Drawing.Point(18, 15);
            this.prog.Name = "prog";
            this.prog.Size = new System.Drawing.Size(716, 23);
            this.prog.TabIndex = 1;
            this.prog.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 649);
            this.panel2.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(50, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1195, 649);
            this.panel5.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.38384F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.010101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.60606F));
            this.tableLayoutPanel1.Controls.Add(this.Dgv, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1195, 649);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            this.Dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.Dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.Dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv.ColumnHeadersHeight = 50;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv.DefaultCellStyle = dataGridViewCellStyle7;
            this.Dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv.EnableHeadersVisualStyles = false;
            this.Dgv.Location = new System.Drawing.Point(3, 3);
            this.Dgv.MultiSelect = false;
            this.Dgv.Name = "Dgv";
            this.Dgv.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Dgv.RowHeadersVisible = false;
            this.Dgv.RowHeadersWidth = 5;
            this.Dgv.RowTemplate.Height = 45;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(719, 643);
            this.Dgv.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtSearch, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(740, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.15944F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.85628F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.984281F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(452, 643);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.dt2, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.dt1, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.cbxSecondInput, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.cbxFirstInput, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelControl4, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.labelControl19, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblFirstInput, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblSecondInput, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelControl3, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.cbxRpType, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(446, 181);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // dt2
            // 
            this.dt2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt2.Font = new System.Drawing.Font("JF Flat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt2.Location = new System.Drawing.Point(3, 147);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(307, 30);
            this.dt2.TabIndex = 68;
            // 
            // dt1
            // 
            this.dt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt1.Font = new System.Drawing.Font("JF Flat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt1.Location = new System.Drawing.Point(3, 111);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(307, 30);
            this.dt1.TabIndex = 67;
            // 
            // cbxSecondInput
            // 
            this.cbxSecondInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSecondInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSecondInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxSecondInput.FormattingEnabled = true;
            this.cbxSecondInput.Location = new System.Drawing.Point(3, 75);
            this.cbxSecondInput.Name = "cbxSecondInput";
            this.cbxSecondInput.Size = new System.Drawing.Size(307, 36);
            this.cbxSecondInput.TabIndex = 66;
            // 
            // cbxFirstInput
            // 
            this.cbxFirstInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxFirstInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxFirstInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxFirstInput.FormattingEnabled = true;
            this.cbxFirstInput.Location = new System.Drawing.Point(3, 39);
            this.cbxFirstInput.Name = "cbxFirstInput";
            this.cbxFirstInput.Size = new System.Drawing.Size(307, 36);
            this.cbxFirstInput.TabIndex = 65;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl4.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("JF Flat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseBackColor = true;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl4.LineColor = System.Drawing.Color.Black;
            this.labelControl4.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl4.LineVisible = true;
            this.labelControl4.Location = new System.Drawing.Point(316, 147);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.labelControl4.Size = new System.Drawing.Size(127, 31);
            this.labelControl4.TabIndex = 63;
            this.labelControl4.Text = "الى:";
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl19.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.labelControl19.Appearance.Font = new System.Drawing.Font("JF Flat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl19.Appearance.Options.UseBackColor = true;
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Appearance.Options.UseForeColor = true;
            this.labelControl19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl19.LineColor = System.Drawing.Color.Black;
            this.labelControl19.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl19.LineVisible = true;
            this.labelControl19.Location = new System.Drawing.Point(316, 3);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.labelControl19.Size = new System.Drawing.Size(127, 30);
            this.labelControl19.TabIndex = 59;
            this.labelControl19.Text = "نوع التقرير:";
            // 
            // lblFirstInput
            // 
            this.lblFirstInput.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstInput.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.lblFirstInput.Appearance.Font = new System.Drawing.Font("JF Flat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstInput.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblFirstInput.Appearance.Options.UseBackColor = true;
            this.lblFirstInput.Appearance.Options.UseFont = true;
            this.lblFirstInput.Appearance.Options.UseForeColor = true;
            this.lblFirstInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirstInput.LineColor = System.Drawing.Color.Black;
            this.lblFirstInput.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lblFirstInput.LineVisible = true;
            this.lblFirstInput.Location = new System.Drawing.Point(316, 39);
            this.lblFirstInput.Name = "lblFirstInput";
            this.lblFirstInput.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblFirstInput.Size = new System.Drawing.Size(127, 30);
            this.lblFirstInput.TabIndex = 60;
            this.lblFirstInput.Text = "مدخل اول:";
            // 
            // lblSecondInput
            // 
            this.lblSecondInput.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblSecondInput.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.lblSecondInput.Appearance.Font = new System.Drawing.Font("JF Flat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondInput.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblSecondInput.Appearance.Options.UseBackColor = true;
            this.lblSecondInput.Appearance.Options.UseFont = true;
            this.lblSecondInput.Appearance.Options.UseForeColor = true;
            this.lblSecondInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSecondInput.LineColor = System.Drawing.Color.Black;
            this.lblSecondInput.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lblSecondInput.LineVisible = true;
            this.lblSecondInput.Location = new System.Drawing.Point(316, 75);
            this.lblSecondInput.Name = "lblSecondInput";
            this.lblSecondInput.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblSecondInput.Size = new System.Drawing.Size(127, 30);
            this.lblSecondInput.TabIndex = 61;
            this.lblSecondInput.Text = "مدخل ثاني:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl3.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("JF Flat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl3.LineColor = System.Drawing.Color.Black;
            this.labelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(316, 111);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.labelControl3.Size = new System.Drawing.Size(127, 30);
            this.labelControl3.TabIndex = 62;
            this.labelControl3.Text = "من:";
            // 
            // cbxRpType
            // 
            this.cbxRpType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxRpType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxRpType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxRpType.FormattingEnabled = true;
            this.cbxRpType.Location = new System.Drawing.Point(3, 3);
            this.cbxRpType.Name = "cbxRpType";
            this.cbxRpType.Size = new System.Drawing.Size(307, 36);
            this.cbxRpType.TabIndex = 64;
            this.cbxRpType.SelectedIndexChanged += new System.EventHandler(this.cbxRpType_SelectedIndexChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnShow, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnPrintExitBill, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 551);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(446, 43);
            this.tableLayoutPanel4.TabIndex = 1;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // btnShow
            // 
            this.btnShow.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnShow.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.btnShow.Appearance.Font = new System.Drawing.Font("JF Flat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnShow.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnShow.Appearance.Options.UseBackColor = true;
            this.btnShow.Appearance.Options.UseFont = true;
            this.btnShow.Appearance.Options.UseForeColor = true;
            this.btnShow.AppearanceDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnShow.AppearanceDisabled.Options.UseFont = true;
            this.btnShow.AppearanceHovered.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnShow.AppearanceHovered.BackColor2 = System.Drawing.Color.Black;
            this.btnShow.AppearanceHovered.Font = new System.Drawing.Font("JF Flat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnShow.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnShow.AppearanceHovered.Options.UseBackColor = true;
            this.btnShow.AppearanceHovered.Options.UseFont = true;
            this.btnShow.AppearanceHovered.Options.UseForeColor = true;
            this.btnShow.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnShow.AppearancePressed.Options.UseFont = true;
            this.btnShow.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.ImageOptions.Image")));
            this.btnShow.Location = new System.Drawing.Point(226, 3);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(217, 37);
            this.btnShow.TabIndex = 33;
            this.btnShow.Text = "معاينة";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnPrintExitBill
            // 
            this.btnPrintExitBill.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnPrintExitBill.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.btnPrintExitBill.Appearance.Font = new System.Drawing.Font("JF Flat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintExitBill.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnPrintExitBill.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnPrintExitBill.Appearance.Options.UseBackColor = true;
            this.btnPrintExitBill.Appearance.Options.UseFont = true;
            this.btnPrintExitBill.Appearance.Options.UseForeColor = true;
            this.btnPrintExitBill.AppearanceDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrintExitBill.AppearanceDisabled.Options.UseFont = true;
            this.btnPrintExitBill.AppearanceHovered.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPrintExitBill.AppearanceHovered.BackColor2 = System.Drawing.Color.Black;
            this.btnPrintExitBill.AppearanceHovered.Font = new System.Drawing.Font("JF Flat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintExitBill.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnPrintExitBill.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnPrintExitBill.AppearanceHovered.Options.UseBackColor = true;
            this.btnPrintExitBill.AppearanceHovered.Options.UseFont = true;
            this.btnPrintExitBill.AppearanceHovered.Options.UseForeColor = true;
            this.btnPrintExitBill.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrintExitBill.AppearancePressed.Options.UseFont = true;
            this.btnPrintExitBill.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnPrintExitBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintExitBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrintExitBill.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintExitBill.ImageOptions.Image")));
            this.btnPrintExitBill.Location = new System.Drawing.Point(3, 3);
            this.btnPrintExitBill.Name = "btnPrintExitBill";
            this.btnPrintExitBill.Size = new System.Drawing.Size(217, 37);
            this.btnPrintExitBill.TabIndex = 32;
            this.btnPrintExitBill.Text = "طباعة";
            this.btnPrintExitBill.Click += new System.EventHandler(this.btnPrintExitBill_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Location = new System.Drawing.Point(3, 600);
            this.txtSearch.Name = "txtSearch";
            // 
            // 
            // 
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Properties.NullText = "بحث";
            this.txtSearch.Size = new System.Drawing.Size(446, 34);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.EditValueChanged += new System.EventHandler(this.txtSearch_EditValueChanged);
            this.txtSearch.TextChanged += new System.EventHandler(this.textEdit1_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(728, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(6, 643);
            this.panel6.TabIndex = 1;
            // 
            // bgwork
            // 
            this.bgwork.WorkerReportsProgress = true;
            this.bgwork.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwork_DoWork);
            this.bgwork.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwork_ProgressChanged);
            // 
            // FRMRPFUEL
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 749);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("JF Flat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRMRPFUEL";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "FRMRPFUEL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMRPFUEL_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblSystemName;
        private Guna.UI.WinForms.GunaButton gunaButton12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DateTimePicker dt2;
        private System.Windows.Forms.DateTimePicker dt1;
        private System.Windows.Forms.ComboBox cbxSecondInput;
        private System.Windows.Forms.ComboBox cbxFirstInput;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl lblFirstInput;
        private DevExpress.XtraEditors.LabelControl lblSecondInput;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cbxRpType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ProgressBar prog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb1;
        private System.ComponentModel.BackgroundWorker bgwork;
        private DevExpress.XtraEditors.SimpleButton btnPrintExitBill;
        private DevExpress.XtraEditors.SimpleButton btnShow;
    }
}