using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DAnTE.Inferno
{
    partial class frmLinRegPar
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

        private Label mlblPickFactor;
        private Button mbtnOK;
        private Button mbtnCancel;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLinRegPar));
            this.mlblPickFactor = new System.Windows.Forms.Label();
            this.mbtnOK = new System.Windows.Forms.Button();
            this.mbtnCancel = new System.Windows.Forms.Button();
            this.mbtnSelectFolder = new System.Windows.Forms.Button();
            this.mtxtBoxFolder = new System.Windows.Forms.TextBox();
            this.mchkBoxPlot = new System.Windows.Forms.CheckBox();
            this.mcmbBoxFactors = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mrBtnMinMissing = new System.Windows.Forms.RadioButton();
            this.mrBtnMedian = new System.Windows.Forms.RadioButton();
            this.mrBtnFirst = new System.Windows.Forms.RadioButton();
            this.niceLine2 = new DAnTE.ExtraControls.NiceLine();
            this.niceLine1 = new DAnTE.ExtraControls.NiceLine();
            this.mlblDataName = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mlblPickFactor
            // 
            this.mlblPickFactor.AutoSize = true;
            this.mlblPickFactor.Location = new System.Drawing.Point(55, 98);
            this.mlblPickFactor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblPickFactor.Name = "mlblPickFactor";
            this.mlblPickFactor.Size = new System.Drawing.Size(237, 17);
            this.mlblPickFactor.TabIndex = 1;
            this.mlblPickFactor.Text = "Pick the Factor Denoting Replicates:";
            // 
            // mbtnOK
            // 
            this.mbtnOK.Location = new System.Drawing.Point(136, 409);
            this.mbtnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mbtnOK.Name = "mbtnOK";
            this.mbtnOK.Size = new System.Drawing.Size(100, 28);
            this.mbtnOK.TabIndex = 2;
            this.mbtnOK.Text = "OK";
            this.mbtnOK.UseVisualStyleBackColor = true;
            this.mbtnOK.Click += new System.EventHandler(this.mbtnOK_Click);
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbtnCancel.Location = new System.Drawing.Point(272, 409);
            this.mbtnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Size = new System.Drawing.Size(100, 28);
            this.mbtnCancel.TabIndex = 3;
            this.mbtnCancel.Text = "Cancel";
            this.mbtnCancel.UseVisualStyleBackColor = true;
            this.mbtnCancel.Click += new System.EventHandler(this.mbtnCancel_Click);
            // 
            // mbtnSelectFolder
            // 
            this.mbtnSelectFolder.Enabled = false;
            this.mbtnSelectFolder.Location = new System.Drawing.Point(463, 350);
            this.mbtnSelectFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mbtnSelectFolder.Name = "mbtnSelectFolder";
            this.mbtnSelectFolder.Size = new System.Drawing.Size(33, 25);
            this.mbtnSelectFolder.TabIndex = 12;
            this.mbtnSelectFolder.Text = "...";
            this.mbtnSelectFolder.UseVisualStyleBackColor = true;
            this.mbtnSelectFolder.Click += new System.EventHandler(this.mbtnSelectFolder_Click);
            // 
            // mtxtBoxFolder
            // 
            this.mtxtBoxFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtBoxFolder.Enabled = false;
            this.mtxtBoxFolder.Location = new System.Drawing.Point(57, 351);
            this.mtxtBoxFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtBoxFolder.Name = "mtxtBoxFolder";
            this.mtxtBoxFolder.Size = new System.Drawing.Size(397, 22);
            this.mtxtBoxFolder.TabIndex = 11;
            // 
            // mchkBoxPlot
            // 
            this.mchkBoxPlot.AutoSize = true;
            this.mchkBoxPlot.Location = new System.Drawing.Point(29, 322);
            this.mchkBoxPlot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mchkBoxPlot.Name = "mchkBoxPlot";
            this.mchkBoxPlot.Size = new System.Drawing.Size(342, 21);
            this.mchkBoxPlot.TabIndex = 10;
            this.mchkBoxPlot.Text = "Save Diagnostic Plots (WARNING: Could be slow)";
            this.mchkBoxPlot.UseVisualStyleBackColor = true;
            this.mchkBoxPlot.Click += new System.EventHandler(this.mchkBoxPlot_CheckedChanged);
            // 
            // mcmbBoxFactors
            // 
            this.mcmbBoxFactors.FormattingEnabled = true;
            this.mcmbBoxFactors.Location = new System.Drawing.Point(303, 95);
            this.mcmbBoxFactors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mcmbBoxFactors.Name = "mcmbBoxFactors";
            this.mcmbBoxFactors.Size = new System.Drawing.Size(164, 24);
            this.mcmbBoxFactors.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Data Source:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Linear Regression";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mrBtnMinMissing);
            this.groupBox2.Controls.Add(this.mrBtnMedian);
            this.groupBox2.Controls.Add(this.mrBtnFirst);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(29, 153);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(491, 148);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pick Reference";
            // 
            // mrBtnMinMissing
            // 
            this.mrBtnMinMissing.AutoSize = true;
            this.mrBtnMinMissing.Checked = true;
            this.mrBtnMinMissing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrBtnMinMissing.Location = new System.Drawing.Point(63, 110);
            this.mrBtnMinMissing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrBtnMinMissing.Name = "mrBtnMinMissing";
            this.mrBtnMinMissing.Size = new System.Drawing.Size(298, 21);
            this.mrBtnMinMissing.TabIndex = 2;
            this.mrBtnMinMissing.TabStop = true;
            this.mrBtnMinMissing.Text = "Dataset with Least Amount of Missing Data";
            this.mrBtnMinMissing.UseVisualStyleBackColor = true;
            // 
            // mrBtnMedian
            // 
            this.mrBtnMedian.AutoSize = true;
            this.mrBtnMedian.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrBtnMedian.Location = new System.Drawing.Point(63, 71);
            this.mrBtnMedian.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrBtnMedian.Name = "mrBtnMedian";
            this.mrBtnMedian.Size = new System.Drawing.Size(309, 21);
            this.mrBtnMedian.TabIndex = 1;
            this.mrBtnMedian.Text = "Create the Median Set in Replicate Category";
            this.mrBtnMedian.UseVisualStyleBackColor = true;
            // 
            // mrBtnFirst
            // 
            this.mrBtnFirst.AutoSize = true;
            this.mrBtnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrBtnFirst.Location = new System.Drawing.Point(63, 34);
            this.mrBtnFirst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrBtnFirst.Name = "mrBtnFirst";
            this.mrBtnFirst.Size = new System.Drawing.Size(220, 21);
            this.mrBtnFirst.TabIndex = 0;
            this.mrBtnFirst.Text = "First Set in Replicate Category";
            this.mrBtnFirst.UseVisualStyleBackColor = true;
            // 
            // niceLine2
            // 
            this.niceLine2.Location = new System.Drawing.Point(16, 31);
            this.niceLine2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.niceLine2.Name = "niceLine2";
            this.niceLine2.Size = new System.Drawing.Size(504, 17);
            this.niceLine2.TabIndex = 21;
            // 
            // niceLine1
            // 
            this.niceLine1.Location = new System.Drawing.Point(25, 383);
            this.niceLine1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.niceLine1.Name = "niceLine1";
            this.niceLine1.Size = new System.Drawing.Size(487, 17);
            this.niceLine1.TabIndex = 4;
            // 
            // mlblDataName
            // 
            this.mlblDataName.AutoSize = true;
            this.mlblDataName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlblDataName.Location = new System.Drawing.Point(299, 53);
            this.mlblDataName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblDataName.Name = "mlblDataName";
            this.mlblDataName.Size = new System.Drawing.Size(52, 17);
            this.mlblDataName.TabIndex = 55;
            this.mlblDataName.Text = "label8";
            // 
            // frmLinRegPar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.mbtnCancel;
            this.ClientSize = new System.Drawing.Size(539, 454);
            this.Controls.Add(this.mlblDataName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.niceLine2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mcmbBoxFactors);
            this.Controls.Add(this.mbtnSelectFolder);
            this.Controls.Add(this.mtxtBoxFolder);
            this.Controls.Add(this.mchkBoxPlot);
            this.Controls.Add(this.niceLine1);
            this.Controls.Add(this.mbtnCancel);
            this.Controls.Add(this.mbtnOK);
            this.Controls.Add(this.mlblPickFactor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLinRegPar";
            this.ShowInTaskbar = false;
            this.Text = "Pick Parameters for Linear Regression";
            this.Load += new System.EventHandler(this.frmPickFactor_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ExtraControls.NiceLine niceLine1;
        #endregion
        private Button mbtnSelectFolder;
        private TextBox mtxtBoxFolder;
        private CheckBox mchkBoxPlot;
        private ComboBox mcmbBoxFactors;
        private Label label2;
        private Label label3;
        private ExtraControls.NiceLine niceLine2;
        private GroupBox groupBox2;
        private RadioButton mrBtnMinMissing;
        private RadioButton mrBtnMedian;
        private RadioButton mrBtnFirst;
        private Label mlblDataName;
    }
}