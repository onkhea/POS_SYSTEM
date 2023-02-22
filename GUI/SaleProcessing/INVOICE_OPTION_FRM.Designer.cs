namespace POS.GUI.SaleProcessing
{
    partial class INVOICE_OPTION_FRM
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
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(126, 50);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(179, 20);
            this.textBox15.TabIndex = 37;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(126, 12);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(179, 20);
            this.textBox16.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(43, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "INV Disc (USD)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "INV Discount (%)";
            // 
            // INVOICE_OPTION_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 195);
            this.ControlBox = false;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "INVOICE_OPTION_FRM";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Options";
            this.Load += new System.EventHandler(this.INVOICE_OPTION_FRM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox textBox15;
        internal System.Windows.Forms.TextBox textBox16;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label13;
    }
}