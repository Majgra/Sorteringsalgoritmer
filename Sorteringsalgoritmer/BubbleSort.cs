public class BubbleSort
{
    public static void Sort(int [] lista)
    {
        for (int i = 0; i < lista.Length - 1; i++)
        {
            for (int j = 0; j < lista.Length - i -1; j++)
            {
                if (lista[j] > lista [j+1])
                {
                    int byt = lista[j];
                    lista [j] = lista[j + 1];
                    lista[j + 1] = byt;
                }
            }
        }
    }
}