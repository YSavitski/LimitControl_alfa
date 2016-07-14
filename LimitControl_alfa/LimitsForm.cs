using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimitControl_alfa
{
    public partial class LimitsForm : Form
    {
        public LimitsForm()
        {
           
            InitializeComponent();
            this.CenterToScreen();
            DataTable mytable = new DataTable();
            Connection.LoadDataInTable(string.Format(@"SELECT *FROM BankAccounts"), mytable);
            dataGridView1.DataSource = mytable;
        }

        private void btnAddBank_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result = new AddBankForm().ShowDialog();
        }

        private void LimitsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
