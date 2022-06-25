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
                Console.WriteLine("1.Permutation Using Recursion\n2.BinarySearch");
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

//UC-2
//2.Binary Search the Word from Word List
//a. Desc -> Read in a list of words from File. Then prompt the user to enter a word to
//search the list. The program reports if the search word is found in the list.
//b. I/P -> read in the list words comma separated from a File and then enter the word to be searched
//c. Logic -> Use Arrays to sort the word list and then do the binary search
//d. O/P -> Print the result if the word is found or not

//Results
//Welcome To Datastructures and Algorithms
//1.Permutation Using Recursion
//2.BinarySearch
//Enter Your Option
//2
//1. black
//2. blue
//3. brown
//4. green
//5. magenta
//6. orange
//7. pink
//8. red
//9. white
//10. yellow