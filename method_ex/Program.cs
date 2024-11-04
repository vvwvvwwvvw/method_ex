namespace method_ex
{
     class Program
    {
        public static void methodByValue(int x)
        {
            x = x + 1;
        }
        public static void methodArray(int[] x)
        {
            for(int i = 0; i < 5; i++) x[i] = 1;
        }
        public static void methodRef(ref int x)
        {
            x= x + 1;
        }
        static void Main(string[] args)
        {
            int a = 10;
            methodByValue(a);
            Console.WriteLine(a);// 출력 1

            int[] b = {0,1,2,3,4};
            methodArray(b);
            for(int i = 0;i < 5; i++)
            {
                Console.WriteLine(b[i]);// 츨력 2
            }

            methodRef(ref a);
            Console.WriteLine(a);// 출력 3

        }
    }
}
