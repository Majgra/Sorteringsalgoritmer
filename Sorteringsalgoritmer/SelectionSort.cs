public class SelectionSort
{
    public static void Sort(int [] lista)
    {
        for (int i = 0; i < lista.Length - 1; i++)
        {
            int minstapositionen = i;
            for (int j = i + 1; j < lista.Length; j++)
            {
                if (lista[j] < lista [minstapositionen])
                {
                    minstapositionen = j;
                }
            }
            
            int byt = lista[minstapositionen];
            lista[minstapositionen] = lista[i];
            lista[i] = byt;
        }
    }
}