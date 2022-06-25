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
                    "\n10.FindNumber\n11.TaskDoneByMaximumAmount");
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
                    case 11:
                        TaskDoneByMaximumAmount taskdonebymaximumamount = new TaskDoneByMaximumAmount();
                        taskdonebymaximumamount.tasks();
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

//UC-11
//11.You have a long list of tasks that you need to do today. To accomplish task you need M
//minutes, and the deadline for this task is D . You need not complete a task at a stretch.
//You can complete a part of it, switch to another task, and then switch back.You've
//realized that it might not be possible to complete all the tasks by their deadline. So you
//decide to do them in such a manner that the maximum amount by which a task's
//completion time overshoots its deadline is minimized.
//Input Format - The first line contains the number of tasks, . Each of the next
//lines contains two integers, D and M .
//Output Format - Output T lines. The ith line contains the value of the maximum
//amount by which a task's completion time overshoots its deadline, when the first
//tasks on your list are scheduled optimally.

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
//11.TaskDoneByMaximumAmount
//Enter Your Option
//11
//Number of Tasks:   3

//Task - 1
//Deadline: 2
//Time Taken: 15

//Task - 2
//Deadline: 3
//Time Taken: 25

//Task - 3
//Deadline: 1
//Time Taken: 10



//Task - 1 overshoots its deadline 2 by 13

//Task -2 overshoots its deadline 3 by 37

//Task -3 overshoots its deadline 1 by 47