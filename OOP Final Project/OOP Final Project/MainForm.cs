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
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddBtn addfunc = new AddBtn(); //Class AddBtn from MyButtonControls class (Polymorphism)
            addfunc.GoTo();
            this.Close(); 
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            ViewBtn vwfunc = new ViewBtn(); //Class ViewBtn from MyButtonControls class (Polymorphism)
            vwfunc.GoTo();
            this.Close(); 

        }

        

        private void lgOutbtn_Click(object sender, EventArgs e)
        {
            LogOutBtn lgofunc = new LogOutBtn(); //Class LogOutBtn from MyButtonControls class (Polymorphism)
            lgofunc.GoTo();
            this.Close();
        }
    }
}
