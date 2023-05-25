using Newtonsoft.Json;

namespace SerealizationAndDeserealizationLib
{
    public class SerealizationAndDeserealizationLib
    {
        public static void Serialize<T>(T list)
        {
            string json = JsonConvert.SerializeObject(list);
            string path = "C:\\заметки\\result.json";
            File.WriteAllText(path, json);
        }
        public static T Deserialize<T>()
        {
            string path = "C:\\заметки\\result.json";
            string json = File.ReadAllText(path); ;
            T list = JsonConvert.DeserializeObject<T>(json);
            return list;
        }
    }
}