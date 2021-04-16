using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CCardoso.Criptografia.Exemplo
{
    public static class CryptRsa
    {
        public static string PrivateKey { get; set; }
        public static string PublicKey { get; set; }
        public static string Encrypt(string text)
        {
            string secret;
            byte[] buffer;

            ReadOnlySpan<byte> spanKey = Convert.FromBase64String(File.ReadAllText(PublicKey));

            RSA rsa = RSA.Create();
            rsa.ImportRSAPublicKey(spanKey, out _);
            
            buffer = rsa.Encrypt(Encoding.UTF8.GetBytes(text), RSAEncryptionPadding.Pkcs1);

            secret = Convert.ToBase64String(buffer);
            return secret;
        }
        public static string Decrypt(string secret)
        {
            string text;
            byte[] buffer;

            ReadOnlySpan<byte> spanKey = Convert.FromBase64String(File.ReadAllText(PrivateKey));

            RSA rsa = RSA.Create();
            rsa.ImportRSAPrivateKey(spanKey, out _);

            buffer = rsa.Decrypt(Convert.FromBase64String(secret), RSAEncryptionPadding.Pkcs1);

            text = Encoding.UTF8.GetString(buffer);
            return text;
        }
    }
}
