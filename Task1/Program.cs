void NpervixChisel(int n)
        {
          if (n>=1)
            {
                NpervixChisel(n-1);
                Console.Write(n +" ");
            }
        } 
        int n=int.Parse(Console.ReadLine()); 
        NpervixChisel(n);