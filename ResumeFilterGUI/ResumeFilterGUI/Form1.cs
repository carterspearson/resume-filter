using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ResumeFilterGUI
{
    public partial class Form1 : Form
    {
        List<string> requiredKeyWords = new List<string>();
        List<string> optionalKeyWords = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        #region keyword input UI

        private void reqKeywordAdd_Click(object sender, EventArgs e)
        {
            string input = reqKeywordInput.Text;
            StringFunctions.getKeywords(requiredKeyWords, input);
            reqKeywordHolder.Text = StringFunctions.getHolderText(requiredKeyWords);
            reqKeywordInput.Text = "";
        }

        private void reqKeywordClear_Click(object sender, EventArgs e)
        {
            reqKeywordHolder.Text = "";
            requiredKeyWords = new List<string>();

        }

        private void reqKeywordInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                reqKeywordAdd_Click(this, new EventArgs());
            }
        }

        private void reqKeywordUndo_Click(object sender, EventArgs e)
        {
            if (requiredKeyWords.Count() > 0)
                requiredKeyWords.RemoveAt(requiredKeyWords.Count() - 1);
            reqKeywordHolder.Text = StringFunctions.getHolderText(requiredKeyWords);
        }

        private void optKeywordAdd_Click(object sender, EventArgs e)
        {
            string input = optKeywordInput.Text;
            StringFunctions.getKeywords(optionalKeyWords, input);
            optKeywordHolder.Text = StringFunctions.getHolderText(optionalKeyWords);
            optKeywordInput.Text = "";
        }

        private void optKeywordClear_Click(object sender, EventArgs e)
        {
            optKeywordHolder.Text = "";
            optionalKeyWords = new List<string>();
        }

        private void optKeywordInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                optKeywordAdd_Click(this, new EventArgs());
            }
        }

        private void optKeywordUndo_Click(object sender, EventArgs e)
        {
            if (optionalKeyWords.Count() > 0)
                optionalKeyWords.RemoveAt(optionalKeyWords.Count() - 1);
            optKeywordHolder.Text = StringFunctions.getHolderText(optionalKeyWords);
        }

        #endregion

        private void filterButton_Click(object sender, EventArgs e)
        {
            List<string[]> resumeList = new List<string[]>();
            resumeHolder.Items.Clear();

            FolderFunctions.deleteFiles(Constants.APPROVEDFOLDER, Constants.REJECTEDFOLDER);

            string[] wordExtensionArray = {"*.doc", "*.pdf" };
            List<string> pdfs = (List<string>)FolderFunctions.GetFilesByExtensions(Constants.INPUTFOLDER, wordExtensionArray);

            foreach (string s in pdfs)
            {
                Resume currentPDF;
                if (s.Contains(".doc"))
                    currentPDF = new Resume(s, false);
                else
                    currentPDF = new Resume(s, true);
                currentPDF.ResumeContainsKeyWords(requiredKeyWords, optionalKeyWords);
                updateResumeHolder(currentPDF);
                FolderFunctions.SortPDF(currentPDF);
            }

            if (requiredKeyWords.Count() != 0 || optionalKeyWords.Count() != 0)
            {
                DataComparer dataComparer = new DataComparer(0, SortOrder.Descending);
                resumeHolder.ListViewItemSorter = dataComparer;
            }
        }

        private void updateResumeHolder(Resume currentPDF)
        {
            string status = "Approved";
            if (currentPDF.pass == false)
                status = "Rejected";

            string type = "PDF";
            if (currentPDF.PDF == false)
                type = "Word";

            string[] arr = new string[] {currentPDF.name, String.Format(@"{0}/{1}", currentPDF.keyWordsContained.Count(), 
                    currentPDF.keyWordsNotContained.Count() + currentPDF.keyWordsContained.Count()), status, type};

            if (requiredKeyWords.Count() == 0 && optionalKeyWords.Count() == 0)
                arr[1] = "";

            ListViewItem itm = new ListViewItem(arr);
            itm.Tag = currentPDF;

            if (currentPDF.pass == false)
                itm.BackColor = Color.Red;
            else if (currentPDF.keyWordsNotContained.Count() == 0)
                itm.BackColor = Color.Green;
            else
                itm.BackColor = Color.Orange;

            resumeHolder.Items.Add(itm);
        }

        private void resumeHolder_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = resumeHolder.Columns[e.ColumnIndex].Width;
        }

        private void resumeHolder_MouseClick(object sender, MouseEventArgs e)
        {
            int selected = resumeHolder.SelectedIndices[0];
            Resume current = (Resume)resumeHolder.Items[selected].Tag;

            string text = "Name: " + current.name;
            text += "\nKeywords Contained: \n";
            foreach (string s in current.keyWordsContained)
                text += "    -    " + s + "\n";
            text += "Keywords Not Contained: \n";
            foreach (string s in current.keyWordsNotContained)
                text += "    -    " + s + "\n";

            resumeInspect.Text = text;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (resumeHolder.Items.Count == 0 || resumeHolder.SelectedIndices.Count == 0)
                return;
            int selected = resumeHolder.SelectedIndices[0];

            foreach (int i in resumeHolder.SelectedIndices)
            {
                Resume current = (Resume)resumeHolder.Items[i].Tag;
                System.Diagnostics.Process.Start(current.path);
            }
        }

        private void resumeHolder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            openButton_Click(this, e);
        }

        private void approveButton_Click(object sender, EventArgs e)
        {
            foreach (int i in resumeHolder.SelectedIndices)
            {
                resumeHolder.Items[i].SubItems[2].Text = "Approved";
                Resume current = (Resume)resumeHolder.Items[i].Tag;
                if (current.pass == false)
                {
                    current.pass = true;
                    FolderFunctions.SortPDF(current);
                    FileInfo file = new FileInfo(Constants.REJECTEDFOLDER + @"\" + System.IO.Path.GetFileName(current.path));
                    file.Delete();
                }
            }
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            foreach (int i in resumeHolder.SelectedIndices)
            {
                resumeHolder.Items[i].SubItems[2].Text = "Rejected";
                Resume current = (Resume)resumeHolder.Items[i].Tag;
                if (current.pass == true)
                {
                    current.pass = false;
                    FolderFunctions.SortPDF(current);
                    FileInfo file = new FileInfo(Constants.APPROVEDFOLDER + @"\" + System.IO.Path.GetFileName(current.path));
                    file.Delete();
                }
            }
        }
    }
}
