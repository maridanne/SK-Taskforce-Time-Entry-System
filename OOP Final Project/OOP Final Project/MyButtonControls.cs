using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

 
namespace OOP_Final_Project
{
    public abstract class MainClass
    {
        public abstract void GoTo();

    }

    // In this class, we apply the OOP Style called POLYMORPHISM ABSTRACTION...
    public class MyButtonControls : MainClass
    {
        public override void  GoTo()
        {
            Form frm = new Form();
            frm.Close();
        }
    }
    // child classes overriding the method of the baseclass...
    public class AddBtn : MyButtonControls 
    {
        public override void GoTo()
        {
            try
            {
                AddForm addf = new AddForm();
                addf.Show(); // Here, the OOP Style called EXCEPTION is implemented...
            }
            catch
            {
                AddForm addf = new AddForm();
                addf.Show();
            }
        }
    }
    public class ViewBtn : MyButtonControls
    {
        public override void GoTo()
        {
            try
            {
                ViewForm vf = new ViewForm();
                vf.Show(); //EXCEPTION
            }
            catch
            {
                ViewForm vf = new ViewForm();
                vf.Show();
            }
        }
    }
    public class LogOutBtn : MyButtonControls
    {
        public override void GoTo()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                LogInForm frm1 = new LogInForm();
                frm1.Show();
                ViewForm vf = new ViewForm();
                vf.Close();
                AddForm addf = new AddForm();
                addf.Close();
                MainForm mf = new MainForm();
                mf.Close();

            }
            else if (dialogResult == DialogResult.No)
            {

            }

        }
    }
    public class HomeBtn : MyButtonControls
    {
        public override void GoTo()
        {
            MainForm mf = new MainForm();
            mf.Show();
            ViewForm vf = new ViewForm();
            vf.Close();
            AddForm addf = new AddForm();
            addf.Close();
        }
    }
}


