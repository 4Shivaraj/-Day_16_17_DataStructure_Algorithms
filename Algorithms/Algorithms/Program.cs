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
                Console.WriteLine("1.Permutation Using Recursion");
                Console.WriteLine("Enter Your Option");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        PermutationsOfString permutationsofstring = new PermutationsOfString();
                        permutationsofstring.permutations();
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

//UC-1
//1.Write static functions to return all permutations of a String using iterative method and
//Recursion method. Check if the arrays returned by two string functions are equal.

//Results
//Welcome To Datastructures and Algorithms
//1.Permutation Using Recursion
//Enter Your Option
//1
//Enter a string:  ABC

//Permutations of string ABC are:
//ABC
//ACB
//BAC
//BCA
//CAB
//CBA