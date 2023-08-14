void garbege(int[] arr, int size, int index)
{
    int largestIndex = index;
    int leftChild = 2 * index + 1;
    int rightChild = 2 * index + 2;

    if (leftChild < size && arr[leftChild] > arr[largestIndex])
    {
        largestIndex = leftChild;
    }

    if (rightChild < size && arr[rightChild] > arr[largestIndex])
    {
        largestIndex = rightChild;
    }

    if (largestIndex != index)
    {
        int bin = arr[index];
        arr[index] = arr[largestIndex];
        arr[largestIndex] = bin;

        garbege(arr, size, largestIndex);
    }
}

int[] SortArray(int[] array, int size)
{
    if (size <= 1)
        return array;

    for (int i = size / 2 - 1; i >= 0; i--)
    {
        garbege(array, size, i);
    }

    for (int i = size - 1; i >= 0; i--)
    {
        int trash = array[0];
        array[0] = array[i];
        array[i] = trash;

        garbege(array, i, 0);
    }

    return array;
}

void ArrSee(int[] arr)
{
    Console.Write("[");
    int i=0;
    while (i<arr.Length-1)
    {
        Console.Write($"{arr[i]}|");
        i++;
    }
    Console.Write(arr[i]);
    Console.Write("]");
}
int[] gi= {5,2,8,6,9,1,4};
ArrSee(SortArray(gi,gi.Length));