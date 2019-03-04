using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcInternationalization.Models
{
    public class LanguageVM
    { 
      
        public int selected { get; set; }
        
        public string English { get; set; }
       public string  Arabic { get; set; }
      public  string  Espanich { get; set; }
        public string Name { get; set; }
        public LanguageVM() { this.selected = -1; }
    }
}