public class MergeSort
{   
    public static void Sort(int [] lista)
    {
        int [] arbetskopia = (int[])lista.Clone();

        SplitMerge(arbetskopia, 0, lista.Length, lista);
    }

    public static void SplitMerge(int [] left, int begin, int end, int [] right)
    {
        if (end - begin <= 1)
            return;
        
        int middle = (end + begin) / 2;
        SplitMerge(right, begin, middle, left);
        SplitMerge(right, middle, end, left);

        Merge(left, begin, middle, end, right);

    }
    public static void Merge(int [] right, int begin, int middle, int end, int [] left)
    {
        int i = begin;
        int j = middle;

        for (int k = begin; k < end; k++)
        {
            if (i < middle && (j >= end || right[i] <= right[j]))
            {
                left[k] = right[i];
                i++;
            } 
            else
            {
                left[k] = right[j];
                j++;
            }
        }
    }
}