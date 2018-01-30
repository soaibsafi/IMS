using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class frmStartUpScreen : Form
    {
        public frmStartUpScreen()
        {
            InitializeComponent();
        }

        private void startUpScreenTimer_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
                startUpScreenTimer.Stop();
        }
    }
}
