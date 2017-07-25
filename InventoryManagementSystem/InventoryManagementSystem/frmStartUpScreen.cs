using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class frmStartUpScreen : Form
    {
        public frmStartUpScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
                timer1.Stop();
        }
    }
}
