﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _4PD_Saugumas.Functions
{
    public class GenerateRandomPsw
    {
        public string GenerateToken(int length)
        {
            using (RNGCryptoServiceProvider cryptRNG = new RNGCryptoServiceProvider())
            {
                byte[] tokenBuffer = new byte[length];
                cryptRNG.GetBytes(tokenBuffer);
                return Convert.ToBase64String(tokenBuffer);
            }
        }
    }
}
