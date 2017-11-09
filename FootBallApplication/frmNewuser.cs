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
    public partial class frmNewuser : Form
    {
        clsuser objclus = new clsuser();
        int checkforgot = 0;
        public frmNewuser()
        {
            InitializeComponent();
        }

        private void frmNewuser_Load(object sender, EventArgs e)
        {
            if (checkforgot == 1)
            {
                //txtUserName.Visible = false;
                txtPassword.Visible = false;
                txtconfirmpassword.Visible = false;
                btncancel.Visible = false;
                btnsubmit.Visible = false;
                // label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;

                btnpwd.Visible = true;


                label1.Text = "Enter your registered username";
                txtUserName.Location = new Point(256, 88);
                //Newuser.ActiveForm.Text = "Forgot Password";


            }
            else
            {

                txtUserName.Location = new Point(169, 85);
            }
        }

        private void lblgoto_Click(object sender, EventArgs e)
        {

            this.Close();
            Login lo = new Login();
            lo.Show();
        }
        public frmNewuser(int id)
        {
            checkforgot = id;
            InitializeComponent();

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            int already = 0;
            DataTable dtcheckalready = new DataTable();
            dtcheckalready = objclus.getusers();
            //to check  already user exist in databse
            for (int i = 0; i < dtcheckalready.Rows.Count; i++)
            {

                if (txtUserName.Text == dtcheckalready.Rows[i][0].ToString())
                {

                    already = 1;
                }
            }


            if (already == 0)
            {
                if ((txtPassword.Text == txtconfirmpassword.Text) && txtUserName.Text != "")
                {
                    int Res = objclus.createuser(txtUserName.Text, txtPassword.Text);
                    MessageBox.Show("New user created");
                    this.Close();

                }
                else
                {
                    if ((txtPassword.Text != txtconfirmpassword.Text))
                    {
                        MessageBox.Show("Pasword missmatch");

                    }
                    else
                    {
                        MessageBox.Show("Enter all the fields");

                    }

                }
            }
            else
            {
                MessageBox.Show("The username already exists !");

            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnpwd_Click(object sender, EventArgs e)
        {

            DataTable user = new DataTable();


            user = objclus.getusers(txtUserName.Text);
            if (user.Rows.Count > 0)
            {

                if (user.Rows.Count == 1)
                {

                    lblpassword.Text = user.Rows[0][1].ToString();
                    label4.Visible = true;
                    lblpassword.Visible = true;

                }
                else if (user.Rows.Count > 1)
                {
                    MessageBox.Show("Multiple users exists");


                }
            }
            else
            {
                MessageBox.Show("Username does not exists");
            }
        }
    }
}
