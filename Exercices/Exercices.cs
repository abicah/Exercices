 using BenchmarkDotNet.Attributes;
 

namespace exercices;

public class Exercices
{
    [Params(2147483647)]
     public int P { get; set; }

    
    
     public void BasicParam()
    {
         Basic( P);
        
    }
    
    [Benchmark(Baseline =true)]
    public void BasicImprovedParam()
    {
         BasicImproved( P);
        
    }   
    
    [Benchmark]
     public void FermatParam()
    {
         Fermat( P);
        
    }

    public bool Basic(int p)
    {
         
       for ( int i = 2; i *i < p; i++)
        {
             if (p % i == 0) 
                return false; // p is composite
        }
        
        return true;
    }

   public bool  BasicImproved(int p)
    {
        if (p <= 1 ) return false;
        else if (p  <=  3) return true;
        else if ((p % 2 == 0) || (p % 3 == 0)) return false;

        long i = 5;
        
        while (i*i <= p)
        {
            if ((p % i == 0) || (p % (i + 2) ==0)) return false;
            i = i + 6;
        }
        return true;
   }

    Random random = new Random();
    public bool Fermat(int p)
    {
        if (p < 2) return false; // p is not prime
        if (p == 2) return true; // 2 is the only even prime number
        if (p % 2 == 0) return false; // p is even and not 2

        const int k=10; // Number of iterations for the test
        // Fermat's little theorem: if p is prime, a^(p-1) ≡ 1 (mod p) for any a not divisible by p
        // We will test a few random values of a to check if p is prime 
        for (int i = 0; i < k; i++)
        {
            int a = random.Next(2, p ); // Random number between 2 and p-1
            
            if (pgcd(a, p) !=1 || ExpMod(a, p - 1, p) != 1) return false; // p is composite
   
     }

         // If all tests passed, we can assume p is prime
        
        return true;
    }

    long pgcd(long a, long b)
    {
        while (b != 0)
        {
          (a,b)=(b, a % b) ; 
        }

        return a;
    }
    public int ExpMod(int a, int b, int m)
    {
            long res = 1;
            long x = a % m; 

            while (b > 0)
            {
                //if (b % 2 == 1)
                if ((b & 1) == 1)
                {
                    res = (res * x) % m;
                }
                x = (x * x) % m;
                //b /= 2;
                b >>= 1;
            }
            return (int)res;  
         
    }
}
