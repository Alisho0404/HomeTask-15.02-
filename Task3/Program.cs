 int Sum(int n)
        {
            if (n<=1)
            {
                return 1;
            }
           return n + Sum(n - 1);
        } 
        int n=int.Parse(Console.ReadLine()); 
        System.Console.WriteLine(Sum(n));