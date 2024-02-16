 void Naturalniechislo(int n)
        {

            Console.Write(n+" ");
            if (n<=1)
            {
                return;
            }
            n--;
            Naturalniechislo(n); 
        } 
        int n=int.Parse(Console.ReadLine()); 
        Naturalniechislo(n);
