using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace TubesAppTB1._1
{
    internal class hitungPenilaianConfig
    {
        public bintangConfig conf;
        public string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        public string fileConfigName = "aplikasi_tambalBan.json";

        public hitungPenilaianConfig()
        {
            try
            {
                ReadConfigFile();
            }
            catch
            {
                SetDefault();
                WriteConfigFile();
            }
        }

        private void SetDefault()
        {
            beriRatingConfig objBeriRating = new beriRatingConfig(
                "Mohon maaf atas ketidakpuasan layanan dari kami",
                "Terimakasih atas penilaian anda");
            List<string> jenisNamaGerai = new List<string>() { "pit", "drow", "tiny", "spirit" };

            conf = new bintangConfig(objBeriRating, jenisNamaGerai);
        }

        private bintangConfig ReadConfigFile()
        {
            String jsonStringFromFile = File.ReadAllText(path + "/" + fileConfigName);
            conf = JsonSerializer.Deserialize<bintangConfig>(jsonStringFromFile);
            return conf;
        }

        private void WriteConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };

            string jsonString = JsonSerializer.Serialize(conf, options);
            string fullFilePath = path + "/" + fileConfigName;
            File.WriteAllText(fullFilePath, jsonString);
        }
    }
}
