using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECART.Utility
{
    public class Utility
    {
        public static string ConvertObjectToJsonString(object t)
        {
            return JsonConvert.SerializeObject(t);
        }
    }
}