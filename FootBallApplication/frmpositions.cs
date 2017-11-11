using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data;
using System.Linq;
using BAL;

namespace FootBallApplication
{
    public partial class frmpositions : Form
    {
        public frmpositions()
        {
            InitializeComponent();
        }
        string savedteam = "";
        DataTable dt = new DataTable();
        clsposition pos = new clsposition();
        DataTable dtstore = new DataTable();
        DataTable dtfinal = new DataTable();
        int var = 0;
        private void frmpositions_Load(object sender, EventArgs e)
        {
            dtstore.Columns.Add("players", typeof(string));
            dtfinal.Columns.Add("players", typeof(string));
            dt = new DataTable();
            dt = pos.LoadTeams(clsGlobalValues.mid, clsGlobalValues.Tournament);

            if (dt.Rows.Count > 0)
            {
                cmbteam.Items.Add(dt.Rows[0][0].ToString());
                cmbteam.Items.Add(dt.Rows[0][1].ToString());
            }
            cmbteam.Text = cmbteam.Items[0].ToString();

           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////pnlpitch.Visible=true;
            //label1.Visible = true;
            //label2.Visible = true;

            //label3.Visible = true;
            //label4.Visible = true;



            //label5.Visible = true;
            //label6.Visible = true;

            //label7.Visible = true;
            //label8.Visible = true;

            //label9.Visible = true;
            //label10.Visible = true;

            //label11.Visible = true;
            //label12.Visible = true;

            //label13.Visible = true;

          
           


            //dt = new DataTable();
            //dt = pos.LoadTeamsattribute(clsGlobalValues.mid, clsGlobalValues.Tournament);


            //cmbpo1.Items.Clear();
            //cmbpo2.Items.Clear();
            //cmbpo3.Items.Clear();
            //cmbpo4.Items.Clear();
            //cmbpo5.Items.Clear();
            //cmbpo6.Items.Clear();
            //cmbpo7.Items.Clear();
            //cmbpo8.Items.Clear();
            //cmbpo9.Items.Clear();
            //cmbpo10.Items.Clear();
            //cmbpo11.Items.Clear();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    cmbpo1.Items.Add(dt.Rows[i][0].ToString());
            //    cmbpo2.Items.Add(dt.Rows[i][0].ToString());
            //    cmbpo3.Items.Add(dt.Rows[i][0].ToString());
            //    cmbpo4.Items.Add(dt.Rows[i][0].ToString());
            //    cmbpo5.Items.Add(dt.Rows[i][0].ToString());
            //    cmbpo6.Items.Add(dt.Rows[i][0].ToString());
            //    cmbpo7.Items.Add(dt.Rows[i][0].ToString());
            //    cmbpo8.Items.Add(dt.Rows[i][0].ToString());
            //    cmbpo9.Items.Add(dt.Rows[i][0].ToString());
            //    cmbpo10.Items.Add(dt.Rows[i][0].ToString());
            //    cmbpo11.Items.Add(dt.Rows[i][0].ToString());

            //}

            //dt = new DataTable();
            //dt = pos.Loadplayer(clsGlobalValues.mid, clsGlobalValues.Tournament,cmbteam.SelectedItem.ToString());

            ////chkp1.Visible = true;
            ////chkp2.Visible = true;
            ////chkp3.Visible = true;
            ////chkp4.Visible = true;
            ////chkp5.Visible = true;
            ////chkp6.Visible = true;
            ////chkp7.Visible = true;
            ////chkp8.Visible = true;
            ////chkp9.Visible = true;
            ////chkp10.Visible = true;
            ////chkp11.Visible = true;
            //var = 1;



            //p1.Text = dt.Rows[0][0].ToString();
            //p2.Text = dt.Rows[1][0].ToString();
            //p3.Text = dt.Rows[2][0].ToString();
            //p4.Text = dt.Rows[3][0].ToString();
            //p5.Text = dt.Rows[4][0].ToString();

            //p6.Text = dt.Rows[5][0].ToString();
            //p7.Text = dt.Rows[6][0].ToString();
            //p8.Text = dt.Rows[7][0].ToString();
            //p9.Text = dt.Rows[8][0].ToString();
            //p10.Text = dt.Rows[9][0].ToString();
            //p11.Text = dt.Rows[10][0].ToString();



           


            //    btnSave.Visible = true;


            //cmbpo1.Visible = true;
            //cmbpo2.Visible = true;
            //cmbpo3.Visible = true;
            //cmbpo4.Visible = true;
            //cmbpo5.Visible = true;
            //cmbpo6.Visible = true;

            //cmbpo7.Visible = true;
            //cmbpo8.Visible = true;
            //cmbpo9.Visible = true;
            //cmbpo10.Visible = true;
            //cmbpo11.Visible = true;

            //cmbpo1.Text = dt.Rows[0][1].ToString();
            //cmbpo2.Text = dt.Rows[1][1].ToString();
            //cmbpo3.Text = dt.Rows[2][1].ToString();
            //cmbpo4.Text = dt.Rows[3][1].ToString();
            //cmbpo5.Text = dt.Rows[4][1].ToString();
            //cmbpo6.Text = dt.Rows[5][1].ToString();
            //cmbpo7.Text = dt.Rows[6][1].ToString();
            //cmbpo8.Text = dt.Rows[7][1].ToString();
            //cmbpo9.Text = dt.Rows[8][1].ToString();
            //cmbpo10.Text = dt.Rows[9][1].ToString();
            //cmbpo11.Text = dt.Rows[10][1].ToString();








        }

