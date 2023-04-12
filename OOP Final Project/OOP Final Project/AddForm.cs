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
    public partial class AddForm : Form
    {
        
        public AddForm()
        {
            InitializeComponent();
            
        }


        private void AddForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDatabaseDataSet.MyTable' table. You can move, or remove it, as needed.
            this.myTableTableAdapter.Fill(this.myDatabaseDataSet.MyTable);

        }


        private void hmBtn_Click(object sender, EventArgs e)
        {
            HomeBtn hmfunc = new HomeBtn(); //Class HomeBtn from MyButtonControls class (Polymorphism)
            hmfunc.GoTo();
        }

        private void vwBtn_Click(object sender, EventArgs e)
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

        private void myTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.myTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDatabaseDataSet);

        }
    }
}
