namespace KDZCardGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OpenFileDialogbtn = new ReaLTaiizor.Controls.Button();
            this.Exceldgv = new System.Windows.Forms.DataGridView();
            this.SelectFolderbtn = new ReaLTaiizor.Controls.Button();
            this.SelectReportFileBtn = new ReaLTaiizor.Controls.Button();
            this.ImageColCmb = new ReaLTaiizor.Controls.AloneComboBox();
            this.CheckImagebtn = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Exceldgv)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenFileDialogbtn
            // 
            this.OpenFileDialogbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OpenFileDialogbtn.BackColor = System.Drawing.Color.Transparent;
            this.OpenFileDialogbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenFileDialogbtn.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.OpenFileDialogbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenFileDialogbtn.Image = null;
            this.OpenFileDialogbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenFileDialogbtn.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.OpenFileDialogbtn.Location = new System.Drawing.Point(581, 56);
            this.OpenFileDialogbtn.Name = "OpenFileDialogbtn";
            this.OpenFileDialogbtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.OpenFileDialogbtn.Size = new System.Drawing.Size(120, 40);
            this.OpenFileDialogbtn.TabIndex = 0;
            this.OpenFileDialogbtn.Text = "Select File";
            this.OpenFileDialogbtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.OpenFileDialogbtn.Click += new System.EventHandler(this.OpenFileDialogbtn_Click);
            // 
            // Exceldgv
            // 
            this.Exceldgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exceldgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Exceldgv.Location = new System.Drawing.Point(12, 165);
            this.Exceldgv.Name = "Exceldgv";
            this.Exceldgv.RowTemplate.Height = 25;
            this.Exceldgv.Size = new System.Drawing.Size(776, 273);
            this.Exceldgv.TabIndex = 1;
            // 
            // SelectFolderbtn
            // 
            this.SelectFolderbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectFolderbtn.BackColor = System.Drawing.Color.Transparent;
            this.SelectFolderbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectFolderbtn.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SelectFolderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectFolderbtn.Image = null;
            this.SelectFolderbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelectFolderbtn.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SelectFolderbtn.Location = new System.Drawing.Point(63, 56);
            this.SelectFolderbtn.Name = "SelectFolderbtn";
            this.SelectFolderbtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.SelectFolderbtn.Size = new System.Drawing.Size(120, 40);
            this.SelectFolderbtn.TabIndex = 2;
            this.SelectFolderbtn.Text = "Select Picture Folder";
            this.SelectFolderbtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.SelectFolderbtn.Click += new System.EventHandler(this.SelectFolderbtn_Click);
            // 
            // SelectReportFileBtn
            // 
            this.SelectReportFileBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectReportFileBtn.BackColor = System.Drawing.Color.Transparent;
            this.SelectReportFileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectReportFileBtn.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SelectReportFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectReportFileBtn.Image = null;
            this.SelectReportFileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelectReportFileBtn.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SelectReportFileBtn.Location = new System.Drawing.Point(581, 10);
            this.SelectReportFileBtn.Name = "SelectReportFileBtn";
            this.SelectReportFileBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.SelectReportFileBtn.Size = new System.Drawing.Size(120, 40);
            this.SelectReportFileBtn.TabIndex = 3;
            this.SelectReportFileBtn.Text = "Save Report File";
            this.SelectReportFileBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.SelectReportFileBtn.Click += new System.EventHandler(this.SelectReportFileBtn_Click);
            // 
            // ImageColCmb
            // 
            this.ImageColCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ImageColCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ImageColCmb.EnabledCalc = true;
            this.ImageColCmb.FormattingEnabled = true;
            this.ImageColCmb.ItemHeight = 20;
            this.ImageColCmb.Location = new System.Drawing.Point(46, 24);
            this.ImageColCmb.Name = "ImageColCmb";
            this.ImageColCmb.Size = new System.Drawing.Size(151, 26);
            this.ImageColCmb.TabIndex = 4;
            // 
            // CheckImagebtn
            // 
            this.CheckImagebtn.BackColor = System.Drawing.Color.Transparent;
            this.CheckImagebtn.Enabled = false;
            this.CheckImagebtn.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.CheckImagebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckImagebtn.Image = null;
            this.CheckImagebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckImagebtn.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.CheckImagebtn.Location = new System.Drawing.Point(63, 102);
            this.CheckImagebtn.Name = "CheckImagebtn";
            this.CheckImagebtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.CheckImagebtn.Size = new System.Drawing.Size(120, 40);
            this.CheckImagebtn.TabIndex = 5;
            this.CheckImagebtn.Text = "Check Images";
            this.CheckImagebtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.CheckImagebtn.Click += new System.EventHandler(this.CheckImagebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckImagebtn);
            this.Controls.Add(this.ImageColCmb);
            this.Controls.Add(this.SelectReportFileBtn);
            this.Controls.Add(this.SelectFolderbtn);
            this.Controls.Add(this.Exceldgv);
            this.Controls.Add(this.OpenFileDialogbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Generate";
            ((System.ComponentModel.ISupportInitialize)(this.Exceldgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.Button OpenFileDialogbtn;
        private DataGridView Exceldgv;
        private ReaLTaiizor.Controls.Button SelectFolderbtn;
        private ReaLTaiizor.Controls.Button SelectReportFileBtn;
        private ReaLTaiizor.Controls.AloneComboBox ImageColCmb;
        private ReaLTaiizor.Controls.Button CheckImagebtn;
    }
}