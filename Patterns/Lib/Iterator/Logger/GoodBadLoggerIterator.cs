using System;
using System.Collections;
using System.Collections.Generic;

namespace Patterns.Lib.Iterator.Logger
{
    public class GoodBadLoggerIterator: IEnumerator
    {
        private readonly List<string> _logs;
        private readonly List<string> _goodLogs;
        private readonly List<string> _badLogs;
        private readonly LogType _stepBy;
        private int _anyPosition;
        private int _goodPosition;
        private int _badPosition;

        public GoodBadLoggerIterator(List<string> logs, LogType stepBy)
        {
            _logs = logs;
            _goodLogs = new List<string>();
            _badLogs = new List<string>();
            _stepBy = stepBy;
            PrepareGoodBadLogs();
            _anyPosition = -1;
            _goodPosition = -1;
            _badPosition = -1;
        }

        private void PrepareGoodBadLogs()
        {
            foreach (var log in _logs)
            {
                if (log.Contains("<g>"))
                {
                    _goodLogs.Add(log);
                    continue;
                }
                _badLogs.Add(log);
            }
        }
        
        public bool MoveNext()
        {
            switch (_stepBy)
            {
                case LogType.Bad:
                    if (_badPosition + 1 >= _badLogs.Count) return false;
                    _badPosition += 1;
                    break;
                case LogType.Good:
                    if (_goodPosition + 1 >= _goodLogs.Count) return false;
                    _goodPosition += 1;
                    break;
                case LogType.Any:
                    if (_anyPosition + 1 >= _logs.Count) return false;
                    _anyPosition += 1;
                    break;
                default:
                    throw new Exception("Unsupported iteration type.");
            }

            return true;
        }

        public void Reset()
        {
            _anyPosition = 0;
            _goodPosition = 0;
            _badPosition = 0;
        }

        public object Current
        {
            get
            {
                switch (_stepBy)
                {
                    case LogType.Bad:
                        return _badLogs[_badPosition];
                    case LogType.Good:
                        return _goodLogs[_goodPosition];
                    case LogType.Any:
                        return _logs[_anyPosition];
                    default:
                        throw new Exception("Unsupported iteration type.");
                }
            }
        }
    }
}