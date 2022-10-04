namespace Fuel.FRMS
{
    partial class FRMBACKUP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMBACKUP));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPathSave = new System.Windows.Forms.TextBox();
            this.btnDetectFile = new Guna.UI.WinForms.GunaButton();
            this.btnBackup = new Guna.UI.WinForms.GunaButton();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.txtPathSave, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDetectFile, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBackup, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(611, 180);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txtPathSave
            // 
            this.txtPathSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPathSave.Enabled = false;
            this.txtPathSave.Font = new System.Drawing.Font("JF Flat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathSave.Location = new System.Drawing.Point(3, 48);
            this.txtPathSave.Name = "txtPathSave";
            this.txtPathSave.Size = new System.Drawing.Size(422, 40);
            this.txtPathSave.TabIndex = 0;
            // 
            // btnDetectFile
            // 
            this.btnDetectFile.Animated = true;
            this.btnDetectFile.AnimationHoverSpeed = 0.07F;
            this.btnDetectFile.AnimationSpeed = 0.07F;
            this.btnDetectFile.BackColor = System.Drawing.Color.Transparent;
            this.btnDetectFile.BaseColor = System.Drawing.Color.Transparent;
            this.btnDetectFile.BorderColor = System.Drawing.Color.Red;
            this.btnDetectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetectFile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDetectFile.FocusedColor = System.Drawing.Color.Empty;
            this.btnDetectFile.Font = new System.Drawing.Font("JF Flat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetectFile.ForeColor = System.Drawing.Color.White;
            this.btnDetectFile.Image = global::Fuel.Properties.Resources.folder_32px;
            this.btnDetectFile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDetectFile.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDetectFile.Location = new System.Drawing.Point(431, 48);
            this.btnDetectFile.Name = "btnDetectFile";
            this.btnDetectFile.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.btnDetectFile.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDetectFile.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDetectFile.OnHoverImage = null;
            this.btnDetectFile.OnPressedColor = System.Drawing.Color.Black;
            this.btnDetectFile.Radius = 20;
            this.btnDetectFile.Size = new System.Drawing.Size(177, 39);
            this.btnDetectFile.TabIndex = 8;
            this.btnDetectFile.Text = "تحديد مسار";
            this.btnDetectFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDetectFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Animated = true;
            this.btnBackup.AnimationHoverSpeed = 0.07F;
            this.btnBackup.AnimationSpeed = 0.07F;
            this.btnBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnBackup.BaseColor = System.Drawing.Color.Transparent;
            this.btnBackup.BorderColor = System.Drawing.Color.Red;
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBackup.FocusedColor = System.Drawing.Color.Empty;
            this.btnBackup.Font = new System.Drawing.Font("JF Flat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Image = global::Fuel.Properties.Resources.Add_Database_75px2;
            this.btnBackup.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBackup.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBackup.Location = new System.Drawing.Point(431, 93);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.btnBackup.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBackup.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBackup.OnHoverImage = null;
            this.btnBackup.OnPressedColor = System.Drawing.Color.Black;
            this.btnBackup.Radius = 20;
            this.btnBackup.Size = new System.Drawing.Size(177, 39);
            this.btnBackup.TabIndex = 9;
            this.btnBackup.Text = "انشاء نسخة احتياطية";
            this.btnBackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnExit
            // 
            this.btnExit.Animated = true;
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.07F;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BaseColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::Fuel.Properties.Resources.Cancel2_32px;
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Radius = 15;
            this.btnExit.Size = new System.Drawing.Size(42, 39);
            this.btnExit.TabIndex = 15;
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FRMBACKUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 180);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRMBACKUP";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMBACKUP";
            this.Load += new System.EventHandler(this.FRMBACKUP_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtPathSave;
        private Guna.UI.WinForms.GunaButton btnDetectFile;
        private Guna.UI.WinForms.GunaButton btnBackup;
        private Guna.UI.WinForms.GunaButton btnExit;
    }
}