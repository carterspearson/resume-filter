using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ResumeFilterGUI
{
    class DataComparer : System.Collections.IComparer
    {
        private int col;
        private SortOrder order;
        public DataComparer()
        {
            col = 0;
            order = SortOrder.Ascending;
        }

        public DataComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }

        public int Compare(object x, object y)
        {
            int returnVal = -1;
            returnVal = CompareValues(((ListViewItem)x).SubItems[1].Text, ((ListViewItem)y).SubItems[1].Text);

            // Determine whether the sort order is descending.
            if (order == SortOrder.Descending)
                // Invert the value returned by String.Compare.
                returnVal *= -1;

            return returnVal;
        }

        public int StringToInt(string string1)
        {
            int i = 0;
            string returnString = "";
            if (string1 == "")
                return 0;
            while (string1[i] != '/')
            {
                returnString += string1[i];
                i++;
            }
            return Int32.Parse(returnString);
        }

        public int CompareValues(String string1, String string2)
        {
            int int1 = StringToInt(string1);
            int int2 = StringToInt(string2);

            if (int1 > int2)
                return 1;
            else if (int1 < int2)
                return -1;
            else
                return 0;
        }
    }
}
