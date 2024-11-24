using System;

namespace Log.Enum
{
    [Flags]
    public enum MsgType
    {
        Info,    // DarkCyan            ==> 一般訊息 (info)   
        Debug,   // DarkGreen           ==> ex 的訊息
        Warning, // DarkYellow          ==> 可容許的錯誤，警告作用
        Error,   // DarkRed             ==> 不可容許的錯誤  
        Fatal,   // Background DarkRed  ==> 致命錯誤(目前沒有用到)
        System,  // 系統開始和結束
    }
}