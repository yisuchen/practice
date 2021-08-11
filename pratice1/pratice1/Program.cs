using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace pratice1
{
    public class Program
    {
        #region 第一題
        /// <summary>
        /// 找出陣列裡,不重複的數字
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber(int[] nums)
        {
            // memo
            //建一陣列提供暫時存放, 判斷是否有key已在陣列
            //yes = delete
            //no = insert
            List<int> tempList = new List<int>();
            foreach (var num in nums)
            {
                //初始第一次
                if (tempList.Count == 0)
                {
                    tempList.Add(num);
                    continue;
                }
                else
                {
                    //如有相符元素, 則做刪除, 減少陣列長度
                    foreach (var tempNum in tempList)
                    {
                        if (tempNum == num)
                        {
                            tempList.Remove(tempNum);
                            break;
                        }
                    }
                }
            }
            return tempList[0];
        }
        #endregion

        #region 第一題 - 2
        
        /// <summary>
        /// 利用 XOR 邏輯 找出陣列中不重複的數字
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber2(int[] nums)
        {
            int val = 0;
            foreach(var num in nums)
            {
                val = val ^ num;
            }
            return val;
        }
        #endregion

        #region 第二題
        /// <summary>
        /// 判斷是否為3的乘冪
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool IsPowerOfThree(int number)
        {
            // memo
            // 以3為基礎, 如小於傳入數值, 持續*3
            // 滿足條件後, 判斷是否相等
            bool result = false;
            int tempNumber = 3;

            while (tempNumber < number)
            {
                tempNumber = tempNumber * 3;
            }
            //判斷是否相同
            if (tempNumber == number)
            {
                result = true;
            }
            return result;
        }
        #endregion

        #region 第三題
        /// <summary>
        /// 數字陣列裡所有0的元素移到最後面
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] MoveZeroes(int[] nums)
        {
            // memo 
            // 遍尋陣列  0=>計數   !=0 => Add List
            int zeroCount = 0;
            List<int> resultList = new List<int>();
            foreach (var num in nums)
            {
                if (num == 0)
                {
                    zeroCount++;
                    continue;
                }
                else
                {
                    resultList.Add(num);  // 加入list
                }
            }

            for (var i = 0; i < zeroCount; i++)
            {
                resultList.Add(0); // 依 count 次數 插入 0
            }
            return (resultList.ToArray());
        }
        #endregion

        #region 第三題 2次嘗試
        /// <summary>
        /// 數字陣列裡所有0的元素移到最後面
        /// </summary>
        /// <param name="nums"></param>
        public int[] MoveZeroes2(int[] nums)
        {
            // memo
            // 找到 0 記住 index
            // 找到其他數字 => 與0的index對換
            // index ++
            int index = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = nums[i]; //迴圈現在指到的數字  0,12,0,1,3  index = 1
                if (temp == 0)
                {
                    if (index == -1)//第一個0的位置
                        index = i;
                    else continue;
                }
                else
                {
                    if (index == -1)
                        continue;
                    nums[i] = nums[index] ;
                    nums[index] = temp;
                    index++;//第一個0的位置往後移一位
                }
            }
            return nums;
            //Console.WriteLine("[{0}]", string.Join(", ", nums));
            //Console.ReadKey();
        }
        #endregion
        public static void Main(string[] args)
        {
            Program program = new Program();
            // #1
            int[] nums1 = new int[] { 4, 1, 2, 1, 2 };
            Console.WriteLine(program.SingleNumber(nums1));

            // #2
            Console.WriteLine(program.IsPowerOfThree(0));

            // #3
            int[] nums = new int[] { 0, 12, 0, 1, 3 };
            Console.WriteLine("[{0}]", string.Join(", ", program.MoveZeroes2(nums)));

        }
    }

    public class Calculator
    {
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int Minus(int firsrNumber, int secondNumber)
        {
            return firsrNumber - secondNumber;
        }

        public void SomeMethod()
        {
            throw new NotImplementedException();
        }
    }


}
