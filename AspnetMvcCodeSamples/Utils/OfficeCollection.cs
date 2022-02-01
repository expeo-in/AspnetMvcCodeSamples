using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace AspnetMvcCodeSamples.Utils
{
    public class OfficeCollection: ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new OfficeElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((OfficeElement)element).Location;
        }
    }
}