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
                    "\n5.MergeSort\n6.Anagrams\n7.PrimeNumber\n8.AnagramAndPalindromes\n9.SearchingAndSortingUsingGenerics" +
                    "\n10.FindNumber");
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
                    case 10:
                        FindNumber findnumber = new FindNumber();
                        findnumber.Find();
                        findnumber.Question(12, 23);
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

//UC-10
//10.Question to find your number
//a. Desc -> takes a command-line argument N, asks you to think of a number
//between 0 and N-1, where N = 2^n, and always guesses the answer with n
//questions.
//b. I/P -> the Number N and then recursively ask true/false if the number is between
//a high and low value
//c. Logic -> Use Binary Search to find the number
//d. O/P -> Print the intermediary number and the final answer

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
//10.FindNumber
//Enter Your Option
//10
//Enter a limit:
//100
//Enter a guess between 0 and 1.2676506002282294E+30
//is this  number 17 is grater than your number ?
//n
//is this  number 14 is grater than your number ?
//n
//is this  number 13 is grater than your number ?
//n
//is this  number 12 is grater than your number ?