namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] array = new int[5];

            int[] numbers2 = [5, 2, 9, 1, 5, 6,6,6];
            Console.WriteLine("Sorted array: " + string.Join(", ", array));
            int[] numbers = [5, 2, 9, 7, 5, 6];
            int[] numbers3 = [4, 2, 4, 3, 3,];
            // int[] numbers = new int[] { 5, 2, 9, 1, 5, 6 };
            //BubbleSort(numbers);
            SelectionSort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            int more = 0;

            more = CountNonUnique(numbers2);
            Console.WriteLine("Numer of repeated numbers: " + more);
            // string.Join is for print horizontally an array
            Console.WriteLine("Sorted array: " + string.Join(", ", numbers));
            int mysum = NumJewelsInStones("aA", "aAAbbbb");
            Console.WriteLine("jewels : " + mysum);

            int less = SingleNumber(numbers3);
            Console.WriteLine("number only 1 time is : " + less);
            int[] indices = TwoSum(numbers, 9);
            Console.WriteLine(string.Join(",", indices));



        }

        static void BubbleSort(int[] nums)
        {
            int n = nums.Length;

            //last iteration is n-1 element since if it goes to n last element then j+1 will be out of index
            for (int i = 0;i <n-1; i++) 
            {
               
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        // temp will have greater one
                        int temp = nums[j];

                        //nums[j] will have smaller one
                        nums[j] = nums[j + 1];

                        //nums[j + 1] will have greater one
                        nums[j + 1] = temp;
                    }
                }

           
            }

        }

        static void SelectionSort(int[] nums)
        {
            int n = nums.Length;

            // n-1 since at n all be sorted
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;

                for (int j = i+1; j < n; j++)
                {
                    if (nums[j] < nums[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    // old min
                    int temp = nums[i];

                    // new min
                    nums[i] = nums[min];

                    //old min
                    nums[min] = temp;


          
                }
            }

        }

       
        public static int IsPrime(int N)
        {

            if (N > 1)
            {
                // smallest
                for (int i = 2; i <= Math.Sqrt(N); i++)
                {   
                    if (N % i == 0)
                        return i;

                }
                return 1;


            }
            else
            {
                return 0;
            }
        }
        public static int isPrime_greatest(int N)
        {
            if(N <= 1)
            {
                return 1;
            }

            bool isprime = true;
            int largest = 1;

            for (int i =2; i< N/2; i++)
            {
                if (N % i == 0)
                {
                    isprime = false;
                    largest = i;
                }
            }

            return isprime ? 1 : largest;

        }

        public static string RemoveVowels(string S)
        {
            //type name[] = new type[] { }
            Dictionary<char, bool> vowels = new Dictionary<char, bool>
            {
                {'a', true },
                {'e', true },
                {'i', true },
                {'o', true },
                {'u', true },
            };

            string result = "";

            foreach (char c in S)
            {
                if (!vowels.ContainsKey(c))
                {
                    result += c;
                }
            }

            return result;

        }

        public static int CountNonUnique(int[] numbers)
        {
            int max = 0;
            int more_than = 0;
            for(int i = 0; i< numbers.Length; i++)
            {
                if( numbers[i] > max)
                {
                    max = numbers[i];

                }
                    
            }

            int[] counting = new int[max+1];

            for (int j = 0; j < numbers.Length; j++)
            {
                counting[numbers[j]] += 1;
                
            }

            for (int k = 0; k < counting.Length; k++)
            {
                if (counting[k] > 1)
                {
                    more_than += 1;
                }

            }

            return more_than;


        }

       
        public static bool IsArmstrong (int N)
        {
            int Number = N;
            int sum = 0;
            int k = N.ToString().Length;
            while (N > 0)
            {
                int digit = N % 10;
                sum += digit;
                N = N / 10;
            }

            if(sum == Number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int NumJewelsInStones(string J, string S)
        {
            int sum = 0;
            int less = 0;
            foreach(char c in S)
            {
                foreach(char k in J)
                {
                    if(c == k)
                    {
                        sum += 1;
                    }
                }
            }
            return sum;

        }

        public static int SingleNumber(int[] nums)
        {
            int max = 0;
            int less = 0;


            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }

            int[] counting = new int[max+1];


            for (int i = 0; i < nums.Length; i++)
            {
                counting[nums[i]] += 1;
               
            }



            for(int j =0; j < counting.Length; j++)
            {
                Console.Write(counting[j]);

                if (counting[j] == 1)
                {
                    less = j;
                }

         
            }

            return less;



        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            Dictionary<int, int> dic1 = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int number2 = target - numbers[i];

                if (dic1.ContainsKey(number2))
                {
                    int idx1 = dic1[number2];
                    int idx2 = i;
                    return idx1 < idx2 ? new int[] { idx1, idx2 } : new int[] { idx2, idx1 };
                }

                if (!dic1.ContainsKey(numbers[i]))
                {
                    dic1[numbers[i]] = i;
                }
            }

            // Return an empty array or a default value if no solution is found
            return new int[] { -1, -1 };
        }

    }


}
