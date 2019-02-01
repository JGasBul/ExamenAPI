using Examen_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Examen_Web.Controllers
{
    public class RecetasController : ApiController
    {
        // GET: api/Recetas
        public IEnumerable<Recetas> Get()
        {
            var repo = new RecetasRepository();
            List<Recetas> recetas = repo.Retrieve();
            return recetas;
        }

        // GET: api/Recetas/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Recetas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Recetas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Recetas/5
        public void Delete(int id)
        {
        }
    }
}
