using System;
using System.Collections;
using System.Windows.Forms;

namespace LineCounter.Logic
{
    public class ListViewColumnSorter : IComparer
    {
        private int _columnToSort;
        private SortOrder _orderOfSort;
        private IComparer _comparer;

        public int SortColumn
        {
            get { return _columnToSort; }
            set { _columnToSort = value; }
        }

        public SortOrder Order
        {
            get { return _orderOfSort; }
            set { _orderOfSort = value; }
        }

        public IComparer Comparer
        {
            get { return _comparer; }
            set
            {
                _comparer = value;
                if (_comparer != null)
                    return;
                _comparer = new CaseInsensitiveComparer();
            }
        }

        public ListViewColumnSorter()
        {
            _columnToSort = 0;
            _orderOfSort = SortOrder.None;
            _comparer = new CaseInsensitiveComparer();
        }

        public int Compare(object x, object y)
        {
            var itemX = (ListViewItem) x;
            var itemY = (ListViewItem) y;

            var textX = itemX.SubItems[_columnToSort].Text;
            var textY = itemY.SubItems[_columnToSort].Text;

            var comparison = _comparer.Compare(textX, textY);

            return _orderOfSort == SortOrder.Ascending
                ? -comparison
                : comparison;
        }
    }
}