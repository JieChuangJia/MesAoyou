using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MESInterface;
namespace AYUI
{
    public partial class Form1 : Form
    {
        private IMES mesInterface;
        AYWCFServer.WCFManager wcfManager = new AYWCFServer.WCFManager();
        public Form1(IMES mes)
        {
            InitializeComponent();
            this.mesInterface = mes;
            string restr = "";
            this.mesInterface.AddGroup("查询", ref restr);
            this.mesInterface.AddGroupItemArea("查询", "电芯查询", OnQueryBatteryEventhandler, ref restr);
            this.mesInterface.RegistStartAction(StartServ);
        }
        private void StartServ()
        {  
            Uri _baseAddress = new Uri("http://localhost/AYMESSvc");
            string restr ="";
            wcfManager.Start(_baseAddress, ref restr);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void OnQueryBatteryEventhandler(object sender,EventArgs e)
        {
            this.mesInterface.ShowTab(this);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
