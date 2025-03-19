namespace ArrayExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Array Initialization & Output
            static void ArrayIntOutput()
            {
                //Declaring an Array of 5 Int
                int[] numbers = new int[5] { 11, 12, 13, 14, 15 };


                Console.WriteLine("Array Numbers: ");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            //-----------------------------------------------
            //2. Finding Maximum & Minimum in an Array
            static void FindMaxMin()
            {
                int[] numbers = new int[10];
                Console.WriteLine("Enter 10 Numbers: ");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine($"Number  {i+1} :  ");
                    numbers[i]= int.Parse(Console.ReadLine());
                }

                int maximum = numbers[0];
                int minimum = numbers[0];

                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] > maximum)
                        maximum = numbers[i];

                    if (numbers[i] < minimum)
                        minimum = numbers[i];
                }
                Console.WriteLine($"Maximum Value is {maximum}");
                Console.WriteLine($"Minimum Value is {minimum}");
            }


            //-----------------------------------------------
            // 3. Count Even & Odd Numbers 
            static void CountEvenOdd()
            {
                Console.WriteLine("Enter number of Element");
                int N = int.Parse(Console.ReadLine());
                int[] nums = new int[N];
                Console.WriteLine($"Enter {N} numbers :");
                int EvenNumbersCount = 0, OddNumbersCount = 0;
                for (int i = 0; i<N; i++)
                {
                    nums[i]= int.Parse(Console.ReadLine());
                }

                for (int i = 0; i<N; i++)
                {
                    if (nums[i] % 2==0)
                    {
                        EvenNumbersCount =EvenNumbersCount + 1;
                    }


                    else
                    {
                        OddNumbersCount=OddNumbersCount +1;
                    }


                }
                Console.WriteLine($"total Even numbers is {EvenNumbersCount}");
                Console.WriteLine($"total Odd numbers is {OddNumbersCount}");
            }

            //----------------------------------------
            //4. Reverse an Array
            static void ReverseArray()
            {
                Console.WriteLine(" Enter a Number of Elements");
                int e = int.Parse(Console.ReadLine());
                int[] numrs = new int[e];
                Console.WriteLine($"Enter {e} numbers");

                for (int i = 0; i<e; i++)
                {
                    Console.WriteLine($"Number {i+1}");
                    numrs[i]=int.Parse(Console.ReadLine());
                }
                Array.Reverse(numrs);
                Console.WriteLine("Reversed Array : ");

                foreach (int number in numrs)
                {
                    Console.WriteLine(number + " , ");
                }
            }
         
            //----------------------------------------
            // 6. Search for a Number in an Array
            static void SearchNumber()
            {
                Console.Write("Enter the number of elements: ");
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];

                Console.WriteLine("Enter elements:");
                for (int i = 0; i < n; i++)
                    arr[i] = int.Parse(Console.ReadLine());

                Console.Write("Enter number to search: ");
                int search = int.Parse(Console.ReadLine());

                int index = -1;
                int[] indexes = new int[arr.Length];

                for (int i = 0; i<arr.Length; i++)
                {

                    if (arr[i] == search)
                    {
                        
                        index = i;
                        break;
                    }
                   
                }

                if (index != -1)
                    Console.WriteLine(index);
                else
                    Console.WriteLine("not found");

                Console.WriteLine(index == -1 ? "Number not found." : $"Number found at index {index}");
            }
            //-----------------------------------------------

            // 7. Sorting an Array (Ascending Order)
            static void SortArray()
            {
                Console.Write("Enter the number of elements: ");
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];

                Console.WriteLine("Enter elements:");
                for (int i = 0; i < n; i++)
                    arr[i] = int.Parse(Console.ReadLine());

                Array.Sort(arr);
                Console.WriteLine("Sorted Array: " + string.Join(" ", arr));
            }
            //-----------------------------------------------

            // 8. Merging Two Arrays
            static void MergeArrays()
            {
                Console.Write("Enter the size of the arrays: ");
                int n = int.Parse(Console.ReadLine());
                int[] arr1 = new int[n], arr2 = new int[n], merged = new int[2 * n];

                Console.WriteLine("Enter first array:");
                for (int i = 0; i < n; i++) arr1[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second array:");
                for (int i = 0; i < n; i++) arr2[i] = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                    merged[i] = arr1[i];




                for (int i = 0; i < n; i++)
                    merged[n + i] = arr2[i];

                Console.WriteLine("Merged Array:");
                for (int i = 0; i < 2 * n; i++)
                    Console.Write(merged[i] + " ");
                Console.WriteLine();
            }
            //-------------------------------------------------- 

            // 9. Remove Duplicates from an Array
            static void RemoveDuplicates()
            {
                Console.Write("Enter the number of elements: ");
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];

                Console.WriteLine("Enter elements:");
                for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Array without duplicates:");
                for (int i = 0; i < n; i++)
                {
                    bool isDuplicate = false;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            isDuplicate = true;
                            break;
                        }
                    }
                    if (!isDuplicate) Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }
            //------------------------------------------

            // 10. Find Second Largest Number
            static void FindSecondLargest()
            {
                Console.Write("Enter the number of elements: ");
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];

                Console.WriteLine("Enter elements:");
                for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());

                int largest = int.MinValue, secondLargest = int.MinValue;

                for (int i = 0; i < n; i++)
                {
                    if (arr[i] > largest)
                    {
                        secondLargest = largest;
                        largest = arr[i];
                    }
                    else if (arr[i] > secondLargest && arr[i] != largest)
                        secondLargest = arr[i];
                }
                Console.WriteLine($"Second Largest: {secondLargest}");




            }
        }


    }
}   

