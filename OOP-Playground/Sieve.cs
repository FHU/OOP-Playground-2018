using System;

namespace OOPPlayground
{
    public class Sieve
    {

        public Sieve()
        {
        }

        public void FindPrimes(int min, int max) {

            //initialize boolean array

            bool[] numbers = new bool[max + 1];
            for (int i = 2; i <= max; i++) {
                numbers[i] = true;
            }

            // iterate over multiples 
            int sqrtMax = (int)Math.Sqrt(max);
            for (int i = 2; i < sqrtMax ; i++) {
                if( numbers[i]) {
                    for (int j = i * i; j < max; j+=i) {
                        numbers[j] = false;
                    }
                }
            }

            //mark multiples as false


            //iterate over array to find primes remaining

        }
    }
}
