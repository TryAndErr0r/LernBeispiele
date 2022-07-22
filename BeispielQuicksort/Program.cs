// See https://aka.ms/new-console-template for more information
using BeispieleQuicksort;

Console.WriteLine("Hello, World!");

int[] unsortiertesArray = new int[10];

Random rand = new Random();

for(int i = 0; i < unsortiertesArray.Length; i++)
{
    unsortiertesArray[i] = rand.Next(100);
}

Console.WriteLine("Unsortiert: " + unsortiertesArray.Select(x => x.ToString()).Aggregate((a, b) => a + ", " + b));

Quicksort.QuickSortRecursive(ref unsortiertesArray, 0, unsortiertesArray.Length - 1);

Console.WriteLine("Sortiert: " + unsortiertesArray.Select(x=> x.ToString()).Aggregate((a,b) => a + ", " + b));

Console.ReadKey();