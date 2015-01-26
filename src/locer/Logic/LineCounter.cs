using System;
using System.Collections.Generic;

namespace LineCounter.Logic
{
    public class LineCounter
    {
        private readonly List<LineCounterFile> _fileInformations = new List<LineCounterFile>();

        private int _totalLineCount = -1;
        private int _minNonWhitespaceChars;

        public int MinNonWhitespaceChars
        {
            get { return _minNonWhitespaceChars; }
            set { _minNonWhitespaceChars = value; }
        }

        public int FileCount
        {
            get { return _fileInformations.Count; }
        }

        public LineCounterFile this[int index]
        {
            get { return _fileInformations[index]; }
        }

        public int TotalLineCount
        {
            get { return _totalLineCount; }
        }

        public void Add(string filename)
        {
            for (var i = 0; i < _fileInformations.Count; ++i)
            {
                if (string.Equals(_fileInformations[i].Filename, filename, StringComparison.OrdinalIgnoreCase))
                {
                    var message = string.Format("File {0} allready in list", filename);
                    throw new Exception(message);
                }
            }
            _fileInformations.Add(new LineCounterFile(filename)
            {
                MinNonWhitespaceChars = _minNonWhitespaceChars
            });
        }

        public void Remove(string filename)
        {
            for (var i = 0; i < _fileInformations.Count; ++i)
            {
                if (string.Equals(_fileInformations[i].Filename, filename, StringComparison.OrdinalIgnoreCase))
                {
                    _fileInformations.RemoveAt(i);
                    break;
                }
            }
        }

        public void Clear()
        {
            _fileInformations.Clear();
            _totalLineCount = -1;
        }

        public void Count()
        {
            _totalLineCount = 0;

            foreach (var fileInformation in _fileInformations)
            {
                fileInformation.Count();
                _totalLineCount += fileInformation.LineCount;
            }
        }
    }
}