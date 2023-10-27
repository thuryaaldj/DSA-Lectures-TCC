using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end) // don't edit this line!!!
                                                                                // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                                // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: write code for the ternary search algorithm and return the index of the element

            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid1 = left + (right - left) / 3;
                int mid2 = left + 2 * (right - left) / 3;

                if (arr[mid1] == key)
                    return mid1;
                if (arr[mid2] == key)
                    return mid2;

                if (key < arr[mid1])
                    right = mid1 - 1;
                else if (key > arr[mid2])
                    left = mid2 + 1;
                else
                {
                    left = mid1 + 1;
                    right = mid2 - 1;
                }
            }


            return -1;
        }

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: this methods is for getting the first accurence of the key and the last accurance
            start = 0;
            end = arr.Length - 1;
            int count = 0;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (arr[mid] == key)
                {
                    count++;
                }

                if (arr[mid] < key)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return count;
        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            //TODO: write code to calculate the repeat count of a spacific element
            // make sure to use the previous method in this method

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(key))
                    count++;
            }
            return count;
        }

    }
}
