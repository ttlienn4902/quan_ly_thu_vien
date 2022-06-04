using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace quan_ly_thu_vien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Functions.Connect();
        }     
       
	 
        private void mnuNXB_Click(object sender, EventArgs e)
        {
            frmNXB f = new frmNXB();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();

        }

        private void mnuThuthu_Click(object sender, EventArgs e)
        {
            Thủ_Thư f = new Thủ_Thư();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();

        }
    }


    }

