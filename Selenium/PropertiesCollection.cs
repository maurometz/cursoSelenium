using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Selenium
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }
    class PropertiesCollection
    {        
        //Auto-implemented property
        public static IWebDriver driver{ get; set; }
    }
}
