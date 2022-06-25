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
                    "\n5.MergeSort\n6.Anagrams\n7.PrimeNumber\n8.AnagramAndPalindromes");
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

//UC-8
//8.Extend the above program to find the prime numbers that are Anagram and
//Palindrome
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
//Enter Your Option
//8
//Prime numbers from 0 to 1000 are:
//2
//3
//5
//7
//11
//13
//17
//19
//23
//29
//31
//37
//41
//43
//47
//53
//59
//61
//67
//71
//73
//79
//83
//89
//97
//101
//103
//107
//109
//113
//127
//131
//137
//139
//149
//151
//157
//163
//167
//173
//179
//181
//191
//193
//197
//199
//211
//223
//227
//229
//233
//239
//241
//251
//257
//263
//269
//271
//277
//281
//283
//293
//307
//311
//313
//317
//331
//337
//347
//349
//353
//359
//367
//373
//379
//383
//389
//397
//401
//409
//419
//421
//431
//433
//439
//443
//449
//457
//461
//463
//467
//479
//487
//491
//499
//503
//509
//521
//523
//541
//547
//557
//563
//569
//571
//577
//587
//593
//599
//601
//607
//613
//617
//619
//631
//641
//643
//647
//653
//659
//661
//673
//677
//683
//691
//701
//709
//719
//727
//733
//739
//743
//751
//757
//761
//769
//773
//787
//797
//809
//811
//821
//823
//827
//829
//839
//853
//857
//859
//863
//877
//881
//883
//887
//907
//911
//919
//929
//937
//941
//947
//953
//967
//971
//977
//983
//991
//997

//Palindromes and Prime number between 0 to 1000 are:
//2
//3
//5
//7
//11
//101
//131
//151
//181
//191
//313
//353
//373
//383
//727
//757
//787
//797
//919
//929

//Anagram of Prime number between 0 to 1000 are:

//Anagram of 13 :   13   31
//Anagram of 17 :   17   71
//Anagram of 31 :   13   31
//Anagram of 37 :   37   73
//Anagram of 71 :   17   71
//Anagram of 73 :   37   73
//Anagram of 79 :   79   97
//Anagram of 97 :   79   97
//Anagram of 107 :   107   701
//Anagram of 113 :   113   131   311
//Anagram of 127 :   127   271
//Anagram of 131 :   113   131   311
//Anagram of 137 :   137   173   317
//Anagram of 139 :   139   193
//Anagram of 149 :   149   419   491   941
//Anagram of 157 :   157   571   751
//Anagram of 163 :   163   613   631
//Anagram of 167 :   167   617   761
//Anagram of 173 :   137   173   317
//Anagram of 179 :   179   197   719   971
//Anagram of 181 :   181   811
//Anagram of 191 :   191   911
//Anagram of 193 :   139   193
//Anagram of 197 :   179   197   719   971
//Anagram of 199 :   199   919   991
//Anagram of 239 :   239   293
//Anagram of 241 :   241   421
//Anagram of 251 :   251   521
//Anagram of 271 :   127   271
//Anagram of 277 :   277   727
//Anagram of 281 :   281   821
//Anagram of 283 :   283   823
//Anagram of 293 :   239   293
//Anagram of 311 :   113   131   311
//Anagram of 313 :   313   331
//Anagram of 317 :   137   173   317
//Anagram of 331 :   313   331
//Anagram of 337 :   337   373   733
//Anagram of 347 :   347   743
//Anagram of 349 :   349   439
//Anagram of 359 :   359   593   953
//Anagram of 367 :   367   673
//Anagram of 373 :   337   373   733
//Anagram of 379 :   379   397   739   937
//Anagram of 389 :   389   839   983
//Anagram of 397 :   379   397   739   937
//Anagram of 419 :   149   419   491   941
//Anagram of 421 :   241   421
//Anagram of 439 :   349   439
//Anagram of 457 :   457   547
//Anagram of 461 :   461   641
//Anagram of 463 :   463   643
//Anagram of 467 :   467   647
//Anagram of 479 :   479   947
//Anagram of 491 :   149   419   491   941
//Anagram of 521 :   251   521
//Anagram of 547 :   457   547
//Anagram of 563 :   563   653
//Anagram of 569 :   569   659
//Anagram of 571 :   157   571   751
//Anagram of 577 :   577   757
//Anagram of 587 :   587   857
//Anagram of 593 :   359   593   953
//Anagram of 613 :   163   613   631
//Anagram of 617 :   167   617   761
//Anagram of 619 :   619   691
//Anagram of 631 :   163   613   631
//Anagram of 641 :   461   641
//Anagram of 643 :   463   643
//Anagram of 647 :   467   647
//Anagram of 653 :   563   653
//Anagram of 659 :   569   659
//Anagram of 673 :   367   673
//Anagram of 683 :   683   863
//Anagram of 691 :   619   691
//Anagram of 701 :   107   701
//Anagram of 709 :   709   907
//Anagram of 719 :   179   197   719   971
//Anagram of 727 :   277   727
//Anagram of 733 :   337   373   733
//Anagram of 739 :   379   397   739   937
//Anagram of 743 :   347   743
//Anagram of 751 :   157   571   751
//Anagram of 757 :   577   757
//Anagram of 761 :   167   617   761
//Anagram of 769 :   769   967
//Anagram of 787 :   787   877
//Anagram of 797 :   797   977
//Anagram of 811 :   181   811
//Anagram of 821 :   281   821
//Anagram of 823 :   283   823
//Anagram of 839 :   389   839   983
//Anagram of 857 :   587   857
//Anagram of 863 :   683   863
//Anagram of 877 :   787   877
//Anagram of 907 :   709   907
//Anagram of 911 :   191   911
//Anagram of 919 :   199   919   991
//Anagram of 937 :   379   397   739   937
//Anagram of 941 :   149   419   491   941
//Anagram of 947 :   479   947
//Anagram of 953 :   359   593   953
//Anagram of 967 :   769   967
//Anagram of 971 :   179   197   719   971
//Anagram of 977 :   797   977
//Anagram of 983 :   389   839   983
//Anagram of 991 :   199   919   991