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
using API.Models;
using Newtonsoft.Json;

namespace API.Controllers
{
    [RoutePrefix("api/zone")]
    public class ZoneController : ApiController
    {
        private SCMSEntities db = new SCMSEntities();


        [HttpGet]
        [Route("getname")]
        public HttpResponseMessage Get()
        {
            try
            {
                var obj = db.Proc_FindAll_CM_Zone().ToList();
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(obj));
                response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                return response;
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
        // GET: api/Zone
        public IQueryable<CM_Zone> GetCM_Zone()
        {
            return db.CM_Zone;
        }

        // GET: api/Zone/5
        [ResponseType(typeof(CM_Zone))]
        public async Task<IHttpActionResult> GetCM_Zone(int id)
        {
            CM_Zone cM_Zone = await db.CM_Zone.FindAsync(id);
            if (cM_Zone == null)
            {
                return NotFound();
            }

            return Ok(cM_Zone);
        }

        // PUT: api/Zone/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCM_Zone(int id, CM_Zone cM_Zone)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cM_Zone.id)
            {
                return BadRequest();
            }

            db.Entry(cM_Zone).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CM_ZoneExists(id))
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

        // POST: api/Zone
        [ResponseType(typeof(CM_Zone))]
        public async Task<IHttpActionResult> PostCM_Zone(CM_Zone cM_Zone)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CM_Zone.Add(cM_Zone);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = cM_Zone.id }, cM_Zone);
        }

        // DELETE: api/Zone/5
        [ResponseType(typeof(CM_Zone))]
        public async Task<IHttpActionResult> DeleteCM_Zone(int id)
        {
            CM_Zone cM_Zone = await db.CM_Zone.FindAsync(id);
            if (cM_Zone == null)
            {
                return NotFound();
            }

            db.CM_Zone.Remove(cM_Zone);
            await db.SaveChangesAsync();

            return Ok(cM_Zone);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CM_ZoneExists(int id)
        {
            return db.CM_Zone.Count(e => e.id == id) > 0;
        }
    }
}