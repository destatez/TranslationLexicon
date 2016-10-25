using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TranslationLexicon.Models
{
    public class Entry
    {
        public string Id { get; set; }
        public string Definition { get; set; }
        public string CheckedBy { get; set;}
        public string CheckedOn { get; set; }
    }
}
