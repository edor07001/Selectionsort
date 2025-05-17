using System.Diagnostics;

int size = 100000;
int[] numbers = new int[size];
Random rng = new Random();

for(int i = 0; i < size; i++)
{
    numbers[i] = rng.Next();
}

Stopwatch sw = Stopwatch.StartNew();

SelectionSort(numbers);

sw.Stop();

for(int i = 0; i < size; i++)
{
    Console.WriteLine(numbers[i]);
}

Console.WriteLine($"Tid för sortering: {sw.Elapsed}");

static void SelectionSort(int[] arr)
{
    int n = arr.Length;
    for (int i = 0; i < n - 1; i++)
    {
        int minIndex = i;
        for (int j = i + 1; j < n; j++)
        {
            if (arr[j] < arr[minIndex])
            {
                minIndex = j;
            }
        }

        int temp = arr[i];
        arr[i] = arr[minIndex];
        arr[minIndex] = temp;
    }
}