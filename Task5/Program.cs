 int CountNumber(int n)
        {
            int count = 0;
            if(n<=1)
            {
                return 1;
            }
            n /= 10;
            count++;
            return count+CountNumber(n-1);
              
        } 
        int n=int.Parse(Console.ReadLine()); 
        Console.WriteLine(CountNumber(n));