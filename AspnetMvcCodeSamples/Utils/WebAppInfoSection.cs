using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace AspnetMvcCodeSamples.Utils
{
    public class WebAppInfoSection : ConfigurationSection
    {
        [ConfigurationProperty("title")]
        public string Title
        {
            get
            {
                return (string)this["title"];
            }
            set
            { 
                this["title"] = value; 
            }
        }

        [ConfigurationProperty("contact")]
        public ContactElement Contact
        {
            get
            {
                return (ContactElement)this["contact"];
            }
            set
            { this["contact"] = value; }
        }


        [ConfigurationProperty("offices")]
        [ConfigurationCollection(typeof(OfficeCollection))]
        public OfficeCollection Offices
        {
            get
            {
                OfficeCollection officeCollection = (OfficeCollection)this["offices"];
                return officeCollection;
            }

            set
            {
                this["offices"] = value;
            }
        }
    }
}