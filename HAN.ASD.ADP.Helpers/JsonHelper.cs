using System.Text.Json;

namespace HAN.ASD.ADP.Helpers
{
    public static class JsonHelper
    {
        public static T? LoadJson<T>(string path) where T : class
        {
            T? items = null;
            using (var reader = new StreamReader(path))
            {
                var json = reader.ReadToEnd();
                if (json != null)
                {
                    items = JsonSerializer.Deserialize<T?>(json);
                }
            }

            return items;
        }
    }
}
