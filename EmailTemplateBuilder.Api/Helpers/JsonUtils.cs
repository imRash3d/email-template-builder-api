using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailTemplateBuilder.Api.Helpers
{
    public class JsonUtils
    {
        /*
        private static readonly JsonSerializerSettings _options
       = new() { NullValueHandling = NullValueHandling.Ignore };
        public static void WriteJsonFIle(object obj, string fileName)
        {

            var jsonString = JsonConvert.SerializeObject(obj, Formatting.Indented, _options);
            File.WriteAllText(fileName, jsonString);

            var mimeType = "application/json";
            var fileBytes = Encoding.ASCII.GetBytes(jsonString);
             new FileContentResult(fileBytes, mimeType)
            {
                FileDownloadName = fileName
            };
        }
        */
    }
}

