public class QuickSort : ISortStrategy
{
    public void Sort(int[] array)
    {
        Console.WriteLine("Sorting array using Quick Sort");
        QuickSortRecursive(array, 0, array.Length - 1);
    }

    // Ahmed Helmy :)
    private void QuickSortRecursive(int[] array, int low, int high)
    {
        if (low < high)
        {
            int partitionIndex = Partition(array, low, high);

            QuickSortRecursive(array, low, partitionIndex - 1);
            QuickSortRecursive(array, partitionIndex + 1, high);
        }
    }

    private int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                // Swap array[i] and array[j]
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        // Swap array[i+1] and array[high] (pivot)
        int tempPivot = array[i + 1];
        array[i + 1] = array[high];
        array[high] = tempPivot;

        return i + 1;
    }
}
