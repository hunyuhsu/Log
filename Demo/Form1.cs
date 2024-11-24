using Demo.Component;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Tool.Log;
using Tool.Log.Enum;

namespace Demo
{
    public partial class Form1 : Form
    {
        private Log Log;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_InitialLog_Click(object sender, EventArgs e)
        {
            Log = new Log();
        }

        private void btn_OpenLogDir_Click(object sender, EventArgs e)
        {
            string filename = Log.DirPath;
            System.Diagnostics.Process.Start("Explorer.exe", $"/e, {filename}");
        }

        private void btn_WriteMsg_Click(object sender, EventArgs e)
        {
            WriteLog(new MsgInfo(MsgType.Info, "Test Msg"), true);
            WriteLog(new MsgInfo(MsgType.Debug, "Test Msg"), true);
            WriteLog(new MsgInfo(MsgType.Error, "Test Msg"), true);
            WriteLog(new MsgInfo(MsgType.Fatal, "Test Msg"), true);
            WriteLog(new MsgInfo(MsgType.Warning, "Test Msg"), true);
        }

        private void btn_ClearMsg_Click(object sender, EventArgs e)
        {
            rtb_MsgInfo.Clear();
        }

        private void WriteLog(string msg, bool display)
        {
            Log.Write(msg);

            if (display)
            {
                this.Invoke(new Action(() =>
                {
                    rtb_MsgInfo.SelectionStart = rtb_MsgInfo.TextLength;
                    msg = Regex.Replace(msg, @"^[0-9]+\/[0-9]+\/+[0-9]+\s", ""); // 移除 年月日 顯示
                    rtb_MsgInfo.SelectionColor = ConsoleColor.DarkGray.GetColor();
                    rtb_MsgInfo.AppendText(msg + Environment.NewLine);
                    rtb_MsgInfo.ScrollToCaret();
                }));
            }
        }

        public void WriteLog(MsgInfo msgInfo, bool display)
        {
            Log.Write(msgInfo);

            if (display)
            {
                this.Invoke(new Action(() =>
                {
                    rtb_MsgInfo.SelectionStart = rtb_MsgInfo.TextLength;
                    msgInfo.Message = Regex.Replace(msgInfo.Message, @"^[0-9]+\/[0-9]+\/+[0-9]+\s", ""); // 移除 年月日 顯示                    
                    rtb_MsgInfo.SelectionColor = msgInfo.ConsoleColor.GetColor();
                    rtb_MsgInfo.AppendText(msgInfo.Message + Environment.NewLine);
                    rtb_MsgInfo.ScrollToCaret();

                }));
            }
        }

    }
}
