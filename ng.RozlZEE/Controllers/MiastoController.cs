using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ng.RozlZEE.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ng.RozlZEE.Controllers
{
    [AllowAnonymous]
    public class MiastoController : ApiController
    {
        private RozlZEEEntities db = new RozlZEEEntities();


        //mongo db tests
        public void MongoDB()
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            

        }
        
        // GET: api/Miasto
        [HttpGet]
        [Authorize]
        public IQueryable<Miasto> GetMiasto()
        {

            return db.Miasto;
        }

        // GET: api/Miasto/5
        [ResponseType(typeof(Miasto))]
        public IHttpActionResult GetMiasto(int id)
        {
            Miasto miasto = db.Miasto.Find(id);
            if (miasto == null)
            {
                return NotFound();
            }

            return Ok(miasto);
        }

        // PUT: api/Miasto/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutMiasto(int id, Miasto miasto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != miasto.Id)
            {
                return BadRequest();
            }

            db.Entry(miasto).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MiastoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Miasto
        [ResponseType(typeof(Miasto))]
        public async Task<IHttpActionResult> PostMiasto(Miasto miasto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Miasto.Add(miasto);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = miasto.Id }, miasto);
        }

        // DELETE: api/Miasto/5
        [ResponseType(typeof(Miasto))]
        public async Task<IHttpActionResult> DeleteMiasto(int id)
        {
            Miasto miasto = await db.Miasto.FindAsync(id);
            if (miasto == null)
            {
                return NotFound();
            }

            db.Miasto.Remove(miasto);
            await db.SaveChangesAsync();

            return Ok(miasto);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MiastoExists(int id)
        {
            return db.Miasto.Count(e => e.Id == id) > 0;
        }
    }
}