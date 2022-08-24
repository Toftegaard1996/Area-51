using System;

namespace Area_51.Classes
{

        public static class RNG
        {
            private static Random _rnd = new Random();

            public static int Range(int a, int b)
            {
                return _rnd.Next(a,b);
            }

        }
    
}
