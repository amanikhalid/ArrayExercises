namespace ArrayExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Array Initialization & Output
            // Declaring an Array of 5 Int
            //int[] numbers = new int[5] {11, 12, 13, 14, 15};

         
            //Console.WriteLine("Array Numbers: ");
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            ////-----------------------------------------------
            ////2. Finding Maximum & Minimum in an Array
            //Console.WriteLine("Enter 10 Numbers: ");


            //-----------------------------------------------
            // 3. Count Even & Odd Numbers 
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
            
        
        }
    }

