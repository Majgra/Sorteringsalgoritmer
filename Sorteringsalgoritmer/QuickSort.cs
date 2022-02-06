public class QuickSort
{
    public static void Sort(int [] lista)
    {
        Sort(lista, 0, lista.Length - 1);
    }
     public static void Sort(int [] lista, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(lista, left, right);

            if (pivot > 1)
            {
                Sort(lista, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                Sort(lista, pivot + 1, right);
            }
        }
    }
    public static int Partition(int[] lista, int left, int right)
    {
        int pivot =  lista[left];
        while (true)
        {
            while (lista[left] < pivot)
            {
                left++;
            }
            while (lista[right] > pivot)
            {
                right--;
            }
            if (left < right)
            {
                if (lista[left] == lista[right])
                {
                    return right;
                }

                int byt = lista[left];
                lista[left] = lista[right];
                lista[right] = byt;
            }
            else
            {
                return right;
            }
        }
    }
}