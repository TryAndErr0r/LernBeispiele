using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispieleQuicksort
{
    public static class Quicksort
    {
		//https://www.programmingalgorithms.com/algorithm/quick-sort-recursive/
		public static void QuickSortRecursive(ref int[] data, int left, int right)
		{
			if (left < right)
			{
				int q = Partition(ref data, left, right);
				QuickSortRecursive(ref data, left, q - 1);
				QuickSortRecursive(ref data, q + 1, right);
			}
		}

		private static int Partition(ref int[] data, int left, int right)
		{
			int pivot = data[right];
			int temp;
			int i = left;

			for (int j = left; j < right; ++j)
			{
				if (data[j] <= pivot)
				{
					temp = data[j];
					data[j] = data[i];
					data[i] = temp;
					i++;
				}
			}

			data[right] = data[i];
			data[i] = pivot;

			return i;
		}
	}
}
