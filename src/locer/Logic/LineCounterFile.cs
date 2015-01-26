using System;
using System.IO;

namespace LineCounter.Logic
{
    public class LineCounterFile
    {
        private string _filename;
        private int _lineCount;
        private int _minNonWhitespaceChars;

        public string Filename
        {
            get { return _filename; }
            set
            {
                _filename = value;
                _lineCount = -1;
            }
        }

        public int LineCount
        {
            get { return _lineCount; }
        }

        public int MinNonWhitespaceChars
        {
            get { return _minNonWhitespaceChars; }
            set { _minNonWhitespaceChars = value; }
        }

        public LineCounterFile(string filename)
        {
            _filename = filename;
            _lineCount = -1;
        }

        public void Count()
        {
            using (var reader = new StreamReader(_filename))
            {
                _lineCount = 0;
                for (var line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    if (_minNonWhitespaceChars == 0 || line.Trim().Length >= _minNonWhitespaceChars)
                        ++_lineCount;
                }
            }
        }
    }
}