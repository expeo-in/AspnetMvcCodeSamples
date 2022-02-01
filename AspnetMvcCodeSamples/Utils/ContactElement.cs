using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace AspnetMvcCodeSamples.Utils
{
    public class ContactElement : ConfigurationElement
    {
        [ConfigurationProperty("name")]
        public String Name
        {
            get
            {
                return (String)this["name"];
            }
            set
            {
                this["name"] = value;
            }
        }

        [ConfigurationProperty("email")]
        public String Email
        {
            get
            {
                return (String)this["email"];
            }
            set
            {
                this["email"] = value;
            }
        }

    }
}