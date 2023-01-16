using System;
using System.Collections.Generic;
using System.Text;

namespace Shifr1
{
    internal class ShifrDeshifr
    {
        private static byte perem = 0x44;

        public static byte[] Shifrovka(byte[] fo)
        {
            
                for (int i = 0; i < fo.Length; i++)
                {
                    fo[i] ^= perem;
                }
                return fo;
            
        }
        public static byte[] Deshifrovka(byte[] fo)
        {
           
                for (int i = 0; i < fo.Length; i++)
                {
                    fo[i] ^= perem;
                }
                return fo;
           
        }
    }
}
