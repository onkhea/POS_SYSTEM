using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using POS.DataLayer;
using POS.GUI;

namespace POS.Transaction
{
    class DropDownList
    {
        Connection.Connection  connection = new Connection.Connection();
        DataManager dataManager = new DataManager();

        public void BindingData(string SQLStr, TextBox textBox, Form form, DROPLIST_FRM droplist, Button button, params int[] visibleColumn)
        {
            var command = new SqlCommand(SQLStr,connection.Connect());
            var dt = dataManager.GetData(command);
         
            droplist.DataGridView.DataSource = dt;
            droplist.Top = form.Top + textBox.Top + textBox.Height + button.Height + 2 ;
            droplist.Left = form.Left + textBox.Left + button.Height - 18;
            droplist.DataGridView.Columns[0].Width = droplist.DataGridView.Width*34/100;
            droplist.DataGridView.Columns[1].Width = droplist.DataGridView.Width*60/100;
            foreach (var column in visibleColumn)
            {
                droplist.DataGridView.Columns[column].Visible = false;
            }
        }

        public void BindingData(string SQLStr, TextBox textBox, Form form, DROPLIST_FRM droplist, Button button, Int16 addTopPosition ,params int[] visibleColumn)
        {
            var command = new SqlCommand(SQLStr, connection.Connect());
            var dt = dataManager.GetData(command);

            droplist.DataGridView.DataSource = dt;
            droplist.Top = form.Top + textBox.Top + textBox.Height + button.Height + 2 + addTopPosition;
            droplist.Left = form.Left + textBox.Left + button.Height - 18;
            droplist.DataGridView.Columns[0].Width = droplist.DataGridView.Width * 34 / 100;
            droplist.DataGridView.Columns[1].Width = droplist.DataGridView.Width * 60 / 100;
            foreach (var column in visibleColumn)
            {
                droplist.DataGridView.Columns[column].Visible = false;
            }
        }

        public void BindingData(DataTable dataTable, TextBox textBox, Form form, DROPLIST_FRM droplist, Button button, Int16 addTopPosition, params int[] visibleColumn)
        {
            droplist.DataGridView.DataSource = dataTable;
            droplist.Top = form.Top + textBox.Top + textBox.Height + button.Height + 2 + addTopPosition;
            droplist.Left = form.Left + textBox.Left + button.Height - 18;
            droplist.DataGridView.Columns[0].Width = droplist.DataGridView.Width * 34 / 100;
            droplist.DataGridView.Columns[1].Width = droplist.DataGridView.Width * 60 / 100;
            foreach (var column in visibleColumn)
            {
                droplist.DataGridView.Columns[column].Visible = false;
            }
        }


    }
}
