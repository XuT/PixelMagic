﻿namespace PixelMagic.GUI
{
    partial class SelectWoWProcessToAttachTo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectWoWProcessToAttachTo));
            this.cmbWoW = new System.Windows.Forms.ComboBox();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbRotation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbWoW
            // 
            this.cmbWoW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWoW.FormattingEnabled = true;
            this.cmbWoW.Location = new System.Drawing.Point(12, 129);
            this.cmbWoW.Name = "cmbWoW";
            this.cmbWoW.Size = new System.Drawing.Size(223, 21);
            this.cmbWoW.TabIndex = 1;
            // 
            // cmdConnect
            // 
            this.cmdConnect.Image = global::PixelMagic.GUI.Properties.Resources.Register;
            this.cmdConnect.Location = new System.Drawing.Point(270, 140);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(75, 23);
            this.cmdConnect.TabIndex = 2;
            this.cmdConnect.Text = "Connect";
            this.cmdConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdConnect.UseVisualStyleBackColor = true;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Image = global::PixelMagic.GUI.Properties.Resources.Refresh2_16x16;
            this.cmdRefresh.Location = new System.Drawing.Point(241, 140);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(23, 23);
            this.cmdRefresh.TabIndex = 5;
            this.cmdRefresh.TabStop = false;
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PixelMagic.GUI.Properties.Resources.pm;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 109);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cmbRotation
            // 
            this.cmbRotation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRotation.FormattingEnabled = true;
            this.cmbRotation.Location = new System.Drawing.Point(12, 156);
            this.cmbRotation.Name = "cmbRotation";
            this.cmbRotation.Size = new System.Drawing.Size(223, 21);
            this.cmbRotation.TabIndex = 7;
            this.cmbRotation.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SelectWoWProcessToAttachTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 189);
            this.Controls.Add(this.cmbRotation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbWoW);
            this.Controls.Add(this.cmdConnect);
            this.Controls.Add(this.cmdRefresh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectWoWProcessToAttachTo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Please select a WoW Process to connect to:";
            this.Load += new System.EventHandler(this.SelectWoWProcessToAttachTo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.ComboBox cmbWoW;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbRotation;
    }
}