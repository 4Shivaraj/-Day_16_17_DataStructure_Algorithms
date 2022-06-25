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
                    "\n5.MergeSort\n6.Anagrams");
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
                    case 6:
                        Anagrams anagrams = new Anagrams();
                        anagrams.checkAnagrams();
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

//UC_6
//6.An Anagram Detection Example
//a. Desc -> One string is an anagram of another if the second is simply a
//rearrangement of the first. For example, 'heart' and 'earth' are anagrams...
//b. I/P -> Take 2 Strings as Input such abcd and dcba and Check for Anagrams
//c. O/P -> The Two Strings are Anagram or not....

//RESULT
//Welcome To Datastructures and Algorithms
//1.Permutation Using Recursion
//2.BinarySearch
//3.InsertionSort
//4.BubbleSort
//5.MergeSort
//6.Anagrams
//Enter Your Option
//6
//Enter first string:   a gentleman

//Enter second string:   elegant man

//String a gentleman and elegant man are anagram of each other.