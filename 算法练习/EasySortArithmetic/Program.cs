﻿namespace EasySortArithmetic
{
    class Program
    {
        /* 排序算法
         * 内排序：所有排序操作都在内存中完成。
         * 外排序：由于数据量太大，因此把数据放在磁盘中，而排序通过磁盘和内存的数据传输才能进行。
         * 时间复杂度：一个算法执行所耗费的时间。
         * 空间复杂度：运行完一个程序所需内存的大小。
         * 冒泡排序、选择排序、插入排序、希尔排序
        */
        static void Main(string[] args)
        {
            int[] strArry = { 3, 44, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };
            //测试冒泡
            //var newArry = BubbleSort(strArry);
            //for (int i = 0; i < newArry.Length; i++)
            //{
            //    System.Console.WriteLine(newArry[i]);
            //}
            var newArry = SelectionSort(strArry);
            for (int i = 0; i < newArry.Length; i++)
            {
                System.Console.WriteLine(newArry[i]);
            }

            System.Console.ReadKey();
        }


        #region 冒泡排序
        /* 冒泡排序
         * 通过两两元素的数据比较，将最大的数或者最小的数冒到数列的顶端，依次重复执行的时候，最终将整个数列进行一个排序。
         * 
         * 算法描述
         * 比较相邻的元素。如果第一个比第二个大，就交换他们两个。
         * 对每一对相邻元素做同样的工作，从开始第一对到结尾的最后一对，这样在最后的元素应该会是最大的数。
         * 针对所有的元素重复以上的步骤，除了最后一个。
         * 重复步骤1~3，直到排序完成。
         */

        /// <summary>
        /// 冒泡排序
        /// </summary>
        private static int[] BubbleSort(int[] strArry)
        {
            if (strArry == null || strArry.Length <= 1)
            {
                return strArry;
            }

            //外层的for循环指的是冒泡的轮数。轮数=数组的长度-1（最后一个元素是不需要操作的）
            for (int i = 0; i < strArry.Length - 1; i++)
            {
                //内层的for循环是指每一轮冒泡操作中两两数据比较与数据交换。比完一次就少一个数，所以就要再减去 i.
                for (int j = 0; j < strArry.Length - 1 - i; j++)
                {
                    //判断“大于”就是升序，因为将大放到后面的位置了。
                    if (strArry[j] > strArry[j + 1])
                    {
                        int temp = strArry[j];//把第j个值放到临时变量里面。
                        strArry[j] = strArry[j + 1];//然后将第j+1的值放到j的位置。
                        strArry[j + 1] = temp;//最后将第j的值放到j+1的位置。
                    }
                }
            }
            return strArry;
        }
        #endregion 冒泡排序

        #region 选择排序
        /* 选择排序
         * 在未排序的数列中找到最大（小）的元素，存放在未排序的序列的起始位置，然后再从剩余未排序的元素中继续找最大（小）元素，
         * 然后放到已排序的末尾，以此类推，直到所有元素均排序完毕。
         * 
         * 算法描述
         * 初始状态：无序区为R[1..n],有序区为空。
         * 
         * 第i趟排序（i=1,2,3...n-1）开始时，当前有序区和无序区分别为R[1..i-1]和R(1..n)。该趟排序从当前无序区中选出关键字最小的记录
         * R[K],将他与无序区的第1个记录R交换，使R[1..i]和R(1..n)分别为记录个数增加1个的新有序区和记录个数减少1个的新无序区；
         * 
         * n-1趟结束，数组有序化了。
         */

        /// <summary>
        /// 选择排序
        /// </summary>
        /// <param name="strArry"></param>
        /// <returns></returns>
        private static int[] SelectionSort(int[] strArry)
        {
            if (strArry == null || strArry.Length <= 1)
            {
                return strArry;
            }
            //外层循环==轮数
            for (int i = 0; i < strArry.Length; i++)
            {
                //最小数的索引
                int mixindex = i;
                //内循环是每一轮外循环里面的数据比较
                for (int j = i; j < strArry.Length; j++)
                {
                    if (strArry[j] < strArry[mixindex])//找到最小的数
                        mixindex = j;//将最小的数的索引保存
                }
                int temp = strArry[mixindex];//将这个最小的数据，存放到临时变量里面。
                strArry[mixindex] = strArry[i];//再把将索引为 i 的值，放到最小值的那个位置。 
                strArry[i] = temp;//然后再将最小的值放到第 i 位。
            }

            return strArry;

        }
        #endregion

        #region 插入排序
        /*插入排序
         * 通过构建有序数列，对于未排序数据，在已排序序列中从后向前扫描，找打相应位置并插入。
         * 
         * 算法描述
         * 1、从第一个元素开始，该元素可以认为已经被排序；
         * 2、取出下一个元素，在已排序的元素序列中从后向前扫描；
         * 3、如果该元素（已排序）大于新元素，将该元素移到下一个位置；
         * 4、重复步骤3，直到找到已排序的元素小于或者等于新元素的位置；
         * 5、将新元素插入到该位置后，重复步骤2~5
         */
        #endregion
    }
}
