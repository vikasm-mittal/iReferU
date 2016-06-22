using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iReferU.Models
{
    public class BaseModel
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [Version]
        public string Version { get; set; }
    }
}
