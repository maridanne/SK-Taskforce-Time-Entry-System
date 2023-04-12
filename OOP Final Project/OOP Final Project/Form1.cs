using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Final_Project
{
    
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
        
        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLgn_Click(object sender, EventArgs e)
        {
            childClass staffInfos = new childClass();

            if (txtUser.Text == staffInfos.staff1_user & txtPass.Text == staffInfos.staff1_pass)
            {
                MainForm frm = new MainForm();
                frm.Show();
                this.Visible = false;
               

            }
            else if (txtUser.Text == staffInfos.staff2_user & txtPass.Text == staffInfos.staff2_pass)
            {
                MainForm frm = new MainForm();
                frm.Show();
                this.Visible = false;

            }
            else if (txtUser.Text == staffInfos.staff3_user & txtPass.Text == staffInfos.staff3_pass)
            {
                MainForm frm = new MainForm();
                frm.Show();
                this.Visible = false;

            }
            else
            {
                InterfaceImplementation iI = new InterfaceImplementation();
                iI.logInfailedfunc();
                txtUser.Clear();
                txtPass.Clear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    // Here we apply the OOP Style called INHERITANCE...
    public class AuthorizedStaffs // Parent or the Base Class
    {
        public string staff1_user = "dinahmarieanimos";
        public string staff1_pass = "marie";
        public string staff2_user = "windellmaeurmeneta";
        public string staff2_pass = "windell";
        public string staff3_user = "alessamaediaz";
        public string staff3_pass = "alessa";
    }
    public class childClass : AuthorizedStaffs
    {
        // The child class that will inherit the fields of the parent class (AuthorizedStaffs).
    }
}
