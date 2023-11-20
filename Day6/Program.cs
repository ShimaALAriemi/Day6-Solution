namespace Day6
{
    internal class Program
    {
        static void PrintLine(int n = 4, string s = "_", bool flag = false)
        {
            if (flag) for (int i = 0; i < n; i++) Console.WriteLine(s);
            else for (int i = 0; i < n; i++) Console.Write(s);

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            PrintLine(9, " @___@ ");
            PrintLine();
            PrintLine(s: " (____) ", n: 8, flag: true);
            PrintLine(3, "***^***", true);

            int a = 1;
            int b = 2;

            Console.WriteLine($"A is {a} , B is {b}\n");

            SwapVal(a, b);

            Console.WriteLine($"When Swap By Value:\nA is {a} , B is {b}\n");

            SwapRef(ref a, ref b);

            int[] munumber = new int[] { 1, 3, 4, 5 };
            Console.WriteLine(munumber[0]);

            isUpdate(munumber);

            Console.WriteLine(munumber[0]);


         

            


        }


        //When Swap By Value
        static void SwapVal(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;

            Console.WriteLine($"A is {x} , B is {y}\n");

        }
        //When Swap By Refrence
        static void SwapRef(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;

            Console.WriteLine($"When Swap By Refrence:\nA is {x} , B is {y} \n");

        }

        static void isUpdate(int[] num)
        {
            num[0] = 100;
        }

        public static bool IsPalindrome(int x)
        {
            string num = x.ToString();
            Console.WriteLine(num[0]);
            int j = num.Length - 1;

            for (int i = 0; i < num.Length; i++)
            {

                if (string.Equals(num[i], num[j]) == false) return false;
                j--;

            }
            return true;
        }
    }
}