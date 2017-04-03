using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace ZNLCRM.Utility
{
    public class EncrypHandler
    {
        private const int KeySize = 32;     //密码长度
        private const int KeyPostion = 20; //密码位置
        private static SymmetricAlgorithm mobjCryptoService = new RijndaelManaged();
        private static string Key = "7by1JIN3vG1Qy3R8feycKW2MukTgasvK";
        #region 对称加解密处理
        /// <summary>
        /// 获得密钥
        /// </summary>
        /// <returns>密钥</returns>
        private static byte[] GetLegalKey(string Key)
        {
            string sTemp = Key;
            mobjCryptoService.GenerateKey();
            byte[] bytTemp = mobjCryptoService.Key;
            int KeyLength = bytTemp.Length;
            if (sTemp.Length > KeyLength)
                sTemp = sTemp.Substring(0, KeyLength);
            else if (sTemp.Length < KeyLength)
                sTemp = sTemp.PadRight(KeyLength, ' ');
            return ASCIIEncoding.ASCII.GetBytes(sTemp);
        }

        /// <summary>
        /// 获得初始向量IV
        /// </summary>
        /// <returns>初试向量IV</returns>
        private static byte[] GetLegalIV()
        {
            string sTemp = "E4ghj*Ghg7!rNIfb&95GUY86GfghUb#er57HBh(u%g6HJ($jhWk7&!hg4ui%$hjk";
            mobjCryptoService.GenerateIV();
            byte[] bytTemp = mobjCryptoService.IV;
            int IVLength = bytTemp.Length;
            if (sTemp.Length > IVLength)
                sTemp = sTemp.Substring(0, IVLength);
            else if (sTemp.Length < IVLength)
                sTemp = sTemp.PadRight(IVLength, ' ');
            return ASCIIEncoding.ASCII.GetBytes(sTemp);
        }

        /// <summary>
        /// 加密方法
        /// </summary>
        /// <param name="Source">待加密的串</param>
        /// <returns>经过加密的串</returns>
        public static string Encrypto(string Source)
        {
            if (Key.Length != KeySize)
                return "";
            //if (Source.Length <= KeyPostion)
            //    Source += Key;
            //else
            //    Source.Insert(KeyPostion, Key);
            byte[] bytIn = UTF8Encoding.UTF8.GetBytes(Source);
            MemoryStream ms = new MemoryStream();
            mobjCryptoService.Key = GetLegalKey(Key);
            mobjCryptoService.IV = GetLegalIV();
            ICryptoTransform encrypto = mobjCryptoService.CreateEncryptor();
            CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Write);
            cs.Write(bytIn, 0, bytIn.Length);
            cs.FlushFinalBlock();
            ms.Close();
            byte[] bytOut = ms.ToArray();
            string encryStr = Convert.ToBase64String(bytOut);
            //200字节处放32位密码
            if (encryStr.Length <= KeyPostion)
                encryStr += Key;
            else
                encryStr = encryStr.Insert(KeyPostion, Key);

            return encryStr;
        }

        /// <summary>
        /// 文件加密
        /// </summary>
        public static void Encrypto(string sourceFile, string targetFile)
        {
            StreamReader sr = new StreamReader(sourceFile);
            StreamWriter sw = new StreamWriter(targetFile);
            string lsStr = sr.ReadToEnd();
            lsStr = Encrypto(lsStr);
            sw.Write(lsStr);
            sw.Close();
            sr.Close();
        }

        /// <summary>
        /// 解密方法
        /// </summary>
        /// <param name="Source">待解密的串</param>
        /// <returns>经过解密的串</returns>
        public static string Decrypto(string Source)
        {
            string Key = "";
            if (Source.Length < KeySize)
                return "";
            if (Source.Length < KeySize + KeyPostion)
            {
                Key = Source.Substring(Source.Length - KeySize, KeySize);
                Source = Source.Substring(0, Source.Length - KeySize);
            }
            else
            {
                Key = Source.Substring(KeyPostion, KeySize);
                Source = Source.Substring(0, KeyPostion) + Source.Substring(KeyPostion + KeySize);
            }
            byte[] bytIn = Convert.FromBase64String(Source);
            MemoryStream ms = new MemoryStream(bytIn, 0, bytIn.Length);
            mobjCryptoService.Key = GetLegalKey(Key);
            mobjCryptoService.IV = GetLegalIV();
            ICryptoTransform encrypto = mobjCryptoService.CreateDecryptor();
            CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cs);
            return sr.ReadToEnd();
        }
        
        #endregion

        public static string MD5(string text)
        {
            byte[] bytes = Encoding.Default.GetBytes(text);
            byte[] buffer2 = new MD5CryptoServiceProvider().ComputeHash(bytes);
            string str = "";
            foreach (byte num in buffer2)
            {
                if (num < 0x10)
                {
                    str = str + "0" + num.ToString("X");
                }
                else
                {
                    str = str + num.ToString("X");
                }
            }
            return str.ToLower();
        }

        
    }
}
