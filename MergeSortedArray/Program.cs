using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int [] result = Solution.Merge(new int [] { 2,0}, 3, new int[] { 1 }, 3);

        foreach (int number in result)
        {
            Console.WriteLine(number);
        }
    }
}
public class Solution
{
    public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
    {
        for (int i = 0, j = 0; i < nums1.Length && j < nums2.Length; i++)
        {
            if (nums1[i] != 0)
            {
                continue;
            }
            else
            {
                nums1[i] = nums2[j];
                j++;
            }
        }

        int k, l;

        for (k = 1; k < nums1.Length; k++)
        {
            l = k;
            while ((l > 0) && (nums1[l] < nums1[l - 1]))
            {
                var holder = nums1[l];
                nums1[l] = nums1[l - 1];
                nums1[l - 1] = holder;

                l = l - 1;
            }
        }

        return nums1;
    }
}