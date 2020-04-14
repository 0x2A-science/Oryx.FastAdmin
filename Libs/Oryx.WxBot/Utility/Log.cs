﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Oryx.WxBot
{
    public class Log
    {
        private static string debugLog = "Logs\\debug\\";
        public static void WriteDebug(string content)
        {
            string dtDate = DateTime.Now.ToString("yyyyMMdd");
            string dtNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string logFileName = dtDate + ".log";
            string logContent = dtNow + Environment.NewLine + content + Environment.NewLine;
            if (!Directory.Exists(debugLog))
            {
                Directory.CreateDirectory(debugLog);
            }
            File.AppendAllText(debugLog + logFileName, logContent);
        }
    }
}
