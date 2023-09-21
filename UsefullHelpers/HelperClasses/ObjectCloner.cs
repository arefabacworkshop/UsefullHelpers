using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsefullHelpers.HelperClasses
{
    public static class ObjectCloner
    {
        public static T CloneObject<T>(T obj)
        {
            if (obj == null)
                return default(T);

            string serializedObject = JsonConvert.SerializeObject(obj);
            return JsonConvert.DeserializeObject<T>(serializedObject);
        }
    }

}
