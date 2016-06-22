using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iReferU.Models
{
    public class ReferralItem : BaseModel
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "shortdescription")]
        public string ShortDescription { get; set; }

        [JsonProperty(PropertyName = "longdescription")]
        public string LongDescription { get; set; }
    }
}
