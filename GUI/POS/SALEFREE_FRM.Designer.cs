namespace POS.GUI.POS
{
    partial class SALEFREE_FRM
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
            this.components = new System.ComponentModel.Container();
            this.Label1 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(15, 86);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(544, 51);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Waiting for barcode scan to sale for free.....";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Limon F3", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(15, 22);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(539, 64);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "rg;caMkarbBa©Úlelx)akUdedIm,Ilk;edayminKitéfø>>>>>";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SALEFREE_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 159);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SALEFREE_FRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SALEFREE_FRM";
            this.Load += new System.EventHandler(this.SALEFREE_FRM_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SALEFREE_FRM_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Label Label2;
    }
}