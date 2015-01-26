using System;
using System.Collections.Generic;
using System.IO;

namespace LineCounter.Logic
{
    internal sealed class FileFinder
    {
        private readonly List<string> _fileNames = new List<string>();

        public string this[int index]
        {
            get { return _fileNames[index]; }
        }

        public int Count
        {
            get { return _fileNames.Count; }
        }

        public void Clear()
        {
            _fileNames.Clear();
        }

        public void AddFiles(string directory, string searchPattern)
        {
            if (directory == null)
                throw new ArgumentNullException(@"directory");

            if (searchPattern == null)
                throw new ArgumentNullException(@"searchPattern");

            AddFiles(directory, searchPattern, false);
        }

        public void AddFiles(string directory, string searchPattern, bool includeSubfolders)
        {
            if (directory == null)
                throw new ArgumentNullException(@"directory");

            if (searchPattern == null)
                throw new ArgumentNullException(@"searchPattern");

            foreach (var pattern in searchPattern.Split(';'))
            {
                var patternPart = pattern.Trim();

                if (includeSubfolders)
                {
                    foreach (var subDirectory in Directory.GetDirectories(directory))
                        AddFiles(subDirectory, patternPart, true);
                }

                foreach (var file in Directory.GetFiles(directory, patternPart))
                    _fileNames.Add(file);
            }
        }
    }
}