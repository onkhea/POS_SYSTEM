namespace POS.GUI.Maintains
{
    partial class EXCHANGERATE_FRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EXCHANGERATE_FRM));
            this.Lvw = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.Label2 = new System.Windows.Forms.Label();
            this.DTPDATE = new System.Windows.Forms.DateTimePicker();
            this.txtExchange = new System.Windows.Forms.TextBox();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lvw
            // 
            this.Lvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader7,
            this.ColumnHeader2});
            this.Lvw.FullRowSelect = true;
            this.Lvw.HideSelection = false;
            this.Lvw.Location = new System.Drawing.Point(2, 81);
            this.Lvw.MultiSelect = false;
            this.Lvw.Name = "Lvw";
            this.Lvw.Size = new System.Drawing.Size(417, 273);
            this.Lvw.TabIndex = 15;
            this.Lvw.UseCompatibleStateImageBehavior = false;
            this.Lvw.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Date";
            this.ColumnHeader1.Width = 80;
            // 
            // ColumnHeader7
            // 
            this.ColumnHeader7.Text = "Exchange Rate";
            this.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ColumnHeader7.Width = 100;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Description";
            this.ColumnHeader2.Width = 212;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(1, 33);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(30, 13);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Date";
            // 
            // DTPDATE
            // 
            this.DTPDATE.Location = new System.Drawing.Point(61, 29);
            this.DTPDATE.Name = "DTPDATE";
            this.DTPDATE.Size = new System.Drawing.Size(200, 20);
            this.DTPDATE.TabIndex = 10;
            // 
            // txtExchange
            // 
            this.txtExchange.Location = new System.Drawing.Point(343, 30);
            this.txtExchange.Name = "txtExchange";
            this.txtExchange.Size = new System.Drawing.Size(76, 20);
            this.txtExchange.TabIndex = 12;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripButton,
            this.EditToolStripButton1,
            this.DeleteToolStripButton2,
            this.SaveToolStripButton});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip1.Size = new System.Drawing.Size(422, 25);
            this.ToolStrip1.TabIndex = 8;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // NewToolStripButton
            // 
            this.NewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NewToolStripButton.Image")));
            this.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolStripButton.Name = "NewToolStripButton";
            this.NewToolStripButton.Size = new System.Drawing.Size(48, 22);
            this.NewToolStripButton.Text = "&New";
            this.NewToolStripButton.Click += new System.EventHandler(this.NewToolStripButton_Click);
            // 
            // EditToolStripButton1
            // 
            this.EditToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("EditToolStripButton1.Image")));
            this.EditToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolStripButton1.Name = "EditToolStripButton1";
            this.EditToolStripButton1.Size = new System.Drawing.Size(45, 22);
            this.EditToolStripButton1.Text = "&Edit";
            this.EditToolStripButton1.Click += new System.EventHandler(this.EditToolStripButton1_Click);
            // 
            // DeleteToolStripButton2
            // 
            this.DeleteToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("DeleteToolStripButton2.Image")));
            this.DeleteToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStripButton2.Name = "DeleteToolStripButton2";
            this.DeleteToolStripButton2.Size = new System.Drawing.Size(58, 22);
            this.DeleteToolStripButton2.Text = "&Delete";
            this.DeleteToolStripButton2.Click += new System.EventHandler(this.DeleteToolStripButton2_Click);
            // 
            // SaveToolStripButton
            // 
            this.SaveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripButton.Image")));
            this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripButton.Name = "SaveToolStripButton";
            this.SaveToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.SaveToolStripButton.Text = "&Save";
            this.SaveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButton_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(263, 33);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(81, 13);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Exchange Rate";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(1, 58);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(60, 13);
            this.Label6.TabIndex = 13;
            this.Label6.Text = "Description";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(61, 55);
            this.txtdesc.MaxLength = 100;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(358, 20);
            this.txtdesc.TabIndex = 14;
            this.txtdesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdesc_KeyDown);
            // 
            // EXCHANGERATE_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 354);
            this.Controls.Add(this.Lvw);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.DTPDATE);
            this.Controls.Add(this.txtExchange);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtdesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EXCHANGERATE_FRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exchange Rate";
            this.Load += new System.EventHandler(this.EXHCNANGERATE_FRM_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListView Lvw;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader7;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DateTimePicker DTPDATE;
        internal System.Windows.Forms.ToolStripButton SaveToolStripButton;
        internal System.Windows.Forms.ToolStripButton DeleteToolStripButton2;
        internal System.Windows.Forms.TextBox txtExchange;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton NewToolStripButton;
        internal System.Windows.Forms.ToolStripButton EditToolStripButton1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtdesc;
    }
}