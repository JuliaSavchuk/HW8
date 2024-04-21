namespace HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 5, 1, 9, 2, 6, 4, 7, 8 };
            Array arrayObject = new Array(array);

            arrayObject.Show();
            arrayObject.SortByParam(true);
            arrayObject.Show("After sorting");

            Console.WriteLine("\n=====Task 1=====");
            Console.WriteLine($"Number of elements less than 3: {arrayObject.Less(3)}");
            Console.WriteLine($"Number of elements greater than 3: {arrayObject.Greater(3)}");

            Console.WriteLine("\n=====Task 2=====");
            arrayObject.ShowEven();
            arrayObject.ShowOdd();

            Console.WriteLine("\n=====Task 3=====");
            Console.WriteLine($"Number of distinct elements: {arrayObject.CountDistinct()}");
            Console.WriteLine($"Number of elements equal to 2: {arrayObject.EqualToValue(2)}");

        }
    }
}