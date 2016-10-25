using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;
using TranslationLexicon.Models;

namespace TranslationLexicon.Controllers
{
    [Route("api/[controller]")]
    public class InterchangeController: Controller
    {
        [HttpGet("Import")]
        public List<Entry> TestImport()
        {
            Db dbinterface = new Db();
            foreach(Entry e in dbinterface.Entries)
            {
                dbinterface.Remove(e);
            }
            dbinterface.SaveChanges();
            string input = System.IO.File.ReadAllText("input.xml");
            List<Entry> output = new List<Entry>();
            XDocument doc = XDocument.Parse(input);
            var entries = doc.XPathSelectElements("//entry");
            foreach (var e in entries)
            {
                Entry entry = new Entry();
                entry.Id = e.Attribute("n").Value.Split('|')[0];
                entry.Definition = e.ToString();
                output.Add(entry);
                dbinterface.Entries.Add(entry);
            }
            dbinterface.SaveChanges();
            return output;
        }
    }
}
