using Newtonsoft.Json;
using ScreenerLib.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace ScreenerApp.Configuration
{
    internal static class Accounts
    {
        private static string FilePath = Environment.CurrentDirectory;
        private static string FileName = "accounts.json";

        public static List<Account> Load()
        {
            List<Account> result = new List<Account>();

            try
            {
                using (StreamReader reader = new StreamReader(Path.Combine(FilePath, FileName)))
                {
                    var readResult = reader.ReadToEnd();
                    result = JsonConvert.DeserializeObject<List<Account>>(readResult);
                }

                foreach(var account in result)
                {
                    using (StreamReader reader = new StreamReader(Path.Combine(FilePath, "Accounts", account.Name + ".json")))
                    {
                        account.Json = reader.ReadToEnd();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                return result;
            }

            return result;
        }
    }
}
