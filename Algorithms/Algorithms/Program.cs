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
                Console.WriteLine("1.Permutation Using Recursion\n2.BinarySearch\n3.InsertionSort");
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

//UC-3
//3.Insertion Sorta
//.Desc -> Reads in strings and prints them in sorted order using insertion sort.
//b.I / P->read in the list words
//c. Logic -> Use Insertion Sort to sort the words in the String array
//d. O/P -> Print the Sorted List

//Results
//Welcome To Datastructures and Algorithms
//1.Permutation Using Recursion
//2.BinarySearch
//3.InsertionSort
//Enter Your Option
//3
//Array before sorting:
//white
//black
//blue
//green
//red
//orange
//brown
//yellow
//pink
//magenta

//Array after sorting:
//black
//blue
//brown
//green
//magenta
//orange
//pink
//red
//white
//yellow