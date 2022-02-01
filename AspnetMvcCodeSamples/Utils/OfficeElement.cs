using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace AspnetMvcCodeSamples.Utils
{
    public class OfficeElement : ConfigurationElement
    {

        [ConfigurationProperty("location")]
        public String Location
        {
            get
            {
                return (String)this["location"];
            }
            set
            {
                this["location"] = value;
            }
        }

        [ConfigurationProperty("address")]
        public String Address
        {
            get
            {
                return (String)this["address"];
            }
            set
            {
                this["address"] = value;
            }
        }
    }
}