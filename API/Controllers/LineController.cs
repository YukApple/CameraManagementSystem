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
    [RoutePrefix("api/line")]
    public class LineController : ApiController
    {
        private SCMSEntities db = new SCMSEntities();


        [HttpGet]
        [Route("getname")]
        public HttpResponseMessage Get()
        {
            try
            {
                var obj = db.Proc_FindAll_CM_Line().ToList();
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
        // GET: api/Line
        public IQueryable<CM_Line> GetCM_Line()
        {
            return db.CM_Line;
        }

        // GET: api/Line/5
        [ResponseType(typeof(CM_Line))]
        public async Task<IHttpActionResult> GetCM_Line(int id)
        {
            CM_Line cM_Line = await db.CM_Line.FindAsync(id);
            if (cM_Line == null)
            {
                return NotFound();
            }

            return Ok(cM_Line);
        }

        // PUT: api/Line/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCM_Line(int id, CM_Line cM_Line)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cM_Line.id)
            {
                return BadRequest();
            }

            db.Entry(cM_Line).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CM_LineExists(id))
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

        // POST: api/Line
        [ResponseType(typeof(CM_Line))]
        public async Task<IHttpActionResult> PostCM_Line(CM_Line cM_Line)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CM_Line.Add(cM_Line);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = cM_Line.id }, cM_Line);
        }

        // DELETE: api/Line/5
        [ResponseType(typeof(CM_Line))]
        public async Task<IHttpActionResult> DeleteCM_Line(int id)
        {
            CM_Line cM_Line = await db.CM_Line.FindAsync(id);
            if (cM_Line == null)
            {
                return NotFound();
            }

            db.CM_Line.Remove(cM_Line);
            await db.SaveChangesAsync();

            return Ok(cM_Line);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CM_LineExists(int id)
        {
            return db.CM_Line.Count(e => e.id == id) > 0;
        }
    }
}