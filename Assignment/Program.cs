namespace Assignment
{
    internal class Program
    {
        #region Count numbers greater than X
        //static void CountGreaterNumbers(int[] arr, int[] queries)
        //{
        //    foreach (int x in queries)
        //    {
        //        Console.WriteLine(arr.Count(n => n > x));
        //    }
        //}
        #endregion


        #region Check if an array is a palindrome
        //static string IsPalindrome(int[] arr)
        //{
        //    return arr.SequenceEqual(arr.Reverse()) ? "YES" : "NO";
        //}

        #endregion


        #region Reverse a queue using a stack
        //static Queue<int> ReverseQueue(Queue<int> queue)
        //{
        //    Stack<int> stack = new Stack<int>();
        //    while (queue.Count > 0)
        //        stack.Push(queue.Dequeue());
        //    while (stack.Count > 0)
        //        queue.Enqueue(stack.Pop());
        //    return queue;
        //}
        #endregion



        #region Check balanced parentheses
        //static string IsBalanced(string s)
        //{
        //    Stack<char> stack = new Stack<char>();
        //    foreach (char c in s)
        //    {
        //        if ("({[".Contains(c)) stack.Push(c);
        //        else if (stack.Count == 0 || "(){}[]".IndexOf(stack.Pop() + "" + c) == -1)
        //            return "Unbalanced";
        //    }
        //    return stack.Count == 0 ? "Balanced" : "Unbalanced";
        //}
        #endregion


        #region Remove duplicates from an array
        //static int[] RemoveDuplicates(int[] arr)
        //{
        //    return arr.Distinct().ToArray();
        //}
        #endregion


        #region Remove all odd numbers

        //static List<int> RemoveOddNumbers(List<int> list)
        //{
        //    return list.Where(n => n % 2 == 0).ToList();
        //}
        #endregion


        #region Generic queue implementation
        //class GenericQueue<T>
        //{
        //    private Queue<T> queue = new Queue<T>();
        //    public void Enqueue(T item) => queue.Enqueue(item);
        //    public T Dequeue() => queue.Dequeue();
        //}
        #endregion



        #region Search for an integer in a stack
        //static void SearchStack(Stack<int> stack, int target)
        //{
        //    int count = 0;
        //    foreach (int num in stack)
        //    {
        //        count++;
        //        if (num == target)
        //        {
        //            Console.WriteLine($"Target was found successfully and the count = {count}");
        //            return;
        //        }
        //    }
        //    Console.WriteLine("Target was not found");
        //}
        #endregion


        #region Find intersection of two arrays
        //static int[] FindIntersection(int[] arr1, int[] arr2)
        //{
        //    return arr1.GroupBy(n => n)
        //               .SelectMany(g => Enumerable.Repeat(g.Key, Math.Min(g.Count(), arr2.Count(n => n == g.Key))))
        //               .ToArray();
        //}
        #endregion



        #region Find contiguous sublist with target sum
        //static List<int> FindSublistWithSum(List<int> list, int target)
        //{
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        int sum = 0;
        //        for (int j = i; j < list.Count; j++)
        //        {
        //            sum += list[j];
        //            if (sum == target)
        //                return list.GetRange(i, j - i + 1);
        //        }
        //    }
        //    return new List<int>();
        //}
        #endregion


        #region Reverse first K elements of a queue
        //static Queue<int> ReverseFirstK(Queue<int> queue, int k)
        //{
        //    Stack<int> stack = new Stack<int>();
        //    for (int i = 0; i < k; i++)
        //        stack.Push(queue.Dequeue());
        //    while (stack.Count > 0)
        //        queue.Enqueue(stack.Pop());
        //    for (int i = 0; i < queue.Count - k; i++)
        //        queue.Enqueue(queue.Dequeue());
        //    return queue;
        //}
        #endregion
    }
}
