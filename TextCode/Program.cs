using Microsoft.TeamFoundation.Common.Internal;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Collections;
//using System.Text.RegularExpressions;
//using System.Linq;
using System.Threading;

namespace TextCode
{
    class Program
    {
        static List<Person> lista = new List<Person>() {
            new Person(){Name="Rose",Age=19},
            new Person(){Name="Steve",Age=45},
            new Person(){Name="Jessica",Age=20}
        };
        static AutoResetEvent autoSet = new AutoResetEvent(false);
        //泛型没有非泛型线程互斥属性SyncRoot，需要自己new一个
        static object syncObj = new object();
        static void Main(string[] args)
        {
            #region MyRegion


            //int x = 1534236469;
            //int f = 0;
            //string a = x.ToString();
            //string b = string.Empty;
            //foreach (char i in a)
            //{
            //    if (i == '-')
            //    {
            //        f = 1;
            //        b = b.Insert(0, i.ToString());
            //    }
            //    else
            //    {
            //        b = b.Insert(f, i.ToString());
            //    }

            //}
            //int ee = 0;
            //int.TryParse(b, out ee);
            //int x = 121;
            //if (x < 0)
            //{
            //    Console.WriteLine("false");
            //}
            //int a, i = 0;
            //for (int i = x; i > 0; i = i / 10)
            //{
            //    a = a * 10 + i % 10;
            //    Console.WriteLine(a);
            //}
            //for (x; x > a; x = x / 10)
            //{
            //    a = a * 10 + x % 10;
            //}
            //if (a == x)
            //{
            //    Console.WriteLine(a);
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}

            //string II = "IVIII";

            //int a = 0;
            //string b = string.Empty;
            //int sum = 0;
            //while (II != "")
            //{
            //    if (II.Length == 1)
            //    {
            //        b = II;
            //    }
            //    else
            //        b = II.Substring(0,1);
            //    if (b == "I" || b == "X" || b == "C")
            //    {
            //        if (II.Length > 1)
            //        {
            //            int f = SingleStr(II.Substring(0, 2));
            //            if (f != 0)
            //            {
            //                sum = sum + f;
            //                II = II.Remove(0, 2);
            //            }
            //            else
            //            {
            //                f = SingleStr(b);
            //                sum = sum + f;
            //                II = II.Remove(0, 1);
            //            }

            //        }
            //        else
            //        {
            //            int f = SingleStr(b);
            //            sum = sum + f;
            //            II = II.Remove(0, 1);
            //        }
            //    }
            //    else
            //    {
            //        int f = SingleStr(b);
            //        sum = sum + f;
            //        II = II.Remove(0, 1);
            //    }
            //}
            //string[] a = new string[2] { "c", "c" };
            //string str = a[0];
            //string r = "";


            //for (int i = 1; i <= str.Length; i++)
            //{
            //    string b = str.Substring(0, i);
            //    if (FindStr(b, a, i))
            //    {
            //        if (r.Length < b.Length)
            //        {
            //            r = b;
            //        }
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}
            //string a = "{[]}";