        private void cmbteam_SelectedIndexChanged(object sender, EventArgs e)
        {


            //chkp1.Checked = true;
            //chkp2.Checked = true;
            //chkp3.Checked = true;
            //chkp4.Checked = true;
            //chkp5.Checked = true;
            //chkp6.Checked = true;
            //chkp7.Checked = true;
            //chkp8.Checked = true;
            //chkp9.Checked = true;
            //chkp10.Checked = true;
            //chkp11.Checked = true;




            cmbpo1.Visible = true;
            cmbpo2.Visible = true;
            cmbpo3.Visible = true;
            cmbpo4.Visible = true;
            cmbpo5.Visible = true;
            cmbpo6.Visible = true;

            cmbpo7.Visible = true;
            cmbpo8.Visible = true;
            cmbpo9.Visible = true;
            cmbpo10.Visible = true;
            cmbpo11.Visible = true;



            label1.Visible = true;
                label2.Visible = true;

                label3.Visible = true;
                label4.Visible = true;



                label5.Visible = true;
                label6.Visible = true;

                label7.Visible = true;
                label8.Visible = true;

                label9.Visible = true;
                label10.Visible = true;

                label11.Visible = true;
                label12.Visible = true;

                label13.Visible = true;





                dt = new DataTable();
                dt = pos.LoadTeamsattribute(clsGlobalValues.mid, clsGlobalValues.Tournament);


                cmbpo1.Items.Clear();
                cmbpo2.Items.Clear();
                cmbpo3.Items.Clear();
                cmbpo4.Items.Clear();
                cmbpo5.Items.Clear();
                cmbpo6.Items.Clear();
                cmbpo7.Items.Clear();
                cmbpo8.Items.Clear();
                cmbpo9.Items.Clear();
                cmbpo10.Items.Clear();
                cmbpo11.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbpo1.Items.Add(dt.Rows[i][0].ToString());
                    cmbpo2.Items.Add(dt.Rows[i][0].ToString());
                    cmbpo3.Items.Add(dt.Rows[i][0].ToString());
                    cmbpo4.Items.Add(dt.Rows[i][0].ToString());
                    cmbpo5.Items.Add(dt.Rows[i][0].ToString());
                    cmbpo6.Items.Add(dt.Rows[i][0].ToString());
                    cmbpo7.Items.Add(dt.Rows[i][0].ToString());
                    cmbpo8.Items.Add(dt.Rows[i][0].ToString());
                    cmbpo9.Items.Add(dt.Rows[i][0].ToString());
                    cmbpo10.Items.Add(dt.Rows[i][0].ToString());
                    cmbpo11.Items.Add(dt.Rows[i][0].ToString());

                }



