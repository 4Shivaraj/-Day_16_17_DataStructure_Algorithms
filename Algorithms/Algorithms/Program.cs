namespace DataStructure
{
    class Program
    {
        static void Main(String[] args)
        {
            string flag = "Y";
            while (flag == "Y" || flag == "y")
            {
                Console.WriteLine("Welcome To Datastructures and Algorithms");
                Console.WriteLine("1.Permutation Using Recursion\n2.BinarySearch\n3.InsertionSort\n4.BubbleSort" +
                    "\n5.MergeSort");
                Console.WriteLine("Enter Your Option");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        PermutationsOfString permutationsofstring = new PermutationsOfString();
                        permutationsofstring.permutations();
                        break;
                    case 2:
                        BinarySearchProb binarysearchprob = new BinarySearchProb();
                        binarysearchprob.binarySearch();
                        break;
                    case 3:
                        InsertionSort insertionsort = new InsertionSort();
                        insertionsort.insertionSort();
                        break;
                    case 4:
                        BubbleSort bubblesort = new BubbleSort();
                        bubblesort.bubbleSort();
                        break;
                    case 5:
                        MergeSort mergesort = new MergeSort();
                        mergesort.mergeSort();
                        break;
                    default:
                        Console.WriteLine("-------Enter the valid option---");
                        break;
                }
                Console.WriteLine("\nDo you want to continue");
                flag = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}

//UC_5
//5.Merge Sort - Write a program to do Merge Sort of list of Strings.
//a. Logic -> To Merge Sort an array, we divide it into two halves, sort the two halves
//independently, and then merge the results to sort the full array. To sort a[lo, hi),
//we use the following recursive strategy:
//b.Base case: If the subarray length is 0 or 1, it is already sorted.
//c.Reduction step: Otherwise, compute mid = lo + (hi - lo) / 2, recursively sort the
//two subarrays a[lo, mid) and a[mid, hi), and merge them to produce a sorted
//result.

//RESULT
//Welcome To Datastructures and Algorithms
//1.Permutation Using Recursion
//2.BinarySearch
//3.InsertionSort
//4.BubbleSort
//5.MergeSort
//Enter Your Option
//5
//Array before sorting
//white  black  blue  green  red  orange  brown  yellow  pink  magenta

//Array after sorting
//black  blue  brown  green  magenta  orange  pink  red  white  yellow