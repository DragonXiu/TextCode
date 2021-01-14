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
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.Services.Common;

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
            int x1 = 91545588;
            Console.WriteLine("{0} ->0x{1}", x1, x1.ToString("x2"));
            Console.WriteLine($"{"p",-16}{0.1785f,-10:p}");//p%
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
            WordPattern1("abba", "dog cat cat dog");
            BackspaceCompare("aaa###a", "aaaa###a");
            IsLongPressedName("kikcxmvzi", "kiikcxxmmvvzz");
            FindTheDifference("abcd", "abcde");
            LongestPalindrome("civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth");
            ToHex(1);
            ThirdMax(new int[] { 3, 2, 1 });
            AddStrings("0", "0");
            CountSegments("Hello, my name is   John ");
            DataInit();
            int[] aa = { 4, 3, 2, 7, 8, 2, 3, 1 };
            FindDisappearedNumbers(aa);
            int[] aaa = { 1, 2, 2, 1, 1, 3 };
            string[] words = { "caaat", "bt", "hat", "tree", "atach" };

            CountCharacters(words, "atach");
            UniqueOccurrences(aaa);
            HammingDistance(1, 2);
            LicenseKeyFormatting("5F3Z - 2e-9 - w", 4);
            string[] a16 = { "Hello", "Alaska", "Dad", "Peace" };
            FindWords(a16);
            int[] Valid = { 1, 2, 3, 4, 5 };
            ValidMountainArray(Valid);
            int[] FindR = { 5, 4, 3, 2, 9 };
            FindRelativeRanks(FindR);
            ConstructRectangle(7);
            DetectCapitalUse("USa");
            List<string> Leng = new List<string> { "hot", "dot", "dog", "lot", "log", "cog" };
            LadderLength("hit", "cog", Leng);

            KClosest(new int[][] { new int[]{1,3},
new int[] {-2,2}}, 1);

            ReverseWords("Let's take LeetCode contest");
            MatrixReshape(new int[][] { new int[] { 1, 2, 6, 6, 6 }, new int[] { 5, 6, 8, 6, 6 } }, 2, 4);
            SortByBits(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 });
            FindMinArrowShots(new int[][] { new int[] { 2, 6 }, new int[] { 2, 8 }, new int[] { 10, 16 }, new int[] { 7, 12 } });
            // FindRotateSteps("nyngl","yyynnnnnnlllggg");
            ReversePairs(new int[] { 2147483647, 2147483647, 2147483647, 2147483647, 2147483647, 2147483647 });
            CheckRecord("PPALLLPL");
            ReorganizeString("vvvlo");
            SearchRange(new int[] { 2, 2 }, 2);
            CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1 }, 1);
            IsPossible(new int[] { 3, 4, 4, 5, 6, 7, 8, 9, 10, 11 });
            MatrixScore(new int[][] { new int[] { 0, 0, 1, 1 }, new int[] { 1, 0, 1, 0 }, new int[] { 1, 1, 0, 0 } });
            GroupAnagrams(new string[] { "", "b", "" });
            FindMaxAverage(new int[] { -1 }, 1);
            FindErrorNums(new int[] { 1, 2, 2, 4 });
            ImageSmoother(new int[][] { new int[] { 1, 1, 1 }, new int[] { 1, 0, 1 }, new int[] { 1, 1, 1 } });
            CheckPossibility(new int[] { 3, 4, 2, 3 });
            Candy(new int[] { 1, 3, 2, 1, 1, 2, 1 });
            FindLengthOfLCIS(new int[] { 1, 3, 5, 4, 3, 4, 5, 6, 7 });
            ValidPalindrome("aabac");
            HasAlternatingBits(10);
            MaximalRectangle(new char[][] { new char[] { '1', '0', '1', '0', '0' }, new char[] { '1', '0', '1', '1', '1' }, new char[] { '1', '1', '1', '1', '1' } ,
            new char[]{ '1', '0', '0', '1', '0' } });
            LastStoneWeight(new int[] { 2, 4, 1, 1, 7, 8 });
            EraseOverlapIntervals(new int[][] { new int[] { 1, 2 }, new int[] { 3, 5 }, new int[] { 2, 6 } });
            ToLowerCase("Hello");
            longestword(new string[] { });
            PivotIndex(new int[] { });
            FindCircleNum(new int[][] { new int[] { 1, 1,0 }, new int[] { 1, 1, 0 }, new int[] { 0, 0, 1 } });
            ShortestCompletingWord("1s3 456", new string[]{ "looks", "pest", "stew", "show" });
            MaxSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 },1) ;
            MaxProfit1(new int[] { 3, 3, 5, 0, 0, 3, 1, 4 });
            SummaryRanges(new int[] { -1, 0 });
            var counter = 1;
            var result1= Sum() + Sum();

            int Sum()
            {
                return counter++;
            }
            Console.WriteLine("SUM:"+result.ToString());
            SmallestStringWithSwaps("qdwyt", new List<IList<int>>() { 
                new List<int>() { 2, 3 }
            ,new List<int>() { 3, 2 }
            , new List<int>() { 0, 1 }
             , new List<int>() { 4, 0  }
             , new List<int>() { 3, 2 } });
            PrefixesDivBy5(new int[] { 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 1 });
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
                flag[i] = 0;
            }
            dfs(ref res, nums, flag, temp);
            return res;

        }
        private void dfs(ref List<IList<int>> res, int[] nums, int[] flag, List<int> temp)
        {
            if (temp.Count == nums.Length)
            {
                res.Add(new List<int>(temp));
                return;
            }
            for (int i = 0; i < nums.Length; ++i)
            {
                if (flag[i] == 1)
                {
                    continue;
                }
                flag[i] = 1;
                temp.Add(nums[i]);
                dfs(ref res, nums, flag, temp);
                temp.RemoveAt(temp.Count - 1);
                flag[i] = 0;
                while (i < nums.Length - 1 && nums[i + 1] == nums[i])
                {
                    i++;
                }
            }
        }
        #endregion
        #region 左叶子之和
        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return dfs(root, false);
        }
        private int dfs(TreeNode root, bool isLeft)
        {
            if (root.left == null && root.right == null && isLeft)
            {
                return root.val;
            }
            return dfs(root.left, true) + dfs(root.right, false);
        }


        #endregion
        #region 计数质数
        public int CountPrimes(int n)
        {
            #region 厄拉多塞筛选法
            int count = 0;
            bool[] signs = new bool[n];
            for (int i = 2; i < n; i++)
            {

                //因为C#布尔默认值为假
                if (!signs[i])
                {
                    count++;
                    for (int j = i + i; j < n; j += i)
                    {
                        //排除不是质数的值
                        signs[j] = true;
                    }
                }

            }
            return count;
            #endregion
            #region 暴力超时
            //if (n < 2)
            //{
            //    return 0;
            //}
            //int result = 0;
            //int num =2;
            //while (num<n)
            //{
            //    bool flag = false;
            //    for (int i = 2; i < n; i++)
            //    {
            //        if (n%i==0)
            //        {
            //            flag = true;
            //            break;
            //        }
            //    }
            //    if (!flag)
            //    {
            //        result++;
            //    }
            //}
            //return result;
            #endregion
        }
        #endregion
        #region 把搜索二叉树转换成累加二叉树
        int sum = 0;
        public TreeNode ConvertBST(TreeNode root)
        {
            if (root != null)
            {
                ConvertBST(root.right);
                sum += root.val;
                root.val = sum;
                ConvertBST(root.left);
            }
            return root;
        }
        #endregion
        #region 字符串同构
        public bool IsIsomorphic(string s, string t)
        {
            return oo(s, t) && oo(t, s);

        }
        private bool oo(string s, string t)
        {
            int n = s.Length;
            Dictionary<char, char> dic = new Dictionary<char, char>();
            for (int i = 0; i < n; i++)
            {
                char c1 = s[i];
                char c2 = t[i];
                if (dic.ContainsKey(c1))
                {
                    char o;
                    dic.TryGetValue(c1, out o);
                    if (o != c2 || dic.ContainsKey(c2))
                    {
                        return false;
                    }
                }
                else
                {
                    dic.Add(c1, c2);
                }
            }
            return true;
        }
        #endregion
        #region 反转链表
        public ListNode ReverseList(ListNode head)
        {

            #region 迭代
            /*在遍历列表时，将当前节点的 next 指针改为指向前一个元素。由于节点没有引用其上一个节点，因此必须事先存储其前一个元素。在更改引用之前，还需要另一个指针来存储下一个节点。不要忘记在最后返回新的头引用！
            */
            //ListNode prev = null;
            //ListNode curr = head;
            //while (curr!=null)
            //{
            //    ListNode nextTemp = curr.next;
            //    curr.next = prev;
            //    prev = curr;
            //    curr = nextTemp;
            //}
            //return prev;
            #endregion
            #region 递归
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode p = ReverseList(head.next);
            head.next.next = head;
            head.next = null;
            return p;
            #endregion
        }
        #endregion
        #region 监控二叉树
        public int MinCameraCover(TreeNode root)
        {
            int[] array = dfs(root);
            return array[1];
        }
        private int[] dfs(TreeNode root)
        {
            if (root == null)
            {
                return new int[] { int.MaxValue / 2, 0, 0 };
            }
            int[] leftArray = dfs(root.left);
            int[] rightArray = dfs(root.right);
            int[] array = new int[3];
            array[0] = leftArray[2] + rightArray[2] + 1;
            array[1] = Math.Min(array[0], Math.Min(leftArray[0] + rightArray[1], rightArray[0] + leftArray[1]));
            array[2] = Math.Min(array[0], leftArray[1] + rightArray[1]);

            return array;
        }
        #endregion
        #region 合并二叉树
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            #region 深度优先搜索
            //if (t1==null)
            //{
            //    return t1;
            //}
            //if (t2==null)
            //{
            //    return t1;
            //}
            //TreeNode root = new TreeNode(t1.val+t2.val);
            //root.left = MergeTrees(t1.left,t2.left);
            //root.right = MergeTrees(t1.right,t2.right);
            //return root;
            #endregion
            #region 广度优先搜索
            if (t1 == null)
            {
                return t2;
            }
            if (t2 == null)
            {
                return t1;
            }
            TreeNode root = new TreeNode(t1.val + t2.val);
            Queue<TreeNode> queue = new Queue<TreeNode>();
            Queue<TreeNode> queue2 = new Queue<TreeNode>();
            Queue<TreeNode> queue3 = new Queue<TreeNode>();
            queue.Enqueue(root);
            queue2.Enqueue(t1);
            queue3.Enqueue(t2);
            while (!(queue2 == null) && !(queue3 == null))
            {
                TreeNode node = queue.Dequeue();
                TreeNode node1 = queue2.Dequeue();
                TreeNode node2 = queue3.Dequeue();
                TreeNode left1 = node1.left;
                TreeNode left2 = node2.left;
                TreeNode right1 = node1.right;
                TreeNode right2 = node2.right;
                if (left1 != null && left2 != null)
                {
                    if (left1 != null && left2 != null)
                    {
                        TreeNode left = new TreeNode(left1.val + left2.val);
                        node.left = left;
                        queue.Enqueue(left);
                        queue2.Enqueue(left1);
                        queue3.Enqueue(left2);
                    }
                    else if (left1 != null)
                    {
                        node.left = left1;
                    }
                    else if (left2 != null)
                    {
                        node.left = left2;
                    }
                }
                if (right1 != null && right2 != null)
                {
                    if (right1 != null && right2 != null)
                    {
                        TreeNode right = new TreeNode(right1.val + right1.val);
                        node.right = right;
                        queue.Enqueue(right);
                        queue2.Enqueue(right1);
                        queue3.Enqueue(right2);
                    }
                    else if (right1 != null)
                    {
                        node.right = right1;
                    }
                    else if (right2 != null)
                    {
                        node.right = right2;
                    }
                }
            }
            return root;
            #endregion

        }
        #endregion
        #region 是否存在重复元素
        public bool ContainsDuplicate(int[] nums)
        {
            Array.Sort(nums);
            bool flag = false;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] == nums[i])
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        #endregion
        #region 二叉搜索树中的众数
        int bases;
        int count;
        int maxCount;
        List<int> answer = new List<int>();
        public int[] FindMode(TreeNode root)
        {
            TreeNode cur = root;
            TreeNode pre = null;
            while (cur != null)
            {
                if (cur.left == null)
                {
                    update(cur.val);
                    cur = cur.right;
                    continue;
                }
                pre = cur.left;
                while (pre.right != null && pre.right != cur)
                {
                    pre = pre.right;
                }
                if (pre.right == null)
                {
                    pre.right = cur;
                    cur = cur.left;
                }
                else
                {
                    pre.right = null;
                    update(cur.val);
                    cur = cur.right;
                }
            }
            int n = answer.Count();
            int[] mode = new int[n];
            for (int i = 0; i < n; i++)
            {
                mode[i] = answer[i];
            }

            return mode;
        }
        private void update(int x)
        {
            if (x == bases)
            {
                ++count;
            }
            else
            {
                count = 1;
                bases = x;
            }
            if (count == maxCount)
            {
                answer.Add(bases);
            }
            if (count > maxCount)
            {
                maxCount = count;
                answer.Clear();
                answer.Add(bases);
            }
        }
        #endregion
        #region 存在重复的元素||
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            HashSet<int> hs = new HashSet<int>();
            int i = 0;
            while (i < nums.Length)
            {
                if (hs.Contains(nums[i]))
                {
                    return true;
                }
                hs.Add(nums[i]);
                if (hs.Count() > k)
                {
                    hs.Remove(nums[i - k]);
                }
                i++;
            }
            return false;
        }
        #endregion
        #region 从中序与后序遍历序列构造二叉树
        //int post_idx;
        //int[] postorder;
        //int[] inorder1;
        //Dictionary<int, int> idx_map = new Dictionary<int, int>();
        private TreeNode helper(int[] inorder, int[] postorder, Dictionary<int, int> dictionary, int start, int end, int index)
        {
            var root = new TreeNode(postorder[index]);
            if (start == end)
            {
                return root;
            }
            int pos = dictionary[postorder[index]];
            if (pos > start)
            {
                root.left = helper(inorder, postorder, dictionary, start, pos - 1, pos + index - end - 1);
            }
            if (pos < end)
            {
                root.right = helper(inorder, postorder, dictionary, pos + 1, end, index - 1);
            }
            return root;
            ////如果这里没有节点构造二叉树，就结束
            //if (in_left>in_right)
            //{
            //    return null;
            //}
            ////选择post_idx位置的元素作为当前子树根节点
            //int root_val = postorder[post_idx];
            //TreeNode root = new TreeNode(root_val);
            ////根据root所在位置分成左右两棵子树
            //int index;
            //idx_map.TryGetValue(root_val,out index);
            ////下标减一
            //post_idx--;
            ////构造右子树
            //root.left = helper(in_left+1,in_right);
            ////构造左子树
            //root.right = helper(in_left, index - 1);
            //return root;
        }
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            if (inorder == null || postorder == null || inorder.Length <= 0 || postorder.Length <= 0)
            {
                return null;
            }
            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < inorder.Length; ++i)
            {
                dictionary.Add(inorder[i], i);
            }
            return helper(inorder, postorder, dictionary, 0, postorder.Length - 1, postorder.Length - 1);
            //this.postorder = postorder;
            //this.inorder1 = inorder;
            ////从后序遍历的最后一个元素开始
            //post_idx = postorder.Length - 1;
            ////建立（元素，下标）键值对的哈希表
            //int idx = 0;
            //for (int i = 0; i < inorder1.Length; i++)
            //{
            //    idx_map.Add(i,idx++);
            //}
            //return helper(0, inorder1.Length-1);
        }
        #endregion
        #region 用队列实现栈
        /*使用一个队列实现栈：只能实现存和取两个操作其中一个时间复杂度O(1)，另一个O(n)
         作为本题Pop和Top两个读取操作，所以采取的模式是写入O(n)，读取为O(1)，所谓实现栈和O(n)
        就是在入队或者出队循环前n-1各节点，从队后立即再加入队排在队尾，即实现队反序*/
        Queue<int> queue = new Queue<int>();
        public void Push(int x)
        {
            queue.Enqueue(x);
            for (int index = 0; index < this.queue.Count - 1; index++)
            {
                queue.Enqueue(queue.Dequeue());
            }
        }
        public int Pop()
        {
            return queue.Count > 0 ? queue.Dequeue() : -1;
        }
        public int Top()
        {
            return queue.Count > 0 ? queue.Peek() : -1;
        }
        public bool Empty()
        {
            return queue.Count == 0;
        }
        #endregion
        #region 路径总和 II
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            #region 深度优先搜索
            //IList<IList<int>> result = new List<IList<int>>();
            //List<int> data = new List<int>();
            //dfs(result, data, sum, root);
            //return result;
            #endregion
            #region 广度优先搜索
            IList<IList<int>> result = new List<IList<int>>();
            var dic = new Dictionary<TreeNode, int>();
            if (root == null)
            {
                return result;
            }
            Queue<TreeNode> queueNode = new Queue<TreeNode>();
            Queue<int> queueSum = new Queue<int>();
            queueNode.Enqueue(root);
            queueSum.Enqueue(0);
            while (!(queueNode == null))
            {
                TreeNode node = queueNode.Dequeue();
                int rec = queueSum.Dequeue() + node.val;
                if (node.left == null && node.right == null)
                {
                    if (rec == sum)
                    {

                    }
                }
            }
            return result;
            #endregion

        }
        private void getPath(TreeNode node, IList<IList<int>> result, Dictionary<TreeNode, int> map)
        {
            List<int> temp = new List<int>();
            while (node != null)
            {
                temp.Add(node.val);
                //map.TryGetValue(node,out node);
            }
        }
        private void dfs(IList<IList<int>> result, List<int> data, int sum, TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            sum -= root.val;
            data.Add(root.val);
            if (root.left == null && root.right == null && sum == 0)
            {
                result.Add(data);
            }
            dfs(result, data, sum, root.left);
            dfs(result, data, sum, root.right);
            data.Clear();
        }
        #endregion
        #region 2的幂
        public bool IsPowerOfTwo(int n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
        #endregion
        #region  二叉搜索树的最近公共祖先
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            //TreeNode ancestor = null;
            //List<TreeNode> path_p = getpath(root,p);
            //List<TreeNode> path_q = getpath(root,q);

            //for (int i = 0; i < path_p.Count()&&path_q.Count()>i; i++)
            //{
            //    if (path_p[i]==path_q[i])
            //    {
            //        ancestor = path_p[i];
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //return ancestor;
            if (root.val > p.val && root.val > q.val)
            {
                return LowestCommonAncestor(root.left, p, q);
            }
            if (root.val < q.val && root.val < p.val)
            {
                return LowestCommonAncestor(root.right, p, q);
            }
            return root;
        }
        public List<TreeNode> getpath(TreeNode root, TreeNode target)
        {
            List<TreeNode> path = new List<TreeNode>();
            TreeNode node = root;
            while (node != target)
            {
                path.Add(node);
                if (target.val < node.val)
                {
                    node = node.left;
                }
                else
                {
                    node = node.right;
                }
            }
            path.Add(node);
            return path;
        }
        #endregion
        #region 请判断一个链表是否为回文链表。
        public bool IsPalindrome(ListNode head)
        {
            List<int> vals = new List<int>();
            ListNode T = head;
            while (T != null)
            {
                vals.Add(T.val);
                T = T.next;
            }
            int first = 0;
            int second = vals.Count() - 1;
            while (first < second)
            {
                if (vals[first] != vals[second])
                {
                    return false;
                }
                first++;
                second--;
            }
            return true;
        }
        #endregion
        #region  填充每个节点的下一个右侧节点指针 II
        public Node Connect(Node root)
        {
            Node last = null;
            Node nextStart = null;
            if (root == null)
            {
                return null;
            }
            Node start = root;
            while (start != null)
            {
                last = null;
                nextStart = null;
                for (Node p = start; p != null; p = p.next)
                {
                    if (p.left != null)
                    {
                        handle(p.left, last, nextStart);
                    }
                    if (p.right != null)
                    {
                        handle(p.right, last, nextStart);
                    }
                }
                start = nextStart;
            }
            return root;
            //if (root==null)
            //{
            //    return null;
            //}
            //Queue<Node> queue = new Queue<Node>();
            //while (!(queue==null))
            //{
            //    int n = queue.Count();
            //    Node last = null;
            //    for (int i = 0; i <=n; ++i)
            //    {
            //        Node f = queue.Dequeue();
            //        if (f.left!=null)
            //        {
            //            queue.Enqueue(f.left);
            //        }
            //        if (f.right!=null)
            //        {
            //            queue.Enqueue(f.right);
            //        }
            //        if (i!=1)
            //        {
            //            last.next = f;
            //        }
            //        last = f;
            //    }
            //}
            //return root;
        }
        private void handle(Node p, Node last, Node nextStart)
        {
            if (last != null)
            {
                last.next = p;
            }
            if (nextStart == null)
            {
                nextStart = p;
            }
            last = p;
        }
        #endregion
        #region 二叉树的后序遍历
        public IList<int> PostorderTraversal(TreeNode root)
        {
            #region 递归

            //List<int> result = new List<int>();
            //if (root == null)
            //{
            //    return result;
            //}
            //dfs(root.left, result);
            //dfs(root.left, result);
            //result.Add(root.val);
            //return result;

            #endregion
            #region Morris 
            List<int> res = new List<int>();
            if (root == null)
            {
                return res;
            }
            TreeNode p1 = root;
            TreeNode p2 = null;
            while (p1 != null)
            {
                p2 = p1.left;
                if (p2 != null)
                {
                    while (p2.right != null && p2.right != p1)
                    {
                        p2 = p2.right;
                    }
                    if (p2.right == null)
                    {
                        p2.right = p1;
                        p1 = p1.left;
                        continue;
                    }
                    else
                    {
                        p2.right = null;
                        addPath(res, p1.left);
                    }
                }
                p1 = p1.right;
            }
            addPath(res, root);
            return res;
            #endregion

        }
        private void addPath(List<int> res, TreeNode node)
        {
            List<int> tmp = new List<int>();
            while (node != null)
            {
                tmp.Add(node.val);
                node = node.right;
            }
            for (int i = tmp.Count(); i >= 0; --i)
            {
                res.Add(tmp[i]);
            }
        }
        private void dfs(TreeNode root, List<int> result)
        {
            if (root == null)
            {
                result.Add(root.val);
                return;
            }
            if (root.left != null)
            {
                dfs(root.left, result);
            }
            if (root.right != null)
            {
                dfs(root.right, result);
            }
            result.Add(root.val);


        }
        #endregion
        #region 删除链表
        public void DeleteList(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
        #endregion
        #region 二叉搜索树中的插入操作
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null)
            {
                return new TreeNode(val);
            }
            TreeNode ns = root;
            while (ns != null)
            {
                if (ns.val > val)
                {
                    if (ns.left == null)
                    {
                        ns.left = new TreeNode(val);
                        break;
                    }
                    else
                    {
                        ns = ns.left;
                    }
                }
                else
                {
                    if (ns.right == null)
                    {
                        ns.right = new TreeNode(val);
                        break;
                    }
                    else
                    {
                        ns = ns.right;
                    }
                }
            }
            return root;
        }
        #endregion
        #region 有效的字母异位词
        public bool IsAnagram(string s, string t)
        {

            if (s.Length != t.Length)
            {
                return false;
            }
            int[] arr = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                arr[s[i] - 'a']++;
                arr[t[i] - 'a']--;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    return false;
                }
            }
            return true;
            //int one = s.Length;
            //int two = t.Length;
            //if (one!=two)
            //{
            //    return false;
            //}
            //Dictionary<char, int> dic = new Dictionary<char, int>();
            //for (int i = 0; i < one-1; i++)
            //{
            //    if (dic.ContainsKey(s[i]))
            //    {
            //        int value;
            //        dic.TryGetValue(s[i],out value);
            //        value += 1;
            //        dic.Remove(s[i]);
            //        dic.Add(s[i],value);
            //    }
            //    else
            //    {
            //        dic.Add(s[i],1);
            //    }
            //}
            //for (int i = 0; i < one - 1; i++)
            //{
            //    if (dic.ContainsKey(t[i]))
            //    {
            //        int value;
            //        dic.TryGetValue(t[i], out value);
            //        value -= 1;
            //        dic.Remove(t[i]);
            //        dic.Add(t[i], value);
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //foreach (var item in dic.Values)
            //{
            //    if (item!=0)
            //    {
            //        return false;
            //    }
            //}
            //return true;
        }
        #endregion
        #region 颜色分类
        public void SortColors(int[] nums)
        {
            #region 单指针
            //int len = nums.Length;
            //int ptr = 0;
            //for (int i = 0; i < len; i++)
            //{
            //    if (nums[i]==0)
            //    {
            //        int temp = 0;
            //        temp= nums[ptr];
            //        nums[ptr] = nums[i];
            //        nums[i] = temp;
            //        ++ptr;
            //    }
            //}
            //for (int i = ptr; i < len; i++)
            //{
            //    if (nums[i]==1)
            //    {
            //        int temp = 0;
            //        temp = nums[ptr];
            //        nums[ptr] = nums[i];
            //        nums[i] = temp;
            //        ++ptr;
            //    }
            //}
            #endregion
            #region 双指针01(左左)
            //int n = nums.Length;
            //int p0 = 0;
            //int p1 = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    if (nums[i]==1)
            //    {
            //        int temp = nums[i];
            //        nums[i] = nums[p1];
            //        nums[p1] = temp;
            //        ++p1;
            //    }
            //    else if (nums[i]==0)
            //    {
            //        int temp = nums[i];
            //        nums[i] = nums[p0];
            //        nums[p0] = temp;
            //        if (p0<p1)
            //        {
            //            temp = nums[i];
            //            nums[i] = nums[p1];
            //            nums[p1] = temp;
            //        }
            //        ++p0;
            //        ++p1;
            //    }
            //}

            #endregion
            #region 双指针02(左右)
            int n = nums.Length;
            int p0 = 0;
            int p2 = n - 1;
            for (int i = 0; i < n; ++i)
            {
                while (i <= p2 && nums[i] == 2)
                {
                    int temp = nums[i];
                    nums[i] = nums[p2];
                    nums[p2] = temp;
                    --p2;
                }
                if (nums[i] == 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[p0];
                    nums[p0] = temp;
                    ++p0;
                }
            }
            #endregion

        }
        #endregion
        #region 各位相加
        public int AddDigits(int num)
        {
            return (num - 1) % 9 + 1;
        }
        #endregion
        #region 反转字符串
        public void ReverseString(char[] s)
        {
            int one = 0;
            int two = s.Length - 1;
            while (one < two)
            {
                char temp = s[one];
                s[one] = s[two];
                s[two] = temp;
                one++;
                two--;
            }

        }
        #endregion
        #region 丑数
        public bool IsUgly(int num)
        {
            if (num == 0) { return false; }
            while (num != 1)
            {
                if (num % 2 == 0) { num /= 2; continue; }
                if (num % 3 == 0) { num /= 3; continue; }
                if (num % 5 == 0) { num /= 5; continue; }
                return false;
            }
            return true;
        }
        #endregion
        #region 缺失数字
        public int MissingNumber(int[] nums)
        {
            Array.Sort(nums);
            if (nums[nums.Length - 1] != nums.Length)
            {
                return nums.Length;
            }
            // 判断 0 是否出现在首位
            else if (nums[0] != 0)
            {
                return 0;
            }

            int result = -1;
            // 此时缺失的数字一定在 (0, n) 中
            for (int i = 1; i < nums.Length; i++)
            {
                int expectedNum = nums[i - 1] + 1;
                if (nums[i] != expectedNum)
                {
                    result = expectedNum;
                }
            }
            // 未缺失任何数字（保证函数有返回值）
            return result;
        }
        #endregion
        #region 第一个错误的版本

        #endregion
        #region 环形链表||
        public ListNode DetectCycle(ListNode head)
        {
            #region 哈希表
            ListNode pos = head;
            HashSet<ListNode> hs = new HashSet<ListNode>();
            while (pos != null)
            {
                if (hs.Contains(pos))
                {
                    return pos;
                }
                else
                {
                    hs.Add(pos);
                }
                pos = pos.next;
            }
            return null;
            #endregion
            #region 快慢指针
            ListNode fast = head;
            ListNode slow = head;
            while (fast != null)
            {
                slow = slow.next;
                if (fast.next == null)
                {
                    return null;
                }
                fast = fast.next.next;
                if (fast == slow)
                {
                    ListNode ptr = head;
                    while (ptr != slow)
                    {
                        ptr = ptr.next;
                        slow = slow.next;
                    }
                    return ptr;
                }
            }
            #endregion
        }
        #endregion
        #region 移动零
        public void MoveZeroes(int[] nums)
        {
            if (nums.Length == 0)
            {
                return;
            }
            int a = 0;
            int b = 0;
            while (a < nums.Length)
            {
                if (nums[a] != 0)
                {
                    int temp = nums[a];
                    nums[a] = nums[b];
                    nums[b++] = temp;
                }
                a++;
            }
        }
        #endregion
        #region 二叉树最小绝对值
        public int GetMinimumDifference(TreeNode root)
        {
            int min = int.MaxValue;
            int pre = -1;
            dfs(root, pre, min);
            return min;
        }
        private void dfs(TreeNode root, int pre, int ans)
        {
            if (root == null)
            {
                return;
            }
            dfs(root.left, pre, ans);
            if (pre == -1)
            {
                pre = root.val;
            }
            else
            {
                ans = Math.Min(ans, root.val - pre);
                pre = root.val;
            }
            dfs(root.right, pre, ans);
        }
        #endregion
        #region 单词规律
        public static bool WordPattern(string pattern, string s)
        {
            List<string> mm = s.Split(" ").ToList<string>();
            if (mm.Count() != pattern.Length)
            {
                return false;
            }
            Dictionary<char, string> dic = new Dictionary<char, string>();
            for (int i = 0; i < pattern.Length; i++)
            {
                if (dic.ContainsKey(pattern[i]))
                {
                    string m;
                    dic.TryGetValue(pattern[i], out m);
                    if (m != mm[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (dic.ContainsValue(mm[i]))
                    {
                        return false;
                    }

                    dic.Add(pattern[i], mm[i]);
                }
            }
            return true;
        }
        #endregion
        #region 两两交换链表中的节点
        public ListNode SwapPairs(ListNode head)
        {
            #region 递归
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode newHead = head.next;
            head.next = SwapPairs(newHead.next);
            newHead.next = head;
            return newHead;
            #endregion
            #region 迭代
            ListNode pre = new ListNode(0);
            pre.next = head;
            ListNode temp = pre;
            while (temp.next != null && temp.next.next != null)
            {
                ListNode start = temp.next;
                ListNode end = temp.next.next;
                temp.next = end;
                start.next = end.next;
                end.next = start;
                temp = start;
            }
            return pre.next;



            #endregion

        }

        #endregion
        #region Nim 游戏
        public bool CanWinNim(int n)
        {
            return (n % 4 != 0);
        }
        #endregion
        #region 查找常用字符
        public IList<string> CommonChars(string[] A)
        {
            /*给定仅有小写字母组成的字符串数组 A，返回列表中的每个字符串中都显示的全部字符（包括重复字符）
             * 组成的列表。例如，如果一个字符在每个字符串中出现 3 次，但不是 4 次，则需要在最终答案中包含该字符 3 次。
             * 你可以按任意顺序返回答案。
             * 示例 1：输入：["bella","label","roller"]输出：["e","l","l"]
             * 示例 2：输入：["cool","lock","cook"]输出：["c","o"]*/
            List<string> result = new List<string> { };
            string a = A[0];
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (dic.ContainsKey(a[i]))
                {
                    int num;
                    dic.TryGetValue(a[i], out num);
                    dic.Remove(a[i]);
                    dic.Add(a[i], num + 1);
                }
                else
                {
                    dic.Add(a[i], 1);
                }

            }
            for (int i = 0; i < a.Length; i++)
            {
                char b = a[i];
                for (int j = 0; j < A.Length; j++)
                {
                    if (!A[j].Contains(b))
                    {
                        dic.Remove(b);
                        break;
                    }
                    else
                    {
                        int num;
                        int num1 = 0;
                        dic.TryGetValue(a[i], out num);
                        for (int k = 0; k < A[j].Length; k++)
                        {
                            if (A[j][k] == b)
                            {
                                num1++;
                            }
                        }
                        if (num > num1)
                        {
                            dic.Remove(b);
                            dic.Add(b, num1);
                        }
                    }
                }
            }
            foreach (var item in dic)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    result.Add(item.Key.ToString());
                }
            }
            return result;
            #region 根据小写字母特性新建一个26数组，根据最小次数
            var res = new int[26];
            for (var k = 0; k < 26; k++)
            {
                res[k] = int.MaxValue;
            }
            foreach (var s in A)
            {
                var t = new int[26];
                foreach (var c in s)
                {
                    t[c - 'a']++;
                }
                for (var k = 0; k < 26; k++)
                {
                    if (t[k] < res[k])
                    {
                        res[k] = t[k];
                    }
                }
            }
            var list = new List<string>();
            for (var k = 0; k < 26; k++)
            {
                if (res[k] < int.MaxValue)
                {
                    while (res[k] > 0)
                    {
                        list.Add(((char)('a' + k)).ToString());
                        res[k]--;
                    }
                }
            }
            return list;
            #endregion
        }
        #endregion
        #region 区域和检索 - 数组不可变
        //static int[] sum1;
        //public NumArray(int[] nums)
        //{
        //    sum1 = nums;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        sum1[i] = sum1[i - 1] + sum1[i];
        //    }
        //}

        //public int SumRange(int i, int j)
        //{
        //    if (i==0)
        //    {
        //       return sum1[j];
        //    }
        //    return sum1[j]-sum1[i - 1];
        //}
        #endregion
        #region 填充每个节点的下一个右侧节点指针
        public Node Connect1(Node root)
        {
            #region 层次

            if (root == null)
            {
                return root;
            }
            //初始化队列同时将第一层节点加入队列中，即根节点
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            //外层的while循环迭代是层数
            while (!(queue.Count == 0))
            {
                //记录当前队列大小
                int size = queue.Count;
                //遍历这一层所有节点
                for (int i = 0; i < size; i++)
                {
                    //从队首取出元素
                    Node node = queue.Dequeue();
                    //连接
                    if (i < size - 1)
                    {
                        node.next = queue.Peek();
                    }
                    //拓宽下一层节点
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
            }
            //返回根节点
            return root;

            #endregion
            #region next
            if (root == null)
            {
                return root;
            }
            //从根节点开始
            Node leftmost = root;
            while (leftmost.left != null)
            {
                //遍历这一层次节点组织组织成的链表，为下一层的节点更新next指针
                Node head = leftmost;
                while (head != null)
                {
                    //第一种情况
                    head.left.next = head.right;
                    //第二种情况
                    if (head.next != null)
                    {
                        head.right.next = head.next.left;
                    }
                    //指针向后移动
                    head = head.next;
                }
                //去一层的最左的节点
                leftmost = leftmost.left;
            }
            return root;
            #endregion
        }

        #endregion
        #region 3的幂
        public bool IsPowerOfThree(int n)
        {
            if (n < 1)
            {
                return false;
            }
            while (n % n == 0)
            {
                n /= 3;
            }
            //double res =   Math.Log10(n) / Math.Log10(3);
            //  return res - (int)res == 0;
            return n == 1;
        }
        #endregion
        #region  有序数组的平方
        public int[] SortedSquares(int[] A)
        {
            /*给定一个按非递减顺序排序的整数数组 A，返回每个数字的平方组成的新数组，要求也按非递减顺序排序。*/
            int num = A.Length;

            A[0] = A[0] * A[0];

            for (int i = 1; i < A.Length; i++)
            {
                A[i] = A[i] * A[i];
                for (int j = i; j > 0; j--)
                {
                    if (A[j] > A[j - 1])
                    {
                        int temp = A[j];
                        A[j] = A[j - 1];
                        A[j - 1] = temp;
                    }
                }
            }
            return A;
            #region 双指针
            int[] ans = new int[A.Length];
            for (int i = 0, j = A.Length - 1, pos = A.Length - 1; i <= j;)
            {
                if (A[i] * A[i] > A[j] * A[j])
                {
                    ans[pos] = A[i];
                    ++i;
                }
                else
                {
                    ans[pos] = A[j] * A[j];
                    --j;
                }
                --pos;
            }
            return ans;
            #endregion
        }

        #endregion
        #region 4的幂
        public bool IsPowerOfFour(int num)
        {
            double res = Math.Log10(num) / Math.Log10(4);
            return res - (int)res == 0;
        }
        #endregion
        #region N皇后 II
        int n2;
        int[] res2;
        int count2 = 0;//总方案数
        public int TotalNQueens(int n)
        {
            HashSet<int> columns = new HashSet<int>();
            HashSet<int> diagonals1 = new HashSet<int>();
            HashSet<int> diagonals2 = new HashSet<int>();
            return backtrack(n, 0, columns, diagonals1, diagonals2);
            #region 位

            this.n2 = n;
            this.res2 = new int[n];

            #endregion
        }
        private void check(int k)
        {
            if (k == n2)
            {
                count2++;
                return;
            }
            for (int i = 0; i < n2; i++)
            {
                //将位置i放入索引数组第k个
                res2[k] = i;
                if (!Judge(k))
                {
                    check(k + 1);//不冲突的话，回溯放置下一行
                }
                //冲突的话试下一个位置
            }
        }
        //判断第k行的位置是否与之前位置冲突
        private Boolean Judge(int k)
        {
            for (int i = 0; i < k; i++)
            {
                if (res2[k] == res2[i] || Math.Abs(k - i) == Math.Abs(res2[k] - res2[i]))
                {
                    return true;
                }
            }
            return false;
        }
        private int backtrack(int n, int row, HashSet<int> columns, HashSet<int> diagonals1, HashSet<int> diagonals2)
        {
            if (row == n)
            {
                return 1;
            }
            else
            {
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    if (columns.Contains(i))
                    {
                        continue;
                    }
                    int diagonal1 = row - i;
                    if (diagonals1.Contains(diagonal1))
                    {
                        continue;
                    }
                    int diagonal2 = row + i;
                    if (diagonals2.Contains(diagonal2))
                    {
                        continue;
                    }
                    columns.Add(i);
                    diagonals1.Add(diagonal1);
                    diagonals2.Add(diagonal2);
                    count += backtrack(n, row + 1, columns, diagonals1, diagonals2);
                    columns.Remove(i);
                    diagonals1.Remove(diagonal1);
                    diagonals2.Remove(diagonal2);
                }
                return count;
            }

        }
        #endregion
        #region 反转字符串中的元音字母
        public string ReverseVowels(string s)
        {
            List<char> yuan = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            StringBuilder result = new StringBuilder();
            result.Append(s);
            int a = 0;
            int b = s.Length - 1;
            while (a < b)
            {
                if (!yuan.Contains(result[a]))
                {
                    a++;
                }
                if (!yuan.Contains(result[b]))
                {
                    b--;
                }
                if (yuan.Contains(result[a]) && yuan.Contains(result[b]))
                {
                    char temp = result[a];
                    result[a] = result[b];
                    result[b] = temp;
                    a++;
                    b--;
                }
            }
            return result.ToString();
        }
        #endregion
        #region 比较含退格的字符串
        public static bool BackspaceCompare(string S, string T)
        {
            /*输入：S = "ab#c", T = "ad#c "
             * 输出：true
             * 解释：S 和 T 都会变成 “ac”。*/
            int a = 0;
            StringBuilder temp = new StringBuilder();
            for (int i = S.Length - 1; i >= 0; i--)
            {
                if (S[i] == '#')
                {
                    a++;
                }
                else if (S[i] != '#' && a > 0)
                {
                    a--;
                }
                else if (S[i] != '#' && a == 0)
                {
                    temp.Insert(0, S[i]);
                }
            }
            a = 0;
            for (int i = T.Length - 1; i >= 0; i--)
            {
                if (T[i] == '#')
                {
                    a++;
                }
                else if (T[i] != '#' && a > 0)
                {
                    a--;
                }
                else if (T[i] != '#' && a == 0)
                {
                    if (temp.Length == 0)
                    {
                        return false;
                    }
                    if (T[i] == temp[temp.Length - 1])
                    {
                        temp.Remove(temp.Length - 1, 1);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion
        #region 两个数组的交集
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            /*给定两个数组，编写一个函数来计算它们的交集*/
            HashSet<int> temp = new HashSet<int>();
            List<int> result = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (temp.Contains(nums1[i]))
                {
                    continue;
                }
                else
                {
                    temp.Add(nums1[i]);
                }
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                if (temp.Contains(nums2[i]))
                {
                    if (result.Contains(nums2[i]))
                    {
                        continue;
                    }
                    else
                    {
                        result.Add(nums2[i]);
                    }
                }
                else
                {
                    continue;
                }
            }
            return result.ToArray();
        }
        #endregion
        #region  两个数组的交集 II
        public int[] Intersection2(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            List<int> result = new List<int>();
            int a = 0;
            int b = 0;
            while (a < nums1.Length && b < nums2.Length)
            {
                if (nums1[a] != nums2[b])
                {
                    if (nums1[a] > nums2[b])
                    {
                        b++;
                    }
                    else
                    {
                        a++;
                    }
                }
                else
                {
                    result.Add(nums1[a]);
                    a++;
                    b++;
                }
            }
            return result.ToArray();
        }
        #endregion
        #region 有效的完全平方数
        public bool IsPerfectSquare(int num)
        {
            #region 牛顿迭代法
            long x = num / 2;
            if (num < 2)
            {

                while (x * x > num)
                {
                    x = (x + num / x) / 2;
                }

            }
            return (x * x == num);
            #endregion

        }
        #endregion
        #region 重排链表
        public void ReorderList(ListNode head)
        {
            #region 线性表存储该链表
            if (head == null)
            {
                return;
            }
            List<ListNode> list = new List<ListNode>();
            ListNode node = head;
            while (node != null)
            {
                list.Add(node);
                node = node.next;
            }
            int i = 0;
            int j = list.Count() - 1;
            while (i < j)
            {
                list[i].next = list[j];
                i++;
                if (i == j)
                {
                    break;
                }
                list[j].next = list[i];
                j--;
            }
            list[i].next = null;
            #endregion
            #region MyRegion
            /*先找处链表L的中间结点，为此设置两个指针p和q，指针p每次走一步，指针q每次走两步，当指针q到达链尾时，指针p正好在链表的中间结点；
2、然后将L的后半段结点原地逆置；
3、从单链表前后两段中 依次各取一个结点，按要求重排；
*/
            //void reorderList(ListNode* head)
            //        {
            //            ListNode* p = head,*q = head,*r,*s = head;
            //            if (!head)            //head为空，则直接退出
            //                return;
            //            while (q->next)
            //            {      //寻找中间结点
            //                q = q->next;       //p走一步
            //                p = p->next;
            //                if (q->next)
            //                    q = q->next;     //q走两步
            //            }
            //            q = p->next;           //p所指结点为中间结点，q为后半段链表的首结点
            //            p->next = nullptr;
            //            while (q)
            //            {            //将链表后半段逆置
            //                r = q->next;
            //                q->next = p->next;
            //                p->next = q;
            //                q = r;
            //            }
            //            q = p->next;            //q指向后半段的第一个数据结点
            //            p->next = nullptr;
            //            while (q)
            //            {             //将链表后半段的结点插入到指定位置
            //                r = q->next;        //r指向后半段的下一个结点
            //                q->next = s->next;  //将q所指结点插入到s所指结点（head结点）之后
            //                s->next = q;
            //                s = q->next;        //s指向前半段的下一个插入点
            //                q = r;
            //            }
            //        }

            #endregion
        }
        #endregion
        #region 猜数字大小
        //public int GuessNumber(int n)
        //{
        //int low = 1;
        //int high = n;
        //while (low<=high)
        //{
        //    int mid = low + (high - low) / 2;
        //    int res = guess(mid);
        //    if (res == 0)
        //    {
        //        return mid;
        //    }
        //    else if (res < 0)
        //    {
        //        high = mid - 1;
        //    }
        //    else low = mid + 1;
        //}
        //return -1;
        //}
        #endregion
        #region 两整数之和
        public int GetSum(int a, int b)
        {
            /*异或得到不进位加法的和，按位与并左移一位得到进位的和，两者相加即为两数之和。出口为进位为0。
可用迭代或递归。*/
            int aa = a, bb = b, c;
            do
            {
                c = aa & bb;//进位
                aa ^= bb;//低位
                bb = c << 1;
            } while (c != 0);
            return aa;
        }
        #endregion
        #region 赎金信
        public bool CanConstruct(string ransomNote, string magazine)
        {
            int n1 = ransomNote.Length;
            List<char> temp = new List<char>();
            temp = magazine.ToList();
            int a = 0;
            while (a < n1)
            {
                bool flag = false;
                for (int i = 0; i < temp.Count; i++)
                {
                    if (ransomNote[a] == temp[i])
                    {
                        flag = true;
                        temp.RemoveAt(i);
                        break;
                    }
                }
                if (!flag)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion
        #region 长按键入
        public static bool IsLongPressedName(string name, string typed)
        {
            int a = 0;
            int b = 0;
            char temp = ' ';
            while (b < typed.Length)
            {
                if (a < name.Length && name[a] == typed[b])
                {
                    a++;
                    b++;
                }
                else if (b > 0 && typed[b] == typed[b - 1])
                {
                    b++;
                }
                else
                {
                    return false;
                }
            }

            return a == name.Length;
        }
        #endregion
        #region 字符串中的第一个唯一字符
        public int FirstUniqChar(string s)
        {
            int resul = 0;
            int[] nums = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                nums[s[i] - 'a']++;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (nums[s[i] - 'a'] == 1)
                {
                    resul = s[i] - 'a';
                    break;
                }
            }
            return resul;
        }
        #endregion
        #region    划分字母区间
        public IList<int> PartitionLabels(string S)
        {
            int[] last = new int[26];
            int length = S.Length;
            for (int i = 0; i < length; i++)
            {
                last[S[i] - 'a'] = i;
            }
            List<int> partition = new List<int>();
            int start = 0, end = 0;
            for (int i = 0; i < length; i++)
            {
                end = Math.Max(end, last[S[i] - 'a']);
                if (i == end)
                {
                    partition.Add(end - start + 1);
                    start = end + 1;
                }
            }
            return partition;
        }
        #endregion
        #region 找不同
        public static char FindTheDifference(string s, string t)
        {
            int[] nums1 = new int[26];
            char result = ' ';
            for (int i = 0; i < s.Length; i++)
            {
                nums1[s[i] - 'a']++;
            }
            for (int i = 0; i < t.Length; i++)
            {
                --nums1[t[i] - 'a'];
                if (nums1[i] == -1)
                {
                    result = (char)('a' + i);
                    break;
                }
            }
            for (int i = 0; i < nums1.Length; i++)
            {
                if (nums1[i] == -1)
                {
                    result = (char)('a' + i);
                    break;
                }
            }
            return result;
        }
        #endregion
        #region 二进制手表

        public IList<string> ReadBinaryWatch(int num)
        {
            var dictA = new Dictionary<int, List<int>>();
            var res = new List<string>();
            for (var i = 0; i < 12; i++)
            {
                var t = BitCount(i);
                if (dictA.ContainsKey(t))
                {
                    dictA[t].Add(i);
                }
                else
                {
                    dictA[t] = new List<int> { i };
                }
            }

            var dictB = new Dictionary<int, List<int>>();
            for (var i = 0; i < 60; i++)
            {
                var t = BitCount(i);
                if (dictB.ContainsKey(t))
                {
                    dictB[t].Add(i);
                }
                else
                {
                    dictB[t] = new List<int> { i };
                }
            }
            for (var i = 0; i <= 4 && dictA.ContainsKey(i); i++)
            {
                var j = num - i;
                if (j >= 0 && dictB.ContainsKey(j))
                {
                    foreach (var a in dictA[i])
                    {
                        foreach (var b in dictB[j])
                        {
                            if (b < 10)
                            {
                                res.Add($"{a}:0{b}");
                            }
                            else
                            {
                                res.Add($"{a}:{b}");
                            }
                        }
                    }

                }
            }
            return res;
        }

        int BitCount(int n)
        {
            var count = 0;
            while (n > 0)
            {
                n &= (n - 1);
                count++;
            }
            return count;
        }

        #endregion
        #region 数字转换十六进制
        public static string ToHex(int num)
        {
            //正数取余，负数补码

            //StringBuilder result = new StringBuilder();
            //int n = 0;
            //while (num>16)
            //{
            //    int remainder = num /16;
            //    result.Append(remainder.ToString());
            //    num = num%16;
            //}
            //   DisposeNum(num, result);
            //return result.ToString();
            if (num == 0)
            {
                return "0";
            }
            string res = "";
            uint num1 = (uint)num;
            int a = num & 15;
            string[] hex = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f" };
            while (num1 != 0)
            {
                res = hex[num1 % 16] + res;
                num1 /= 16;
            }
            return res;
        }
        private static void DisposeNum(int remainder, StringBuilder result)
        {
            string[] scale = new string[] { "a", "b", "c", "d", "e", "f" };
            if (remainder >= 10)
            {
                result.Append(scale[remainder % 10]);
            }
            else
            {
                result.Append(remainder.ToString());
            }
        }
        #endregion
        #region Fizz Buzz
        public IList<string> FizzBuzz(int n)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < n; i++)
            {
                if (i < 3)
                {
                    result.Add(i.ToString());
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }
            return result;

        }
        #endregion
        #region 最长回文串
        public static int LongestPalindrome(string s)
        {
            //每个字母的个数要是双数
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int num = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    int value = 0;
                    dic.TryGetValue(s[i], out value);
                    dic.Remove(s[i]);
                    dic.Add(s[i], ++value);
                }
                else
                {
                    dic.Add(s[i], 1);
                }
            }
            int j = 0;
            int a = 0;
            foreach (var item in dic.Values)
            {

                if (item % 2 == 0)
                {
                    num += item;
                }
                else if (item > j)
                {
                    int temp = j;
                    j = item;
                    num += (temp / 2 * 2);
                }
                else num += (item / 2 * 2);
                if (item == 1)
                {
                    a = 1;
                }
            }
            if (j > 1)
            {
                num += j;
            }
            else num += a;
            return num;
        }
        #endregion
        #region 第三大的数
        public static int ThirdMax(int[] nums)
        {
            /*给定一个非空数组，返回此数组中第三大的数。
             * 如果不存在，则返回数组中最大的数。要求算法时间复杂度必须是O(n)。*/
            Array.Sort(nums);
            int length = nums.Length;
            if (length < 3)
            {
                return nums[length - 1];
            }
            int n = 1;
            int temp = nums[length - 1];
            for (int i = length - 2; i >= 0; i--)
            {
                if (temp > nums[i])
                {
                    n++;
                    temp = nums[i];
                }
                if (n == 3)
                {
                    return nums[i];
                }
            }
            return nums[length - 1];
        }
        #endregion
        #region 字符串相加
        public static string AddStrings(string num1, string num2)
        {
            /*给定两个字符串形式的非负整数 num1 和num2 ，计算它们的和。
             * num1 和num2 的长度都小于 5100
             * num1 和num2 都只包含数字 0-9
             * num1 和num2 都不包含任何前导零
             * 你不能使用任何內建 BigInteger 库， 也不能直接将输入的字符串转换为整数形式*/
            int scale = 0;
            int n1 = num1.Length - 1, n2 = num2.Length - 1;
            StringBuilder result = new StringBuilder();
            while (n1 >= 0 || n2 >= 0)
            {
                if (n1 >= 0 && n2 >= 0)
                {
                    int a = (int)num1[n1] + (int)num2[n2] + scale;
                    scale = 0;
                    result.Insert(0, a % 10);
                    if (a / 10 > 0)
                    {
                        scale = 1;
                    }
                    n1--;
                    n2--;
                }
                else if (n1 >= 0)
                {
                    int a = (int)num1[n1] + scale;
                    scale = 0;
                    result.Insert(0, a % 10);
                    if (a / 10 > 0)
                    {
                        scale = 1;
                    }
                    n1--;
                }
                else if (n2 >= 0)
                {
                    int a = (int)num2[n2] + scale;
                    scale = 0;
                    result.Insert(0, a % 10);
                    if (a / 10 > 0)
                    {
                        scale = 1;
                    }
                    n2--;
                }

            }
            return result.ToString();
        }
        #endregion
        #region 视频拼接
        public int VideoStitching(int[][] clips, int T)
        {
            int[] dp = new int[T + 1];
            Array.Fill(dp, int.MaxValue - 1);
            dp[0] = 0;
            for (int i = 1; i <= T; i++)
            {
                foreach (int[] item in clips)
                {
                    if (item[0] < i && i <= item[1])
                    {
                        dp[i] = Math.Min(dp[i], dp[item[0]] + 1);
                    }
                }
            }
            return dp[T] == int.MaxValue - 1 ? -1 : dp[T];
        }
        #endregion
        #region 有多少小于当前数字的数字
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int n = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        n++;
                    }
                }
                result[i] = n;
            }
            return result;
        }
        #endregion
        #region 字符串中的单词数
        /*统计字符串中的单词个数，这里的单词指的是连续的不是空格的字符。
         * 请注意，你可以假定字符串里不包括任何不可打印的字符。*/
        public static int CountSegments(string s)
        {
            string[] result = s.Split(" ");
            // string[] result = Regex.Split(s, "\\s+", RegexOptions.IgnoreCase);
            int n = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != "")
                {
                    n++;
                }
            }
            return n;
        }
        #endregion
        #region 排列硬币
        public int ArrangeCoins(int n)
        {
            /*你总共有 n 枚硬币，你需要将它们摆成一个阶梯形状，第 k 行就必须正好有 k 枚硬币。
             * 给定一个数字 n，找出可形成完整阶梯行的总行数。*/
            int num = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n - i >= 0)
                {
                    num++;
                    n -= i;
                }
                else
                {
                    break;
                }

            }
            return num;
        }
        #endregion
        #region 二叉树的前序遍历
        public IList<int> PreorderTraversal(TreeNode root)
        {
            /*给定一个二叉树，返回它的 前序 遍历*/
            List<int> result = new List<int>();


            return result;
        }
        private void Def(List<int> result, TreeNode root)
        {
            result.Add(root.val);
            if (root.left != null)
            {
                PreorderTraversal(root.left);
            }
            if (root.right != null)
            {
                PreorderTraversal(root.right);
            }

        }
        #endregion
        #region  找到所有数组中消失的数字
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            Array.Sort(nums);
            List<int> result = new List<int>();
            int n = nums.Length;
            for (int i = n - 1; i >= 0; i--)
            {

                if (nums[i] > n)
                {
                    for (int j = n; j < nums[i]; j++)
                    {
                        result.Add(n);
                    }
                    n = nums[i] + 1;
                }
                else if (nums[i] == n)
                {
                    n++;
                }
            }
            for (int i = n; i <= nums.Length; i++)
            {
                result.Add(i);
            }
            //List<int> result = new List<int>();
            //int n = 1;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i]>n)
            //    {                    
            //        for (int j = n; j  < nums[i]; j ++)
            //        {
            //            result.Add(n);
            //        }
            //        n = nums[i ] + 1;
            //    }
            //    else if (nums[i]==n)
            //    {
            //        n++;
            //    }

            //}
            return result;
        }
        #endregion
        #region 哈希数组统计相同距离点数
        public int NumberOfBoomerangs(int[][] points)
        {
            var ans = 0;
            foreach (var p1 in points)
            {
                //p1距离为distanceMap的点个数
                var distanceMap = new Dictionary<int, int>();
                foreach (var p2 in points)
                {
                    var dx = p1[0] - p2[0];
                    var dy = p1[1] - p2[1];
                    if (distanceMap.ContainsKey(dx * dx + dy * dy))
                    {
                        distanceMap[dx * dx + dy * dy]++;
                    }
                    else
                    {
                        distanceMap.Add(dx * dx + dy * dy, 1);
                    }
                }
                foreach (var x in distanceMap)
                {
                    ans += x.Value * (x.Value - 1);
                }
            }
            return ans;
        }
        #endregion
        #region 独一无二的出现次数
        public static bool UniqueOccurrences(int[] arr)
        {
            /*给你一个整数数组 arr，请你帮忙统计数组中每个数的出现次数。
             * 如果每个数的出现次数都是独一无二的，就返回 true；否则返回 false*/
            Array.Sort(arr);
            int[] nums = new int[arr.Length];
            int n = 1;
            int a = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    if (nums.Contains(n))
                    {
                        return false;
                    }
                    else
                    {
                        nums[a] = n;
                        a++;
                        n = 1;
                    }
                }
                else
                {
                    n++;
                }
            }
            if (nums.Contains(n))
            {
                return false;
            }
            return true;
        }
        #endregion
        #region 拼写单词
        public static int CountCharacters(string[] words, string chars)
        {
            /*给你一份『词汇表』（字符串数组） words 和一张『字母表』（字符串） chars。
             * 假如你可以用 chars 中的『字母』（字符）拼写出 words 中的某个『单词』（字符串），那么我们就认为你掌握了这个单词。
             * 注意：每次拼写（指拼写词汇表中的一个单词）时，chars 中的每个字母都只能用一次。
             * 返回词汇表 words 中你掌握的所有单词的 长度之和。
             * 输入：words = ["cat", "bt", "hat", "tree"], chars = "atach"
             * * 输出：6
             * 解释： 
             * 可以形成字符串 "cat" 和 "hat"，所以答案是 3 + 3 = 6。
             * 示例 2：
             * 输入：words = ["hello", "world", "leetcode"], chars = "welldonehoneyr"
             * 输出：10
             * 解释：
             * 可以形成字符串 "hello" 和 "world"，所以答案是 5 + 5 = 10。
            */
            int n = 0;
            int[] nums = new int[26];
            for (int i = 0; i < chars.Length; i++)
            {
                nums[chars[i] - 'a']++;
            }
            int[] temp = new int[nums.Length];
            for (int i = 0; i < words.Length; i++)
            {
                bool flag = false;
                nums.CopyTo(temp, 0);
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (!chars.Contains(words[i][j]))
                    {
                        flag = true;
                        break;
                    }
                    else
                    {
                        if (temp[words[i][j] - 'a'] <= 0)
                        {
                            flag = true;
                            break;
                        }
                        else
                        {
                            temp[words[i][j] - 'a']--;
                        }
                    }
                }
                if (!flag)
                {
                    n += words[i].Length;
                }
            }
            return n;
        }
        #endregion
        #region 最小移动次数使数组元素相等
        public int MinMoves(int[] nums)
        {
            /*给定一个长度为 n 的非空整数数组，找到让数组所有元素相等的最小移动次数。每次移动将会使 n - 1 个元素增加 1。*/
            /*假设目前数组总和为sum，我们需要移动次数为m，那么整体数组总和将会增加m * (n - 1)，这里的n为数组长度，
             * 最后数组所有元素都相等为x，于是有：
             * sum + m * (n - 1) = x * n (1)
             * 我们再设数组最小的元素为min_val，m = x - min_val​，即 ​x = m + min_val​带入(1)得：
             * m = sum - min_val * n​
             */
            int sum = 0;
            int min = int.MaxValue;
            int len = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            return sum - min * len;
        }
        #endregion
        #region 求根到叶子节点数字之和
        public int SumNumbers(TreeNode root)
        {
            /*给定一个二叉树，它的每个结点都存放一个 0 - 9 的数字，每条从根到叶子节点的路径都代表一个数字。
             * 例如，从根到叶子节点路径 1->2->3 代表数字 123。
             * 计算从根到叶子节点生成的所有数字之和。
             * 说明: 叶子节点是指没有子节点的节点。*/
            return dfs(root, 0);
        }
        private int dfs(TreeNode root, int presum)
        {
            if (root == null)
            {
                return 0;
            }
            int sum = presum * 10 + root.val;
            if (root.left == null && root.right == null)
            {
                return sum;
            }
            else
            {
                return dfs(root.left, sum) + dfs(root.right, sum);
            }
        }
        #endregion
        #region 分发饼干
        public int FindContentChildren(int[] g, int[] s)
        {
            int result = 0;
            int temp = 0;
            Array.Sort(g);
            Array.Sort(s);
            for (int i = 0; i < g.Length; i++)
            {
                for (int j = temp; j < s.Length; j++)
                {
                    if (g[i] <= s[j])
                    {
                        result++;
                        temp = j + 1;
                        continue;
                    }
                }
            }
            return result;
        }
        #endregion
        #region 汉明距离
        public static int HammingDistance(int x, int y)
        {
            int a1 = 100100 & 0;
            string a = Convert.ToString(100, 2);
            string b = Convert.ToString(1, 2);
            int n1 = a.Length - 1;
            int n2 = b.Length - 1;
            int result = 0;
            while (n1 >= 0 && n2 >= 0)
            {
                if (a[n1] != b[n2])
                {
                    result++;

                }
                n1--;
                n2--;
            }
            for (int i = 0; i <= n1; i++)
            {
                if (a[i] == '1')
                {
                    result++;
                }
            }
            for (int i = 0; i <= n2; i++)
            {
                if (b[i] == '1')
                {
                    result++;
                }
            }
            return result;
            #region 移位
            int xor = x ^ y;
            int distance = 0;
            while (xor != 0)
            {
                if (xor % 2 == 1)
                {
                    distance += 1;
                }
                xor = xor >> 1;//右移1位
            }
            return distance;
            #endregion
            #region 布
            int xor1 = x ^ y;
            int distance1 = 0;
            while (xor1 != 0)
            {
                distance1 += 1;
                xor1 = xor1 & (xor1 - 1);
            }
            return distance1;
            #endregion
        }
        #endregion
        #region 岛屿的周长
        public int IslandPerimeter(int[][] grid)
        {
            int n = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        if (i == 0 || grid[i - 1][j] == 0)
                        {
                            n++;
                        }
                        if (i == grid.Length - 1 || grid[i + 1][j] == 0)
                        {
                            n++;
                        }
                        if (j == 0 || grid[i][j - i] == 0)
                        {
                            n++;
                        }
                        if (j == grid[0].Length - 1 || grid[i][j + 1] == 0)
                        {
                            n++;
                        }
                    }
                }
            }
            return n;
            #region 递归
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        return dfs(grid, i, j);
                    }
                }
            }
            return 0;
            #endregion
        }
        private int dfs(int[][] grid, int r, int c)
        {
            if (!(0 <= r && r < grid.Length && 0 <= c && c < grid[0].Length))
            {
                return 1;
            }
            if (grid[r][c] == 0)
            {
                return 0;
            }
            grid[r][c] = 2;
            return dfs(grid, r - 1, c) + dfs(grid, r + 1, c) + dfs(grid, r, c - 1) + dfs(grid, r, c + 1);
        }
        #endregion
        #region 数字的补数
        public int FindComplement(int num)
        {
            /*5的二进制是：0101，7的二进制是： 0111，它们的抑或为：0010，去掉前导零位即为取反。
             * 再来一个例子，假设a为1110 0101，b为1111 1111，a^b = 0001 1010是a的取反。也就是说二
             * 进制位数与num相同，且全为1的数tmp与num的抑或即为所求。*/
            long temp = 1;
            while (num >= temp)
            {
                temp <<= 1;
            }
            return (int)(temp - 1 - num);
        }
        #endregion
        #region        密钥格式化
        public static string LicenseKeyFormatting(string S, int K)
        {
            string[] arr = S.ToUpper().Split("-");

            string result = "";
            for (int i = 0; i < arr.Length; i++)
            {
                result += i;
            }
            for (int i = result.Length - K; i > 0; i -= K)
            {
                result = result.Insert(i, "-");
            }
            return result;
        }
        #endregion
        #region 最大连续1的个数
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int n = 0;
            int num = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    num++;
                }
                if (nums[i] == 0)
                {
                    if (num > n)
                    {
                        n = num;
                    }
                    num = 0;
                }
            }
            return n;
        }
        #endregion
        #region 构造矩形
        public static int[] ConstructRectangle(int area)
        {
            int[] result = new int[2];
            int a = (int)Math.Sqrt(area);
            int b = a;
            while (a * b != area)
            {
                if (a * b < area)
                {
                    b++;
                }
                else
                {
                    a--;
                }
            }
            result[0] = a;
            result[1] = b;
            while (area % a != 0)
            {
                --a;
            }
            result[0] = area / a;
            result[1] = a;
            return result;
        }

        #endregion
        #region 下一个更大元素 I
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums2.Length - 1; i++)
            {
                for (int j = i; j < nums2.Length; j++)
                {
                    if (nums2[i + 1] > nums2[i])
                    {
                        dic.Add(nums2[i], nums2[i + 1]);
                    }
                    else if (i == nums2.Length - 1)
                    {
                        dic.Add(nums2[i], -1);
                    }
                }


            }
            dic.Add(nums2[nums2.Length - 1], -1);
            for (int i = 0; i < nums1.Length; i++)
            {
                dic.TryGetValue(nums1[i], out int values);
                nums1[i] = values;
            }
            return nums1;
        }
        #endregion
        #region 七进制
        public string ConvertToBase7(int num)
        {
            //逢7进一
            StringBuilder str = new StringBuilder();
            while (Math.Abs(num) > 7)
            {
                str.Insert(0, num % 7);
                num = num / 7;
            }
            str.Insert(0, num);
            return str.ToString();
        }
        #endregion
        #region 键盘行
        public static string[] FindWords(string[] words)
        {
            //给定一个单词列表，只返回可以使用在键盘同一行的字母打印出来的单词。键盘如下图所示。
            string[] str = { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
            List<string> result = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                bool flag = false;
                int n = 0;
                char a = words[i].ToLower()[0];
                if (str[0].Contains(a))
                {
                    n = 0;
                }
                else if (str[1].Contains(a))
                {
                    n = 1;
                }
                else if (str[2].Contains(a))
                {
                    n = 2;
                }
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (!str[n].Contains(words[i][j]))
                    {
                        flag = true;
                    }
                }
                if (!flag)
                {
                    result.Add(words[i]);
                }
            }
            return result.ToArray();
        }
        #endregion
        #region 有效山脉数
        public static bool ValidMountainArray(int[] A)
        {
            //双指针、前后同时判断
            int n = A.Length;
            if (n <= 2)
            {
                return false;
            }
            int f = 0;
            int b = n - 1;
            for (int i = 0; i <= n - 2; i++)
            {
                if (A[i] > A[i + 1])
                {
                    if (i == 0)
                    {
                        return false;
                    }
                    if (i + 1 == n - 1)
                    {
                        break;
                    }
                    for (int j = i + 1; j < n - 2; j++)
                    {
                        if (A[j] < A[j + 1])
                        {
                            return false;
                        }
                    }
                }
                if (i + 1 == n - 1)
                {
                    return false;
                }
            }
            return true;
            //for (int i = 0; i < A.Length-1; i++)
            //{
            //    if (A[i+1]== A[i])
            //    {
            //        return false;
            //    }
            //    if (A[i]> A[i+1]&&(i==0||i==n-2))
            //    {
            //        return false;
            //    }
            //    if (i)
            //    {

            //    }
            //    if (A[i] > A[i + 1])
            //    {
            //        for (int j = n-1; j > i; j++)
            //        {
            //            if (A[j] > A[j-1] && (i !=j-1))
            //            {
            //                return false;
            //            }
            //        }
            //    }
            //}
            return true;
        }
        #endregion
        #region 相对名次
        public static string[] FindRelativeRanks(int[] nums)
        {
            //分数越靠前，分数不同
            string[] result = new string[nums.Length];
            int[] temp = (int[])nums.Clone();
            Dictionary<int, string> dic = new Dictionary<int, string>();
            Array.Sort(temp);
            Array.Reverse(temp);
            for (int i = 0; i < temp.Length; i++)
            {
                if (i == 0)
                {
                    dic.Add(temp[i], "Gold Medal");
                }
                else if (i == 1)
                {
                    dic.Add(temp[i], "Silver Medal");
                }
                else if (i == 2)
                {
                    dic.Add(temp[i], "Bronze Medal");
                }
                else
                {
                    dic.Add(temp[i], (i + 1).ToString());
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                dic.TryGetValue(nums[i], out string value);
                result[i] = value;
            }
            return result;
        }
        #endregion
        #region  完美数
        public bool CheckPerfectNumber(int num)
        {
            /*对于一个 正整数，如果它和除了它自身以外的所有 正因子 之和相等，我们称它为 「完美数」。
             * 给定一个 整数 n， 如果是完美数，返回 true，否则返回 false。*/
            int sum = 1;

            for (int i = 2; i * i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                    if (i * i != num)
                    {
                        sum += num / i;
                    }
                }
            }
            return sum - num == num;

        }
        #endregion
        #region 插入区间
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            List<int[]> ans = new List<int[]>(intervals.Length + 1);
            //int[][] ans= new int[intervals.Length+1][] ;
            bool flag = false;
            //遍历元区间，比较左右边界，进行判断新区间是否放置进答案
            for (int i = 0; i < intervals.Length; i++)
            {
                //新区建左边界大于目前区间右边界
                if (newInterval[0] > intervals[i][1])
                {
                    //直接插入结果集合
                    ans.Add(intervals[i]);
                    continue;
                }
                //新区间的右边界小于目前区间 左边界
                if (newInterval[1] < intervals[i][0])
                {
                    //直接插入新区建
                    ans.Add(newInterval);
                    //flag 设置为true
                    flag = !flag;
                    //把后面的区间都插入结果集合
                    for (; i < intervals.Length; i++)
                        ans.Add(intervals[i]);
                    break;
                }
                //新区间处于目前区间范围 进行区间合并
                //最小值为目前区间和新区间最小值  最大值为他俩中的最大的
                newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
                newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
            }
            //如果没找到合适的机会插入新区建，这里要插入
            if (!flag)
                ans.Add(newInterval);

            return ans.ToArray();

        }
        #endregion
        #region 斐波那契数
        public int Fib(int N)
        {
            int sum = 0;
            int n = 1;
            for (int i = 2; i <= N; i++)
            {
                int temp = sum; ;
                sum = +n;
                n = sum;
            }
            return sum;
        }
        #endregion
        #region 检测大写字母
        public static bool DetectCapitalUse(string word)
        {
            string a = word[0].ToString().ToUpper() + word.Substring(1, word.Length - 1).ToLower();
            return word.ToLower() == word || word.ToUpper() == word || a == word;
        }
        #endregion
        #region 单词接龙
        public static int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            if (!wordList.Contains(endWord))
            {
                return 0;
            }
            int len = beginWord.Length;
            var dic = new Dictionary<string, List<string>>(wordList.Count);
            foreach (var item in wordList)
            {
                for (int i = 0; i < len; i++)
                {
                    string ch = $"{item.Substring(0, i)}*{item.Substring(i + 1)}";
                    if (dic.ContainsKey(ch))
                    {
                        dic[ch].Add(item);
                    }
                    else
                    {
                        dic.Add(ch, new List<string> { item });
                    }
                }
            }
            Queue<KeyValuePair<string, int>> queue = new Queue<KeyValuePair<string, int>>(wordList.Count);
            queue.Enqueue(new KeyValuePair<string, int>(beginWord, 1));
            while (queue.Count != 0)
            {
                var point = queue.Dequeue();
                string word = point.Key;
                int count = point.Value;
                for (int i = 0; i < len; i++)
                {
                    string ch = $"{word.Substring(0, i)}*{word.Substring(i + 1, len - i - 1)}";
                    if (dic.ContainsKey(ch))
                    {
                        foreach (var item in dic[ch])
                        {
                            if (item == endWord)
                            {
                                return ++count;
                            }
                            queue.Enqueue(new KeyValuePair<string, int>(item, count + 1));
                        }
                        dic.Remove(ch);
                    }
                }
            }
            return 0;
            //if (flag(beginWord, endWord))
            //{
            //    return 1;
            //}
            //return dfs(beginWord,0, wordList);
        }
        //private static int dfs(string  str,int num, IList<string> wordList)
        //{
        //    int n = 0;
        //    while (n< wordList.Count())
        //    {
        //        if (flag(str, wordList[n]))
        //        {              
        //            str = wordList[n];
        //            wordList.Remove(wordList[n]);
        //             num=  dfs(str,num+1,wordList );
        //        }
        //        else
        //        {
        //            n++;
        //        }
        //    }
        //    if (n== wordList.Count())
        //    {
        //        return 0;
        //    }
        //    return num;
        //}
        //private static bool flag(string str,string end)
        //{
        //    int num =0;
        //    int n = 0;
        //    while (num<str.Length)
        //    {
        //        if (str[num]==end[num])
        //        {
        //            n++;
        //        }
        //    }
        //    if (str.Length-1==n)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        #endregion
        #region 最长特殊序列 Ⅰ
        public int FindLUSlength(string a, string b)
        {
            if (a == b)
            {
                return -1;
            }
            return a.Length > b.Length ? a.Length : b.Length;
        }
        #endregion
        #region 反转字符串 II
        public string ReverseStr(string s, int k)
        {
            char[] a = s.ToArray();
            for (int start = 0; start < a.Length; start += 2 * k)
            {
                int i = start, j = Math.Min(start + k - 1, a.Length - 1);
                while (i < j)
                {
                    char tmp = a[i];
                    a[i++] = a[j];
                    a[j--] = tmp;
                }
            }
            return new string(a);
        }
        #endregion
        #region 根据数字二进制1的数目排序

        public static int[] SortByBits(int[] arr)
        {
            // [0,1,2,3,4,5,6,7,8],根据二进制的1的数目排序

            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = bitCount(arr[i]) * 100_000 + arr[i];
            }
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] %= 100_000;
            }
            return arr;
        }

        //得到1的个数
        private static int bitCount(int x)
        {
            int res = 0;
            while (x != 0)
            {
                res += (x % 2);
                x /= 2;
            }
            return res;
        }
        #endregion
        #region 二叉树的直径
        int max = 0;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            dfs1(root);
            return max;
        }
        private int dfs1(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int left = dfs1(root.left);
            int right = dfs1(root.right);
            max = Math.Max(left + right, max);
            return Math.Max(right, left) + 1;
        }
        #endregion
        #region 学生出勤管理
        public static bool CheckRecord(string s)
        {
            int a = 0;
            for (int i = 0; i < s.Length; i++)
            {

                if (s[i] == 'A')
                {
                    a += 1;

                    if (a > 1)
                    {
                        return false;
                    }

                }
                //if (s[i]=='L')
                //{
                //    switch (l)
                //    {
                //        case 0:l= 1;
                //            break;
                //        case 1:l = 2;
                //            break;
                //        case 2:
                //            return false;
                //    }
                //}
                //if (a>1&&l>2)
                //{
                //    return false;
                //}
            }
            return true && (!s.Contains("LLL"));
        }
        #endregion
        #region 最接近远点的K个点
        public static int[][] KClosest(int[][] points, int K)
        {
            Array.Sort<int[]>(points, (x, y) => ((x[0] * x[0]) + (x[1] * x[1])).CompareTo((y[0] * y[0]) + (y[1] * y[1])));


            int[][] result = new int[K][];
            if (points == null || K >= 0 || points.Length < K)
            {
                return new int[0][];
            }
            int len = points.Length;//长度
            int left = 0;//左边界
            int right = len - 1;//右边界
            int cur = -1;
            //points进行快排
            while (cur != K - 1)
            {
                cur = Pa(points, left, right);
                if (cur < K - 1)
                {
                    left = cur + 1;
                }
                if (cur > K - 1)
                {
                    right = cur - 1;
                }
            }
            Array.Copy(points, result, K);
            return result;
            //Dictionary<int, double> dic = new Dictionary<int, double>();
            //double[] p = new double[points.Length];
            //int i = 0;
            //foreach (var item in points)
            //{
            //    p[i] = Math.Sqrt(item[0] * item[0] + item[1] * item[1]);
            //    dic.Add(i, p[i]);               
            //    i++;
            //}
            //Array.Sort(p);
            //for (int j = 0; j < K;j++)
            //{
            //    foreach (var item in dic)
            //    {
            //        if (item.Value==p[j])
            //        {
            //            result[j] = points[item.Key];
            //            dic.Remove(item.Key);
            //            break;
            //        }
            //    }
            //}
            //return result;
        }
        /// <summary>
        /// 一轮快排
        /// </summary>
        /// <param name="points">原数组</param>
        /// <param name="left">左边界</param>
        /// <param name="right">右边界</param>
        /// <returns></returns>
        private static int Pa(int[][] points, int left, int right)
        {
            int[] temp = points[left];
            int leftValue = points[left][0] * points[left][0] + points[left][1] * points[left][1];
            while (left < right)
            {
                while (left < right && (points[right][0] * points[right][0] + points[right][1] * points[right][1]) >= leftValue)
                {
                    right--;
                }
                if (left < right)
                {
                    ExPoints(points, left, right);
                }
                while (left < right && (points[left][0] * points[left][0] + points[left][1] * points[left][1]) >= leftValue)
                {
                    left--;
                }
                if (left < right)
                {
                    ExPoints(points, left, right);
                }
            }
            ExPoints(points, left, right);
            return left;
        }

        /// <summary>
        /// 交换指定下标的两个元素
        /// </summary>
        /// <param name="sPoints">原数组</param>
        /// <param name="index1">下标1</param>
        /// <param name="index2">下标2</param>
        private static void ExPoints(int[][] sPoints, int index1, int index2)
        {
            int[] temp = sPoints[index1];
            sPoints[index1] = sPoints[index2];
            sPoints[index2] = temp;
        }
        #endregion
        #region N叉树的最大深度
        public int MaxDepth(Node root)
        {
            int depth = 0;
            if (root == null)
                return 0;
            foreach (Node n in root.children)
            {
                depth = Math.Max(MaxDepth(n), depth);
            }
            return depth + 1;

        }

        #endregion
        #region 反转字符串中的单词 III
        public static string ReverseWords(string s)
        {
            /*给定一个字符串，你需要反转字符串中每个单词的字符顺序，同时仍保留空格和单词的初始顺序。*/
            string[] str = s.Split(" ").ToArray();
            for (int i = 0; i < str.Length; i++)
            {
                StringBuilder res1 = new StringBuilder();
                for (int j = str[i].Length - 1; j >= 0; j--)
                {
                    res1.Append(str[i][j]);
                };
                str[i] = res1.ToString();
            }
            StringBuilder res = new StringBuilder();
            res.Append(str[0]);
            for (int i = 1; i < str.Length; i++)
            {
                res.Append(" ");
                res.Append(str[i]);
            }
            return res.ToString();
        }
        #endregion
        #region 下一个排列
        public void NextPermutation(int[] nums)
        {
            // 从右到做，找到数组中比后面小的数组索引
            int i = nums.Length - 2;
            while (i >= 0 && nums[i] >= nums[i + 1])
            {
                i--;
            }

            // 如果没找到i=-1，说明数组此时是顺序降序状态，那么下一个数字就是顺序升序数组
            if (i >= 0)
            {
                // 从右到做，找到数组中不大于i的数组索引
                int j = nums.Length - 1;
                while (j >= 0 && nums[i] >= nums[j])
                {
                    j--;
                }

                // 交换i和j的位置
                Swap(nums, i, j);
            }

            // 交换i之后，以j为中心点的，两端的索引位置
            Reverse(nums, i + 1);
        }

        public void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        public void Reverse(int[] nums, int start)
        {
            int left = start, right = nums.Length - 1;
            while (left < right)
            {
                Swap(nums, left, right);
                left++;
                right--;
            }
        }
        #endregion
        #region 数组拆分|
        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            int result = 0;
            for (int i = 0; i < nums.Length; i += 2)
            {
                result += nums[i];
            }
            return result;
        }


        #endregion
        #region 二叉树的坡度
        int sumTree = 0;
        public int FindTilt(TreeNode root)
        {
            Dfs(root);
            return sumTree;
        }
        public int Dfs(TreeNode root)
        {
            if (root == null)
            {
                //递归出
                return 0;
            }
            int leftSum = Dfs(root.left);//左子树节点之和
            int rightSum = Dfs(root.right);//右子树节点之和
            sumTree += Math.Abs(leftSum - rightSum);//计算当前节点的坡度
            return root.val + leftSum + rightSum;
        }
        #endregion
        #region 自由之路
        Dictionary<char, IList<int>> charInRing = new Dictionary<char, IList<int>>();
        public int FindRotateSteps(string ring, string key)
        {
            int?[,] dp = new int?[ring.Length, key.Length];
            for (int i = 0; i < ring.Length; i++)
            {
                if (!charInRing.ContainsKey(ring[i]))
                    charInRing[ring[i]] = new List<int>();
                charInRing[ring[i]].Add(i);
            }

            // 旋转表盘的步数+按下的步数
            return Helper(ref ring, ref key, 0, 0, dp) + key.Length;
        }

        private int Helper(ref string ring, ref string key, int ringidx, int keyidx, int?[,] dp)
        {
            if (keyidx == key.Length)
                return 0;
            if (dp[ringidx, keyidx].HasValue)
                return dp[ringidx, keyidx].Value;

            int res = int.MaxValue;
            // 获得目标字符在表盘中的位置（可能有多个）
            foreach (var k in charInRing[key[keyidx]])
            {
                var moves = Math.Min(ring.Length + ringidx - k, Math.Min(Math.Abs(ringidx - k), ring.Length - ringidx + k));
                res = Math.Min(res, moves + Helper(ref ring, ref key, k, keyidx + 1, dp));
            }
            dp[ringidx, keyidx] = res;
            return res;
        }


        private static string Str(string str, int i)
        {
            StringBuilder res = new StringBuilder();
            res.Append(str.Substring(i, str.Length - i));
            res.Append(str.Substring(0, i));
            return res.ToString();
        }
        #endregion
        #region 分糖果
        public int DistributeCandies(int[] candies)
        {
            int num = candies.Length;
            int a = num / 2;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < num; i++)
            {
                if (dic.ContainsKey(candies[i]))
                {
                    dic[candies[i]]++;
                }
                else
                {
                    dic.Add(candies[i], 1);
                }
            }
            int res = dic.Count();
            if (res < a)
            {
                return res;
            }
            else
            {
                return a;
            }

        }
        #endregion
        #region 按奇偶排序数组 II
        public int[] SortArrayByParityII(int[] A)
        {
            /*是否能够整除2*/
            int[] a = new int[A.Length / 2];
            int[] b = new int[A.Length / 2];
            int o = 0, n = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    a[o] = A[i];
                    o++;
                }
                else
                {
                    b[n] = A[i];
                    n++;
                }
            }
            o--; n--;
            for (int i = 0; i < A.Length; i += 2)
            {
                A[i] = a[o--];
            }
            for (int i = 1; i < A.Length; i += 2)
            {
                A[i] = a[n--];
            }
            return A;
        }
        #endregion
        #region 重塑矩阵
        public static int[][] MatrixReshape(int[][] nums, int r, int c)
        {
            int a = nums.Length * nums[0].Length;
            if (r * c != a)
            {
                return nums;
            }
            int[][] res = new int[r][];
            for (int i = 0; i < r; i++)
            {
                res[i] = new int[c];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums[0].Length; j++)
                {
                    var n = i * nums[0].Length + j;
                    res[n / c][n % c] = nums[i][j];//str[0];

                }
            }
            return res;
        }
        #endregion
        #region 另一个树的子树
        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            if (s == null && t == null)
            {
                return true;
            }
            else if (s == null || t == null)
            {
                return false;
            }
            else if (s.val == t.val)
            {
                return (IsTree(s, t)) || IsTree(s.left, t) || IsTree(s.right, t);
            }
            else
            {
                return IsTree(s.left, t) || IsTree(s.right, t);
            }

        }
        private bool IsTree(TreeNode s, TreeNode t)
        {
            if (s == null && t == null)
            {
                return true;
            }
            else if (s == null || t == null)
            {
                return false;
            }
            else if (s.val != t.val)
            {
                return false;
            }
            return IsTree(s.left, t.left) && IsTree(s.right, t.right);
        }
        #endregion
        #region N叉树的前序遍历
        public IList<int> Preorder(Node root)
        {
            #region 递归


            IList<int> res = new List<int>();
            if (root == null)
            {
                return res;
            }
            pro(root, res);
            return res;
            #endregion
            #region 迭代
            Stack<Node> stack = new Stack<Node>();
            IList<int> re = new List<int>();
            if (root == null)
            {
                return re;
            }
            stack.Push(root);
            while (stack.Count != 0)
            {
                Node node = stack.Pop();
                re.Add(node.val);
                for (int i = node.children.Count - 1; i >= 0; --i)
                {
                    stack.Push(node.children[i]);
                }
            }
            return re;
            #endregion
        }
        private void pro(Node root, IList<int> res)
        {
            if (root == null)
            {
                return;
            }
            res.Add(root.val);
            int size = root.children.Count();
            for (int i = 0; i < size; i++)
            {
                Node node = root.children[i];
                if (node != null)
                {
                    pro(node, res);
                }
            }
        }
        #endregion
        #region N叉树的后序遍历

        public IList<int> Postorder(Node root)
        {
            var Traversal = new List<int>();
            if (root == null) return Traversal;
            var S = new Stack<Node>();
            S.Push(root);

            // 把孩子们正序压入栈中，并用头插法插入节点值
            while (S.Count != 0)
            {
                Node cur = S.Pop();
                Traversal.Insert(0, cur.val);
                for (int i = 0; i < cur.children.Count; i++)
                {
                    S.Push(cur.children[i]);
                }
            }
            return Traversal;
        }
        #endregion
        #region 最长和谐子序列 
        public int FindLHS(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]]++;
                }
                else
                {
                    dic.Add(nums[i], 1);
                }
            }
            int res = 0, sum = 0;
            foreach (var item in dic.Keys)
            {
                if (dic.ContainsKey(item + 1))
                {
                    sum = dic[item] + dic[item + 1];
                }
                res = Math.Max(res, sum);
            }
            return res;
            //Array.Sort(nums);
            //int a = 0;
            //int b = nums.Length - 1;
            //int len = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = b; j >=0; j--)
            //    {
            //        if (nums[j]-nums[i]==1)
            //        {
            //          len=  Math.Max((j-i),len);
            //        }
            //    }
            //}
            //return len;
        }

        #endregion
        #region 奇偶链表
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null)
            {
                return head;
            }
            ListNode evenHead = head.next;
            ListNode odd = head, even = evenHead;
            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }
            odd.next = evenHead;
            return head;
        }
        #endregion
        #region 数组的相对排序
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            if (arr2.Length == 0)
            {
                Array.Sort(arr1);
                return arr1;
            }
            int[] res = new int[arr1.Length];
            Dictionary<int, int> dic = new Dictionary<int, int>();
            List<int> temp = new List<int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                if (!arr2.Contains(arr1[i]))
                {
                    temp.Add(arr1[i]);
                }
                else if (dic.ContainsKey(arr1[i]))
                {
                    dic[arr1[i]]++;
                }
                else
                {
                    dic.Add(arr1[i], 1);
                }
            }
            int j = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int k = 0; k < dic[arr2[i]]; k++)
                {
                    res[j] = arr2[i];
                    j++;
                }
            }
            temp.Sort();
            int l = 0;
            for (; j < res.Length; j++)
            {
                res[j] = temp[l];
                l++;
            }
            return res;
        }
        #endregion
        #region 范围求和||
        public int MaxCount(int m, int n, int[][] ops)
        {

            foreach (var item in ops)
            {
                m = Math.Min(m, item[0]);
                n = Math.Min(n, item[1]);
            }
            return m * n;
            //int [][]arr = new int[m][];

            //foreach (var item in ops)
            //{       
            //    for (int i = 0; i < item[0]; i++)
            //    {
            //        for (int j = 0; j < item[1]; j++)
            //        {
            //            arr[i] = new int[n]; 
            //            if (arr[i][j] == arr[0][0])
            //            {
            //                arr[i][j] += 1;
            //            }
            //        }
            //    }
            //}
            //int count = 0;
            //for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (arr[i][j]==arr[0][0])
            //        {
            //            count++;
            //        }
            //    }
            //}
            //return count;
        }
        #endregion
        #region 根据身高重建队列
        public int[][] ReconstructQueue(int[][] people)
        {
            var comparer = Comparer<int[]>.Create((int[] a, int[] b) =>
            {
                if (a[0] != b[0])
                {
                    return b[0].CompareTo(a[0]);
                }
                else
                {
                    return a[1].CompareTo(b[1]);
                }
            });
            Array.Sort(people, comparer);
            var result = new List<int[]>();
            foreach (var item in people)
            {
                result.Insert(item[1], item);
            }
            return result.ToArray();
        }
        #endregion
        #region 距离顺序排列矩阵单元格
        public int[][] AllCellsDistOrder(int R, int C, int r0, int c0)
        {
            int maxDistinct = Math.Max(r0, R - 1 - r0) + Math.Max(c0, C - 1 - c0);
            List<List<int[]>> buket = new List<List<int[]>>();
            for (int i = 0; i < maxDistinct; i++)
            {
                buket.Add(new List<int[]>());
            }
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    int d = dist(i, j, r0, c0);
                    buket[d].Add(new int[] { i, j });
                }
            }
            int[][] ret = new int[R * C][];
            int index = 0;
            for (int i = 0; i < maxDistinct; i++)
            {
                foreach (var item in buket[i])
                {
                    ret[index++] = item;
                }
            }
            return ret;
        }
        private int dist(int r1, int c1, int r2, int c2)
        {
            return Math.Abs(r1 - r2) + Math.Abs(c1 - c2);
        }
        #endregion
        #region 排序链表
        public ListNode SortList(ListNode head)
        {
            return SortList(head, null);
        }
        public ListNode SortList(ListNode head, ListNode tail)
        {
            if (head == null)
            {
                return head;
            }
            if (head.next == tail)
            {
                head.next = null;
                return head;
            }
            ListNode slow = head, fast = head;
            while (fast != tail)
            {
                slow = slow.next;
                fast = fast.next;
                if (fast != tail)
                {
                    fast = fast.next;
                }
            }
            ListNode mid = slow;
            ListNode list1 = SortList(head, mid);
            ListNode list2 = SortList(mid, tail);
            ListNode sorted = Merge(list1, list2);
            return sorted;
        }
        public ListNode Merge(ListNode head1, ListNode head2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode temp = dummyHead, temp1 = head1, temp2 = head2;
            while (temp1 != null && temp2 != null)
            {
                if (temp1.val <= temp2.val)
                {
                    temp.next = temp1;
                    temp1 = temp1.next;
                }
                else
                {
                    temp.next = temp2;
                    temp2 = temp2.next;
                }
                temp = temp.next;
            }
            if (temp1 != null)
            {
                temp.next = temp1;
            }
            else if (temp2 != null)
            {
                temp.next = temp2;
            }
            return dummyHead.next;
        }
        #endregion
        #region 用最少的箭引爆最多的气球
        public static int FindMinArrowShots(int[][] points)
        {
            if (points == null || points.Length == 0)
            {
                return 0;
            }
            Array.Sort(points, (a, b) =>
            {
                if (a[1] == b[1])
                {
                    return 0;
                }
                else if (a[1] < b[1])
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            });
            int count = 0;
            int i = 0;
            while (i < points.Length)
            {
                int right = points[i][1];
                i++;
                while (i < points.Length && points[i][0] <= right)
                {
                    i++;
                }
                count++;
            }
            return count;
        }
        #endregion
        #region  完全二叉树的节点个数
        int znum = 0;
        public int CountNodes(TreeNode root)
        {
            deep(root);
            return znum;
        }
        private int deep(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            znum++;
            if (root.left != null)
            {
                deep(root.left);
            }
            if (root.right != null)
            {
                deep(root.right);
            }
            return znum;
        }
        #endregion
        #region 上升下降字符串

        public string SortString(string s)
        {
            int[] num = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                num[s[i] - 'a']++;
            }

            StringBuilder ret = new StringBuilder();

            while (ret.Length < s.Length)
            {
                for (int i = 0; i < 26; i++)
                {
                    if (num[i] > 0)
                    {
                        ret.Append((char)(i + 'a'));
                        num[i]--;
                    }
                }
                for (int i = 25; i >= 0; i--)
                {
                    if (num[i] > 0)
                    {
                        ret.Append((char)(i + 'a'));
                        num[i]--;
                    }
                }
            }
            return ret.ToString();
        }
        #endregion
        #region 翻转对
        public static int ReversePairs(int[] nums)
        {

            if (nums.Length == 0)
            {
                //没有元素，返回0
                return 0;
            }
            return mergSort(nums, 0, nums.Length - 1);
        }
        //对当前的序列进行归并排序
        private static int mergSort(int[] nums, int start, int end)
        {
            if (start == end)
            {
                //不在构成序列，返回递归的出口
                return 0;
            }
            int mid = (start + end) / 2;//中点
            int n1 = mergSort(nums, start, mid);//左序列归并排序
            int n2 = mergSort(nums, mid + 1, end);//右序列归并排序
            int ret = n1 + n2;
            //此时左右序列都已经排序，现在合并，以及合并前的统计
            int i = start;//i指向左序列的开头
            int j = mid + 1;//j指向有序列的开头
            while (i <= mid)
            {
                while (j <= end && (long)nums[i] > 2 * (long)nums[j])
                {
                    j++;
                }
                ret += j - mid - 1;
                i++;
            }
            //合并两个排序数组
            int[] sortnum = new int[end - start + 1];
            int p1 = start, p2 = mid + 1;
            int p = 0;
            while (p1 <= mid || p2 <= end)
            {
                if (p1 > mid)
                {
                    sortnum[p++] = nums[p2++];
                }
                else if (p2 > end)
                {
                    sortnum[p++] = nums[p1++];
                }
                else
                {
                    if (nums[p1] < nums[p2])
                    {
                        sortnum[p++] = nums[p1++];
                    }
                    else
                    {
                        sortnum[p++] = nums[p2++];
                    }
                }
            }
            for (int n = 0; n < sortnum.Length; n++)
            {
                nums[start + n] = sortnum[n];
            }
            return ret;


        }

        #endregion
        #region 重构字符串
        public static string ReorganizeString(string S)
        {
            int len = S.Length;
            if (len < 2)
            {
                return S;
            }
            int[] arr = new int[26];
            int max_len = 0;
            foreach (var item in S)
            {
                if (max_len < ++arr[item - 'a'])
                {
                    max_len = arr[item - 'a'];
                }
            }
            if (max_len > (len + 1) / 2)
            {
                return "";
            }
            char[] ret = new char[len];
            int even = 0, odd = 1;
            for (int i = 0; i < 26; i++)
            {
                while (arr[i] > 0 && arr[i] < (len / 2 + 1) && odd < len)
                {
                    ret[odd] = (char)(i + 'a');
                    arr[i]--;
                    odd += 2;
                }
                while (arr[i] > 0)
                {
                    ret[even] = (char)(i + 'a');
                    arr[i]--;
                    even += 2;
                }
            }
            return new string(ret);


            //Dictionary<char, int> dic = new Dictionary<char, int>();
            //for (int i = 0; i < S.Length; i++)
            //{
            //    if (dic.ContainsKey(S[i]))
            //    {
            //        dic[S[i]]++;
            //    }
            //    else
            //    {
            //        dic.Add(S[i],1);
            //    }
            //}
            //int mid = S.Length / 2; ;
            //if (S.Length%2!=0)
            //{
            //    mid=mid+1;
            //}
            //StringBuilder res = new StringBuilder();
            //while (res.Length!=S.Length)
            //{
            //    StringBuilder res1 = new StringBuilder();
            //    foreach (var item in dic)
            //    {
            //        if (item.Value>mid)
            //        {
            //            return "";
            //        }
            //        if (item.Value>0)
            //        {
            //            res1.Append(item.Key);
            //        }
            //    }
            //    for (int i = 0; i < res1.Length; i++)
            //    {
            //        dic[res1[i]]--;
            //    }
            //    res.Append(res1);
            //}
            //return res.ToString();
        }
        #endregion
        #region 在排序数组中查找元素的第一个和最后一个位置
        public static int[] SearchRange(int[] nums, int target)
        {
            int[] res = new int[] { -1, -1 };
            int left = 0;
            int right = nums.Length;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (mid > nums.Length - 1)
                {
                    return res;
                }
                if (nums[mid] == target)
                {
                    for (int i = mid; i < nums.Length; i++)
                    {
                        if (nums[i] == target)
                        {
                            res[1] = i;
                        }
                    }
                    for (int i = mid; i >= 0; i--)
                    {
                        if (nums[i] == target)
                        {
                            res[0] = i;
                        }
                    }
                    return res;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
            }

            return res;

        }
        #endregion
        #region 拼接最大数
        public int[] MaxNumber(int[] nums1, int[] nums2, int k)
        {
            int[] res = new int[k];
            int n1 = nums1.Length;
            int n2 = nums2.Length;
            int start = Math.Max(0, k - n2), end = Math.Min(k, n1);
            for (int i = start; i <= end; i++)
            {
                int[] sub1 = Pick_max(nums1, i);
                int[] sub2 = Pick_max(nums2, k - i);
                int[] cur = Merge(sub1, sub2);
                if (Compare(cur, res, 0, 0) > 0)
                {
                    Array.Copy(cur, 0, res, 0, k);
                }
            }
            return res;
        }
        private int[] Pick_max(int[] nums, int k)
        {
            int len = nums.Length;
            int[] stack = new int[k];
            int top = -1;
            int remain = len - k;
            for (int i = 0; i < len; i++)
            {
                int num = nums[i];
                while (top >= 0 && stack[top] < num && remain > 0)
                {
                    top--;
                    remain--;
                }
                if (top < k - 1)
                {
                    stack[++top] = num;
                }
                else
                {
                    remain--;
                }
            }
            return stack;
        }
        private int[] Merge(int[] sub1, int[] sub2)
        {
            int a = sub1.Length, b = sub2.Length;
            if (a == 0)
            {
                return sub2;
            }
            if (b == 0)
            {
                return sub1;
            }
            int merglen = a + b;
            int[] m = new int[merglen];
            int n1 = 0, n2 = 0;
            for (int i = 0; i < merglen; i++)
            {
                if (Compare(sub1, sub2, n1, n2) > 0)
                {
                    m[i] = sub1[n1++];
                }
                else
                {
                    m[i] = sub2[n2++];
                }
            }
            return m;
        }
        private int Compare(int[] sub1, int[] sub2, int n1, int n2)
        {
            int a = sub1.Length, b = sub2.Length;
            while (n1 < a && n2 < b)
            {
                int dif = sub1[n1] - sub2[n2];
                if (dif != 0)
                {
                    return dif;
                }
                n1++;
                n2++;
            }
            return (a - n1) - (b - n2);
        }


        #endregion
        #region 两个列表的最小索引总和
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            int n = int.MaxValue;
            List<string> index = new List<string>();
            Dictionary<string, int> dic = new Dictionary<string, int>();

            for (int i = 0; i < list1.Length; i++)
            {
                dic.Add(list1[i], i);
            }
            for (int i = 0; i < list2.Length; i++)
            {
                if (dic.ContainsKey(list2[i]))
                {
                    if (i + dic[list2[i]] < n)
                    {
                        index.Clear();
                        index.Add(list2[i]);
                    }
                    else if (i + dic[list2[i]] == n)
                    {
                        index.Add(list2[i]);
                    }

                }
            }
            return index.ToArray();
        }
        #endregion
        #region 种花问题
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int count = 0, num = 0;
            //[1,0,0,0,1] n=1
            var temp = new int[flowerbed.Length + 2];
            temp[0] = 0;
            temp[temp.Length - 1] = 0;
            //temp[0,1,0,0,0,1,0]
            for (int i = 0; i < flowerbed.Length; i++)
            {
                temp[i + 1] = flowerbed[i];
            }
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == 0)
                {
                    count++;
                    if (count == 3)
                    {
                        num++;
                        count = 0;
                        i = i - 1;
                    }
                }
                else count = 0;
            }
            return num >= n;

        }

        #endregion
        #region 分隔数组为连续子序列
        public static bool IsPossible(int[] nums)
        {
            //新建两个字典
            Dictionary<int, int> dic1 = new Dictionary<int, int>(); //存储原数组中数字i出现的次数
            Dictionary<int, int> dic2 = new Dictionary<int, int>();//存储以数字i结尾的且符合题意的连续子序列个数
            //以nums =[1, 2, 3, 3, 4, 4, 5]
            //初始化：nc[1] = 1、nc[2] = 1、nc[3] = 2、nc[4] = 2、nc[5] = 1，tail[i]都为0
            foreach (var item in nums)
            {
                if (dic1.ContainsKey(item))
                {
                    dic1[item]++;
                }
                else
                {
                    dic1.Add(item, 1);
                }
            }
            foreach (var item in nums)
            {
                //检查数字 1, nc[1] > 0,并且 nc[2]> 0,nc[3] > 0，因此找到了一个长度为3的连续子序列 nc[1]、nc[2]、nc[3] 各自减一，并 tail[3] 加 1
                int count = dic1[item];
                if (count > 0)
                {
                    //判断item上一个结尾
                    int prevCount = dic2.GetValueOrDefault(item - 1, 0);
                    //如果大于0就就把item接到dic2上,dic2[item-1]-1;dic2[item]+1
                    if (prevCount > 0)
                    {
                        dic1[item] = count - 1;
                        if (dic2.ContainsKey(item - 1))
                        {
                            dic2[item - 1] = prevCount - 1;
                        }
                        else
                        {
                            dic2.Add(item - 1, prevCount - 1);
                        }
                        if (dic2.ContainsKey(item))
                        {
                            dic2[item] = dic2.GetValueOrDefault(item, 0) + 1;
                        }
                        else
                        {
                            dic2.Add(item, dic2.GetValueOrDefault(item, 0) + 1);
                        }
                    }
                    else
                    {
                        //但是 dic2[2]=0，因此不能接在前面，只能往后看(如果后面组不成，那就返回 false了)
                        int count1 = dic1.GetValueOrDefault(item + 1, 0);
                        int count2 = dic1.GetValueOrDefault(item + 2, 0);
                        if (count1 > 0 && count2 > 0)
                        {
                            //实际发现 dic1[4]>0,dic1[5]>0，因此找到了一个长度为3的连续子序列 dic1[3]、dic1[4]、dic1[5] 各自减一，并 dic2[5] 加 1
                            dic1[item] = count - 1;
                            dic1[item + 1] = count1 - 1;
                            dic1[item + 2] = count2 - 1;
                            if (dic2.ContainsKey(item + 2))
                            {
                                dic2[item + 2] = dic2[item + 2] + 1;
                            }
                            else
                            {
                                dic2.Add(item + 2, 1);
                            }

                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        #endregion
        #region 任务调度器
        public int LeastInterval(char[] tasks, int n)
        {
            int[] arr = new int[26];
            for (int i = 0; i < tasks.Length; i++)
            {
                arr[tasks[i] - 'A']++;
            }
            Array.Sort(arr);
            int num = 1;
            for (int j = arr.Length - 2; j >= 0; j--)
            {
                if (arr[j] < arr[j + 1])
                {
                    break;
                }
                num++;
            }
            return Math.Max((arr[^1] - 1) * (n + 1) + num, tasks.Length);
        }
        #endregion
        #region 翻转矩阵后的得分
        public static int MatrixScore(int[][] A)
        {
            int m = A.Length, n = A[0].Length;//m行，n列
            //对最左边列，最优情况取值都为1
            int res = m * (1 << (n - 1));
            for (int i = 1; i < n; i++)
            {
                //对其他列，统计该列0、1数量，最大值记录为num（即转换后的1的最大数量）
                //总贡献为 k*2^n-i-1
                //在这个过程中要考虑上一步对最左边列的转换，判断当第一个元素a[i][0]为0时，
                //  说明这列发生了转换，因此对0值应该取1，1应该取0
                int num = 0;
                for (int j = 0; j < m; j++)
                {
                    if (A[j][0] == 1)
                    {
                        num += A[j][i];
                    }
                    else
                    {
                        num += (1 - A[j][i]);//如果这一行反转，则该元素的实际值1-A[j][i]
                    }
                }
                int k = Math.Max(num, m - num);
                res += k * (1 << (n - i - 1));
            }
            return res;
        }
        #endregion
        #region 柠檬水找零
        public bool LemonadeChange(int[] bills)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            dic.Add(5, 0);
            dic.Add(10, 0);
            for (int i = 0; i < bills.Length; i++)
            {
                if (bills[i] == 5)
                {
                    dic[5]++;
                }
                else if (bills[i] == 10)
                {
                    if (dic[5] > 0)
                    {
                        dic[5]--;
                        dic[10]++;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (bills[i] == 20)
                {
                    if (dic[10] > 0 && dic[5] > 0)
                    {
                        dic[5]--;
                        dic[10]--;
                    }
                    else if (dic[5] > 3)
                    {
                        dic[5] = dic[5] - 3;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            return true;
        }
        #endregion
        #region 字母异位分组
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dic = new Dictionary<string, IList<string>>();
            IList<IList<string>> res = new List<IList<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                char[] a = strs[i].ToArray();
                Array.Sort(a);
                string str = String.Join("", a.Select(x => x.ToString()).ToArray());
                if (dic.ContainsKey(str))
                {
                    dic[str].Add(strs[i]);
                }
                else
                {
                    dic[str] = new List<string> { strs[i] };
                }

            }
            foreach (var item in dic.Keys)
            {
                res.Add(dic[item]);
            }
            return res;
        }
        public void operation(string a, string b)
        {

        }
        #endregion
        #region 单词规律
        public static bool WordPattern1(string pattern, string s)
        {
            Dictionary<char, int> dic1 = new Dictionary<char, int>();
            int n = 1;
            for (int i = 0; i < pattern.Length; i++)
            {
                if (!dic1.ContainsKey(pattern[i]))
                {
                    dic1.Add(pattern[i], n);
                    n++;
                }
            }
            StringBuilder b1 = new StringBuilder();
            for (int i = 0; i < pattern.Length; i++)
            {
                b1.Append(dic1[pattern[i]]);
            }
            Dictionary<string, int> dic2 = new Dictionary<string, int>();
            string[] arr = s.Split(" ").ToArray();
            n = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!dic2.ContainsKey(arr[i]))
                {
                    dic2.Add(arr[i], n);
                    n++;
                }
            }
            StringBuilder b2 = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                b2.Append(dic2[arr[i]]);
            }
            return b1.ToString() == b2.ToString();

        }

        #endregion
        #region 买卖股票的最佳时机含手续费
        //public int MaxProfit(int[] prices, int fee)
        //{

        //}
        #endregion
        #region 根据二叉树创建字符串
        StringBuilder str = new StringBuilder();
        public string Tree2str(TreeNode t)
        {

            if (t != null)
            {
                str.Append(t.val);
                def(t);
            }
            return str.ToString();
        }
        public void def(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            str.Append(root.val);
            if (root.left != null || root.right != null)
            {
                str.Append('(');
                def(root.left);
                str.Append(')');
            }
            if (root.right != null)
            {
                str.Append('(');
                def(root.right);
                str.Append(')');
            }
        }

        #endregion
        #region 旋转图片
        public void Rotate(int[][] matrix)
        {
            #region 数组辅助

            //int n = matrix.Length;
            //int[][] matrix_new = new int[n][];
            //for (int i = 0; i < n; ++i)
            //{
            //    matrix_new[i] = new int[n];
            //    for (int j = 0; j < n; ++j)
            //    {
            //        matrix_new[j][n - i - 1] = matrix[i][j];
            //    }
            //}
            //for (int i = 0; i < n;++ i)
            //{
            //    for (int j = 0; j < n; ++j)
            //    {
            //        matrix[i][j] = matrix_new[i][j];
            //    }
            //}

            #endregion
            #region 原地旋转
            //int n = matrix.Length;
            //for (int i = 0; i < n/2; ++i)
            //{
            //    for (int j = 0; j < (n+1)/2; ++j)
            //    {
            //        int temp = matrix[i][j];
            //        matrix[i][j] = matrix[n - j - 1][i];
            //        matrix[n - j - 1][i] = matrix[n-i-1][n-j-1];
            //        matrix[n - i - 1][n - j - 1] = matrix[j][n - i - 1];
            //        matrix[j][n - i - 1]=temp;
            //    }
            //}

            #endregion
            #region 翻转代替旋转
            int n = matrix.Length;
            //先水平翻转
            for (int i = 0; i < n / 2; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[n - i - 1][j];
                    matrix[n - i - 1][j] = temp;
                }
            }
            //对角线翻转达成旋转90度效果
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            #endregion

        }

        #endregion
        #region 使用最小花费爬楼梯
        public int MinCostClimbingStairs(int[] cost)
        {
            int n = cost.Length;
            int prev = 0, curr = 0;
            for (int i = 2; i <= n; i++)
            {
                int next = Math.Min(curr + cost[i - 1], prev + cost[i - 2]);
                prev = curr;
                curr = next;
            }
            return curr;
        }
        #endregion
        #region 子数组最大平均数1
        public static double FindMaxAverage(int[] nums, int k)
        {
            int len = nums.Length;
            double sum = 0;
            double res = double.MinValue;
            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }
            res = sum;
            for (int i = k; i < len; i++)
            {
                sum += nums[i] - nums[i - k];
                res = Math.Max(res, sum);
            }
            return res / k;
        }
        #endregion
        #region 错误的集合
        public static int[] FindErrorNums(int[] nums)
        {
            Dictionary<int, int> res = new Dictionary<int, int>();
            Array.Sort(nums);
            int small = -1, big = -1;
            foreach (var item in nums)
            {
                if (res.ContainsKey(item))
                {
                    res[item]++;
                }
                else
                {
                    res.Add(item, 1);
                }

            }
            for (int i = 1; i < nums.Length; i++)
            {
                if (res.ContainsKey(i))
                {
                    if (res[i] == 2)
                    {
                        small = i;
                    }
                    else
                    {
                        big = i;
                    }
                }
            }
            return new int[] { small, big };
        }
        #endregion
        #region 二叉树的锯齿形层序遍历
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            IList<IList<int>> res = new List<IList<int>>();
            if (root == null)
            {
                return res;
            }
            Queue<TreeNode> nodes = new Queue<TreeNode>();
            nodes.Enqueue(root);
            bool isOrderLeft = true;
            while (nodes.Count > 0)
            {
                var count = nodes.Count;
                var level = new int[count];
                while (count > 0)
                {
                    var node = nodes.Dequeue();
                    level[isOrderLeft ? (level.Length - count) : (count - 1)] = node.val;
                    count--;
                    if (node.left != null)
                    {
                        nodes.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        nodes.Enqueue(node.right);
                    }
                }
                res.Add(level.ToList());
                isOrderLeft = !isOrderLeft;
            }
            return res;
        }
        #endregion
        #region  两数之和 IV - 输入 BST
        public bool FindTarget(TreeNode root, int k)
        {
            List<int> list = new List<int>();
            return find(root, k, list);
        }
        public bool find(TreeNode root, int k, List<int> list)
        {
            if (root == null)
            {
                return false;
            }
            if (list.Contains(k - root.val))
            {
                return true;
            }
            list.Add(root.val);
            return find(root.left, k, list) || find(root.right, k, list);
        }
        #endregion
        #region 图片平滑器
        public static int[][] ImageSmoother(int[][] M)
        {
            int R = M.Length, C = M[0].Length;
            int[][] ans = new int[R][];
            for (int r = 0; r < R; ++r)
            {
                ans[r] = new int[C];
                for (int c = 0; c < C; ++c)
                {
                    int count = 0;
                    for (int nr = r - 1; nr <= r + 1; ++nr)
                    {
                        for (int nc = c - 1; nc <= c + 1; ++nc)
                        {
                            if (0 <= nr && nr < R && 0 <= nc && nc < C)
                            {
                                ans[r][c] += M[nr][nc];
                                count++;
                            }
                        }

                    }
                    ans[r][c] /= count;
                }
            }
            return ans;
        }
        #endregion
        #region 非递减数列
        public static bool CheckPossibility(int[] nums)
        {
            //[3,4,2,3]
            if (nums.Length <= 2)
            {
                return true;
            }
            int num = 0;
            //非递减，改变非递减
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] >= nums[i - 1])
                {
                    continue;
                }
                num++;
                if (i - 2 >= 0 && nums[i - 2] > nums[i])
                {
                    nums[i] = nums[i - 1];
                }
                else
                {
                    nums[i - 1] = nums[i];
                }
            }
            return num <= 1;
        }
        #endregion
        #region 修捡二叉搜索数
        public TreeNode TrimBST(TreeNode root, int low, int high)
        {
            if (root == null)
            {
                return root;
            }
            if (root.val > high)
            {
                return TrimBST(root.left, low, high);
            }
            if (root.val < low)
            {
                return TrimBST(root.right, low, high);
            }
            root.left = TrimBST(root.left, low, high);
            root.right = TrimBST(root.right, low, high);
            return root;
        }

        #endregion
        #region 二叉树中第二小的节点
        int res = -1;
        public int FindSecondMinimumValue(TreeNode root)
        {
            if (root == null)
            {
                return res;
            }
            //如果存在子树并且值不相等，那么较大的值就有可能是第二小的
            if (root.left != null && root.left.val != root.right.val)
            {
                //获取左右子树中的较大的值
                int bigger = root.left.val > root.right.val ? root.left.val : root.right.val;
                //如果返回值没有被更改过，则bigger有坑就是第二小，如果返回值被更改过
                //则比较当前的res和bigger那个更小
                res = res == -1 ? bigger : Math.Min(res, bigger);
                //将左右子树中值更小的数进行递归，查找是否有更小的值(即为了上一步判断)
                FindSecondMinimumValue(root.left.val > root.right.val ? root.right : root.left);
            }
            //如果左右子树相等或为空，分别递归
            else
            {
                FindSecondMinimumValue(root.left);
                FindSecondMinimumValue(root.right);
            }
            return res;
        }
        #endregion
        #region 分发糖果
        public static int Candy(int[] ratings)
        {
            //从左到右，从右到左
            //[1 3 2 1 1 2 1]
            int n = ratings.Length;
            int[] left = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i > 0 && ratings[i] > ratings[i - 1])
                {
                    left[i] = left[i - 1] + 1;
                }
                else
                {
                    left[i] = 1;
                }
            }//left[1,2,1,1,1,2,1]
            int right = 0, ret = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                if (i < n - 1 && ratings[i] > ratings[i + 1])
                {
                    right++;
                }
                else
                {
                    right = 1;
                }
                //从右到左
                //right  1,2,1,1,2,3,1
                ret += Math.Max(left[i], right);
            }
            return ret;

        }
        #endregion
        #region 最长连续递增序列
        public static int FindLengthOfLCIS(int[] nums)
        {
            int res = 0, count = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                if (i > 0 && nums[i - 1] >= nums[i])
                {
                    count = i;
                }
                res = Math.Max(res, i - count + 1);
            }
            return res;
            //int num = 0,temp=1,len = nums.Length;
            //if (len==1)
            //{
            //    return 1;
            //}
            //bool flag1 = false;
            //for (int i = 1; i < len; i++)
            //{
            //    if (nums[i]>nums[i-1])
            //    {
            //        flag1 = true;
            //        temp += 1;
            //    }
            //    else
            //    {
            //        flag1 = false;
            //        num = Math.Max(num,temp);
            //        temp = 1;
            //    }
            //}
            //return Math.Max(num, temp);

        }

        #endregion
        #region 验证回文字符串 Ⅱ
        public static bool ValidPalindrome(string s)
        {
            //双指针one，two
            //"abca"
            s = "aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga";
            int low = 0, high = s.Length - 1;
            while (low < high)
            {
                char c1 = s[low], c2 = s[high];
                if (c1 == c2)
                {
                    low++;
                    high--;
                }
                else
                {
                    bool flag1 = true, flag2 = true;
                    for (int i = low, j = high - 1; i < j; i++, j--)
                    {
                        char c3 = s[i], c4 = s[j];
                        if (c3 != c4)
                        {
                            flag1 = false;
                            break;
                        }
                    }
                    for (int i = low + 1, j = high; i < j; i++, j--)
                    {
                        char c3 = s[i], c4 = s[j];
                        if (c3 != c4)
                        {
                            flag2 = false;
                            break;
                        }
                    }
                    return flag1 || flag2;
                }
            }
            return true;
            //int one = 0, two = s.Length - 1;
            //while (one < two)
            //{
            //    Console.WriteLine(s[one].ToString());
            //    Console.WriteLine(s[two].ToString());
            //    if (s[one] == s[two])
            //    {
            //        one++;
            //        two--;
            //    }
            //    else
            //    {
            //        bool flag1 = true, flag2 = true;
            //        for (int i = one,j=two-1; i < j; i++,j--)
            //        {
            //            if (s[one]!=s[two])
            //            {
            //                flag1 = false;
            //                break;
            //            }
            //        }
            //        for (int i = one+1, j = two ; i < j; i++, j--)
            //        {
            //            if (s[one] != s[two])
            //            {
            //                flag2 = false;
            //                break;
            //            }
            //        }
            //        return flag1 || flag2;
            //    }

            //}
            //return true;
        }
        #endregion
        #region 交替二斤数
        public static bool HasAlternatingBits(int n)
        {
            //n = 1;
            //List<int> nums = new List<int>();
            //nums.Add(1); 
            //while (nums[nums.Count-1]<=n)
            //{
            //    if (nums.Contains(n))
            //    {
            //        return true;
            //    }
            //    if (nums[nums.Count - 1]%2==0)
            //    {
            //        nums.Add(nums[nums.Count - 1]*2+1);
            //    }
            //    else
            //    {
            //        nums.Add(nums[nums.Count - 1] * 2 );
            //    }

            //}

            //return false;
            n = n ^ (n >> 1);
            return (n & (n + 1)) == 0;
        }
        #endregion
        #region 员工的重要性
        int sum_value = 0;
        public int GetImportance(IList<Employee1> employees, int id)
        {

            values(employees, id);
            return sum_value;
        }
        private void values(IList<Employee1> employees, int value)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].id == value)
                {
                    sum_value += employees[i].importance;
                    for (int j = 0; j < employees[i].subordinates.Count; j++)
                    {
                        values(employees, employees[i].subordinates[i]);
                    }
                }
            }

        }
        #endregion 
        #region 棒球比赛
        public int CalPoints(string[] ops)
        {
            List<int> res = new List<int>();
            foreach (var item in ops)
            {
                switch (item)
                {
                    case "C":
                        res.RemoveAt(res.Count - 1);
                        break;
                    case "D":
                        res.Add(res[res.Count - 1] * 2);
                        break;
                    case "+":
                        res.Add(res[res.Count - 1] * res[res.Count - 2]);
                        break;
                    default:
                        res.Add(int.Parse(item));
                        break;
                }
            }
            return res.Sum();
        }
        #endregion
        #region 最大矩形
        public static int MaximalRectangle(char[][] matrix)
        {
            //matrix = [["1","0","1","0","0"],["1","0","1","1","1"],["1","1","1","1","1"],["1","0","0","1","0"]]
            int m = matrix.Length;
            if (m == 0)
            {
                return 0;
            }
            int n = matrix[0].Length;
            int[][] left = new int[m][];
            for (int i = 0; i < m; i++)
            {
                left[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == '1')
                    {
                        left[i][j] = (j == 0 ? 0 : left[i][j - 1]) + 1;
                    }
                }
            }
            //left = [["1","0","1","0","0"],["1","0","1","2","3"],["1","2","3","4","5"],["1","0","0","1","0"]]
            int ret = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == '0')
                    {
                        continue;
                    }

                    int width = left[i][j];
                    int area = width;
                    for (int k = i - 1; k >= 0; k--)
                    {
                        width = Math.Min(width, left[k][j]);
                        area = Math.Max(area, (i - k + 1) * width);
                    }
                    ret = Math.Max(ret, area);
                    //ret: [1,1],[2,2,2,3],[3,3,3,
                }
            }
            return ret;

        }
        #endregion
        #region 二叉树中搜索
        public TreeNode SearchBST(TreeNode root, int val)
        {
            //寻找值等于val的节点，如果节点不存在返回null
            return val_root(root, val);
        }
        public TreeNode val_root(TreeNode root, int val)
        {
            if (root == null)
            {
                return null;
            }
            if (root.val == val)
            {
                return root;
            }
            return root.val > val ? val_root(root.left, val) : val_root(root.right, val);
        }
        #endregion
        #region 数组的度
        public int FindShortestSubArray(int[] nums)
        {
            var left = new Dictionary<int, int>();//第一次index
            var right = new Dictionary<int, int>();//最后一次index
            var count = new Dictionary<int, int>();//次数
            for (int i = 0; i < nums.Length; i++)
            {
                if (!left.ContainsKey(nums[i]))
                {
                    left.Add(nums[i], i);
                    right.Add(nums[i], i);
                    count.Add(nums[i], 1);
                }
                else
                {
                    right[nums[i]] = i;
                    count[nums[i]]++;
                }

            }
            int ans = nums.Length;
            int degree = count.Values.Max();
            foreach (var item in count)
            {
                if (item.Value == degree)
                {
                    ans = Math.Min(ans, right[item.Key] - left[item.Key] + 1);
                }
            }
            return ans;
        }
        #endregion
        #region 买卖股票最佳时机||||
        public int MaxProfit(int k, int[] prices)
        {
            if (prices == null || prices.Length == 0)
            {
                return 0;
            }
            int n = prices.Length;
            //当k非常大时转为无限次交易
            if (k >= n / 2)
            {
                int dp0 = 0, dp1 = -prices[0];
                for (int i = 0; i < n; i++)
                {
                    int temp = dp0;
                    dp0 = Math.Max(dp0, dp1 + prices[i]);
                    dp1 = Math.Max(dp1, dp0 - prices[i]);
                }
                return Math.Max(dp0, dp1);
            }
            #region 动态规划+空间优化

            //定义二维数组，交易了多少次，当前的买卖状态
            int[][] dp = new int[k + 1][];
            int res = 0;
            for (int i = 0; i <= k; ++i)
            {
                dp[i] = new int[2];
                dp[i][0] = 0;
                dp[i][1] = -prices[0];
            }
            for (int i = 1; i < n; ++i)
            {
                for (int j = k; j > 0; --j)
                {
                    //处理第k次买入
                    dp[j - 1][1] = Math.Max(dp[j - 1][1], dp[j - 1][0] - prices[i]);
                    dp[j][0] = Math.Max(dp[j][0], dp[j - 1][1] + prices[i]);
                }
            }
            #endregion
            return dp[k][0];
        }
        //计算k次交易，index表示当前是哪天，status是买卖状态，contnt为交易对象次数
        private int dfs1(int index, int status, int count, int k, int[] prices)
        {

            if (index == prices.Length || count == k)
            {
                return 0;
            }
            int a = 0, b = 0, c = 0;
            //保持不动
            a = dfs1(index + 1, status, count, k, prices);
            if (status == 1)
            {
                //卖一股
                b = dfs1(index + 1, 0, count + 1, k, prices) + prices[index];
            }
            else
            {
                //买一股
                c = dfs1(index + 1, 1, count, k, prices) - prices[index];
            }
            return Math.Max(Math.Max(a, b), c);

        }
        #endregion
        #region  数据流中的第 K 大元素

        #endregion
        #region 按要求补齐数组
        public int MinPatches(int[] nums, int n)
        {
            //贪心
            //nums = [1,3], n = 6
            int a = 0;
            long x = 1;
            int len = nums.Length, index = 0;
            while (x <= n)//1<6   2<6  4<6
            {
                if (index < len && nums[index] <= x) //0<2&&(nums[0]=1)==1    1<2&&(nums[1]=3)>2   1<2&&(nums[1]=3)<=4
                {
                    x += nums[index];   //x=1+1=2  x=4+3=7  
                    index++; //0+1=1  1+1=2
                }
                else
                {
                    x *= 2;  //x=2*2=4
                    a++;// a=0+1 
                }
            }
            return a;
        }
        #endregion
        #region 二分查找
        public int Search(int[] nums, int target)
        {
            int num = 0, left = 0, right = nums.Length - 1;

            while (left <= right)
            {
                num = left + (right - left) / 2;
                if (nums[num] == target)
                {
                    return num;
                }
                else if (nums[num] > target)
                {
                    right = num - 1;
                    //num = (1 + num ) / 2;
                }
                else
                {
                    left = num + 1;
                    //num = (num + nums.Length) / 2;
                }
            }
            return -1;
        }
        #endregion
        #region 最后一块石头的重量
        public static int LastStoneWeight(int[] stones)
        {
            //[1,1,2,4,7,8]
            //[2,4,1,1,1]
            //[2,1,1,1]
            //[1,1,1]
            //[1]
            Array.Sort(stones);
            int[] nums = new int[stones[stones.Length - 1]];
            //for (int i = 0; i < stones.Length - 1; i++)
            //{
            //    nums[stones]
            //}
            int n = stones.Length - 1;
            while (n > 0)
            {
                Array.Sort(stones);
                if (stones[n] == stones[n - 1])
                {
                    n -= 2;
                }
                else
                {
                    stones[n - 1] = stones[n] - stones[n - 1];
                    n -= 1;
                }
            }
            return stones[0];
        }
        #endregion
        #region 无重叠区间
        public static int EraseOverlapIntervals(int[][] intervals)
        {
            int n = intervals.Length;
            if (n == 0)
            {
                return 0;
            }
            Array.Sort<int[]>(intervals, (x, y) => x[0].CompareTo(y[0]));

            int[] nums = new int[n];
            Array.Fill(nums, 1);
            int num = intervals[0][1];
            int ans = 1;
            for (int i = 1; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (intervals[j][1] <= intervals[i][0])
                    {
                        nums[i] = Math.Max(nums[i], nums[j] + 1); ;
                    }
                }
            }
            for (int i = 1; i < n; ++i)
            {
                if (intervals[i][0] >= num)
                {
                    ++ans;
                    num = intervals[i][1];
                }
            }
            //return n - nums.Max() ;
            return n - ans;
        }
        #endregion
        #region 分隔链表
        public ListNode Partition(ListNode head, int x)
        {
            ListNode current = head;
            ListNode list1 = new ListNode(0);
            list1.next = head;
            ListNode list2 = new ListNode(0);
            list2.next = head;
            ListNode head1 = list1;
            ListNode head2 = list2;
            bool usedList2 = false;
            while (current != null)
            {
                if (current.val < x)
                {
                    list1.next = new ListNode(current.val);
                    list1 = list1.next;
                }
                else
                {
                    list2.next = new ListNode(current.val);
                    list2 = list2.next;
                    usedList2 = true;
                }
                current = current.next;

            }
            if (usedList2)
            {
                list1.next = head2.next;
            }
            return head1.next;

        }
        #endregion
        #region 转成小写字母
        public static string ToLowerCase(string str)
        {
            StringBuilder str1 = new StringBuilder();
            str1.Append(str);
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] >= 65 && str1[i] <= 90)
                {
                    str1[i] = (char)(str1[i] + 32);
                }
            }
            return str1.ToString();
        }
        #endregion
        #region 较大分组的位置
        public IList<IList<int>> LargeGroupPositions(string s)
        {
            int len = s.Length;

            int a = 0, b = 0, num = 1, one = 0;
            List<IList<int>> res = new List<IList<int>>();
            for (int i = 1; i < len; i++)
            {
                if (s[i] != s[i - 1] || i == len - 1)
                {
                    if (num >= 3)
                    {
                        List<int> temp = new List<int>();
                        temp.Add(i - num + 1);
                        temp.Add(i - 1);
                        res.Add(temp);
                    }
                }
                //else if(num>3)
                //{
                //    num = 1;
                //    List<int> temp = new List<int>();
                //    temp.Add(one);
                //    temp.Add(i-1);
                //    res.Add(temp);
                //    one = i;
                //}
                else
                {
                    num++;
                }
            }
            return res;
        }
        #endregion
        #region 1比特与2比特字符
        public bool IsOneBitCharacter(int[] bits)
        {
            //[1, 0, 0]

            int[] nums = new int[2];
            for (int i = 0; i < bits.Length; i++)
            {
                nums[bits[i]]++;
            }
            if (nums[1] > 1)
            {
                if (nums[1] % 2 > nums[0])
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (nums[0] < 1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        #endregion
        #region  词典中最长的单词
        public static string longestword(string[] words)
        {
            words = new string[] { "rac", "rs", "ra", "on", "r", "otif", "o", "onpdu", "rsf", "rs", "ot", "oti", "racy", "onpd" };
            //输入：
            //words = ["w", "wo", "wor", "worl", "world"]
            //输出："world"
            //解释： 
            //单词"world"可由"w", "wo", "wor", 和 "worl"添加一个字母组成。
            //先找最长的还是长的
            Dictionary<string, int> dic = new Dictionary<string, int>();
            Array.Sort(words);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length==1)
                {
                    dic.Add(words[i], 1);
                }
                else 
                {
                    if (dic.ContainsKey(words[i].Substring(0,words[i].Length-1)))
                    {
                        dic.Remove(words[i].Substring(0, words[i].Length - 1));
                        dic.Add(words[i], words[i].Length);
                    }
                }
            }
            string res = "";
            int len = 0;
            foreach (var item in dic)
            {
                if (item.Value>len)
                {
                    len = item.Value;
                    res = item.Key;
                }
            }
            return res;


        }
        #endregion
        #region 寻找数组的中心索引
        public static int PivotIndex(int[] nums)
        {
            //[1, 7, 3, 6, 5, 6] 3
            //[1, 2, 3] -1
            nums = new int[] { 1, 1, -1, -1, 0, 1 };
            int sum = 0, leftSum = 0;
            foreach (var item in nums)
            {
                sum += item;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (leftSum==sum-leftSum-nums[i])
                {
                    return i;
                }
                leftSum += nums[i];
            }
            return -1;
            //int one = 0;
            //int one_v = nums[one];
            //int two = nums.Length-1;
            //int two_v = nums[two];
            //while (two>one && two - one >= 2)
            //{             
                
            //    if (one_v==two_v&&two-one==2)
            //    {
            //        return one + 1;
            //    }
            //    else
            //    {
            //        if (Math.Abs(one_v) > Math.Abs(two_v))
            //        {
            //            --two;
            //            two_v += nums[two];
            //        }
            //        else if (Math.Abs(one_v )< Math.Abs(two_v))
            //        {
            //            ++one;
            //            one_v += nums[one];
            //        }
            //        else
            //        {
            //            two--;
            //            one++;
            //        }
            //    }
            //}
            //return -1;
        }
        #endregion
        #region 除法求值
        public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
        {
            //equations = [["a","b"],["b","c"]], values = [2.0,3.0], queries = [["a","c"],["b","a"],["a","e"],["a","a"],["x","x"]]
            int equationsSize = equations.Count;
            UnionFind unionFind = new UnionFind(2*equationsSize);
            //1.预处理，将变量的值与id进行映射，使得并查集的底层使用数组实现，方便编码
            Dictionary<string, int> dic = new Dictionary<string, int>();
            int id = 0;
            for (int i = 0; i < equationsSize; i++)
            {
                List<string> equation = (List<string>)equations[i];
                string var1 = equation[0];
                string var2 = equation[1];
                if (!dic.ContainsKey(var1))
                {
                    dic.Add(var1,id);
                    id++;
                }
                if (!dic.ContainsKey(var2))
                {
                    dic.Add(var2,id);
                    id++;
                }
                unionFind.union(dic[var1],dic[var2],values[i]);
            }
            //2.做查询
            int queriesSize = queries.Count;
            double[] res = new double[queriesSize];
            for (int i = 0; i < queriesSize; i++)
            {
                string var1 = queries[i][0];
                string var2 = queries[i][1];
                int id1 = dic[var1];
                int id2 = dic[var2];
                if (id1==null||id2==null)
                {
                    res[i] = -1.0d;
                }
                else
                {
                    res[i] = unionFind.isConnected(id1,id2);
                }
            }
            return res;
        }
        #endregion
        #region 自除数
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            //个位数     
            //int  x= 0, y=0;
            //List<int> res = new List<int>();
            //for (int i = 0; i <right+1-left; i++)
            //{
            //    x = left + i;
            //    y = left + i;
            //    while (true)
            //    {
            //        if (y%10==0||x%(y%10)!=0)
            //        {
            //            break;
            //        }
            //        if (y<1)
            //        {
            //            res.Add(x);
            //            break;
            //        }
            //    }
            //}
            //return res;
            List<int> res = new List<int>();
            for (int i = left; i <right; ++i)
            {
                if (selfDividing(i))
                {
                    res.Add(i);
                }
            }
            return res;
        }
        public bool selfDividing(int n)
        {
            string x = n.ToString() ;
            foreach (var item in x)
            {
                if (item=='0'||(n%(item-'0')>0))
                {
                    return false;
                }

            }
            return true;
        }
        //public bool selfDividing(int n)
        //{
        //    int x = n;
        //    while (x>0)
        //    {
        //        int d = x % 10;
        //        x /=10;
        //        if (d==0||(n%d)>0)
        //        {
        //            return false;
        //        }                
        //    }
        //    return true;
        //}
        #endregion
        #region 图像渲染
        int[] dx = { 1, 0, 0, -1 };
        int[] dy = { 0, 1, -1, 0 };
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            #region 深度优先搜索
            int currColor = image[sr][sc];//这个点的颜色
            if (currColor!=newColor)//对比原来的颜色和新颜色
            {
                dfs(image,sr,sc,currColor,newColor);
            }
            return image;
            #endregion
        }
        private void dfs(int[][]image,int x,int y,int color,int newColor)
        {
            if (image[x][y]==color)//
            {
                image[x][y] = newColor;
                for (int i = 0; i < 4; i++)
                {
                    int mx = x + dx[i], my = y + dy[i];
                    if (mx>=0&&mx<image.Length&&my>=0&&my<image[0].Length)
                    {
                        dfs(image,mx,my,color,newColor);
                    }
                }
            }
        }
        #endregion
        #region 省份数量
        public static int FindCircleNum(int[][] isConnected)
        {
            int provinces = isConnected.Length;
            bool[] visited = new bool[provinces];
            int circles = 0;
            for (int i = 0; i < provinces; i++)
            {
                if (!visited[i])
                {
                    dfs(isConnected,visited,provinces,i);
                    circles++;
                }
            }
            return circles;
        }
        private static void dfs(int [][]isConnected,bool[]visited,int province,int i)
        {
            for (int j = 0; j < province; j++)
            {
                if (isConnected[i][j]==1&&!visited[j])
                {
                    visited[j] = true;
                    dfs(isConnected, visited, province, j);
                }              
            }
        }
        #endregion
        #region 寻找比目标字母大的最小字母
        public char NextGreatestLetter(char[] letters, char target)
        {
            char one = letters[0];
            char tweo = letters[letters.Length - 1];
            if (one > target||tweo < target)
            {
                return one;
            }
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i]>one)
                {
                    return letters[i];
                }
            }
            return ' ';
        }
        #endregion
        #region 至少是其他数字两倍的最大数
        public int DominantIndex(int[] nums)
        {
            if (nums.Length==1)
            {
                return 0;
            }
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]] = i;
                }
                else
                {
                    dic.Add(nums[i],i);
                }
            }
            Array.Sort(nums);
            if (nums[nums.Length-1]>=2*nums[nums.Length-2])
            {
                return dic[nums[nums.Length - 1]];
            }
            return -1;
            
        }
        #endregion
        #region 最短补全
        public static  string ShortestCompletingWord(string licensePlate, string[] words)
        {
            //"1s3 PSt"  ["step", "steps", "stripe", "stepple"]
            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (var item in licensePlate.ToLower())
            {
                if (item>=97&&item<=122)
                {
                    if (dic.ContainsKey(item))
                    {
                        dic[item]++;
                    }
                    else
                    {
                        dic.Add(item,1);
                    }
                }
            }
            int num = 0;
            string res = "";    
            int len = 16;
            for (int i = 0; i < words.Length; i++)
            {
                int temp = 0;

                Dictionary<char, int> keyValues = new Dictionary<char, int>();
                foreach (var item in words[i])
                {
                    if (keyValues.ContainsKey(item))
                    {
                        keyValues[item]++;
                    }
                    else
                    {
                        keyValues.Add(item, 1);
                    }
                }
                foreach (var item in keyValues)
                {

                    if (dic.ContainsKey(item.Key))
                    {
                        if (dic[item.Key]>item.Value)
                        {
                            temp += item.Value; 
                        }
                        else
                        {
                            temp += dic[item.Key];
                        }
                    }
                }
                if (temp > num || (temp == num && len > words[i].Length))
                {
                    len = words[i].Length;
                    num = temp;
                    res = words[i];
                }
            }
            return res;
        }
        #endregion
        #region 滑动窗口最大值
        public static int[] MaxSlidingWindow(int[] nums, int k)
        {
            int n = nums.Length;
            int[] res = new int[n - k + 1];
            LinkedList<int> dq = new LinkedList<int>();
            for (int i = 0; i < n; i++)
            {
                if (dq.Count != 0 && dq.First.Value < (i - k + 1))
                {
                    dq.RemoveFirst();//超出窗口长度时删除队首
                }
                while (dq.Count != 0 && nums[i] >= nums[dq.Last.Value])
                {
                    dq.RemoveLast();//如果遍历的元素大于队尾元素就删除队尾
                }
                dq.AddLast(i);//添加
                if (i >= k - 1)
                {
                    res[i - k + 1] = nums[dq.First.Value];//结果
                }
            }
            return res;

        }
        //public static int[] MaxSlidingWindow(int[] nums, int k)
        //{
        //    //nums = [1,3,-1,-3,5,3,6,7], k = 3 结果 [3,3,5,5,6,7]
        //    List<int> res = new List<int>();
        //    int i = 0;
        //    int n = k - 1;
        //    if (nums.Length < k)
        //    {
        //        Array.Sort(nums);
        //        res.Add(nums[nums.Length - 1]);
        //        return res.ToArray();
        //    }
        //    while (n < nums.Length)
        //    {
        //        int num = int.MinValue;
        //        for (int j = i; j <= n; j++)
        //        {
        //            if (nums[j] > num)
        //            {
        //                num = nums[j];
        //            }
        //        }
        //        res.Add(num);
        //        i++;
        //        n++;
        //    }
        //    return res.ToArray();
        //}
        #endregion#region   
        #region 股票四
        public static int MaxProfit1(int[] prices)
        {
             int n = prices.Length;
            int buy1 =  -prices[0], sell1 = 0;
            int buy2 =  -prices[0], sell2 = 0;
            for (int i = 0; i < n; ++i)
            {
                buy1 = Math.Max(buy1,-prices[i]);            //-1 -1 -1 -1 -1
                sell1 = Math.Max(sell1,buy1+prices[i]); //  0   1  2   3  4
                buy2 = Math.Max(buy2,sell1-prices[i]);  // -1 -1 -1 -1 -1
                sell2 = Math.Max(sell2,buy2+prices[i]); //  0   1   2   3  4  
            }
            return sell2;
        }
        #endregion
        #region 汇总区间
        public static IList<string> SummaryRanges(int[] nums)
        {
            //输入：nums = [0,1,2,4,5,7]
            //输出：["0->2","4->5","7"]
            List<string> res = new List<string>();
            if (nums.Length==1)
            {
                res.Add(nums[0].ToString());
            }
            int one = nums[0];
            //StringBuilder str = new StringBuilder();
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i]- nums[i-1] != 1)
                {
                    if (nums[i - 1] != one)
                    {
                        res.Add(one.ToString() + "->" + nums[i - 1].ToString());
                    }
                    else
                    {
                        res.Add(one.ToString());
                    }
                    one = nums[i];
                    if (i == nums.Length - 1)
                    {
                        res.Add(one.ToString());
                    }
                }
                else if(i == nums.Length - 1)
                {
                    res.Add(one.ToString() + "->" + nums[i ].ToString());
                }
            }
            return res;
        }
        #endregion
        #region 交换字符串中的元素
        public static string SmallestStringWithSwaps(string s, IList<IList<int>> pairs)
        {
          //  var nums = a.ToArray();
            int n = pairs.Count;
            if (n<1)
            {
                return s;
            }
            int a = 0;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {
                    if (pairs[j][0]>pairs[j+1][0])
                    {
                        var temp = pairs[j];
                        pairs[j] = pairs[j + 1];
                        pairs[j + 1]=temp;
                        a = 1;
                    }
                
                }    if (a==0)
                    {
                        break;
                    }
            }
            List<int> nums = new List<int>();
            List<List<int>> lists = new List<List<int>>();
            lists.Add(new List<int>() { pairs[0][0], pairs[0][1] });
            for (int i = 0; i < n; i++)
            {
                bool flag = false;
                for (int j = 0; j < lists.Count; j++)
                {
                    if (lists[j].Contains(pairs[i][0]) && !lists[j].Contains(pairs[i][1]))
                    {
                        lists[j].Add(pairs[i][1]);
                    }
                    else if (lists[j].Contains(pairs[i][1]) && !lists[j].Contains(pairs[i][0]))
                    {
                        lists[j].Add(pairs[i][0]);
                    }
                    else if (!lists[j].Contains(pairs[i][1]) && !lists[j].Contains(pairs[i][0]))
                    {
                        flag=true;
                    }

                }
                if (flag)
                {
                    lists.Add(new List<int>() { pairs[i][0], pairs[i][1] });
                }               
            }      
            StringBuilder str = new StringBuilder();
            str.Append(s);
            for (int i = 0; i < lists.Count; i++)
            {
                char[] chars = new char[lists[i].Count];
                for (int j = 0; j< lists[i].Count; j++)
                {
                    chars[j] = s[lists[i][j]];
                }
                Array.Sort(chars);
                for (int j = 0; j < lists[i].Count; j++)
                {
                    lists[i].Sort();
                    int m = lists[i][j];
                    str[m] = chars[j];
                }
            }
      
          


            return str.ToString();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    str.Append(nums[i]);
            //}
            //return str.ToString();
        }

        #endregion
        #region 项目管理
        public int[] SortItems(int n, int m, int[] group, IList<IList<int>> beforeItems)
        {
            List<List<int>> groupItem = new List<List<int>>();
            for (int i = 0; i < n + m; ++i)
            {
                groupItem.Add(new List<int>());
            }
            //组间和组内依赖图
            List<List<int>> groupGraph = new List<List<int>>();
            for (int i = 0; i < n + m; ++i)
            {
                groupGraph.Add(new List<int>());
            }
            List<List<int>> itemGraph = new List<List<int>>();
            for (int i = 0; i < n; ++i)
            {
                itemGraph.Add(new List<int>()); ;
            }

            //组间和组内入度数组
            int[] groupDegree = new int[n + m];
            int[] itemDegree = new int[n];

            List<int> id = new List<int>();
            for (int i = 0; i < n+m; ++i)
            {
                id.Add(i);
            }

            int leftId = m;
            //给未分配的Item分配一个groupId
            for (int i = 0; i < n; ++i)
            {
                if (group[i]==-1)
                {
                    group[i] = leftId;
                    leftId += 1;
                }
                groupItem[group[i]].Add(i);
            }
            //依赖关系图
            for (int i = 0; i < n; ++i)
            {
                int curGroupId = group[i];
                foreach (var item in beforeItems[i])
                {
                    int beforeGroupId = group[item];
                    if (beforeGroupId==curGroupId)
                    {
                        itemDegree[i] += 1;
                        itemGraph[item].Add(i);
                    }
                    else
                    {
                        groupDegree[curGroupId] += 1;
                        groupGraph[beforeGroupId].Add(curGroupId);
                    }
                }
            }
            //组间拓扑关系排序
            List<int> groupTopSort = topSort(groupDegree, groupGraph, id);
            if (groupTopSort.Count==0)
            {
                return new int[0];
            }
            int[] ans = new int[n];
            int index = 0;
            //组内拓扑关系排序
            foreach (var item in groupTopSort)
            {
                int size = groupItem[item].Count;
                if (size==0)
                {
                    continue;
                }
                List<int> res = topSort(itemDegree,itemGraph,groupItem[item]);
                if (res.Count==0)
                {
                    return new int[0];
                }
                foreach (var it in res)
                {
                    ans[index++] = it;
                }
            }
            return ans;
        }
        public List<int> topSort(int[] deg, List<List<int>> graph, List<int> items)
        {
            Queue<int> queue = new Queue<int>();
            foreach (var item in items)
            {
                if (deg[item]==0)
                {
                    queue.Enqueue(item);
                }                
            }
            List<int> res = new List<int>();
            while (queue.Count>0)
            {
                int u = queue.Dequeue();
                res.Add(u);
                foreach (var item in graph[u])
                {
                    if (--deg[item]==0)
                    {
                        queue.Enqueue(item);
                    }
                }
            }
            return res.Count == items.Count ? res : new List<int>();
        }
        #endregion
        #region 冗余连接
        public int[] FindRedundantConnection(int[][] edges)
        {
            int nodesCount = edges.Length;
            int[] parent = new int[nodesCount+1];
            for (int i = 1; i < nodesCount; i++)
            {
                parent[i]= i;
            }
            for (int i = 0; i < nodesCount; i++)
            {
                int[] edge = edges[i];
                int node1 = edge[0], node2 = edge[1];
                if (find(parent,node1)!=find(parent,node2))
                {
                    union(parent,node1,node2);
                }
                else
                {
                    return edge;
                }
            }
            return new int[0];
        }
        public void union(int[]parent,int index1,int index2)
        {
            parent[find(parent,index1)]=find(parent,index2);
        }
        public int find(int[] parent,int index)
        {
            if (parent[index]!=index)
            {
                parent[index] = find(parent,parent[index]);
            }
            return parent[index];
        }
        #endregion
        #region 可被 5 整除的二进制前缀
        public static IList<bool> PrefixesDivBy5(int[] A)
        {
            List<bool> a = new List<bool>();
            long num = 0;
            //1,0,0,1,0,1,0,0,1,0,1,1,1,1,1,1,1,1,1,1,0,0,0,0,1,0,1,0,0,0,0,1,1,0,1,0,0,0,1

            for (int i = 0; i < A.Length; i++)
            {
                num = (num << 1) + A[i];
                //num = num * 2 + A[i];
                if (num % 5 == 0)
                {
                    a.Add(true);
                }
                else
                {
                    a.Add(false);
                }
            }
            return a;
        }
        #endregion
        #region 旋转字符串
        public bool RotateString(string A, string B)
        {
            StringBuilder str = new StringBuilder();
            str.Append(A);
            for (int i = 0; i < A.Length; i++)
            {
                if (B.CompareTo(str.ToString())==0)
                {
                    return true;
                }

                str = str.Remove(0, 1).Append(A[i]);
            }
            #region 奇妙
            //if (A.Length!=B.Length)
            //{
            //    return false;
            //}
            //return (A + A).Contains(B);
            #endregion
            return false;
        }
        #endregion


        #endregion
        #region LinQ
        private static void DataInit()
        {
            IList<UserInfo> userlist = new List<UserInfo>() {
        new UserInfo(){UId=1,UserName="zs",Age=23,RoleId=1},
        new UserInfo(){UId=2,UserName="ls",Age=20,RoleId=2},
        new UserInfo(){UId=3,UserName="ww",Age=26,RoleId=1},
        new UserInfo(){UId=4,UserName="zl",Age=26,RoleId=2},
        new UserInfo(){UId=5,UserName="tq",Age=42,RoleId=2}
        };
            IList<RoleInfo> roleList = new List<RoleInfo> {
            new RoleInfo(){Rid=1,RoleName="管理员"},
            new RoleInfo(){Rid=2,RoleName="普通用户"}
            };
            //query语法
            var result = from u in userlist
                         where u.Age > 20
                         select new { u.UId, u.UserName, u.Age };
            //lambda
            var result2 = userlist.Where<UserInfo>(u => u.Age > 20).Select(u => new { u.UId, u.UserName, u.Age });
            //按id排序，age
            var result3 = from u in userlist
                          orderby u.UId, u.Age descending
                          select u;
            var result31 = userlist.OrderByDescending(u => u.UId).ThenBy(u => u.Age);
            //分组
            var resGroups = from u in userlist
                            group u by u.RoleId;
            //lambda方式，GroupBy延迟执行，ToLookup是立即执行，使用方法和GroupBy一样
            var resGroups1 = userlist.GroupBy(u => u.RoleId);
            //遍历分组
            foreach (var group in resGroups)
            {
                Console.WriteLine("roleId:{0}", group.Key);
                foreach (UserInfo user in group)
                {
                    Console.WriteLine("userName:{0}", user.UserName);
                }
            }
            //连接查询join
            var resJoin = from user in userlist
                          join role in roleList
                          on user.RoleId equals role.Rid
                          select new
                          {
                              uname = user.UserName,
                              rname = role.RoleName
                          };
            foreach (var item in resJoin)
            {
                Console.WriteLine("uname:{0}+rname:{1}", item.uname, item.rname);
            }
            //left join,right join调整顺序即可
            //var resJoin1 = from user in userlist
            //               join role in roleList
            //               on user.RoleId equals role.Rid into temp
            //               from tt in temp.DefaultIfEmpty
            //               select new
            //               {
            //                   uname = user.UserName,
            //                   rname = role?.RoleName
            //               };

            //cross in
            var resJoin2 = from user in userlist
                           from role in roleList
                           select new
                           {
                               uname = user?.UserName,
                               rname = role?.RoleName
                           };
            //lambda方式
            var resJoin3 = userlist.Join(roleList,
                user => user.RoleId,
                role => role.Rid,
                (user, role) => new
                {
                    uname = user.UserName,
                    rname = role.Rid
                });
            //遍历
            foreach (var item in resJoin3)
            {
                Console.WriteLine("用户:{0}---角色:{1}", item.uname, item.rname);
            }
            //量词
            //ALL 所有元素都符合的条件返回true
            bool areAllAdmin = userlist.All(u => u.RoleId == 1);
            //Any 有一个符合条件的返回true

        }

        #endregion
    }
    class Employee1
    {
        public int id;
        public int importance;
        public IList<int> subordinates;
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

    public  class UnionFind
    {
        private int[] parent;
        //指向父节点的权值
        private double[] weight;
        public UnionFind(int n)
        {
            this.parent = new int[n];
            this.weight = new double[n];
            for (int i = 0; i < n; i++)
            {
                parent[i] = i;
                weight[i] = 1.0d;
            }
        }
        public void union(int x,int y,double value)
        {
            int rootX = find(x);
            int rootY = find(y);
            if (rootX==rootY)
            {
                return;
            }
            parent[rootX] = rootY;
            weight[rootX] = weight[y] * value / weight[x];
        }
        //路径压缩 return根节点的id
        public int find(int x)
        {
            if (x!=parent[x])
            {
                int origin = parent[x];
                parent[x] = find(parent[x]);
                weight[x] *= weight[origin];
            }
            return parent[x];
        }
        public double isConnected(int x,int y)
        {

            int rootX = find(x);
            int rootY = find(y);
            if (rootX==rootY)
            {
                return weight[x] / weight[y];
            }
            else
            {
                return -1.0d;
            }
        }
    }
    public class UserInfo
    {
        public int UId { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public int RoleId { get; set; }
    }
    public class RandomizedCollection
    {
        //字典内使用HashSet是为了实现O(1)删除索引，而且索引不会重复
        Dictionary<int, HashSet<int>> iDic { get; set; } = new Dictionary<int, HashSet<int>>();
        List<int> values { get; set; } = new List<int>();
        /** Initialize your data structure here. */
        public RandomizedCollection()
        {
            //列表随机插入是O(n)因为，要后移位置之后的元素，但追加在列表尾部的O(1)
            //列表按索引查找的是O(1),按值查找是O(n)
        }

        /** Inserts a value to the collection. Returns true if the collection did not already contain the specified element. */
        public bool Insert(int val)
        {
            //使用一个字典维护某个数字的所有索引列表
            if (!iDic.TryGetValue(val, out var indexSet))
            {
                indexSet = new HashSet<int>();
                iDic.Add(val, indexSet);
            }
            values.Add(val);
            indexSet.Add(values.Count - 1);
            return true;
        }

        /** Removes a value from the collection. Returns true if the collection contained the specified element. */
        public bool Remove(int val)
        {
            //字典不存在某个数字的索引，也就不存在某个数字
            if (!iDic.TryGetValue(val, out var valList) || valList.Count == 0)
            {
                return false;
            }
            var lastValue = values.Last();
            if (lastValue == val)
            {
                //直接在列表最后移除
                valList.Remove(values.Count - 1);
                values.RemoveAt(values.Count - 1);
                return true;
            }
            //将values最后一个元素的值替换要删除的元素的最后一个索引的位置，然后values删
            //除最后一个元素，即为O(1)删除
            //内替换的值得索引列表应该移除索引值(values的长度-1)，并追加一个被删除元素的所在的索引值
            //（因为被替换的值被替换到这个索引了）
            var valLastIndex = valList.Last();
            var changeIndex = iDic[lastValue];
            valList.Remove(valLastIndex);
            changeIndex.Remove(values.Count - 1);
            changeIndex.Add(valLastIndex);
            values[valLastIndex] = lastValue;
            values.RemoveAt(values.Count - 1);
            return true;
        }

        /** Get a random element from the collection. */
        public int GetRandom()
        {
            return values[new Random().Next(0, values.Count)];
        }
    }
    class RoleInfo
    {
        public int Rid { get; set; }
        public string RoleName { get; set; }
    }

    public class Node
    {
        public int val;
        public List<Node> children;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }
        public Node(int _val, List<Node> _children)
        {
            val = _val;
            children = _children;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
}




