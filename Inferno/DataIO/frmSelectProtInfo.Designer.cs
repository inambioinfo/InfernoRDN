namespace DAnTE.Inferno
{
    partial class frmSelectProtInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectProtInfo));
            this.mlstBoxAllCols = new System.Windows.Forms.ListBox();
            this.mlstBoxMT = new System.Windows.Forms.ListBox();
            this.mlstBoxProteinInfo = new System.Windows.Forms.ListBox();
            this.mbtnOK = new System.Windows.Forms.Button();
            this.mbtnCancel = new System.Windows.Forms.Button();
            this.mbtnMTUnselect = new System.Windows.Forms.Button();
            this.mbtnMTSelect = new System.Windows.Forms.Button();
            this.mbtnProteinUnselect = new System.Windows.Forms.Button();
            this.mbtnProteinSelect = new System.Windows.Forms.Button();
            this.niceLine4 = new DAnTE.ExtraControls.NiceLine();
            this.niceLine2 = new DAnTE.ExtraControls.NiceLine();
            this.niceLine1 = new DAnTE.ExtraControls.NiceLine();
            this.niceLine3 = new DAnTE.ExtraControls.NiceLine();
            this.SuspendLayout();
            // 
            // mlstBoxAllCols
            // 
            this.mlstBoxAllCols.FormattingEnabled = true;
            this.mlstBoxAllCols.HorizontalScrollbar = true;
            this.mlstBoxAllCols.Location = new System.Drawing.Point(30, 50);
            this.mlstBoxAllCols.Name = "mlstBoxAllCols";
            this.mlstBoxAllCols.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.mlstBoxAllCols.Size = new System.Drawing.Size(198, 160);
            this.mlstBoxAllCols.TabIndex = 0;
            // 
            // mlstBoxMT
            // 
            this.mlstBoxMT.FormattingEnabled = true;
            this.mlstBoxMT.HorizontalScrollbar = true;
            this.mlstBoxMT.Location = new System.Drawing.Point(293, 50);
            this.mlstBoxMT.Name = "mlstBoxMT";
            this.mlstBoxMT.Size = new System.Drawing.Size(208, 56);
            this.mlstBoxMT.TabIndex = 0;
            // 
            // mlstBoxProteinInfo
            // 
            this.mlstBoxProteinInfo.FormattingEnabled = true;
            this.mlstBoxProteinInfo.HorizontalScrollbar = true;
            this.mlstBoxProteinInfo.Location = new System.Drawing.Point(294, 151);
            this.mlstBoxProteinInfo.Name = "mlstBoxProteinInfo";
            this.mlstBoxProteinInfo.Size = new System.Drawing.Size(207, 56);
            this.mlstBoxProteinInfo.TabIndex = 1;
            // 
            // mbtnOK
            // 
            this.mbtnOK.Location = new System.Drawing.Point(162, 250);
            this.mbtnOK.Name = "mbtnOK";
            this.mbtnOK.Size = new System.Drawing.Size(75, 23);
            this.mbtnOK.TabIndex = 5;
            this.mbtnOK.Text = "OK";
            this.mbtnOK.UseVisualStyleBackColor = true;
            this.mbtnOK.Click += new System.EventHandler(this.mbtnOK_Click);
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbtnCancel.Location = new System.Drawing.Point(287, 250);
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Size = new System.Drawing.Size(75, 23);
            this.mbtnCancel.TabIndex = 6;
            this.mbtnCancel.Text = "Cancel";
            this.mbtnCancel.UseVisualStyleBackColor = true;
            this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
            // 
            // mbtnMTUnselect
            // 
            this.mbtnMTUnselect.Enabled = false;
            this.mbtnMTUnselect.Location = new System.Drawing.Point(241, 80);
            this.mbtnMTUnselect.Name = "mbtnMTUnselect";
            this.mbtnMTUnselect.Size = new System.Drawing.Size(37, 23);
            this.mbtnMTUnselect.TabIndex = 13;
            this.mbtnMTUnselect.Text = "<<";
            this.mbtnMTUnselect.UseVisualStyleBackColor = true;
            this.mbtnMTUnselect.Click += new System.EventHandler(this.mbtnMTUnselect_Click);
            // 
            // mbtnMTSelect
            // 
            this.mbtnMTSelect.Location = new System.Drawing.Point(241, 54);
            this.mbtnMTSelect.Name = "mbtnMTSelect";
            this.mbtnMTSelect.Size = new System.Drawing.Size(37, 23);
            this.mbtnMTSelect.TabIndex = 12;
            this.mbtnMTSelect.Text = ">>";
            this.mbtnMTSelect.UseVisualStyleBackColor = true;
            this.mbtnMTSelect.Click += new System.EventHandler(this.mbtnMTSelect_Click);
            // 
            // mbtnProteinUnselect
            // 
            this.mbtnProteinUnselect.Enabled = false;
            this.mbtnProteinUnselect.Location = new System.Drawing.Point(241, 180);
            this.mbtnProteinUnselect.Name = "mbtnProteinUnselect";
            this.mbtnProteinUnselect.Size = new System.Drawing.Size(37, 23);
            this.mbtnProteinUnselect.TabIndex = 15;
            this.mbtnProteinUnselect.Text = "<<";
            this.mbtnProteinUnselect.UseVisualStyleBackColor = true;
            this.mbtnProteinUnselect.Click += new System.EventHandler(this.mbtnProteinUnselect_Click);
            // 
            // mbtnProteinSelect
            // 
            this.mbtnProteinSelect.Location = new System.Drawing.Point(241, 155);
            this.mbtnProteinSelect.Name = "mbtnProteinSelect";
            this.mbtnProteinSelect.Size = new System.Drawing.Size(37, 23);
            this.mbtnProteinSelect.TabIndex = 14;
            this.mbtnProteinSelect.Text = ">>";
            this.mbtnProteinSelect.UseVisualStyleBackColor = true;
            this.mbtnProteinSelect.Click += new System.EventHandler(this.mbtnProteinSelect_Click);
            // 
            // niceLine4
            // 
            this.niceLine4.Caption = "Unique Row ID (Mass Tag)";
            this.niceLine4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.niceLine4.Location = new System.Drawing.Point(293, 22);
            this.niceLine4.Name = "niceLine4";
            this.niceLine4.Size = new System.Drawing.Size(220, 15);
            this.niceLine4.TabIndex = 19;
            // 
            // niceLine2
            // 
            this.niceLine2.Caption = "Available Columns";
            this.niceLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.niceLine2.Location = new System.Drawing.Point(12, 22);
            this.niceLine2.Name = "niceLine2";
            this.niceLine2.Size = new System.Drawing.Size(216, 15);
            this.niceLine2.TabIndex = 17;
            // 
            // niceLine1
            // 
            this.niceLine1.Location = new System.Drawing.Point(12, 229);
            this.niceLine1.Name = "niceLine1";
            this.niceLine1.Size = new System.Drawing.Size(501, 15);
            this.niceLine1.TabIndex = 16;
            // 
            // niceLine3
            // 
            this.niceLine3.Caption = "Protein IDs (IPI)";
            this.niceLine3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.niceLine3.Location = new System.Drawing.Point(294, 121);
            this.niceLine3.Name = "niceLine3";
            this.niceLine3.Size = new System.Drawing.Size(219, 15);
            this.niceLine3.TabIndex = 20;
            // 
            // frmSelectProtInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.mbtnCancel;
            this.ClientSize = new System.Drawing.Size(530, 287);
            this.Controls.Add(this.niceLine3);
            this.Controls.Add(this.niceLine4);
            this.Controls.Add(this.niceLine2);
            this.Controls.Add(this.niceLine1);
            this.Controls.Add(this.mbtnProteinUnselect);
            this.Controls.Add(this.mbtnProteinSelect);
            this.Controls.Add(this.mbtnMTUnselect);
            this.Controls.Add(this.mbtnMTSelect);
            this.Controls.Add(this.mbtnCancel);
            this.Controls.Add(this.mbtnOK);
            this.Controls.Add(this.mlstBoxProteinInfo);
            this.Controls.Add(this.mlstBoxAllCols);
            this.Controls.Add(this.mlstBoxMT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectProtInfo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Protein Information";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox mlstBoxAllCols;
        private System.Windows.Forms.ListBox mlstBoxMT;
        private System.Windows.Forms.ListBox mlstBoxProteinInfo;
        private System.Windows.Forms.Button mbtnOK;
        private System.Windows.Forms.Button mbtnCancel;
        private System.Windows.Forms.Button mbtnMTUnselect;
        private System.Windows.Forms.Button mbtnMTSelect;
        private System.Windows.Forms.Button mbtnProteinUnselect;
        private System.Windows.Forms.Button mbtnProteinSelect;
        private ExtraControls.NiceLine niceLine1;
        private ExtraControls.NiceLine niceLine2;
        private ExtraControls.NiceLine niceLine4;
        private ExtraControls.NiceLine niceLine3;
    }
}