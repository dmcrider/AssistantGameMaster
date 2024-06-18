using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AssistantGameMaster.Handlers
{
    internal class Security
    {
        private static readonly string _path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Assembly.GetExecutingAssembly().GetName().Name ?? "AssistantGameMaster", "config");
        private static readonly string _openAIConfigFileName = "openai.config";

        public static void SaveApiKey(string apiKey)
        {
            var encrypted = ProtectedData.Protect(Encoding.UTF8.GetBytes(apiKey), null, DataProtectionScope.CurrentUser);
            Directory.CreateDirectory(_path); // Will skip if it already exists
            File.WriteAllBytes(Path.Combine(_path, _openAIConfigFileName), encrypted);
        }

        public static void DeleteApiKey()
        {
            if (File.Exists(_path))
            {
                File.Delete(_path);
            }
        }

        public static string GetApiKey()
        {
            var fullPath = Path.Combine(_path, _openAIConfigFileName);
            if (File.Exists(fullPath))
            {
                var encrypted = File.ReadAllBytes(fullPath);
                var decrypted = ProtectedData.Unprotect(encrypted, null, DataProtectionScope.CurrentUser);
                return Encoding.UTF8.GetString(decrypted);
            }

            return string.Empty;
        }

        public static bool HasApiKey()
        {
            return !string.IsNullOrEmpty(GetApiKey());
        }
    }
}
