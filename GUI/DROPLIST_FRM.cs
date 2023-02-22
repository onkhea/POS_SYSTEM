using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace POS.GUI
{
    public partial class DROPLIST_FRM : Form
    {
        public DROPLIST_FRM()
        {
            InitializeComponent();
        }
        
        public int SelectIndex;

        private void dataGridViewX1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView.SelectedRows.Count > 0)
            {
                SelectIndex = DataGridView.SelectedRows[0].Index;
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                DialogResult = System.Windows.Forms.DialogResult.No;
            }
        }

        private void dataGridViewX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (DataGridView.SelectedRows.Count > 0)
                {
                    SelectIndex = DataGridView.SelectedRows[0].Index;
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
        }

        private void dataGridViewX1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    DialogResult = System.Windows.Forms.DialogResult.No;
                    break;
                case Keys.Back:
                    DialogResult = System.Windows.Forms.DialogResult.No;
                    break;
            }
        }

        private void dataGridViewX1_MouseEnter(object sender, EventArgs e)
        {
            if (DataGridView.Rows.Count == 0)
            {
                DialogResult = System.Windows.Forms.DialogResult.No;
            }
        }
    }
}
