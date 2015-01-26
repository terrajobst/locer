using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using LineCounter.Logic;

namespace LineCounter
{
    internal sealed partial class MainForm : Form
    {
        private readonly ListViewColumnSorter _lvwColumnSorter = new ListViewColumnSorter();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Count()
        {
            var folderPath = folderTextBox.Text;
            var fileMask = fileMaskEdit.Text;

            if (!Directory.Exists(folderPath))
            {
                var message = string.Format("Folder \"{0}\" does not exist.", folderPath);
                MessageBox.Show(this, message, Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                folderTextBox.Focus();
            }
            else
            {
                if (fileMask == null || fileMask.Trim().Length == 0)
                {
                    var message = string.Format("Please specify a search pattern.", folderPath);
                    MessageBox.Show(this, message, Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    fileMaskEdit.Focus();
                }

                var fileFinder = new FileFinder();
                fileFinder.AddFiles(folderPath, fileMask, true);
                var lineCounter = new Logic.LineCounter();
                lineCounter.MinNonWhitespaceChars = Convert.ToInt32(minimalCharCountUpDown.Value);
                for (var index = 0; index < fileFinder.Count; ++index)
                    lineCounter.Add(fileFinder[index]);
                lineCounter.Count();
                totalLineCountTextBox.Text = string.Format("{0:N0}", lineCounter.TotalLineCount);
                filesListView.BeginUpdate();
                try
                {
                    filesListView.Items.Clear();
                    for (var index = 0; index < lineCounter.FileCount; ++index)
                    {
                        filesListView.Items.Add(new ListViewItem(new string[3]
                        {
                            Path.GetFileName(lineCounter[index].Filename),
                            lineCounter[index].LineCount.ToString(),
                            Path.GetDirectoryName(lineCounter[index].Filename)
                        })
                        {
                            Tag = lineCounter[index].LineCount
                        });
                    }
                }
                finally
                {
                    filesListView.EndUpdate();
                }
            }
        }

        private void LineCounterForm_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(folderTextBox.Text))
                return;
            Count();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            Count();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = folderTextBox.Text;
            if (folderBrowserDialog.ShowDialog(this) != DialogResult.OK)
                return;
            folderTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void LineCounterForm_Resize(object sender, EventArgs e)
        {
            filesListView.Columns[2].Width = -2;
        }

        private void filesListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == _lvwColumnSorter.SortColumn)
            {
                var sortOrder = _lvwColumnSorter.Order == SortOrder.Ascending
                    ? SortOrder.Descending
                    : SortOrder.Ascending;
                _lvwColumnSorter.Order = sortOrder;
            }
            else
            {
                _lvwColumnSorter.SortColumn = e.Column;
                _lvwColumnSorter.Order = SortOrder.Ascending;
            }
            var comparer = e.Column == 1
                ? new IntegerComparer()
                : null;
            _lvwColumnSorter.Comparer = comparer;
            filesListView.Sort();
        }

        private void filesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedLinesOfCode = filesListView.SelectedItems
                .Cast<ListViewItem>()
                .Select(i => i.Tag)
                .OfType<int>()
                .Sum();

            var text = string.Format("{0:N0} lines in selected {1} items", selectedLinesOfCode, filesListView.SelectedItems.Count);
            statusBar.Text = text;
        }
    }
}
