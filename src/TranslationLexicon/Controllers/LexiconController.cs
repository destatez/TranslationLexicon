using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TranslationLexicon.Models;

namespace TranslationLexicon.Controllers
{
    [Route("api/[controller]")]
    public class LexiconController:Controller
    {

        [HttpGet("GetAll")]
        public List<string> GetAll()
        {
            List<string> output = new List<string>();
            Db dbinterface = new Db();
            foreach(Entry e in dbinterface.Entries)
            {
                output.Add(e.Id);
            }
            return output;
        }
        [HttpGet("Get")]
        public Entry Get(string id)
        {
            Db dbinterface = new Db();
            return dbinterface.Entries.Where(e => e.Id == id).First();
        }
        [HttpPost("Save")]
        public void Save(string id,string definition)
        {
            Db dbinterface = new Db();
            Entry ent =  dbinterface.Entries.Where(e => e.Id == id).First();
            ent.Definition = definition;
            dbinterface.Update(ent);
            dbinterface.SaveChanges();
        }
        [HttpPost("Add")]
        public void Add(string id,string definition)
        {
            Db dbinterface = new Db();
            Entry ent = new Entry()
            {
                Id = id,
                Definition = definition
            };
            dbinterface.Entries.Add(ent);
            dbinterface.SaveChanges();
        }
    }
}