                dt = new DataTable();
                dt = pos.Loadplayer(clsGlobalValues.mid, clsGlobalValues.Tournament, cmbteam.SelectedItem.ToString());
                //chkp1.Visible = true;
                //chkp2.Visible = true;
                //chkp3.Visible = true;
                //chkp4.Visible = true;
                //chkp5.Visible = true;
                //chkp6.Visible = true;
                //chkp7.Visible = true;
                //chkp8.Visible = true;
                //chkp9.Visible = true;
                //chkp10.Visible = true;
                //chkp11.Visible = true;

                p1.Text = dt.Rows[0][0].ToString();
                p2.Text = dt.Rows[1][0].ToString();
                p3.Text = dt.Rows[2][0].ToString();
                p4.Text = dt.Rows[3][0].ToString();
                p5.Text = dt.Rows[4][0].ToString();

                p6.Text = dt.Rows[5][0].ToString();
                p7.Text = dt.Rows[6][0].ToString();
                p8.Text = dt.Rows[7][0].ToString();
                p9.Text = dt.Rows[8][0].ToString();
                p10.Text = dt.Rows[9][0].ToString();
                p11.Text = dt.Rows[10][0].ToString();

                cmbpo1.Text = dt.Rows[0][1].ToString();
                cmbpo2.Text = dt.Rows[1][1].ToString();
                cmbpo3.Text = dt.Rows[2][1].ToString();
                cmbpo4.Text = dt.Rows[3][1].ToString();
                cmbpo5.Text = dt.Rows[4][1].ToString();
                cmbpo6.Text = dt.Rows[5][1].ToString();
                cmbpo7.Text = dt.Rows[6][1].ToString();
                cmbpo8.Text = dt.Rows[7][1].ToString();
                cmbpo9.Text = dt.Rows[8][1].ToString();
                cmbpo10.Text = dt.Rows[9][1].ToString();
                cmbpo11.Text = dt.Rows[10][1].ToString();
            

        }

       
        
       
        private void cmbgk1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
               

                



        }

        private void cmblf1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbrf1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void cmbmf1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pos.updateplayer(clsGlobalValues.mid, clsGlobalValues.Tournament, cmbteam.SelectedItem.ToString(), cmbmf1.SelectedItem.ToString());

           
          
        }

        private void cmbmf6_SelectedIndexChanged(object sender, EventArgs e)
        {
          
           
        }

        private void cmbmf11_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cmbmf16_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            //p9.Text = comboBox16.SelectedItem.ToString();
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
           // p10.Text = comboBox25.SelectedItem.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbpo1.SelectedItem.ToString()!="")
                {
                    pos.insertPosition(clsGlobalValues.mid, clsGlobalValues.Tournament, cmbteam.SelectedItem.ToString(), chkp1.Text, comboBox1.SelectedItem.ToString(), cmbpo1.SelectedItem.ToString());
                }

                if (cmbpo2.SelectedItem.ToString() != "")
                {
                    pos.insertPosition(clsGlobalValues.mid, clsGlobalValues.Tournament, cmbteam.SelectedItem.ToString(), chkp2.Text, comboBox1.SelectedItem.ToString(), cmbpo1.SelectedItem.ToString());
                }

                if (cmbpo3.SelectedItem.ToString() != "")
                {
                    pos.insertPosition(clsGlobalValues.mid, clsGlobalValues.Tournament, cmbteam.SelectedItem.ToString(), chkp3.Text, comboBox1.SelectedItem.ToString(), cmbpo1.SelectedItem.ToString());
                }

                if (cmbpo4.SelectedItem.ToString() != "")
                {
                    pos.insertPosition(clsGlobalValues.mid, clsGlobalValues.Tournament, cmbteam.SelectedItem.ToString(), chkp4.Text, comboBox1.SelectedItem.ToString(), cmbpo1.SelectedItem.ToString());
                }

                if (cmbpo5.SelectedItem.ToString() != "")
                {
                    pos.insertPosition(clsGlobalValues.mid, clsGlobalValues.Tournament, cmbteam.SelectedItem.ToString(), chkp5.Text, comboBox1.SelectedItem.ToString(), cmbpo1.SelectedItem.ToString());
                }
                if (cmbpo6.SelectedItem.ToString() != "")
                {
                    pos.insertPosition(clsGlobalValues.mid, clsGlobalValues.Tournament, cmbteam.SelectedItem.ToString(), chkp6.Text, comboBox1.SelectedItem.ToString(), cmbpo1.SelectedItem.ToString());
                }

                if (cmbpo7.SelectedItem.ToString() != "")
                {
                    pos.insertPosition(clsGlobalValues.mid, clsGlobalValues.Tournament, cmbteam.SelectedItem.ToString(), chkp7.Text, comboBox1.SelectedItem.ToString(), cmbpo1.SelectedItem.ToString());
                }

                if (cmbpo8.SelectedItem.ToString() != "")
                {
                    pos.insertPosition(clsGlobalValues.mid, clsGlobalValues.Tournament, cmbteam.SelectedItem.ToString(), chkp8.Text, comboBox1.SelectedItem.ToString(), cmbpo1.SelectedItem.ToString());
                }

                if (cmbpo9.SelectedItem.ToString() != "")
                {
                    pos.insertPosition(clsGlobalValues.mid, clsGlobalValues.Tournament, cmbteam.SelectedItem.ToString(), chkp9.Text, comboBox1.SelectedItem.ToString(), cmbpo1.SelectedItem.ToString());
                }


                if (cmbpo10.SelectedItem.ToString() != "")
                {
                    pos.insertPosition(clsGlobalValues.mid, clsGlobalValues.Tournament, cmbteam.SelectedItem.ToString(), chkp10.Text, comboBox1.SelectedItem.ToString(), cmbpo1.SelectedItem.ToString());
                }

                if (cmbpo11.SelectedItem.ToString() != "")
                {
                    pos.insertPosition(clsGlobalValues.mid, clsGlobalValues.Tournament, cmbteam.SelectedItem.ToString(), chkp11.Text, comboBox1.SelectedItem.ToString(), cmbpo1.SelectedItem.ToString());
                }



                MessageBox.Show("Successfully "+cmbteam.SelectedItem.ToString()+"  Player Position Added!!!");
                cmbteam.Text = "";

                cmbpo1.Text = "";
                cmbpo2.Text = "";
                cmbpo3.Text = "";
                cmbpo4.Text = "";
                cmbpo5.Text = "";
                cmbpo6.Text = "";
                cmbpo7.Text = "";
                cmbpo8.Text = "";
                cmbpo9.Text = ""; cmbpo11.Text = "";
                cmbpo10.Text = "";

            }
            catch
            {
                MessageBox.Show("Enter all the details");
            }
            //clear();
        }

        private void lblstart_Click(object sender, EventArgs e)
        {
            frmTransaction tr = new frmTransaction();
            tr.Show();
            this.Close();
        }

        private void p10_Click(object sender, EventArgs e)
        {

        }

        private void cmbcf1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbmf21_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSquad_Registration sq = new frmSquad_Registration();
            sq.Show();
        }

        private void btnsavepos_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbpo1.SelectedItem.ToString() != "")
                {
                    pos.insertPosition(clsGlobalValues.mid, clsGlobalValues.Tournament, cmbteam.SelectedItem.ToString(), chkp1.Text, comboBox1.SelectedItem.ToString(), cmbpo1.SelectedItem.ToString());
                }

                if (cmbpo2.SelectedItem.ToString() != "")
                {
                    pos.insertPosition(clsGlobalValues.mid, clsGlobalValues.Tournament, cmbteam.SelectedItem.ToString(), chkp2.Text, comboBox1.SelectedItem.ToString(), cmbpo1.SelectedItem.ToString());
                }

                if (cmbpo3.SelectedItem.ToString() != "")
                {
                    pos.insertPosition(clsGlobalValues.mid, clsGlobalValues.Tournament, cmbteam.SelectedItem.ToString(), chkp3.Text, comboBox1.SelectedItem.ToString(), cmbpo1.SelectedItem.ToString());
                }

                if (cmbpo4.SelectedItem.ToString() != "")
                {
                    pos.insertPosition(clsGlobalValues.mid, clsGlobalValues.Tournament, cmbteam.SelectedItem.ToString(), chkp4.Text, comboBox1.SelectedItem.ToString(), cmbpo1.SelectedItem.ToString());
                }

                if (cmbpo5.SelectedItem.ToString() != "")
                {
                    pos.insertPosition(clsGlobalValues.mid, clsGlobalValues.Tournament, cmbteam.SelectedItem.ToString(), chkp5.Text, comboBox1.SelectedItem.ToString(), cmbpo1.SelectedItem.ToString());
                }
                if (cmbpo6.SelectedItem.ToString() != "")
                {
                    pos.insertPosition(clsGlobalValues.mid, clsGlobalValues.Tournament, cmbteam.SelectedItem.ToString(), chkp6.Text, comboBox1.SelectedItem.ToString(), cmbpo1.SelectedItem.ToString());
                }

                if (cmbpo7.SelectedItem.ToString() != "")
                {
                    pos.insertPosition(clsGlobalValues.mid, clsGlobalValues.Tournament, cmbteam.SelectedItem.ToString(), chkp7.Text, comboBox1.SelectedItem.ToString(), cmbpo1.SelectedItem.ToString());
                }

                if (cmbpo8.SelectedItem.ToString() != "")
                {
                    pos.insertPosition(clsGlobalValues.mid, clsGlobalValues.Tournament, cmbteam.SelectedItem.ToString(), chkp8.Text, comboBox1.SelectedItem.ToString(), cmbpo1.SelectedItem.ToString());
                }

                if (cmbpo9.SelectedItem.ToString() != "")
                {
                    pos.insertPosition(clsGlobalValues.mid, clsGlobalValues.Tournament, cmbteam.SelectedItem.ToString(), chkp9.Text, comboBox1.SelectedItem.ToString(), cmbpo1.SelectedItem.ToString());
                }


                if (cmbpo10.SelectedItem.ToString() != "")
                {
                    pos.insertPosition(clsGlobalValues.mid, clsGlobalValues.Tournament, cmbteam.SelectedItem.ToString(), chkp10.Text, comboBox1.SelectedItem.ToString(), cmbpo1.SelectedItem.ToString());
                }

                if (cmbpo11.SelectedItem.ToString() != "")
                {
                    pos.insertPosition(clsGlobalValues.mid, clsGlobalValues.Tournament, cmbteam.SelectedItem.ToString(), chkp11.Text, comboBox1.SelectedItem.ToString(), cmbpo1.SelectedItem.ToString());
                }



                MessageBox.Show( cmbteam.SelectedItem.ToString() + "  Player Positions Added!!!");

                savedteam = cmbteam.Text;


                if (savedteam==cmbteam.Items[0].ToString())
                {
                   
                    cmbteam.Text = cmbteam.Items[1].ToString();
                    chkselectionA.Checked = true;
                    chkselectionA.Text = savedteam;
                }
               else if (savedteam == cmbteam.Items[1].ToString())
                {
                    cmbteam.Text = cmbteam.Items[0].ToString();
                    chkselectionB.Checked = true;
                    chkselectionB.Text = savedteam;

                }
                //cmbteam.Text = savedteam;
               // cmbteam.Text = "";

                //cmbpo1.Text = "";
                //cmbpo2.Text = "";
                //cmbpo3.Text = "";
                //cmbpo4.Text = "";
                //cmbpo5.Text = "";
                //cmbpo6.Text = "";
                //cmbpo7.Text = "";
                //cmbpo8.Text = "";
                //cmbpo9.Text = ""; cmbpo11.Text = "";
                //cmbpo10.Text = "";

            }
            catch
            {
                MessageBox.Show("Enter all the details");
            }
        }
    }
}
