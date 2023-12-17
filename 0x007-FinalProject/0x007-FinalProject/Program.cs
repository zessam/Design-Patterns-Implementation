class Program
{
    static void Main()
    {
        // Create instances of sorting strategies
        var bubbleSort = new BubbleSort();
        var quickSort = new QuickSort();
        var mergeSort = new MergeSort();

        // Create a context with the initial strategy (e.g., Bubble Sort)
        var context = new SortContext(bubbleSort);

        // Perform sorting using the current strategy
        int[] arrayToSort = { 5, 2, 7, 1, 8, 3 };
        Console.WriteLine("Original Array:");
        Console.WriteLine(string.Join(" ", arrayToSort));
        
        
        context.SortArray(arrayToSort);
        PrintSortedArray(arrayToSort);

        // Change the strategy at runtime (e.g., switch to Quick Sort)
        context.SetSortStrategy(quickSort);
        context.SortArray(arrayToSort);
        PrintSortedArray(arrayToSort);

        // Change the strategy again (e.g., switch to Merge Sort)
        context.SetSortStrategy(mergeSort);
        context.SortArray(arrayToSort);
        PrintSortedArray(arrayToSort);
    }

    static void PrintSortedArray(int[] array)
    {
        Console.WriteLine("Sorted Array:");
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}