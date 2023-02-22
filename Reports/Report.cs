using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using POS.DataLayer;

namespace POS.Reports
{
    class Report
    {
        DataManager dataManager = new DataManager();
        public void Preview(string reportName, DataTable table)
        {
            var dataTable = new DataTable();
            dataTable = table;
            var condition = new[] { "REP_TYPE", reportName, "REP_STAT", "A" };
            string dateUpdate = DataAccess.ReturnField("SELECT DATE_UPDT FROM SIREPORT", "REP_CODE", condition, 0);
            if (Int64.Parse(dateUpdate) > 0)
            {
                try
                {
                    var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\REPORTS";
                    var file = Path.Combine(path, reportName + ".repx");
                    if (File.Exists(file) == false)
                    {
                        if (File.Exists(path) == false)
                        {
                            Directory.CreateDirectory(path);
                        }
                        var dt = dataManager.GetData("SELECT REP_DATA FROM SIREPORT", "REP_CODE", "REP_TYPE", reportName,
                                                     "REP_STAT", "A");
                        var fs = new FileStream(file, FileMode.CreateNew);
                        var fr = new StreamWriter(fs);
                        fr.Write(dt.Rows[0][0]);
                        fr.Close();
                        fs.Close();
                    }
                    var rpt = new XtraReport();
                    rpt = XtraReport.FromFile(file, true);
                    var dd = dataTable.Rows.Count;
                    rpt.DataSource = dataTable;

                    
                    rpt.ShowPreviewDialog();
                    rpt.ClosePreview();
                    File.Delete(file);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The report format have problem to print.");
//                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("The report format have not been created.");
            }
        }

        public void Preview(string reportName, DataTable table,params string[] paramNameAndValues)
        {
            var dataTable = new DataTable();
            dataTable = table;
            var condition = new[] { "REP_TYPE", reportName, "REP_STAT", "A" };
            string dateUpdate = DataAccess.ReturnField("SELECT DATE_UPDT FROM SIREPORT", "REP_CODE", condition, 0);
            if (Int64.Parse(dateUpdate) > 0)
            {
                try
                {
                    var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\REPORTS";
                    var file = Path.Combine(path, reportName + ".repx");
                    if (File.Exists(file) == false)
                    {
                        if (File.Exists(path) == false)
                        {
                            Directory.CreateDirectory(path);
                        }
                        var dt = dataManager.GetData("SELECT REP_DATA FROM SIREPORT", "REP_CODE", "REP_TYPE", reportName,
                                                     "REP_STAT", "A");
                        var fs = new FileStream(file, FileMode.CreateNew);
                        var fr = new StreamWriter(fs);
                        var ddd = dt.Rows.Count;
                        fr.Write(dt.Rows[0][0]);
                        fr.Close();
                        fs.Close();
                    }
                    var rpt = new XtraReport();
                    rpt = XtraReport.FromFile(file, true);
                    rpt.DataSource = dataTable;
                    for (int i = 0; i < paramNameAndValues.Length; i += 2)
                    {
                        rpt.Parameters[paramNameAndValues[i]].Value = paramNameAndValues[i + 1];
                    }
                    
                    rpt.ShowPreviewDialog();
                    rpt.ClosePreview();
                    System.IO.File.Delete(file);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The report format have problem to print.");
                    //                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("The report format have not been created.");
            }
        }

        public void QuickPrint(string reportName, DataTable table)
        {
            var dataTable = new DataTable();
            dataTable = table;
            var condition = new[] { "REP_TYPE", reportName, "REP_STAT", "A" };
            string dateUpdate = DataAccess.ReturnField("SELECT DATE_UPDT FROM SIREPORT", "REP_CODE", condition, 0);
            if (Int64.Parse(dateUpdate) > 0)
            {
                try
                {
                    var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\REPORTS";
                    var file = Path.Combine(path, reportName + ".repx");
                    if (File.Exists(file) == false)
                    {
                        if (File.Exists(path) == false)
                        {
                            Directory.CreateDirectory(path);
                        }
                        var dt = dataManager.GetData("SELECT REP_DATA FROM SIREPORT", "REP_CODE", "REP_TYPE", reportName,
                                                     "REP_STAT", "A");
                        var fs = new FileStream(file, FileMode.CreateNew);
                        var fr = new StreamWriter(fs);
                        var ddd = dt.Rows.Count;
                        fr.Write(dt.Rows[0][0]);
                        fr.Close();
                        fs.Close();
                    }
                    var rpt = new XtraReport();
                    rpt = XtraReport.FromFile(file, true);
                    var dd = dataTable.Rows.Count;
                    rpt.DataSource = dataTable;
                    rpt.Print();
//                    rpt.ShowPreviewDialog();
                    rpt.ClosePreview();
                    System.IO.File.Delete(file);
                }
                catch (Exception ex)
                {
                    //                    MessageBox.Show("The report format have problem to print.");
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("The report format have not been created.");
            }
        }
    }
}
