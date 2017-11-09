using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;

namespace FootBallApplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        int intLogin;
        clsLogin objLogin = new clsLogin();

        private void label3_Click(object sender, EventArgs e)
        {
            try
            {
                //*****************GET USERNAME AND PASSWORD******************


                intLogin = objLogin.fnLogin(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                if (intLogin == 1)
                {
                    frmNavigation frmNavigation = new frmNavigation();
                    frmNavigation.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid user");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            //*******************END**************************************
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            //*****************GET USERNAME AND PASSWORD******************

            if (e.KeyCode == Keys.Enter)
            {
                intLogin = objLogin.fnLogin(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                if (intLogin == 1)
                {
                    frmNavigation frmNavigation = new frmNavigation();
                    frmNavigation.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid user");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }
                //*******************END**************************************
            }
        }

        private void pnllogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlcancel_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pnllogin_MouseDown(object sender, MouseEventArgs e)
        {

            intLogin = objLogin.fnLogin(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if (intLogin == 1)
            {
                frmNavigation frmNavigation = new frmNavigation();
                frmNavigation.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid user");
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
        }

        private void pnlcancel_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void pnllogi1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pnllogi1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                //*****************GET USERNAME AND PASSWORD******************


                intLogin = objLogin.fnLogin(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                if (intLogin == 1)
                {
                    frmNavigation frmNavigation = new frmNavigation();
                    frmNavigation.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid user");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    //*****************GET USERNAME AND PASSWORD******************


                    intLogin = objLogin.fnLogin(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                    if (intLogin == 1)
                    {
                        frmNavigation frmNavigation = new frmNavigation();
                        frmNavigation.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid user");
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }


            }
            }

        private void lblnewuser_Click(object sender, EventArgs e)
        {
            frmNewuser ne = new frmNewuser();
            ne.Show();
        }

        private void lblforgotpassword_Click(object sender, EventArgs e)
        {
            frmNewuser ne = new frmNewuser(1);
            ne.Show();
        }
    }
}
