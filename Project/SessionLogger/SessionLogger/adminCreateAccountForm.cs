using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SessionLogger
{
    public partial class adminCreateAccountForm : Form
    {
        private mainForm myParent;
        public adminCreateAccountForm(mainForm form1)
        {
            InitializeComponent();
            myParent = form1;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
