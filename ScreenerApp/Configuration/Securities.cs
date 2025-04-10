using Newtonsoft.Json;
using ScreenerLib;
using ScreenerLib.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace ScreenerApp.Configuration
{
    internal static class Securities
    {
        private static string FilePath = Environment.CurrentDirectory;
        private static string FileName = "securities.json";

        public static List<Security> Load(string connectionName)
        {
            FileName = connectionName;

            List<Security> result = new List<Security>();

            try
            {
                using (StreamReader reader = new StreamReader(Path.Combine(FilePath, "Securities", FileName + ".json")))
                {
                    var readResult = reader.ReadToEnd();
                    result = JsonConvert.DeserializeObject<List<Security>>(readResult);
                }
            }
            catch (FileNotFoundException)
            {
                return result;
            }

            return result;
        }

        public static void Save(List<Security> securities)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(Path.Combine(FilePath, "Securities", FileName + ".json")))
                {
                    var data = JsonConvert.SerializeObject(securities);
                    writer.Write(data);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
