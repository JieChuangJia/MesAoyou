using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AYWCFClient;

namespace TestWcf
{
    public partial class Form1 : Form
    {
        AYWCFClient.AYServClient mesServ = new AYServClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int setp =0;
            string restr="";
           if( mesServ.GetStep(out setp, "123", ref restr)==true)
           {
               MessageBox.Show("成功");
           }
           else

           {
               MessageBox.Show("失败");
           }
        }
    }
}
