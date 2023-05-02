using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GestionMatériel.Utils
{
    public class Password
    {

        const int KeySize = 64;
        const int Iterations = 35000;
        HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;
         public string HashPasword(string password, out byte[] salt)
        {
            salt = RandomNumberGenerator.GetBytes(KeySize);
            var hash = Rfc2898DeriveBytes.Pbkdf2(Encoding.UTF8.GetBytes(password), salt, Iterations, hashAlgorithm, KeySize);

            return Convert.ToHexString(hash);
        }

        public bool VerifyPassword(string password, string hash, byte[] salt) 
        {
            var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, hashAlgorithm, KeySize);

            return hashToCompare.SequenceEqual(Convert.FromHexString(hash));
        }
    }
}
