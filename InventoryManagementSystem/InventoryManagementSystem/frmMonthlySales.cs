﻿using System;
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
    public partial class frmMonthlySales : Form
    {
        public Form RefToAdminPanel { get; set; }
        public frmMonthlySales()
        {
            InitializeComponent();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}