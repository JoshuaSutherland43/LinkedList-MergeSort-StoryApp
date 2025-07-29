using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace LinkedList_MergeSort
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            Data data = new Data();
            LinkedList<string> longList = data.iList();


            int[] arr = longList
                .Select(s => int.Parse(s.Split(' ')[0])) 
                .ToArray();

            // Merge sort
            MergeSort.mergeSort(arr, 0, arr.Length - 1);

            // Sorted results
            Console.WriteLine("Sorted story indexes:");
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
