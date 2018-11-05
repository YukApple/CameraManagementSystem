using CameraSystem.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraSystem
{
    public static class Helpers
    {
        public enum CommandMethod
        {
            GET,
            SET
        }
        public static string ToMD5(string text)
        {
            byte[] result;
            byte[] data = UTF8Encoding.UTF8.GetBytes(text);

            System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();
            // Get the key from config file

            string key = (string)settingsReader.GetValue("SecurityKey", typeof(String));

            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys,Mode=CipherMode.ECB,Padding=PaddingMode.PKCS7})
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    result = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(result, 0, result.Length);
                }
            }

            
        }

        public static string FromMD5(string text)
        {
            byte[] result;
            byte[] data = Convert.FromBase64String(text);

            System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();
            // Get the key from config file

            string key = (string)settingsReader.GetValue("SecurityKey", typeof(String));

            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    result = transform.TransformFinalBlock(data, 0, data.Length);
                    return UTF8Encoding.UTF8.GetString(result);
                }
            }
        }

        /// <summary>
        /// Get value save in app.cofig
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Return value of key</returns>
        public static string GetSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        /// <summary>
        /// Modify value of key
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetSetting(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
        }

        /// <summary>
        /// Add more setting
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void AddSetting(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings.Add(key,value);
            configuration.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static bool isExistsSetting(string key)
        {
            var value = GetSetting(key);
            if (value == null)
            {
                return false;
            }
            return true;
        }

        public static string SendCommand<T>(List<T> data,CommandMethod method,string modelData)
        {
            var jdata = JsonConvert.SerializeObject(data);
            CommandModel cmd = new CommandModel();
            cmd.Command = method.ToString();
            cmd.Model = modelData;
            cmd.Data = jdata;
            return JsonConvert.SerializeObject(cmd);
        }

    }
}
