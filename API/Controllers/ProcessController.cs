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
    [RoutePrefix("api/process")]
    public class ProcessController : ApiController
    {
        private SCMSEntities db = new SCMSEntities();

        [HttpGet]
        [Route("getname")]
        public HttpResponseMessage Get()
        {
            try
            {
                var obj = db.Proc_FindAll_CM_Process().ToList();
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
        // GET: api/Process
        public IQueryable<CM_Process> GetCM_Process()
        {
            return db.CM_Process;
        }

        // GET: api/Process/5
        [ResponseType(typeof(CM_Process))]
        public async Task<IHttpActionResult> GetCM_Process(int id)
        {
            CM_Process cM_Process = await db.CM_Process.FindAsync(id);
            if (cM_Process == null)
            {
                return NotFound();
            }

            return Ok(cM_Process);
        }

        // PUT: api/Process/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCM_Process(int id, CM_Process cM_Process)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cM_Process.id)
            {
                return BadRequest();
            }

            db.Entry(cM_Process).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CM_ProcessExists(id))
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

        // POST: api/Process
        [ResponseType(typeof(CM_Process))]
        public async Task<IHttpActionResult> PostCM_Process(CM_Process cM_Process)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CM_Process.Add(cM_Process);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = cM_Process.id }, cM_Process);
        }

        // DELETE: api/Process/5
        [ResponseType(typeof(CM_Process))]
        public async Task<IHttpActionResult> DeleteCM_Process(int id)
        {
            CM_Process cM_Process = await db.CM_Process.FindAsync(id);
            if (cM_Process == null)
            {
                return NotFound();
            }

            db.CM_Process.Remove(cM_Process);
            await db.SaveChangesAsync();

            return Ok(cM_Process);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CM_ProcessExists(int id)
        {
            return db.CM_Process.Count(e => e.id == id) > 0;
        }
    }
}