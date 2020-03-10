using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SHA1
{
    class Program
    {
        static void Main(string[] args)
        {
            string plainText = "SHA-1 Örneği";
            Console.Write("Özetlemek istediğiniz Veriyi Giriniz:");
            plainText = Console.ReadLine();
            Console.WriteLine(String.Format("Metinin açık hali: {0}",plainText));
            SHA1 shaObject = new SHA1();
            string digeestText = shaObject.Hash(plainText);
            Console.WriteLine(String.Format("Metinin SHA-1 ile Çıkarılmış hali: {0}", digeestText));



            Console.ReadKey();
        }
    }

   public class SHA1
    {
         public string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }
    }
}
