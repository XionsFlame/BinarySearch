//HackerRank Binary Search

using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 18;
            int[] array = arrayBuilder(20);
            BinarySearchRecursive(array, num);
            binarySearchIterative(array, num);
        }

        /* Binary Search splits the search for a target into two to make searching through a 
        sorted array faster than iterating over every index of the array */
        // Requires an array, a target int, and the left and right most indexes
        static bool BinarySearchRecursive(int[] array, int x, int left, int right)
        {
            if(left > right)
            {
                return false;
            }
            //find the mid point of the array
            int mid = (left + right) / 2;
            //Check if you have found the right index, if not then decide which side of the array to search through
            if (array[mid] == x)
                return true;
            else if(x < array[mid])
            {
                return BinarySearchRecursive(array, x, left, mid - 1);
            } else
            {
                return BinarySearchRecursive(array, x, mid + 1, right);
            }
        }

        static bool BinarySearchRecursive(int[] array, int x)
        {
            return BinarySearchRecursive(array, x, 0, array.Length - 1);
        }

        //BST Iterative same functionality just in a while loop.
        static bool binarySearchIterative(int[] array, int x)
        {
            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                {
                    int mid = left + ((right - left) / 2);
                    if (array[mid] == x)
                    {
                        return true;
                    }
                    else if (x < array[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
            }
            return false;
        }

        static int[] arrayBuilder(int n)
        {
            int[] newArray = new int[n];
            for(int i = 0; i < n; i++)
            {
                newArray[i] = i;
            }
            return newArray;
        }
    }
}
