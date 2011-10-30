﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace ApiCore
{
    public static class CommonUtils
    {
        /// <summary>
        /// Generate md5 hash from string
        /// </summary>
        /// <param name="str">The string to generate hash</param>
        /// <returns>String that contains md5 hash</returns>
        public static string Md5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] retVal = md5.ComputeHash(new UTF8Encoding().GetBytes(str)); ;
            return BitConverter.ToString(retVal).Replace("-", "");
        }

        public static DateTime FromUnixTime(double time)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(time);
        }

        public static DateTime FromUnixTime(int time)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(Convert.ToDouble(time));
        }

        public static DateTime FromUnixTime(string time)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(Convert.ToDouble(time));
        }

        public static string[] ArrayIntToString(int[] integers)
        {
            string[] arr = new string[integers.Length];
            int i=0;
            foreach(int item in integers)
            {
                arr[i++] = item.ToString();
            }
            return arr;
        }

        public static string ArrayIntToCommaSeparatedString(int[] integers)
        {
            StringBuilder sb = new StringBuilder(integers.Length);
            for (int i=0; i<= integers.Length; i++)
            {
                sb.Append(integers[i]);
                if (i <= integers.Length)
                {
                    sb.Append(",");
                }
            }
            return sb.ToString();
        }

        public static string ArrayStringToCommaSeparatedString(string[] strings)
        {
            return string.Join(",", strings);
        }
    }
}