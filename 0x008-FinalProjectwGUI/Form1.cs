using System;
using System.Windows.Forms;

namespace DesignPatternProject
{
    public partial class Form1 : Form
    {
        private SortContext sortContext;
        private int[] arrayToSort = { 5, 2, 7, 1, 8, 3 };

        public Form1()
        {
            InitializeComponent();

            // Create instances of sorting strategies
            var bubbleSort = new BubbleSort();
            var quickSort = new QuickSort();
            var mergeSort = new MergeSort();

            // Create a context with the initial strategy (e.g., Bubble Sort)
            sortContext = new SortContext(bubbleSort);

            // Display the original array
            DisplayArrayInfo("Original Array:", arrayToSort);
        }

        private void btnBubbleSort_Click(object? sender, EventArgs e)
        {
            // Set Bubble Sort strategy
            sortContext.SetSortStrategy(new BubbleSort());

            // Perform sorting using the current strategy
            sortContext.SortArray(arrayToSort);

            // Display the sorted array
            DisplayArrayInfo("Switch to Bubble Sort, Sorted Array:", arrayToSort);
        }

        private void btnMergeSort_Click(object? sender, EventArgs e)
        {
            // Set Merge Sort strategy
            sortContext.SetSortStrategy(new MergeSort());

            // Perform sorting using the current strategy
            sortContext.SortArray(arrayToSort);

            // Display the sorted array
            DisplayArrayInfo("Switch to Merge Sort, Sorted Array:", arrayToSort);
        }

        private void btnQuickSort_Click(object? sender, EventArgs e)
        {
            // Set Quick Sort strategy
            sortContext.SetSortStrategy(new QuickSort());

            // Perform sorting using the current strategy
            sortContext.SortArray(arrayToSort);

            // Display the sorted array
            DisplayArrayInfo("Switch to Quick Sort, Sorted Array:", arrayToSort);
        }

        private void btnReset_Click(object? sender, EventArgs e)
        {
            // Reset the array to its original state
            arrayToSort = new int[] { 5, 2, 7, 1, 8, 3 };

            // Display the original array
            DisplayArrayInfo("Original Array:", arrayToSort);
        }

        private void DisplayArrayInfo(string labelText, int[] array)
        {
            // Display array information in the GUI
            lblArrayInfo.Text = labelText;

            // Display array elements in the ListBox
            listBoxSortedArray.Items.Clear();
            foreach (var element in array)
            {
                listBoxSortedArray.Items.Add(element);
            }

            // Print the sorted array text
            Console.WriteLine($"{labelText} {string.Join(", ", array)}");
        }
    }
}
