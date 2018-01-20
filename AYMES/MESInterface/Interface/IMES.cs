using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MESInterface
{
    public interface IMES
    {
        void ShowTab(Form tabForm);
        void ShowMessage(string caption, string mes);
        bool AddGroup(string groupName, ref string reStr);
        bool AddGroupItemArea(string groupName, string itemName, EventHandler callBack, ref string reStr);
        void WriteLog(LogModel log);

        void RegistStartAction(Action startAction);
        void RegistStopAction(Action stopAction);
        void RegistExitAction(Action exitAction);
      
        void SetVersion(string version);
    }
}
