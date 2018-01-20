using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using MESInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AYMES
{
    public partial class MainView : DevExpress.XtraEditors.XtraForm,IMES
    {
        private delegate void DelegateDispLog(LogModel log);//委托，显示日志
        private List<Action> startActionList=new List<Action>();
        private List<Action> stopActionList = new List<Action>();
        private List<Action> exitActionList=new List<Action>();
     
        public MainView()
        {
            InitializeComponent();
            
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            Console.SetOut(new TextBoxWriter(this.richTextBoxLog));
            InitTabbedMDI();
            LoadApp();
        }

        #region 实现IMES基础框架接口

        public void ShowTab(Form tabForm)
        {
            tabForm.MdiParent = this;
           
            tabForm.Show();
        }

        public bool AddGroup(string groupName, ref string reStr)
        {
            try
            {
                bool isContain = false;
                DevExpress.XtraNavBar.NavBarGroup currGroup = null;
                isContain = IsContainGroup(this.nbc_MainMenu, groupName, ref currGroup);
                if (isContain == true)
                {
                    reStr = "已存在此名称的group！";
                    return false;
                }
                DevExpress.XtraNavBar.NavBarGroup barGroup = new DevExpress.XtraNavBar.NavBarGroup();
                barGroup.Name = groupName;
                barGroup.Caption = groupName;
                this.nbc_MainMenu.Groups.Add(barGroup);
                reStr = "添加成功！";
                return true;
            }
            catch (System.Exception ex)
            {
                reStr = ex.Message;
                return false;
            }

        }

        public bool AddGroupItemArea(string groupName, string itemName, EventHandler callBack, ref string reStr)
        {
            try
            {
                bool isContain = false;
                DevExpress.XtraNavBar.NavBarGroup currGroup = null;
                isContain = IsContainGroup(nbc_MainMenu, groupName, ref currGroup);
                if (isContain == false)
                {
                    reStr = groupName + "不存在！";
                    return false;
                }

                DevExpress.XtraNavBar.NavBarItem baritem = new DevExpress.XtraNavBar.NavBarItem();
                baritem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(callBack);
                DevExpress.XtraNavBar.NavBarItemLink itemLink = new DevExpress.XtraNavBar.NavBarItemLink(baritem);
                itemLink.Item.Caption = itemName;
                itemLink.Item.Name = itemName;
                foreach (DevExpress.XtraNavBar.NavBarItemLink link in currGroup.ItemLinks)
                {
                    if (link.Item.Name == itemName)
                    {
                        reStr = "已存在此item！";
                        return false;
                    }
                }
                currGroup.ItemLinks.Add(itemLink);
                this.nbc_MainMenu.Groups.Add(currGroup);
                reStr = "添加成功！";
                return true;
            }
            catch (System.Exception ex)
            {
                reStr = ex.Message;
                return false;
            }
        }

        public void WriteLog(LogModel log)
        {
            if (this.richTextBoxLog.InvokeRequired)
            {
                DelegateDispLog delegateLog = new DelegateDispLog(WriteLog);
                this.Invoke(delegateLog, new object[] { log });
            }
            else
            {
                richTextBoxLog.AppendText(string.Format("[{0:yyyy-MM-dd HH:mm:ss.fff}]{1},{2}", log.LogTime, log.LogSource, log.LogContent) + Environment.NewLine);
                if (richTextBoxLog.Lines.Length > 600)
                {
                    string[] newlines = new string[600];
                    Array.Copy(richTextBoxLog.Lines, richTextBoxLog.Lines.Length - 600, newlines, 0, 600);
                    richTextBoxLog.Lines = newlines;
                    richTextBoxLog.Select(richTextBoxLog.Text.Length, 0);
                    richTextBoxLog.ScrollToCaret();
                }
               
            }
        }
        public void ShowMessage(string caption,string mes)
        {
            MessageBox.Show(mes, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void RegistStartAction(Action startAction)
        {
            if (startAction == null)
            {
                return;
            }
            this.startActionList.Add(startAction);
        }
        public void RegistStopAction(Action stopAction)
        {
            if(stopAction == null)
            {
                return;
            }
            this.stopActionList.Add(stopAction);
        }
        public void RegistExitAction(Action exitAction)
        {
            if (exitAction == null)
            {
                return;
            }
            this.exitActionList.Add(exitAction);
        }
   
        public void SetVersion(string version)
        {
            this.lc_Version.Text = version;
        }
        #endregion

        #region 私有方法
        private bool IsContainGroup(NavBarControl barctrl, string groupName, ref  DevExpress.XtraNavBar.NavBarGroup currGroup)
        {
            foreach (DevExpress.XtraNavBar.NavBarGroup group in this.nbc_MainMenu.Groups)
            {
                if (group == null)
                {
                    continue;
                }
                if (group.Name == groupName)
                {
                    currGroup = group;
                    return true;
                }
            }
            return false;
        }
        private void InitTabbedMDI()
        {
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            //Dark Side,Visual Studio 2013 Blue,Office 2007 Black,Office 2010 Silver,Office 2007 Blue,DevExpress Dark Style,DevExpress Style,Office 2016 Black
            this.defaultLookAndFeel1.LookAndFeel.SetSkinStyle("Dark Side");
            this.xtraTabbedMdiManager1.MdiParent = this;
           
           
        }
      
        private void OnFormCloseEventHandler(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Form f = (Form)sender;
                f.Visible = false;
            }
          
        }
        private void LoadApp()
        {
            AYUI.BatteryView battery = new AYUI.BatteryView(this);
            battery.FormClosing += OnFormCloseEventHandler;

            AYUI.PalletView pallet = new AYUI.PalletView(this);
            pallet.FormClosing += OnFormCloseEventHandler;

        }

   
        #endregion

       
        private void sb_Start_Click(object sender, EventArgs e)
        {
            this.sb_Start.Enabled = false;
            this.sb_Stop.Enabled = true;
            if(this.startActionList != null)
            {
                foreach(Action ac in this.startActionList)
                {
                    ac();
                }
                
            }
        }

        private void sb_Stop_Click(object sender, EventArgs e)
        {
            this.sb_Start.Enabled = true;
            this.sb_Stop.Enabled = false;
            if (this.stopActionList != null)
            {
              foreach(Action ac in this.stopActionList)
              {
                  ac();
              }
            }
        }

        private void sb_Exit_Click(object sender, EventArgs e)
        {
            if (this.exitActionList != null)
            {
               foreach(Action ac in this.exitActionList)
               {
                   ac();
               }
            }
        }

        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBoxLog.Clear();
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("您确定要退出系统么？", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

       

    }
}
