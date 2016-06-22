using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iReferUService.DataObjects
{
    public class ReferralItem : EntityData
    {
        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }
    }
}