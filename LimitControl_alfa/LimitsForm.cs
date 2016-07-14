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
    public partial class LimitsForm : Form
    {
        public LimitsForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            tbcMain.Dock = DockStyle.Fill;
            tbListLimit.Dock = DockStyle.Fill;
        }
    }
}
