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
using API.Repository;
using Newtonsoft.Json;

namespace API.Controllers
{
    [RoutePrefix("api/machine")]
    public class MachineController : ApiController
    {

        private SCMSEntities db = new SCMSEntities();

        // GET: api/Machine
        public IEnumerable<CM_Machine> GetCM_Machine()
        {
            return db.CM_Machine;
        }

        [HttpGet]
        [Route("getname")]
        public HttpResponseMessage Get()
        {
            try
            {
                var mc = db.Proc_Machines().ToList();
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = new StringContent(JsonConvert.SerializeObject(mc));
                response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                return response;
            }
            catch (Exception)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        // GET: api/Machine/5
        [ResponseType(typeof(CM_Machine))]
        public async Task<IHttpActionResult> GetCM_Machine(int id)
        {
            CM_Machine cM_Machine = await db.CM_Machine.FindAsync(id);
            if (cM_Machine == null)
            {
                return NotFound();
            }

            return Ok(cM_Machine);
        }

        // PUT: api/Machine/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCM_Machine(int id, CM_Machine cM_Machine)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cM_Machine.id)
            {
                return BadRequest();
            }

            db.Entry(cM_Machine).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CM_MachineExists(id))
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

        // POST: api/Machine
        [ResponseType(typeof(CM_Machine))]
        public async Task<IHttpActionResult> PostCM_Machine(CM_Machine cM_Machine)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CM_Machine.Add(cM_Machine);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = cM_Machine.id }, cM_Machine);
        }

        // DELETE: api/Machine/5
        [ResponseType(typeof(CM_Machine))]
        public async Task<IHttpActionResult> DeleteCM_Machine(int id)
        {
            CM_Machine cM_Machine = await db.CM_Machine.FindAsync(id);
            if (cM_Machine == null)
            {
                return NotFound();
            }

            db.CM_Machine.Remove(cM_Machine);
            await db.SaveChangesAsync();

            return Ok(cM_Machine);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CM_MachineExists(int id)
        {
            return db.CM_Machine.Count(e => e.id == id) > 0;
        }
    }
}