using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoDs
{
    class Task1
    {
        public int calDec(int n)
        {
            if (n == 0)
                return 0;
            else
            {
                Console.WriteLine(n);
                return (calDec(n - 1) + 1);
            }
        }
        public int calInc(int curr, int n)
        {
            if (curr == n) return n;
            else
            {
                Console.WriteLine(curr);
                return calInc(curr + 1, n)-1;
            }                     
        }
        public void bubSort(int[] arr, int l,int l2, int r)
        {
            if (l == r)
            {
                return;
            }
            else
            {
                if (arr[l] < arr[r])
                {
                    int temp = arr[l];
                    arr[l] = arr[r];
                    arr[r] = temp;
                }
                bubSort(arr, l + 1, l + 1, r);
            }
        }
        public void bubRec(int[]arr , int begIndex)
        {
            if (begIndex == arr.Length)
            {
                return;
            }
            else
            {
                bubRec(arr, begIndex + 1);
                if (begIndex+1<arr.Length && arr[begIndex] > arr[begIndex + 1])
                {
                    int temp = arr[begIndex];
                    arr[begIndex] = arr[begIndex + 1];
                    arr[begIndex + 1] = temp;
                    bubRec(arr, begIndex + 1);
                }
            }
        }
        public void printRec(char[] str, int start, int stop)
        {
            if (start == str.Length)
                Console.Write(str);
            for (int j= start; j <= stop; j++)
            {
                swap(ref str[start], ref str[j]);
                printRec(str, start + 1, stop);
                swap(ref str[start], ref str[j]); 
            }        
        }
        static void swap(ref char a, ref char b)
        {
            char tmp;
            tmp = a;
            a = b;
            b = tmp;
        }
        static void printPermutations(char[] inputArr, int beginIdx, char[] decisionSoFar, int idxForDecision)
        {
            if (beginIdx >= inputArr.Length)
            {
                Console.WriteLine(decisionSoFar);
                return;
            }

            char[] originalInput = new char[inputArr.Length];
            Array.Copy(originalInput, inputArr, inputArr.Length);

            for (int i = beginIdx; i < inputArr.Length; ++i)
            {
                // swap
                char tmp = originalInput[i];
                originalInput[i] = originalInput[beginIdx];
                originalInput[beginIdx] = tmp;
                Array.Copy(inputArr, originalInput, inputArr.Length);
                // print Permutations
                decisionSoFar[idxForDecision] = inputArr[beginIdx];
                printPermutations(inputArr, beginIdx + 1, decisionSoFar, idxForDecision + 1);
            }
        }
        //static void printPermutation(char[] inputStr, int beginIndex, char[] decisionSoFar,int indexForDec)
        //{
        //    if (beginIndex >= inputStr.Length)
        //    {
        //        Console.Write(decisionSoFar);
        //        return;
        //    }
        //    for( int i = beginIndex; i < inputStr.Length; ++i)
        //    {
        //        char temp = inputStr[i];
        //        inputStr[i] = inputStr[beginIndex];
        //        inputStr[beginIndex] = temp;

        //        decisionSoFar[indexForDec] = inputStr[beginIndex];
        //        printPermutation(inputStr, beginIndex + 1, decisionSoFar, indexForDec + 1);
        //    }
        //}

        public void Program()
        {
            calDec(5);
            calInc(1,5);
            int[] arr = { 4, 1, 6, 8 };
            //bubSort(arr,0,1,4);
            bubRec(arr, 0);
            for (int i = 0; i < 4; i++)
            {
                Console.Write(arr[i] + " ");
            }
            string str = "abc";
            char[] charArry = str.ToCharArray();
            printPermutation(charArry,0,2,0);
            Console.ReadKey();
        }
    }
}