            //string one = "";
            //string two = string.Empty;
            //int index = 0;
            //int index2 = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    string str = a.Substring(i, 1);
            //    switch (str)
            //    {
            //        case "(":
            //            one = string.Concat(")", one);
            //            index = i;
            //            continue;
            //        case "[":
            //            one = string.Concat("]", one);
            //            index = i;
            //            continue;
            //        case "{":
            //            one = string.Concat("}", one);
            //            index = i;
            //            continue;
            //    }
            //    if (one.Length < 1)
            //    {
            //        Console.WriteLine(false);
            //        return;
            //    }
            //    if (one.Substring(0, 1) == str)
            //    {
            //        if (one.Length == 1)
            //        {
            //            one = "";
            //        }
            //        else
            //            one = one.Substring(1, one.Length-1);
            //    }
            //    else  Console.WriteLine(false);
            //}
            //if (one.Length == 0)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //    Console.WriteLine(false);
            //int[] nums = new int[6] { 0, 1, 1, 3, 3, 5 };
            //if (nums==null||nums.Length==0)
            //{
            //    Console.WriteLine(0);
            //}
            //int p = 0;int count = 1;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[p]==nums[i])
            //    {
            //        nums[p] = nums[i];
            //    }
            //    else
            //    {
            //        p++;
            //        nums[p] = nums[i];
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);  
            #endregion
            #region 搜索插入位置
            //int[] nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            //if (nums == null || nums.Length < 1)
            //{
            //    Console.WriteLine(0);
            //}
            //int val = 2;
            //int L = nums.Length - 1;
            //int count = 0;
            //for (int i = 0; i < nums.Length - count; i++)
            //{
            //    if (nums[i] == val)
            //    {
            //        for (;i < L; L--)
            //        {
            //            if (nums[L]==val)
            //            {
            //                count++;
            //            }
            //            else
            //            {
            //                nums[i ] = nums[L];
            //                nums[L] = val;   
            //                L--;
            //                break;                          
            //            }
            //        }

            //        count++;

            //    }
            //}
            //Console.WriteLine(nums.Length - count);
            #endregion
            #region 两数之和
            //int[] numbers = new int[4] {0, 0, 3, 4 };
            //int[] count =new  int[2];
            //int target = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = i + 1; j < numbers.Length; j++)
            //    {
            //        if (numbers[i] + numbers[j] == target)
            //        {
            //            count[0] = i + 1;
            //            count[1] = j + 1;
            //            Console.WriteLine(i);
            //            Console.WriteLine(j);
            //        }
            //    }
            //}
            #endregion
            #region 实现strStr()
            //string haystack = "a";
            //string needle = "a";
            //if (needle == "")
            //{
            //    Console.WriteLine(0);
            //}
            //if (haystack.Length < needle.Length)
            //{
            //    Console.WriteLine(-1);
            //}
            //for (int i = 0; i < haystack.Length; i++)
            //{
            //    if (haystack[i]==needle[0])
            //    {
            //        if (haystack.Length-i>=needle.Length)
            //        {
            //            if (haystack.Substring(i, needle.Length) == needle)
            //                Console.WriteLine("输出:"+i);
            //        }
            //        else
            //        {
            //            Console.WriteLine(-1);
            //        }

            //    }
            //}
            //Console.WriteLine(-1);
            #endregion
            #region 搜索插入位置
            //int[] nums = new int[] { 1, 3 };
            //int target = 2;

            //Console.WriteLine(SearchInsert(nums, target));
            //Console.WriteLine(string.Format("{0:00}:{1:00}", minute, second););
            #endregion
            #region 编写质量
            //Employee mike = new Employee() { IDCode = "NB123", Age = 30, Department = new Department() { Name = "Depi" } };
            //Employee rose = mike.Clone() as Employee;
            //Console.WriteLine(rose.IDCode);
            //
            #region dynamic            
            DynamicSample dynamicSample = new DynamicSample();
            var addMethod = typeof(DynamicSample).GetMethod("Add");
            int re = (int)addMethod.Invoke(dynamicSample, new object[] { 1, 2 });
            dynamic dynamicSample2 = new DynamicSample();
            int res = dynamicSample2.Add(1, 2);

            int time = 100000;
            DynamicSample reflectSample = new DynamicSample();
            var add_Method = typeof(DynamicSample).GetMethod("Add");
            Stopwatch watch1 = Stopwatch.StartNew();
            for (var i = 0; i < time; i++)
            {
                add_Method.Invoke(reflectSample, new object[] { 1, 2 });
            }
            Console.WriteLine(string.Format("反射耗时:{0}毫秒", watch1.ElapsedMilliseconds));
            dynamic dynamicSample3 = new DynamicSample();
            Stopwatch watch2 = Stopwatch.StartNew();
            for (int i = 0; i < time; i++)
            {
                dynamicSample3.Add(1, 2);
            }
            Console.WriteLine(string.Format("dynamic耗时:{0}毫秒", watch2.ElapsedMilliseconds));

            DynamicSample reflectSampleBetter = new DynamicSample();
            var addMthod2 = typeof(DynamicSample).GetMethod("Add");
            var delg = (Func<DynamicSample, int, int, int>)Delegate.CreateDelegate(typeof(Func<DynamicSample, int, int, int>), addMthod2);
            Stopwatch watch3 = Stopwatch.StartNew();
            for (var i = 0; i < time; i++)
            {
                delg(reflectSampleBetter, 1, 2);
            }
            Console.WriteLine(string.Format("优化的反射耗时:{0}毫秒", watch3.ElapsedMilliseconds));
            #endregion
            #region 数组
            ClassForExtensions.ResizeArray();
            ClassForExtensions.ResizeList();
            #endregion
            #region 集合安全
            Thread t1 = new Thread(() =>
            {
                //确保等待t2开始之后才运行下面的代码
                autoSet.WaitOne();

                lock (syncObj)
                {
                    foreach (var item in lista)
                    {
                        Console.WriteLine("t1:" + item.Name);
                        Thread.Sleep(1000);
                    }
                }

            });
            t1.Start();
            Thread t2 = new Thread(() =>
            {
                //通知t1可以执行代码
                autoSet.Set();
                //沉睡1秒是为了确保删除操作在t1的迭代过程中
                Thread.Sleep(1000);
                lock (syncObj)
                {
                    lista.RemoveAt(2);
                    Console.WriteLine("删除成功");
                }

            });
            t2.Start();
            #endregion
            #endregion
            #region 算法
            //decimal a = 0;
            //Console.WriteLine(decimal.TryParse("",out a));
            //Console.WriteLine(a);
            //int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //Console.WriteLine(LengthOfLastWord("Hello "));
            //int[] nums = new int[] { 9 };
            //int[] nums1 = PlusOne(nums);
            //for (int i = 0; i < nums1.Length; i++)
            //{
            //    Console.WriteLine(nums1[i]);
            //}
            //int[] a = new int[] { 1, 2, 3, 0, 0, 0 };
            //int[] b = new int[] { 2, 5, 6 };
            //Merge(a, 3, b, 3);
            //int[] nums = new int[] { 1,2,2,6,5,2,8,5,2};
            //Bucket(nums);
            //Generate(3);
            //int[] price = new int[] { 7, 1, 3, 5, 9, 8, 16 };
            //string s = "race a car";
            //SolveNQueens(4);
            int[] result = { 2, 1, 1, 2 };
            Rotate(result, 3);
            Console.WriteLine(Rob(result));
            Console.WriteLine();
            //string s = "abababab";
            // RepeatedSubstringPattern(s);
            //Console.WriteLine(RepeatedSubstringPattern(s));            
            #endregion
            Console.ReadLine();
        }
        #region 算法       
        #region 查找字符串


        public static bool FindStr(string str, string[] a, int length)
        {
            bool flag = false;
            for (int i = 1; i < a.Length; i++)
            {
                if (length < a[i].Length)
                {
                    if (a[i].Substring(0, length) == str)
                    {
                        flag = true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
            return flag;
        }
        #endregion
        #region 简单数据


        public static int SingleStr(string str)
        {
            int a = 0;
            switch (str)
            {
                case "I":
                    a = 1;
                    break;
                case "V":
                    a = 5;
                    break;
                case "X":
                    a = 10;
                    break;
                case "L":
                    a = 50;
                    break;
                case "C":
                    a = 100;
                    break;
                case "D":
                    a = 500;
                    break;
                case "M":
                    a = 1000;
                    break;
                case "IV":
                    a = 4;
                    break;
                case "IX":
                    a = 9;
                    break;
                case "XL":
                    a = 40;
                    break;
                case "XC":
                    a = 90;
                    break;
                case "CD":
                    a = 400;
                    break;
                case "CM":
                    a = 900;
                    break;
                default:
                    a = 0;
                    break;
            }
            return a;
        }
        #endregion
        #region        合并两个有序的链表
        public static ListNode mergeTwoListNode(ListNode l1, ListNode l2)
        {
            ListNode prehead = new ListNode(-1);
            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }
            ListNode newlistnode = prehead;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    newlistnode.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    newlistnode.next = l2;
                    l2 = l2.next;
                }
                newlistnode = newlistnode.next;
            }
            newlistnode.next = l1 == null ? l2 : l1;
            return prehead.next;
        }

        #endregion
        #region 插入指定位置

        public static int SearchInsert(int[] nums, int target)
        {
            int n = nums.Length;
            int left = 0;
            int rigth = n - 1;
            int ans = n;
            while (left <= rigth)
            {
                int min = ((rigth - left) >> 1) + left;
                if (target <= nums[min])
                {
                    ans = min;
                    rigth = min - 1;
                }
                else
                {
                    left = min + 1;
                }
            }
            return ans;
            //int a = nums.Length;
            //if (a == 0)
            //{
            //    return 0;
            //}
            //if (nums[0] >= target)
            //{
            //    return 0;
            //}
            //if (nums[a - 1] == target)
            //{
            //    return a - 1;
            //}
            //if (nums[a - 1] < target)
            //{
            //    return a;
            //}
            //int f = (a - 1) / 2;
            //while (0 <= f && f <= a - 1)
            //{
            //    if (nums[f] < target && target <= nums[f + 1])
            //    {
            //        return f + 1;
            //    }
            //    else if (nums[f - 1] < target && target <= nums[f])
            //    {
            //        return f;
            //    }
            //    if (nums[f] < target)
            //    {
            //        f++;
            //    }
            //    else
            //    {
            //        f--;
            //    }
            //}
            //return 0;
        }
        #endregion
        #region 除数博弈
        public static bool DivisorGame(int N)
        {
            int count = 0;
            int x = N - 1;
            while (0 < x)
            {
                if (N % x == 0)
                {
                    count++;
                    N = N - x;
                    x = N - 1;
                    continue;
                }
                x--;
            }
            if (count % 2 == 0 || count == 0)
            {
                return false;
            }
            else
                return true;
        }
        #endregion
        #region 判断子序列
        public static bool IsSubsequence(string s, string t)
        {

            int a = s.Length;
            int b = t.Length;
            int i = 0;
            int j = 0;
            while (i < a && j < b)
            {
                if (s[i] == t[j])
                {
                    i++;
                }
                j++;
            }
            return i == a;
            //int a = s.Length;
            //int b = t.Length;
            //int index = 0;
            //if (b < a || b < 1)
            //{
            //    return false;
            //}
            //bool flag = false;
            //for (int i = 0; i < a; i++)
            //{

            //    string str = s.Substring(i, 1);

            //    for (int j = index; j < b; j++)
            //    {
            //        if ((b - j) < (a - i))
            //        {
            //            return false;
            //        }
            //        if (t.Substring(j, 1) == str)
            //        {
            //            flag = true;
            //            index = j+1;
            //            break;
            //        }
            //        else
            //        {
            //            flag = false;
            //        }

            //    }
            //    if (flag == false)
            //    {
            //        return false;
            //    }
            //}
            //return flag;

        }
        #endregion
        #region 二叉树最大深度
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
            }

        }
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        #endregion
        #region 最大子序和
        public static int MaxSubArray(int[] nums)
        {
            int len = nums.Length;
            if (len < 0)
            {
                return 0;
            }
            if (len == 1)
            {
                return nums[0];
            }
            int sum = nums[0];
            int result = sum;
            for (int i = 1; i < len; i++)
            {
                sum = Math.Max(sum + nums[i], nums[i]);
                result = Math.Max(result, sum);
            }
            return result;

        }
        #endregion
        #region 最后一个单词的长度
        public static int LengthOfLastWord(string s)
        {
            int len = s.Length;
            if (len < 1)
            {
                return 0;
            }
            int num = 0;
            for (int i = len - 1; i >= 0; i--)
            {
                if (s.Substring(i, 1) == " ")
                {
                    if (num == 0)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
                num++;

            }
            return num;
        }
        #endregion
        #region 魔法索引
        public int FindMagicIndex(int[] nums)
        {
            return Data(nums, 0, (int)(nums.Length - 1));
        }
        public int Data(int[] nums, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }
            int mid = left + (left + right) / 2;
            int leftData = Data(nums, left, mid - 1);
            if (leftData != -1)
            {
                return leftData;
            }
            else if (nums[mid] == mid)
            {
                return mid;
            }
            return Data(nums, mid + 1, right);
        }
        #endregion
        #region 数组加一
        public static int[] PlusOne(int[] digits)
        {
            int len = digits.Length;
            string num = "1";
            for (int i = len - 1; i >= 0; i--)
            {
                if (digits[i] == 9)
                {

                    digits[i] = 0;
                    num = num + 0;
                    if (i == 0)
                    {

                        int[] nums = new int[len + 1];
                        for (int j = 0; j < len + 1; j++)
                        {
                            nums[j] = int.Parse(num.Substring(j, 1));
                        }
                        return nums;
                    }
                }
                else
                {
                    digits[i] = digits[i] + 1;
                    break;
                }
            }
            return digits;
        }
        #endregion
        #region 二进制求和
        public static string AddBinary(string a, string b)
        {
            int len = a.Length - 1;
            int len1 = b.Length - 1;
            string result = "";
            int scale = 0;
            while (len >= 0 || len1 >= 0)
            {
                int num = 0;
                if (len >= 0)
                {
                    num += int.Parse(a.Substring(len, 1));
                }
                if (len1 >= 0)
                {
                    num += int.Parse(b.Substring(len1, 1));
                }
                num += scale;
                if (num < 2)
                {
                    result = result.Insert(0, num.ToString());
                    scale = 0;
                }
                else if (num < 3)
                {
                    result = result.Insert(0, "0");
                    scale = 1;
                }
                else
                {
                    result = result.Insert(0, "1");
                    scale = 1;
                }
                len--;
                len1--;
            }
            if (scale > 0)
            {
                result = result.Insert(0, "1");
            }
            return result;
        }
        #endregion
        #region 爬楼梯
        public static int ClimbStairs(int n)
        {
            int result = n;
            int a = 1;
            int b = 2;
            if (n <= 2)
            {
                return result;
            }
            for (int i = 3; i <= n; i++)
            {
                result = a + b;
                a = b;
                b = result;

            }
            return result;
        }
        #endregion
        #region 计数二进制子串
        public static int CountBinarySubstrings(string s)
        {
            //pre初始化为0，cur初始化为1，然后从第二个数字开始遍历，如果当前数字和前面的数字相同，则cur自增1，否则pre赋值为cur，cur重置1。然后判断如果pre大于等于cur，res自增1
            int res = 0;
            int pre = 0;
            int cur = 1;
            int n = s.Length;
            for (int i = 1; i < n; ++i)
            {
                if (s[i] == s[i - 1]) ++cur;
                else
                {
                    pre = cur;
                    cur = 1;
                }
                if (pre >= cur) ++res;
            }
            return res;
        }
        #endregion
        #region 合并两个有序数组
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] nums_copy = new int[m];
            Array.Copy(nums1, nums_copy, m);
            int one = 0;
            int two = 0;
            int num = 0;
            while ((one < m) && (two < n))
            {
                nums1[num++] = nums_copy[one] < nums2[two] ? nums_copy[one++] : nums2[two++];
            }
            if (one < m)
            {
                int i = one + two;
                while (one < m)
                {
                    nums1[i++] = nums_copy[one++];
                }
            }
            if (two < n)
            {
                int i = one + two;
                while (two < n)
                {
                    nums1[i++] = nums2[two++];
                }
            }
        }
        #endregion
        #region 有效的括弧
        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            if (s.Length % 2 != 0) return false;

            // 根据右括号做主键值映射
            Dictionary<char, char> validMapping = new Dictionary<char, char>()
                {
                    {')', '('},
                    {']', '['},
                    {'}', '{'},
                };

            // 第一下能想到的是 栈存储

            // 只存储做括号，因为括号类型比较多，单纯计数是不行的，而且需要做括号和括号的包含逻辑处理
            Stack<char> lefParentheses = new Stack<char>();
            foreach (var ch in s)
            {
                if (ch == '(' || ch == '[' || ch == '{') lefParentheses.Push(ch);
                else
                {
                    if (lefParentheses.Count == 0) return false;

                    // ([)]这种要求栈顶元素必须和当前的ch是映射关系
                    var topch = lefParentheses.Pop();
                    if (validMapping[ch] != topch) return false;
                }
            }

            return lefParentheses.Count == 0;
        }
        #endregion
        #region 遍历二叉树
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            var stack = new Stack<IList<int>>();

            if (root == null) return stack.ToList();

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);


            while (queue.Count != 0)
            {
                var list = new List<int>();
                int count = queue.Count;

                for (int i = 0; i < count; ++i)
                {
                    var node = queue.Dequeue();
                    list.Add(node.val);

                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }

                stack.Push(list);
            }

            return stack.ToList();

            //IList<IList<int>> result = new List<IList<int>>();
            ////队列用来放每一层不为null的节点
            //Queue<TreeNode> queue = new Queue<TreeNode>();
            ////用来临时存放每次更新queue前的上一层所有节点
            //Queue<TreeNode> tempQueue = new Queue<TreeNode>();

            //if (root != null)
            //{
            //    queue.Enqueue(root);
            //}
            //while (queue.Count > 0)
            //{
            //    var list = new List<int>();
            //    while (queue.Count > 0)
            //    {
            //        var element = queue.Dequeue();
            //        //逐个添加该层节点
            //        list.Add(element.val);
            //        tempQueue.Enqueue(element);
            //    }
            //    result.Add(list);
            //    while (tempQueue.Count > 0)
            //    {
            //        //放入下一层不为空的节点
            //        var element = tempQueue.Dequeue();
            //        if (element.left != null)
            //        {
            //            queue.Enqueue(element.left);
            //        }
            //        if (element.right != null)
            //        {
            //            queue.Enqueue(element.right);
            //        }
            //    }
            //}

            //return result.Reverse().ToList();
        }
        #endregion
        #region 将有序数组转换为二叉搜索树
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return TreeNodeResult(nums, 0, nums.Length - 1);
        }
        public TreeNode TreeNodeResult(int[] nums, int left, int right)
        {
            if (left > right)
            {
                return null;
            }
            //取中间位置偏左的位置
            int mid = (left + right) / 2;
            //定义返回值,根节点
            TreeNode root = new TreeNode(nums[mid]);
            root.left = TreeNodeResult(nums, left, mid - 1);
            root.right = TreeNodeResult(nums, mid + 1, right);
            return root;
        }

        #endregion
        #region 桶排序
        public static void Bucket(int[] nums)
        {
            int[] nums1 = new int[10];
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == i)
                    {
                        nums1[i]++;
                    }
                }
            }
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums1[i]; j++)
                {
                    Console.WriteLine("输出：" + i);
                }
            }
        }
        #endregion
        #region 快速排序
        int[] a = new int[] { };
        public void quicksort(int left, int right)
        {
            int i;
            int j;
            int t;
            int temp;
            if (left > right)
            {
                return;
            }
            temp = a[left];//temp中存的就是基准数
            i = left;
            j = right;
            while (i != j)
            {
                //顺序很重要，要先从右往左找
                while (a[j] >= temp && i < j)
                {
                    j--;
                }
                //再从左往右找
                while (a[i] <= temp && i < j)
                {
                    i--;
                }
                //交换两个输在数组的位置
                if (i < j)
                {
                    t = a[i];
                    a[i] = a[j];
                    a[j] = t;
                }
            }
            //最终将基准数归位
            a[left] = a[i];
            a[i] = temp;
            quicksort(left, i - 1);//继续处理左边，这里是一个递归的过程
            quicksort(i + 1, right);//继续处理右边的，这里是一个递归过程
        }
        #endregion
        #region 平衡二叉树
        public int leftTree = 0;
        public int rightTree = 0;


        public static bool IsBalanced(TreeNode root)
        {
            #region 从下倒上
            return Deep(root) >= 0;
            #endregion
            #region 从上到下        
            if (root == null)
            {
                return true;
            }
            return Math.Abs(Deep(root.left) - Deep(root.right)) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
            #endregion
        }
        public static int Deep(TreeNode treeNode)
        {
            #region 从下倒上
            if (treeNode == null)
            {
                return 0;
            }
            int leftHeight = Deep(treeNode.left);
            int rightHeight = Deep(treeNode.right);
            if (leftHeight == -1 || rightHeight == -1 || Math.Abs(leftHeight - rightHeight) > 1)
            {
                return -1;
            }
            else
            {
                return Math.Max(leftHeight, rightHeight) + 1;
            }


            #endregion

            #region 从上倒下
            //if (treeNode==null)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return Math.Max(Deep(treeNode.left), Deep(treeNode.right)) + 1;
            //}
            #endregion
        }
        #endregion
        #region 最小深度
        public static int MinDepth(TreeNode root)
        {

            #region 递归法
            if (root == null)
            {
                return 0;
            }
            if ((root.left == null) && (root.right == null))
            {
                return 1;
            }
            int min_depth = 0;
            if (root.left != null)
            {
                min_depth = Math.Min(MinDepth(root.left), min_depth);
            }
            if (root.right != null)
            {
                min_depth = Math.Min(MinDepth(root.right), min_depth);
            }

            return min_depth + 1;
            #endregion
        }
        #endregion
        #region 杨辉三角
        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> listAll = new List<IList<int>>();
            int i = 1;
            while (i <= numRows)
            {
                List<int> list = new List<int>();
                for (int j = 1; j <= i; j++)
                {
                    if (i <= 2)
                    {
                        list.Add(1);
                    }
                    else if (j == 1 || j == i)
                    {
                        list.Add(1);
                    }
                    else
                    {
                        list.Add(listAll[i - 1][j - 1] + listAll[i - 1][j]);
                    }
                }
                listAll.Add(list);
                i++;
            }

            return listAll;
        }
        #endregion
        #region 杨辉三角||
        public static IList<int> GetRow(int rowIndex)
        {
            IList<int> list = new List<int>();
            if (rowIndex >= 1)
            {
                list.Add(1);
            }
            if (rowIndex >= 2)
            {
                list.Add(1);
            }
            int i = 2;
            while (i <= rowIndex)
            {
                int v = 0;
                int y = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (j == i)
                    {
                        list.Add(1);
                    }
                    else
                    {
                        if (y == 0)
                        {
                            v = list[j];
                            list[j] = list[j] + list[j - 1];
                            y = v;
                        }
                        else
                        {
                            v = list[j];
                            list[j] = list[j] + y;
                            y = v;
                        }

                    }
                }
                i++;
            }


            return list;

        }
        #endregion
        #region 买股票最佳时机
        public static int MaxProfit(int[] prices)
        {
            /*，如果我们真的在买卖股票，我们肯定会想：如果我是在历史最低点买的股票就好了！太好了，在题目中，我们只要用一个变量记录一个历史最低价格 minprice，我们就可以假设自己的股票是在那天买的。那么我们在第 i 天卖出股票能得到的利润就是 prices[i] - minprice。

因此，我们只需要遍历价格数组一遍，记录历史最低点，然后在每一天考虑这么一个问题：如果我是在历史最低点买进的，那么我今天卖出能赚多少钱？当考虑完所有天数之时，我们就得到了最好的答案。
*/
            int minprice = int.MaxValue;
            int maxprofit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minprice)
                {
                    minprice = prices[i];
                }
                else if (prices[i] - minprice > maxprofit)
                {
                    maxprofit = prices[i] - minprice;
                }
            }
            return maxprofit;


            //int num = 0;
            //int len = prices.Length;
            //for (int i = 0; i < len; i++)
            //{
            //    for (int j = i; j < len; j++)
            //    {
            //        if (prices[i]<prices[j])
            //        {
            //            num = (prices[j] - prices[i])>num? prices[j] - prices[i]:num;
            //        }
            //    }
            //}
            //return num;
        }
        #endregion
        #region 重复子字符串
        public static bool RepeatedSubstringPattern(string s)
        {
            int n = s.Length;
            for (int i = 1; i * 2 <= n; ++i)
            {
                if (n % i == 0)
                {
                    bool match = true;
                    for (int j = i; j < n; ++j)
                    {
                        if (s[j] != s[j - i])
                        {
                            match = false;
                            break;
                        }
                    }
                    if (match)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        #endregion
        #region 买股票的最佳时机||
        public static int maxProfit2(int[] prices)
        {
            #region 改进峰值法
            int maxprofit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    maxprofit += prices[i] - prices[i - 1];
                }
            }
            return maxprofit;
            #endregion
            #region 峰值法
            //int i = 0;
            //int valley = prices[0];
            //int peak = prices[0];
            //int maxprofit = 0;
            //while (i<prices.Length-1)
            //{
            //    while (i<prices.Length-1&&prices[i]>=prices[i+1])
            //    {
            //        i++;
            //    }
            //    valley = prices[i];
            //    while (i<prices.Length-1&&prices[i]<=prices[i+1])
            //    {
            //        i++;
            //    }
            //    peak = prices[i];
            //    maxprofit += peak - valley;
            //}
            //return maxprofit;
            #endregion


            //return calculate(prices, 0);
        }
        /// <summary>
        /// 暴力
        /// </summary>
        /// <param name="prices"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public int calculate(int[] prices, int s)
        {
            if (s >= prices.Length)
            {
                return 0;
            }
            int max = 0;
            for (int start = s; start < prices.Length; start++)
            {
                int maxprofit = 0;
                for (int i = start + 1; i < prices.Length; i++)
                {
                    if (prices[start] < prices[i])
                    {
                        int profit = calculate(prices, i + 1) + prices[i] - prices[start];
                        if (profit > maxprofit)
                        {
                            maxprofit = profit;
                        }
                    }
                    if (maxprofit > max)
                    {
                        max = maxprofit;
                    }
                }
            }
            return max;
        }

        #endregion
        #region 验证回文串
        public static bool IsPalindrome(string s)
        {
            s = s.Trim();
            s = s.ToLower();
            int left = 0;
            int right = s.Length - 1;
            string patternInt = @"^\d*$";
            string patternStr = @"^[A-Za-z]+$";
            bool flag = true;
            while (left < right)
            {
                while (!IsChar(s[left]) && left < right)
                {
                    ++left;
                    if (left > right)
                    {
                        return false;
                    }
                }
                while (!IsChar(s[right]) && left < right)
                {
                    --right;

                }
                if (left < right)
                {
                    if (s[left] != s[right])
                    {
                        return false;
                    }
                    left++;
                    right--;
                }
            }


            return flag;
        }
        private static bool IsChar(char c)
        {
            int num = (int)c;
            if (num >= 48 && num <= 57)
                return true;
            if (num >= 65 && num <= 90)
                return true;
            if (num >= 97 && num <= 122)
                return true;
            return false;
        }
        #endregion
        #region 电话号码的字母组合
        public IList<string> LetterCombinations(string digits)
        {
            int i = 0;
            int num = digits.Length;
            IList<string> list = new List<string>();
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>() {
                { "2",new List<string>{ "a","b","c" } },
                { "3",new List<string>{ "d","e","f"}  },
                { "4",new List<string>{ "g", "h", "i" } },
                { "5",new List<string>{ "j", "k", "l" } },
                { "6",new List<string>{ "m", "n", "o" } },
                { "7",new List<string>{ "p", "q", "s" } },
                { "8",new List<string>{ "t", "u", "v" } },
                { "9",new List<string>{ "w", "x", "y", "z" } }
            };
            while (i < num)
            {

            }

            return list;
        }
        #endregion
        #region 只出现一次的数字
        public int SingleNumber(int[] nums)
        {
            int num = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                num ^= nums[i];
            }
            return num;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    bool flag = false;
            //    if (nums[i]==int.MinValue)
            //    {
            //        continue;
            //    }
            //    for (int j = i+1; j < nums.Length; j++)
            //    {
            //        if (nums[j]==int.MinValue)
            //        {
            //            continue;
            //        }
            //        if (nums[i]==nums[j])
            //        {
            //            nums[i] = int.MinValue;
            //            nums[j] = int.MinValue;
            //            flag = true;
            //            break;
            //        }
            //    }
            //    if (!flag)
            //    {
            //        return nums[i];
            //    }
            //}
            //return 0;
        }
        #endregion
        #region 环形链表
        public bool hasCycle(ListNode head)
        {
            #region 哈希表


            //HashSet<ListNode> nodes = new HashSet<ListNode>();
            //while (head!=null)
            //{
            //    if (nodes.Contains(head))
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        nodes.Add(head);
            //    }
            //    head=head.next;
            //}
            //return false;
            #endregion
            #region 双指针
            /*通过使用具有 不同速度 的快、慢两个指针遍历链表，空间复杂度可以被降低至 
             * O(1)O(1)O(1)。慢指针每次移动一步，而快指针每次移动两步。如果列表中不
             * 存在环，最终快指针将会最先到达尾部，此时我们可以返回 false。现在考虑一
             * 个环形链表，把慢指针和快指针想象成两个在环形赛道上跑步的运动员  
             * （分别称之为慢跑者与快跑者）。而快跑者最终一定会追上慢跑者。这是为什么呢？
             * 考虑下面这种情况（记作情况 A）- 假如快跑者只落后慢跑者一步，在下一次迭代中，
             * 它们就会分别跑了一步或两步并相遇。其他情况又会怎样呢？例如，我们没有考虑快
             * 跑者在慢跑者之后两步或三步的情况。 其实不难想到，因为在下一次或者下下次迭代后
             * ，又会变成上面提到的情况 A。
*/
            if (head == null || head.next == null)
            {
                return false;
            }
            ListNode slow = head;
            ListNode fast = head.next;
            while (slow != fast)
            {
                if (fast == null || fast.next == null)
                {
                    return false;
                }
                slow = slow.next;
                fast = fast.next.next;
            }
            return true;
            #endregion
        }
        #endregion
        #region 机器人是否回到原点
        public bool JudgeCircle(string moves)
        {
            //垂直
            int vertical = 0;
            //水平
            int level = 0;
            int i = 0;
            while (i < moves.Length)
            {
                switch (moves[i])
                {
                    case 'U':
                        vertical++;
                        break;
                    case 'L':
                        level++;
                        break;
                    case 'D':
                        vertical--;
                        break;
                    case 'R':
                        level--;
                        break;
                }
                i++;
            }
            return vertical == 0 && level == 0;
        }


        #endregion
        #region 最短回文串
        public static string ShortestPalindrome(string s)
        {
            List<char> list = new List<char>();
            string before = "";
            int start = 0;
            int end = s.Length - 1;
            while (start < end)
            {
                if (s[start] != s[end])
                {
                    end--;
                    before = before + s[end];
                }
                else
                {
                    start++;
                    end--;
                }
            }
            return before + s;
        }
        #endregion
        #region 相交链表
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
            {
                return null;
            }
            ListNode pA = headA;
            ListNode pB = headB;
            while (pA != pB)
            {
                pA = pA == null ? headB : pA.next;
                pB = pB == null ? headA : pB.next;
            }
            return pA;

        }
        #endregion
        #region 钥匙和房间
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            return false;
        }
        #endregion
        #region Excel列表名称
        public static string ConvertToTitle(int n)
        {
            string[] array = new string[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            System.Text.StringBuilder result = new System.Text.StringBuilder();
            while (n > 0)
            {
                // n -= 1;
                int a = n / 26;
                int b = n % 26;
                if (b == 0)
                {
                    b = 26;
                    n -= 1;
                }
                result.Insert(0, array[b - 1]);
                n = n / 26;
            }
            //if (n<=26)
            //{
            //    result = array[n-1];
            //}
            //else 
            //{
            //    int a = 0;
            //    if (n % 26 == 0)
            //    {
            //        a = 26;
            //        n = n - 26;
            //    }
            //    else
            //    {
            //        a = n % 26;
            //    }
            //    while (n/26>26)
            //    {
            //        result += "A";
            //        n = n / 26;
            //    }
            //    if (n % 26 == 0)
            //    {
            //        result= result+array[n/26 - 1] + array[a-1];
            //    }
            //    else if(n<52)
            //    {
            //        result = result + array[n - 26 - 1] + array[a-1];
            //    }
            //    else
            //    {
            //        result = result + array[n / 26 - 1] + array[a - 1];
            //    }

            //}
            return result.ToString();
        }
        #endregion
        #region 多数元素
        public int MajorityElement(int[] nums)
        {
            #region 随机法
            Random rand = new Random();
            int mCount = nums.Length / 2;
            while (true)
            {
                int candidate = nums[randRange(rand, 0, nums.Length)];
                if (countOccurences(nums, candidate) > mCount)
                {
                    return candidate;
                }
            }

            #endregion
            #region p排序法


            //Array.Sort(nums);
            //return nums[nums.Length/2];
            #endregion
            //System.Collections.Hashtable keyValues = new System.Collections.h();
            //foreach (int item in nums)
            //{
            //    if (keyValues.ContainsKey(item))
            //    {
            //        keyValues.Add(item, 1);
            //    }
            //    else
            //    {
            //        keyValues.Add(item,keyValues.ite(item)+1);
            //    }
            //}
            //return 0;
        }
        private int randRange(Random rand, int min, int max)
        {
            return rand.Next(max - min) + min;
        }
        private int countOccurences(int[] nums, int num)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == num)
                {
                    count++;
                }
            }
            return count;
        }
        #endregion
        #region 表示数值的字符串
        enum Dp
        {
            Start,//可以进入E以外的任意状态
            Symbol,//首位的符号位,可以进入Number状态或FP状态
            Number,//数字,可以进入E状态或者Point状态
            E,//可以进入AE状态
            ES,//E后的第一个符号位,可以进入AE
            AE,//After E,捕获任意数字后退出
            Point,//可以进入E状态,捕获任意数字后退出
            FP,//首位是小数点,奇怪的状态增加了
        };

        public bool IsNumber(string s)
        {
            //朴素的思路就是判断符不符合规范，不符合直接False
            s = s.Trim();
            if (string.IsNullOrEmpty(s)) return false;
            char[] number = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char[] symbol = new char[] { '+', '-' };
            char[] e = new char[] { 'E', 'e' };
            Dp dp = Dp.Start;//状态
                             //朴素的状态机
            foreach (char i in s)
            {
                switch (dp)
                {
                    case Dp.Start:
                        if (symbol.Contains(i)) dp = Dp.Symbol;
                        else if (number.Contains(i)) dp = Dp.Number;
                        else if ('.'.Equals(i)) dp = Dp.FP;
                        else return false;
                        break;
                    case Dp.Symbol:
                        if (number.Contains(i)) dp = Dp.Number;
                        else if ('.'.Equals(i)) dp = Dp.FP;
                        else return false;
                        break;
                    case Dp.Number:
                        if (number.Contains(i)) break;//数字状态的延续
                        else if (e.Contains(i)) dp = Dp.E;
                        else if ('.'.Equals(i)) dp = Dp.Point;
                        else return false;
                        break;
                    case Dp.E:
                        if (symbol.Contains(i)) dp = Dp.ES;//e后第一位可以是符号位
                        else if (number.Contains(i)) dp = Dp.AE;
                        else return false;
                        break;
                    case Dp.ES:
                        if (number.Contains(i)) dp = Dp.AE;
                        else return false;
                        break;
                    case Dp.AE:
                        if (number.Contains(i)) break;//AE的延续
                        else return false;
                        break;
                    case Dp.Point:
                        if (number.Contains(i)) break;//Point的延续
                        else if (e.Contains(i)) dp = Dp.E;
                        else return false;
                        break;
                    case Dp.FP:
                        if (number.Contains(i)) dp = Dp.Point;//进入Point
                        else return false;
                        break;
                }

            }
            if (dp == Dp.E || dp == Dp.Symbol || dp == Dp.ES || dp == Dp.FP) return false;
            return true;
        }
        //public static bool IsNumber(string s)
        //{
        //    Dictionary<State, Dictionary<CharType, State>> transfer = new Dictionary<State, Dictionary<CharType, State>>();
        //    Dictionary<CharType, State> initialMap = new Dictionary<CharType, State>();
        //    initialMap.Add(CharType.CHAR_SPACE, State.STATE_INITIAL);
        //    initialMap.Add(CharType.CHAR_NUMBER, State.STATE_INTEGER);
        //    initialMap.Add(CharType.CHAR_POINT, State.STATE_POINT_WITHOUT_INT);
        //    initialMap.Add(CharType.CHAR_SIGN, State.STATE_INT_SIGN);
        //    transfer.Add(State.STATE_INITIAL, initialMap);

        //    Dictionary<CharType, State> intSignMap = new Dictionary<CharType, State>();
        //    intSignMap.Add(CharType.CHAR_NUMBER, State.STATE_INTEGER);
        //    intSignMap.Add(CharType.CHAR_POINT, State.STATE_POINT_WITHOUT_INT);
        //    transfer.Add(State.STATE_INT_SIGN, initialMap);



        //    Dictionary<CharType, State> integerMap = new Dictionary<CharType, State>();
        //    integerMap.Add(CharType.CHAR_NUMBER, State.STATE_INTEGER);
        //    integerMap.Add(CharType.CHAR_EXP, State.STATE_EXP);
        //    integerMap.Add(CharType.CHAR_POINT, State.STATE_POINT);
        //    integerMap.Add(CharType.CHAR_SPACE, State.STATE_END);
        //    transfer.Add(State.STATE_INTEGER, integerMap);

        //    Dictionary<CharType, State> pointMap = new Dictionary<CharType, State>();
        //    pointMap.Add(CharType.CHAR_NUMBER, State.STATE_FRACTION);
        //    pointMap.Add(CharType.CHAR_EXP, State.STATE_EXP);
        //    pointMap.Add(CharType.CHAR_SPACE, State.STATE_END);
        //    transfer.Add(State.STATE_POINT, pointMap);


        //    Dictionary<CharType, State> pointWithoutIntMap = new Dictionary<CharType, State>();
        //    pointWithoutIntMap.Add(CharType.CHAR_NUMBER, State.STATE_FRACTION);
        //    transfer.Add(State.STATE_POINT_WITHOUT_INT, pointWithoutIntMap);

        //    Dictionary<CharType, State> fractionMap = new Dictionary<CharType, State>();
        //    fractionMap.Add(CharType.CHAR_NUMBER, State.STATE_FRACTION);
        //    fractionMap.Add(CharType.CHAR_EXP, State.STATE_EXP);
        //    fractionMap.Add(CharType.CHAR_SPACE, State.STATE_END);
        //    transfer.Add(State.STATE_FRACTION, fractionMap);

        //    Dictionary<CharType, State> expMap = new Dictionary<CharType, State>();
        //    expMap.Add(CharType.CHAR_NUMBER, State.STATE_EXP_NUMBER);
        //    expMap.Add(CharType.CHAR_SIGN, State.STATE_EXP_SIGN);
        //    transfer.Add(State.STATE_EXP, expMap);


        //    Dictionary<CharType, State> expNumberMap = new Dictionary<CharType, State>();
        //    expNumberMap.Add(CharType.CHAR_NUMBER, State.STATE_EXP_NUMBER);
        //    expNumberMap.Add(CharType.CHAR_SPACE, State.STATE_END);
        //    transfer.Add(State.STATE_EXP_NUMBER, expNumberMap);

        //    Dictionary<CharType, State> endMap = new Dictionary<CharType, State>();
        //    endMap.Add(CharType.CHAR_SPACE, State.STATE_END);
        //    transfer.Add(State.STATE_END, endMap);

        //    int len = s.Length;
        //    State state = State.STATE_INITIAL;      
        //    Dictionary<CharType, State> sb;
        //    for (int i = 0; i < len; i++)
        //    {
        //        CharType type = toCharType(s[i]);
        //        transfer.TryGetValue(state, out sb);
        //        if (!sb.ContainsKey(type))
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            sb.TryGetValue(type,out state);
        //        }
        //    }

        //    return state == State.STATE_INTEGER || state == State.STATE_POINT || state == State.STATE_FRACTION || state == State.STATE_EXP_NUMBER || state == State.STATE_END;


        //}
        //public enum State
        //{
        //    STATE_INITIAL,
        //    STATE_INT_SIGN,
        //    STATE_INTEGER,
        //    STATE_POINT,
        //    STATE_POINT_WITHOUT_INT,
        //    STATE_FRACTION,
        //    STATE_EXP,
        //    STATE_EXP_SIGN,
        //    STATE_EXP_NUMBER,
        //    STATE_END,
        //}
        //public enum CharType
        //{
        //    CHAR_NUMBER,
        //    CHAR_EXP,
        //    CHAR_POINT,
        //    CHAR_SIGN,
        //    CHAR_SPACE,
        //    CHAR_ILLEGAL,
        //}
        //public static CharType toCharType(char ch)
        //{
        //    if (ch >= '0' && ch <= '9')
        //    {
        //        return CharType.CHAR_NUMBER;
        //    }
        //    else if (ch == 'e' || ch == 'E')
        //    {
        //        return CharType.CHAR_EXP;
        //    }
        //    else if (ch == '.')
        //    {
        //        return CharType.CHAR_POINT;
        //    }
        //    else if (ch == '+' || ch == '-')
        //    {
        //        return CharType.CHAR_SIGN;
        //    }
        //    else if (ch == ' ')
        //    {
        //        return CharType.CHAR_SPACE;
        //    }
        //    else
        //    {
        //        return CharType.CHAR_ILLEGAL;
        //    }
        //}
        #endregion
        #region Excel序号
        public static int TitleToNumber(string s)
        {
            char[] array = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            int n = s.Length - 1;
            int i = 0;
            int a = 0;
            while (i < s.Length)
            {
                int p = Array.IndexOf(array, s[i]);
                a = (int)(a + (Math.Pow(26.0, n) * (p + 1)));
                i++;
                n--;
            }
            return a;
        }
        #endregion
        #region N皇后
        //回溯法
        public static IList<IList<string>> SolveNQueens(int n)
        {
            IList<IList<string>> res = new List<IList<string>>();
            char[][] chess = new char[n][];
            for (int i = 0; i < n; i++)
            {
                chess[i] = new char[n];
                for (int j = 0; j < n; j++)
                {
                    chess[i][j] = '.';
                }
            }
            backtrack(chess, 0, res);
            return res;
        }
        private static void backtrack(char[][] chess, int row, IList<IList<string>> res)
        {
            //终止条件，最后一行都走完了,说明找到了最后一组，把它加入集合res
            if (row == chess.Length)
            {
                res.Add(construct(chess));
                return;
            }
            int n = chess.Length;
            for (int i = 0; i < n; i++)
            {
                if (isValid(chess, row, i))
                {
                    continue;
                    //复制数组
                    //copy(chess);
                    chess[row][i] = 'Q';
                    backtrack(chess, row + 1, res);
                    chess[row][i] = '.';
                }
            }
        }
        private static char[][] copy(char[][] chess)
        {
            char[][] temp = new char[chess.Length][];
            Array.Copy(chess, temp, chess.Length);
            //for (int i = 0; i < chess.Length; i++)
            //{
            //    for (int j = 0; j < chess.Length; j++)
            //    {
            //        temp[i, j] = chess[i, j];
            //    }
            //}
            return temp;
        }

        /// <summary>
        /// 判断queue
        /// </summary>
        /// <returns></returns>
        private static bool isValid(char[][] chess, int row, int col)
        {
            //判断当前有没有皇后，因为它是一行行向下遍历
            //只需检查走过的行数即可
            int n = chess.Length;
            //检查同列
            for (int i = 0; i < row; i++)
            {
                if (chess[i][col] == 'Q')
                {
                    return false;
                }
            }
            //右上
            for (int i = row - 1, j = col + 1; i >= 0 && j < n; i--, j++)
            {
                if (chess[i][j] == 'Q')
                {
                    return false;
                }
            }
            //左上
            for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (chess[i][j] == 'Q')
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// 数组转化list
        /// </summary>
        /// <param name="chess"></param>
        /// <returns></returns>
        private static List<string> construct(char[][] chess)
        {
            List<string> path = new List<string>();
            for (int i = 0; i < chess.Length; i++)
            {
                string a = "";
                for (int j = 0; j < chess.Length; j++)
                {
                    a.Append(chess[i][j]);
                }
                path.Add(a);
            }
            return path;
        }
        #endregion
        #region 阶乘后的零
        public static int TrailingZeroes(int n)
        {
            int num = 0;
            while (n > 0)
            {
                num += n / 5;
                n = n / 5;
            }
            return num;


            //Int64 a = 1;
            //int result = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    a = a * i;
            //}
            //string s = a.ToString();
            //for (int i =s.Length-1; i >0 ; i--)
            //{
            //    if (s[i]=='0')
            //    {
            //        result++;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //return result;
        }
        #endregion
        #region 二叉树的所有路径
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            #region 深度优先搜索
            //List<string> paths = new List<string>();
            //constructPaths(root,"",paths);
            //return paths;
            #endregion
            #region MyRegion
            List<string> paths = new List<string>();
            if (root == null)
            {
                return paths;
            }
            Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
            Queue<string> pathQueue = new Queue<string>();
            nodeQueue.Enqueue(root);
            pathQueue.Enqueue(root.val.ToString());
            while (!(nodeQueue.Count < 1))
            {
                TreeNode node = nodeQueue.Dequeue();
                string path = pathQueue.Dequeue();
                if (node.left == null && node.right == null)
                {
                    paths.Add(path);
                }
                else
                {
                    if (node.left != null)
                    {
                        nodeQueue.Enqueue(node.left);
                        pathQueue.Enqueue(new StringBuilder(path).Append(node.left.val).ToString());
                    }
                }
                if (node.right != null)
                {
                    nodeQueue.Enqueue(node.right);
                    pathQueue.Enqueue(new StringBuilder(path).Append(node.right.val).ToString());
                }
            }
            return paths;
            #endregion
        }
        private void constructPaths(TreeNode root, string path, List<string> paths)
        {
            if (root != null)
            {
                StringBuilder pathSB = new StringBuilder(path);
                pathSB.Append(root.val.ToString());//转化string
                if (root.left == null && root.right == null)//当前节点是叶子节点
                {
                    paths.Add(pathSB.ToString());//把路径加入答案中
                }
                else
                {
                    pathSB.Append("->");//当前节点不是叶子节点
                    constructPaths(root.left, pathSB.ToString(), paths);
                    constructPaths(root.right, pathSB.ToString(), paths);
                }

            }
        }
        #endregion
        #region 第k个排列
        public static string getPermutation(int n, int k)
        {
            //定义数组
            int[] factorial = new int[n];
            factorial[0] = 1;
            for (int i = 1; i < n; ++i)
            {
                factorial[i] = factorial[i - 1] * i;
            }
            --k;
            StringBuilder sb = new StringBuilder();
            int[] valid = new int[n + 1];
            Array.Fill(valid, 1);
            for (int i = 1; i <= n; ++i)
            {
                int order = k / factorial[n - i] + 1;
                for (int j = 1; j <= n; ++j)
                {
                    order -= valid[j];
                    if (order == 0)
                    {
                        sb.Append(j);
                        valid[j] = 0;
                        break;
                    }
                }
                k %= factorial[n - i];
            }
            return sb.ToString();
        }
        #endregion
        #region 前K个高频元素
        public static int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int value = 0;
                if (dic.ContainsKey(nums[i]))
                {
                    dic.TryGetValue(nums[i], out value);
                    dic.Remove(nums[i]);
                    dic.Add(nums[i], value + 1);
                }
                else
                {
                    dic.Add(nums[i], 1);
                }
            }
            var a = from p in dic orderby p.Value descending select p;
            List<int> result = new List<int>();
            foreach (KeyValuePair<int, int> item in a)
            {
                if (k > 0)
                {
                    result.Add(item.Key);
                }
                k--;
            }
            return result.ToArray();
        }
        #endregion
        #region 旋转数组
        public static void Rotate(int[] nums, int k)
        {
            #region 反转
            /* public void rotate(int[] nums, int k) {
        k %= nums.length;
        reverse(nums, 0, nums.length - 1);
        reverse(nums, 0, k - 1);
        reverse(nums, k, nums.length - 1);
    }
    public void reverse(int[] nums, int start, int end) {
        while (start < end) {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }*/
            #endregion
            #region 环状替换
            //int num = nums.Length - 1;
            //k = k % nums.Length;
            //int count = 0;
            //for (int start  = 0; start < nums.Length; start++)
            //{
            //    int current = start;
            //    int prev = nums[start];
            //    do
            //    {
            //        int next = (current + k) % nums.Length;
            //        int temp = nums[next];
            //        nums[next] = prev;
            //        prev = temp;
            //        current = next;
            //        count++;
            //    } while (start!=current);
            //int temp = 0;


            #endregion
            #region 暴力解      
            //int a = 0;
            //int num = nums.Length-1;
            //for (int i = 0; i < k; i++)
            //{
            //    a = nums[num];
            //    for (int j = num; j >= 0; j--)
            //    {
            //        if (j!=0)
            //        {
            //            nums[j] = nums[j - 1];
            //        }
            //        else
            //        {
            //            nums[0] = a;
            //        }

            //    }    

            //}
            #endregion
        }
        #endregion
        #region 组合
        List<IList<int>> result = new List<IList<int>>();
        List<int> nums = new List<int>();
        public IList<IList<int>> Combine(int n, int k)
        {

            dfs(1, n, k);
            return result;
        }
        public void dfs(int cur, int n, int k)
        {
            //剪枝：temp长度加上区间[cur,n]的长度小于k，不同于长度为k的temp
            if (nums.Count + (n - cur + 1) < k)
            {
                return;
            }
            //记录合法的答案
            if (nums.Count == k)
            {
                result.Add(nums);
                return;
            }
            //考虑当前位置
            nums.Add(cur);
            dfs(cur + 1, n, k);
            nums.Remove(nums.Count - 1);
            //考虑不选择当前位置
            dfs(cur + 1, n, k);

        }

        #endregion
        #region 颠倒二进制位
        public static uint reverseBits(uint n)
        {
            uint result = 0;
            for (int i = 0; i < 32; i++)
            {
                result += ((n & (1U << (31 - i))) != 0 ? 1U << i : 0);
            }
            return result;
        }
        #endregion
        #region 位1的数
        public int HammingWeight(uint n)
        {
            int num = 0;
            while (n != 0)
            {
                num++;
                n &= (n - 1);

            }
            //uint mask = 1;
            //for (int i = 0; i < 32; i++)
            //{
            //    if ((n&mask)!=0)
            //    {
            //        num++;
            //    }
            //    mask <<= 1;
            //}
            return num;
        }
        #endregion
        #region  组合总和 II
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            List<IList<int>> result = new List<IList<int>>();
            List<int> nums = new List<int>();
            //关键步骤
            Array.Sort(candidates);
            dfs(0, target, result, candidates, nums);
            return result;
        }
        private void dfs(int index, int target, List<IList<int>> result, int[] candidates, List<int> nums)
        {
            if (target == 0)
            {
                if (!result.Contains(nums))
                {
                    result.Add(new List<int>(nums));
                }
                return;
            }
            else
            {
                for (int i = index; i < candidates.Length; i++)
                {
                    if (candidates[i] > target)
                    {
                        break;
                    }
                    nums.Add(candidates[i]);
                    dfs(i + 1, target - candidates[i], result, candidates, nums);
                    nums.RemoveAt(nums.Count - 1);
                    while (i < candidates.Length && candidates[i] == candidates[i + 1])
                    {
                        i++;
                    }
                }
            }

        }

        #endregion
        #region 二叉树的层平均值
        public IList<double> AverageOfLevels(TreeNode root)
        {
            //深度优先搜索
            List<double> result = new List<double>();
            //List<TreeNode> root = new List<TreeNode>();
            List<int> counts = new List<int>();
            dfs(root, 0, counts, result);
            List<double> averages = new List<double>();
            int size = result.Count();
            #region 广度优先搜索
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (!(queue.Count() != 0))
            {
                double sum = 0;
                int len = queue.Count();
                for (int i = 0; i < len; i++)
                {
                    TreeNode node = queue.Peek();
                    sum += node.val;
                    TreeNode left = node.left;
                    TreeNode right = node.right;
                    if (left != null)
                    {
                        queue.Enqueue(left);
                    }
                    if (right != null)
                    {
                        queue.Enqueue(right);
                    }
                }
            }
            #endregion
            for (int i = 0; i < size; i++)
            {
                averages.Add(result[i] / counts[i]);
            }
            return averages;

        }
        public void dfs(TreeNode root, int level, List<int> counts, List<double> sums)
        {
            if (root == null)
            {
                return;
            }
            if (level < sums.Count())
            {
                sums[level] = sums[level] + root.val;
                counts[level] = counts[level] + 1;
            }
            else
            {
                sums.Add(1.0 * root.val);
                counts.Add(1);
            }
            dfs(root.left, level + 1, counts, sums);
            dfs(root.right, level + 1, counts, sums);
        }
        #endregion
        #region 二叉树的中序遍历
        public List<int> inorderTraversal(TreeNode root)
        {
            List<int> res = new List<int>();

            return res;
        }
        public void inorder(TreeNode root, List<int> res)
        {
            if (root == null)
            {
                return;
            }
            inorder(root.left, res);
            res.Add(root.val);
            inorder(root.right, res);
        }
        #endregion
        #region 解数独
        public void SolveSudoku(char[][] board)
        {

        }
        #endregion
        #region 翻转二叉树
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return root;
            }
            TreeNode left = InvertTree(root.left);
            TreeNode right = InvertTree(root.right);
            root.left = right;
            root.right = left;
            return root;

        }
        #endregion
        #region 打家劫舍
        public static int Rob(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {

                return 0;
            }
            int len = nums.Length;
            if (len == 1)
            {
                return nums[0];
            }
            int first = nums[0];
            int second = Math.Max(first, nums[1]);
            for (int i = 2; i < len; i++)
            {
                int temp = second;
                second = Math.Max(first + nums[i], second);
                first = temp;
            }
            return second;
            //int len = nums.Length;
            //int result = 0;
            //int n = 0;
            //while (n<2)
            //{
            //    int sum = 0;
            //    for (int i = 0; i < len; i += 2)
            //    {
            //        sum += nums[i];
            //    }
            //    if (sum>result)
            //    {
            //        result = sum;
            //    }
            //    n++;
            //}

            //return result;
        }
        #endregion
        #region 快乐数
        public bool IsHappy(int n)
        {
            HashSet<int> seen = new HashSet<int>();
            while (n != 1 && !seen.Contains(n))
            {
                seen.Add(n);
                n = getNext(n);
            }
            return n == 1;
        }
        private int getNext(int n)
        {
            int totalSum = 0;
            while (n > 0)
            {
                int d = n % 10;
                n = n / 10;
                totalSum += d * d;
            }
            return totalSum;
        }
        #endregion
        #region 移除链表元素
        public ListNode RemoveElements(ListNode head, int val)
        {
            //新建一个哨兵
            ListNode sendinel = new ListNode(0);
            sendinel.next = head;
            ListNode prev = sendinel;
            ListNode curr = head;
            while (curr != null)
            {
                if (curr.val == val)
                {
                    prev.next = curr.next;
                }
                else
                {
                    prev = curr.next;
                }
                curr = curr.next;
            }
            return sendinel.next;
        }
        #endregion
        #region 全排列 II
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            Array.Sort(nums);
            if (nums.Length == 0)
            {
                return new List<IList<int>>();
            }
            List<IList<int>> res = new List<IList<int>>();
            List<int> temp = new List<int>();
            int[] flag = new int[nums.Length];
            for (int i = 0; i < flag.Length; ++i)
            {
                flag[i]=0;
            }
            dfs(ref res,nums,flag,temp);
            return res;

        }
        private void dfs(ref List<IList<int>> res, int[] nums, int[] flag,List<int>temp)
        {
            if (temp.Count==nums.Length)
            {
                res.Add(new List<int>(temp));
                return;
            }
            for (int i = 0; i < nums.Length;++i)
            {
                if (flag[i]==1)
                {
                    continue;
                }
                flag[i] = 1;
                temp.Add(nums[i]);
                dfs(ref res,nums,flag,temp);
                temp.RemoveAt(temp.Count - 1);
                flag[i] = 0;
                while (i<nums.Length-1&&nums[i+1]==nums[i])
                {
                    i++;
                }
            }
        }
        #endregion
        #region 左叶子之和
        public int SumOfLeftLeaves(TreeNode root)
        {
            int result = 0;
            if (root==null)
            {
                return 0;
            }
            result += root.left.val;
            return result;
        }
        #endregion
    }
    #region 最小栈
    public class MinStack
    {
        Stack<int> x_stack;
        Stack<int> min_stack;
        /** initialize your data structure here. */
        public MinStack()
        {
            min_stack.Push(int.MaxValue);
        }

        public void Push(int x)
        {
            x_stack.Push(x);
            min_stack.Push(Math.Min(min_stack.Peek(), x));
        }

        public void Pop()
        {
            x_stack.Pop();
            min_stack.Pop();
        }

        public int Top()
        {
            return x_stack.Peek();
        }

        public int GetMin()
        {
            return min_stack.Peek();
        }

    }
    #endregion
    #region MyRegion


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val)
        {
            this.val = val;
        }
    }
    #endregion
    #endregion

    #region 编写质量
    #region 正确实现浅拷贝和深拷贝
    [Serializable]
    class Employee : ICloneable
    {
        public string IDCode { get; set; }
        public int Age { get; set; }
        public Department Department { get; set; }
        #region ICloneable 成员
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        //深拷贝
        public Employee DeepClone()
        {
            using (Stream objectStream = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(objectStream, this);
                objectStream.Seek(0, SeekOrigin.Begin);
                return formatter.Deserialize(objectStream) as Employee;
            }
        }
        public Employee ShallowClone()
        {
            return Clone() as Employee;
        }

    }
    class Department
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
        #endregion
    }
    #endregion
    #region 使用dynamic /daɪˈnæmɪk/
    /*var是语法糖,支持智能感知，编译时实际类
     * 型来替换该变量，dynamic是到运行时解析*/
    public class DynamicSample
    {
        public string Name { get; set; }
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    #endregion
    #region 元素数量可变的情况下不要使用数组
    class ArrayLZ
    {
        public void a()
        {
            int[] iArr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            ArrayList arrayList = ArrayList.Adapter(iArr);//数组转换ArrayList
            arrayList.Add(7);
            List<int> list = iArr.ToList<int>();//将数组转换List<T>
            list.Add(8);
            iArr = (int[])iArr.Resize(10);


        }
    }
    //ReSize
    public static class ClassForExtensions
    {
        public static Array Resize(this Array array, int newSize)
        {
            Type t = array.GetType().GetElementType();
            Array newArray = Array.CreateInstance(t, newSize);
            Array.Copy(array, 0, newArray, 0, Math.Min(array.Length, newSize));
            return newArray;
        }
        //测试速度
        public static void ResizeArray()
        {
            int[] iArr = { 0, 1, 2, 3, 4, 5, 6 };
            Stopwatch watch1 = new Stopwatch();
            watch1.Start();
            iArr = (int[])iArr.Resize(10);
            watch1.Stop();
            Console.WriteLine("ResizeArray：" + watch1.Elapsed);
        }
        public static void ResizeList()
        {
            List<int> iArr = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6 });
            Stopwatch watch2 = new Stopwatch();
            watch2.Start();
            iArr.Add(0);
            iArr.Add(0);
            iArr.Add(0);
            watch2.Stop();
            Console.WriteLine("ResizeList:" + watch2.Elapsed);

        }
    }

    #endregion
    #region 多数情况下使用foreach,for索引器，foreach迭代器
    //迭代器模式
    public class Iterator
    {
        public void IteratorA()
        {
            //使用接口IMyEnumerable代替MyList
            IMyEnumerable list = new MyList();
            //得到迭代器，再循环中针对迭代器编码，而不是集合MyList
            IMyEnumerator enumerator = list.GetMyEnumerator();
            for (int i = 0; i < list.Count; i++)
            {
                object current = enumerator.Current;
                enumerator.MoveNext();
            }
            while (enumerator.MoveNext())
            {
                object current = enumerator.Current;
            }
        }
        /// <summary>
        /// 要求所有迭代器全部实现该接口
        /// </summary>
        interface IMyEnumerator
        {
            bool MoveNext();
            object Current { get; }
        }

        /// <summary>
        /// 要求所有的集合实现该接口
        /// 这样客户端就可以针对该接口编码
        /// 而无需关注集体实现
        /// </summary>
        interface IMyEnumerable
        {
            IMyEnumerator GetMyEnumerator();
            int Count { get; }
        }
        class MyList : IMyEnumerable
        {
            object[] item = new object[10];
            IMyEnumerator myEnumerator;
            public object this[int i]
            {
                get { return item[i]; }
                set { this.item[i] = value; }
            }
            public int Count
            {
                get { return item.Length; }
            }
            public IMyEnumerator GetMyEnumerator()
            {
                if (myEnumerator == null)
                {
                    myEnumerator = new MyEnumerator(this);
                }
                return myEnumerator;
            }
        }
        class MyEnumerator : IMyEnumerator
        {
            int index = 0;
            MyList myList;
            public MyEnumerator(MyList myList)
            {
                this.myList = myList;
            }
            public bool MoveNext()
            {
                if (index + 1 > myList.Count)
                {
                    index = 1;
                    return false;
                }
                else
                {
                    index++;
                    return true;
                }
            }
            public object Current
            {
                get { return myList[index - 1]; }
            }
        }
    }

    #endregion
    #region 使用泛型集合代替非泛型集合
    public class Generic
    {
        static int collectionCount = 0;
        static Stopwatch watch = null;
        static int testCount = 10000000;
        static void TestBegin()
        {
            GC.Collect();//强制对所用代码进行即时垃圾回收
            GC.WaitForPendingFinalizers();//挂起线程，执行终结器队列中的终结器(即析构方法)
            GC.Collect();//再次对所用代码垃圾回收，主要包括终结器队列中出来的对象
            collectionCount = GC.CollectionCount(0);//返回在0代中执行垃圾回收次数
            watch = new Stopwatch();
            watch.Start();
        }
        static void TestEnd()
        {
            watch.Stop();
            Console.WriteLine("耗时:" + watch.ElapsedMilliseconds.ToString());
            Console.WriteLine("垃圾回收次数:" + (GC.CollectionCount(0) - collectionCount));
        }
        static void TestArrayList()
        {
            ArrayList al = new ArrayList();
            int temp = 0;
            for (int i = 0; i < testCount; i++)
            {
                al.Add(i);
                temp = (int)al[i];
            }
            al = null;
        }
        static void TestGenericList()
        {
            List<int> listT = new List<int>();
            int temp = 0;
            for (int i = 0; i < testCount; i++)
            {
                listT.Add(i);
                temp = listT[i];
            }
            listT = null;
        }
    }
    #endregion
    #region 避免List<T>作为自定义集合类的基类

    #endregion
    #region 确保线性安全
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    #endregion
    #endregion
}




