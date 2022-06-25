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
                    "\n5.MergeSort\n6.Anagrams\n7.PrimeNumber\n8.AnagramAndPalindromes\n9.SearchingAndSortingUsingGenerics");
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
                    case 7:
                        PrimeNumbers primenumbers = new PrimeNumbers();
                        primenumbers.primeNumbers();
                        break;
                    case 8:
                        AnagramAndPalindromeNumber anagramandpalindromenumber = new AnagramAndPalindromeNumber();
                        anagramandpalindromenumber.anagramAndPalindrome();
                        break;
                    case 9:
                        SearchingAndSortingUsingGenerics searchingandsortingusinggenerics = new SearchingAndSortingUsingGenerics();
                        searchingandsortingusinggenerics.SearchingAndSorting();
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

//UC-9
//Rewrite Use Generics for Search and Sort Algorithms

//RESULT
//Welcome To Datastructures and Algorithms
//1.Permutation Using Recursion
//2.BinarySearch
//3.InsertionSort
//4.BubbleSort
//5.MergeSort
//6.Anagrams
//7.PrimeNumber
//8.AnagramAndPalindromes
//9.SearchingAndSortingUsingGenerics
//Enter Your Option
//9
//Enter size of array: 5

//Enter array elements:
//56
//34
//25
//76
//45

//Select an option:
//1.Bubble Sort
//2.Binary Search
//Option:  1

//Array before sorting:
//56 34 25 76 45

//Array after sorting:
//25 34 45 56 76