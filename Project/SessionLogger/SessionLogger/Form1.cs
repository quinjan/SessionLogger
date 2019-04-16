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
    public partial class mainForm : Form
    {
        private adminLogoutForm adminLogoutWindow;
        private adviseeRegisterForm adviseeRegisterWindow;
        private endSessionForm endSessionWindow;
        private adviserLoginForm adviserLoginWindow;
        private adminCreateAccountForm adminCreateAccountWindow;
        public mainForm()
        {
            InitializeComponent();
            backPanel.BackColor = Color.FromArgb(200, Color.White);
            hidePanels();
            hideAdminPanels();
            adviseePanel.Show();
        }

        private void hidePanels()
        {
            adviseePanel.Hide();
            adviserPanel.Hide();
            adminPanel.Hide();
        }

        private void hideAdminPanels()
        {
            adminEditCoursePanel.Hide();
            editAccountPanel.Hide();
        }

        public void adminLoginSuccessful()
        {
            hidePanels();
            hideAdminPanels();
            bunifuTransition1.ShowSync(adminPanel);
            bunifuTransition1.ShowSync(editAccountPanel);
        }

        private void adviseeButton_Click(object sender, EventArgs e)
        {
            if (adminPanel.Visible == true)
            {
                adminLogoutWindow = new adminLogoutForm(this);
                if (adminLogoutWindow.ShowDialog() == DialogResult.OK)
                {
                    hidePanels();
                    bunifuTransition1.ShowSync(adviseePanel);
                }
            }

            else if (adviseePanel.Visible == false)
            {
                hidePanels();
                bunifuTransition1.ShowSync(adviseePanel);
            } 
        }

        private void adviserButton_Click(object sender, EventArgs e)
        {

            if (adminPanel.Visible == true)
            {
                adminLogoutWindow = new adminLogoutForm(this);
                if (adminLogoutWindow.ShowDialog() == DialogResult.OK)
                {
                    hidePanels();
                    bunifuTransition1.ShowSync(adviserPanel);
                }
            }

            else if (adviserPanel.Visible == false)
            {
                hidePanels();
                bunifuTransition1.ShowSync(adviserPanel);
            }
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            if (adminPanel.Visible == false)
            {
                adminLoginForm loginWindow = new adminLoginForm(this);
                loginWindow.ShowDialog();
            }
        }

        private void adminEditAccountButton_Click(object sender, EventArgs e)
        {
            if (editAccountPanel.Visible == false)
            {
                hideAdminPanels();
                bunifuTransition1.ShowSync(editAccountPanel);
            }
        }

        private void adminEditCoursesButton_Click(object sender, EventArgs e)
        {
            if (adminEditCoursePanel.Visible == false)
            {
                hideAdminPanels();
                bunifuTransition1.ShowSync(adminEditCoursePanel);
            }
        }

        private void adviseeRegisterButton_Click(object sender, EventArgs e)
        {
            adviseeRegisterWindow = new adviseeRegisterForm(this);
            adviseeRegisterWindow.ShowDialog();
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            endSessionWindow = new endSessionForm(this);
            endSessionWindow.ShowDialog();
        }

        private void adviserLoginButton_Click(object sender, EventArgs e)
        {
            adviserLoginWindow = new adviserLoginForm(this);
            adviserLoginWindow.ShowDialog();
        }

        private void adviserLogoutButton_Click(object sender, EventArgs e)
        {
            adminLogoutWindow = new adminLogoutForm(this);
            adminLogoutWindow.ShowDialog();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            adminCreateAccountWindow = new adminCreateAccountForm(this);
            adminCreateAccountWindow.ShowDialog();
        }
    }
}
