using System;
using System.Windows.Forms;
using POS.DataLayer;
using POS.Transaction;
using POS.Transaction.Sale;
using POS.Utilities;
using POS.Transaction.Security;

namespace POS.GUI.POS
{
    public partial class AddcustomerPos : Form
    {
        SetupLocationCustomerPos _setupLocation = new SetupLocationCustomerPos();
        public AddcustomerPos(SetupLocationCustomerPos setupLocationCustomerPOS)
        {
            InitializeComponent();
            _setupLocation = setupLocationCustomerPOS;
        }

        #  region global variable

        readonly DropDownList _dropDownList = new DropDownList();
        readonly DataManager _dataManager = new DataManager();
        #endregion

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            const Int16 i = 3;
            _dropDownList.BindingData("SELECT SI_CODE,SUBSTRING(SI_DATA,0,15) EMP_NAME FROM SIPDATA WHERE SI_TYPE = 'EMP'",txtEmpCode,this,droplistFrm,btnEmployee,i);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtEmpCode.Text =
                    droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtEmpName.Text =
                    droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
                txtCustomerCode.Focus();
            }
        }

        private void txtEmpCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtEmpCode.Text))
                {
                    var dt = _dataManager.GetData("SELECT SI_CODE,SUBSTRING(SI_DATA,0,15) EMP_NAME FROM SIPDATA WHERE SI_TYPE = 'EMP' AND UPPER(SI_TYPE) LIKE UPPER('"+txtEmpCode.Text + "%')");
                    if (dt.Rows.Count > 0)
                    {
                        txtEmpCode.Text = dt.Rows[0][0].ToString();
                        txtEmpName.Text = dt.Rows[0][1].ToString();
                        txtCustomerCode.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Not found code '" + txtEmpCode.Text + "'", "Not found", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        txtEmpCode.SelectionStart = 0;
                        txtEmpCode.SelectionLength = txtEmpCode.Text.Length;
                        txtEmpCode.Focus();
                        return;

                    }
                }
            }
            else if(e.KeyCode == Keys.F6)
            {
                btnEmployee_Click(null,null);
            }
        }

        private void btnUsercode_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            const Int16 i = 3;
            _dropDownList.BindingData("SELECT ADD_CODE,ADD_NAME FROM SIPADDR WHERE ADD_TYPE = '0' AND ADD_STAT = 'A'",
                                      txtCustomerCode, this, droplistFrm, btnCustomerCode,i);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtCustomerCode.Text =
                    droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtCustomerName.Text =
                    droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
                txtUserCode.Focus();
            }
        }

        private void txtUserCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtCustomerCode.Text))
                {
                    var dt =
                       _dataManager.GetData("SELECT ADD_CODE,ADD_NAME FROM SIPADDR WHERE ADD_TYPE = '0' AND ADD_STAT = 'A' AND UPPER(ADD_CODE) LIKE UPPER('" +
                            txtCustomerCode.Text + "%')");
                    if (dt.Rows.Count > 0)
                    {
                        txtCustomerCode.Text = dt.Rows[0][0].ToString();
                        txtCustomerName.Text = dt.Rows[0][1].ToString();
                        txtUserCode.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Not found code '" + txtCustomerCode.Text + "'", "Not found", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        txtCustomerCode.SelectionStart = 0;
                        txtCustomerCode.SelectionLength = txtCustomerCode.Text.Length;
                        txtCustomerCode.Focus();
                        return;
                    }
                }
            }
            else if(e.KeyCode ==Keys.F6)
            {
                btnUsercode_Click(null,null);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            const Int16 i = 3;
            _dropDownList.BindingData("SELECT LOC_CODE, LOC_NAME FROM SIPLOCA", txtLocCode, this, droplistFrm,
                                      btnLocation, i);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtLocCode.Text =
                    droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtLocName.Text =
                    droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
                txtEmpCode.Focus();
            }
        }

        private void txtLocCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                var dt =
                    _dataManager.GetData("SELECT LOC_CODE, LOC_NAME FROM SIPLOCA WHERE UPPER(LOC_CODE) LIKE UPPER('" +
                                         txtLocCode.Text + "%')");
                if (!string.IsNullOrEmpty(txtLocCode.Text))
                {
                    if (dt.Rows.Count > 0)
                    {
                        txtLocCode.Text = dt.Rows[0][0].ToString();
                        txtLocName.Text = dt.Rows[0][1].ToString();
                        txtEmpCode.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Not found code '" + txtLocCode.Text + "'", "Not Found", MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        txtLocCode.SelectionStart = 0;
                        txtLocCode.SelectionLength = txtLocCode.Text.Length;
                        txtLocCode.Focus();
                        return;
                        
                    }
                }
            }
            else if(e.KeyCode == Keys.F6)
            {
                btnLocation_Click(null,null);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            if (Condition.EmptyControl(txtLocCode,txtEmpCode,txtCustomerCode))
            {
                MessageBox.Show("Please fill into blank textbox", "Blank", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }
            if (_setupLocation.isEdit== false)
            {
                if (_dataManager.Exists("SIPCUSPOS","LOC_CODE",txtLocCode.Text,"EMP_CODE",txtEmpCode.Text,"ADD_CODE",txtCustomerCode.Text))
                {
                    MessageBox.Show("Please check again. this record already in database.", "Existing Record",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmpCode.SelectionStart = 0;
                    txtEmpCode.SelectionLength = txtEmpCode.Text.Length;
                    txtEmpCode.Focus();
                    txtCustomerCode.Clear();
                    txtCustomerName.Clear();
                    return;
                }
                var setupCustomerPOS = new SetupCustomerPOS();
                var value = new[]
                                {
                                    txtEmpCode.Text,txtLocCode.Text, txtCustomerCode.Text,txtUserCode.Text,
                                    UserLogOn.Code, UserLogOn.Code, DateTime.Now.ToShortDateString(), DateTime.Now.ToShortDateString()
                                };
                setupCustomerPOS.Save(value);
                _setupLocation.DataGridView1.Rows.Add(txtLocCode.Text, txtLocName.Text,
                                                      txtEmpCode.Text, txtEmpName.Text,
                                                      txtCustomerCode.Text, txtCustomerName.Text, txtUserCode.Text,
                                                      txtUserName.Text);
                txtEmpCode.Clear();
                txtEmpName.Clear();
                txtCustomerCode.Clear();
                txtCustomerName.Clear();
                txtUserCode.Clear();
                txtUserName.Clear();
                txtEmpCode.Focus();
            }
            else
            {
                var setupCustomerPOS = new SetupCustomerPOS();
                var paramValue = new[]
                                {
                                    "EMP_CODE", txtEmpCode.Text, "ADD_CODE", txtCustomerCode.Text,
                                    "USER_UPDT", "asdfas", "UPDT_DATE", DateTime.Now.ToShortDateString(),"USER_CODE",txtUserCode.Text
                                };
                var condition = new[] {"LOC_CODE", txtLocCode.Text};
                setupCustomerPOS.Update(paramValue,condition);
                SIDataGridView.BindingData_ToGrid_OnSelected(_setupLocation.DataGridView1, txtLocCode.Text,
                                                             txtLocName.Text, txtEmpCode.Text, txtEmpName.Text,
                                                             txtCustomerCode.Text, txtCustomerName.Text,
                                                             txtUserCode.Text, txtUserName.Text);
                MessageBox.Show("Edit is successfully","Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();

            }
                


        }

        private void AddcustomerPos_Load(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            var droplistFrm = new DROPLIST_FRM();
            const Int16 i = 3;
            _dropDownList.BindingData("SELECT USER_CODE,[USER_NAME] FROM SIPUSERS",
                                      txtUserCode, this, droplistFrm, btnUser, i);
            if (droplistFrm.ShowDialog() == DialogResult.OK)
            {
                txtUserCode.Text =
                    droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[0].Value.ToString();
                txtUserName.Text =
                    droplistFrm.DataGridView.Rows[droplistFrm.SelectIndex].Cells[1].Value.ToString();
            }
        }

        private void txtUserCode_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                var dt =
                    _dataManager.GetData("SELECT USER_CODE,[USER_NAME] FROM SIPUSERS WHERE UPPER(USER_CODE) LIKE ('" +
                                         txtUserCode.Text + "%')");
                if (dt.Rows.Count > 0)
                {
                    txtUserCode.Text = dt.Rows[0][0].ToString();
                    txtUserName.Text = dt.Rows[0][1].ToString();
                    btnOk.Focus();
                }
            }
            else if(e.KeyCode == Keys.F6)
            {
                btnUser_Click(null,null);
            }
        }
    }
}
