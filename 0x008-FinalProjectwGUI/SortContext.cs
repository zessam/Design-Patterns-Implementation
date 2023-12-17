public class SortContext
{
    private ISortStrategy _sortStrategy;

    // Constructor to set the initial strategy
    public SortContext(ISortStrategy sortStrategy)
    {
        _sortStrategy = sortStrategy;
    }

    // Method to change the strategy at runtime
    public void SetSortStrategy(ISortStrategy sortStrategy)
    {
        _sortStrategy = sortStrategy;
    }

    // Method that uses the current strategy to perform sorting
    public void SortArray(int[] array)
    {
        _sortStrategy.Sort(array);
    }
}