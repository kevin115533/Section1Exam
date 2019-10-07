using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 Author: Kevin Tran
 Class: ITD 1253
 Due Date: 10/7/2019
     
     */

namespace Section1Exam
{
    public partial class Teletype : Form
    {
        public Teletype()
        {
            InitializeComponent();
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "A";
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "B";
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "C";
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "D";
        }

        private void BtnE_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "E";
        }

        private void BtnF_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "D";
        }

        private void BtnG_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "G";
        }

        private void BtnH_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "H";
        }

        private void BtnI_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "I";
        }

        private void BtnJ_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "J";
        }

        private void BtnK_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "K";
        }

        private void BtnL_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "L";
        }

        private void BtnM_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "M";
        }

        private void BtnN_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "N";
        }

        private void BtnO_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "O";
        }

        private void BtnP_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "P";
        }

        private void BtnQ_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "Q";
        }

        private void BtnR_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "R";
        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "S";
        }

        private void BtnT_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "T";
        }

        private void BtnU_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "U";
        }

        private void BtnV_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "V";
        }

        private void BtnW_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "W";
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "X";
        }

        private void BtnY_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "Y";
        }

        private void BtnZ_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "Z";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + "9";
        }

        private void BtnSpace_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + " ";
        }

        private void BtnPeriod_Click(object sender, EventArgs e)
        {
            txtMessage.Text = txtMessage.Text + ".";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            lblLastSent.Text = txtMessage.Text;
            txtMessage.Text = "";
        }
    }
}
