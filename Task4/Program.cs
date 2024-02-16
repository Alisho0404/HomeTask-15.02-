 void DigitsNumber(int n)
        {
            if (n/10!=0)
            {
                DigitsNumber(n / 10);
            }
            Console.Write(n%10+" ");
        } 
         int n=int.Parse(Console.ReadLine());
         DigitsNumber(n);