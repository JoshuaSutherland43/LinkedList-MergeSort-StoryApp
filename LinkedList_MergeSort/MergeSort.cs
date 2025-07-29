using System;

namespace LinkedList_MergeSort
{
    public class MergeSort
    {
        // Merge 2 sub arrays
        static void merge(int[] arr, int l, int m, int r)
        {

            // Find the size of the 2 sub arrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;


            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];

            
            // Copy data to temp Arrays
            for (int i = 0; i < n1; i++)
                L[i] = arr[l + i];

            for (int j = 0; j < n2; j++)
                R[j] = arr[m + 1 + j];


            
            // Merging temp arrays
            int iIndex = 0, jIndex = 0, k = l; // Initial indexes of first and second sub arrays

            while (iIndex < n1 && jIndex < n2) 
            {
                if (L[iIndex] <= R[jIndex])
                    arr[k++] = L[iIndex++];
                else
                    arr[k++] = R[jIndex++];
            }


            // Copy remaining elements of L[]
            while (iIndex < n1)
                arr[k++] = L[iIndex++];


            // Copy remaining elements of R[]
            while (jIndex < n2)
                arr[k++] = R[jIndex++];
        }



        // Main function that sorts arr[l..r] using merge()
        public static void mergeSort(int[] arr, int l, int r)
        {

            if (l < r)
            {
                int m = l + (r - l) / 2; // Finding the middle

                // Sort first and second halves
                mergeSort(arr, l, m);
                mergeSort(arr, m + 1, r);

                // Merge the second halves
                merge(arr, l, m, r);
            }
        }
    }
}
