using System.Text.Json;

namespace GasStation
{
    public static class JsonLogic
    {
        public static bool SaveToJson<T>(List<T> list, string path)
        {
            try
            {
                string jsonstring = "";

                foreach (T item in list)
                {
                    jsonstring += JsonSerializer.Serialize<T>(item);
                    jsonstring += "\n";
                }
                File.WriteAllText(path, jsonstring);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool ReadFromJson<T>(string path, out List<T> list)
        {
            list = new();

            try
            {
                List<string> lines = new();
                lines = File.ReadAllLines(path).ToList();

                foreach (string line in lines)
                {
                    T? item = JsonSerializer.Deserialize<T>(line);

                    if (item != null) list.Add(item);
                }
                return true;
            }
            catch (IOException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
