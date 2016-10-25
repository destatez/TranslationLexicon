using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Query;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TranslationLexicon.Models;
using TranslationLexicon;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Xml.Linq;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace TranslationLexicon.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Entry> Get()
        {

            Db db = new Db();
            return db.Entries;
            
        }


        // POST api/values
        [HttpPost]
        public void Post()
        {
        }
        [HttpGet("Test")]
        public string Test()
        {
            return "Hello world";
        }

        // PUT api/values/5

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
