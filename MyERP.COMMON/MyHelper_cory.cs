using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
 namespace MyERP.COMMON
{
    public static class MyHelper_cory
    {
        #region 字符串类
        /// <summary>
        /// 合并字符串(将两个用分割符分割的长度相同的字符串合并为一个用指定分割符分割的字符串)
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="splitChar1"></param>
        /// <param name="s2"></param>
        /// <param name="splitChar2"></param>
        /// <param name="splitChar3"></param>
        /// <returns></returns>
        public static string mergerString(string s1, char splitChar1, string s2, char splitChar2, char splitChar3)
        {
             string[] ss1 = s1.Split(new char[] { splitChar1 });
            string[] ss2 = s2.Split(new char[] { splitChar2 });
            string summ = null;
            for (int i = 0; i < ss1.Length; i++)
            {
                summ += ss1[i].Trim() + splitChar3 + ss2[i].Trim() + ' ';
             }
            return summ;
        }
        #endregion
         #region 密码类
         /// <summary>
        /// 计算字符串的MD5值
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        private static string GetMd5FromString(string msg)
        {
            //1.创建一个用来计算MD5值的类的对象
            using (MD5 md5 = MD5.Create())
            {
                 //把字符串转为Byte[]  注意:如字符串中包含汉字,则这里会把汉字使用UTF-8编码转换为Byte[] 
                byte[] bytemsg = Encoding.Default.GetBytes(msg);
                //2.计算给定字符串MD5值 
                //返回值就是算后后MD5值,如何把一个长度为16的byte[]转为一个长度为32的字符串,就是把每个byte转为16进制同时保留2位即可
                byte[] encryptmsg = md5.ComputeHash(bytemsg);
                md5.Clear();//释放资料
                StringBuilder sbMd5 = new StringBuilder();
                for (int i = 0; i < encryptmsg.Length; i++)
                {
                    sbMd5.Append(encryptmsg[i].ToString("x2"));  //x2 表示16进制2位
                }
                return sbMd5.ToString();
            }
        }
         /// <summary>
        /// 计算文件的Md5值
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private static string GetMd5FromFile(string filePath)
        {
            //using(FileStream fsRead=new FileStream(filePath,FileMode.Open,FileAccess.Read))
            //{
             //    byte[] buffer=new byte[1024*1254*5];
            //    int n = fsRead.Read(buffer, 0, buffer.Length);
            //}
             using (MD5 md5 = MD5.Create())
            {
                using (FileStream fsRead = File.OpenRead(filePath))
                {
                    byte[] bytes = md5.ComputeHash(fsRead);
                    md5.Clear(); //Md5类资源
                    StringBuilder sbMd5 = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        sbMd5.Append(bytes[i].ToString("X2")); //X2表示大写十六制二位 x2表示小写十六制二位
                    }
                    return sbMd5.ToString();
                }
            }
        }
         #region 字符串加密解密
        /// <summary>
        /// Base64加密
        /// </summary>
        /// <param name="codeName">加密采用的编码方式</param>
        /// <param name="source">待加密的明文</param>
        /// <returns></returns>
        public static string EncodeBase64(Encoding encode, string source)
        {
            string enstring = "";
            byte[] bytes = encode.GetBytes(source);
            try
            {
                enstring = Convert.ToBase64String(bytes);
            }
            catch
            {
                enstring = source;
            }
            return enstring;
        }
         /// <summary>
        /// Base64加密，采用utf8编码方式加密
        /// </summary>
        /// <param name="source">待加密的明文</param>
        /// <returns>加密后的字符串</returns>
        public static string EncodeBase64(string source)
        {
            return EncodeBase64(Encoding.UTF8, source);
        }
         /// <summary>
        /// Base64解密
        /// </summary>
        /// <param name="codeName">解密采用的编码方式，注意和加密时采用的方式一致</param>
        /// <param name="result">待解密的密文</param>
        /// <returns>解密后的字符串</returns>
        public static string DecodeBase64(Encoding encode, string result)
        {
            string decode = "";
            byte[] bytes = Convert.FromBase64String(result);
            try
            {
                decode = encode.GetString(bytes);
            }
            catch
            {
                decode = result;
            }
            return decode;
        }
         /// <summary>
        /// Base64解密，采用utf8编码方式解密
        /// </summary>
        /// <param name="result">待解密的密文</param>
        /// <returns>解密后的字符串</returns>
        public static string DecodeBase64(string result)
        {
            return DecodeBase64(Encoding.UTF8, result);
        }
        #endregion
         /// <summary>
        /// MD5加密函数  密码盐提高安全性 MD5(password+"字符串")
        /// </summary>
        /// <param name="sDataIn"></param>
        /// <returns></returns>
        public static string GetMD5(string sDataIn)
        {
            //MD5CryptoServiceProvider 需要using
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bytValue, bytHash;
            bytValue = System.Text.Encoding.UTF8.GetBytes(sDataIn);
            bytHash = md5.ComputeHash(bytValue);
            md5.Clear();
            string sTemp = "";
            for (int i = 0; i < bytHash.Length; i++)
            {
                sTemp += bytHash[i].ToString("X").PadLeft(2, '0');
             }
            return sTemp.ToLower();
        }
        #endregion
         /// <summary>
        /// 限制只能打开一个进程
        /// </summary>
        /// <returns></returns>
        //public static bool SingerThreading()
        //{
        //    bool ret;
        //    System.Threading.Mutex mutex = new System.Threading.Mutex(true, System.Windows.Forms.Application.ProductName, out ret);
        //    // MessageBox.Show(System.Windows.Forms.Application.ProductName);
        //    if (ret)
        //    {
        //        System.Windows.Forms.Application.EnableVisualStyles();
        //        //System.Windows.Forms.Application.DoEvents();
        //        //System.Windows.Forms.Application.Run(new Main());
        //        mutex.ReleaseMutex();
        //        return false;
        //    }
        //    else
        //    {
        //        // MessageBox.Show(null, "有一个和本程序相同的应用程序已经在运行，请不要同时运行多个本程序。\n\n这个程序即将退出", System.Windows.Forms.Application.ProductName, MessageBoxButton.OK,MessageBoxImage.Warning);
        //        //MessageBox.Show(System.Windows.Forms.Application.ProductName);
        //        return true;
         //    }
        //}
                 /// <summary>
        /// 获取当前登陆Windows用户名
        /// </summary>
        /// <returns></returns>
        public static string GetUserName()
        {
            return System.Environment.UserName.ToString();
        }
         /// <summary>
        /// 获取当前主机名
        /// </summary>
        /// <returns></returns>
        public static string GetHostName()
        {
            return System.Net.Dns.GetHostName();
        }
         /// <summary>
        /// 获取今天是星期几
        /// </summary>
        /// <returns></returns>
        public static string GetWeek()
        {
            string str = DateTime.Now.DayOfWeek.ToString().Trim();
            string strWeek = "";
            switch (str)
            {
                case "Monday":
                    strWeek = "星期一";
                    break;
                case "Tuesday":
                    strWeek = "星期二";
                    break;
                case "Wednesday":
                    strWeek = "星期三";
                    break;
                case "Thursday":
                    strWeek = "星期四";
                    break;
                case "Friday":
                    strWeek = "星期五";
                    break;
                case "Saturday":
                    strWeek = "星期六";
                    break;
                case "Sunday":
                    strWeek = "星期日";
                    break;
            }
            return strWeek;
        }
         /// <summary>
        /// 获取第一分区硬盘编号
        /// </summary>
        /// <returns>返回一个字符串类型</returns>
         public static string GetHardDiskID()
        {
            try
            {
                 ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
                 string strHardDiskID = null;
                 foreach (ManagementObject mo in searcher.Get())
                {
                     strHardDiskID = mo["SerialNumber"].ToString().Trim();
                     break;
                 }
                 return strHardDiskID;
             }
             catch
            {
                 return "";
             }
         }
         /// <summary>
         /// 获取CPU编号
         /// </summary>
         /// <returns>返回一个字符串类型</returns>
         public static string Get_CPUID()
        {
             try
            {
                 //需要在解决方案中引用System.Management.DLL文件
                 ManagementClass mc = new ManagementClass("Win32_Processor");
                 ManagementObjectCollection moc = mc.GetInstances();
                 string strCpuID = null;
                 foreach (ManagementObject mo in moc)
                {
                     strCpuID = mo.Properties["ProcessorId"].Value.ToString();
                     break;
                 }
                 return strCpuID;
             }
             catch
            {
                 return "";
             }
        }
    }
}
