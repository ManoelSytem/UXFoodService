using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UxFoodService.Util
{
    public class JsonAutoMapperGeneric : IJsonAutoMapper
    {
        public T ConvertAutoMapperJson<T>(object obj)
        {
            string Jsonvalor = JsonConvert.SerializeObject(obj);
            T novaEntidade = JsonConvert.DeserializeObject<T>(Jsonvalor);
            return novaEntidade;
        }

        public List<T> ConvertAutoMapperListJson<T>(IEnumerable<object> obj)
        {
            string Jsonvalor = JsonConvert.SerializeObject(obj);
            List<T> novaEntidade = JsonConvert.DeserializeObject<List<T>>(Jsonvalor);
            return novaEntidade;
        }

        public List<T> ConvertAutoMapperListJsonString<T>(string Jsonvalor)
        {
            List<T> novaEntidade = JsonConvert.DeserializeObject<List<T>>(Jsonvalor);
            return novaEntidade;
        }
    }
}
