using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimitControl_alfa
{
    public partial class AddBankForm : Form
    {
        public AddBankForm()
        {
            InitializeComponent();
        }

        private void btnAddBankCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBankForm_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            tbBankName.Clear();
            tbBaseAc.Clear();
            tbActualCredPos.Clear();
            tbNCLimit.Clear();
            tbNCRate.Clear();
            tbOverallLimit.Clear();
            tbNostroLimit.Clear();
            tbCashLimit.Clear();
            tbCredOper1DayLimit.Clear();
            tbForexLimit.Clear();
            tbSecuritiesLimit.Clear();
            tbOthersOperLimit.Clear();
        }
    }
}
