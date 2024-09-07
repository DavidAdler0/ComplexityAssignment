using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexityAssignment
{
    internal class Exercises
    {
        //1: 1+ +1 n*7 +1 -> O(n)
        public int CalculateOddSum(int[] array)
        {
            int sum = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                int cur = array[i];
                if (cur % 2 != 0)
                {
                    sum += cur;
                }
            }
            return sum;

        }

        //2: 1 + 1 + n-1*7 +1 -> O(n)
        public int FindMaximumTwo(int[] array)
        {
            int sum = int.MinValue;
            for (int i = 0; i < array.Length -1; i++)
            {
                int cur = array[i] + array[i + 1];
                if ( cur > sum)
                {
                    sum = cur ;
                }
            }
            return sum;
        }
        //3: 1 + 1 + n*4 + 1 + 1 -> O(n)
        public bool ContainsNumber(int[] array, int number)
        {
            bool result = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    result = true;
                    return result;
                }
            }
            return result;
        }
        //4: 1 + 1 + (n*2)*((n/2)*2 +1)*((n/4)*8 +1) +1 -> O(n^3)
        public int SumOfAllTriplets(int[] array)
        {
            int maxTriplets = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    for (int k = j + 1; k < array.Length; k++)
                    {
                        int cur = array[i] + array[j] + array[k];
                        if (cur > maxTriplets)
                        {
                            maxTriplets = cur;
                        }
                    }
                }

            }
            return maxTriplets;
        }
        //5: 1 + 1 + n*6 + 3 -> O(n)
        public (int, int) FindLastPairWithProduct(int[] array, int product)
        {
            int firstOfProduct = int.MinValue;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] * array[i + 1] == product)
                {
                    firstOfProduct = i;
                }
            }
            return (array[firstOfProduct], array[firstOfProduct + 1]);
        }
        //6: 1+ +1 n*7 +1 -> O(n)
        public int CountEvenNumbers(int[] array)
        {
            int sum = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                int cur = array[i];
                if (cur % 2 == 0)
                {
                    sum += cur;
                }
            }
            return sum;
        }
        //7: 4 + n1*16 + (n2-n1)*6 +1 -> O(n) 
        public int[] MergeSortedArraysUnique(int[] array1, int[] array2)
        {
            int length1 = array1.Length;
            int length2 = array2.Length;
            int[] mergedArray = new int[length1 + length2];
            int i1 = 0, i2 = 0, i3 = 0;
            while (i1 < length1 && i2 < length2)
            {
                if ((array1[i1] == array2[i2]))
                {
                    mergedArray[i3++] = array1[i1++];
                    i2++;
                }
                else if (array1[i1] < array2[i2])
                {
                    mergedArray[i3++] = array1[i1++];
                }
                else
                {
                    mergedArray[i3++] = array2[i2++];
                }
            }
            while (i1 < length1)
            {
                mergedArray[i3++] = array1[i1++];
            }
            while (i2 < length2)
            {
                mergedArray[i3++] = array1[i2++];
            }
            return mergedArray;
        }
        //8: 3 + 1 + (n*2)*((n/2)*11 +2) +1 -> O(n^2)
        public (int,int)[] FindPairsWithSum(int[] array, int sum)
        {
            (int, int)[] allPairsWhithSum = new (int, int)[array.Length/2];
            int idx = 0;
            for (int i = 0; i < allPairsWhithSum.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == sum)
                    {
                        allPairsWhithSum[idx++] = (array[i], array[j]);
                    }
                }
            }
            return allPairsWhithSum;
        }
        //9: 1 + 1 + (n*2)*(n*7 +1) +1 -> O(n^2)
        public static int[] CountFrequency(int[] array)
        {
            int[] frquency = new int[array.Length];
            for (int i = 0;i < frquency.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        frquency[j] +=1;
                    }
                }
            }
            return frquency;
        }
        //10: 1 + 1 + (n*6)*((n/2 -1)*6 +1) +1 -> O(n^2)
        public int FindMaxSubarraySum(int[] array)
        {
            int maxSubArray = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                int sum = array[i];
                for (int j = i +1;  j < array.Length; j++)
                {
                    int cur = array[j];
                    if (sum + cur > sum)
                    {
                        sum += cur;
                    }
                }
                if (sum > maxSubArray)
                {
                    maxSubArray = sum;
                }
            }
            return maxSubArray;
        }
        //11: 1 + (n*4) * (((n/2 -1) * 5) +1) + 1 -> O(n^2)
        public int FindFirstRepeating(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int firstNum = array[i];
                for (int j = i + 1; j < array.Length; ++j)
                {
                    int secondNum = array[j];
                    if (secondNum == firstNum)
                    {
                        return firstNum;
                    }
                }
            }
            return -1;
        }
        //12: 1 + n*8 +1 -> O(n)
        public int FindMissingNumber(int[] array, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                int cur = array[i];
                if (array[i+1] - cur != 1)
                    return cur + 1;
            }
            return -1;
        }
        //13:  1 + (n*2)*((n/2)*4 +1) +1 -> O(n^2)
        public int FindMissingNumberUnsorted(int[] array, int n)
        {
            for(int i = 1; i <= n; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] == i)
                        break;
                    else return i;
                }
            }
            return -1;
        }


    }
}
