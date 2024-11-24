using Log.Enum;
using System;
using System.IO;
using System.Text;

namespace Log
{
    public class Log
    {
        private static object lockObject = new object();
        private static string FileDirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
        private string FileName { get { return $"{DateTime.Now.ToString("yyyyMMdd")}.log"; } }
        public string DirPath { get { return FileDirPath; } }

        public Log() : this(FileDirPath)
        { }

        public Log(string path)
        {
            FileDirPath = path;
            Write(new MsgInfo(MsgType.System, "Start"));
        }

        ~Log()
        {
            Write(new MsgInfo(MsgType.System, "End"));
        }

        public void Write(MsgInfo msgInfo)
        {
            FileMode mode = GetFileMode();
            lock (lockObject)
            {
                Console.ForegroundColor = msgInfo.ConsoleColor;
                Console.WriteLine(msgInfo.Message);

                using (FileStream fs = new FileStream(Path.Combine(FileDirPath, FileName), mode))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.Default))
                    {
                        sw.WriteLine(msgInfo.Message);
                    }
                }
            }
        }

        /// <summary>
        /// 將訊息寫入Log
        /// </summary>
        /// <param name="msg">採用預設格式(Info)</param>
        public void Write(string msg)
        {
            FileMode mode = GetFileMode();
            lock (lockObject)
            {
                var msgInfo = new MsgInfo(MsgType.Info, msg);

                Console.ForegroundColor = msgInfo.ConsoleColor;
                Console.WriteLine(msgInfo.Message);

                using (FileStream fs = new FileStream(Path.Combine(FileDirPath, FileName), mode))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.Default))
                    {
                        sw.WriteLine(msgInfo.Message);
                    }
                }
            }
        }

        private FileMode GetFileMode()
        {
            if (Directory.Exists(FileDirPath))
            {
                return FileMode.Append;
            }
            else
            {
                Directory.CreateDirectory(FileDirPath);
                return FileMode.CreateNew;
            }
        }

    }

}
