using System.Security.Cryptography;
using System.Text;

namespace Nfsw.Core.Common.Utilities
{
    public class MD5Hash
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string HashString(string text)
        {
            using (var md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(text);
                byte[] hash = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                    sb.Append(hash[i].ToString("X2").ToLower());

                return sb.ToString();
            }
        }
    }
}
