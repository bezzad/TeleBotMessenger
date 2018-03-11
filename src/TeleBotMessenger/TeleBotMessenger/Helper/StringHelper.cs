using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TeleBotMessenger.Model;

namespace TeleBotMessenger.Helper
{
    public static class StringHelper
    {
        public static Dictionary<char, char> PersianNumDictionary =
            new Dictionary<char, char>
            {
                {'0', '۰'},
                {'1', '۱'},
                {'2', '۲'},
                {'3', '۳'},
                {'4', '۴'},
                {'5', '۵'},
                {'6', '۶'},
                {'7', '۷'},
                {'8', '۸'},
                {'9', '۹'}
            };


        public static char[] EnglishLetters { get; } = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSWXYZ".ToCharArray()
            ;

        public static char[] NumericalLetters { get; } = "0123456789".ToCharArray();

        public static string UriPattern { get; } =
            @"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$";

        public static char[] SentenceEndLetters { get; } = ".;?!,.،؟!-\r\n\t".ToCharArray();

        public static string GetNetMessage(this string msg)
        {
            if (msg == null) return null;

            msg = msg.Replace("/", "");
            var skipFirstLen = 0;
            foreach (var c in msg)
                if (!c.IsEnglishLetter() && !c.IsArabicLetter())
                    skipFirstLen++;
                else break;

            return msg.Substring(skipFirstLen);
        }

        public static bool IsEnglishLetter(this char ch)
        {
            return EnglishLetters.Any(c => c.Equals(ch)) || NumericalLetters.Any(c => c.Equals(ch));
        }

        public static bool IsEndLetter(this char ch)
        {
            return SentenceEndLetters.Any(c => c.Equals(ch));
        }

        public static bool IsArabicLetter(this char ch)
        {
            var uni = CharUnicodeInfo.GetUnicodeCategory(ch);
            return uni == UnicodeCategory.LetterNumber ||
                   uni == UnicodeCategory.OtherLetter;
        }

        /// <summary>
        ///     Cut the text to special length, so that words should be complete and
        ///     do not cut from between word chars.
        ///     Note:
        ///     The text must be non HTML codes!
        /// </summary>
        /// <param name="text">the text</param>
        /// <param name="maxLength">the point which must be cutting from there</param>
        /// <returns></returns>
        public static string SummeryCreator(this string text, int maxLength = 100)
        {
            text = text.Replace("<", "&lt;").Replace(">", "&gt;").Replace("&", "&amp;");

            if (text.Length <= maxLength) return text;

            var result = text.Substring(0, maxLength - 3);
            var firstLen = result.Length;
            for (var i = firstLen - 1; i > 0; i--)
                if (result[i].IsEndLetter() || char.IsWhiteSpace(result[i]))
                    result = result.Substring(0, i);
                else if (result.Length != firstLen) //  continue removing till char is not end letter
                    break;

            return result + "...";
        }


        /// <summary>
        ///     Encrypt a string using dual encryption method. Return a encrypted cipher Text
        /// </summary>
        /// <param name="toEncrypt">string to be encrypted</param>
        /// <param name="passKey">encryption password</param>
        /// <param name="hashPassword">use hashing? to extra security</param>
        /// <returns></returns>
        public static string UrlEncrypt(this string toEncrypt, string passKey, bool hashPassword = true)
        {
            try
            {
                byte[] keyArray;
                var toEncryptArray = Encoding.UTF8.GetBytes(toEncrypt);

                if (hashPassword)
                {
                    var hashmd5 = new MD5CryptoServiceProvider();
                    keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(passKey));
                    hashmd5.Clear();
                }
                else
                {
                    keyArray = Encoding.UTF8.GetBytes(passKey);
                }

                var tdes = new TripleDESCryptoServiceProvider
                {
                    Key = keyArray,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                };

                var cTransform = tdes.CreateEncryptor();
                var resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                tdes.Clear();

                return Convert.ToBase64String(resultArray).Replace("/", "_").Replace("+", "-").Replace("=", "");
            }
            catch (SecurityException)
            {
                //Logger.Error(se);
                Debugger.Break();
            }
            catch (Exception)
            {
                //Logger.Error(ex);
                Debugger.Break();
            }

            return null;
        }

        /// <summary>
        ///     Decrypt a string using dual encryption method. Return a decrypted clear string
        /// </summary>
        /// <param name="cipherString">encrypted string</param>
        /// <param name="passKey">encryption password</param>
        /// <param name="hashPassword">Did you use the hashing password? pass true if is yes</param>
        /// <returns></returns>
        public static string UrlDecrypt(this string cipherString, string passKey, bool hashPassword = true)
        {
            try
            {
                byte[] keyArray;
                cipherString = cipherString.Replace("_", "/").Replace("-", "+");
                //
                // The base 64 string length must be multiply of 4, 
                // so right padding by char '=' at the end of the string
                if (cipherString.Length % 4 != 0)
                {
                    var padding = 4 - cipherString.Length % 4;
                    cipherString = cipherString.PadRight(padding + cipherString.Length, '=');
                }
                var toEncryptArray = Convert.FromBase64String(cipherString);


                if (hashPassword)
                {
                    var hashmd5 = new MD5CryptoServiceProvider();
                    keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(passKey));
                    hashmd5.Clear();
                }
                else
                {
                    keyArray = Encoding.UTF8.GetBytes(passKey);
                }

                var tdes = new TripleDESCryptoServiceProvider
                {
                    Key = keyArray,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                };

                var cTransform = tdes.CreateDecryptor();
                var resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

                tdes.Clear();
                return Encoding.UTF8.GetString(resultArray);
            }
            catch (SecurityException)
            {
                //Logger.Error(se);
                Debugger.Break();
            }
            catch (Exception)
            {
                //Logger.Error(ex);
                Debugger.Break();
            }
            return null;
        }

        public static string Base64Encode(this string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(this string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static string ToPersianNumber(this int source)
        {
            return source.ToString().Aggregate("", (current, no) => current + PersianNumDictionary[no]);
        }

        public static async Task StoreAsync(string path, List<TelegramMessage> msgList)
        {
            var json = JsonConvert.SerializeObject(msgList, Formatting.None);
            var encodedText = Encoding.Unicode.GetBytes(json);

            Directory.CreateDirectory(Path.GetDirectoryName(path));

            using (var sourceStream = new FileStream(path,
                FileMode.Create, FileAccess.ReadWrite, FileShare.Read,
                bufferSize: 4096, useAsync: true))
            {
                await sourceStream.WriteAsync(encodedText, 0, encodedText.Length);
            }
        }

        public static async Task<List<TelegramMessage>> ReadAsync(string filePath)
        {
            if(!File.Exists(filePath)) return new List<TelegramMessage>();
            using (var sourceStream = new FileStream(filePath,
                FileMode.Open, FileAccess.Read, FileShare.Read,
                bufferSize: 4096, useAsync: true))
            {
                var sb = new StringBuilder();

                var buffer = new byte[0x1000];
                int numRead;
                while ((numRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                {
                    var text = Encoding.Unicode.GetString(buffer, 0, numRead);
                    sb.Append(text);
                }

                var json = sb.ToString();
                var result = JsonConvert.DeserializeObject<List<TelegramMessage>>(json);
                return result;
            }
        }
    }
}