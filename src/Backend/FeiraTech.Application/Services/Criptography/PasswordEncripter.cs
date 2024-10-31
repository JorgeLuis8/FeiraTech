using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FeiraTech.Application.Services.Criptography
{
    public class PasswordEncripter
    {
        public string Encript(string password)
        {
            var key = "ABC"; //chave para encriptar a senha
            var newPass = $"{password}{key}";

            var bytes = new UTF8Encoding().GetBytes(newPass);
            var hashBytes = SHA512.HashData(bytes);
            return ConvertToString(hashBytes);
        }

        //convertendo array de bytes para string
        private static string ConvertToString(byte[] hashBytes)
        {

            var builder = new StringBuilder();
            foreach (var b in hashBytes)
            {
                var hex = b.ToString("x2");
                builder.Append(hex);
            }
            return builder.ToString();
        }
    }
}
