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
    public class User_DataController : ApiController
    {
        private WebApplication2Context db = new WebApplication2Context();

        // GET: api/User_Data
        public IQueryable<User_Data> GetUser_Data()
        {
            return db.User_Data;
        }

        // GET: api/User_Data/5
        [ResponseType(typeof(User_Data))]
        public async Task<IHttpActionResult> GetUser_Data(int id)
        {
            User_Data user_Data = await db.User_Data.FindAsync(id);
            if (user_Data == null)
            {
                return NotFound();
            }

            return Ok(user_Data);
        }
        
        // PUT: api/User_Data/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutUser_Data(int id, User_Data user_Data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user_Data.Id)
            {
                return BadRequest();
            }

            db.Entry(user_Data).State = EntityState.Modified;
            
            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!User_DataExists(id))
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

        // POST: api/User_Data
        [ResponseType(typeof(User_Data))]
        public async Task<IHttpActionResult> PostUser_Data(User_Data user_Data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.User_Data.Add(user_Data);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = user_Data.Id }, user_Data);
        }

        // DELETE: api/User_Data/5
        [ResponseType(typeof(User_Data))]
        public async Task<IHttpActionResult> DeleteUser_Data(int id)
        {
            User_Data user_Data = await db.User_Data.FindAsync(id);
            if (user_Data == null)
            {
                return NotFound();
            }

            db.User_Data.Remove(user_Data);
            await db.SaveChangesAsync();

            return Ok(user_Data);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool User_DataExists(int id)
        {
            return db.User_Data.Count(e => e.Id == id) > 0;
        }
    }
}