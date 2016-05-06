using System;
using System.IO;
using System.Security.Cryptography;

namespace PixON
{
    class Format
    {
        public static string GetMD5(string fileName)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(fileName))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower();
                }
            }
        }
    }
}
