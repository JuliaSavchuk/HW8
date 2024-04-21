namespace HW8
{
    
    public class Array : IOutput, IMath, ISort, ICalc, IOutput2, ICalc2
    {
        public int[] elements;

        public Array(int[] array)
        {
            elements = array;
        }

        public void Show()
        {
            Console.WriteLine("\nElements of the array:");
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write(elements[i] + " ");
            }
        }
        public void Show(string info)
        {
            Console.WriteLine($"\nElements of the array: {info}");
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write(elements[i] + " ");
            }
        }

        public int Max()
        {
            int max = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }
            return max;
        }
        public int Min()
        {
            int min = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] < min)
                {
                    min = elements[i];
                }
            }
            return min;
        }
        public float Avg()
        {
            int sum = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                sum += elements[i];
            }
            return (float)sum / elements.Length;
        }
        public bool Search(int valueToSearch)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }
        public void SortAsc()
        {
            for (int i = 0; i < elements.Length - 1; i++)
            {
                for (int j = 0; j < elements.Length - 1 - i; j++)
                {
                    if (elements[j] > elements[j + 1])
                    {
                        int temp = elements[j];
                        elements[j] = elements[j + 1];
                        elements[j + 1] = temp;
                    }
                }
            }
        }
        public void SortDesc()
        {
            for (int i = 0; i < elements.Length - 1; i++)
            {
                for (int j = 0; j < elements.Length - 1 - i; j++)
                {
                    if (elements[j] < elements[j + 1])
                    {
                        int temp = elements[j];
                        elements[j] = elements[j + 1];
                        elements[j + 1] = temp;
                    }
                }
            }
        }
        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }

        //Task1
        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (var element in elements)
            {
                if (element < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (var element in elements)
            {
                if (element > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        //Task2
        public void ShowEven()
        {
            Console.WriteLine("Even elements:");
            foreach (var element in elements)
            {
                if (element % 2 == 0)
                {
                    Console.Write(element + " ");
                }
            }
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            Console.WriteLine("Odd elements:");
            foreach (var element in elements)
            {
                if (element % 2 != 0)
                {
                    Console.Write(element + " ");
                }
            }
            Console.WriteLine();
        }

        //Task3
        public int CountDistinct()
        {
            return elements.Distinct().Count();
        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            foreach (var element in elements)
            {
                if (element == valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
