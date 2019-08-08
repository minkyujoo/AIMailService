using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AIMailService.Svc
{
    public class IntentEntity
    {
        public bool isImportance { get; set; }
        public string intent { get; set; }
        public double Confidence { get; set; }
        public string displayIntent { get; set; }

    }
}