using System.Text.Json;

namespace StudentAPI
{
    public static class MahasiswaHelper
    {
        public static List<Mahasiswa> JsonToMhs()
        {
            string text = File.ReadAllText(@"./mahasiswa.json");
            return JsonSerializer.Deserialize<List<Mahasiswa>>(text);           
        }

        public static void MhsToJson(List<Mahasiswa> mhs)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(mhs, options);
            File.WriteAllText(@"./mahasiswa.json", jsonString);
        }
    }
}
