using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.DataLayer;
using POS.Utilities;

namespace POS.GUI.Purchases
{
    public partial class PurchaseorderPrintFrm : Form
    {
        public PurchaseorderPrintFrm()
        {
            InitializeComponent();
        }

        DataManager _dataManager = new DataManager();

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (Condition.EmptyControl(txtF1,txtRef1))
                {
                    return;
                }
                if (_dataManager.Exists("SIREPORT",txtF1.Text,"REP_CODE","REP_TYPE","Print Purchase Form") == false)
                {
                    MessageBox.Show("Data '" + txtF1.Text + "' doesn't exists");
                    txtF1.SelectAll();
                    txtF1.Focus();
                    return;
                }
                var dt = new DataTable();

            }
            catch (Exception ex)
            {
                
                throw;
            }
//            Try
//            If CheckEmpty(txtF1, txtRef1) Then Exit Sub
//            If Exists(CN, "SIREPORT", "DB_CODE", DBCODE, "REP_CODE", txtF1.Text, "REP_TYPE", "Print Purchase Form") = False Then
//                MsgBox("Data '" & txtF1.Text & "' does not exists", MsgBoxStyle.Critical)
//                txtF1.SelectAll()
//                txtF1.Focus()
//                Exit Sub
//            End If
//
//            Dim TBLDATA As New DataTable
//            'Dim SHOW_ITEM_DETAIL As String = "A" 'For Print Detail Line Description
//            Dim TBL As DataTable = SelectData(CN, "SELECT REP_DATA FROM SIREPORT", "DB_CODE", DBCODE, "REP_TYPE", "Print Purchase Form", "REP_CODE", txtF1.Text)
//            If TBL.Rows.Count > 0 Then
//                If TBL.Rows(0)(0).ToString.Trim <> "" Then
//                    If cboIn_item.SelectedIndex = 0 Then
//                        TBLDATA = SelectData(CN, "SELECT * FROM _PRINT_ORDER", "Order_code", txtRef1.Text)
//                    Else
//                        TBLDATA = SelectData(CN, "SELECT * FROM _PRINT_ORDER", "Order_code", txtRef1.Text, "Line_Type", "D")
//                    End If
//                    If TBLDATA.Rows.Count <= 0 Then
//                        MsgBox("There are no purchase order data to be printed.", MsgBoxStyle.Critical)
//                        Exit Sub
//                    End If
//                Else
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
