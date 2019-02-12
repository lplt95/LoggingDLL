using System;
using System.Text;
using System.Security.Cryptography;

namespace LoggingDLL
{
    public class Crypto
    {
        /// <summary>
        /// Preparing hash of string using SHA-512
        /// </summary>
        /// <param name="input">String to hash</param>
        /// <returns></returns>
        public static string GetHash(string input)
        {
            SHA512CryptoServiceProvider _shaCrypto = new SHA512CryptoServiceProvider();
            byte[] _data = _shaCrypto.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder _sBulider = new StringBuilder();
            for (int i = 0; i < _data.Length; i++)
            {
                _sBulider.Append(_data[i].ToString("x2"));
            }
            return _sBulider.ToString();
        }
        /// <summary>
        /// Veryfing if one hash is compare to second one.
        /// </summary>
        /// <param name="input">Inputed string to hash</param>
        /// <param name="hash">The hashed one</param>
        /// <returns>True if strings are compare, false if not.</returns>
        public static bool VerifyHash (string input, string hash)
        {
            string _hashOfInput = GetHash(input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(_hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
