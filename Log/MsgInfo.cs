using Log.Enum;
using System;

namespace Log
{
    public class MsgInfo
    {
        public string Message { get; set; }
        public MsgType MsgType { get; private set; }
        public ConsoleColor ConsoleColor { get; private set; }

        public MsgInfo(MsgType msgType, string msg)
        {
            MsgType = msgType;
            Message = $"{DateTime.Now,10} , {msgType,7} , {msg}";
            switch (msgType)
            {
                case MsgType.Info:
                    ConsoleColor = ConsoleColor.DarkGray;
                    break;
                case MsgType.Debug:
                    ConsoleColor = ConsoleColor.DarkMagenta;
                    break;
                case MsgType.Warning:
                    ConsoleColor = ConsoleColor.DarkYellow;
                    break;
                case MsgType.Error:
                    ConsoleColor = ConsoleColor.Red;
                    break;
                case MsgType.Fatal:
                    ConsoleColor = ConsoleColor.DarkRed;
                    break;
                case MsgType.System:
                    ConsoleColor = ConsoleColor.Green;
                    if (msg.ToUpper() == "START")
                        Message = $"---------- {DateTime.Now,10}    {msg} ----------";
                    else if (msg.ToUpper() == "END")
                        Message = $"---------- {DateTime.Now,10}    {msg} ----------\r\n";
                    break;
            }
        }
    }

}

