using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CSharp_TP1
{
    public class Fifth
    {
        public static void JSONParse()
        {
            JObject data = (JObject)JsonConvert.DeserializeObject(File.ReadAllText(@"./file/DOGE_AllDataPoints_3Days.json"));
            Console.Write(data["data"]);
        }
    }
}