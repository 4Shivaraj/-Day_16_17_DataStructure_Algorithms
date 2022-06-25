using System;
using System.Collections.Generic;

namespace DataStructure
{
    class BinarySearchProb
    {
        public void binarySearch()
        {
            // Input text file path
            string file = @"C:\Users\4shiv\OneDrive\Desktop\Fellowship\Assignments\Assignment_Day_16_17\Day_16_17_DS_Algorithms\Algorithms\Binarysearch.txt";

            // Reading comma-separated values from input file 
            string str = File.ReadAllText(file);

            // Converting string into array of strings
            String[] strArray = str.Split(',');

            // Using bubble sorting algorithm for sorting string array elements
            BubbleSort(strArray);


            // Printing sorted string array elements
            for (int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, strArray[i]);
            }


            // Taking input string value to be searched
            Console.Write("\n\nEnter text to be searched:  ");
            string word = Console.ReadLine();

            int left = 0;
            int right = strArray.Length - 1;

            // Using Binary Search 
            int result = BinarySearch(strArray, left, right, word);

            Console.WriteLine((result == -1) ? "\nElement not found" : "\nElement found at position " + (result + 1));

        }

        public static int BinarySearch(string[] strArray, int left, int right, string word)
        {
            if (right >= left)
            {

                int mid = left + (right - left) / 2;

                if (strArray[mid] == word)
                {
                    return mid;
                }
                else if (word.CompareTo(strArray[mid]) < 0)
                {
                    return BinarySearch(strArray, left, mid - 1, word);        // left sub array
                }
                else
                {
                    return BinarySearch(strArray, mid + 1, right, word);      // right sub array
                }
            }

            return -1;
        }

        void BubbleSort(string[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}