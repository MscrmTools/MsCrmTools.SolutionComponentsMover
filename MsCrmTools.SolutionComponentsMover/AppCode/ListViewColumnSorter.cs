using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsCrmTools.SolutionComponentsMover.AppCode
{

    public class ListViewColumnSorter : IComparer
    {
        public int SortColumn { set; get; }
        public SortOrder Order { set; get; }


        public ListViewColumnSorter()
        {
            SortColumn = 0;
            Order = SortOrder.None;
        }

        public int Compare(object x, object y)
        {
            int returnVal;

            // Check if date value
            if (DateTime.TryParse(((ListViewItem)x).SubItems[SortColumn].Text, out var xDate)
                && DateTime.TryParse(((ListViewItem)y).SubItems[SortColumn].Text, out var yDate))
            {
                returnVal = DateTime.Compare(xDate, yDate);
            }
            else
            {
                // Compare the two items as a string
                returnVal = String.CompareOrdinal(((ListViewItem)x).SubItems[SortColumn].Text,
                    ((ListViewItem)y).SubItems[SortColumn].Text);
            }

            if (Order == SortOrder.Descending)
                // Invert the value returned by String.Compare
                returnVal *= -1;
            return returnVal;
        }
    }
}
