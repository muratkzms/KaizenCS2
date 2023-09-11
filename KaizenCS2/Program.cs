using Newtonsoft.Json;

namespace KaizenCS2
{
    internal class Program
    {
        public static void LoadJson()
        {
            using (StreamReader r = new StreamReader("response.json"))
            {
                string json = r.ReadToEnd();
                List<Receipt> items = JsonConvert.DeserializeObject<List<Receipt>>(json);

                Console.WriteLine(items[0].description);
                using (StreamWriter writetext = new StreamWriter("KaizenCS2.txt"))
                {
                    writetext.WriteLine(items[0].description);
                }
            }
        }
        static void Main(string[] args)
        {
            LoadJson();
        }
    }
}