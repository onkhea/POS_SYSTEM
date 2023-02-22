using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.DataLayer;
using POS.Reports;
using POS.Transaction;
using POS.Utilities;

namespace POS.GUI.Purchases
{
    public partial class SIPOPURCHASEORDER_PRINT_FRM : Form//DevComponents.DotNetBar.Office2007Form
    {
        public SIPOPURCHASEORDER_PRINT_FRM()
        {
            InitializeComponent();
        }

         DropDownList downList = new DropDownList();
         DataManager dataManager = new DataManager();

        private void SIPOPURCHASEORDER_PRINT_FRM_Load(object sender, EventArgs e)
        {

        }

        private void btnF1_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            Int16 i = 5;
            downList.BindingData("SELECT REP_CODE, REP_DESC, REP_TYPE FROM SIREPORT WHERE REP_TYPE = 'Print Purchase Form '", txtF1, this, droplistFrm, btnF1, i, 2);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtF1.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtDesc1.Text = droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
            }

        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (Condition.EmptyControl(txtF1))
                    return;

                if (!dataManager.Exists("SIREPORT", txtF1.Text, "REP_CODE", "REP_TYPE", "Print Purchase Form"))
                {
                    MessageBox.Show("Data '" + txtF1.Text + "' does not exists", "Existing", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    txtF1.SelectAll();
                    txtF1.Focus();
                    return;
                }

                var tblDataTable = new DataTable();
                var dt = dataManager.GetData("SELECT REP_DATA FROM SIREPORT", "REP_CODE", "REP_TYPE",
                                             "Print Purchase Form", "REP_CODE", txtF1.Text);
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0][0].ToString() != "")
                    {
                       
                            tblDataTable =
                                dataManager.GetData("SELECT * FROM V_PurchaseOrder_Print WHERE [Order Code] = '" +
                                                    txtRef1.Text + "'");
                        if (tblDataTable.Rows.Count <= 0)
                        {
                            MessageBox.Show("There are no purchase order data to be printed.", "No Purchase",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }                     
                    }
                    else
                    {
                        MessageBox.Show("There are no report format to print purchase order.", "Format Printing",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                Report report = new Report();
                report.Preview("Print Purchase Form",tblDataTable);
            
        }
            catch (Exception)
            {
                
                throw;
            }
//          
//                    MsgBox("There are no report format to print purchase order.", MsgBoxStyle.Critical)
//                    Exit Sub
//                End If
//            Else
//                MsgBox("There are no report format to print purchase order.", MsgBoxStyle.Critical)
//                Exit Sub
//            End If
//            'PRINT REPORT
//            Try
//                Dim ReportFile As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData, "report.repx")
//                If File.Exists(ReportFile) Then File.Delete(ReportFile)
//                Dim FS As New FileStream(ReportFile, FileMode.CreateNew)
//                Dim FR As New StreamWriter(FS)
//                FR.Write(TBL.Rows(0)(0))
//                FR.Close()
//                FS.Close()
//                Dim R As XtraReport = XtraReport.FromFile(ReportFile, True)
//                With R
//                    .DataSource = TBLDATA
//                    .ShowPreviewDialog()
//                    .ClosePreview()
//                End With
//                File.Delete(ReportFile)
//            Catch ex As Exception
//                MsgBox("The report format have problem to print.", MsgBoxStyle.Critical)
//            End Try
//            Me.Close()
//        Catch ex As Exception
//            MsgBox(ex.Message, MsgBoxStyle.Critical)
//        End Try
        }
    }
}
