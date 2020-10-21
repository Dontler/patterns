using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Patterns.Lib.Iterator.Logger
{
    public class GoodBadLogger: IEnumerable
    {
        private List<string> _logs;
        private readonly string _defaultPath = "./good_bad_log.log";
        private const string GoodLogQualifier = "<g>";
        private const string BadLogQualifier = "<b>";

        private string DefaultPath => Path.GetFullPath(_defaultPath);
        public LogType SearchBy { get; set; }

        public GoodBadLogger()
        {
            SearchBy = LogType.Any;
        }

        public void LoadLogs()
        {
            _logs = new List<string>();
            if (!File.Exists(DefaultPath))
            {
                File.Create(DefaultPath).Close();
                return;
            }
            using (var sr = new StreamReader(DefaultPath))
            {
                while (!sr.EndOfStream)
                {
                    _logs.Add(sr.ReadLine());
                }
            }
        }

        public void WriteGoodLog(string message)
        {
            if (!AreLogsLoaded())
            {
                throw new Exception("Logs not loaded!");
            }
            
            var currentDateTime = DateTime.Now.ToString("g");
            var logText = $"{GoodLogQualifier}{currentDateTime}:: Хорошая запись: {message}\n";
            
            WriteLog(logText);
        }

        public void WriteBadLog(string message)
        {
            if (!AreLogsLoaded())
            {
                throw new Exception("Logs not loaded!");
            }
            
            var currentDateTime = DateTime.Now.ToString("g");
            var logText = $"{BadLogQualifier}{currentDateTime}:: Плохая запись: {message}\n";
            
            WriteLog(logText);
        }

        private void WriteLog(string message)
        {
            var messageBytes = System.Text.Encoding.UTF8.GetBytes(message);
            using (var fs = new FileStream(DefaultPath, FileMode.Append))
            {
                fs.Write(messageBytes, 0, messageBytes.Length);
            }
            
            _logs.Add(message);
        }

        private bool AreLogsLoaded()
        {
            return _logs != null;
        }

        public IEnumerator GetEnumerator()
        {
            return new GoodBadLoggerIterator(_logs, SearchBy);
        }
    }
}