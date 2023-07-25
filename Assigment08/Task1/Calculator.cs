namespace Calculator
{
    public static class Calculator
    {
        private static int x;
        private static int y;

        public static int Add(int x, int y)
        {
            return x+y;
        }
        public static int Subtract(int x, int y)
        {
            return x-y;
        }
        public static int Multiply(int x, int y)
        {
            return x*y;
        }
        public static int Divide(int x, int y)
        {
            if(y == 0)
            { 
            Console.WriteLine("nulze gayofa ar sheidzleba"); 
            }
            return x/y;
        }
        public static double Pow(double x, int y)
        {
            if (y < 0)
            {
                x = 1 / x;
            }
            if (y == 0)  
            {
                return 1;
            }
            if (y == 1)  
            {
                return x;
            }
            double ans = 1;
            for (int i = 0; i < y; i++)
            ans *= x;
            return ans;
        }

        public static double Sqrt(double x)
        {
            if (x <= 0)
            {
                Console.WriteLine("sheiyvanet dadebiti ricxvi");
            }

            if (x == 1)
            {
                return x;
            }
            double ans = 1;
            double i = 1;
            while (true)
            {
               i++;
               ans = (x / ans + ans) / 2;
               if (i == x + 1)
                {
                    break;
                }
            }
            return ans;
        }
    }
}