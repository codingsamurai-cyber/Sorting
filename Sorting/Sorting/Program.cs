Sort sort = new Sort();

int[] arr = { 2, 4, 1, 8, 3, 9, 0, 45, 43, 1 };

sort.InsSort(arr);
foreach (var item in arr)
{
    Console.Write(item + " ");
}

class Sort
{
    public int[] SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int min_index = i;
            for (int p = i + 1; p < arr.Length; p++)
            {
                if (arr[p] < arr[min_index])
                {
                    min_index = p;
                }
            }
            int temp = arr[i];
            arr[i] = arr[min_index];
            arr[min_index] = temp;
        }

        return arr;
    }

    public int[] InsertionSort(int[] arr)
    {
        int n = arr.Length, key, p;
        for (int i = 1; i < n; i++)
        {
            key = arr[i];
            p = i - 1;
            while (p >= 0 && arr[p] > key)
            {
                arr[p + 1] = arr[p];
                p -= 1;
            }
            arr[p + 1] = key;
        }
        return arr;
    }

    public int[] InsSort(int[] arr)
    {
        int j, temp;
        for (int i = 1; i < arr.Length; i++)
        {
            j = i;
            while (arr[j] < arr[j - 1])
            {
                temp = arr[j - 1];
                arr[j - 1] = arr[j];
                arr[j] = temp;
                if (j > 1)
                {
                    j--;
                }
                else
                {
                    break;
                }
            }
        }
        return arr;
    }
}