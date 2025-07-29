using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LinkedList_MergeSort
{
    public partial class Form2 : Form
    {
        private Data data = new Data();
        private LinkedList<string> l;

        public Form2()
        {
            //Initializing data
            InitializeComponent();
            l = data.iList();
            DisplayUnsorted();
        }

        private void DisplayUnsorted()
        {

            // Displaying the raw list without any sorted data
            lstStory.Items.Clear();
            foreach (var item in l)
            {
                lstStory.Items.Add(item);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

            // Spliting the integer from the strings
            var sorted = l
                .OrderBy(s => int.Parse(s.Split(' ')[0]))
                .ToList();

            // Clearing the current list items
            lstStory.Items.Clear();

            // Incrementing the new list with sorted items
            foreach (var item in sorted)
            {
                lstStory.Items.Add(item + "\n");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            // Hiding this page to move to the next one.
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void lstScript_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
