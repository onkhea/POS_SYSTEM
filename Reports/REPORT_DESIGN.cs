using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS.Reports
{
    public partial class REPORT_DESIGN : Form
    {
        public REPORT_DESIGN()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var path = Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData) + "\\REPORTS";
                var File = Path.Combine(path, "report.repx");
                // specify the report's path for the design panel
                xrDesignPanel1.FileName = File;
                // sale the report to the specified path.
                xrDesignPanel1.SaveReport();
                DialogResult = DialogResult.OK;
                Close();
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }
    }
}
