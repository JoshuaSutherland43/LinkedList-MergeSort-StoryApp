using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LinkedList_MergeSort
{
    public partial class Form1 : Form
    {
        private List<string> sortedList;
        private int curInd = 0;

        public Form1()
        {
            // Initializing components

            InitializeComponent();
            LoadSortedStory();
            DisplayCurrent();
        }

        private void LoadSortedStory()
        {
            // Obtaining the List and spliting the int from the string.
            Data data = new Data();
            LinkedList<string> x = data.iList();

            // Sorting the list and displaying from 1 -> 12
            sortedList = x
                .OrderBy(s => int.Parse(s.Split(' ')[0]))
                .ToList();
        }

        private void DisplayCurrent()
        {

            // Displaying the current item in the sorted List
            if (sortedList != null && sortedList.Count > 0)
            {
                lblOut.Text = sortedList[curInd];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Moving to the next node
            if (curInd < sortedList.Count - 1)
            {
                curInd++;
                DisplayCurrent();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            // Moving to the previous node
            if (curInd > 0)
            {
                curInd--;
                DisplayCurrent();
            }
        }

        private void lblOut_Click(object sender, EventArgs e)
        {

        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            // Changing pages
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
