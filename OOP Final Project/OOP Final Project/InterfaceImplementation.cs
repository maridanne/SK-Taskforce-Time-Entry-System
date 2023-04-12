using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Final_Project
{
    //Here, we implement the OOP Style called INTERFACE...
    interface ILoginFailed
    {
        void logInfailedfunc();
    }
    public class InterfaceImplementation : ILoginFailed
    {
        public void logInfailedfunc()
        {
            MessageBox.Show("Log in failed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
