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
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Label2 = new System.Windows.Forms.Label();
            this.DTPDATE = new System.Windows.Forms.DateTimePicker();
            this.txtExchange = new System.Windows.Forms.TextBox();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.NewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lvw
            // 
            resources.ApplyResources(this.Lvw, "Lvw");
            this.Lvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader7,
            this.ColumnHeader2});
            this.Lvw.FullRowSelect = true;
            this.Lvw.HideSelection = false;
            this.Lvw.MultiSelect = false;
            this.Lvw.Name = "Lvw";
            this.Lvw.UseCompatibleStateImageBehavior = false;
            this.Lvw.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            resources.ApplyResources(this.ColumnHeader1, "ColumnHeader1");
            // 
            // ColumnHeader7
            // 
            resources.ApplyResources(this.ColumnHeader7, "ColumnHeader7");
            // 
            // ColumnHeader2
            // 
            resources.ApplyResources(this.ColumnHeader2, "ColumnHeader2");
            // 
            // Label2
            // 
            resources.ApplyResources(this.Label2, "Label2");
            this.Label2.Name = "Label2";
            // 
            // DTPDATE
            // 
            resources.ApplyResources(this.DTPDATE, "DTPDATE");
            this.DTPDATE.Name = "DTPDATE";
            // 
            // txtExchange
            // 
            resources.ApplyResources(this.txtExchange, "txtExchange");
            this.txtExchange.Name = "txtExchange";
            // 
            // ToolStrip1
            // 
            resources.ApplyResources(this.ToolStrip1, "ToolStrip1");
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripButton,
            this.EditToolStripButton1,
            this.DeleteToolStripButton2,
            this.SaveToolStripButton});
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // Label3
            // 
            resources.ApplyResources(this.Label3, "Label3");
            this.Label3.Name = "Label3";
            // 
            // Label6
            // 
            resources.ApplyResources(this.Label6, "Label6");
            this.Label6.Name = "Label6";
            // 
            // txtdesc
            // 
            resources.ApplyResources(this.txtdesc, "txtdesc");
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdesc_KeyDown);
            // 
            // NewToolStripButton
            // 
            resources.ApplyResources(this.NewToolStripButton, "NewToolStripButton");
            this.NewToolStripButton.Name = "NewToolStripButton";
            this.NewToolStripButton.Click += new System.EventHandler(this.NewToolStripButton_Click);
            // 
            // EditToolStripButton1
            // 
            resources.ApplyResources(this.EditToolStripButton1, "EditToolStripButton1");
            this.EditToolStripButton1.Name = "EditToolStripButton1";
            this.EditToolStripButton1.Click += new System.EventHandler(this.EditToolStripButton1_Click);
            // 
            // DeleteToolStripButton2
            // 
            resources.ApplyResources(this.DeleteToolStripButton2, "DeleteToolStripButton2");
            this.DeleteToolStripButton2.Name = "DeleteToolStripButton2";
            this.DeleteToolStripButton2.Click += new System.EventHandler(this.DeleteToolStripButton2_Click);
            // 
            // SaveToolStripButton
            // 
            resources.ApplyResources(this.SaveToolStripButton, "SaveToolStripButton");
            this.SaveToolStripButton.Name = "SaveToolStripButton";
            this.SaveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButton_Click);
            // 
            // EXCHANGERATE_FRM
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lvw);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.DTPDATE);
            this.Controls.Add(this.txtExchange);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtdesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EXCHANGERATE_FRM";
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