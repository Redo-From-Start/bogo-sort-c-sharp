using System;

namespace bogosort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] old = { 1, 6, 42, 6, 43, 234, 68, 2, 7 };
            int[] a = bogo(old);

            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] bogo(int[] old)
        {
            int[] ne = old;
            bool done = false;

            Random rng = new Random();

            while (!done)
            {
                int n = ne.Length;
                while (n > 1)
                {
                    int k = rng.Next(n--);
                    int temp = ne[n];
                    ne[n] = ne[k];
                    ne[k] = temp;
                }

                int p = 0;

                done = true;

                foreach (int i in ne)
                {
                    if (p > i)
                    {
                        done = false;
                        break;
                    }

                    p = i;
                }
            }

            return ne;
        }
    }
}
