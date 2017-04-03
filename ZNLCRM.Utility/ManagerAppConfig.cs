using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Configuration;

namespace ZNLCRM.Utility
{
    public class ManagerAppConfig
    {
        // <summary>
        /// 依据连接串名字connectionName返回数据连接字符串
        /// </summary>
        /// <param name="connectionName"></param>
        /// <returns></returns>
        public static string GetConnectionStringsConfig(string connectionName)
        {
            string connectionString =
                    EncrypHandler.Decrypto(ConfigurationManager.ConnectionStrings[connectionName].ConnectionString.ToString());
            //Console.WriteLine(connectionString);
            return connectionString;
        }

        /// <summary>
        /// 更新连接字符串
        /// </summary>
        /// <param name="newName"> 连接字符串名称 </param>
        /// <param name="newConString"> 连接字符串内容 </param>
        /// <param name="newProviderName"> 数据提供程序名称 </param>
        public static void UpdateConnectionStringsConfig(string newName,
            string newConString,
            string newProviderName)
        {
            bool isModified = false;    // 记录该连接串是否已经存在
            // 如果要更改的连接串已经存在
            if (ConfigurationManager.ConnectionStrings[newName] != null)
            {
                isModified = true;
            }
            // 新建一个连接字符串实例
            ConnectionStringSettings mySettings =
                new ConnectionStringSettings(newName, EncrypHandler.Encrypto(newConString), newProviderName);
            // 打开可执行的配置文件*.exe.config
            Configuration config =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // 如果连接串已存在，首先删除它
            if (isModified)
            {
                config.ConnectionStrings.ConnectionStrings.Remove(newName);
            }
            // 将新的连接串添加到配置文件中.
            config.ConnectionStrings.ConnectionStrings.Add(mySettings);
            // 保存对配置文件所作的更改
            config.Save(ConfigurationSaveMode.Modified);
            // 强制重新载入配置文件的ConnectionStrings配置节
            ConfigurationManager.RefreshSection("ConnectionStrings");
        }

        /// <summary>
        /// 返回＊.exe.config文件中appSettings配置节的value项
        /// </summary>
        public static string GetAppConfig(string name)
        {
            return ConfigurationManager.AppSettings
                .Cast<string>() // key
                .Any(key => key == name)
                    ? ConfigurationManager.AppSettings[name]
                    : null;
        }

        /// <summary>
        /// 在＊.exe.config文件中appSettings配置节增加一对键、值对
        /// </summary>
        public static void UpdateAppConfig(string name, string value)
        {
            bool isModified = ConfigurationManager.AppSettings
                .Cast<string>().Any(key => key == name);

            // Open App.Config of executable

            Configuration config = ConfigurationManager
                .OpenExeConfiguration(ConfigurationUserLevel.None);
            // You need to remove the old settings object before you can replace it
            if (isModified)
            {
                config.AppSettings.Settings.Remove(name);
            }
            // Add an Application Setting.
            config.AppSettings.Settings.Add(name, value);
            // Save the changes in App.config file.
            config.Save(ConfigurationSaveMode.Modified);
            // Force a reload of a changed section.
            ConfigurationManager.RefreshSection("appSettings");
        }

        /// <summary>
        /// 设置AppConfig键值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetAppConfigKeyValue(string xpath, string attributeName, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(config.FilePath);
                XmlElement node = xmlDoc.SelectSingleNode(xpath) as XmlElement;
                if (node != null)
                {
                    node.SetAttribute(attributeName, value);
                    xmlDoc.Save(config.FilePath);
                }
            }
            catch { }
        }

        /// <summary>
        /// 获取AppConfig键值
        /// </summary>
        /// <param name="key"></param>
        public static string GetAppConfigKeyValue(string xpath, string attributeName)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string strRet = string.Empty;
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(config.FilePath);
                XmlElement node = xmlDoc.SelectSingleNode(xpath) as XmlElement;
                if (node != null)
                {
                    strRet = node.GetAttribute(attributeName);
                }
            }
            catch { }
            return strRet;
        }
    }
}
