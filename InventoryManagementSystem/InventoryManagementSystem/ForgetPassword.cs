using InventoryManagementSystem.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ForgetPassword : Form
    {
        ServiceFactory factory;
        IAccountService accountService;
        public ForgetPassword()
        {
            InitializeComponent();
            factory = new ServiceFactory();
            accountService = factory.GetAccountServiceInstance();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.ToLower();
            string dept = txtDept.Text;

            int valid = accountService.checkValidUser(dept, email);
            MessageBox.Show(valid.ToString());
            if(valid==1)
            {
                string password = accountService.ValidUserPass(dept);
                MessageBox.Show(password);
                if (SendUserEmail(email,password))
                {
                    MessageBox.Show("Mail Send");
                }
                else
                {
                    MessageBox.Show("Incorrect Email");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Email or Dept");
            }

           


        }

        public bool SendUserEmail(string Email,string pass)

        {
            bool status;
            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress("inventorysoft143@gmail.com");
                message.Subject = "Inventory Software Password  Recovery";
                message.Body = " Dear "+txtDept.Text+",  \n You might forgot your password.\n Your Password  : "+pass+ "  \nThank you sir.\n\n \n \n <<<<<<<<<<  This is an Auto Generated Email. Please Do not reply to this email >>>>>>>>>> \n\n  Inventory Software System \n System Admin : Fahim Afser & Soaib safi"; 
                message.To.Add(Email);

                SmtpClient client = new SmtpClient();
                client.Credentials = new NetworkCredential("inventorysoft143@gmail.com", "14-28008-3");
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.Send(message);
                status = true;
            }
            catch
            {
                status = false;
            }
            return status;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
