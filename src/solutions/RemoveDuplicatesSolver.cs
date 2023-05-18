namespace solutions.easy;

public class RemoveDuplicatesSolver
{
    /// <summary>
    /// m O(1)
    /// c O(n)
    /// нет постоянной записи
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int RemoveDuplicates(int[] nums)
    {
        /*
         * 0 0 1 1 2 2 3 3 4 4 5
         * суть: мы бы добавляем в список очередной новый элемент.
         * 1) т.к. массив упорядочен по возрастанию, то nums[i]<=nums[i+1]. Соответственно, следующий новый элемент -- это когда текущий не равен следующему
         * 2) т.к. мы используем тот же массив, мы можем сказать что по 0 индексу содержится первый уникальный элемент
        int k = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] != nums[i + 1])
            {
                nums[++k] = nums[i + 1];
            }
        }
        return k + 1;
         */



        /* или, для оптимизации -- 0 элемент уже уникальный, то */
        
        int k = 1;
        for (int i = 0; i < nums.Length-1; i++)
        {
            if (nums[i] != nums[i+1])
            {
                nums[k++] = nums[i+1];
            }
        }
        return k;

        /*
        int k = 0;
        for (int i = 0;i < nums.Length - 1;k++)
        {
            int j = i + 1;
            while (j < nums.Length && nums[i] == nums[j]) j++;

            if (j == nums.Length)
            {
                break;
            }

            nums[k + 1] = nums[j];
            i = j;
        }
        return k+1;*/
    }
}