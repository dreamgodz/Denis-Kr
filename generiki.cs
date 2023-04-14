using Newtonsoft.Json;
using System;

namespace dz.jen
{
   public static class generiki
   { 
        public static string ToJson<T>(this T obj)
        {
            var json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            Console.WriteLine(json);
            return json;
        }

        public static T OffJson<T>(this string obj)
        {
            var json = JsonConvert.DeserializeObject<T>(obj);
            Console.WriteLine(json);     
            return json;
        }
   }
}
