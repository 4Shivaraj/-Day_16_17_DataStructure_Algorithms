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
                    "\n10.FindNumber\n11.TaskDoneByMaximumAmount\n12.CustomisedMessages");
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
                    case 12:
                        CustomizedMessage customizedmessage = new CustomizedMessage();
                        customizedmessage.printMessage();
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

//UC-12
//12.Customize Message Demonstration using String Function and RegEx
//a. Desc -> Read in the following message: Hello << name >>, We have your full
//name as <<full name>> in our system. your contact number is 91-xxxxxxxxxx.
//Please, let us know in case of any clarification Thank you BridgeLabz 01/01/2016.
//Use Regex to replace name, full name, Mobile#, and Date with proper value.
//b. I/P -> read in the Message
//c. Logic -> Use Regex to do the following
//i. Replace <<name>> by first name of the user ( assume you are the user)
//ii.replace << full name >> by user full name.
//iii. replace any occurance of mobile number that should be in format
//91-xxxxxxxxxx by your contact number.
//iv. replace any date in the format XX/XX/XXXX by current date.
//d. O/P -> Print the Modified Message.

//RESULT
//Hello Shivaraj,

//We have your full name as Shivaraj Krishnamurthy in our system. Your contact number is 8618199771.
//Please let us know in case of any clarification.

//Thank you


//BridgeLabz
//26-02-2022.


////Task - 1 overshoots its deadline 2 by 13

////Task -2 overshoots its deadline 3 by 37

////Task -3 overshoots its deadline 1 by 47