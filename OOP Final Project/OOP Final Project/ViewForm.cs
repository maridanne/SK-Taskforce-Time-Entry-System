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
public partial class ViewForm : Form
{
        public ViewForm()
            {
                InitializeComponent();
            }

            public void ViewForm_Load(object sender, EventArgs e)
            {
                // TODO: This line of code loads data into the 'myDatabaseDataSet.MyTable' table. You can move, or remove it, as needed.
                this.myTableTableAdapter.Fill(this.myDatabaseDataSet.MyTable);



            }


            private void addBtn_Click(object sender, EventArgs e)
            {
                AddForm addf = new AddForm();
                addf.Show();
                this.Visible = false;
            }

            private void myTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
            {
                this.Validate();
                this.myTableBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.myDatabaseDataSet);

            }

            private void clsBtn_Click(object sender, EventArgs e)
            {
            this.Close();
            HomeBtn hmfunc = new HomeBtn();
            hmfunc.GoTo();

            }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBtn addfunc = new AddBtn();
            addfunc.GoTo();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            HomeBtn homefunc = new HomeBtn();
            homefunc.GoTo();
            
            
        }
    }

}

