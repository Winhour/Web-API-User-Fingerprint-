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
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class FingerprintsController : ApiController
    {
        private WebApplication2Context db = new WebApplication2Context();

        // GET: api/Fingerprints
        public IQueryable<Fingerprints> GetFingerprints()
        {
            return db.Fingerprints;
        }

        // GET: api/Fingerprints/5
        [ResponseType(typeof(Fingerprints))]
        public async Task<IHttpActionResult> GetFingerprints(int id)
        {
            Fingerprints fingerprints = await db.Fingerprints.FindAsync(id);
            if (fingerprints == null)
            {
                return NotFound();
            }

            return Ok(fingerprints);
        }

        // PUT: api/Fingerprints/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutFingerprints(int id, Fingerprints fingerprints)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fingerprints.Id)
            {
                return BadRequest();
            }

            db.Entry(fingerprints).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FingerprintsExists(id))
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

        // POST: api/Fingerprints
        [ResponseType(typeof(Fingerprints))]
        public async Task<IHttpActionResult> PostFingerprints(Fingerprints fingerprints)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Fingerprints.Add(fingerprints);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = fingerprints.Id }, fingerprints);
        }

        // DELETE: api/Fingerprints/5
        [ResponseType(typeof(Fingerprints))]
        public async Task<IHttpActionResult> DeleteFingerprints(int id)
        {
            Fingerprints fingerprints = await db.Fingerprints.FindAsync(id);
            if (fingerprints == null)
            {
                return NotFound();
            }

            db.Fingerprints.Remove(fingerprints);
            await db.SaveChangesAsync();

            return Ok(fingerprints);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FingerprintsExists(int id)
        {
            return db.Fingerprints.Count(e => e.Id == id) > 0;
        }
    }
}