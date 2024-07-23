namespace EightQueen
{
    public class EightQueensSolver
    {
        public void PermutationsHelper(int[] nums, int startIndex)
        {
            if (startIndex == nums.Length - 1)
            {
                PrintArray(nums);
            }
            else
            {
                for (int i = startIndex; i < nums.Length; i++)
                {
                    Swap(nums, startIndex, i);
                    PermutationsHelper(nums, startIndex + 1);
                    Swap(nums, startIndex, i); // 回溯
                }
            }
        }

        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        private void PrintArray(int[] array)
        {
            var n = array.Length;
            foreach (var element in array)
            {
                Console.WriteLine("Q".PadLeft(element + 1, '.').PadRight(n, '.'));
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public int[] CreateIntArray(int n)
        {
            var result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = i;
            }
            return result;
        }
    }
}
