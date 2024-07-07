using System;
using System.Buffers;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace BudgetAPI
{
    public class Secrecy
    {
        public static string hashString(string word)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hValue = Encoding.ASCII.GetBytes(word);
                byte[] result = SHA256.HashData(hValue);
                return Encoding.ASCII.GetString(result);
            }
        }
    }
}
