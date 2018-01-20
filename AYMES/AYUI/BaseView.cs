using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AYUI
{
    public partial class BaseView : DevExpress.XtraEditors.XtraForm
    {

        public BaseView()
        {
            InitializeComponent();
        }
       
        private void BaseView_Load(object sender, EventArgs e)
        {
            //AddPresener();
        }

        #region IBaseView方法实现
        public void ShowMessage(string mess, string title)
        {
            MessageBox.Show(mess, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public int AskMessage(string strCont)
        {
            DialogResult result = MessageBox.Show(strCont, "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }
        #endregion

    }
}